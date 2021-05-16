using System;
using System.Collections;
using System.Net;
using System.Net.Sockets;

namespace RxjhServer.bbg
{
    /// <summary>
    /// AuthServer 的摘要说明。
    /// </summary>
    public class AuthServer
    {
        public static ArrayList clients;
        private string ip;
        private Socket listenSocket;
        private int port;
        public int totalReceive;
        public int totalSend;
        //ClientConnection connection1;

        public event MessageeDelegaterE OnSockMessage;

        // 方法
        /// <summary>
        /// 静态构造函数
        /// </summary>
        static AuthServer()
        {//声明定义动态数组
            AuthServer.clients = new ArrayList();
        }

        /// <summary>
        /// 带参数构造函数(3724端口验证服务的连接信息)
        /// </summary>
        /// <param name="i">域名或者ip</param>
        /// <param name="pt">端口</param>
        public AuthServer(string i, int pt)
        {
            //定义发送字节和并赋初值,目前程序保留未使用该变量
            this.totalSend = 0;
            //定义接受字节和并赋初值,目前程序保留未使用该变量
            this.totalReceive = 0;
            //域名或者ip
            this.ip = i;
            //端口号
            this.port = pt;
            //简单域名解析为ip并提供给容器变量
            //IPHostEntry entry1 = Dns.GetHostEntry(i);
            //将网络端点表示为 IP 地址和端口号。
            //IPEndPoint point1 = new IPEndPoint(entry1.AddressList[0], this.port);
            //获取 IP 地址的地址族。为listenSocket这个Socket新实例准备.
            //this.addressFamily = point1.Address.AddressFamily;
            //获取ip为控制台显示监听状态准备.
            //this.address = point1.Address;
            this.Start();
            //if (World.Keyk.CpuID != World.KeykF.CpuID || World.Keyk.DriveID != World.KeykF.DriveID || World.Keyk.IP != World.KeykF.IP || World.Keyk.Mac != World.KeykF.Mac)
            //{
            //    Environment.Exit(0);
            //}
            //else if (World.KeykF.IP.Length < 4 || World.KeykF.Mac.Length < 4 || World.Keyk.IP.Length < 4 || World.Keyk.Mac.Length < 4)
            //{
            //    Environment.Exit(0);
            //}
        }
        /// <summary>
        /// 关闭 Socket 连接并释放所有关联的资源。
        /// </summary>
        public void CloseServer()
        {//关闭 Socket 连接并释放所有关联的资源。
            this.listenSocket.Close();
        }
        /// <summary>
        /// 清理正在使用的资源，关闭正在运行的服务。
        /// </summary>
        public void Dispose()
        {
            while (AuthServer.clients.Count > 0)
            {//循环释放AuthServer.clients里每个连接所占用资源
                ((SockClienT)AuthServer.clients[0]).Dispose();
            }
            try
            {//禁用 listenSocket 上的发送和接收。(先禁用后关闭增加安全性,希望大家以后写Socket借鉴)
                this.listenSocket.Shutdown(SocketShutdown.Both);
            }
            catch
            {
                //未处理异常 中  国 源 码 网   ww w . zg y mw.com
            }
            if (this.listenSocket != null)
            {//关闭 listenSocket 连接并释放所有关联的资源。
                this.listenSocket.Close();
            }
        }

        /// <summary>
        /// 虚方法定义接受端口数据后的处理流程用以实现运行时动态多态性
        /// </summary>
        /// <param name="ar">异步操作状态</param>
        public virtual void OnAccept(IAsyncResult ar)
        {
            try
            {
                //异步接受传入的连接尝试，并创建新的 Socket 来处理远程主机通信
                Socket socket1 = this.listenSocket.EndAccept(ar);
                if (socket1 != null)
                {
                    ClientConnection connection1 = new ClientConnection(socket1, new RemoveClientDelegateE(this.RemoveClient));
                    AuthServer.clients.Add(connection1);
                    connection1.OnSockMessage += new MessageeDelegaterE(connection1_OnSockMessage);
                    connection1.Start();
                }
            }
            catch (Exception ex)
            {
                //未处理异常
                //Console.WriteLine("开始监听端口: {0}, 地址: {1}", this.port, this.address.ToString());
                Console.WriteLine("{0}", ex);

            }
            try
            {
                this.listenSocket.BeginAccept(new AsyncCallback(this.OnAccept), this.listenSocket);
            }
            catch
            {
                this.Dispose();
                return;
            }
        }


        /// <summary>
        /// 删除客户端连接
        /// </summary>
        /// <param name="client"></param>
        public void RemoveClient(SockClienT client)
        {
            //lock (AuthServer.clients.SyncRoot)
            using (Lock l = new Lock(AuthServer.clients, "RemoveClient")) //lock (thisLock3)
                AuthServer.clients.Remove(client);
        }

        /// <summary>
        /// 开始监听3724端口
        /// </summary>
        /// <returns></returns>
        public bool Start()
        {
            try
            {
                //初始化 Socket 类的新实例。
                this.listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                this.listenSocket.Bind(new IPEndPoint(IPAddress.Any, this.port));
                //Console.WriteLine("开始监听端口: {0}, 地址: {1}", this.port, this.address.ToString());
                Form1.WriteLine(5, "开始监听百宝端口" + this.port + " IP " + this.ip.ToString());

                //将 Socket 置于侦听状态并设定连接队列最大长度.
                this.listenSocket.Listen(10);
                this.listenSocket.BeginAccept(new AsyncCallback(this.OnAccept), this.listenSocket);
            }
            catch (Exception exception1)
            {
                Console.WriteLine("Failled to list on port {0}\n{1}", this.port, exception1.Message);
                Form1.WriteLine(1, "监听百宝端口出错 " + this.port + "   " + exception1.Message);
                this.listenSocket = null;
                return false;
            }
            return true;
        }

        private void connection1_OnSockMessage(object sender, SockClienT client)
        {
            RaiseMessageEvent(sender, client);
        }
        private void RaiseMessageEvent(object Msg, SockClienT client)
        {
            if (OnSockMessage != null)
                OnSockMessage(Msg, client);
        }
    }
}
