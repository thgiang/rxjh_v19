using System;
using System.Timers;

namespace RxjhServer.Network
{
	public class NetState : IDisposable
	{
		public byte[] g_cur_key = new byte[32]
		{
			4,
			55,
			194,
			8,
			236,
			235,
			63,
			151,
			52,
			131,
			91,
			17,
			67,
			248,
			106,
			144,
			193,
			231,
			211,
			232,
			92,
			237,
			241,
			255,
			89,
			139,
			13,
			129,
			51,
			65,
			89,
			137
		};

		public int Key2 = 2138432278;

		public DateTime Ljtime = DateTime.Now;

		private IntPtr _ConnId = IntPtr.Zero;

		private string _绑定帐号 = string.Empty;

		private string _port = string.Empty;

		public bool 在线;

		public bool 登陆;

		public bool 加密;

		public bool 断开;

		private TcpServer Server;

		private int _WorldId;

		private bool _挂机;

		private Players _Player;

		public ByteQueue m_Buffer;

		private bool m_Running;

		private string m_ToString;

		public bool 版本验证;

		private System.Timers.Timer _自动断开;

		public int dwStop;

		public bool 退出;

		public IntPtr ConnId
		{
			get
			{
				return _ConnId;
			}
			set
			{
				_ConnId = value;
			}
		}

		public int WorldId
		{
			get
			{
				return _WorldId;
			}
			set
			{
				_WorldId = value;
			}
		}

		public bool 挂机
		{
			get
			{
				return _挂机;
			}
			set
			{
				_挂机 = value;
			}
		}

		public string 绑定帐号
		{
			get
			{
				return _绑定帐号;
			}
			set
			{
				_绑定帐号 = value;
			}
		}

		public Players Player
		{
			get
			{
				return _Player;
			}
			set
			{
				_Player = value;
			}
		}

		private ByteQueue mBuffer
		{
			get
			{
				return m_Buffer;
			}
		}

		public bool Running
		{
			get
			{
				return m_Running;
			}
			set
			{
				m_Running = value;
			}
		}

		public System.Timers.Timer 自动断开
		{
			get
			{
				return _自动断开;
			}
			set
			{
				_自动断开 = value;
			}
		}

		public string port
		{
			get
			{
				return _port;
			}
			set
			{
				_port = value;
			}
		}

		public override string ToString()
		{
			return m_ToString;
		}

		public void delWorldIdd(int WId)
		{
			try
			{
				if (World.InConnectList(WId))
				{
					World.list[WId] = null;
					World.list.Remove(WId);
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "delWorldIdd()出错" + WorldId + "|" + ToString() + " " + ex.Message);
			}
		}

		~NetState()
		{
		}

		public NetState(ClientInfo Ci)
		{
			try
			{
				ConnId = Ci.ConnId;
				Server = Ci.Server;
				Ljtime = DateTime.Now;
				挂机 = false;
				m_Buffer = new ByteQueue();
				m_Running = false;
				断开 = false;
				m_ToString = Ci.IpAddress;
				port = Ci.Port.ToString();
				WorldId = Ci.WorldId;
				if (!World.InConnectList(WorldId))
				{
					World.list.Add(WorldId, this);
				}
				else
				{
					Form1.WriteLine(3, WorldId + " 断开卡号连接 " + m_ToString + ":" + port);
					Server.Disconnect(ConnId);
				}
				Player = new Players(this);
				自动断开 = new System.Timers.Timer(3000.0);
				自动断开.Elapsed += 自动断开事件;
				自动断开.AutoReset = true;
				自动断开.Enabled = true;
				Form1.WriteLine(3, "连接 连接ID[" + ConnId.ToInt32() + "]-全服ID[" + WorldId + "]-IP地址[" + m_ToString + ":" + port + "]");
			}
			catch (Exception ex)
			{
				Server.Disconnect(ConnId);
				Form1.WriteLine(3, WorldId + " 初始化客户端连接出错 " + m_ToString + ":" + port + "|" + ex.Message);
			}
		}

		private void 自动断开事件(object sender, ElapsedEventArgs e)
		{
			if (!版本验证)
			{
				Form1.WriteLine(1, WorldId + " 自动断开事件 " + ToString());
				Dispose(true);
			}
			if (自动断开 != null)
			{
				自动断开.Enabled = false;
				自动断开.Close();
				自动断开.Dispose();
				自动断开 = null;
			}
		}

		private void reflashClient()
		{
			Server.SetConnectionExtra(ConnId, new ClientInfo
			{
				ConnId = ConnId,
				IpAddress = ToString(),
				Port = ushort.Parse(port),
				Server = Server,
				WorldId = WorldId,
				Client = this
			});
		}

		public void Start()
		{
			if (Player != null)
			{
				m_Running = true;
				reflashClient();
			}
		}

		public void IDout()
		{
			try
			{
				if (Player != null)
				{
					World.conn.发送("用户登出|" + Player.Userid + "|" + World.服务器ID);
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "IDout()出错" + WorldId + "|" + ToString() + " " + ex.Message);
			}
		}

		public void HandleReceive(NetState ns)
		{
			try
			{
				if (mBuffer != null && mBuffer.Length > 0)
				{
					using (new Lock(mBuffer, "HandleReceive"))
					{
						int length = mBuffer.Length;
						while (true)
						{
							if (length <= 0 || !Running || length <= 4)
							{
								return;
							}
							int num = Buffer.ToInt16(mBuffer.GetPacketID(), 0);
							if (num <= 0)
							{
								mBuffer.Clear();
								return;
							}
							int num2 = num + 6;
							if (length < num2)
							{
								break;
							}
							byte[] array = new byte[num2];
							mBuffer.Dequeue(array, 0, num2);
							length = mBuffer.Length;
							if (170 != array[0] || 85 != array[1])
							{
								mBuffer.Clear();
								return;
							}
							if (array[num2 - 2] != 85 || array[num2 - 1] != 170)
							{
								mBuffer.Clear();
								return;
							}
							Player.ManagePacket(array, array.Length);
						}
						if (170 != mBuffer.m_Buffer[0] && 85 != mBuffer.m_Buffer[1])
						{
							mBuffer.Clear();
						}
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "HandleReceive()出错" + WorldId + "|" + ToString() + " " + ((ex != null) ? ex.ToString() : null));
				Server.Disconnect(ConnId);
			}
		}

		public void Send(byte[] bytes, int len)
		{
			if (m_Running && !挂机)
			{
				Server.Send(ConnId, bytes, len);
			}
		}

		public void Send单包(byte[] toSendBuff, int len)
		{
			byte[] array = new byte[Buffer.ToInt16(toSendBuff, 9) + 7];
			System.Buffer.BlockCopy(toSendBuff, 5, array, 0, array.Length);
			Send单包封装发送(array, array.Length);
		}

		private void Send单包封装发送(byte[] toSendBuff, int length)
		{
			byte[] array = new byte[length + 15];
			array[0] = 170;
			array[1] = 85;
			System.Buffer.BlockCopy(Buffer.GetBytes(length + 9), 0, array, 2, 2);
			System.Buffer.BlockCopy(toSendBuff, 0, array, 5, length);
			array[array.Length - 2] = 85;
			array[array.Length - 1] = 170;
			Send(array, array.Length);
		}

		public void Send多包(byte[] toSendBuff, int len)
		{
			byte[] array = new byte[Buffer.ToInt16(toSendBuff, 8) + 5];
			System.Buffer.BlockCopy(toSendBuff, 4, array, 0, array.Length);
			Send多包加密(array, array.Length, 1);
		}

		private void Send多包加密(byte[] toSendBuff, int length, int xl)
		{
			try
			{
				byte[] packetBuffer;
				int num = SendDuopak3(toSendBuff, length, out packetBuffer);
				byte[] array = new byte[num + 8];
				System.Buffer.BlockCopy(Buffer.GetBytes(192), 0, array, 0, 2);
				System.Buffer.BlockCopy(Buffer.GetBytes(num + 4), 0, array, 2, 2);
				System.Buffer.BlockCopy(Buffer.GetBytes(num), 0, array, 4, 2);
				System.Buffer.BlockCopy(Buffer.GetBytes(length), 0, array, 6, 2);
				System.Buffer.BlockCopy(packetBuffer, 0, array, 8, num);
				Send多包封装发送(array, array.Length, xl);
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "Send()_Send多包加密发送错误" + WorldId + "|" + ex.Message);
			}
		}

		private void Send多包封装发送(byte[] toSendBuff, int length, int xl)
		{
			byte[] array = new byte[length + 16];
			array[0] = 170;
			array[1] = 85;
			System.Buffer.BlockCopy(Buffer.GetBytes(length + 10), 0, array, 2, 2);
			System.Buffer.BlockCopy(Buffer.GetBytes(xl), 0, array, 4, 2);
			System.Buffer.BlockCopy(toSendBuff, 0, array, 6, length);
			array[array.Length - 2] = 85;
			array[array.Length - 1] = 170;
			Send(array, array.Length);
		}

		public void Offline()
		{
			if (Server.Disconnect(ConnId))
			{
				退出 = true;
				挂机 = true;
				World.离线数量++;
				Form1.WriteLine(3, WorldId + " 离线挂机 " + ToString());
			}
			else
			{
				Form1.WriteLine(3, WorldId + " 离线挂机错误 " + ToString());
			}
		}

		public void DisposedOffline()
		{
			try
			{
				int num = ConnId.ToInt32();
				int worldId = WorldId;
				string text = ToString();
				挂机 = false;
				退出 = true;
				m_Running = false;
				if (m_Buffer != null)
				{
					m_Buffer.Dispose();
					m_Buffer = null;
				}
				if (自动断开 != null)
				{
					自动断开.Enabled = false;
					自动断开.Close();
					自动断开.Dispose();
					自动断开 = null;
				}
				IDout();
				if (Player != null)
				{
					Player.Logout();
					Player.Dispose();
				}
				Players value;
				if (World.allConnectedChars.TryGetValue(WorldId, out value))
				{
					World.allConnectedChars.Remove(WorldId);
				}
				Player = null;
				delWorldIdd(WorldId);
				int num2 = 18;
				Form1.WriteLine(3, "退出挂机 连接ID[" + num + "]人物全服ID[" + worldId + "] IP地址[" + text + "] ExceStep:" + num2);
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, " ProcessDisposedOffline()出错" + WorldId + "|" + ToString() + " " + ex.Message);
			}
		}

		public void logout(SocketOperation enOperation, int errorCode)
		{
			int num = 0;
			try
			{
				num = 1;
				NetState value;
				if (World.list.TryGetValue(WorldId, out value))
				{
					num = 2;
					if (!挂机)
					{
						num = 3;
						int num2 = ConnId.ToInt32();
						int worldId = WorldId;
						string text = ToString() + ":" + port;
						挂机 = false;
						退出 = true;
						m_Running = false;
						num = 4;
						if (m_Buffer != null)
						{
							m_Buffer.Dispose();
							m_Buffer = null;
						}
						num = 5;
						if (自动断开 != null)
						{
							自动断开.Enabled = false;
							自动断开.Close();
							自动断开.Dispose();
							自动断开 = null;
						}
						num = 6;
						if (在线)
						{
							IDout();
							num = 7;
						}
						num = 8;
						if (Player != null)
						{
							num = 9;
							if (!Player.退出中)
							{
								num = 10;
								Player.Logout();
								num = 11;
							}
							num = 12;
							Player.Dispose();
							num = 13;
						}
						num = 14;
						Players value2;
						if (World.allConnectedChars.TryGetValue(WorldId, out value2))
						{
							num = 15;
							World.allConnectedChars.Remove(WorldId);
							num = 16;
						}
						num = 17;
						Player = null;
						delWorldIdd(WorldId);
						num = 18;
						Form1.WriteLine(3, "退出 连接ID[" + num2 + "]人物全服ID[" + worldId + "] IP地址[" + text + "] ExceStep:" + num);
					}
				}
			}
			catch
			{
				Form1.WriteLine(3, "退出错误 ExceStep:" + num);
			}
		}

		public void Dispose()
		{
			Dispose(true);
		}

		private void Dispose(bool flush)
		{
			try
			{
				if (!断开)
				{
					断开 = true;
					Server.Disconnect(ConnId);
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, " Dispose()出错" + WorldId + "|" + ToString() + " " + ex.Message);
			}
		}

		public void SendPak(发包类 pak, int id, int wordid)
		{
			try
			{
				byte[] array = pak.ToArray2(id, wordid);
				Send多包加密(array, array.Length, 1);
			}
			catch (Exception)
			{
			}
		}

		private int SendDuopak3(byte[] 进包, int 进包长, out byte[] packetBuffer)
		{
			packetBuffer = new byte[进包长 + 进包长 / 32 + 1];
			int 出包长 = 0;
			int 进包处理长 = 0;
			int i = 6;
			int num = 5;
			int j = 0;
			int num2 = 0;
			int num3 = 0;
			try
			{
				for (; i <= 进包长; i++)
				{
					while (num > 1 && i - num < 255)
					{
						for (; j < 255 && num + j < 进包长 && i + j < 进包长; j++)
						{
							if (进包[i + j] != 进包[num + j])
							{
								if (num2 >= 3)
								{
									if (进包[i] == 进包[num - 1] && i - num < 254)
									{
										num3 = 1;
									}
									else
									{
										OneByte(i, num, j, num2, 进包, ref 进包处理长, ref 出包长, ref packetBuffer);
										i = 进包处理长;
										num = 进包处理长;
										num3 = 0;
										num2 = 0;
									}
								}
								else
								{
									num2 = 0;
								}
								break;
							}
							num2++;
						}
						if (num2 >= 3 && (进包[i] != 进包[num - 1] || num3 == 0))
						{
							OneByte(i, num, j, num2, 进包, ref 进包处理长, ref 出包长, ref packetBuffer);
							i = 进包处理长;
							num = 进包处理长;
							num3 = 0;
						}
						j = 0;
						num2 = 0;
						num--;
					}
					num = i;
				}
				if (进包处理长 >= 进包长)
				{
					return 出包长;
				}
				int num4 = 进包长 - 进包处理长;
				if (num4 <= 32)
				{
					if (num4 <= 0)
					{
						return 出包长;
					}
					packetBuffer[出包长++] = (byte)(进包长 - 进包处理长 - 1);
					System.Buffer.BlockCopy(进包, 进包处理长, packetBuffer, 出包长, 进包长 - 进包处理长);
					出包长 += 进包长 - 进包处理长;
					return 出包长;
				}
				int outlength = 0;
				byte[] array = new byte[num4];
				System.Buffer.BlockCopy(进包, 进包处理长, array, 0, array.Length);
				byte[] array2 = SendDuopak(array, array.Length, out outlength);
				if (出包长 == 0)
				{
					packetBuffer = new byte[array2.Length];
				}
				System.Buffer.BlockCopy(array2, 0, packetBuffer, 出包长, outlength);
				出包长 += outlength;
				return 出包长;
			}
			catch (Exception value)
			{
				Console.WriteLine(value);
				return 出包长;
			}
		}

		private void OneByte(int j, int i, int n, int x, byte[] 进包, ref int 进包处理长, ref int 出包长, ref byte[] packetBuffer)
		{
			int num = j - 进包处理长;
			if (num > 32)
			{
				int outlength = 0;
				byte[] array = new byte[num];
				System.Buffer.BlockCopy(进包, 进包处理长, array, 0, array.Length);
				System.Buffer.BlockCopy(SendDuopak(array, array.Length, out outlength), 0, packetBuffer, 出包长, outlength);
				出包长 += outlength;
				进包处理长 += num;
			}
			else if (num > 0)
			{
				packetBuffer[出包长++] = (byte)(num - 1);
				System.Buffer.BlockCopy(进包, 进包处理长, packetBuffer, 出包长, j - 进包处理长);
				出包长 += j - 进包处理长;
				进包处理长 += j - 进包处理长;
			}
			int num2 = x - 2;
			if (num2 < 7)
			{
				packetBuffer[出包长++] = (byte)(num2 << 5);
				int num3 = j - i - 1;
				packetBuffer[出包长++] = (byte)num3;
			}
			else
			{
				packetBuffer[出包长++] = 224;
				int num4 = x - 2 - 7;
				packetBuffer[出包长++] = (byte)num4;
				int num5 = j - i - 1;
				packetBuffer[出包长++] = (byte)num5;
			}
			进包处理长 += x;
		}

		private byte[] SendDuopak(byte[] toSendBuff, int length, out int outlength)
		{
			try
			{
				int num = 10;
				int num2 = length / 10;
				while (length - num2 * num > 0 && length - num2 * num < 2)
				{
					num++;
					num2 = length / num;
				}
				if (length % num > 0)
				{
					num2++;
				}
				byte[] array = new byte[length + num2];
				int num3 = 0;
				int num4 = 0;
				int num5 = num;
				do
				{
					if (num3 + num5 < length)
					{
						array[num4] = (byte)(num5 - 1);
						System.Buffer.BlockCopy(toSendBuff, num3, array, num4 + 1, num5);
						num3 += num5;
						num4 += num5 + 1;
						num5 = num;
					}
					else
					{
						num5 = length - num3;
						array[num4] = (byte)(num5 - 1);
						System.Buffer.BlockCopy(toSendBuff, num3, array, num4 + 1, num5);
						num3 += num5;
						num4 += num5 + 1;
					}
				}
				while (num3 < length);
				outlength = num4;
				return array;
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "Send()SendDuopak" + WorldId + "|" + ex.Message);
				outlength = length;
				return toSendBuff;
			}
		}
	}
}
