using RxjhServer.DbClss;
using RxjhServer.HelperTools;
using System;

namespace RxjhServer
{
	public class MissionClass : IDisposable
	{
		private Players Play;

		public MissionClass(Players Playr)
		{
			Play = Playr;
		}

		~MissionClass()
		{
		}

		public void Dispose()
		{
			Play = null;
		}

		public void 任务(byte[] data, int length)
		{
			Play.封包修改(data, length);
			int num = BitConverter.ToUInt16(data, 10);
			int num2 = BitConverter.ToUInt16(data, 12);
			int 任务阶段ID = BitConverter.ToInt16(data, 14);
			switch (num)
			{
			case 12:
				任务12(num, num2, 任务阶段ID);
				return;
			case 11:
				任务11(num, num2, 任务阶段ID);
				return;
			case 45:
				任务45(num, num2, 任务阶段ID);
				return;
			case 18:
				任务18(num, num2, 任务阶段ID);
				return;
			case 73:
				任务73(num, num2, 任务阶段ID);
				return;
			case 46:
				任务46(num, num2, 任务阶段ID);
				return;
			case 300:
				任务300(num, num2, 任务阶段ID);
				return;
			case 178:
				任务178(num, num2, 任务阶段ID);
				return;
			case 74:
				任务74(num, num2, 任务阶段ID);
				return;
			case 301:
				任务301(num, num2, 任务阶段ID);
				return;
			case 400:
			case 401:
			case 402:
			case 403:
			case 404:
			case 405:
			case 406:
			case 407:
			case 408:
			case 410:
				任务八转(num, num2, 任务阶段ID);
				return;
			case 748:
			case 749:
			case 750:
				任务十转(num, num2, 任务阶段ID);
				return;
			case 615:
			case 617:
			case 620:
				任务九转(num, num2, 任务阶段ID);
				return;
			case 9998:
				任务9998(num, num2, 任务阶段ID);
				return;
			case 9202:
				任务9202(num, num2, 任务阶段ID);
				return;
			case 1002:
				任务1002(num, num2, 任务阶段ID);
				return;
			case 1003:
				任务1003(num, num2, 任务阶段ID);
				return;
			case 1004:
				任务1004(num, num2, 任务阶段ID);
				return;
			case 1005:
				任务1005(num, num2, 任务阶段ID);
				return;
			case 1006:
				任务1006(num, num2, 任务阶段ID);
				return;
			}
			if (num2 == 1)
			{
				任务提示(num, 11, 任务阶段ID);
			}
			if (num2 == 3)
			{
				任务提示(num, 31, 任务阶段ID);
			}
			if (num2 == 5)
			{
				任务提示(num, 51, 任务阶段ID);
			}
		}

		public bool 任务1002(int 任务ID, int 操作ID, int 任务阶段ID)
		{
			if (Play.人物灵兽 == null)
			{
				任务提示(任务ID, 12, 任务阶段ID);
				return false;
			}
			if (Play.人物灵兽.FLD_LEVEL >= 15 && Play.人物灵兽.FLD_JOB_LEVEL == 0)
			{
				Play.灵兽转职业(0, 1);
				Play.人物灵兽.计算基本数据();
				Play.更新灵兽HP_MP_SP();
				Play.更新灵兽武功和状态();
				Play.更新灵兽负重();
				Play.召唤更新显示已装备物品(Play);
				任务提示(任务ID, 10, 0);
				Play.更新人物任务();
				return true;
			}
			任务提示(任务ID, 12, 任务阶段ID);
			return false;
		}

		public bool 任务1003(int 任务ID, int 操作ID, int 任务阶段ID)
		{
			if (Play.人物灵兽 == null)
			{
				任务提示(任务ID, 12, 任务阶段ID);
				return false;
			}
			if (Play.人物灵兽.FLD_LEVEL >= 50 && Play.人物灵兽.FLD_JOB_LEVEL == 1)
			{
				Play.灵兽转职业(1, 2);
				Play.人物灵兽.计算基本数据();
				Play.更新灵兽HP_MP_SP();
				Play.更新灵兽武功和状态();
				Play.更新灵兽负重();
				Play.召唤更新显示已装备物品(Play);
				任务提示(任务ID, 10, 0);
				Play.更新人物任务();
				return true;
			}
			任务提示(任务ID, 12, 任务阶段ID);
			return false;
		}

		public bool 任务1004(int 任务ID, int 操作ID, int 任务阶段ID)
		{
			if (Play.人物灵兽 == null)
			{
				任务提示(任务ID, 12, 任务阶段ID);
				return false;
			}
			if (Play.人物灵兽.FLD_LEVEL >= 50 && Play.人物灵兽.FLD_JOB_LEVEL == 1)
			{
				Play.灵兽转职业(2, 2);
				Play.人物灵兽.计算基本数据();
				Play.更新灵兽HP_MP_SP();
				Play.更新灵兽武功和状态();
				Play.更新灵兽负重();
				Play.召唤更新显示已装备物品(Play);
				Play.更新人物任务();
				return true;
			}
			任务提示(任务ID, 12, 任务阶段ID);
			return false;
		}

		public bool 任务1005(int 任务ID, int 操作ID, int 任务阶段ID)
		{
			if (Play.人物灵兽 == null)
			{
				任务提示(任务ID, 12, 任务阶段ID);
				return false;
			}
			if (Play.人物灵兽.FLD_LEVEL >= 75 && Play.人物灵兽.FLD_JOB_LEVEL == 2)
			{
				Play.灵兽转职业(1, 3);
				Play.人物灵兽.计算基本数据();
				Play.更新灵兽HP_MP_SP();
				Play.更新灵兽武功和状态();
				Play.更新灵兽负重();
				Play.召唤更新显示已装备物品(Play);
				Play.更新人物任务();
				return true;
			}
			任务提示(任务ID, 12, 任务阶段ID);
			return false;
		}

		public bool 任务1006(int 任务ID, int 操作ID, int 任务阶段ID)
		{
			if (Play.人物灵兽 == null)
			{
				任务提示(任务ID, 12, 任务阶段ID);
				return false;
			}
			if (Play.人物灵兽.FLD_LEVEL >= 75 && Play.人物灵兽.FLD_JOB_LEVEL == 2)
			{
				Play.灵兽转职业(2, 3);
				Play.人物灵兽.计算基本数据();
				Play.更新灵兽HP_MP_SP();
				Play.更新灵兽武功和状态();
				Play.更新灵兽负重();
				Play.召唤更新显示已装备物品(Play);
				Play.更新人物任务();
				return true;
			}
			任务提示(任务ID, 12, 任务阶段ID);
			return false;
		}

		public void 任务提示(int 任务ID, int 操作ID, int 任务阶段ID)
		{
			byte[] array = Converter.hexStringToByte("AA551400000084000600120033000000000000000000000055AA");
			System.Buffer.BlockCopy(BitConverter.GetBytes(任务ID), 0, array, 10, 2);
			System.Buffer.BlockCopy(BitConverter.GetBytes(操作ID), 0, array, 12, 2);
			System.Buffer.BlockCopy(BitConverter.GetBytes(任务阶段ID), 0, array, 14, 2);
			System.Buffer.BlockCopy(BitConverter.GetBytes(Play.人物全服ID), 0, array, 4, 2);
			if (Play.Client != null)
			{
				Play.Client.Send(array, array.Length);
			}
		}

		public void 任务18(int 任务ID, int 操作ID, int 任务阶段ID)
		{
			switch (操作ID)
			{
			case 1:
				if (Play.Player_Level >= 10 && Play.Player_Job_leve < 1)
				{
					任务提示(任务ID, 11, 任务阶段ID);
				}
				else
				{
					任务提示(任务ID, 12, 任务阶段ID);
				}
				break;
			case 2:
			{
				Play.人物转职业(0, 1);
				任务提示(任务ID, 21, 1);
				设置任务(任务ID, 1);
				Play.新学气功(5, 0);
				Play.Player_Money += 1000000L;
				Play.更新金钱和负重();
				int num = Play.得到包裹空位(Play);
				if (num != -1)
				{
					Play.增加物品带属性(1008000055, num, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
				}
				Play.更新人物数据(Play);
				Play.更新武功和状态();
				break;
			}
			case 3:
				任务提示(任务ID, 31, 任务阶段ID);
				break;
			case 4:
				if (Play.任务.ContainsKey(任务ID))
				{
					Play.任务.Remove(任务ID);
				}
				任务提示(任务ID, 41, 任务阶段ID);
				break;
			case 5:
				任务提示(任务ID, 51, 任务阶段ID);
				break;
			}
		}

		public void 任务11(int 任务ID, int 操作ID, int 任务阶段ID)
		{
			switch (操作ID)
			{
			case 1:
				if (Play.Player_Level >= 35 && Play.Player_Job_leve < 2 && Play.Player_Zx == 0)
				{
					任务提示(任务ID, 11, 任务阶段ID);
				}
				else
				{
					任务提示(任务ID, 12, 任务阶段ID);
				}
				break;
			case 2:
				Play.人物转职业(1, 2);
				任务提示(任务ID, 21, 1);
				设置任务(任务ID, 1);
				Play.新学气功(6, 0);
				Play.Player_Money += 2000000L;
				Play.神女武功点数 += 5;
				Play.更新金钱和负重();
				Play.更新人物数据(Play);
				Play.更新装备效果to(Play, Play);
				Play.更新武功和状态();
				break;
			case 3:
				任务提示(任务ID, 31, 任务阶段ID);
				break;
			case 4:
				if (Play.任务.ContainsKey(任务ID))
				{
					Play.任务.Remove(任务ID);
				}
				任务提示(任务ID, 41, 任务阶段ID);
				break;
			case 5:
				任务提示(任务ID, 51, 任务阶段ID);
				break;
			}
		}

		public void 任务12(int 任务ID, int 操作ID, int 任务阶段ID)
		{
			switch (操作ID)
			{
			case 1:
				if (Play.Player_Level >= 35 && Play.Player_Job_leve < 2 && Play.Player_Zx == 0)
				{
					任务提示(任务ID, 11, 任务阶段ID);
				}
				else
				{
					任务提示(任务ID, 12, 任务阶段ID);
				}
				break;
			case 2:
				Play.人物转职业(2, 2);
				任务提示(任务ID, 21, 1);
				设置任务(任务ID, 1);
				Play.新学气功(6, 0);
				Play.Player_Money += 2000000L;
				Play.神女武功点数 += 5;
				Play.更新金钱和负重();
				Play.更新人物数据(Play);
				Play.更新装备效果to(Play, Play);
				Play.更新武功和状态();
				break;
			case 3:
				任务提示(任务ID, 31, 任务阶段ID);
				break;
			case 4:
				if (Play.任务.ContainsKey(任务ID))
				{
					Play.任务.Remove(任务ID);
				}
				任务提示(任务ID, 41, 任务阶段ID);
				break;
			case 5:
				任务提示(任务ID, 51, 任务阶段ID);
				break;
			}
		}

		public void 任务45(int 任务ID, int 操作ID, int 任务阶段ID)
		{
			switch (操作ID)
			{
			case 1:
				if (Play.Player_Level >= 60 && Play.Player_Job_leve < 3 && Play.Player_Zx != 0)
				{
					任务提示(任务ID, 11, 任务阶段ID);
				}
				else
				{
					任务提示(任务ID, 12, 任务阶段ID);
				}
				break;
			case 2:
			{
				Play.人物转职业(Play.Player_Zx, 3);
				任务提示(任务ID, 21, 1);
				设置任务(任务ID, 1);
				Play.新学气功(7, 0);
				Play.Player_Money += 3000000L;
				Play.神女武功点数 += 5;
				Play.更新金钱和负重();
				Play.更新武功和状态();
				Play.初始化已装备物品();
				Play.更新人物数据(Play);
				int num = Play.得到包裹空位(Play);
				if (num != -1)
				{
					Play.增加物品带属性(1008000003, num, 8, 0, 2019990000, 0, 0, 0, 0, 0, 0, 0, 0);
				}
				int num2 = Play.得到包裹空位(Play);
				if (num2 != -1)
				{
					Play.增加物品带属性(1008000055, num2, 20, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
				}
				break;
			}
			case 3:
				任务提示(任务ID, 31, 任务阶段ID);
				break;
			case 4:
				if (Play.任务.ContainsKey(任务ID))
				{
					Play.任务.Remove(任务ID);
				}
				任务提示(任务ID, 41, 任务阶段ID);
				break;
			case 5:
				任务提示(任务ID, 51, 任务阶段ID);
				break;
			}
		}

		public void 任务46(int 任务ID, int 操作ID, int 任务阶段ID)
		{
			switch (操作ID)
			{
			case 1:
				if (Play.Player_Level >= 60 && Play.Player_Job_leve < 3 && Play.Player_Zx != 0)
				{
					任务提示(任务ID, 11, 任务阶段ID);
				}
				else
				{
					任务提示(任务ID, 12, 任务阶段ID);
				}
				break;
			case 2:
			{
				Play.人物转职业(Play.Player_Zx, 3);
				任务提示(任务ID, 21, 1);
				设置任务(任务ID, 1);
				Play.新学气功(7, 0);
				Play.Player_Money += 3000000L;
				Play.神女武功点数 += 5;
				Play.更新金钱和负重();
				Play.更新人物数据(Play);
				Play.更新武功和状态();
				int num = Play.得到包裹空位(Play);
				if (num != -1)
				{
					Play.增加物品带属性(1008000003, num, 8, 0, 2019990000, 0, 0, 0, 0, 0, 0, 0, 0);
				}
				int num2 = Play.得到包裹空位(Play);
				if (num2 != -1)
				{
					Play.增加物品带属性(1008000055, num2, 20, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
				}
				break;
			}
			case 3:
				任务提示(任务ID, 31, 任务阶段ID);
				break;
			case 4:
				if (Play.任务.ContainsKey(任务ID))
				{
					Play.任务.Remove(任务ID);
				}
				任务提示(任务ID, 41, 任务阶段ID);
				break;
			case 5:
				任务提示(任务ID, 51, 任务阶段ID);
				break;
			}
		}

		public void 任务73(int 任务ID, int 操作ID, int 任务阶段ID)
		{
			if (操作ID == 1)
			{
				if (Play.Player_Level >= 80 && Play.Player_Job_leve < 4 && Play.Player_Zx != 0)
				{
					任务提示(任务ID, 11, 任务阶段ID);
				}
				else
				{
					任务提示(任务ID, 12, 任务阶段ID);
				}
			}
			switch (操作ID)
			{
			case 2:
			{
				Play.人物转职业(Play.Player_Zx, 4);
				任务提示(任务ID, 21, 1);
				设置任务(任务ID, 1);
				Play.新学气功(8, 0);
				Play.新学气功(9, 0);
				Play.Player_Money += 5000000L;
				Play.神女武功点数 += 5;
				Play.更新人物数据(Play);
				Play.更新金钱和负重();
				Play.更新武功和状态();
				int num = Play.得到包裹空位(Play);
				if (num != -1)
				{
					int 物品ID = 0;
					if (Play.Player_Job == 1)
					{
						物品ID = ((Play.Player_Zx != 1) ? 100202028 : 100201027);
					}
					else if (Play.Player_Job == 2)
					{
						物品ID = ((Play.Player_Zx != 1) ? 200202028 : 200201027);
					}
					else if (Play.Player_Job == 3)
					{
						物品ID = ((Play.Player_Zx != 1) ? 300202028 : 300201027);
					}
					else if (Play.Player_Job == 4)
					{
						物品ID = ((Play.Player_Zx != 1) ? 400202028 : 400201027);
					}
					else if (Play.Player_Job == 5)
					{
						物品ID = ((Play.Player_Zx != 1) ? 500202028 : 500201027);
					}
					else if (Play.Player_Job == 6)
					{
						物品ID = ((Play.Player_Zx != 1) ? 700202028 : 700201027);
					}
					else if (Play.Player_Job == 7)
					{
						物品ID = ((Play.Player_Zx != 1) ? 800202028 : 800201027);
					}
					else if (Play.Player_Job == 8)
					{
						物品ID = 100204005;
					}
					else if (Play.Player_Job == 9)
					{
						物品ID = 200204005;
					}
					else if (Play.Player_Job == 10)
					{
						物品ID = ((Play.Player_Zx != 1) ? 900202030 : 900201029);
					}
					else if (Play.Player_Job == 11)
					{
						物品ID = ((Play.Player_Zx != 1) ? 400204015 : 400204005);
					}
					else if (Play.Player_Job == 12)
					{
						物品ID = 300204005;
					}
					else if (Play.Player_Job == 13)
					{
						物品ID = 500204005;
					}
					if (Play.Player_Job != 4 && Play.Player_Job != 6)
					{
						Play.增加物品带属性(物品ID, num, 1, 10000007, 70000023, 70000023, 70000023, 70000023, 0, 0, 0, 0, 0);
					}
					else
					{
						Play.增加物品带属性(物品ID, num, 1, 10000007, 10000013, 10000013, 10000013, 10000013, 0, 0, 0, 0, 0);
					}
				}
				int num2 = Play.得到包裹空位(Play);
				if (num2 != -1)
				{
					Play.增加物品带属性(1008000003, num2, 10, 0, 2019990000, 0, 0, 0, 0, 0, 0, 0, 0);
				}
				int num3 = Play.得到包裹空位(Play);
				if (num3 != -1)
				{
					Play.增加物品带属性(1008000006, num3, 5, 0, 2016000000, 0, 0, 0, 0, 0, 0, 0, 0);
				}
				int num4 = Play.得到包裹空位(Play);
				if (num4 != -1)
				{
					Play.增加物品带属性(1008000055, num4, 25, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
				}
				break;
			}
			case 3:
				任务提示(任务ID, 31, 任务阶段ID);
				break;
			case 4:
				if (Play.任务.ContainsKey(任务ID))
				{
					Play.任务.Remove(任务ID);
				}
				任务提示(任务ID, 41, 任务阶段ID);
				break;
			case 5:
				任务提示(任务ID, 51, 任务阶段ID);
				break;
			}
		}

		public void 任务74(int 任务ID, int 操作ID, int 任务阶段ID)
		{
			switch (操作ID)
			{
			case 1:
				if (Play.Player_Level >= 80 && Play.Player_Job_leve < 4 && Play.Player_Zx != 0)
				{
					任务提示(任务ID, 11, 任务阶段ID);
				}
				else
				{
					任务提示(任务ID, 12, 任务阶段ID);
				}
				break;
			case 2:
			{
				Play.人物转职业(Play.Player_Zx, 4);
				任务提示(任务ID, 21, 1);
				设置任务(任务ID, 1);
				Play.新学气功(8, 0);
				Play.新学气功(9, 0);
				Play.Player_Money += 10000000L;
				Play.神女武功点数 += 5;
				Play.更新人物数据(Play);
				Play.更新金钱和负重();
				Play.更新武功和状态();
				int num = Play.得到包裹空位(Play);
				if (num != -1)
				{
					int 物品ID = 0;
					if (Play.Player_Job == 1)
					{
						物品ID = ((Play.Player_Zx != 1) ? 100202028 : 100201027);
					}
					else if (Play.Player_Job == 2)
					{
						物品ID = ((Play.Player_Zx != 1) ? 200202028 : 200201027);
					}
					else if (Play.Player_Job == 3)
					{
						物品ID = ((Play.Player_Zx != 1) ? 300202028 : 300201027);
					}
					else if (Play.Player_Job == 4)
					{
						物品ID = ((Play.Player_Zx != 1) ? 400202028 : 400201027);
					}
					else if (Play.Player_Job == 5)
					{
						物品ID = ((Play.Player_Zx != 1) ? 500202028 : 500201027);
					}
					else if (Play.Player_Job == 6)
					{
						物品ID = ((Play.Player_Zx != 1) ? 700202028 : 700201027);
					}
					else if (Play.Player_Job == 7)
					{
						物品ID = ((Play.Player_Zx != 1) ? 800202028 : 800201027);
					}
					else if (Play.Player_Job == 8)
					{
						物品ID = 100204005;
					}
					else if (Play.Player_Job == 9)
					{
						物品ID = 200204005;
					}
					else if (Play.Player_Job == 10)
					{
						物品ID = ((Play.Player_Zx != 1) ? 900202030 : 900201029);
					}
					else if (Play.Player_Job == 11)
					{
						物品ID = ((Play.Player_Zx != 1) ? 400204015 : 400204005);
					}
					else if (Play.Player_Job == 12)
					{
						物品ID = 300204005;
					}
					else if (Play.Player_Job == 13)
					{
						物品ID = 500204005;
					}
					if (Play.Player_Job != 4 && Play.Player_Job != 6)
					{
						Play.增加物品带属性(物品ID, num, 1, 10000007, 70000023, 70000023, 70000023, 70000023, 0, 0, 0, 0, 0);
					}
					else
					{
						Play.增加物品带属性(物品ID, num, 1, 10000007, 10000013, 10000013, 10000013, 10000013, 0, 0, 0, 0, 0);
					}
				}
				int num2 = Play.得到包裹空位(Play);
				if (num2 != -1)
				{
					Play.增加物品带属性(1008000003, num2, 10, 0, 2019990000, 0, 0, 0, 0, 0, 0, 0, 0);
				}
				int num3 = Play.得到包裹空位(Play);
				if (num3 != -1)
				{
					Play.增加物品带属性(1008000006, num3, 5, 0, 2016000000, 0, 0, 0, 0, 0, 0, 0, 0);
				}
				int num4 = Play.得到包裹空位(Play);
				if (num4 != -1)
				{
					Play.增加物品带属性(1008000055, num4, 25, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
				}
				break;
			}
			case 3:
				任务提示(任务ID, 31, 任务阶段ID);
				break;
			case 4:
				if (Play.任务.ContainsKey(任务ID))
				{
					Play.任务.Remove(任务ID);
				}
				任务提示(任务ID, 41, 任务阶段ID);
				break;
			case 5:
				任务提示(任务ID, 51, 任务阶段ID);
				break;
			}
		}

		public void 任务178(int 任务ID, int 操作ID, int 任务阶段ID)
		{
			switch (操作ID)
			{
			case 1:
				if (Play.Player_Level >= 100 && Play.Player_Job_leve < 5 && Play.Player_Zx != 0)
				{
					任务提示(任务ID, 11, 任务阶段ID);
				}
				else
				{
					任务提示(任务ID, 12, 任务阶段ID);
				}
				break;
			case 2:
			{
				Play.人物转职业(Play.Player_Zx, 5);
				任务提示(任务ID, 21, 1);
				设置任务(任务ID, 1);
				Play.新学气功(10, 0);
				Play.学习技能(0, 25);
				Play.学习技能(0, 26);
				Play.学习技能(0, 27);
				Play.更新人物数据(Play);
				Play.更新经验和历练();
				Play.Player_Money += 20000000L;
				Play.神女武功点数 += 5;
				Play.更新金钱和负重();
				Play.更新武功和状态();
				int num = Play.得到包裹空位(Play);
				if (num != -1)
				{
					Play.增加物品带属性(1008000003, num, 15, 0, 2019990000, 0, 0, 0, 0, 0, 0, 0, 0);
				}
				int num2 = Play.得到包裹空位(Play);
				if (num2 != -1)
				{
					Play.增加物品带属性(1008000006, num2, 5, 0, 2016000000, 0, 0, 0, 0, 0, 0, 0, 0);
				}
				int num3 = Play.得到包裹空位(Play);
				if (num3 != -1)
				{
					Play.增加物品带属性(1008000055, num3, 30, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
				}
				break;
			}
			case 3:
				任务提示(任务ID, 31, 任务阶段ID);
				break;
			case 4:
				if (Play.任务.ContainsKey(任务ID))
				{
					Play.任务.Remove(任务ID);
				}
				任务提示(任务ID, 41, 任务阶段ID);
				break;
			case 5:
				任务提示(任务ID, 51, 任务阶段ID);
				break;
			}
		}

		public void 任务300(int 任务ID, int 操作ID, int 任务阶段ID)
		{
			switch (操作ID)
			{
			case 1:
				if (Play.Player_Level >= 115 && Play.Player_Job_leve < 6 && Play.Player_Zx != 0)
				{
					任务提示(任务ID, 11, 任务阶段ID);
				}
				else
				{
					任务提示(任务ID, 12, 任务阶段ID);
				}
				break;
			case 2:
			{
				int num = Play.得到包裹空位(Play);
				if (num != -1)
				{
					Play.人物转职业(Play.Player_Zx, 6);
					任务提示(任务ID, 21, 1);
					设置任务(任务ID, 1);
					Play.发送六转技能书(num);
					Play.更新人物数据(Play);
					Play.更新经验和历练();
					Play.初始化已装备物品();
					Play.Player_Money += 30000000L;
					Play.神女武功点数 += 5;
					Play.更新金钱和负重();
					Play.更新武功和状态();
					int num2 = Play.得到包裹空位(Play);
					if (num2 != -1)
					{
						Play.增加物品带属性(1008000003, num2, 20, 0, 2019990000, 0, 0, 0, 0, 0, 0, 0, 0);
					}
					int num3 = Play.得到包裹空位(Play);
					if (num3 != -1)
					{
						Play.增加物品带属性(1008000006, num3, 10, 0, 2016000000, 0, 0, 0, 0, 0, 0, 0, 0);
					}
					int num4 = Play.得到包裹空位(Play);
					if (num4 != -1)
					{
						Play.增加物品带属性(1008000055, num4, 40, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
					}
				}
				else
				{
					Play.系统提示("装备栏没有空位了。");
					任务提示(任务ID, 31, 任务阶段ID);
				}
				break;
			}
			case 3:
				任务提示(任务ID, 31, 任务阶段ID);
				break;
			case 4:
				if (Play.任务.ContainsKey(任务ID))
				{
					Play.任务.Remove(任务ID);
				}
				任务提示(任务ID, 41, 任务阶段ID);
				break;
			case 5:
				任务提示(任务ID, 51, 任务阶段ID);
				break;
			}
		}

		public void 任务301(int 任务ID, int 操作ID, int 任务阶段ID)
		{
			switch (操作ID)
			{
			case 1:
				if (Play.Player_Level >= 120 && Play.Player_Job_leve < 7 && Play.Player_Zx != 0)
				{
					任务提示(任务ID, 11, 任务阶段ID);
				}
				else
				{
					任务提示(任务ID, 12, 任务阶段ID);
				}
				break;
			case 2:
			{
				int num = Play.得到包裹空位(Play);
				if (num != -1)
				{
					Play.人物转职业(Play.Player_Zx, 7);
					任务提示(任务ID, 21, 1);
					设置任务(任务ID, 1);
					Play.发送七转技能书(num);
					Play.更新人物数据(Play);
					Play.更新经验和历练();
					Play.初始化已装备物品();
					Play.Player_Money += 50000000L;
					Play.神女武功点数 += 5;
					Play.更新金钱和负重();
					Play.更新武功和状态();
					int num2 = Play.得到包裹空位(Play);
					if (num2 != -1)
					{
						Play.增加物品带属性(1008000003, num2, 20, 0, 2019990000, 0, 0, 0, 0, 0, 0, 0, 0);
					}
					int num3 = Play.得到包裹空位(Play);
					if (num3 != -1)
					{
						Play.增加物品带属性(1008000006, num3, 10, 0, 2016000000, 0, 0, 0, 0, 0, 0, 0, 0);
					}
					int num4 = Play.得到包裹空位(Play);
					if (num4 != -1)
					{
						Play.增加物品带属性(1008000055, num4, 50, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
					}
				}
				else
				{
					Play.系统提示("装备栏没有空位了。");
					任务提示(任务ID, 31, 任务阶段ID);
				}
				break;
			}
			case 3:
				任务提示(任务ID, 31, 任务阶段ID);
				break;
			case 4:
				if (Play.任务.ContainsKey(任务ID))
				{
					Play.任务.Remove(任务ID);
				}
				任务提示(任务ID, 41, 任务阶段ID);
				break;
			case 5:
				任务提示(任务ID, 51, 任务阶段ID);
				break;
			}
		}

		public void 任务八转(int 任务ID, int 操作ID, int 任务阶段ID)
		{
			switch (操作ID)
			{
			case 1:
				if (Play.Player_Level >= 130 && Play.Player_Job_leve < 8 && Play.Player_Zx != 0)
				{
					任务提示(任务ID, 11, 任务阶段ID);
				}
				else
				{
					任务提示(任务ID, 12, 任务阶段ID);
				}
				break;
			case 2:
			{
				int num = Play.得到包裹空位(Play);
				if (num != -1)
				{
					Play.人物转职业(Play.Player_Zx, 8);
					任务提示(任务ID, 21, 1);
					设置任务(任务ID, 1);
					Play.发送八转技能书(num);
					Play.更新人物数据(Play);
					Play.更新经验和历练();
					Play.初始化已装备物品();
					Play.Player_Money += 80000000L;
					Play.神女武功点数 += 5;
					Play.更新金钱和负重();
					Play.更新武功和状态();
					int num2 = Play.得到包裹空位(Play);
					if (num2 != -1)
					{
						Play.增加物品带属性(1008000003, num2, 30, 0, 2019990000, 0, 0, 0, 0, 0, 0, 0, 0);
					}
					int num3 = Play.得到包裹空位(Play);
					if (num3 != -1)
					{
						Play.增加物品带属性(1008000006, num3, 20, 0, 2016000000, 0, 0, 0, 0, 0, 0, 0, 0);
					}
					int num4 = Play.得到包裹空位(Play);
					if (num4 != -1)
					{
						Play.增加物品带属性(1008000055, num4, 100, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
					}
				}
				else
				{
					Play.系统提示("装备栏没有空位了。");
					任务提示(任务ID, 31, 任务阶段ID);
				}
				break;
			}
			case 3:
				任务提示(任务ID, 31, 任务阶段ID);
				break;
			case 4:
				if (Play.任务.ContainsKey(任务ID))
				{
					Play.任务.Remove(任务ID);
				}
				任务提示(任务ID, 41, 任务阶段ID);
				break;
			case 5:
				任务提示(任务ID, 51, 任务阶段ID);
				break;
			}
		}

		public void 任务九转(int 任务ID, int 操作ID, int 任务阶段ID)
		{
			switch (操作ID)
			{
			case 1:
				if (Play.Player_Level >= 140 && Play.Player_Job_leve < 9 && Play.Player_Zx != 0)
				{
					任务提示(任务ID, 11, 任务阶段ID);
				}
				else
				{
					任务提示(任务ID, 10, 任务阶段ID);
				}
				break;
			case 2:
			{
				int num = Play.得到包裹空位(Play);
				if (num != -1)
				{
					Play.人物转职业(Play.Player_Zx, 9);
					任务提示(任务ID, 21, 1);
					设置任务(任务ID, 1);
					Play.Player_Money += 100000000L;
					Play.神女武功点数 += 5;
					Play.发送九转技能书(num);
					Play.更新人物数据(Play);
					Play.更新经验和历练();
					Play.初始化已装备物品();
					Play.更新金钱和负重();
					Play.更新武功和状态();
					int num2 = Play.得到包裹空位(Play);
					if (num2 != -1)
					{
						Play.增加物品带属性(1008000003, num2, 30, 0, 2019990000, 0, 0, 0, 0, 0, 0, 0, 0);
					}
					int num3 = Play.得到包裹空位(Play);
					if (num3 != -1)
					{
						Play.增加物品带属性(1008000006, num3, 20, 0, 2016000000, 0, 0, 0, 0, 0, 0, 0, 0);
					}
					int num4 = Play.得到包裹空位(Play);
					if (num4 != -1)
					{
						Play.增加物品带属性(1008000055, num4, 200, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
					}
				}
				else
				{
					Play.系统提示("装备栏没有空位了。");
					任务提示(任务ID, 31, 任务阶段ID);
				}
				break;
			}
			case 3:
				任务提示(任务ID, 31, 任务阶段ID);
				break;
			case 4:
				if (Play.任务.ContainsKey(任务ID))
				{
					Play.任务.Remove(任务ID);
				}
				任务提示(任务ID, 41, 任务阶段ID);
				break;
			case 5:
				任务提示(任务ID, 51, 任务阶段ID);
				break;
			}
		}

		public void 任务十转(int 任务ID, int 操作ID, int 任务阶段ID)
		{
			switch (操作ID)
			{
			case 1:
				if (Play.Player_Level >= 150 && Play.Player_Job_leve < 10 && Play.Player_Zx != 0)
				{
					任务提示(任务ID, 11, 任务阶段ID);
				}
				else
				{
					任务提示(任务ID, 10, 任务阶段ID);
				}
				break;
			case 2:
				if (Play.得到包裹空位(Play) != -1)
				{
					Play.人物转职业(Play.Player_Zx, 10);
					任务提示(任务ID, 21, 1);
					设置任务(任务ID, 1);
					Play.Player_Money += 200000000L;
					Play.神女武功点数 += 5;
					Play.发送十转技能书();
					Play.更新人物数据(Play);
					Play.更新经验和历练();
					Play.初始化已装备物品();
					Play.更新金钱和负重();
					Play.更新武功和状态();
					int num = Play.得到包裹空位(Play);
					if (num != -1)
					{
						Play.增加物品带属性(1008000003, num, 30, 0, 2019990000, 0, 0, 0, 0, 0, 0, 0, 0);
					}
					int num2 = Play.得到包裹空位(Play);
					if (num2 != -1)
					{
						Play.增加物品带属性(1008000006, num2, 20, 0, 2016000000, 0, 0, 0, 0, 0, 0, 0, 0);
					}
					int num3 = Play.得到包裹空位(Play);
					if (num3 != -1)
					{
						Play.增加物品带属性(1008000055, num3, 200, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
					}
				}
				else
				{
					Play.系统提示("装备栏没有空位了。");
					任务提示(任务ID, 31, 任务阶段ID);
				}
				break;
			case 3:
				任务提示(任务ID, 31, 任务阶段ID);
				break;
			case 4:
				if (Play.任务.ContainsKey(任务ID))
				{
					Play.任务.Remove(任务ID);
				}
				任务提示(任务ID, 41, 任务阶段ID);
				break;
			case 5:
				任务提示(任务ID, 51, 任务阶段ID);
				break;
			}
		}

		public void 设置任务(int 任务ID, int 任务阶段ID)
		{
			任务类 value;
			if (Play.任务.TryGetValue(任务ID, out value))
			{
				value.任务阶段ID = 任务阶段ID;
				return;
			}
			任务类 任务类 = new 任务类();
			任务类.任务ID = 任务ID;
			任务类.任务阶段ID = 任务阶段ID;
			if (!Play.任务.ContainsKey(任务ID))
			{
				Play.任务.Add(任务ID, 任务类);
			}
		}

		public void 任务9998(int 任务ID, int 操作ID, int 任务阶段ID)
		{
			if (任务阶段ID == 0)
			{
				switch (操作ID)
				{
				case 4:
					break;
				case 1:
					任务提示(任务ID, 11, 任务阶段ID);
					break;
				case 2:
					任务提示(任务ID, 21, 任务阶段ID);
					设置任务(任务ID, 1);
					break;
				case 3:
					任务提示(任务ID, 31, 任务阶段ID);
					break;
				case 5:
					任务提示(任务ID, 51, 任务阶段ID);
					break;
				}
			}
			else
			{
				int num = Play.得到包裹空位(Play);
				if (num != -1)
				{
					Play.增加物品2(BitConverter.GetBytes(RxjhClass.GetDBItmeId()), BitConverter.GetBytes(1700101), num, BitConverter.GetBytes(1), new byte[56]);
					任务提示(任务ID, 11, 2);
					设置任务(任务ID, 2);
				}
				else
				{
					任务提示(任务ID, 10, 任务阶段ID);
				}
			}
		}

		public void 任务9202(int 任务ID, int 操作ID, int 任务阶段ID)
		{
			if (任务阶段ID == 0)
			{
				switch (操作ID)
				{
				case 1:
					任务提示(任务ID, 11, 任务阶段ID);
					break;
				case 2:
					任务提示(任务ID, 21, 任务阶段ID);
					设置任务(任务ID, 1);
					break;
				case 3:
					任务提示(任务ID, 31, 任务阶段ID);
					break;
				}
				return;
			}
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			for (int i = 0; i < 36; i++)
			{
				if (BitConverter.ToInt32(Play.装备栏包裹[i].物品ID, 0) == 1000000161)
				{
					num = 1;
				}
				else if (BitConverter.ToInt32(Play.装备栏包裹[i].物品ID, 0) == 1000000162)
				{
					num2 = 1;
				}
				else if (BitConverter.ToInt32(Play.装备栏包裹[i].物品ID, 0) == 1000000163)
				{
					num3 = 1;
				}
				else if (BitConverter.ToInt32(Play.装备栏包裹[i].物品ID, 0) == 1000000164)
				{
					num4 = 1;
				}
				else if (BitConverter.ToInt32(Play.装备栏包裹[i].物品ID, 0) == 1000000199)
				{
					num5 = 1;
				}
			}
			if (num != 0 && num2 != 0 && num3 != 0 && num4 != 0 && num5 != 0)
			{
				for (int j = 0; j < 36; j++)
				{
					if (BitConverter.ToInt32(Play.装备栏包裹[j].物品ID, 0) == 1000000161)
					{
						Play.减去物品(j, 1);
					}
					else if (BitConverter.ToInt32(Play.装备栏包裹[j].物品ID, 0) == 1000000162)
					{
						Play.减去物品(j, 1);
					}
					else if (BitConverter.ToInt32(Play.装备栏包裹[j].物品ID, 0) == 1000000163)
					{
						Play.减去物品(j, 1);
					}
					else if (BitConverter.ToInt32(Play.装备栏包裹[j].物品ID, 0) == 1000000164)
					{
						Play.减去物品(j, 1);
					}
					else if (BitConverter.ToInt32(Play.装备栏包裹[j].物品ID, 0) == 1000000199)
					{
						Play.减去物品(j, 1);
					}
				}
				Play.增加物品(BitConverter.GetBytes(RxjhClass.GetDBItmeId()), BitConverter.GetBytes(1000000365), Play.得到包裹空位(Play), BitConverter.GetBytes(1), new byte[56]);
				任务提示(任务ID, 11, 2);
				设置任务(任务ID, 3);
			}
			else
			{
				任务提示(任务ID, 12, 任务阶段ID);
			}
		}
	}
}
