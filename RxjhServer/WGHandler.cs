using System;
using System.Net.Sockets;
using System.Text;

namespace RxjhServer
{
	public class WGHandler : WGSockClient
	{
		private string string_0;

		public string ServerId
		{
			get
			{
				return string_0;
			}
			set
			{
				string_0 = value;
			}
		}

		public void Logout()
		{
			Form1.WriteLine(3, "服务器以断开 ID：" + ServerId);
		}

		public WGHandler(Socket socket_0, RemoveWGClientDelegate removeWGClientDelegate_0)
			: base(socket_0, removeWGClientDelegate_0)
		{
		}

		public override byte[] ProcessDataReceived(byte[] data, int length)
		{
			try
			{
				int num = 0;
				if (170 == data[0] && 102 == data[1])
				{
					byte[] array = new byte[4];
					System.Buffer.BlockCopy(data, 2, array, 0, 4);
					int num2 = Buffer.ToInt32(array, 0);
					if (length < num2 + 6)
					{
						return null;
					}
					while (true)
					{
						byte[] array2 = new byte[num2];
						System.Buffer.BlockCopy(data, num + 6, array2, 0, num2);
						num += num2 + 6;
						DataReceived(array2, num2);
						if (num >= length || data[num] != 170 || data[num + 1] != 102)
						{
							break;
						}
						System.Buffer.BlockCopy(data, num + 2, array, 0, 4);
						num2 = Buffer.ToInt16(array, 0);
					}
				}
				else
				{
					Form1.WriteLine(1, "错包：" + data[0] + " " + data[1]);
				}
				return null;
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "出错：" + ex.Message);
				Console.WriteLine(ex.Message);
				Console.WriteLine(ex.Source);
				Console.WriteLine(ex.StackTrace);
				return null;
			}
		}

		public byte[] DataReceived(byte[] byte_0, int int_0)
		{
			try
			{
				string @string = Encoding.Default.GetString(byte_0);
				Form1.WriteLine(3, "帐号验证收到：" + @string);
				string[] array = @string.Split('|');
				string text = array[0];
				if (text != null && text == "服务器连接登陆")
				{
					ServerId = array[1];
					World.端口更换通知(ServerId);
					Form1.WriteLine(3, "服务器连接成功 ID：" + array[1]);
				}
				return null;
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "出错：" + ex.Message);
				Console.WriteLine(ex.Message);
				Console.WriteLine(ex.Source);
				Console.WriteLine(ex.StackTrace);
				return null;
			}
		}
	}
}
