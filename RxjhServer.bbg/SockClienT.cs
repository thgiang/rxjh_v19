using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using RxjhServer.HelperTools;
using System.Threading;

namespace RxjhServer.bbg
{
    /// <summary>
    /// SockClienT 的摘要说明。
    /// </summary>
    public class SockClienT
    {
        #region 域
        // 域
        public Socket clientSocket;
        private byte[] dataReceive;
        private bool disposed;
        private MemoryStream ms;
        private RemoveClientDelegateE removeFromTheServerList;
        public event MessageeDelegaterE OnSockMessage;

        #endregion
        #region 属性
        // 属性
        public bool Disposed
        {
            get
            {
                return this.disposed;
            }
        }
        public IPAddress IP
        {
            get
            {
                try
                {
                    if (this.disposed)
                    {
                        return null;
                    }
                    return ((IPEndPoint)this.clientSocket.RemoteEndPoint).Address;
                }
                catch
                {
                    this.Dispose();
                }
                return null;
            }
        }
        #endregion
        #region 方法
        // 方法
        public SockClienT(Socket from, RemoveClientDelegateE rftsl)
        {
            this.dataReceive = new byte[1500];
            this.disposed = false;
            this.ms = new MemoryStream();
            this.removeFromTheServerList = rftsl;
            this.clientSocket = from;
        }

        public void Dispose()
        {
            if (!this.disposed)
            {
                this.disposed = true;
                try
                {
                    if (this.removeFromTheServerList != null)
                    {
                        this.removeFromTheServerList(this);
                    }
                    this.clientSocket.Shutdown(SocketShutdown.Both);
                }
                catch
                {
                }
                if (this.clientSocket != null)
                {
                    this.clientSocket.Close();
                }
                this.clientSocket = null;

            }
        }

        public virtual void OnReceiveData(IAsyncResult ar)
        {
            try
            {
                if (this.disposed)
                {
                    return;
                }
                int num1 = this.clientSocket.EndReceive(ar);

                if (num1 <= 0)
                {
                    //RaiseMessageEvent("用户退出["+Userid+"]-["+Username+"]");
                    this.Dispose();
                }
                else
                {//运行时多态性分别调用-验证,游戏,网页
                    this.ProcessDataReceived(this.dataReceive, num1);
                    //					if (buffer1 != null)
                    //					{//多态回call
                    //						this.clientSocket.BeginSend(buffer1, 0, buffer1.Length, SocketFlags.None, new AsyncCallback(this.OnSended), this);
                    //					}
                    //					else
                    //					{
                    //						this.clientSocket.BeginReceive(this.dataReceive, 0, this.dataReceive.Length, SocketFlags.None, new AsyncCallback(this.OnReceiveData), this);
                    //					}
                    this.Dispose();
                }
            }
            catch (Exception)
            {
                //log.ErrLog(ex);
                this.Dispose();
            }
        }

        public void OnSended(IAsyncResult ar)
        {
            try
            {
                if (this.disposed)
                {
                    return;
                }
                this.clientSocket.EndSend(ar);
                this.clientSocket.BeginReceive((ar.AsyncState as SockClienT).dataReceive, 0, (ar.AsyncState as SockClienT).dataReceive.Length, SocketFlags.None, new AsyncCallback(this.OnReceiveData), ar.AsyncState);
            }
            catch
            {
                this.Dispose();
            }
        }

        public void OnSended2(IAsyncResult ar)
        {
            try
            {
                if (this.disposed)
                {
                    return;
                }
                this.clientSocket.EndSend(ar);
            }
            catch (Exception)
            {
                this.Dispose();
            }
        }

        public virtual void ProcessDataReceived(byte[] data, int length)
        {

        }
        public virtual void Sendd(string str)
        {
            //Thread.Sleep(50);
            byte[] Rxjh_Name = System.Text.Encoding.Default.GetBytes(str);
            Send(Rxjh_Name, Rxjh_Name.Length);
        }

        public virtual void Send(string str)
        {
            try
            {
                int num1 = 0;
                if (this.disposed)
                {
                    return;
                }
                byte[] buffer1 = new byte[str.Length];
                Converter.ToBytes(str, buffer1, ref num1);
                this.clientSocket.BeginSend(buffer1, 0, num1, SocketFlags.None, new AsyncCallback(this.OnSended2), this);
            }
            catch (Exception)
            {
                this.Dispose();
            }
        }

        public virtual void Send(byte[] toSendBuff, int len)
        {
            try
            {
                if (this.disposed)
                {
                    return;
                }

                byte[] buffer1 = new byte[len + 6];
                buffer1[0] = 170;
                buffer1[1] = 102;
                System.Buffer.BlockCopy(System.BitConverter.GetBytes(len), 0, buffer1, 2, 4);
                System.Buffer.BlockCopy(toSendBuff, 0, buffer1, 6, len);
                this.clientSocket.BeginSend(buffer1, 0, buffer1.Length, SocketFlags.None, new AsyncCallback(this.OnSended2), this);


                //byte[] buffer1 = new byte[len];
                //Buffer.BlockCopy(toSendBuff, 0, buffer1, 0, len);
                //this.clientSocket.BeginSend(buffer1, 0, len, SocketFlags.None, new AsyncCallback(this.OnSended2), this);
            }
            catch (Exception)
            {
                this.Dispose();
            }
        }

        public virtual void Send(char[] toSendBuff, int len)
        {
            try
            {
                if (this.disposed)
                {
                    return;
                }
                byte[] buffer1 = new byte[len];
                System.Buffer.BlockCopy(toSendBuff, 0, buffer1, 0, len);
                this.clientSocket.BeginSend(buffer1, 0, len, SocketFlags.None, new AsyncCallback(this.OnSended2), this);
            }
            catch (Exception)
            {
                this.Dispose();
            }
        }

        public virtual void Send(byte[] toSendBuff, int offset, int len)
        {
            try
            {
                if (this.disposed)
                {
                    return;
                }

                byte[] buffer1 = new byte[len];
                System.Buffer.BlockCopy(toSendBuff, offset, buffer1, 0, len);
                if (this.disposed)
                {
                    return;
                }
                this.clientSocket.BeginSend(buffer1, 0, len, SocketFlags.None, new AsyncCallback(this.OnSended2), this);
            }
            catch (Exception)
            {
                this.Dispose();
            }
        }

        public void Start()
        {
            this.clientSocket.BeginReceive(this.dataReceive, 0, this.dataReceive.Length, SocketFlags.None, new AsyncCallback(this.OnReceiveData), this);
        }

        /// <summary>
        /// 产生发送一般消息的事件
        /// </summary>
        /// <param name="Msg">消息</param>
        public void RaiseMessageEvent(string Msg)
        {
            if (OnSockMessage != null)
                OnSockMessage(Msg, this);
        }

        #endregion
    }
}
