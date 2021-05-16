using LuaInterface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace RxjhServer
{
	public class ScriptClass
	{
		public Dictionary<int, LuaFunction> 任务事件列表 = new Dictionary<int, LuaFunction>();

		public string 脚本目录 = "script";

		public LuaFunction 怪物死亡事件;

		public LuaFunction 打开物品事件;

		public Lua pLuaVM;

		private string string_0;

		private string string_1;

		private string string_2;

		private string string_3;

		private string string_4;

		private string string_5;

		private string string_6;

		private string string_7;

		private string string_8;

		private string string_9;

		private string string_10;

		private string string_11;

		private string string_12;

		private string string_13;

		private string string_14;

		private string string_15;

		private string string_16;

		private string string_17;

		private string string_18;

		private string string_19;

		private string string_20;

		private string string_21;

		private string string_22;

		private string string_23;

		private string string_24;

		private string string_25;

		private string string_26;

		private string string_27;

		private string string_28;

		private string string_29;

		private string string_30;

		private string string_31;

		private string string_32;

		private string string_33;

		private string string_34;

		private string string_35;

		private string string_36;

		private string string_37;

		private string string_38;

		private string string_39;

		private string string_40;

		private string string_41;

		private string string_42;

		private string string_43;

		private string string_44;

		private string string_45;

		private string string_46;

		private string string_47;

		private string string_48;

		private string string_49;

		private string string_50;

		private string string_51;

		private string string_52;

		private string string_53;

		public ScriptClass()
		{
			注册脚本API();
			脚本目录 = Application.StartupPath + "\\Script";
			GetUrlDirectory(脚本目录);
			Form1.WriteLine(2, "加载脚本完成");
			注册事件();
		}

		public void 注册事件()
		{
			打开物品事件 = pLuaVM.GetFunction("OpenItmeTrigGer");
			怪物死亡事件 = pLuaVM.GetFunction("DestroyMonster");
		}

		public void SetUrlFile(string string_54)
		{
			if (Buffer.IsEquals(Path.GetExtension(string_54), ".lua"))
			{
				try
				{
					pLuaVM.DoFile(string_54);
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
					Form1.WriteLine(2, "加载Lua脚本出错" + ex.Message);
				}
			}
		}

		public void GetUrlDirectory(string string_54)
		{
			if (Directory.Exists(string_54))
			{
				string[] files = Directory.GetFiles(string_54);
				foreach (string urlFile in files)
				{
					try
					{
						SetUrlFile(urlFile);
					}
					catch (Exception value)
					{
						Console.Write(value);
					}
				}
				GetUrlDirectoryS(string_54);
			}
		}

		public void GetUrlDirectoryS(string string_54)
		{
			string[] directories = Directory.GetDirectories(string_54);
			foreach (string string_55 in directories)
			{
				GetUrlDirectory(string_55);
			}
		}

		public void 初始化函数名()
		{
			发送六转技能书(1, 1);
			发送七转技能书(1, 1);
			发送八转技能书(1, 1);
			发送九转技能书(1, 1);
			更新HP_MP_SP(1);
			删除任务物品(1, 1, 1);
			检查任务物品数量(1, 1, 1);
			计算人物基本数据(1);
			学习技能提示(1);
			设置人物元宝(1, 1, 1);
			设置人物会员(1, 1);
			设置玩家等级(1, 1);
			物品使用(1, 1, 1);
			删除物品(1, 1, 1);
			得到包裹物品(1, 1);
			学习升天武功书(1, 1, 1);
			初始话已装备物品(1);
			更新经验和历练(1);
			更新金钱和负重(1);
			更新武功和状态(1);
			新学气功(1, 1);
			人物转职业(1, 1, 1);
			得到包裹空位位置(1);
			得到包裹空位位置组(1, 1);
			Get任务阶段(1, 1);
			GetWorldItme(0);
			GetPlayerThis(1);
			增加物品Script(1, 1, 1, 1);
			得到任务物品(1, 1, 1);
			增加任务物品(1, 1, 1);
			增加物品带属性(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1);
			任务提示数据发送(1, 1, 1, 1);
			系统提示(1, "1", 1, "1");
			设置任务数据(1, 1, 1);
			学习技能(1, 1, 1);
			追加状态物品(1, 1, 1, 1, 1, 1);
			发送公告("1", 1);
			得到包裹空位数(1);
			GetPlayer_Name(1);
			GetPlayer_Level(1);
			GetPlayer_Job(1);
			GetPlayer_Zx(1);
			GetPlayer_Job_Level(1);
			GetPlayer_Qigong_Point(1);
			SetPlayer_Money(1, 1);
			GetPlayer_Sex(1);
			GetPlayer_Wx(1);
			SetPlayer_Wx(1, 0);
			GetWorldItme_Level(0);
			GetWorldItme_Zx(0);
			GetWorldItme_Reside1(0);
			GetWorldItme_Job_Level(0);
			SetPlayer_ExpErience(1, 0);
			GetPlayer_ExpErience(1);
		}

		public void 注册脚本API()
		{
			int num = 0;
			try
			{
				num = 1;
				初始化函数名();
				pLuaVM = new Lua();
				num = 2;
				pLuaVM.RegisterFunction("SendMissionMsg", this, GetType().GetMethod(string_27));
				num = 3;
				pLuaVM.RegisterFunction("SendSysMsg", this, GetType().GetMethod(string_28));
				pLuaVM.RegisterFunction("SendKongfuMsg", this, GetType().GetMethod(string_4));
				pLuaVM.RegisterFunction("SendNoticeMsg", this, GetType().GetMethod(string_35));
				pLuaVM.RegisterFunction("AddQuest", this, GetType().GetMethod(string_29));
				pLuaVM.RegisterFunction("AddMission", this, GetType().GetMethod(string_29));
				pLuaVM.RegisterFunction("AddStKongfu", this, GetType().GetMethod(string_11));
				pLuaVM.RegisterFunction("AddQigong", this, GetType().GetMethod(string_16));
				pLuaVM.RegisterFunction("AddSkill", this, GetType().GetMethod(string_30));
				pLuaVM.RegisterFunction("AddSkillBook6", this, GetType().GetMethod(string_31));
				pLuaVM.RegisterFunction("AddSkillBook7", this, GetType().GetMethod(string_32));
				pLuaVM.RegisterFunction("AddSkillBook8", this, GetType().GetMethod(string_33));
				pLuaVM.RegisterFunction("AddSkillBook9", this, GetType().GetMethod(string_34));
				pLuaVM.RegisterFunction("AddItme", this, GetType().GetMethod(string_23));
				pLuaVM.RegisterFunction("AddItmeProp", this, GetType().GetMethod(string_26));
				pLuaVM.RegisterFunction("DelItme", this, GetType().GetMethod(string_9));
				pLuaVM.RegisterFunction("AddQuestItme", this, GetType().GetMethod(string_25));
				pLuaVM.RegisterFunction("DelQuestItme", this, GetType().GetMethod(string_1));
				pLuaVM.RegisterFunction("GetWorldItme", this, GetType().GetMethod(string_21));
				pLuaVM.RegisterFunction("GetPlayer", this, GetType().GetMethod(string_22));
				pLuaVM.RegisterFunction("GetQuestLevel", this, GetType().GetMethod(string_20));
				pLuaVM.RegisterFunction("GetPackage", this, GetType().GetMethod(string_18));
				pLuaVM.RegisterFunction("GetPackagenum", this, GetType().GetMethod(string_37));
				pLuaVM.RegisterFunction("GetPackages", this, GetType().GetMethod(string_19));
				pLuaVM.RegisterFunction("GetPakItme", this, GetType().GetMethod(string_10));
				pLuaVM.RegisterFunction("GetQuestItme", this, GetType().GetMethod(string_24));
				pLuaVM.RegisterFunction("SetPlayerTransfer", this, GetType().GetMethod(string_17));
				pLuaVM.RegisterFunction("SetQigong", this, GetType().GetMethod(string_16));
				pLuaVM.RegisterFunction("SetPlayerLevel", this, GetType().GetMethod(string_7));
				pLuaVM.RegisterFunction("SetPlayerVIP", this, GetType().GetMethod(string_6));
				pLuaVM.RegisterFunction("SetPlayerRxpiont", this, GetType().GetMethod(string_5));
				pLuaVM.RegisterFunction("UpGongFu", this, GetType().GetMethod(string_15));
				pLuaVM.RegisterFunction("UpMoney", this, GetType().GetMethod(string_14));
				pLuaVM.RegisterFunction("UpExp", this, GetType().GetMethod(string_13));
				pLuaVM.RegisterFunction("UpYzbItme", this, GetType().GetMethod(string_12));
				pLuaVM.RegisterFunction("UpUseItme", this, GetType().GetMethod(string_8));
				pLuaVM.RegisterFunction("CheckQitemNum", this, GetType().GetMethod(string_2));
				pLuaVM.RegisterFunction("UpHpMpSp", this, GetType().GetMethod(string_0));
				pLuaVM.RegisterFunction("UpPlayerBase", this, GetType().GetMethod(string_3));
				pLuaVM.RegisterFunction("AddStateItems", this, GetType().GetMethod(string_36));
				num = 3;
				pLuaVM.RegisterFunction("GetPlayer_Name", this, GetType().GetMethod(string_38));
				pLuaVM.RegisterFunction("GetPlayer_Level", this, GetType().GetMethod(string_39));
				pLuaVM.RegisterFunction("GetPlayer_Job", this, GetType().GetMethod(string_40));
				pLuaVM.RegisterFunction("GetPlayer_Zx", this, GetType().GetMethod(string_41));
				pLuaVM.RegisterFunction("GetPlayer_Job_Level", this, GetType().GetMethod(string_42));
				pLuaVM.RegisterFunction("GetPlayer_Qigong_Point", this, GetType().GetMethod(string_43));
				pLuaVM.RegisterFunction("GetPlayer_Sex", this, GetType().GetMethod(string_45));
				pLuaVM.RegisterFunction("SetPlayer_Money", this, GetType().GetMethod(string_44));
				pLuaVM.RegisterFunction("GetPlayer_Wx", this, GetType().GetMethod(string_46));
				pLuaVM.RegisterFunction("SetPlayer_Wx", this, GetType().GetMethod(string_47));
				num = 4;
				pLuaVM.RegisterFunction("GetWorldItme_Level", this, GetType().GetMethod(string_48));
				pLuaVM.RegisterFunction("GetWorldItme_Zx", this, GetType().GetMethod(string_49));
				pLuaVM.RegisterFunction("GetWorldItme_Reside1", this, GetType().GetMethod(string_50));
				pLuaVM.RegisterFunction("GetWorldItme_Job_Level", this, GetType().GetMethod(string_51));
				pLuaVM.RegisterFunction("SetPlayer_ExpErience", this, GetType().GetMethod(string_52));
				pLuaVM.RegisterFunction("GetPlayer_ExpErience", this, GetType().GetMethod(string_53));
			}
			catch (Exception ex)
			{
				Form1.WriteLine(2, num + "|注册脚本API出错-" + ex.Message);
			}
		}

		public int GetWorldItme_Level(int int_0)
		{
			if (int_0 == 0)
			{
				string_48 = new StackTrace().GetFrame(0).GetMethod().Name;
				return 0;
			}
			ItmeClass value;
			if (World.Itme.TryGetValue(int_0, out value))
			{
				return value.FLD_LEVEL;
			}
			return 0;
		}

		public int GetWorldItme_Zx(int int_0)
		{
			if (int_0 == 0)
			{
				string_49 = new StackTrace().GetFrame(0).GetMethod().Name;
				return 0;
			}
			ItmeClass value;
			if (World.Itme.TryGetValue(int_0, out value))
			{
				return value.FLD_ZX;
			}
			return 0;
		}

		public int GetWorldItme_Reside1(int int_0)
		{
			if (int_0 == 0)
			{
				string_50 = new StackTrace().GetFrame(0).GetMethod().Name;
				return 0;
			}
			ItmeClass value;
			if (World.Itme.TryGetValue(int_0, out value))
			{
				return value.FLD_RESIDE1;
			}
			return 0;
		}

		public int GetWorldItme_Job_Level(int int_0)
		{
			if (int_0 == 0)
			{
				string_51 = new StackTrace().GetFrame(0).GetMethod().Name;
				return 0;
			}
			ItmeClass value;
			if (World.Itme.TryGetValue(int_0, out value))
			{
				return value.FLD_JOB_LEVEL;
			}
			return 0;
		}

		public void SetPlayer_ExpErience(int int_0, int int_1)
		{
			Players value;
			if (int_0 == 1)
			{
				string_52 = new StackTrace().GetFrame(0).GetMethod().Name;
			}
			else if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				value.Player_ExpErience += int_1;
			}
		}

		public int GetPlayer_ExpErience(int int_0)
		{
			if (int_0 == 1)
			{
				string_53 = new StackTrace().GetFrame(0).GetMethod().Name;
				return 0;
			}
			Players value;
			if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				return value.Player_ExpErience;
			}
			return 0;
		}

		public void SetPlayer_Wx(int int_0, int int_1)
		{
			Players value;
			if (int_0 == 1)
			{
				string_47 = new StackTrace().GetFrame(0).GetMethod().Name;
			}
			else if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				value.Player_WuXun += int_1;
			}
		}

		public int GetPlayer_Wx(int int_0)
		{
			if (int_0 == 1)
			{
				string_46 = new StackTrace().GetFrame(0).GetMethod().Name;
				return 0;
			}
			Players value;
			if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				return value.Player_WuXun;
			}
			return 0;
		}

		public int GetPlayer_Sex(int int_0)
		{
			if (int_0 == 1)
			{
				string_45 = new StackTrace().GetFrame(0).GetMethod().Name;
				return 0;
			}
			Players value;
			if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				return value.Player_Sex;
			}
			return 0;
		}

		public string GetPlayer_Name(int int_0)
		{
			if (int_0 == 1)
			{
				string_38 = new StackTrace().GetFrame(0).GetMethod().Name;
				return string.Empty;
			}
			Players value;
			if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				return value.UserName;
			}
			return string.Empty;
		}

		public int GetPlayer_Qigong_Point(int int_0)
		{
			if (int_0 == 1)
			{
				string_43 = new StackTrace().GetFrame(0).GetMethod().Name;
				return 0;
			}
			Players value;
			if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				return value.Player_Qigong_point;
			}
			return 0;
		}

		public void SetPlayer_Money(int int_0, int int_1)
		{
			Players value;
			if (int_0 == 1)
			{
				string_44 = new StackTrace().GetFrame(0).GetMethod().Name;
			}
			else if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				value.Player_Money += int_1;
			}
		}

		public int GetPlayer_Level(int int_0)
		{
			if (int_0 == 1)
			{
				string_39 = new StackTrace().GetFrame(0).GetMethod().Name;
				return 0;
			}
			Players value;
			if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				return value.Player_Level;
			}
			return 0;
		}

		public int GetPlayer_Job(int int_0)
		{
			if (int_0 == 1)
			{
				string_40 = new StackTrace().GetFrame(0).GetMethod().Name;
				return 0;
			}
			Players value;
			if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				return value.Player_Job;
			}
			return 0;
		}

		public int GetPlayer_Zx(int int_0)
		{
			if (int_0 == 1)
			{
				string_41 = new StackTrace().GetFrame(0).GetMethod().Name;
				return 0;
			}
			Players value;
			if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				return value.Player_Zx;
			}
			return 0;
		}

		public int GetPlayer_Job_Level(int int_0)
		{
			if (int_0 == 1)
			{
				string_42 = new StackTrace().GetFrame(0).GetMethod().Name;
				return 0;
			}
			Players value;
			if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				return value.Player_Job_leve;
			}
			return 0;
		}

		public void 删除任务物品(int int_0, int int_1, int int_2)
		{
			Players value;
			if (int_0 == 1)
			{
				string_1 = new StackTrace().GetFrame(0).GetMethod().Name;
			}
			else if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				value.del任务物品(int_1, int_2);
			}
		}

		public void 计算人物基本数据(int int_0)
		{
			Players value;
			if (int_0 == 1)
			{
				string_3 = new StackTrace().GetFrame(0).GetMethod().Name;
			}
			else if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				value.计算人物基本数据();
			}
		}

		public void 更新HP_MP_SP(int int_0)
		{
			Players value;
			if (int_0 == 1)
			{
				string_0 = new StackTrace().GetFrame(0).GetMethod().Name;
			}
			else if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				value.更新HP_MP_SP();
			}
		}

		public bool 检查任务物品数量(int int_0, int int_1, int int_2)
		{
			if (int_0 == 1)
			{
				string_2 = new StackTrace().GetFrame(0).GetMethod().Name;
				return false;
			}
			Players value;
			if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				return value.检查任务物品数量(int_1, int_2);
			}
			return false;
		}

		public void 追加状态物品(int int_0, int int_1, int int_2, int int_3, int int_4, int int_5)
		{
			Players value;
			if (int_0 == 1)
			{
				string_36 = new StackTrace().GetFrame(0).GetMethod().Name;
			}
			else if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				if (value.追加状态New列表.Count > 0)
				{
					value.新吃药提示();
					return;
				}
				value.Set追加状态物品(int_1, int_2, int_3, int_4);
				value.计算人物装备数据();
				value.更新武功和状态();
				value.物品减去属性数量(int_5, 1);
			}
		}

		public void 学习技能提示(int int_0)
		{
			Players value;
			if (int_0 == 1)
			{
				string_4 = new StackTrace().GetFrame(0).GetMethod().Name;
			}
			else if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				value.学习技能提示();
			}
		}

		public void 设置人物元宝(int int_0, int int_1, int int_2)
		{
			Players value;
			if (int_0 == 1)
			{
				string_5 = new StackTrace().GetFrame(0).GetMethod().Name;
			}
			else if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				value.检察元宝数据(int_1, int_2);
				value.保存元宝数据();
			}
		}

		public void 设置人物会员(int int_0, int int_1)
		{
			Players value;
			if (int_0 == 1)
			{
				string_6 = new StackTrace().GetFrame(0).GetMethod().Name;
			}
			else if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				DateTime fLD_VIPTIM = value.FLD_VIPTIM;
				DateTime fLD_VIPTIM2 = (!(fLD_VIPTIM < DateTime.Now)) ? fLD_VIPTIM.AddMonths(int_1) : DateTime.Now.AddMonths(int_1);
				value.FLD_VIP = 1;
				value.FLD_VIPTIM = fLD_VIPTIM2;
				value.保存会员数据();
			}
		}

		public void 设置玩家等级(int int_0, int int_1)
		{
			Players value;
			if (int_0 == 1)
			{
				string_7 = new StackTrace().GetFrame(0).GetMethod().Name;
			}
			else if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				int num2 = value.Player_Zx = new Random().Next(1, 3);
				value.Player_Job_leve = 0;
				value.Player_WuXun = 0;
				value.Player_Money = 0;
				value.Player_ExpErience = 0;
				value.升天武功点数 = 0;
				value.人物经验 = (long)World.lever[int_1];
				value.Player_Level = int_1;
				value.计算人物基本数据3();
				value.更新经验和历练();
				value.更新金钱和负重();
				value.保存人物数据存储过程();
				value.保存个人仓库存储过程();
				value.保存综合仓库存储过程();
				value.保存帮派数据();
			}
		}

		public void 物品使用(int int_0, int int_1, int int_2)
		{
			Players value;
			if (int_0 == 1)
			{
				string_8 = new StackTrace().GetFrame(0).GetMethod().Name;
			}
			else if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				value.物品使用(1, int_1, int_2);
			}
		}

		public void 删除物品(int int_0, int int_1, int int_2)
		{
			Players value;
			if (int_0 == 1)
			{
				string_9 = new StackTrace().GetFrame(0).GetMethod().Name;
			}
			else if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				value.减去物品(int_1, int_2);
			}
		}

		public int 得到包裹物品(int int_0, int int_1)
		{
			if (int_0 == 1)
			{
				string_10 = new StackTrace().GetFrame(0).GetMethod().Name;
				return 0;
			}
			Players value;
			if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				for (int i = 0; i < 36; i++)
				{
					if (Buffer.ToInt32(value.装备栏包裹[i].物品ID, 0) == int_1)
					{
						return i;
					}
				}
			}
			return -1;
		}

		public void 学习升天武功书(int int_0, int int_1, int int_2)
		{
			Players value;
			if (int_0 == 1)
			{
				string_11 = new StackTrace().GetFrame(0).GetMethod().Name;
			}
			else if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				武功类.学习武功书(value, int_1, int_2);
			}
		}

		public void 初始话已装备物品(int int_0)
		{
			Players value;
			if (int_0 == 1)
			{
				string_12 = new StackTrace().GetFrame(0).GetMethod().Name;
			}
			else if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				value.初始化已装备物品();
			}
		}

		public void 更新经验和历练(int int_0)
		{
			Players value;
			if (int_0 == 1)
			{
				string_13 = new StackTrace().GetFrame(0).GetMethod().Name;
			}
			else if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				value.更新经验和历练();
			}
		}

		public void 更新金钱和负重(int int_0)
		{
			Players value;
			if (int_0 == 1)
			{
				string_14 = new StackTrace().GetFrame(0).GetMethod().Name;
			}
			else if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				value.更新金钱和负重();
			}
		}

		public void 更新武功和状态(int int_0)
		{
			Players value;
			if (int_0 == 1)
			{
				string_15 = new StackTrace().GetFrame(0).GetMethod().Name;
			}
			else if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				value.更新武功和状态();
			}
		}

		public void 新学气功(int int_0, int int_1)
		{
			Players value;
			if (int_0 == 1)
			{
				string_16 = new StackTrace().GetFrame(0).GetMethod().Name;
			}
			else if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				value.新学气功(int_1, 0);
			}
		}

		public void 人物转职业(int int_0, int int_1, int int_2)
		{
			Players value;
			if (int_0 == 1)
			{
				string_17 = new StackTrace().GetFrame(0).GetMethod().Name;
			}
			else if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				value.人物转职业(int_1, int_2);
			}
		}

		public int 得到包裹空位位置(int int_0)
		{
			if (int_0 == 1)
			{
				string_18 = new StackTrace().GetFrame(0).GetMethod().Name;
				return 0;
			}
			Players value;
			if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				return value.得到包裹空位位置();
			}
			return -1;
		}

		public int 得到包裹空位数(int int_0)
		{
			if (int_0 == 1)
			{
				string_37 = new StackTrace().GetFrame(0).GetMethod().Name;
				return -1;
			}
			Players value;
			if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				return value.得到包裹空位数();
			}
			return -1;
		}

		public List<int> 得到包裹空位位置组(int int_0, int int_1)
		{
			if (int_0 == 1)
			{
				string_19 = new StackTrace().GetFrame(0).GetMethod().Name;
				return null;
			}
			Players value;
			if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				return value.得到包裹空位位置组(int_1);
			}
			return new List<int>();
		}

		public int Get任务阶段(int int_0, int int_1)
		{
			if (int_0 == 1)
			{
				string_20 = new StackTrace().GetFrame(0).GetMethod().Name;
				return 0;
			}
			Players value;
			if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				return value.Get任务阶段(int_1);
			}
			return 0;
		}

		public ItmeClass GetWorldItme(int int_0)
		{
			if (int_0 == 0)
			{
				string_21 = new StackTrace().GetFrame(0).GetMethod().Name;
				return null;
			}
			ItmeClass value;
			if (World.Itme.TryGetValue(int_0, out value))
			{
				return value;
			}
			return null;
		}

		public Players GetPlayerThis(int int_0)
		{
			if (int_0 == 1)
			{
				string_22 = new StackTrace().GetFrame(0).GetMethod().Name;
				return null;
			}
			Players value;
			if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				return value;
			}
			return null;
		}

		public void 增加物品Script(int int_0, int int_1, int int_2, int int_3)
		{
			Players value;
			if (int_0 == 1)
			{
				string_23 = new StackTrace().GetFrame(0).GetMethod().Name;
			}
			else if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				value.增加物品Script(int_1, int_2, int_3);
			}
		}

		public bool 得到任务物品(int int_0, int int_1, int int_2)
		{
			if (int_0 == 1)
			{
				string_24 = new StackTrace().GetFrame(0).GetMethod().Name;
				return false;
			}
			Players value;
			if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				return value.得到任务物品(int_1, int_2);
			}
			return false;
		}

		public void 增加任务物品(int int_0, int int_1, int int_2)
		{
			Players value;
			if (int_0 == 1)
			{
				string_25 = new StackTrace().GetFrame(0).GetMethod().Name;
			}
			else if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				value.设置任务物品(int_1, int_2);
			}
		}

		public void 增加物品带属性(int int_0, int int_1, int int_2, int int_3, int int_4, int int_5, int int_6, int int_7, int int_8, int int_9, int int_10, int int_11, int int_12, int int_13)
		{
			Players value;
			if (int_0 == 1)
			{
				string_26 = new StackTrace().GetFrame(0).GetMethod().Name;
			}
			else if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				value.增加物品带属性(int_1, int_2, int_3, int_4, int_5, int_6, int_7, int_8, int_9, int_10, int_11, int_12, int_13);
			}
		}

		public void 任务提示数据发送(int int_0, int int_1, int int_2, int int_3)
		{
			Players value;
			if (int_0 == 1)
			{
				string_27 = new StackTrace().GetFrame(0).GetMethod().Name;
			}
			else if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				value.任务提示数据发送(int_1, int_2, int_3);
			}
		}

		public void 系统提示(int int_0, string string_54, int int_1, string string_55)
		{
			Players value;
			if (int_0 == 1)
			{
				string_28 = new StackTrace().GetFrame(0).GetMethod().Name;
			}
			else if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				value.系统提示(string_54, int_1, string_55);
			}
		}

		public void 设置任务数据(int int_0, int int_1, int int_2)
		{
			Players value;
			if (int_0 == 1)
			{
				string_29 = new StackTrace().GetFrame(0).GetMethod().Name;
			}
			else if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				value.设置任务数据(int_1, int_2);
			}
		}

		public void 学习技能(int int_0, int int_1, int int_2)
		{
			Players value;
			if (int_0 == 1)
			{
				string_30 = new StackTrace().GetFrame(0).GetMethod().Name;
			}
			else if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				value.学习技能(int_1, int_2);
			}
		}

		public void 发送六转技能书(int int_0, int int_1)
		{
			Players value;
			if (int_0 == 1)
			{
				string_31 = new StackTrace().GetFrame(0).GetMethod().Name;
			}
			else if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				value.发送六转技能书(int_1);
			}
		}

		public void 发送七转技能书(int int_0, int int_1)
		{
			Players value;
			if (int_0 == 1)
			{
				string_32 = new StackTrace().GetFrame(0).GetMethod().Name;
			}
			else if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				value.发送七转技能书(int_1);
			}
		}

		public void 发送八转技能书(int int_0, int int_1)
		{
			Players value;
			if (int_0 == 1)
			{
				string_33 = new StackTrace().GetFrame(0).GetMethod().Name;
			}
			else if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				value.发送八转技能书(int_1);
			}
		}

		public void 发送九转技能书(int int_0, int int_1)
		{
			Players value;
			if (int_0 == 1)
			{
				string_34 = new StackTrace().GetFrame(0).GetMethod().Name;
			}
			else if (World.allConnectedChars.TryGetValue(int_0, out value))
			{
				value.发送九转技能书(int_1);
			}
		}

		public void 发送公告(string string_54, int int_0)
		{
			if (string_54 == "1")
			{
				string_35 = new StackTrace().GetFrame(0).GetMethod().Name;
			}
			else
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
								value.系统公告(string_54);
								break;
							case 1:
								value.系统滚动公告(string_54);
								break;
							case 2:
								value.系统提示(string_54, 10, "系统信息");
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
		}
	}
}
