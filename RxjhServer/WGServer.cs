using System;
using System.Collections;
using System.Net;
using System.Net.Sockets;

namespace RxjhServer
{
	public class WGServer
	{
		public static ArrayList clients = new ArrayList();

		private IPAddress ipaddress_0;

		private AddressFamily addressFamily_0;

		private string string_0;

		private Socket socket_0;

		private int int_0;

		public int totalReceive;

		public int totalSend;

		public WGServer(string string_1, int int_1)
		{
			totalSend = 0;
			totalReceive = 0;
			string_0 = string_1;
			int_0 = int_1;
			IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Any, int_0);
			addressFamily_0 = iPEndPoint.Address.AddressFamily;
			ipaddress_0 = iPEndPoint.Address;
		}

		public void Dispose()
		{
			while (clients.Count > 0)
			{
				((WGSockClient)clients[0]).Dispose();
			}
			try
			{
				socket_0.Shutdown(SocketShutdown.Both);
			}
			catch
			{
			}
			if (socket_0 != null)
			{
				socket_0.Close();
			}
		}

		public virtual void OnAccept(IAsyncResult iasyncResult_0)
		{
			try
			{
				Socket socket = socket_0.EndAccept(iasyncResult_0);
				if (socket != null)
				{
					WGHandler wGHandler = new WGHandler(socket, RemoveClient);
					lock (clients.SyncRoot)
					{
						clients.Add(wGHandler);
					}
					wGHandler.Start();
				}
			}
			catch
			{
			}
			try
			{
				socket_0.BeginAccept(OnAccept, socket_0);
			}
			catch
			{
				Dispose();
			}
		}

		public void RemoveClient(WGSockClient wgsockClient_0)
		{
			(wgsockClient_0 as WGHandler).Logout();
			lock (clients.SyncRoot)
			{
				clients.Remove(wgsockClient_0);
			}
		}

		public bool Start()
		{
			try
			{
				socket_0 = new Socket(addressFamily_0, SocketType.Stream, ProtocolType.Tcp);
				socket_0.Bind(new IPEndPoint(IPAddress.Any, int_0));
				Form1.WriteLine(1, "开始监听网关服务端口:" + int_0 + " 地址:" + ipaddress_0.ToString());
				socket_0.Listen(1000);
				socket_0.BeginAccept(OnAccept, socket_0);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Failled to list on port {0}\n{1}", int_0, ex.Message);
				socket_0 = null;
				return false;
			}
			return true;
		}
	}
}
