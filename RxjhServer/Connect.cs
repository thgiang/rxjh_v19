using DNGuard;
using RxjhServer.HelperTools;
using RxjhServer.Network;
using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Timers;

namespace RxjhServer
{
	[SecureMethod]
	public class Connect
	{
		private System.Timers.Timer timer_0;

		private Socket socket_0;

		private byte[] dataReceive;

		public Connect()
		{
			dataReceive = new byte[102400];
			timer_0 = new System.Timers.Timer(5000.0);
			timer_0.Elapsed += timer_0_Elapsed;
			timer_0.AutoReset = true;
			timer_0.Enabled = true;
		}

		private void timer_0_Elapsed(object sender, ElapsedEventArgs e)
		{
			if (!socket_0.Connected)
			{
				Sestup();
			}
		}

		public void Sestup()
		{
			try
			{
				IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse(World.帐号验证服务器IP), World.帐号验证服务器端口);
				socket_0 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				socket_0.BeginConnect(remoteEP, method_0, socket_0);
			}
			catch (Exception ex)
			{
				Form1.WriteLine(2, "连接帐号验证服务器出错      " + World.帐号验证服务器端口 + "      IP      " + World.帐号验证服务器IP.ToString() + "      " + ex.Message);
			}
		}

		public void Dispose()
		{
			if (timer_0 != null)
			{
				timer_0.Enabled = false;
				timer_0.Close();
				timer_0.Dispose();
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
			socket_0 = null;
		}

		public void 复查用户登陆()
		{
			try
			{
				StringBuilder stringBuilder = new StringBuilder();
				foreach (NetState value9 in World.list.Values)
				{
					string value = "NULL";
					int value2 = 0;
					if (value9.挂机)
					{
						value2 = 1;
					}
					int value3 = 0;
					string value4 = string.Empty;
					string value5 = string.Empty;
					int value6 = 0;
					string value7 = string.Empty;
					string value8 = string.Empty;
					Players players = World.检查玩家世界ID(value9.WorldId);
					if (players != null)
					{
						value = players.UserName;
						value3 = players.原服务器序号;
						value4 = players.原服务器IP;
						value5 = players.原服务器端口.ToString();
						value6 = players.原服务器ID;
						value7 = players.银币广场服务器IP;
						value8 = players.银币广场服务器端口.ToString();
					}
					stringBuilder.Append(value9.Player.Userid);
					stringBuilder.Append("-");
					stringBuilder.Append(value9.ToString());
					stringBuilder.Append("-");
					stringBuilder.Append(value9.绑定帐号);
					stringBuilder.Append("-");
					stringBuilder.Append(value2);
					stringBuilder.Append("-");
					stringBuilder.Append(value);
					stringBuilder.Append("-");
					stringBuilder.Append(value3);
					stringBuilder.Append("-");
					stringBuilder.Append(value4);
					stringBuilder.Append("-");
					stringBuilder.Append(value5);
					stringBuilder.Append("-");
					stringBuilder.Append(value6);
					stringBuilder.Append("-");
					stringBuilder.Append(value7);
					stringBuilder.Append("-");
					stringBuilder.Append(value8);
					stringBuilder.Append("-");
					stringBuilder.Append(value9.WorldId);
					stringBuilder.Append(",");
				}
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Remove(stringBuilder.Length - 1, 1);
				}
				World.conn.发送("复查用户登陆|" + ((stringBuilder != null) ? stringBuilder.ToString() : null));
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "复查用户登陆      错误" + ex.Message);
			}
		}

		private void method_0(IAsyncResult iasyncResult_0)
		{
			try
			{
				((Socket)iasyncResult_0.AsyncState).EndConnect(iasyncResult_0);
				try
				{
					发送("服务器连接登陆|" + World.服务器ID + "|" + World.最大在线 + "|" + CRC32.GetEXECRC32());
					Form1.WriteLine(2, "帐号服务器连接成功      端口      " + World.帐号验证服务器端口 + "      IP      " + World.帐号验证服务器IP);
					socket_0.BeginReceive(dataReceive, 0, dataReceive.Length, SocketFlags.None, OnReceiveData, this);
					Thread.Sleep(500);
					发送("更新服务器端口|" + World.服务器ID + "|" + World.游戏服务器端口2);
					复查用户登陆();
				}
				catch (Exception ex)
				{
					Form1.WriteLine(1, "验证服务器ConnectCallback出错：" + ex.Message);
				}
			}
			catch (Exception ex2)
			{
				Form1.WriteLine(1, "帐号服务器连接出错：" + ex2.Message);
			}
		}

		public virtual void OnReceiveData(IAsyncResult iasyncResult_0)
		{
			try
			{
				int num = socket_0.EndReceive(iasyncResult_0);
				if (num > 0 && socket_0.Connected)
				{
					ProcessDataReceived(dataReceive, num);
					socket_0.BeginReceive(dataReceive, 0, dataReceive.Length, SocketFlags.None, OnReceiveData, this);
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "帐号服务器      接收出错：" + ex.Message);
			}
		}

		public static byte[] Compress(byte[] byte_0)
		{
			try
			{
				MemoryStream memoryStream = new MemoryStream();
				GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Compress, true);
				gZipStream.Write(byte_0, 0, byte_0.Length);
				gZipStream.Close();
				byte[] array = new byte[memoryStream.Length];
				memoryStream.Position = 0L;
				memoryStream.Read(array, 0, array.Length);
				memoryStream.Close();
				return array;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public static string CompressString(string string_0)
		{
			return Convert.ToBase64String(Compress(Encoding.GetEncoding("UTF-8").GetBytes(string_0)));
		}

		public void 发送(string string_0)
		{
			try
			{
				if (socket_0 != null && socket_0.Connected)
				{
					byte[] bytes = Encoding.Default.GetBytes(string_0);
					Send(bytes, bytes.Length);
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "验证服务器发送出错：" + string_0 + ex.Message);
			}
		}

		public virtual void Send(byte[] byte_0, int int_0)
		{
			try
			{
				byte[] array = new byte[int_0 + 6];
				array[0] = 204;
				array[1] = 153;
				System.Buffer.BlockCopy(Buffer.GetBytes(int_0), 0, array, 2, 4);
				System.Buffer.BlockCopy(byte_0, 0, array, 6, int_0);
				socket_0.BeginSend(array, 0, int_0 + 6, SocketFlags.None, OnSended2, this);
			}
			catch (SocketException ex)
			{
				Form1.WriteLine(1, "帐号服务器      发送出错：" + ex.Message);
			}
			catch (Exception ex2)
			{
				Form1.WriteLine(1, "帐号服务器      发送出错：" + ex2.Message);
			}
		}

		public void OnSended2(IAsyncResult iasyncResult_0)
		{
			try
			{
				socket_0.EndSend(iasyncResult_0);
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "帐号服务器      发送出错：" + ex.Message);
			}
		}

		public void ProcessDataReceived(byte[] byte_0, int int_0)
		{
			try
			{
				int num = 0;
				if (204 == byte_0[0] && 153 == byte_0[1])
				{
					byte[] array = new byte[4];
					System.Buffer.BlockCopy(byte_0, 2, array, 0, 4);
					int num2 = Buffer.ToInt32(array, 0);
					if (int_0 >= num2 + 6)
					{
						while (true)
						{
							byte[] array2 = new byte[num2];
							System.Buffer.BlockCopy(byte_0, num + 6, array2, 0, num2);
							num += num2 + 6;
							DataReceived(array2, num2);
							if (num >= int_0 || byte_0[num] != 204 || byte_0[num + 1] != 153)
							{
								break;
							}
							System.Buffer.BlockCopy(byte_0, num + 2, array, 0, 4);
							num2 = Buffer.ToInt16(array, 0);
						}
					}
				}
				else
				{
					Form1.WriteLine(1, "LoginServer错包：" + byte_0[0] + "      " + byte_0[1]);
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "出错：" + ex.Message);
				Console.WriteLine(ex.Message);
				Console.WriteLine(ex.Source);
				Console.WriteLine(ex.StackTrace);
			}
		}

		public void DataReceived(byte[] byte_0, int int_0)
		{
			string @string = Encoding.Default.GetString(byte_0);
			try
			{
				string[] array = @string.Split('|');
				string text = array[0];
				if (text != null)
				{
					switch (Class3.smethod_0(text))
					{
					case 293814719u:
						if (text == "开启宝盒")
						{
							开启宝盒(array[1], array[2], array[3]);
						}
						break;
					case 12574353u:
						if (text == "势力战掉线" && World.势力战掉线玩家 != null && !World.势力战掉线玩家.ContainsKey(array[1]))
						{
							World.势力战掉线玩家.Add(array[1], array[2]);
						}
						break;
					case 1115043000u:
						if (text == "狮吼功")
						{
							狮吼功(array[1], array[2], array[3]);
						}
						break;
					case 936733853u:
						if (text == "狮子吼")
						{
							NetState value2;
							if (Buffer.IsEquals(array[1], "OK"))
							{
								World.发送全服狮子吼消息广播数据(int.Parse(array[2]), array[3], int.Parse(array[4]), array[5], int.Parse(array[6]), int.Parse(array[7]), int.Parse(array[8]));
							}
							else if (World.list.TryGetValue(int.Parse(array[2]), out value2))
							{
								value2.Player.系统提示("狮子吼列队以满请等待.....");
							}
						}
						break;
					case 935011129u:
						if (text == "获取服务器列表")
						{
							Players players3 = World.检查玩家(array[1]);
							if (players3 != null)
							{
								for (int j = 2; j < array.Length - 1; j++)
								{
									players3.更新服务器列表(array[j]);
								}
							}
						}
						break;
					case 1613984784u:
						if (text == "移除势力战掉线" && World.势力战掉线玩家 != null && World.势力战掉线玩家.ContainsKey(array[1]))
						{
							World.势力战掉线玩家.Remove(array[1]);
						}
						break;
					case 1409266929u:
						if (text == "传音消息")
						{
							World.发送传音消息(int.Parse(array[1]), array[2], array[3], array[4], int.Parse(array[5]), array[6]);
						}
						break;
					case 1306863018u:
						if (text == "PK提示")
						{
							PK提示(array[1], array[2]);
						}
						break;
					case 1930274563u:
						if (text == "情侣提示")
						{
							情侣提示(array[1], array[2]);
						}
						break;
					case 1846846822u:
						if (text == "更新配置")
						{
							更新配置(array[1], array[2]);
						}
						break;
					case 1658660851u:
						if (text == "势力战进程")
						{
							World.势力战进程 = int.Parse(array[1]);
						}
						break;
					case 2048662807u:
						if (text == "势力战人数")
						{
							World.势力战正人数 = int.Parse(array[1]);
							World.势力战邪人数 = int.Parse(array[2]);
						}
						break;
					case 2045065696u:
						if (text == "帮派消息")
						{
							byte[] array2 = smethod_0(array[2]);
							World.发送帮派消息(array[1], array2, array2.Length);
						}
						break;
					case 2888238993u:
						if (text == "PVP")
						{
							for (int i = 1; i < array.Length; i++)
							{
								Players players2 = World.检查玩家name(array[i]);
								if (players2 != null)
								{
									players2.FLD_VIP = 1;
									players2.更新人物数据(players2);
								}
							}
						}
						break;
					case 2831938062u:
						if (text == "刷怪掉宝")
						{
							刷怪掉宝(array[1], array[2], array[3]);
						}
						break;
					case 2124471572u:
						if (text == "用户踢出" && array[1].Length != 0)
						{
							用户踢出(int.Parse(array[1]));
						}
						break;
					case 3264094646u:
						if (text == "帐号服务器断开连接" && socket_0 != null)
						{
							socket_0.Close();
						}
						break;
					case 2978865490u:
						if (text == "用户换线登陆")
						{
							Form1.WriteLine(1, "收到LS：" + @string);
							用户换线登陆(int.Parse(array[4]), array[1], array[2], array[3], array[7], array[8], array[9], array[10], array[11], array[12], array[13], array[6], array[14]);
						}
						break;
					case 2956427845u:
						if (text == "用户登陆")
						{
							用户登陆(int.Parse(array[2]), array[1], array[3], array[4], array[5], array[6], array[7], array[8], array[9]);
						}
						break;
					case 4253856169u:
						if (text == "OpClient")
						{
							try
							{
								Players players = World.检查玩家世界ID(int.Parse(array[1]));
								NetState value;
								if (players != null)
								{
									if (players.Client != null)
									{
										players.OpClient(int.Parse(array[2]));
									}
								}
								else if (World.list.TryGetValue(int.Parse(array[1]), out value))
								{
									if (value.Player != null)
									{
										value.Player.OpClient(int.Parse(array[2]));
									}
									else
									{
										byte[] array3 = Converter.hexStringToByte("AA5512000100BB00040001000000000000000000000055AA");
										System.Buffer.BlockCopy(Buffer.GetBytes(int.Parse(array[2])), 0, array3, 10, 2);
										System.Buffer.BlockCopy(Buffer.GetBytes(int.Parse(array[1])), 0, array3, 4, 2);
										value.Send(array3, array3.Length);
									}
								}
							}
							catch
							{
							}
						}
						break;
					case 4014676641u:
						if (text == "发送公告")
						{
							发送公告(int.Parse(array[1]), array[2]);
						}
						break;
					case 3727864345u:
						if (text == "用户踢出ID" && array[1].Length != 0)
						{
							用户踢出ID(array[1]);
						}
						break;
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "验证服务器接收出错：" + @string + ex.Message);
			}
		}

		private static byte[] smethod_0(string string_0)
		{
			string_0 = string_0.Replace("      ", string.Empty);
			if (string_0.Length % 2 != 0)
			{
				string_0 += "      ";
			}
			byte[] array = new byte[string_0.Length / 2];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = Convert.ToByte(string_0.Substring(i * 2, 2), 16);
			}
			return array;
		}

		public void 更新配置(string string_0, string string_1)
		{
			Players players = World.检查玩家(string_0);
			if (players != null)
			{
				if (players.快捷栏.Contains(1008000044))
				{
					players.人物追加最大_HP += 300;
				}
				if (players.快捷栏.Contains(1008000045))
				{
					players.人物追加最大_MP += 200;
				}
				if (!players.是否更新配置)
				{
					byte[] array = Converter.hexStringToByte(string_1);
					System.Buffer.BlockCopy(Buffer.GetBytes(players.人物全服ID), 0, array, 4, 2);
					players.换线更新配置(array, array.Length);
				}
				players.客户端设置 = string_1;
				players.更新HP_MP_SP();
			}
		}

		public void 用户登陆(int int_0, string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6, string string_7)
		{
			try
			{
				NetState value;
				if (World.list.TryGetValue(int_0, out value))
				{
					value.Player.连接登陆2(string_0, string_1, string_2, string_3, string_4, string_5, string_6, string_7);
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "验证服务器用户登陆出错：" + ex.Message);
			}
		}

		public void 用户换线登陆(int int_0, string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6, string string_7, string string_8, string string_9, string string_10, string string_11)
		{
			try
			{
				NetState value;
				if (World.list.TryGetValue(int_0, out value))
				{
					value.Player.换线账号登陆(string_0, int.Parse(string_1), int.Parse(string_2), int_0, string_3, string_4, string_5, string_6, string_7, string_8, string_9, string_10, string_11);
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "验证用户换线登陆：" + ex.Message);
			}
		}

		public void 狮吼功(string string_0, string string_1, string string_2)
		{
			try
			{
				foreach (Players value in World.allConnectedChars.Values)
				{
					if (value != null)
					{
						value.系统提示(string_1, 21, string_0 + "：线路：" + string_2 + "线");
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "发送狮吼功出错：" + ex.Message);
			}
		}

		public void 刷怪掉宝(string string_0, string string_1, string string_2)
		{
			try
			{
				World.全局提示("刷怪掉宝:线路:" + string_2 + "线", 22, string_1);
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "发送刷怪掉宝出错：" + ex.Message);
			}
		}

		public void 情侣提示(string string_0, string string_1)
		{
			try
			{
				World.全局提示("情侣提示:", 20, string_1);
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "发送刷怪掉宝出错：" + ex.Message);
			}
		}

		public void PK提示(string string_0, string string_1)
		{
			try
			{
				World.全局提示("PK提示:", 24, string_1);
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "发送刷怪掉宝出错：" + ex.Message);
			}
		}

		public void 开启宝盒(string string_0, string string_1, string string_2)
		{
			try
			{
				World.全局提示("开启宝盒:线路:" + string_2 + "线", 22, string_1);
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "发送开启宝盒出错：" + ex.Message);
			}
		}

		public void 发送公告(int int_0, string string_0)
		{
			try
			{
				foreach (Players value in World.allConnectedChars.Values)
				{
					if (value != null)
					{
						switch (int_0)
						{
						case 0:
							value.系统公告(string_0);
							break;
						case 1:
							value.系统滚动公告(string_0);
							break;
						case 2:
							value.系统提示(string_0, 10, "系统提示");
							break;
						}
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "发送公告出错：" + ex.Message);
			}
		}

		public void 用户踢出(int int_0)
		{
			try
			{
				Players players = World.检查玩家世界ID(int_0);
				string text = string.Empty;
				string text2 = string.Empty;
				string text3 = string.Empty;
				if (players != null)
				{
					text = players.Userid;
					text2 = players.UserName;
					text3 = players.Client.ToString();
					if (players.Client.挂机)
					{
						players.Client.DisposedOffline();
						World.离线数量--;
						if (World.离线数量 < 0)
						{
							World.离线数量 = 0;
						}
					}
					else
					{
						players.kickidlog("用户踢出()");
						players.OpClient(1);
						players.Logout();
						players.Client.Dispose();
					}
				}
				NetState value;
				if (World.list.TryGetValue(int_0, out value))
				{
					value.delWorldIdd(int_0);
					value.Dispose();
				}
				Form1.WriteLine(3, "用户踢出      [" + text + "]-[" + text2 + "]" + text3);
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "验证服务器用户踢出出错：" + int_0 + "      " + ex.Message);
			}
		}

		public void 用户踢出ID(string string_0)
		{
			try
			{
				Players players = World.检查玩家(string_0);
				if (players != null)
				{
					string userid = players.Userid;
					string userName = players.UserName;
					players.Client.ToString();
					if (players.Client.挂机)
					{
						players.Client.DisposedOffline();
						World.离线数量--;
						if (World.离线数量 < 0)
						{
							World.离线数量 = 0;
						}
					}
					else
					{
						players.OpClient(1);
						players.kickidlog("玩家重复登陆      -      用户踢出ID()");
						players.Logout();
						players.Client.Dispose();
					}
					World.conn.发送("踢出玩家ID|" + World.服务器ID + "|" + string_0);
					Form1.WriteLine(3, "玩家重复登陆      -      用户踢出ID      [" + players.Userid + "]-[" + players.UserName + "]" + players.Client.ToString());
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "验证服务器用户踢出出错：" + string_0 + "      " + ex.Message);
			}
		}
	}
}
