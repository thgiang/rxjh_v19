using System;
using System.Net.Sockets;
using System.Text;

namespace RxjhServer.bbg
{
	public class ClientConnection : SockClienT
	{
		public ClientConnection(Socket socket_0, RemoveClientDelegateE removeClientDelegateE_1)
			: base(socket_0, removeClientDelegateE_1)
		{
		}

		public void DataReceived(byte[] byte_1, int int_0)
		{
			if (World.jlMsg == 1)
			{
				Form1.WriteLine(0, "ProcessDataReceived()");
			}
			try
			{
				byte[] array = new byte[int_0];
				for (int i = 0; i < int_0; i++)
				{
					array[i] = byte_1[i];
				}
				string @string = Encoding.Default.GetString(array);
				string str = "-1";
				string[] array2 = @string.Split(',');
				string text = array2[0];
				if (text == null)
				{
					goto IL_0239;
				}
				if (text == "用户登陆超变态jc")
				{
					str = ((World.检查玩家(array2[1]) != null) ? "登陆成功" : "登陆失败");
				}
				else if (text != "查询超变百宝")
				{
					if (!(text == "购买超变百宝"))
					{
						goto IL_0239;
					}
					Players players = World.检查玩家(array2[1]);
					if (long.Parse(array2[4]) >= 0L && int.Parse(array2[3]) >= 1)
					{
						百宝阁类 value;
						if (players == null)
						{
							str = "-1";
						}
						else if (World.百宝阁属性物品类list.TryGetValue(int.Parse(array2[2]), out value))
						{
							str = players.百宝阁买卖东西(int.Parse(array2[2]), int.Parse(array2[3]), int.Parse(array2[4]), int.Parse(array2[5]), value.MAGIC0, value.MAGIC1, value.MAGIC2, value.MAGIC3, value.MAGIC4, value.中级魂, value.觉醒, value.进化, value.绑定, value.使用天数);
						}
					}
					else
					{
						str = "-1";
						players.Dispose();
					}
				}
				else
				{
					Players players2 = World.检查玩家(array2[1]);
					if (players2 == null)
					{
						str = "-1";
					}
					else if (array2[2] == "热血元宝")
					{
						players2.查百宝阁元宝数();
						str = players2.FLD_RXPIONT.ToString();
					}
					else if (array2[2] == "赠品元宝")
					{
						players2.查百宝阁元宝数();
						str = players2.FLD_RXPIONTX.ToString();
					}
					else if (array2[2] == "空位")
					{
						str = players2.得到包裹空位数().ToString();
					}
				}
				goto IL_023f;
				IL_023f:
				Sendd(str);
				goto end_IL_0016;
				IL_0239:
				str = "-1";
				goto IL_023f;
				end_IL_0016:;
			}
			catch (Exception)
			{
				Dispose();
			}
		}

		public override void ProcessDataReceived(byte[] byte_1, int int_0)
		{
			int num = 0;
			if (170 != byte_1[0] || 102 != byte_1[1])
			{
				Form1.WriteLine(1, "错包：" + byte_1[0] + " " + byte_1[1]);
				return;
			}
			byte[] array = new byte[4];
			System.Buffer.BlockCopy(byte_1, 2, array, 0, 4);
			int num2 = BitConverter.ToInt32(array, 0);
			if (int_0 < num2 + 6)
			{
				return;
			}
			while (true)
			{
				if (World.jlMsg == 1)
				{
					Form1.WriteLine(0, "ProcessDataReceived");
				}
				byte[] array2 = new byte[num2];
				System.Buffer.BlockCopy(byte_1, num + 6, array2, 0, num2);
				num += num2 + 6;
				DataReceived(array2, num2);
				if (num < int_0 && byte_1[num] == 170 && byte_1[num + 1] == 102)
				{
					System.Buffer.BlockCopy(byte_1, num + 2, array, 0, 4);
					num2 = BitConverter.ToInt16(array, 0);
					continue;
				}
				break;
			}
		}
	}
}
