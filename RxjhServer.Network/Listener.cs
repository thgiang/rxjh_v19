using System;
using System.Collections;
using System.Net;
using System.Runtime.InteropServices;

namespace RxjhServer.Network
{
	public class Listener
	{
		private delegate void ShowMsg(string string_0);

		private AppState appState_0 = AppState.Stoped;

		public TcpServer Server = new TcpServer();

		private ShowMsg showMsg_0;

		private bool bool_0;

		private void method_0()
		{
			showMsg_0 = method_6;
			Server.Event_2 += Server_OnPrepareListen;
			Server.Event_0 += Server_OnAccept;
			Server.Event_1 += Server_OnSend;
			Server.Event_3 += Server_OnReceive;
			Server.Event_4 += Server_OnClose;
			Server.Event_5 += Server_OnShutdown;
			method_5(AppState.Stoped);
		}

		public Listener(ushort ushort_0)
		{
			try
			{
				bool_0 = false;
				method_0();
				method_1(ushort_0);
			}
			catch (Exception ex)
			{
				method_5(AppState.Error);
				method_6(ex.Message);
			}
		}

		~Listener()
		{
		}

		private void method_1(ushort ushort_0)
		{
			try
			{
				method_5(AppState.Starting);
				Server.IpAddress = "0.0.0.0";
				Server.Port = ushort_0;
				Server.SendPolicy = ((World.MainServer == 1) ? SendPolicy.Safe : SendPolicy.Direct);
				if (!Server.Start(World.ServerIDStart))
				{
					method_5(AppState.Stoped);
					throw new Exception(string.Format("监听端口失败 -> {0}({1})", Server.ErrorMessage, Server.ErrorCode));
				}
				World.主Socket = true;
				World.游戏服务器端口2 = ushort_0;
				method_6(string.Format("开始监听端口 {0}:{1}", "0.0.0.0", ushort_0));
				World.conn.发送("更新服务器端口|" + World.服务器ID + "|" + Hasher.GetIP() + "|" + ushort_0 + "|" + World.是否加密 + "|" + World.加密密钥);
				method_5(AppState.Started);
			}
			catch (Exception ex)
			{
				method_6(ex.Message);
			}
		}

		public void Stop()
		{
			try
			{
				method_5(AppState.Stoping);
				World.主Socket = false;
				if (!bool_0)
				{
					if (Server.Stop())
					{
						method_5(AppState.Stoped);
						bool_0 = true;
					}
					else
					{
						method_6("停止通信服务出错");
					}
				}
			}
			catch (Exception ex)
			{
				method_6("停止通信服务出错2 " + ex.Message);
			}
		}

		public void Dispose()
		{
			try
			{
				Server.Destroy();
			}
			catch (Exception ex)
			{
				method_6("终止通信服务出错 " + ex.Message);
			}
		}

		private HandleResult Server_OnShutdown()
		{
			method_6("停止通信组件服务");
			return HandleResult.Ok;
		}

		private void method_2(IntPtr intptr_0)
		{
			try
			{
				if (!Server.Disconnect(intptr_0))
				{
					throw new Exception(string.Format("断开连接({0}) 错误", intptr_0));
				}
				method_6(string.Format("$({0}) 断开连接", intptr_0));
			}
			catch (Exception ex)
			{
				method_6(ex.Message);
			}
		}

		private HandleResult Server_OnPrepareListen(IntPtr intptr_0)
		{
			return HandleResult.Ok;
		}

		private ClientInfo method_3(IntPtr intptr_0, string string_0, ushort ushort_0)
		{
			try
			{
				return new ClientInfo
				{
					ConnId = intptr_0,
					IpAddress = string_0,
					Port = ushort_0,
					Server = Server,
					WorldId = method_4(string_0)
				};
			}
			catch
			{
			}
			return null;
		}

		private int method_4(string string_0)
		{
			bool flag = false;
			int num = World.服务器ID * 100;
			while (true)
			{
				NetState value;
				if (num < 65500)
				{
					if (!World.list.TryGetValue(num, out value) && num < 3000)
					{
						break;
					}
					num++;
					continue;
				}
				if (!flag)
				{
					for (int i = 300; i < 65500; i++)
					{
						if (!World.list.TryGetValue(i, out value))
						{
							return i;
						}
					}
				}
				return 0;
			}
			return num;
		}

		private static long smethod_0(string string_0)
		{
			char[] separator = new char[1]
			{
				'.'
			};
			string[] array = string_0.Split(separator);
			return (long.Parse(array[0]) << 24) | (long.Parse(array[1]) << 16) | (long.Parse(array[2]) << 8) | long.Parse(array[3]);
		}

		private HandleResult Server_OnAccept(IntPtr intptr_0, IntPtr intptr_1)
		{
			string string_ = string.Empty;
			ushort ushort_ = 0;
			if (Server.GetRemoteAddress(intptr_0, ref string_, ref ushort_))
			{
				if (World.封IP)
				{
					IPAddress iPAddress = new IPAddress((uint)IPAddress.HostToNetworkOrder((int)smethod_0(string_)));
					if (World.BipList.Contains(iPAddress))
					{
						if (World.断开连接)
						{
							method_2(intptr_0);
						}
						if (World.关闭连接)
						{
							Stop();
						}
					}
					DateTime value = DateTime.Now;
					int num = 0;
					foreach (NetState value2 in World.list.Values)
					{
						if (value2.ToString() == iPAddress.ToString())
						{
							value = value2.Ljtime;
							num++;
						}
					}
					if (num > World.游戏登陆端口最大连接数)
					{
						if ((int)DateTime.Now.Subtract(value).TotalMilliseconds < World.游戏登陆端口最大连接时间数)
						{
							Form1.WriteLine(1, "到达IP最大连接数" + iPAddress.ToString());
							if (World.加入过滤列表 && !World.BipList.Contains(iPAddress))
							{
								World.BipList.Add(iPAddress);
							}
							method_2(intptr_0);
							try
							{
								Queue queue = Queue.Synchronized(new Queue());
								foreach (NetState value3 in World.list.Values)
								{
									if (value3.ToString() == iPAddress.ToString())
									{
										queue.Enqueue(value3);
									}
								}
								while (queue.Count > 0)
								{
									((NetState)queue.Dequeue()).Dispose();
								}
							}
							catch
							{
							}
						}
					}
					else
					{
						ClientInfo clientInfo = method_3(intptr_0, string_, ushort_);
						if (Server.SetConnectionExtra(intptr_0, clientInfo))
						{
							new NetState(clientInfo).Start();
						}
						else
						{
							method_6(string.Format(" > [{0},OnAccept] -> SetConnectionExtra(connId, ci) Error", intptr_0));
						}
					}
				}
				else
				{
					ClientInfo clientInfo2 = method_3(intptr_0, string_, ushort_);
					if (Server.SetConnectionExtra(intptr_0, clientInfo2))
					{
						new NetState(clientInfo2).Start();
					}
					else
					{
						method_6(string.Format(" > [{0},OnAccept] -> SetConnectionExtra(connId, ci) Error", intptr_0));
					}
				}
			}
			else
			{
				method_6(string.Format(" > [{0},OnAccept] -> GetRemoteAddress(connId, ref ip, ref port) Error", intptr_0));
			}
			return HandleResult.Ok;
		}

		private HandleResult Server_OnSend(IntPtr intptr_0, byte[] byte_0)
		{
			World.发送速度 += byte_0.Length;
			return HandleResult.Ok;
		}

		private HandleResult Server_OnReceive(IntPtr intptr_0, byte[] byte_0)
		{
			try
			{
				IntPtr intptr_ = IntPtr.Zero;
				if (Server.GetConnectionExtra(intptr_0, ref intptr_))
				{
					ClientInfo clientInfo = (ClientInfo)Marshal.PtrToStructure(intptr_, typeof(ClientInfo));
					int num = byte_0.Length;
					if (num <= 0)
					{
						return HandleResult.Error;
					}
					World.接收速度 += num;
					using (new Lock(clientInfo.Client.m_Buffer, "this.m_Buffer"))
					{
						clientInfo.Client.m_Buffer.Enqueue(byte_0, 0, num);
					}
					clientInfo.Client.HandleReceive(clientInfo.Client);
				}
				return HandleResult.Ok;
			}
			catch (Exception)
			{
				return HandleResult.Error;
			}
		}

		private HandleResult Server_OnClose(IntPtr intptr_0, SocketOperation socketOperation_0, int int_0)
		{
			int num = 0;
			try
			{
				IntPtr intptr_ = IntPtr.Zero;
				if (Server.GetConnectionExtra(intptr_0, ref intptr_))
				{
					num = 1;
					((ClientInfo)Marshal.PtrToStructure(intptr_, typeof(ClientInfo))).Client.logout(socketOperation_0, int_0);
					num = 2;
				}
				if (int_0 == 0)
				{
					method_6(string.Format("[断开 连接ID:{0} ExceStep:{1}]", intptr_0, num));
				}
				else
				{
					method_6(string.Format("[断开 连接ID:{0} ExceStep:{1}] -> OP:{2},CODE:{3}", intptr_0, num, socketOperation_0, int_0));
				}
				num = 3;
				if (!Server.SetConnectionExtra(intptr_0, null))
				{
					num = 4;
					method_6(string.Format("[断开错误:SetConnectionExtra({0}, null) fail ExceStep:{1}] -> OP:{2},CODE:{3}", intptr_0, 4, socketOperation_0, int_0));
				}
			}
			catch (Exception ex)
			{
				method_6("断开错误 连接ID:" + intptr_0 + " OP:" + socketOperation_0.ToString() + " CODE:" + int_0 + " ExceStep:" + num + " ExceptionMsg:" + ex.Message);
			}
			return HandleResult.Ok;
		}

		private void method_5(AppState appState_1)
		{
			appState_0 = appState_1;
			World.SocketState = appState_0.ToString();
		}

		private void method_6(string string_0)
		{
			Form1.WriteLine(1, string_0);
		}
	}
}
