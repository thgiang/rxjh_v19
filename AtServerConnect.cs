using DNGuard;
using RxjhServer;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Timers;

[SecureMethod]
public class AtServerConnect
{
	private byte[] 数据包;

	private Socket socket_0;

	private System.Timers.Timer timer_0;

	public AtServerConnect()
	{
		数据包 = new byte[10240000];
		timer_0 = new System.Timers.Timer(5000.0);
		timer_0.Elapsed += timer_0_Elapsed;
		timer_0.AutoReset = true;
		timer_0.Enabled = true;
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

	private void method_0(IAsyncResult iasyncResult_0)
	{
		try
		{
			((Socket)iasyncResult_0.AsyncState).EndConnect(iasyncResult_0);
			try
			{
				Form1.WriteLine(2, "攻击伺服器连接成功 端口 " + World.AtPort + " IP " + World.帐号验证服务器IP);
				发送("攻击伺服器连接|" + World.游戏服务器端口2);
				socket_0.BeginReceive(数据包, 0, 数据包.Length, SocketFlags.None, OnReceiveData, this);
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "攻击伺服器ConnectCallback出错：" + ex.Message);
			}
		}
		catch (Exception ex2)
		{
			Form1.WriteLine(1, "攻击伺服器连接出错：" + ex2.Message);
		}
	}

	public virtual void OnReceiveData(IAsyncResult iasyncResult_0)
	{
		try
		{
			if (socket_0.EndReceive(iasyncResult_0) > 0)
			{
				socket_0.BeginReceive(数据包, 0, 数据包.Length, SocketFlags.None, OnReceiveData, this);
			}
		}
		catch (Exception ex)
		{
			Form1.WriteLine(1, "攻击伺服器接收出错：" + ex.Message);
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
			Form1.WriteLine(1, "攻击伺服器发送出错：" + ex.Message);
		}
	}

	public void ProcessDataReceived(byte[] byte_0, int int_0)
	{
		try
		{
			int num = 0;
			byte[] array = new byte[4];
			System.Buffer.BlockCopy(byte_0, 2, array, 0, 4);
			int num2 = BitConverter.ToInt32(array, 0);
			if (int_0 >= num2 + 6)
			{
				try
				{
					while (true)
					{
						byte[] array2 = new byte[num2];
						System.Buffer.BlockCopy(byte_0, num + 6, array2, 0, num2);
						num += num2 + 6;
						Players value;
						if ((array2[0] == 170 && array2[1] == 85 && num2 == 45 && !World.allConnectedChars.TryGetValue(BitConverter.ToInt16(array2, 5), out value)) || num >= int_0 || byte_0[num] != 170 || byte_0[num + 1] != 102)
						{
							break;
						}
						System.Buffer.BlockCopy(byte_0, num + 2, array, 0, 4);
						num2 = BitConverter.ToInt16(array, 0);
					}
				}
				catch
				{
				}
			}
		}
		catch (Exception ex)
		{
			Form1.WriteLine(1, "攻击确认发送出错：" + ex.Message);
		}
	}

	public virtual void Send(byte[] byte_0, int int_0)
	{
		try
		{
			byte[] array = new byte[int_0 + 6];
			array[0] = 170;
			array[1] = 102;
			System.Buffer.BlockCopy(BitConverter.GetBytes(int_0), 0, array, 2, 4);
			System.Buffer.BlockCopy(byte_0, 0, array, 6, int_0);
			socket_0.BeginSend(array, 0, int_0 + 6, SocketFlags.None, OnSended2, this);
		}
		catch (SocketException ex)
		{
			Form1.WriteLine(1, "攻击伺服器发送出错：" + ex.Message);
		}
		catch (Exception ex2)
		{
			Form1.WriteLine(1, "攻击伺服器发送出错：" + ex2.Message);
		}
	}

	public void Sestup()
	{
		try
		{
			IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse(World.帐号验证服务器IP), World.AtPort);
			socket_0 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			socket_0.UseOnlyOverlappedIO = true;
			socket_0.LingerState.Enabled = false;
			socket_0.ExclusiveAddressUse = false;
			socket_0.BeginConnect(remoteEP, method_0, socket_0);
		}
		catch (Exception ex)
		{
			Form1.WriteLine(2, "连接攻击伺服器出错 " + World.帐号验证服务器端口 + " IP " + World.帐号验证服务器IP.ToString() + " " + ex.Message);
		}
	}

	private void timer_0_Elapsed(object sender, ElapsedEventArgs e)
	{
		if (!socket_0.Connected)
		{
			Sestup();
		}
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
			Form1.WriteLine(1, "攻击伺服器发送出错：" + string_0 + ex.Message);
		}
	}
}
