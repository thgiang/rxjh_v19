using RxjhServer.DbClss;
using RxjhServer.HelperTools;
using RxjhServer.Network;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Timers;

namespace RxjhServer
{
	public class PlayersBes : 气功属性
	{
		private object thisLock = new object();

		public List<Players> tem = new List<Players>();

		public List<int> 快捷栏 = new List<int>();

		public List<int> 得到门徽ID = new List<int>();

		public float Speed = 127f;

		public 武功类[,] 武功新 = new 武功类[4, 32];

		public int 行走状态id = 1;

		public System.Timers.Timer 查坐标 = new System.Timers.Timer(6000.0);

		private byte[] 样式 = Converter.hexStringToByte("00000000030000000000FFFF0000FFFF");

		public double 拳师会心一击威力 = 0.3;

		public string 婚戒刻字 = string.Empty;

		public float 最大移动速度 = 100f;

		public int 证婚人提问答案 = 2;

		public string Temp游戏安全码 = string.Empty;

		public string 游戏安全码 = string.Empty;

		public string 商店名 = string.Empty;

		private string string_0 = string.Empty;

		private string string_1 = string.Empty;

		private string string_2 = string.Empty;

		private string string_3 = string.Empty;

		private string string_4 = string.Empty;

		private string string_5 = string.Empty;

		private string string_6 = string.Empty;

		private bool bool_0 = true;

		public string _势力战派别 = string.Empty;

		public string 客户端设置 = string.Empty;

		public byte[] 移动封包 = new byte[52];

		public Dictionary<int, ServerList> SerList;

		public System.Timers.Timer 无敌时间计数器;

		public System.Timers.Timer 移动地图计时器;

		public System.Timers.Timer 障力恢复时间计数器;

		public bool 刺客发起技能加成;

		public double 刺客物理攻击加成;

		public double 刺客魔法攻击加成;

		public double 升天气功武功等级;

		public bool 是否更新配置;

		public bool 上线;

		public bool 存档时间;

		public ConfigClass Config;

		public bool PK死亡;

		public bool Player无敌;

		public bool 打开商店中;

		public bool 打开交易;

		public bool 打开个人商店;

		public bool 退出中;

		public bool 进店中;

		public bool 妖花青草;

		public int 进店中ID;

		public bool 打开仓库中;

		public Dictionary<int, 个人传书类> 传书列表;

		private NetState netState_0;

		public bool FLD_是否可以送花;

		public int _当前操作NPC;

		public int 凝神宝珠位置;

		public int 心跳次数阀值;

		public bool 打坐;

		public int PVP分数;

		public int PVP逃跑次数;

		public Dictionary<int, 公有药品类> 符列表;

		public int _当前操作类型;

		public Dictionary<int, string> allChars;

		public 坐标Class 新坐标;

		public 灵兽类 人物灵兽;

		public ThreadSafeDictionary<int, NpcClass> NpcList;

		public ThreadSafeDictionary<double, 地面物品类> 地面物品列表;

		public Hashtable 土灵符坐标;

		public ThreadSafeDictionary<int, 追加状态类> 追加状态列表;

		public ThreadSafeDictionary<int, 追加状态New类> 追加状态New列表;

		public ThreadSafeDictionary<int, 异常状态类> 异常状态;

		public ThreadSafeDictionary<int, 异常状态攻击类> 异常攻击状态;

		public ThreadSafeDictionary<int, 异常状态防御类> 异常防御状态;

		public ThreadSafeDictionary<int, 异常掉蓝状态类> 异常掉蓝状态;

		public ThreadSafeDictionary<int, 异常掉血状态类> 异常掉血状态;

		public int 称号积分;

		public ThreadSafeDictionary<int, 神女异常状态类> 神女异常状态;

		public Dictionary<int, 时间药品类> 时间药品;

		public bool 怒;

		public List<攻击类> 攻击列表;

		public List<int> 玉连环;

		public List<武功类> 新武功连击;

		public SortedDictionary<int, 升天气功类> 升天气功;

		public 个人商店类 个人商店;

		public int 武功连击记数器;

		public int 装备数据版本;

		public int 综合仓库装备数据版本;

		public 物品类[] 个人仓库;

		public 物品类[] 公共仓库;

		public 物品类[] 装备栏包裹;

		public 物品类[] 披风行囊;

		public 物品类[] 装备栏已穿装备;

		public 物品类[] 辅助装备栏装备;

		public 气功类[] 气功;

		public 任务物品类[] 任务物品;

		public Dictionary<int, 任务类> 任务;

		public Dictionary<int, int> 已完成任务;

		public 师徒类 师傅数据;

		public 师徒类[] 徒弟数据;

		public double 当前移动距离;

		public double 人物距离计算;

		public bool 触发杀星义气虎;

		public bool 触发杀星义气杀;

		public float destX;

		public float destY;

		public float destZ;

		public float fromX;

		public float fromY;

		public float fromZ;

		public float reach;

		public 交易类 交易;

		public int GM模式;

		public int 组队id;

		public int 组队阶段;

		public int 潜行模式;

		public double 刺_连消带打数量;

		public double 韩飞官_天魔狂血攻击力;

		public int 韩飞官_天魔狂血叠加次数;

		public byte[] 个人药品;

		public byte[] 追加状态物品New;

		public double 爆毒状态;

		public int 隐身状态id;

		public int 关起来;

		public int 安全模式;

		public int 升天历练当前获得数;

		public int 升天历练数;

		public int 升天武功点数;

		public int 神女武功点数;

		public bool 跑走;

		public int 修炼地图剩余时间;

		public int 活动地图剩余时间;

		public int 天地同寿回避次数;

		public int 天地同寿回避累积攻击力;

		public DateTime FBtime;

		public DateTime PKhmtime;

		public DateTime SThmtime;

		public DateTime XThmtime;

		public DateTime CWhmtime;

		public DateTime TMJCtime;

		public int 丢失武勋;

		public int 装备追加对怪攻击;

		public int 装备追加对怪防御;

		public int 药品追加对怪攻击;

		public int 药品追加对怪防御;

		public int FLD_药品_追加_气功;

		public int 每日获得武勋;

		public int 武皇通币;

		public int 拳师连击控制;

		public int 锁定人物几率;

		public bool 人物锁定;

		public float AttackX;

		public float AttackY;

		public int 攻击次数;

		public float lastX;

		public float lastY;

		public int lastMAP;

		public bool 中毒;

		public bool 是否携带披风行囊;

		public int 解除关系倒计时;

		public int 是否已婚;

		public int 安全码操作ID;

		public bool 安全码是否通过验证;

		public int 交易人物ID;

		public int 交易操作ID;

		public bool 触发地图移动事件;

		public bool 触发鸾凤和鸣;

		public int 触发属性提升;

		public bool 触发流星漫天;

		public bool 万毒不侵;

		public bool 夫妻组队中;

		public int 玫瑰称号积分;

		public int 行走状态id1;

		public int 门派称号类型;

		public int 称号排名;

		public string _人物分区ID;

		private int int_0;

		public int _夫妻武功攻击力MP;

		public int _人物封包ID;

		private string string_7;

		private int int_1;

		private int int_2;

		private int int_3;

		private string string_8;

		private int int_4;

		private int int_5;

		private int int_6;

		private int int_7;

		private int int_8;

		private bool bool_1;

		private int int_9;

		private int int_10;

		private int int_11;

		private int int_12;

		private int int_13;

		private int int_14;

		private byte[] _帮派门徽;

		private int int_15;

		private int int_16;

		private long long_0;

		private long long_1;

		private long long_2;

		private int int_17;

		private int int_18;

		private int int_19;

		private int int_20;

		private int int_21;

		private int int_22;

		private int int_23;

		private int int_24;

		private int int_25;

		private int int_26;

		private int int_27;

		private int int_28;

		private int int_29;

		private int int_30;

		private int int_31;

		private int int_32;

		private int int_33;

		private int int_34;

		private int int_35;

		private int int_36;

		private int int_37;

		private int int_38;

		private int int_39;

		private int int_40;

		private int int_41;

		private int int_42;

		private int int_43;

		private int int_44;

		private int int_45;

		private int int_46;

		private int int_47;

		public 人物模板类 New人物模版;

		private byte[] _人物名字模版;

		private int int_48;

		private float float_0;

		private float float_1;

		private float float_2;

		private int int_49;

		private int int_50;

		private int int_51;

		private int int_52;

		private long long_3;

		private long long_4;

		private int int_53;

		private int int_54;

		private int int_55;

		public Dictionary<int, 公有药品类> 公有药品;

		public Dictionary<int, 称号药品类> 称号药品;

		private int int_56;

		private int int_57;

		private DateTime dateTime_0;

		private int int_58;

		private int int_59;

		private int int_60;

		private int int_61;

		private string string_9;

		private int int_62;

		private DateTime dateTime_1;

		public int 中级附魂_复仇;

		public int 中级附魂_吸魂;

		public int 中级附魂_奇缘;

		public int 中级附魂_愤怒;

		public int 中级附魂_移星;

		public int 中级附魂_护体;

		public int 中级附魂_混元;

		public int _FLD_荣誉ID;

		public int _武林荣誉ID_;

		public bool _Player死亡;

		private int int_63;

		private bool bool_2;

		private bool bool_3;

		private int int_64;

		private string string_10;

		private double double_173;

		private double double_174;

		private double double_175;

		private double double_176;

		private double double_177;

		private double double_178;

		private int int_65;

		private int int_66;

		private int int_67;

		private int int_68;

		private int int_69;

		private double double_179;

		private int int_70;

		private int int_71;

		private int int_72;

		private int int_73;

		private DateTime dateTime_2;

		private double double_180;

		private int int_74;

		private int int_75;

		private int int_76;

		private int int_77;

		private double double_181;

		private double double_182;

		private double double_183;

		private double double_184;

		private int int_78;

		private int int_79;

		private int int_80;

		private int int_81;

		private int int_82;

		private double double_185;

		private double double_186;

		private double double_187;

		private double double_188;

		private int int_83;

		private int int_84;

		private int int_85;

		private int int_86;

		private int int_87;

		private int int_88;

		private double double_189;

		private double double_190;

		private double double_191;

		private double double_192;

		private double double_193;

		private double double_194;

		private double double_195;

		private double double_196;

		private double double_197;

		private double double_198;

		private int int_89;

		private int int_90;

		private int int_91;

		private int int_92;

		private int int_93;

		private int int_94;

		private double double_199;

		private double double_200;

		private double double_201;

		private int int_95;

		private double double_202;

		private double double_203;

		private int int_96;

		private double double_204;

		private double double_205;

		private int int_97;

		private int int_98;

		private double double_206;

		private double double_207;

		private double double_208;

		private double double_209;

		private double double_210;

		private double double_211;

		private double double_212;

		private double double_213;

		private double double_214;

		private double double_215;

		private double double_216;

		private double double_217;

		private double double_218;

		private double double_219;

		private int int_99;

		private int int_100;

		private int int_101;

		private int int_102;

		private double double_220;

		private double double_221;

		private double double_222;

		private double double_223;

		private double double_224;

		private double double_225;

		private double double_226;

		private double double_227;

		private double double_228;

		private double double_229;

		private double double_230;

		private double double_231;

		private double double_232;

		private double double_233;

		private double double_234;

		private double double_235;

		private double double_236;

		private double double_237;

		private double double_238;

		private double double_239;

		private double double_240;

		private double double_241;

		private double double_242;

		private double double_243;

		private double double_244;

		private double double_245;

		private double double_246;

		private double double_247;

		private double double_248;

		private double double_249;

		private double double_250;

		private double double_251;

		private double double_252;

		private double double_253;

		private double double_254;

		private double double_255;

		private double double_256;

		private double double_257;

		private double double_258;

		private double double_259;

		private double double_260;

		private double double_261;

		private double double_262;

		private double double_263;

		private int int_103;

		private int int_104;

		private int int_105;

		private int int_106;

		private int int_107;

		public int 武器攻击力;

		public double 武器武功攻击力百分比;

		public int 衣服防御力;

		public double 衣服武功防御力百分比;

		public int FLD_爱情度等级;

		public int _门派贡献度;

		private int int_108;

		public string _FLD_情侣戒指;

		public double _FLD_药品_减少攻击;

		public double _FLD_药品_减少防御;

		public int _玫瑰称号追加HP;

		public int _玫瑰称号追加防御;

		public int _玫瑰称号追加攻击;

		public int _门派称号追加HP;

		public int _门派称号追加防御;

		public int _门派称号追加攻击;

		public int _称号追加HP;

		public int _称号追加防御;

		public int _称号追加攻击;

		public int _人物追加战力;

		public int _人物追加武勋战力;

		public double _FLD_追加哀鸿片野_HP上限;

		public int _FLD_最小攻击;

		public double _FLD_人物_追加_武功防御力;

		public double _FLD_灵宠_追加_经验百分比;

		public double _FLD_灵宠_追加_历练百分比;

		public int _FLD_装备_追加_武功命中;

		public int _FLD_装备_追加_武功回避;

		public int _减免对方伤害;

		public int _FLD_装备_增加异常;

		public int _FLD_装备_增加对方异常;

		public int _FLD_神女_追加_攻击;

		public int _FLD_神女_追加_防御;

		public string 人物分区ID
		{
			get
			{
				return _人物分区ID;
			}
			set
			{
				_人物分区ID = value;
			}
		}

		public int 门派贡献度
		{
			get
			{
				return _门派贡献度;
			}
			set
			{
				_门派贡献度 = value;
			}
		}

		public int Player_Whtb
		{
			get
			{
				return int_108;
			}
			set
			{
				if (value < 0)
				{
					int_108 = 0;
				}
				else
				{
					int_108 = value;
				}
			}
		}

		public int 当前操作NPC
		{
			get
			{
				return _当前操作NPC;
			}
			set
			{
				_当前操作NPC = value;
			}
		}

		public int 当前操作类型
		{
			get
			{
				return _当前操作类型;
			}
			set
			{
				_当前操作类型 = value;
			}
		}

		public NetState Client
		{
			get
			{
				return netState_0;
			}
			set
			{
				netState_0 = value;
			}
		}

		public int 夫妻武功攻击力
		{
			get
			{
				if (夫妻组队中)
				{
					return (int)((double)int_0 + (double)int_0 * 0.1);
				}
				return int_0;
			}
			set
			{
				int_0 = value;
			}
		}

		public int 夫妻武功攻击力MP
		{
			get
			{
				if (夫妻组队中)
				{
					return (int)((double)_夫妻武功攻击力MP + (double)_夫妻武功攻击力MP * 0.1);
				}
				return _夫妻武功攻击力MP;
			}
			set
			{
				_夫妻武功攻击力MP = value;
			}
		}

		public int 人物灵兽全服ID
		{
			get
			{
				return 人物全服ID * 2 + 40000;
			}
		}

		public int 人物位置
		{
			get
			{
				return int_5;
			}
			set
			{
				int_5 = value;
			}
		}

		public int 人物轻功
		{
			get
			{
				return int_6;
			}
			set
			{
				int_6 = value;
			}
		}

		public int 琴师状态
		{
			get
			{
				return int_7;
			}
			set
			{
				int_7 = value;
			}
		}

		public int 当前激活技能ID
		{
			get
			{
				return int_8;
			}
			set
			{
				int_8 = value;
			}
		}

		public bool 弓群攻触发心神
		{
			get
			{
				return bool_1;
			}
			set
			{
				bool_1 = value;
			}
		}

		public string Userid
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

		public string Password
		{
			get
			{
				return string_1;
			}
			set
			{
				string_1 = value;
			}
		}

		public string lastloginip
		{
			get
			{
				return string_2;
			}
			set
			{
				string_2 = value;
			}
		}

		public string 绑定帐号
		{
			get
			{
				return string_3;
			}
			set
			{
				string_3 = value;
			}
		}

		public int 势力战杀人数
		{
			get
			{
				return int_9;
			}
			set
			{
				int_9 = value;
			}
		}

		public int 势力战死亡数
		{
			get
			{
				return int_10;
			}
			set
			{
				int_10 = value;
			}
		}

		public string UserName
		{
			get
			{
				return string_4;
			}
			set
			{
				string_4 = value;
			}
		}

		public int 帮派Id
		{
			get
			{
				return int_11;
			}
			set
			{
				int_11 = value;
			}
		}

		public string 帮派名字
		{
			get
			{
				return string_5;
			}
			set
			{
				string_5 = value;
			}
		}

		public int 帮派等级
		{
			get
			{
				return int_12;
			}
			set
			{
				int_12 = value;
			}
		}

		public int 帮派人物等级
		{
			get
			{
				return int_13;
			}
			set
			{
				int_13 = value;
			}
		}

		public int 帮派门服字
		{
			get
			{
				return int_14;
			}
			set
			{
				int_14 = value;
			}
		}

		public byte[] 帮派门徽
		{
			get
			{
				return _帮派门徽;
			}
			set
			{
				_帮派门徽 = value;
			}
		}

		public int 帮派门服颜色
		{
			get
			{
				return int_15;
			}
			set
			{
				int_15 = value;
			}
		}

		public int Player_ExpErience
		{
			get
			{
				return int_16;
			}
			set
			{
				int_16 = value;
			}
		}

		public long 人物经验
		{
			get
			{
				return long_0;
			}
			set
			{
				long_0 = value;
			}
		}

		public long 人物最大经验
		{
			get
			{
				return long_1;
			}
			set
			{
				long_1 = value;
			}
		}

		public long Player_Money
		{
			get
			{
				return long_2;
			}
			set
			{
				if (value < 0L)
				{
					long_2 = 0L;
				}
				else
				{
					long_2 = value;
				}
			}
		}

		public int 上河调计数
		{
			get
			{
				return int_17;
			}
			set
			{
				int_17 = value;
			}
		}

		public int 下河调计数
		{
			get
			{
				return int_18;
			}
			set
			{
				int_18 = value;
			}
		}

		public int 玉连环计数
		{
			get
			{
				return int_19;
			}
			set
			{
				int_19 = value;
			}
		}

		public int 人物_HP
		{
			get
			{
				return int_20;
			}
			set
			{
				int_20 = value;
			}
		}

		public int 人物_WX_BUFF_生命
		{
			get
			{
				return int_21;
			}
			set
			{
				int_21 = value;
			}
		}

		public int 人物_WX_BUFF_攻击
		{
			get
			{
				return int_22;
			}
			set
			{
				int_22 = value;
			}
		}

		public int 人物_WX_BUFF_防御
		{
			get
			{
				return int_23;
			}
			set
			{
				int_23 = value;
			}
		}

		public int 人物_WX_BUFF_回避
		{
			get
			{
				return int_24;
			}
			set
			{
				int_24 = value;
			}
		}

		public int 人物_WX_BUFF_内功
		{
			get
			{
				return int_25;
			}
			set
			{
				int_25 = value;
			}
		}

		public int 人物_WX_BUFF_命中
		{
			get
			{
				return int_26;
			}
			set
			{
				int_26 = value;
			}
		}

		public int 人物_WX_BUFF_气功
		{
			get
			{
				return int_27;
			}
			set
			{
				int_27 = value;
			}
		}

		public int FLD_人物基本_攻击
		{
			get
			{
				if (FLD_追加百分比_攻击 < 1E-05)
				{
					FLD_追加百分比_攻击 = 0.0;
				}
				return (int)(((double)(FLD_攻击 + FLD_装备_追加_攻击 + FLD_人物_追加_攻击) + FLD_人物_气功_攻击) * (1.0 + FLD_追加百分比_攻击 + FLD_药品_减少攻击)) + 人物_WX_BUFF_攻击 + FLD_宠物_追加_攻击 + 称号追加攻击 + 玫瑰称号追加攻击 + 门派称号追加攻击;
			}
		}

		public int FLD_人物基本_命中
		{
			get
			{
				if (FLD_追加百分比_命中 < 0.0001)
				{
					FLD_追加百分比_命中 = 0.0;
				}
				if (FLD_装备_追加_命中百分比 < 0.0001)
				{
					FLD_装备_追加_命中百分比 = 0.0;
				}
				return (int)((double)(FLD_命中 + FLD_装备_追加_命中 + FLD_人物_追加_命中 + FLD_人物_气功_命中) * (1.0 + FLD_追加百分比_命中 + FLD_装备_追加_命中百分比)) + 人物_WX_BUFF_命中;
			}
		}

		public int FLD_人物基本_防御
		{
			get
			{
				if (FLD_追加百分比_防御 < 0.0001)
				{
					FLD_追加百分比_防御 = 0.0;
				}
				return (int)((double)(FLD_防御 + FLD_装备_追加_防御 + FLD_人物_追加_防御) * (1.0 + FLD_追加百分比_防御 + FLD_药品_减少防御)) + 人物_WX_BUFF_防御 + FLD_宠物_追加_防御 + FLD_人物_气功_防御 + 称号追加防御 + 玫瑰称号追加防御 + 门派称号追加防御;
			}
		}

		public int FLD_人物基本_防御New
		{
			get
			{
				if (FLD_追加百分比_防御 < 0.0001)
				{
					FLD_追加百分比_防御 = 0.0;
				}
				return (int)((double)(FLD_防御 + FLD_装备_追加_防御New + FLD_人物_追加_防御) * (1.0 + FLD_追加百分比_防御 + FLD_药品_减少防御)) + 人物_WX_BUFF_防御 + FLD_宠物_追加_防御 + FLD_人物_气功_防御 + 称号追加防御 + 玫瑰称号追加防御 + 门派称号追加防御;
			}
		}

		public int FLD_人物基本_回避
		{
			get
			{
				if (FLD_人物_追加百分比_回避 < 0.0001)
				{
					FLD_人物_追加百分比_回避 = 0.0;
				}
				if (FLD_装备_追加_回避百分比 < 0.0001)
				{
					FLD_装备_追加_回避百分比 = 0.0;
				}
				return (int)((double)(FLD_回避 + FLD_装备_追加_回避 + FLD_人物_追加_回避 + FLD_人物_气功_回避) * (1.0 + FLD_人物_追加百分比_回避 + FLD_装备_追加_回避百分比)) + 人物_WX_BUFF_回避;
			}
		}

		public int 人物最大_HP
		{
			get
			{
				if (FLD_追加百分比_HP上限 < 0.0001)
				{
					FLD_追加百分比_HP上限 = 0.0;
				}
				return (int)((double)(人物基本最大_HP + FLD_装备_追加_HP + 人物_气功_追加_HP + 人物追加最大_HP) * (1.0 + FLD_追加百分比_HP上限 + FLD_追加哀鸿片野_HP上限)) + 人物_WX_BUFF_生命 + FLD_宠物_追加_最大HP + 称号追加HP + 玫瑰称号追加HP + 门派称号追加HP;
			}
		}

		public int 人物最大_MP
		{
			get
			{
				if (FLD_追加百分比_MP上限 < 0.0001)
				{
					FLD_追加百分比_MP上限 = 0.0;
				}
				return (int)((double)(人物基本最大_MP + FLD_装备_追加_MP + 人物_气功_追加_MP + 人物追加最大_MP) * (1.0 + FLD_追加百分比_MP上限)) + 人物_WX_BUFF_内功;
			}
		}

		public int 人物最大_AP
		{
			get
			{
				return 人物基本最大_障力 + FLD_装备_追加_障力;
			}
		}

		public double 人物_追加_经验百分比
		{
			get
			{
				return FLD_人物_追加_经验百分比;
			}
		}

		public int 人物_气功_追加_HP
		{
			get
			{
				return int_28;
			}
			set
			{
				int_28 = value;
			}
		}

		public int 人物_气功_追加_武功防御力
		{
			get
			{
				return int_29;
			}
			set
			{
				int_29 = value;
			}
		}

		public int 人物基本最大_HP
		{
			get
			{
				return int_30;
			}
			set
			{
				int_30 = value;
			}
		}

		public int 人物追加最大_HP
		{
			get
			{
				return int_31;
			}
			set
			{
				int_31 = value;
			}
		}

		public int 人物_MP
		{
			get
			{
				return int_32;
			}
			set
			{
				int_32 = value;
			}
		}

		public int 人物_AP
		{
			get
			{
				return int_33;
			}
			set
			{
				int_33 = value;
			}
		}

		public int 人物基本最大_MP
		{
			get
			{
				return int_34;
			}
			set
			{
				int_34 = value;
			}
		}

		public int 人物追加最大_MP
		{
			get
			{
				return int_35;
			}
			set
			{
				int_35 = value;
			}
		}

		public int 人物_气功_追加_MP
		{
			get
			{
				return int_36;
			}
			set
			{
				int_36 = value;
			}
		}

		public int 人物基本最大_障力
		{
			get
			{
				return int_37;
			}
			set
			{
				int_37 = value;
			}
		}

		public int 人物_SP
		{
			get
			{
				return int_38;
			}
			set
			{
				int_38 = value;
			}
		}

		public int 人物最大_SP
		{
			get
			{
				return int_39;
			}
			set
			{
				int_39 = value;
			}
		}

		public int Player_Qigong_point
		{
			get
			{
				return int_40;
			}
			set
			{
				int_40 = value;
			}
		}

		public int Player_Zx
		{
			get
			{
				return int_41;
			}
			set
			{
				int_41 = value;
			}
		}

		public int Player_Level
		{
			get
			{
				return int_42;
			}
			set
			{
				int_42 = value;
			}
		}

		public int Player_WuXun
		{
			get
			{
				return int_43;
			}
			set
			{
				int_43 = value;
			}
		}

		public int 武勋阶段
		{
			get
			{
				return int_44;
			}
			set
			{
				int_44 = value;
			}
		}

		public int 人物善恶
		{
			get
			{
				return int_45;
			}
			set
			{
				if (int_45 + value > 0)
				{
					int_45 = 0;
				}
				else if (int_45 - value < -30000)
				{
					int_45 = -30000;
				}
				else
				{
					int_45 = value;
				}
			}
		}

		public int Player_Job
		{
			get
			{
				return int_46;
			}
			set
			{
				int_46 = value;
			}
		}

		public int Player_Job_leve
		{
			get
			{
				return int_47;
			}
			set
			{
				int_47 = value;
			}
		}

		public byte[] 人物名字模版
		{
			get
			{
				return _人物名字模版;
			}
			set
			{
				_人物名字模版 = value;
			}
		}

		public int Player_Sex
		{
			get
			{
				return int_48;
			}
			set
			{
				int_48 = value;
			}
		}

		public float 人物坐标_X
		{
			get
			{
				return float_0;
			}
			set
			{
				float_0 = value;
			}
		}

		public float 人物坐标_Y
		{
			get
			{
				return float_1;
			}
			set
			{
				float_1 = value;
			}
		}

		public float 人物坐标_Z
		{
			get
			{
				return float_2;
			}
			set
			{
				float_2 = value;
			}
		}

		public int 人物坐标_地图
		{
			get
			{
				return int_49;
			}
			set
			{
				int_49 = value;
			}
		}

		public int 人物当前负重
		{
			get
			{
				return int_50;
			}
			set
			{
				int_50 = value;
			}
		}

		public int 人物负重总
		{
			get
			{
				return int_51 + FLD_人物_气功_负重;
			}
			set
			{
				int_51 = value;
			}
		}

		public int 人物封包ID
		{
			get
			{
				return _人物封包ID;
			}
			set
			{
				_人物封包ID = value;
			}
		}

		public string 原服务器IP
		{
			get
			{
				return string_7;
			}
			set
			{
				string_7 = value;
			}
		}

		public int 原服务器端口
		{
			get
			{
				return int_1;
			}
			set
			{
				int_1 = value;
			}
		}

		public int 原服务器序号
		{
			get
			{
				return int_2;
			}
			set
			{
				int_2 = value;
			}
		}

		public int 原服务器ID
		{
			get
			{
				return int_3;
			}
			set
			{
				int_3 = value;
			}
		}

		public string 银币广场服务器IP
		{
			get
			{
				return string_8;
			}
			set
			{
				string_8 = value;
			}
		}

		public int 银币广场服务器端口
		{
			get
			{
				return int_4;
			}
			set
			{
				int_4 = value;
			}
		}

		public int 人物全服ID
		{
			get
			{
				return Client.WorldId;
			}
		}

		public int 人物PK模式
		{
			get
			{
				return int_52;
			}
			set
			{
				int_52 = value;
			}
		}

		public long 个人仓库钱数
		{
			get
			{
				return long_3;
			}
			set
			{
				long_3 = value;
			}
		}

		public long 综合仓库钱数
		{
			get
			{
				return long_4;
			}
			set
			{
				long_4 = value;
			}
		}

		public int FLD_RXPIONT
		{
			get
			{
				return int_53;
			}
			set
			{
				int_53 = value;
			}
		}

		public int FLD_RXPIONTX
		{
			get
			{
				return int_54;
			}
			set
			{
				int_54 = value;
			}
		}

		public int FLD_Coin
		{
			get
			{
				return int_55;
			}
			set
			{
				int_55 = value;
			}
		}

		public int Rxjh_WX
		{
			get
			{
				return int_56;
			}
			set
			{
				int_56 = value;
			}
		}

		public int FLD_VIP
		{
			get
			{
				return int_57;
			}
			set
			{
				int_57 = value;
			}
		}

		public DateTime FLD_VIPTIM
		{
			get
			{
				return dateTime_0;
			}
			set
			{
				dateTime_0 = value;
			}
		}

		public int FLD_攻击速度
		{
			get
			{
				return int_58;
			}
			set
			{
				int_58 = value;
			}
		}

		public int FLD_制作类型
		{
			get
			{
				return int_59;
			}
			set
			{
				int_59 = value;
			}
		}

		public int FLD_制作等级
		{
			get
			{
				return int_60;
			}
			set
			{
				int_60 = value;
			}
		}

		public int FLD_制作熟练度
		{
			get
			{
				return int_61;
			}
			set
			{
				if (value >= 1500)
				{
					int_61 = 1500;
				}
				else
				{
					int_61 = value;
				}
			}
		}

		public string FLD_情侣
		{
			get
			{
				return string_9;
			}
			set
			{
				string_9 = value;
			}
		}

		public string FLD_情侣戒指
		{
			get
			{
				return _FLD_情侣戒指;
			}
			set
			{
				_FLD_情侣戒指 = value;
			}
		}

		public int FLD_情侣_爱情度
		{
			get
			{
				return int_62;
			}
			set
			{
				int_62 = value;
			}
		}

		public string FLD_临时师徒
		{
			get
			{
				return string_6;
			}
			set
			{
				string_6 = value;
			}
		}

		public bool 可结成师徒关系状态
		{
			get
			{
				return bool_0;
			}
			set
			{
				bool_0 = value;
			}
		}

		public DateTime 解除师徒关系时间
		{
			get
			{
				return dateTime_1;
			}
			set
			{
				dateTime_1 = value;
			}
		}

		public int FLD_荣誉ID
		{
			get
			{
				return _FLD_荣誉ID;
			}
			set
			{
				_FLD_荣誉ID = value;
			}
		}

		public int 荣誉ID_
		{
			get
			{
				return _武林荣誉ID_;
			}
			set
			{
				_武林荣誉ID_ = value;
			}
		}

		public bool Player死亡
		{
			get
			{
				if (人物_HP <= 0)
				{
					_Player死亡 = true;
				}
				return _Player死亡;
			}
			set
			{
				_Player死亡 = value;
			}
		}

		public string 势力战派别
		{
			get
			{
				return _势力战派别;
			}
			set
			{
				_势力战派别 = value;
			}
		}

		public int FLD_PVP_Piont
		{
			get
			{
				return int_63;
			}
			set
			{
				int_63 = value;
			}
		}

		public bool 元宝账户状态
		{
			get
			{
				return bool_2;
			}
			set
			{
				bool_2 = value;
			}
		}

		public bool 是否押注
		{
			get
			{
				return bool_3;
			}
			set
			{
				bool_3 = value;
			}
		}

		public int 押注专场代码
		{
			get
			{
				return int_64;
			}
			set
			{
				int_64 = value;
			}
		}

		public string 押注单双
		{
			get
			{
				return string_10;
			}
			set
			{
				string_10 = value;
			}
		}

		public double FLD_药品_减少攻击
		{
			get
			{
				return _FLD_药品_减少攻击;
			}
			set
			{
				_FLD_药品_减少攻击 = value;
			}
		}

		public double FLD_药品_减少防御
		{
			get
			{
				return _FLD_药品_减少防御;
			}
			set
			{
				_FLD_药品_减少防御 = value;
			}
		}

		public int 玫瑰称号追加HP
		{
			get
			{
				return _玫瑰称号追加HP;
			}
			set
			{
				_玫瑰称号追加HP = value;
			}
		}

		public int 玫瑰称号追加防御
		{
			get
			{
				return _玫瑰称号追加防御;
			}
			set
			{
				_玫瑰称号追加防御 = value;
			}
		}

		public int 玫瑰称号追加攻击
		{
			get
			{
				return _玫瑰称号追加攻击;
			}
			set
			{
				_玫瑰称号追加攻击 = value;
			}
		}

		public int 门派称号追加HP
		{
			get
			{
				return _门派称号追加HP;
			}
			set
			{
				_门派称号追加HP = value;
			}
		}

		public int 门派称号追加防御
		{
			get
			{
				return _门派称号追加防御;
			}
			set
			{
				_门派称号追加防御 = value;
			}
		}

		public int 门派称号追加攻击
		{
			get
			{
				return _门派称号追加攻击;
			}
			set
			{
				_门派称号追加攻击 = value;
			}
		}

		public int 称号追加HP
		{
			get
			{
				return _称号追加HP;
			}
			set
			{
				_称号追加HP = value;
			}
		}

		public int 称号追加防御
		{
			get
			{
				return _称号追加防御;
			}
			set
			{
				_称号追加防御 = value;
			}
		}

		public int 称号追加攻击
		{
			get
			{
				return _称号追加攻击;
			}
			set
			{
				_称号追加攻击 = value;
			}
		}

		public int 人物追加战力
		{
			get
			{
				return _人物追加战力;
			}
			set
			{
				_人物追加战力 = value;
			}
		}

		public int 人物追加武勋战力
		{
			get
			{
				return _人物追加武勋战力;
			}
			set
			{
				_人物追加武勋战力 = value;
			}
		}

		public int 人物_追加_PVP战力
		{
			get
			{
				return 人物追加战力 + 人物追加武勋战力;
			}
		}

		public double FLD_追加百分比_攻击
		{
			get
			{
				return double_173;
			}
			set
			{
				double_173 = value;
			}
		}

		public double FLD_追加百分比_防御
		{
			get
			{
				return double_174;
			}
			set
			{
				double_174 = value;
			}
		}

		public double FLD_追加百分比_命中
		{
			get
			{
				return double_175;
			}
			set
			{
				double_175 = value;
			}
		}

		public double FLD_人物_追加百分比_回避
		{
			get
			{
				return double_176;
			}
			set
			{
				double_176 = value;
			}
		}

		public double FLD_追加哀鸿片野_HP上限
		{
			get
			{
				return _FLD_追加哀鸿片野_HP上限;
			}
			set
			{
				_FLD_追加哀鸿片野_HP上限 = value;
			}
		}

		public double FLD_追加百分比_HP上限
		{
			get
			{
				return double_177;
			}
			set
			{
				double_177 = value;
			}
		}

		public double FLD_追加百分比_MP上限
		{
			get
			{
				return double_178;
			}
			set
			{
				double_178 = value;
			}
		}

		public int FLD_心
		{
			get
			{
				return int_65;
			}
			set
			{
				int_65 = value;
			}
		}

		public int FLD_体
		{
			get
			{
				return int_66;
			}
			set
			{
				int_66 = value;
			}
		}

		public int FLD_力
		{
			get
			{
				return int_67;
			}
			set
			{
				int_67 = value;
			}
		}

		public int FLD_身
		{
			get
			{
				return int_68;
			}
			set
			{
				int_68 = value;
			}
		}

		public int FLD_攻击
		{
			get
			{
				return int_69;
			}
			set
			{
				int_69 = value;
			}
		}

		public double 最小攻击
		{
			get
			{
				return double_179;
			}
			set
			{
				double_179 = value;
			}
		}

		public int FLD_最小攻击
		{
			get
			{
				return _FLD_最小攻击;
			}
			set
			{
				_FLD_最小攻击 = value;
			}
		}

		public int FLD_最大攻击
		{
			get
			{
				return int_70;
			}
			set
			{
				int_70 = value;
			}
		}

		public int FLD_命中
		{
			get
			{
				return int_71;
			}
			set
			{
				int_71 = value;
			}
		}

		public int FLD_防御
		{
			get
			{
				return int_72;
			}
			set
			{
				int_72 = value;
			}
		}

		public int FLD_回避
		{
			get
			{
				return int_73;
			}
			set
			{
				int_73 = value;
			}
		}

		public DateTime FLD_结婚纪念日
		{
			get
			{
				return dateTime_2;
			}
			set
			{
				dateTime_2 = value;
			}
		}

		public double FLD_人物_气功_攻击
		{
			get
			{
				return double_180;
			}
			set
			{
				double_180 = value;
			}
		}

		public int FLD_人物_气功_命中
		{
			get
			{
				return int_74;
			}
			set
			{
				int_74 = value;
			}
		}

		public int FLD_人物_气功_防御
		{
			get
			{
				return int_75;
			}
			set
			{
				int_75 = value;
			}
		}

		public int FLD_人物_气功_负重
		{
			get
			{
				return int_76;
			}
			set
			{
				int_76 = value;
			}
		}

		public int FLD_人物_气功_回避
		{
			get
			{
				return int_77;
			}
			set
			{
				int_77 = value;
			}
		}

		public double FLD_人物_武功攻击力增加百分比
		{
			get
			{
				return double_181;
			}
			set
			{
				double_181 = value;
			}
		}

		public double FLD_人物_武功防御力增加百分比
		{
			get
			{
				return double_182;
			}
			set
			{
				double_182 = value;
			}
		}

		public double FLD_人物_气功_武功攻击力增加百分比
		{
			get
			{
				return double_183;
			}
			set
			{
				double_183 = value;
			}
		}

		public double FLD_人物_气功_武功防御力增加百分比
		{
			get
			{
				return double_184;
			}
			set
			{
				double_184 = value;
			}
		}

		public double FLD_人物_追加_武功防御力
		{
			get
			{
				return _FLD_人物_追加_武功防御力;
			}
			set
			{
				_FLD_人物_追加_武功防御力 = value;
			}
		}

		public int FLD_人物_追加_攻击
		{
			get
			{
				return int_78;
			}
			set
			{
				int_78 = value;
			}
		}

		public int FLD_神女_追加_攻击
		{
			get
			{
				return _FLD_神女_追加_攻击;
			}
			set
			{
				_FLD_神女_追加_攻击 = value;
			}
		}

		public int FLD_人物_追加_防御
		{
			get
			{
				return int_79;
			}
			set
			{
				int_79 = value;
			}
		}

		public int FLD_神女_追加_防御
		{
			get
			{
				return _FLD_神女_追加_防御;
			}
			set
			{
				_FLD_神女_追加_防御 = value;
			}
		}

		public int FLD_人物_追加_命中
		{
			get
			{
				return int_80;
			}
			set
			{
				int_80 = value;
			}
		}

		public int FLD_人物_追加_回避
		{
			get
			{
				return int_81;
			}
			set
			{
				int_81 = value;
			}
		}

		public int FLD_人物_追加_气功
		{
			get
			{
				return int_82;
			}
			set
			{
				int_82 = value;
			}
		}

		public double FLD_人物_追加_经验百分比
		{
			get
			{
				return double_185;
			}
			set
			{
				double_185 = value;
			}
		}

		public double FLD_宠物_追加_经验百分比
		{
			get
			{
				return double_186;
			}
			set
			{
				double_186 = value;
			}
		}

		public double FLD_灵宠_追加_经验百分比
		{
			get
			{
				return _FLD_灵宠_追加_经验百分比;
			}
			set
			{
				_FLD_灵宠_追加_经验百分比 = value;
			}
		}

		public double FLD_灵宠_追加_历练百分比
		{
			get
			{
				return _FLD_灵宠_追加_历练百分比;
			}
			set
			{
				_FLD_灵宠_追加_历练百分比 = value;
			}
		}

		public double FLD_人物_追加_历练百分比
		{
			get
			{
				return double_187;
			}
			set
			{
				double_187 = value;
			}
		}

		public double FLD_人物_追加_合成成功率百分比
		{
			get
			{
				return double_188;
			}
			set
			{
				double_188 = value;
			}
		}

		public int FLD_夫妻辅助_追加_防具_属性
		{
			get
			{
				return int_83;
			}
			set
			{
				int_83 = value;
			}
		}

		public int FLD_夫妻辅助_追加_武器_属性
		{
			get
			{
				return int_84;
			}
			set
			{
				int_84 = value;
			}
		}

		public int FLD_结婚礼物_追加_属性石
		{
			get
			{
				return int_85;
			}
			set
			{
				int_85 = value;
			}
		}

		public int FLD_宠物_追加_最大HP
		{
			get
			{
				return int_86;
			}
			set
			{
				int_86 = value;
			}
		}

		public int FLD_宠物_追加_攻击
		{
			get
			{
				return int_87;
			}
			set
			{
				int_87 = value;
			}
		}

		public int FLD_宠物_追加_防御
		{
			get
			{
				return int_88;
			}
			set
			{
				int_88 = value;
			}
		}

		public double FLD_人物_追加_贩卖价格百分比
		{
			get
			{
				return double_189;
			}
			set
			{
				double_189 = value;
			}
		}

		public double FLD_人物_追加_武勋获得量百分比
		{
			get
			{
				return double_190;
			}
			set
			{
				double_190 = value;
			}
		}

		public double FLD_人物_追加_吸魂几率百分比
		{
			get
			{
				return double_191;
			}
			set
			{
				double_191 = value;
			}
		}

		public double FLD_人物_追加_获得游戏币百分比
		{
			get
			{
				return double_192;
			}
			set
			{
				double_192 = value;
			}
		}

		public double FLD_人物_追加_物品掉落概率百分比
		{
			get
			{
				return double_193;
			}
			set
			{
				double_193 = value;
			}
		}

		public double FLD_装备_追加_合成成功率百分比
		{
			get
			{
				return double_194;
			}
			set
			{
				double_194 = value;
			}
		}

		public double FLD_装备_追加_获得游戏币百分比
		{
			get
			{
				return double_195;
			}
			set
			{
				double_195 = value;
			}
		}

		public double FLD_装备_武功攻击力增加百分比
		{
			get
			{
				return double_196;
			}
			set
			{
				double_196 = value;
			}
		}

		public int FLD_装备_追加_武功命中
		{
			get
			{
				return _FLD_装备_追加_武功命中;
			}
			set
			{
				_FLD_装备_追加_武功命中 = value;
			}
		}

		public int FLD_装备_追加_武功回避
		{
			get
			{
				return _FLD_装备_追加_武功回避;
			}
			set
			{
				_FLD_装备_追加_武功回避 = value;
			}
		}

		public int 减免对方伤害
		{
			get
			{
				return _减免对方伤害;
			}
			set
			{
				_减免对方伤害 = value;
			}
		}

		public int FLD_装备_增加异常
		{
			get
			{
				return _FLD_装备_增加异常;
			}
			set
			{
				_FLD_装备_增加异常 = value;
			}
		}

		public int FLD_装备_增加对方异常
		{
			get
			{
				return _FLD_装备_增加对方异常;
			}
			set
			{
				_FLD_装备_增加对方异常 = value;
			}
		}

		public double FLD_装备_武功防御力
		{
			get
			{
				return double_197;
			}
			set
			{
				double_197 = value;
			}
		}

		public double FLD_装备_武功防御力增加百分比
		{
			get
			{
				return double_198;
			}
			set
			{
				double_198 = value;
			}
		}

		public int FLD_装备_追加_攻击
		{
			get
			{
				return int_89;
			}
			set
			{
				int_89 = value;
			}
		}

		public int FLD_装备_追加_防御
		{
			get
			{
				return int_90;
			}
			set
			{
				int_90 = value;
			}
		}

		public int FLD_装备_追加_防御New
		{
			get
			{
				return int_91;
			}
			set
			{
				int_91 = value;
			}
		}

		public int FLD_装备_追加_武器_强化
		{
			get
			{
				return int_92;
			}
			set
			{
				int_92 = value;
			}
		}

		public int FLD_装备_追加_防具_强化
		{
			get
			{
				return int_93;
			}
			set
			{
				int_93 = value;
			}
		}

		public int FLD_装备_追加_命中
		{
			get
			{
				return int_94;
			}
			set
			{
				int_94 = value;
			}
		}

		public double FLD_装备_追加_降低百分比攻击
		{
			get
			{
				return double_199;
			}
			set
			{
				double_199 = value;
			}
		}

		public double FLD_装备_追加_降低百分比防御
		{
			get
			{
				return double_200;
			}
			set
			{
				double_200 = value;
			}
		}

		public double FLD_装备_追加_命中百分比
		{
			get
			{
				return double_201;
			}
			set
			{
				double_201 = value;
			}
		}

		public int FLD_装备_追加_愤怒
		{
			get
			{
				return int_95;
			}
			set
			{
				int_95 = value;
			}
		}

		public double FLD_装备_追加_回避百分比
		{
			get
			{
				return double_202;
			}
			set
			{
				double_202 = value;
			}
		}

		public double FLD_装备_降低_伤害值
		{
			get
			{
				return double_203;
			}
			set
			{
				double_203 = value;
			}
		}

		public int FLD_装备_追加_伤害值
		{
			get
			{
				return int_96;
			}
			set
			{
				int_96 = value;
			}
		}

		public double FLD_装备_追加_初始化愤怒概率百分比
		{
			get
			{
				return double_204;
			}
			set
			{
				double_204 = value;
			}
		}

		public double FLD_装备_追加_中毒概率百分比
		{
			get
			{
				return double_205;
			}
			set
			{
				double_205 = value;
			}
		}

		public int FLD_装备_追加_回避
		{
			get
			{
				return int_97;
			}
			set
			{
				int_97 = value;
			}
		}

		public int FLD_装备_追加_气功
		{
			get
			{
				return int_98;
			}
			set
			{
				int_98 = value;
			}
		}

		public double FLD_装备_追加_经验百分比
		{
			get
			{
				return double_206;
			}
			set
			{
				double_206 = value;
			}
		}

		public double FLD_装备_追加_死亡损失经验减少
		{
			get
			{
				return double_207;
			}
			set
			{
				double_207 = value;
			}
		}

		public double FLD_装备_追加_气功_0
		{
			get
			{
				return double_208;
			}
			set
			{
				double_208 = value;
			}
		}

		public double FLD_装备_追加_气功_1
		{
			get
			{
				return double_209;
			}
			set
			{
				double_209 = value;
			}
		}

		public double FLD_装备_追加_气功_2
		{
			get
			{
				return double_210;
			}
			set
			{
				double_210 = value;
			}
		}

		public double FLD_装备_追加_气功_3
		{
			get
			{
				return double_211;
			}
			set
			{
				double_211 = value;
			}
		}

		public double FLD_装备_追加_气功_4
		{
			get
			{
				return double_212;
			}
			set
			{
				double_212 = value;
			}
		}

		public double FLD_装备_追加_气功_5
		{
			get
			{
				return double_213;
			}
			set
			{
				double_213 = value;
			}
		}

		public double FLD_装备_追加_气功_6
		{
			get
			{
				return double_214;
			}
			set
			{
				double_214 = value;
			}
		}

		public double FLD_装备_追加_气功_7
		{
			get
			{
				return double_215;
			}
			set
			{
				double_215 = value;
			}
		}

		public double FLD_装备_追加_气功_8
		{
			get
			{
				return double_216;
			}
			set
			{
				double_216 = value;
			}
		}

		public double FLD_装备_追加_气功_9
		{
			get
			{
				return double_217;
			}
			set
			{
				double_217 = value;
			}
		}

		public double FLD_装备_追加_气功_11
		{
			get
			{
				return double_219;
			}
			set
			{
				double_219 = value;
			}
		}

		public double FLD_装备_追加_气功_10
		{
			get
			{
				return double_218;
			}
			set
			{
				double_218 = value;
			}
		}

		public int FLD_装备_追加_HP
		{
			get
			{
				return int_99;
			}
			set
			{
				int_99 = value;
			}
		}

		public int FLD_装备_追加_障力恢复量
		{
			get
			{
				return int_100;
			}
			set
			{
				int_100 = value;
			}
		}

		public int FLD_装备_追加_MP
		{
			get
			{
				return int_101;
			}
			set
			{
				int_101 = value;
			}
		}

		public int FLD_装备_追加_障力
		{
			get
			{
				return int_102;
			}
			set
			{
				int_102 = value;
			}
		}

		public double FLD_装备_追加_升天一遁出逆境
		{
			get
			{
				return double_220;
			}
			set
			{
				double_220 = value;
			}
		}

		public double FLD_装备_追加_升天一破甲刺魂
		{
			get
			{
				return double_221;
			}
			set
			{
				double_221 = value;
			}
		}

		public double FLD_装备_追加_升天一绝影射魂
		{
			get
			{
				return double_222;
			}
			set
			{
				double_222 = value;
			}
		}

		public double FLD_装备_追加_升天三怒意之火
		{
			get
			{
				return double_223;
			}
			set
			{
				double_223 = value;
			}
		}

		public double FLD_装备_追加_升天一夜魔缠身
		{
			get
			{
				return double_224;
			}
			set
			{
				double_224 = value;
			}
		}

		public double FLD_装备_追加_升天一力劈华山
		{
			get
			{
				return double_225;
			}
			set
			{
				double_225 = value;
			}
		}

		public double FLD_装备_追加_升天一长虹贯日
		{
			get
			{
				return double_226;
			}
			set
			{
				double_226 = value;
			}
		}

		public double FLD_装备_追加_升天一金钟罡气
		{
			get
			{
				return double_227;
			}
			set
			{
				double_227 = value;
			}
		}

		public double FLD_装备_追加_升天一运气行心
		{
			get
			{
				return double_228;
			}
			set
			{
				double_228 = value;
			}
		}

		public double FLD_装备_追加_升天一正本培源
		{
			get
			{
				return double_229;
			}
			set
			{
				double_229 = value;
			}
		}

		public double FLD_装备_追加_升天一运气疗伤
		{
			get
			{
				return double_230;
			}
			set
			{
				double_230 = value;
			}
		}

		public double FLD_装备_追加_升天一百变神行
		{
			get
			{
				return double_231;
			}
			set
			{
				double_231 = value;
			}
		}

		public double FLD_装备_追加_升天一狂风天意
		{
			get
			{
				return double_232;
			}
			set
			{
				double_232 = value;
			}
		}

		public double FLD_装备_追加_升天一飞花点翠
		{
			get
			{
				return double_233;
			}
			set
			{
				double_233 = value;
			}
		}

		public double FLD_装备_追加_升天一行风弄舞
		{
			get
			{
				return double_234;
			}
			set
			{
				double_234 = value;
			}
		}

		public double FLD_装备_追加_升天二穷途末路
		{
			get
			{
				return double_235;
			}
			set
			{
				double_235 = value;
			}
		}

		public double FLD_装备_追加_升天三火龙之火
		{
			get
			{
				return double_236;
			}
			set
			{
				double_236 = value;
			}
		}

		public double FLD_装备_追加_升天二天地同寿
		{
			get
			{
				return double_237;
			}
			set
			{
				double_237 = value;
			}
		}

		public double FLD_装备_追加_升天一护身罡气
		{
			get
			{
				return double_238;
			}
			set
			{
				double_238 = value;
			}
		}

		public double FLD_装备_追加_升天二以退为进
		{
			get
			{
				return double_239;
			}
			set
			{
				double_239 = value;
			}
		}

		public double FLD_装备_追加_升天二千钧压驼
		{
			get
			{
				return double_240;
			}
			set
			{
				double_240 = value;
			}
		}

		public double FLD_装备_追加_升天二顺水推舟
		{
			get
			{
				return double_241;
			}
			set
			{
				double_241 = value;
			}
		}

		public double FLD_装备_追加_升天二三潭映月
		{
			get
			{
				return double_242;
			}
			set
			{
				double_242 = value;
			}
		}

		public double FLD_装备_追加_升天二天魔护体
		{
			get
			{
				return double_243;
			}
			set
			{
				double_243 = value;
			}
		}

		public double FLD_装备_追加_升天二万物回春
		{
			get
			{
				return double_244;
			}
			set
			{
				double_244 = value;
			}
		}

		public double FLD_装备_追加_升天一护身气甲
		{
			get
			{
				return double_245;
			}
			set
			{
				double_245 = value;
			}
		}

		public double FLD_装备_追加_升天三火凤临朝
		{
			get
			{
				return double_246;
			}
			set
			{
				double_246 = value;
			}
		}

		public double FLD_装备_追加_升天三天外三矢
		{
			get
			{
				return double_247;
			}
			set
			{
				double_247 = value;
			}
		}

		public double FLD_装备_追加_升天三无情打击
		{
			get
			{
				return double_248;
			}
			set
			{
				double_248 = value;
			}
		}

		public double FLD_装备_追加_升天三明镜止水
		{
			get
			{
				return double_249;
			}
			set
			{
				double_249 = value;
			}
		}

		public double FLD_装备_追加_升天三子夜秋歌
		{
			get
			{
				return double_250;
			}
			set
			{
				double_250 = value;
			}
		}

		public double FLD_装备_追加_升天三内息行心
		{
			get
			{
				return double_251;
			}
			set
			{
				double_251 = value;
			}
		}

		public double FLD_装备_追加_升天三以柔克刚
		{
			get
			{
				return double_252;
			}
			set
			{
				double_252 = value;
			}
		}

		public double FLD_装备_追加_升天四红月狂风
		{
			get
			{
				return double_253;
			}
			set
			{
				double_253 = value;
			}
		}

		public double FLD_装备_追加_升天四毒蛇出洞
		{
			get
			{
				return double_254;
			}
			set
			{
				double_254 = value;
			}
		}

		public double FLD_装备_追加_升天四满月狂风
		{
			get
			{
				return double_255;
			}
			set
			{
				double_255 = value;
			}
		}

		public double FLD_装备_追加_升天四烈日炎炎
		{
			get
			{
				return double_256;
			}
			set
			{
				double_256 = value;
			}
		}

		public double FLD_装备_追加_升天四长虹贯天
		{
			get
			{
				return double_257;
			}
			set
			{
				double_257 = value;
			}
		}

		public double FLD_装备_追加_升天四哀鸿遍野
		{
			get
			{
				return double_258;
			}
			set
			{
				double_258 = value;
			}
		}

		public double FLD_装备_追加_升天一夺命连环
		{
			get
			{
				return double_259;
			}
			set
			{
				double_259 = value;
			}
		}

		public double FLD_装备_追加_升天一电光石火
		{
			get
			{
				return double_260;
			}
			set
			{
				double_260 = value;
			}
		}

		public double FLD_装备_追加_升天一精益求精
		{
			get
			{
				return double_261;
			}
			set
			{
				double_261 = value;
			}
		}

		public double FLD_装备_追加_升天四望梅添花
		{
			get
			{
				return double_262;
			}
			set
			{
				double_262 = value;
			}
		}

		public double FLD_装备_追加_升天四悬丝诊脉
		{
			get
			{
				return double_263;
			}
			set
			{
				double_263 = value;
			}
		}

		public int FLD_装备_追加_心
		{
			get
			{
				return int_103;
			}
			set
			{
				int_103 = value;
			}
		}

		public int FLD_装备_追加_体
		{
			get
			{
				return int_104;
			}
			set
			{
				int_104 = value;
			}
		}

		public int FLD_装备_追加_力
		{
			get
			{
				return int_105;
			}
			set
			{
				int_105 = value;
			}
		}

		public int FLD_装备_追加_身
		{
			get
			{
				return int_106;
			}
			set
			{
				int_106 = value;
			}
		}

		public int FLD_装备_追加_觉醒
		{
			get
			{
				return int_107;
			}
			set
			{
				int_107 = value;
			}
		}

        public int get_荣誉ID(string string_11, int int_109)
        {
            try
            {
                switch (int_109)
                {
                    case 1:
                        for (int index = 0; index < World.势力战排行数据.Count; ++index)
                        {
                            if (World.势力战排行数据[index].人物名 == string_11)
                            {
                                switch (index + 1)
                                {
                                    case 1:
                                        return 1008001300;
                                    case 2:
                                        return 1008001301;
                                    case 3:
                                        return 1008001302;
                                    case 4:
                                        return 1008001303;
                                    case 5:
                                        return 1008001304;
                                    case 6:
                                        return 1008001305;
                                    case 7:
                                        return 1008001306;
                                    case 8:
                                        return 1008001307;
                                    case 9:
                                        return 1008001308;
                                    case 10:
                                        return 1008001309;
                                    case 11:
                                        return 1008001240;
                                    case 12:
                                        return 1008001241;
                                    case 13:
                                        return 1008001242;
                                    case 14:
                                        return 1008001243;
                                    case 15:
                                        return 1008001244;
                                    case 16:
                                        return 1008001245;
                                    case 17:
                                        return 1008001246;
                                    case 18:
                                        return 1008001247;
                                    case 19:
                                        return 1008001248;
                                    case 20:
                                        return 1008001249;
                                    case 21:
                                        return 1008001230;
                                    case 22:
                                        return 1008001231;
                                    case 23:
                                        return 1008001232;
                                    case 24:
                                        return 1008001233;
                                    case 25:
                                        return 1008001234;
                                    case 26:
                                        return 1008001235;
                                    case 27:
                                        return 1008001236;
                                    case 28:
                                        return 1008001237;
                                    case 29:
                                        return 1008001238;
                                    case 30:
                                        return 1008001239;
                                    case 31:
                                        return 1008001220;
                                    case 32:
                                        return 1008001221;
                                    case 33:
                                        return 1008001222;
                                    case 34:
                                        return 1008001223;
                                    case 35:
                                        return 1008001224;
                                    case 36:
                                        return 1008001225;
                                    case 37:
                                        return 1008001226;
                                    case 38:
                                        return 1008001227;
                                    case 39:
                                        return 1008001228;
                                    case 40:
                                        return 1008001229;
                                    case 41:
                                        return 1008001210;
                                    case 42:
                                        return 1008001211;
                                    case 43:
                                        return 1008001212;
                                    case 44:
                                        return 1008001213;
                                    case 45:
                                        return 1008001214;
                                    case 46:
                                        return 1008001215;
                                    case 47:
                                        return 1008001216;
                                    case 48:
                                        return 1008001217;
                                    case 49:
                                        return 1008001218;
                                    case 50:
                                        return 1008001219;
                                    case 51:
                                        return 1008001200;
                                    case 52:
                                        return 1008001201;
                                    case 53:
                                        return 1008001202;
                                    case 54:
                                        return 1008001203;
                                    case 55:
                                        return 1008001204;
                                    case 56:
                                        return 1008001205;
                                    case 57:
                                        return 1008001206;
                                    case 58:
                                        return 1008001207;
                                    case 59:
                                        return 1008001208;
                                    case 60:
                                        return 1008001209;
                                    default:
                                        return 0;
                                }
                            }
                        }
                        break;
                    case 2:
                        for (int index = 0; index < World.武林血战排行数据.Count; ++index)
                        {
                            if (World.武林血战排行数据[index].人物名 == string_11)
                            {
                                switch (index + 1)
                                {
                                    case 1:
                                        return 1008001310;
                                    case 2:
                                        return 1008001311;
                                    case 3:
                                        return 1008001312;
                                    case 4:
                                        return 1008001313;
                                    case 5:
                                        return 1008001314;
                                    case 6:
                                        return 1008001315;
                                    case 7:
                                        return 1008001316;
                                    case 8:
                                        return 1008001317;
                                    case 9:
                                        return 1008001318;
                                    case 10:
                                        return 1008001319;
                                    case 11:
                                        return 1008001290;
                                    case 12:
                                        return 1008001291;
                                    case 13:
                                        return 1008001292;
                                    case 14:
                                        return 1008001293;
                                    case 15:
                                        return 1008001294;
                                    case 16:
                                        return 1008001295;
                                    case 17:
                                        return 1008001296;
                                    case 18:
                                        return 1008001297;
                                    case 19:
                                        return 1008001298;
                                    case 20:
                                        return 1008001299;
                                    case 21:
                                        return 1008001280;
                                    case 22:
                                        return 1008001281;
                                    case 23:
                                        return 1008001282;
                                    case 24:
                                        return 1008001283;
                                    case 25:
                                        return 1008001284;
                                    case 26:
                                        return 1008001285;
                                    case 27:
                                        return 1008001286;
                                    case 28:
                                        return 1008001287;
                                    case 29:
                                        return 1008001288;
                                    case 30:
                                        return 1008001289;
                                    case 31:
                                        return 1008001270;
                                    case 32:
                                        return 1008001271;
                                    case 33:
                                        return 1008001272;
                                    case 34:
                                        return 1008001273;
                                    case 35:
                                        return 1008001274;
                                    case 36:
                                        return 1008001275;
                                    case 37:
                                        return 1008001276;
                                    case 38:
                                        return 1008001277;
                                    case 39:
                                        return 1008001278;
                                    case 40:
                                        return 1008001279;
                                    case 41:
                                        return 1008001260;
                                    case 42:
                                        return 1008001261;
                                    case 43:
                                        return 1008001262;
                                    case 44:
                                        return 1008001263;
                                    case 45:
                                        return 1008001264;
                                    case 46:
                                        return 1008001265;
                                    case 47:
                                        return 1008001266;
                                    case 48:
                                        return 1008001267;
                                    case 49:
                                        return 1008001268;
                                    case 50:
                                        return 1008001269;
                                    case 51:
                                        return 1008001250;
                                    case 52:
                                        return 1008001251;
                                    case 53:
                                        return 1008001252;
                                    case 54:
                                        return 1008001253;
                                    case 55:
                                        return 1008001254;
                                    case 56:
                                        return 1008001255;
                                    case 57:
                                        return 1008001256;
                                    case 58:
                                        return 1008001257;
                                    case 59:
                                        return 1008001258;
                                    case 60:
                                        return 1008001259;
                                    default:
                                        return 0;
                                }
                            }
                        }
                        break;
                    case 3:
                        for (int index = 0; index < World.帮派排行数据.Count; ++index)
                        {
                            if (World.帮派排行数据[index].人物名 == string_11)
                            {
                                switch (index + 1)
                                {
                                    case 1:
                                        return 1008001310;
                                    case 2:
                                        return 1008001311;
                                    case 3:
                                        return 1008001312;
                                    case 4:
                                        return 1008001313;
                                    case 5:
                                        return 1008001314;
                                    case 6:
                                        return 1008001315;
                                    case 7:
                                        return 1008001316;
                                    case 8:
                                        return 1008001317;
                                    case 9:
                                        return 1008001318;
                                    case 10:
                                        return 1008001319;
                                    case 11:
                                        return 1008001290;
                                    case 12:
                                        return 1008001291;
                                    case 13:
                                        return 1008001292;
                                    case 14:
                                        return 1008001293;
                                    case 15:
                                        return 1008001294;
                                    case 16:
                                        return 1008001295;
                                    case 17:
                                        return 1008001296;
                                    case 18:
                                        return 1008001297;
                                    case 19:
                                        return 1008001298;
                                    case 20:
                                        return 1008001299;
                                    case 21:
                                        return 1008001280;
                                    case 22:
                                        return 1008001281;
                                    case 23:
                                        return 1008001282;
                                    case 24:
                                        return 1008001283;
                                    case 25:
                                        return 1008001284;
                                    case 26:
                                        return 1008001285;
                                    case 27:
                                        return 1008001286;
                                    case 28:
                                        return 1008001287;
                                    case 29:
                                        return 1008001288;
                                    case 30:
                                        return 1008001289;
                                    case 31:
                                        return 1008001270;
                                    case 32:
                                        return 1008001271;
                                    case 33:
                                        return 1008001272;
                                    case 34:
                                        return 1008001273;
                                    case 35:
                                        return 1008001274;
                                    case 36:
                                        return 1008001275;
                                    case 37:
                                        return 1008001276;
                                    case 38:
                                        return 1008001277;
                                    case 39:
                                        return 1008001278;
                                    case 40:
                                        return 1008001279;
                                    case 41:
                                        return 1008001260;
                                    case 42:
                                        return 1008001261;
                                    case 43:
                                        return 1008001262;
                                    case 44:
                                        return 1008001263;
                                    case 45:
                                        return 1008001264;
                                    case 46:
                                        return 1008001265;
                                    case 47:
                                        return 1008001266;
                                    case 48:
                                        return 1008001267;
                                    case 49:
                                        return 1008001268;
                                    case 50:
                                        return 1008001269;
                                    case 51:
                                        return 1008001250;
                                    case 52:
                                        return 1008001251;
                                    case 53:
                                        return 1008001252;
                                    case 54:
                                        return 1008001253;
                                    case 55:
                                        return 1008001254;
                                    case 56:
                                        return 1008001255;
                                    case 57:
                                        return 1008001256;
                                    case 58:
                                        return 1008001257;
                                    case 59:
                                        return 1008001258;
                                    case 60:
                                        return 1008001259;
                                    default:
                                        return 0;
                                }
                            }
                        }
                        break;
                }
                return 0;
            }
            catch
            {
                return 0;
            }
        }
        public void Clear()
		{
			触发属性提升 = 0;
			触发鸾凤和鸣 = false;
			Player无敌 = false;
			PK死亡 = false;
			跑走 = false;
			是否更新配置 = false;
			上线 = false;
			触发地图移动事件 = false;
			装备追加对怪防御 = 0;
			装备追加对怪攻击 = 0;
			药品追加对怪防御 = 0;
			药品追加对怪攻击 = 0;
			FLD_药品_追加_气功 = 0;
			武器攻击力 = 0;
			武器武功攻击力百分比 = 0.0;
			衣服防御力 = 0;
			衣服武功防御力百分比 = 0.0;
			交易人物ID = 0;
			交易操作ID = 0;
			Temp游戏安全码 = string.Empty;
			商店名 = string.Empty;
			安全码操作ID = -1;
			安全码是否通过验证 = false;
			是否已婚 = 0;
			证婚人提问答案 = 2;
			解除关系倒计时 = 0;
			婚戒刻字 = string.Empty;
			荣誉ID_ = 0;
			是否携带披风行囊 = false;
			怒 = false;
			中毒 = false;
			新武功连击 = new List<武功类>();
			SerList = new Dictionary<int, ServerList>(10);
			时间药品 = new Dictionary<int, 时间药品类>();
			刺客发起技能加成 = false;
			刺客物理攻击加成 = 0.0;
			刺客魔法攻击加成 = 0.0;
			升天气功武功等级 = 0.0;
			每日获得武勋 = 0;
			丢失武勋 = 0;
			PVP分数 = 0;
			PVP逃跑次数 = 0;
			lastX = 0f;
			lastY = 0f;
			lastMAP = 101;
			AttackX = 0f;
			AttackY = 0f;
			攻击次数 = 0;
			心跳次数阀值 = 3;
			修炼地图剩余时间 = 0;
			活动地图剩余时间 = 0;
			FBtime = DateTime.Now;
			PKhmtime = DateTime.Now;
			XThmtime = DateTime.Now;
			TMJCtime = DateTime.Now;
			CWhmtime = DateTime.Now;
			SThmtime = DateTime.Now;
			凝神宝珠位置 = -1;
			FLD_宠物_追加_攻击 = 0;
			FLD_宠物_追加_防御 = 0;
			FLD_宠物_追加_最大HP = 0;
			弓群攻触发心神 = false;
			韩飞官_天魔狂血攻击力 = 0.0;
			韩飞官_天魔狂血叠加次数 = 0;
			FLD_爱情度等级 = 0;
			FLD_是否可以送花 = true;
			当前操作类型 = 0;
			人物锁定 = false;
			锁定人物几率 = 0;
			FLD_夫妻辅助_追加_防具_属性 = 0;
			FLD_夫妻辅助_追加_武器_属性 = 0;
			FLD_结婚礼物_追加_属性石 = 0;
			拳师连击控制 = 0;
			拳师会心一击威力 = 0.3;
			解除师徒关系时间 = DateTime.Parse("2012/12/12      12:12:12");
			丢失武勋 = 0;
			武皇通币 = 0;
			当前操作NPC = 0;
			天地同寿回避次数 = 0;
			天地同寿回避累积攻击力 = 0;
			FLD_荣誉ID = 0;
			势力战杀人数 = 0;
			势力战死亡数 = 0;
			琴师状态 = 0;
			元宝账户状态 = false;
			FLD_PVP_Piont = 0;
			当前激活技能ID = 0;
			玉连环 = new List<int>();
			装备数据版本 = 1;
			综合仓库装备数据版本 = 1;
			退出中 = false;
			存档时间 = false;
			妖花青草 = false;
			武功新 = new 武功类[4, 32];
			夫妻武功攻击力 = 0;
			夫妻武功攻击力MP = 0;
			追加状态列表 = new ThreadSafeDictionary<int, 追加状态类>();
			追加状态New列表 = new ThreadSafeDictionary<int, 追加状态New类>();
			公有药品 = new Dictionary<int, 公有药品类>();
			称号药品 = new Dictionary<int, 称号药品类>();
			任务 = new Dictionary<int, 任务类>();
			已完成任务 = new Dictionary<int, int>();
			客户端设置 = string.Empty;
			师傅数据 = new 师徒类();
			徒弟数据 = new 师徒类[3];
			武功新 = new 武功类[4, 32];
			异常状态 = new ThreadSafeDictionary<int, 异常状态类>();
			异常防御状态 = new ThreadSafeDictionary<int, 异常状态防御类>();
			异常攻击状态 = new ThreadSafeDictionary<int, 异常状态攻击类>();
			异常掉血状态 = new ThreadSafeDictionary<int, 异常掉血状态类>();
			异常掉蓝状态 = new ThreadSafeDictionary<int, 异常掉蓝状态类>();
			神女异常状态 = new ThreadSafeDictionary<int, 神女异常状态类>();
			装备栏包裹 = new 物品类[66];
			披风行囊 = new 物品类[66];
			装备栏已穿装备 = new 物品类[16];
			辅助装备栏装备 = new 物品类[15];
			气功 = new 气功类[15];
			个人仓库 = new 物品类[60];
			公共仓库 = new 物品类[60];
			任务物品 = new 任务物品类[36];
			升天气功 = new SortedDictionary<int, 升天气功类>();
			FLD_追加哀鸿片野_HP上限 = 0.0;
			人物追加最大_HP = 0;
			人物追加最大_MP = 0;
			人物_气功_追加_武功防御力 = 0;
			人物基本最大_HP = 0;
			FLD_装备_追加_HP = 0;
			FLD_装备_追加_障力恢复量 = 0;
			人物_气功_追加_HP = 0;
			人物基本最大_MP = 0;
			人物基本最大_障力 = 0;
			FLD_装备_追加_MP = 0;
			人物_气功_追加_MP = 0;
			人物_AP = 0;
			帮派门徽 = null;
			追加状态物品New = null;
			帮派人物等级 = 0;
			帮派名字 = string.Empty;
			帮派Id = 0;
			帮派等级 = 0;
			FLD_追加百分比_攻击 = 0.0;
			FLD_追加百分比_防御 = 0.0;
			FLD_追加百分比_命中 = 0.0;
			FLD_人物_追加百分比_回避 = 0.0;
			FLD_追加百分比_HP上限 = 0.0;
			FLD_追加百分比_MP上限 = 0.0;
			FLD_人物_武功攻击力增加百分比 = 0.0;
			FLD_人物_武功防御力增加百分比 = 0.0;
			最小攻击 = 0.0;
			FLD_药品_减少攻击 = 0.0;
			FLD_药品_减少防御 = 0.0;
			人物追加战力 = 0;
			人物追加武勋战力 = 0;
			称号追加HP = 0;
			称号追加攻击 = 0;
			称号追加防御 = 0;
			门派称号追加HP = 0;
			门派称号追加攻击 = 0;
			门派称号追加防御 = 0;
			玫瑰称号追加HP = 0;
			玫瑰称号追加攻击 = 0;
			玫瑰称号追加防御 = 0;
			FLD_人物_追加_攻击 = 0;
			FLD_人物_追加_防御 = 0;
			FLD_神女_追加_防御 = 0;
			FLD_神女_追加_攻击 = 0;
			FLD_人物_追加_命中 = 0;
			FLD_人物_追加_回避 = 0;
			FLD_人物_追加_气功 = 0;
			FLD_人物_追加_贩卖价格百分比 = 0.0;
			FLD_人物_追加_武勋获得量百分比 = 0.0;
			FLD_人物_追加_吸魂几率百分比 = 0.0;
			FLD_人物_追加_合成成功率百分比 = 0.0;
			FLD_人物_追加_获得游戏币百分比 = 0.0;
			FLD_人物_追加_经验百分比 = 0.0;
			FLD_宠物_追加_经验百分比 = 0.0;
			FLD_人物_追加_物品掉落概率百分比 = 0.0;
			FLD_人物_追加_历练百分比 = 0.0;
			FLD_人物_追加_武功防御力 = 0.0;
			FLD_装备_追加_升天二万物回春 = 0.0;
			FLD_装备_追加_升天二千钧压驼 = 0.0;
			FLD_装备_追加_升天二穷途末路 = 0.0;
			FLD_装备_追加_升天三火龙之火 = 0.0;
			FLD_装备_追加_升天一护身罡气 = 0.0;
			FLD_装备_追加_升天一护身气甲 = 0.0;
			FLD_装备_追加_升天三怒意之火 = 0.0;
			FLD_装备_追加_升天二三潭映月 = 0.0;
			FLD_装备_追加_升天二顺水推舟 = 0.0;
			FLD_装备_追加_升天二天地同寿 = 0.0;
			FLD_装备_追加_升天二天魔护体 = 0.0;
			FLD_装备_追加_升天二以退为进 = 0.0;
			FLD_装备_追加_升天三火凤临朝 = 0.0;
			FLD_装备_追加_升天三明镜止水 = 0.0;
			FLD_装备_追加_升天三内息行心 = 0.0;
			FLD_装备_追加_升天三无情打击 = 0.0;
			FLD_装备_追加_升天三天外三矢 = 0.0;
			FLD_装备_追加_升天三以柔克刚 = 0.0;
			FLD_装备_追加_升天三子夜秋歌 = 0.0;
			FLD_装备_追加_升天四哀鸿遍野 = 0.0;
			FLD_装备_追加_升天四毒蛇出洞 = 0.0;
			FLD_装备_追加_升天四红月狂风 = 0.0;
			FLD_装备_追加_升天四烈日炎炎 = 0.0;
			FLD_装备_追加_升天四满月狂风 = 0.0;
			FLD_装备_追加_升天四望梅添花 = 0.0;
			FLD_装备_追加_升天四悬丝诊脉 = 0.0;
			FLD_装备_追加_升天四长虹贯天 = 0.0;
			FLD_装备_追加_升天一百变神行 = 0.0;
			FLD_装备_追加_升天一遁出逆境 = 0.0;
			FLD_装备_追加_升天一飞花点翠 = 0.0;
			FLD_装备_追加_升天一行风弄舞 = 0.0;
			FLD_装备_追加_升天一金钟罡气 = 0.0;
			FLD_装备_追加_升天一绝影射魂 = 0.0;
			FLD_装备_追加_升天一狂风天意 = 0.0;
			FLD_装备_追加_升天一力劈华山 = 0.0;
			FLD_装备_追加_升天一破甲刺魂 = 0.0;
			FLD_装备_追加_升天一夜魔缠身 = 0.0;
			FLD_装备_追加_升天一运气行心 = 0.0;
			FLD_装备_追加_升天一运气疗伤 = 0.0;
			FLD_装备_追加_升天一长虹贯日 = 0.0;
			FLD_装备_追加_升天一正本培源 = 0.0;
			FLD_装备_追加_升天一夺命连环 = 0.0;
			FLD_装备_追加_升天一电光石火 = 0.0;
			FLD_装备_追加_升天一精益求精 = 0.0;
			FLD_装备_追加_合成成功率百分比 = 0.0;
			FLD_装备_追加_获得游戏币百分比 = 0.0;
			FLD_装备_武功攻击力增加百分比 = 0.0;
			FLD_装备_武功防御力 = 0.0;
			FLD_装备_武功防御力增加百分比 = 0.0;
			FLD_装备_追加_降低百分比攻击 = 0.0;
			FLD_装备_追加_降低百分比防御 = 0.0;
			FLD_装备_追加_命中百分比 = 0.0;
			FLD_装备_追加_回避百分比 = 0.0;
			FLD_装备_追加_愤怒 = 0;
			FLD_装备_追加_初始化愤怒概率百分比 = 0.0;
			FLD_装备_追加_中毒概率百分比 = 0.0;
			FLD_装备_降低_伤害值 = 0.0;
			FLD_装备_追加_伤害值 = 0;
			FLD_装备_追加_攻击 = 0;
			FLD_装备_追加_障力 = 0;
			FLD_装备_追加_防御 = 0;
			FLD_装备_追加_防御New = 0;
			FLD_装备_追加_命中 = 0;
			FLD_装备_追加_回避 = 0;
			FLD_装备_追加_气功 = 0;
			FLD_装备_追加_防具_强化 = 0;
			FLD_装备_追加_武器_强化 = 0;
			FLD_装备_追加_经验百分比 = 0.0;
			FLD_装备_追加_死亡损失经验减少 = 0.0;
			FLD_装备_追加_心 = 0;
			FLD_装备_追加_体 = 0;
			FLD_装备_追加_力 = 0;
			FLD_装备_追加_身 = 0;
			FLD_装备_追加_觉醒 = 0;
			FLD_装备_追加_气功_0 = 0.0;
			FLD_装备_追加_气功_1 = 0.0;
			FLD_装备_追加_气功_2 = 0.0;
			FLD_装备_追加_气功_3 = 0.0;
			FLD_装备_追加_气功_4 = 0.0;
			FLD_装备_追加_气功_5 = 0.0;
			FLD_装备_追加_气功_6 = 0.0;
			FLD_装备_追加_气功_7 = 0.0;
			FLD_装备_追加_气功_8 = 0.0;
			FLD_装备_追加_气功_9 = 0.0;
			FLD_装备_追加_气功_10 = 0.0;
			FLD_装备_追加_气功_11 = 0.0;
			FLD_结婚纪念日 = DateTime.Now;
			base.韩_天魔狂血 = 0.0;
			base.韩_追骨吸元 = 0.0;
			base.韩_火龙问鼎 = 0.0;
			base.刀_连环飞舞 = 0.0;
			base.刀_升天三气功_火龙之火 = 0.0;
			base.剑_破天一剑 = 0.0;
			base.枪_升天三气功_怒意之火 = 0.0;
			base.致命一击几率 = 0.0;
			base.谭_招式新法 = 0.0;
			base.怪反伤几率 = 0.0;
			base.人反伤几率 = 0.0;
			base.破甲几率 = 0.0;
			base.气沉丹田 = 0.0;
			base.真武绝击 = 0.0;
			base.暗影绝杀 = 0.0;
			base.流光乱舞 = 0.0;
			base.剑_升天三气功_护身罡气 = 0.0;
			base.剑_移花接木 = 0.0;
			base.剑_回柳身法 = 0.0;
			base.剑_怒海狂澜 = 0.0;
			base.剑_冲冠一怒 = 0.0;
			base.剑_无坚不摧 = 0.0;
			base.枪_运气疗伤 = 0.0;
			base.枪_灵甲护身 = 0.0;
			base.枪_乾坤挪移 = 0.0;
			base.枪_狂神降世 = 0.0;
			base.枪_转攻为守 = 0.0;
			base.卢_转攻为守 = 0.0;
			base.枪_末日狂舞 = 0.0;
			base.弓_锐利之箭 = 0.0;
			base.弓_猎鹰之眼 = 0.0;
			base.弓_无明暗矢 = 0.0;
			base.弓_回流真气 = 0.0;
			base.弓_流星三矢 = 0.0;
			base.弓_致命绝杀 = 0.0;
			base.弓_心神凝聚 = 0.0;
			base.医_运气疗心 = 0.0;
			base.医_长攻击力 = 0.0;
			base.医_太极心法 = 0.0;
			base.医_妙手回春 = 0.0;
			base.医_神农仙术 = 0.0;
			base.医_九天真气 = 0.0;
			base.医_升天二气功_万物回春 = 0.0;
			base.医_吸星大法 = 0.0;
			base.刺_荆轲之怒 = 0.0;
			base.刺_三花聚顶 = 0.0;
			base.刺_连环飞舞 = 0.0;
			base.刺_必杀一击 = 0.0;
			base.刺_心神凝聚 = 0.0;
			base.刺_致手绝命 = 0.0;
			base.刺_先发制人 = 0.0;
			base.刺_千蛛万手 = 0.0;
			base.刺_连消带打 = 0.0;
			base.刺_剑刃乱舞 = 0.0;
			base.刺_一招残杀 = 0.0;
			base.刺_升天三气功_无情打击 = 0.0;
			base.琴师_高山流水 = 0.0;
			base.琴师_汉宫秋月 = 0.0;
			base.琴师_鸾凤和鸣 = 0.0;
			base.琴师_梅花三弄 = 0.0;
			base.琴师_清心普善 = 0.0;
			base.琴师_秋江夜泊 = 0.0;
			base.琴师_潇湘雨夜 = 0.0;
			base.琴师_阳关三叠 = 0.0;
			base.琴师_阳明春晓 = 0.0;
			base.琴师_岳阳三醉 = 0.0;
			base.琴师_战马奔腾 = 0.0;
			base.琴师_三和弦_发动概率 = 0.0;
			base.谭_冲冠一怒 = 0.0;
			base.谭_怒海狂澜 = 0.0;
			base.谭_回柳身法 = 0.0;
			base.谭_纵横无双 = 0.0;
			base.谭_移花接木 = 0.0;
			base.谭_护身罡气 = 0.0;
			base.谭_连环飞舞 = 0.0;
			base.韩_升天一气功_行风弄舞 = 0.0;
			base.韩_升天二气功_天魔护体 = 0.0;
			base.韩_升天二气功_内息行心 = 0.0;
			base.刀_升天一气功_遁出逆境 = 0.0;
			base.剑_乘胜追击 = 0.0;
			base.枪_升天一气功_破甲刺魂 = 0.0;
			base.弓_升天一气功_绝影射魂 = 0.0;
			base.医_狂意护体 = 0.0;
			base.医_升天一气功_护身气甲 = 0.0;
			base.刺_升天一气功_夜魔缠身 = 0.0;
			base.升天一气功_力劈华山 = 0.0;
			base.升天一气功_长虹贯日 = 0.0;
			base.升天一气功_金钟罡气 = 0.0;
			base.升天一气功_运气行心 = 0.0;
			base.升天一气功_正本培源 = 0.0;
			base.升天一气功_运气疗伤 = 0.0;
			base.升天一气功_百变神行 = 0.0;
			base.升天一气功_狂风天意 = 0.0;
			base.刀_升天二气功_穷途末路 = 0.0;
			base.剑_升天二气功_天地同寿 = 0.0;
			base.枪_升天二气功_以退为进 = 0.0;
			base.弓_升天二气功_千钧压驼 = 0.0;
			base.医_无中生有 = 0.0;
			base.刺_升天二气功_顺水推舟 = 0.0;
			base.琴师_升天一气功_飞花点翠 = 0.0;
			base.琴师_升天二气功_三潭映月 = 0.0;
			base.琴师_升天三气功_子夜秋歌 = 0.0;
			base.刺_以怒还怒 = 0.0;
			base.刀_梵音破镜 = 0.0;
			base.剑_升天三气功_火凤临朝 = 0.0;
			base.枪_怒意之吼 = 0.0;
			base.弓_升天三气功_天外三矢 = 0.0;
			base.医_升天三气功_明镜止水 = 0.0;
			base.谭_升天三气功_以柔克刚 = 0.0;
			base.谭_升天三气功_火凤临朝 = 0.0;
			base.谭_升天二气功_天地同寿 = 0.0;
			base.谭_升天二气功_纵横无双 = 0.0;
			base.谭_升天一气功_怒海狂澜 = 0.0;
			base.升天四式_红月狂风 = 0.0;
			base.升天四式_毒蛇出洞 = 0.0;
			base.升天四式_满月狂风 = 0.0;
			base.升天四式_烈日炎炎 = 0.0;
			base.升天四式_望梅添花 = 0.0;
			base.升天四式_悬丝诊脉 = 0.0;
			base.升天四式_长虹贯天 = 0.0;
			base.升天四式_哀鸿遍野 = 0.0;
			base.升天五式_致残 = 0.0;
			base.升天五式_破空坠星 = 0.0;
			base.升天五式_魔魂之力 = 0.0;
			base.升天五式_不死之躯 = 0.0;
			base.升天五式_惊涛骇浪 = 0.0;
			base.升天五式_天魔之力 = 0.0;
			base.升天五式_龙爪纤指手 = 0.0;
			base.升天五式_一招杀神 = 0.0;
			base.升天五式_形移妖相 = 0.0;
			base.升天五式_千里一击 = 0.0;
			base.升天五式_灭世狂舞 = 0.0;
			base.升天五式_惊天动地 = 0.0;
			base.升天五式_龙魂附体 = 0.0;
			base.升天一式_陵劲淬砺 = 0.0;
			base.升天二式_杀星光符 = 0.0;
			base.升天三式_技冠群雄 = 0.0;
			人物_WX_BUFF_生命 = 0;
			人物_WX_BUFF_攻击 = 0;
			人物_WX_BUFF_防御 = 0;
			人物_WX_BUFF_回避 = 0;
			人物_WX_BUFF_内功 = 0;
			人物_WX_BUFF_命中 = 0;
			人物_WX_BUFF_气功 = 0;
			base.狂风万破 = 0.0;
			上河调计数 = 0;
			下河调计数 = 0;
			玉连环计数 = 0;
			FLD_攻击速度 = 100;
			潜行模式 = 0;
			爆毒状态 = 0.0;
			刺_连消带打数量 = 0.0;
			关起来 = 0;
			升天武功点数 = 0;
			升天历练数 = 0;
			升天历练当前获得数 = 0;
			base.流星漫天 = 0.0;
			base.弱点攻破 = 0.0;
			base.牢不可破 = 0.0;
			base.陵劲淬砺 = 0.0;
			base.卢_破血狂风 = 0.0;
			base.技冠群雄 = 0.0;
			base.神女杀星义虎 = 10.0;
			base.神女杀星义杀 = 10.0;
			base.神女运气行心 = 0.0;
			base.神女太极心法 = 0.0;
			base.神女神力激发 = 0.0;
			base.神女杀星义气 = 0.0;
			base.神女洗髓易筋 = 0.0;
			base.神女黑花漫开 = 0.0;
			base.神女长功击力 = 0.0;
			base.神女黑花集中 = 0.0;
			base.神女真武绝击 = 0.0;
			base.神女万毒不侵 = 0.0;
			base.神女愤怒调节 = 0.0;
			base.神女蛊毒解除 = 0.0;
			base.神女神力保护 = 0.0;
			base.神女尸毒爆发 = 0.0;
		}

		~PlayersBes()
		{
		}

		public PlayersBes(NetState netState_1)
		{
			触发鸾凤和鸣 = false;
			Player无敌 = false;
			PK死亡 = false;
			跑走 = false;
			触发地图移动事件 = false;
			是否更新配置 = false;
			上线 = false;
			装备追加对怪防御 = 0;
			装备追加对怪攻击 = 0;
			武器攻击力 = 0;
			武器武功攻击力百分比 = 0.0;
			衣服防御力 = 0;
			衣服武功防御力百分比 = 0.0;
			交易人物ID = 0;
			交易操作ID = 0;
			Temp游戏安全码 = string.Empty;
			商店名 = string.Empty;
			安全码操作ID = 0;
			安全码是否通过验证 = false;
			是否已婚 = 0;
			证婚人提问答案 = 2;
			解除关系倒计时 = 0;
			婚戒刻字 = string.Empty;
			客户端设置 = string.Empty;
			荣誉ID_ = 0;
			是否携带披风行囊 = false;
			怒 = false;
			中毒 = false;
			新武功连击 = new List<武功类>();
			SerList = new Dictionary<int, ServerList>(10);
			刺客发起技能加成 = false;
			刺客物理攻击加成 = 0.0;
			刺客魔法攻击加成 = 0.0;
			每日获得武勋 = 0;
			丢失武勋 = 0;
			lastX = 0f;
			lastY = 0f;
			lastMAP = 101;
			AttackX = 0f;
			AttackY = 0f;
			攻击次数 = 0;
			当前激活技能ID = 0;
			心跳次数阀值 = 3;
			修炼地图剩余时间 = 0;
			活动地图剩余时间 = 0;
			凝神宝珠位置 = -1;
			FLD_宠物_追加_攻击 = 0;
			FLD_宠物_追加_防御 = 0;
			FLD_宠物_追加_最大HP = 0;
			弓群攻触发心神 = false;
			韩飞官_天魔狂血攻击力 = 0.0;
			韩飞官_天魔狂血叠加次数 = 0;
			升天气功武功等级 = 0.0;
			FLD_爱情度等级 = 0;
			FLD_是否可以送花 = true;
			当前操作类型 = 0;
			人物锁定 = false;
			锁定人物几率 = 0;
			人物追加战力 = 0;
			FLD_夫妻辅助_追加_防具_属性 = 0;
			FLD_夫妻辅助_追加_武器_属性 = 0;
			FLD_结婚礼物_追加_属性石 = 0;
			解除师徒关系时间 = DateTime.Parse("2012/12/12      12:12:12");
			丢失武勋 = 0;
			武皇通币 = 0;
			拳师连击控制 = 0;
			拳师会心一击威力 = 0.3;
			传书列表 = new Dictionary<int, 个人传书类>();
			天地同寿回避次数 = 0;
			天地同寿回避累积攻击力 = 0;
			FLD_荣誉ID = 0;
			夫妻武功攻击力MP = 0;
			夫妻武功攻击力 = 0;
			潜行模式 = 0;
			装备数据版本 = 1;
			综合仓库装备数据版本 = 1;
			PKhmtime = DateTime.Now;
			TMJCtime = DateTime.Now;
			XThmtime = DateTime.Now;
			FBtime = DateTime.Now;
			CWhmtime = DateTime.Now;
			SThmtime = DateTime.Now;
			Config = new ConfigClass();
			交易 = new 交易类();
			Client = netState_1;
			妖花青草 = false;
			NpcList = new ThreadSafeDictionary<int, NpcClass>();
			地面物品列表 = new ThreadSafeDictionary<double, 地面物品类>();
			土灵符坐标 = new Hashtable();
			攻击列表 = new List<攻击类>();
			玉连环 = new List<int>();
			FLD_追加哀鸿片野_HP上限 = 0.0;
			人物追加最大_HP = 0;
			人物追加最大_MP = 0;
			人物基本最大_HP = 0;
			FLD_装备_追加_障力恢复量 = 0;
			FLD_装备_追加_HP = 0;
			人物_气功_追加_HP = 0;
			人物基本最大_MP = 0;
			人物基本最大_障力 = 0;
			FLD_装备_追加_MP = 0;
			人物_气功_追加_MP = 0;
			FLD_攻击速度 = 100;
			人物_AP = 0;
			爆毒状态 = 0.0;
			刺_连消带打数量 = 0.0;
			升天武功点数 = 0;
			组队阶段 = 0;
			安全模式 = 0;
			当前操作NPC = 0;
			称号排名 = 0;
			行走状态id1 = 0;
			门派称号类型 = 0;
		}

		public bool GetSTQG(int int_109)
		{
			升天气功类 value;
			if (升天气功 != null && 升天气功.Count != 0)
			{
				return 升天气功.TryGetValue(int_109, out value);
			}
			return false;
		}

		public bool GetAddState(int int_109)
		{
			追加状态类 value;
			if (追加状态列表 != null && 追加状态列表.Count != 0)
			{
				return 追加状态列表.TryGetValue(int_109, out value);
			}
			return false;
		}

		public bool GetAddStateNew(int int_109)
		{
			追加状态New类 value;
			if (追加状态New列表 != null && 追加状态New列表.Count != 0)
			{
				return 追加状态New列表.TryGetValue(int_109, out value);
			}
			return false;
		}

		public bool GetAbnormalState(int int_109)
		{
			异常状态类 value;
			if (异常状态 != null && 异常状态.Count != 0)
			{
				return 异常状态.TryGetValue(int_109, out value);
			}
			return false;
		}

		public void 气功Clear()
		{
			for (int i = 0; i < 12; i++)
			{
				气功[i] = new 气功类(new byte[4]);
			}
		}

		public void 任务Clear()
		{
			任务 = new Dictionary<int, 任务类>();
		}

		public void addFLD_追加百分比_攻击(double double_264)
		{
			using (new Lock(thisLock, "addFLD_追加百分比_攻击"))
			{
				FLD_追加百分比_攻击 += double_264;
			}
		}

		public void delFLD_追加百分比_攻击(double double_264)
		{
			using (new Lock(thisLock, "dllFLD_追加百分比_攻击"))
			{
				FLD_追加百分比_攻击 -= double_264;
				if (!(FLD_追加百分比_攻击 >= 0.0))
				{
					FLD_追加百分比_攻击 = 0.0;
				}
			}
		}

		public void addFLD_追加百分比_防御(double double_264)
		{
			using (new Lock(thisLock, "addFLD_追加百分比_防御"))
			{
				FLD_追加百分比_防御 += double_264;
			}
		}

		public void delFLD_追加百分比_防御(double double_264)
		{
			using (new Lock(thisLock, "dllFLD_追加百分比_防御"))
			{
				FLD_追加百分比_防御 -= double_264;
				if (!(FLD_追加百分比_防御 >= 0.0))
				{
					FLD_追加百分比_防御 = 0.0;
				}
			}
		}

		public void addFLD_装备_追加_武器_强化(int int_109)
		{
			using (new Lock(thisLock, "addFLD_装备_追加_武器_强化"))
			{
				FLD_装备_追加_武器_强化 += int_109;
			}
		}

		public void delFLD_装备_追加_武器_强化(int int_109)
		{
			using (new Lock(thisLock, "dllFLD_装备_追加_武器_强化"))
			{
				FLD_装备_追加_武器_强化 -= int_109;
				if (FLD_装备_追加_武器_强化 < 0)
				{
					FLD_装备_追加_武器_强化 = 0;
				}
			}
		}

		public void addFLD_装备_追加_防具_强化(int int_109)
		{
			using (new Lock(thisLock, "addFLD_装备_追加_防具_强化"))
			{
				FLD_装备_追加_防具_强化 += int_109;
			}
		}

		public void delFLD_装备_追加_防具_强化(int int_109)
		{
			using (new Lock(thisLock, "dllFLD_装备_追加_防具_强化"))
			{
				FLD_装备_追加_防具_强化 -= int_109;
				if (FLD_装备_追加_防具_强化 < 0)
				{
					FLD_装备_追加_防具_强化 = 0;
				}
			}
		}

		public bool 检查物品系统(Itimesx itimesx_0)
		{
			if (itimesx_0.属性类型 != 0)
			{
				if (itimesx_0.属性类型 == 1)
				{
					if (World.物品最高攻击值 != 0 && itimesx_0.属性数量 >= World.物品最高攻击值)
					{
						return true;
					}
				}
				else if (itimesx_0.属性类型 == 2)
				{
					if (World.物品最高防御值 != 0 && itimesx_0.属性数量 >= World.物品最高防御值)
					{
						return true;
					}
				}
				else if (itimesx_0.属性类型 == 3)
				{
					if (World.物品最高生命值 != 0 && itimesx_0.属性数量 >= World.物品最高生命值)
					{
						return true;
					}
				}
				else if (itimesx_0.属性类型 == 4)
				{
					if (World.物品最高内功值 != 0 && itimesx_0.属性数量 >= World.物品最高内功值)
					{
						return true;
					}
				}
				else if (itimesx_0.属性类型 == 5)
				{
					if (World.物品最高命中值 != 0 && itimesx_0.属性数量 >= World.物品最高命中值)
					{
						return true;
					}
				}
				else if (itimesx_0.属性类型 == 6)
				{
					if (World.物品最高回避值 != 0 && itimesx_0.属性数量 >= World.物品最高回避值)
					{
						return true;
					}
				}
				else if (itimesx_0.属性类型 == 7)
				{
					if (World.物品最高武功值 != 0 && itimesx_0.属性数量 >= World.物品最高武功值)
					{
						return true;
					}
				}
				else if (itimesx_0.属性类型 == 8)
				{
					if (World.物品最高气功值 != 0 && itimesx_0.属性数量 >= World.物品最高气功值)
					{
						return true;
					}
				}
				else if (itimesx_0.属性类型 == 9)
				{
					if (World.物品最高合成值 != 0 && itimesx_0.属性数量 >= World.物品最高合成值)
					{
						return true;
					}
				}
				else if (itimesx_0.属性类型 == 11 && World.物品最高合成值 != 0 && itimesx_0.属性数量 >= World.物品最高武防值)
				{
					return true;
				}
			}
			return false;
		}

		public void 封号(int int_109, string string_11, string string_12)
		{
			DBA.ExeSqlCommand(string.Format("UPDATE      TBL_ACCOUNT      SET      FLD_ZT={1},FLD_NAME='{2}'      WHERE      FLD_ID='{0}'", Userid, int_109, string_12), "rxjhaccount");
			Client.Dispose();
		}

		public void 检查物品系统(string string_11, ref 物品类 物品类_0)
		{
			DateTime value = new DateTime(1970, 1, 1, 8, 0, 0);
			if (物品类_0.FLD_JSSJ > 物品类_0.FLD_KSSJ && DateTime.Now.Subtract(value).TotalSeconds > (double)物品类_0.FLD_JSSJ)
			{
				系统提示("您有物品过期[" + 物品类_0.得到物品名称() + "],系统已删除！", 9, "装备到期提示");
				物品类_0.物品_byte = new byte[73];
				return;
			}
			switch (World.查非法物品)
			{
			case 2:
			{
				物品类_0.得到物品属性方法(0, 0);
				装备检测类 value2;
				if (!World.装备检测list.TryGetValue(物品类_0.FLD_RESIDE2, out value2) || !检查物品系统2(物品类_0, value2))
				{
					break;
				}
				string text = string.Format("SELECT  count(*)  FROM  Itme_Log  WHERE  ItmeId={0}", BitConverter.ToInt32(物品类_0.物品全局ID, 0));
				int num;
				try
				{
					num = (int)DBA.GetDBValue_3(text, "WebDb");
				}
				catch
				{
					num = -1;
				}
				if (num == 0)
				{
					Form1.WriteLine(77, "非法物品  " + string_11 + "  [" + Userid + "]-[" + UserName + "]  位置[" + 物品类_0.物品位置 + "]  编号[" + BitConverter.ToInt32(物品类_0.物品全局ID, 0) + "]  物品名称[" + 物品类_0.得到物品名称() + "]  物品数量[" + BitConverter.ToInt32(物品类_0.物品数量, 0) + "]  属性:[" + 物品类_0.FLD_MAGIC0 + "," + 物品类_0.FLD_MAGIC1 + "," + 物品类_0.FLD_MAGIC2 + "," + 物品类_0.FLD_MAGIC3 + "," + 物品类_0.FLD_MAGIC4 + "]  绑定[" + 物品类_0.物品绑定 + "]  魂[" + 物品类_0.FLD_FJ_觉醒 + "]  进化[" + 物品类_0.FLD_FJ_进化 + "]");
					if (World.查非法物品操作 == 1)
					{
						物品类_0.物品_byte = new byte[World.数据库单个物品大小];
					}
					else if (World.查非法物品操作 == 2)
					{
						封号(72, Userid, "查非法物品操作2-6");
					}
				}
				break;
			}
			case 1:
				if (!World.查绑定非法物品 && 物品类_0.物品绑定)
				{
					break;
				}
				if (物品类_0.属性1.属性类型 != 0 && 检查物品系统(物品类_0.属性1))
				{
					Form1.WriteLine(77, "非法物品  " + string_11 + "  [" + Userid + "]-[" + UserName + "]  位置[" + 物品类_0.物品位置 + "]  编号[" + BitConverter.ToInt32(物品类_0.物品全局ID, 0) + "]  物品名称[" + 物品类_0.得到物品名称() + "]  物品数量[" + BitConverter.ToInt32(物品类_0.物品数量, 0) + "]  属性:[" + 物品类_0.FLD_MAGIC0 + "," + 物品类_0.FLD_MAGIC1 + "," + 物品类_0.FLD_MAGIC2 + "," + 物品类_0.FLD_MAGIC3 + "," + 物品类_0.FLD_MAGIC4 + "]");
					if (World.查非法物品操作 == 1)
					{
						物品类_0.物品_byte = new byte[World.数据库单个物品大小];
					}
					else if (World.查非法物品操作 == 2)
					{
						封号(72, Userid, "查非法物品操作2-1");
					}
				}
				else if (物品类_0.属性2.属性类型 != 0 && 检查物品系统(物品类_0.属性2))
				{
					Form1.WriteLine(77, "非法物品  " + string_11 + "  [" + Userid + "]-[" + UserName + "]  位置[" + 物品类_0.物品位置 + "]  编号[" + BitConverter.ToInt32(物品类_0.物品全局ID, 0) + "]  物品名称[" + 物品类_0.得到物品名称() + "]  物品数量[" + BitConverter.ToInt32(物品类_0.物品数量, 0) + "]  属性:[" + 物品类_0.FLD_MAGIC0 + "," + 物品类_0.FLD_MAGIC1 + "," + 物品类_0.FLD_MAGIC2 + "," + 物品类_0.FLD_MAGIC3 + "," + 物品类_0.FLD_MAGIC4 + "]");
					if (World.查非法物品操作 == 1)
					{
						物品类_0.物品_byte = new byte[World.数据库单个物品大小];
					}
					else if (World.查非法物品操作 == 2)
					{
						封号(72, Userid, "查非法物品操作2-2");
					}
				}
				else if (物品类_0.属性3.属性类型 != 0 && 检查物品系统(物品类_0.属性3))
				{
					Form1.WriteLine(77, "非法物品  " + string_11 + "  [" + Userid + "]-[" + UserName + "]  位置[" + 物品类_0.物品位置 + "]  编号[" + BitConverter.ToInt32(物品类_0.物品全局ID, 0) + "]  物品名称[" + 物品类_0.得到物品名称() + "]  物品数量[" + BitConverter.ToInt32(物品类_0.物品数量, 0) + "]  属性:[" + 物品类_0.FLD_MAGIC0 + "," + 物品类_0.FLD_MAGIC1 + "," + 物品类_0.FLD_MAGIC2 + "," + 物品类_0.FLD_MAGIC3 + "," + 物品类_0.FLD_MAGIC4 + "]");
					if (World.查非法物品操作 == 1)
					{
						物品类_0.物品_byte = new byte[World.数据库单个物品大小];
					}
					else if (World.查非法物品操作 == 2)
					{
						封号(72, Userid, "查非法物品操作2-3");
					}
				}
				else if (物品类_0.属性4.属性类型 != 0 && 检查物品系统(物品类_0.属性4))
				{
					Form1.WriteLine(77, "非法物品  " + string_11 + "  [" + Userid + "]-[" + UserName + "]  位置[" + 物品类_0.物品位置 + "]  编号[" + BitConverter.ToInt32(物品类_0.物品全局ID, 0) + "]  物品名称[" + 物品类_0.得到物品名称() + "]  物品数量[" + BitConverter.ToInt32(物品类_0.物品数量, 0) + "]  属性:[" + 物品类_0.FLD_MAGIC0 + "," + 物品类_0.FLD_MAGIC1 + "," + 物品类_0.FLD_MAGIC2 + "," + 物品类_0.FLD_MAGIC3 + "," + 物品类_0.FLD_MAGIC4 + "]");
					if (World.查非法物品操作 == 1)
					{
						物品类_0.物品_byte = new byte[World.数据库单个物品大小];
					}
					else if (World.查非法物品操作 == 2)
					{
						封号(72, Userid, "查非法物品操作2-4");
					}
				}
				else if ((物品类_0.FLD_RESIDE2 == 1 || 物品类_0.FLD_RESIDE2 == 4) && 物品类_0.FLD_FJ_觉醒 >= World.物品最高附魂值)
				{
					Form1.WriteLine(77, "非法物品  " + string_11 + "  [" + Userid + "]-[" + UserName + "]  位置[" + 物品类_0.物品位置 + "]  编号[" + BitConverter.ToInt32(物品类_0.物品全局ID, 0) + "]  物品名称[" + 物品类_0.得到物品名称() + "]  物品数量[" + BitConverter.ToInt32(物品类_0.物品数量, 0) + "]  属性:[" + 物品类_0.FLD_MAGIC0 + "," + 物品类_0.FLD_MAGIC1 + "," + 物品类_0.FLD_MAGIC2 + "," + 物品类_0.FLD_MAGIC3 + "," + 物品类_0.FLD_MAGIC4 + "]");
					if (World.查非法物品操作 == 1)
					{
						物品类_0.物品_byte = new byte[World.数据库单个物品大小];
					}
					else if (World.查非法物品操作 == 2)
					{
						封号(72, Userid, "查非法物品操作2-5");
					}
				}
				break;
			}
		}

		public bool 检查物品系统2(物品类 物品类_0, 装备检测类 装备检测类_0)
		{
			if ((装备检测类_0.物品最高攻击值 != 0 && 物品类_0.物品属性_攻击力增加 >= 装备检测类_0.物品最高攻击值) || (装备检测类_0.物品最高防御值 != 0 && 物品类_0.物品属性_防御力增加 >= 装备检测类_0.物品最高防御值) || (装备检测类_0.物品最高生命值 != 0 && 物品类_0.物品属性_生命力增加 >= 装备检测类_0.物品最高生命值) || (装备检测类_0.物品最高内功值 != 0 && 物品类_0.物品属性_内功力增加 >= 装备检测类_0.物品最高内功值) || (装备检测类_0.物品最高命中值 != 0 && 物品类_0.物品属性_命中率增加 >= 装备检测类_0.物品最高命中值) || (装备检测类_0.物品最高回避值 != 0 && 物品类_0.物品属性_回避率增加 >= 装备检测类_0.物品最高回避值) || (装备检测类_0.物品最高武功值 != 0 && 物品类_0.物品属性_武功攻击力 >= 装备检测类_0.物品最高武功值) || (装备检测类_0.物品最高气功值 != 0 && 物品类_0.物品属性_全部气功等级增加 >= 装备检测类_0.物品最高气功值))
			{
				return true;
			}
			if (装备检测类_0.物品最高附魂值 != 0)
			{
				return 物品类_0.FLD_FJ_觉醒 >= 装备检测类_0.物品最高附魂值;
			}
			return false;
		}

		public void 读出灵兽数据(long long_5, Players players_0)
		{
			try
			{
				DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT      *      FROM      TBL_XWWL_Cw      WHERE      ItmeId      ={0}", long_5));
				if (dBToDataTable.Rows.Count > 0)
				{
					人物灵兽 = new 灵兽类(long_5, Client, dBToDataTable, players_0);
					if (人物灵兽 != null)
					{
						人物灵兽.全服ID = 人物灵兽全服ID;
					}
					else
					{
						系统提示("灵兽召唤出错,请联系管理员。");
					}
				}
				dBToDataTable.Dispose();
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "读出灵兽数据出错      [" + Userid + "][" + UserName + "][" + long_5 + "]      " + ex.Message);
			}
		}

		public double 得到气功加成值(int int_109, int int_110, int int_111)
		{
			try
			{
				foreach (气功加成属性 value in World.气功加成.Values)
				{
					if (value.FLD_JOB == int_109 && value.FLD_INDEX == int_110)
					{
						return (int_111 == 0) ? value.FLD_每点加成比率值1 : value.FLD_每点加成比率值2;
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "得到气功加成比率值出错      [" + Userid + "][" + UserName + "]" + ex.Message);
			}
			return 0.0;
		}

		public double 得到升天气功加成值(int int_109)
		{
			try
			{
				升天气功总类 value;
				if (World.升天气功List.TryGetValue(int_109, out value))
				{
					return value.FLD_每点加成比率值;
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "得到升天气功加成比率值出错      [" + Userid + "][" + UserName + "]" + ex.Message);
			}
			return 0.0;
		}

		public double 得到单项气功增加值(int int_109)
		{
			switch (int_109)
			{
			case 58:
				return FLD_装备_追加_升天一护身气甲;
			case 33:
				return FLD_装备_追加_升天三怒意之火;
			case 0:
				return FLD_装备_追加_气功_0;
			case 1:
				return FLD_装备_追加_气功_1;
			case 2:
				return FLD_装备_追加_气功_2;
			case 3:
				return FLD_装备_追加_气功_3;
			case 4:
				return FLD_装备_追加_气功_4;
			case 5:
				return FLD_装备_追加_气功_5;
			case 6:
				return FLD_装备_追加_气功_6;
			case 7:
				return FLD_装备_追加_气功_7;
			case 8:
				return FLD_装备_追加_气功_8;
			case 9:
				return FLD_装备_追加_气功_9;
			case 10:
				return FLD_装备_追加_气功_10;
			case 11:
				return FLD_装备_追加_气功_11;
			case 13:
				return FLD_装备_追加_升天三火龙之火;
			case 25:
				return FLD_装备_追加_升天一护身罡气;
			case 310:
				return FLD_装备_追加_升天一遁出逆境;
			case 311:
				return FLD_装备_追加_升天二穷途末路;
			case 313:
				return FLD_装备_追加_升天四红月狂风;
			case 314:
				return FLD_装备_追加_升天四毒蛇出洞;
			case 321:
				return FLD_装备_追加_升天二天地同寿;
			case 322:
				return FLD_装备_追加_升天三火凤临朝;
			case 323:
				return FLD_装备_追加_升天四红月狂风;
			case 324:
				return FLD_装备_追加_升天四毒蛇出洞;
			case 170:
				return FLD_装备_追加_升天三无情打击;
			case 150:
				return FLD_装备_追加_升天二万物回春;
			case 370:
				return FLD_装备_追加_升天一夜魔缠身;
			case 371:
				return FLD_装备_追加_升天二顺水推舟;
			case 373:
				return FLD_装备_追加_升天四满月狂风;
			case 374:
				return FLD_装备_追加_升天四烈日炎炎;
			case 380:
				return FLD_装备_追加_升天一力劈华山;
			case 381:
				return FLD_装备_追加_升天一长虹贯日;
			case 382:
				return FLD_装备_追加_升天一金钟罡气;
			case 383:
				return FLD_装备_追加_升天一运气行心;
			case 384:
				return FLD_装备_追加_升天一正本培源;
			case 385:
				return FLD_装备_追加_升天一运气疗伤;
			case 386:
				return FLD_装备_追加_升天一百变神行;
			case 387:
				return FLD_装备_追加_升天一狂风天意;
			case 390:
				return FLD_装备_追加_升天一飞花点翠;
			case 391:
				return FLD_装备_追加_升天二三潭映月;
			case 392:
				return FLD_装备_追加_升天三子夜秋歌;
			case 393:
				return FLD_装备_追加_升天四红月狂风;
			case 394:
				return FLD_装备_追加_升天四悬丝诊脉;
			case 352:
				return FLD_装备_追加_升天三明镜止水;
			case 353:
				return FLD_装备_追加_升天四满月狂风;
			case 354:
				return FLD_装备_追加_升天四望梅添花;
			case 330:
				return FLD_装备_追加_升天一破甲刺魂;
			case 331:
				return FLD_装备_追加_升天二以退为进;
			case 333:
				return FLD_装备_追加_升天四红月狂风;
			case 334:
				return FLD_装备_追加_升天四毒蛇出洞;
			case 340:
				return FLD_装备_追加_升天一绝影射魂;
			case 341:
				return FLD_装备_追加_升天二千钧压驼;
			case 342:
				return FLD_装备_追加_升天三天外三矢;
			case 343:
				return FLD_装备_追加_升天四满月狂风;
			case 344:
				return FLD_装备_追加_升天四烈日炎炎;
			default:
				return 0.0;
			case 700:
				return FLD_装备_追加_升天三以柔克刚;
			case 701:
				return FLD_装备_追加_升天四长虹贯天;
			case 702:
				return FLD_装备_追加_升天四哀鸿遍野;
			case 600:
				return FLD_装备_追加_升天一行风弄舞;
			case 601:
				return FLD_装备_追加_升天二天魔护体;
			case 602:
				return FLD_装备_追加_升天三内息行心;
			case 603:
				return FLD_装备_追加_升天四长虹贯天;
			case 604:
				return FLD_装备_追加_升天四哀鸿遍野;
			case 561:
				return FLD_装备_追加_升天一夺命连环;
			case 562:
				return FLD_装备_追加_升天一电光石火;
			case 563:
				return FLD_装备_追加_升天一精益求精;
			case 564:
				return FLD_装备_追加_升天四红月狂风;
			case 565:
				return FLD_装备_追加_升天四毒蛇出洞;
			}
		}

		public void 更新气功()
		{
			using (new Lock(thisLock, "更新气功"))
			{
				人物_气功_追加_HP = 0;
				人物_气功_追加_MP = 0;
				FLD_人物_气功_攻击 = 0.0;
				FLD_人物_气功_防御 = 0;
				FLD_人物_气功_命中 = 0;
				FLD_人物_气功_回避 = 0;
				FLD_人物_追加百分比_回避 = 0.0;
				FLD_追加百分比_命中 = 0.0;
				FLD_人物_气功_负重 = 0;
				FLD_人物_气功_武功攻击力增加百分比 = 0.0;
				FLD_人物_气功_武功防御力增加百分比 = 0.0;
				人物_气功_追加_武功防御力 = 0;
				for (int i = 0; i < 12; i++)
				{
					byte[] 气功_byte = 气功[i].气功_byte;
					if (气功_byte[0] != byte.MaxValue && BitConverter.ToInt16(气功_byte, 0) > 0)
					{
						double num = BitConverter.ToInt16(气功_byte, 0);
						if (num > 0.0)
						{
							double num2 = num + (double)FLD_装备_追加_气功 + (double)FLD_人物_追加_气功 + (double)人物_WX_BUFF_气功 + 得到单项气功增加值(i) + (double)FLD_药品_追加_气功;
							double num3 = 得到气功加成值(Player_Job, i, 0);
							switch (Player_Job)
							{
							case 1:
								switch (i)
								{
								case 0:
								{
									double num11 = (double)FLD_最小攻击 * num2 * num3 / 100.0 / 2.0;
									if (num11 < 1.0)
									{
										num11 = 1.0;
									}
									FLD_人物_气功_攻击 = (int)(num11 + 0.5);
									break;
								}
								case 1:
									FLD_人物_气功_命中 = (int)((double)FLD_命中 * (0.1 + num2 * num3));
									break;
								case 2:
									base.刀_连环飞舞 = 10.0 + num2 * num3;
									break;
								case 3:
									base.狂风万破 = num2 * num3;
									break;
								case 4:
									FLD_人物_气功_防御 = (int)((double)FLD_防御 * num2 * num3);
									人物_气功_追加_HP = (int)(num2 * 得到气功加成值(Player_Job, i, 1));
									break;
								case 5:
									base.破甲几率 = 5.0 + num2 * num3;
									break;
								case 6:
									base.气沉丹田 = num2 * num3;
									break;
								case 7:
									base.真武绝击 = num2 * num3;
									break;
								case 8:
									base.怪反伤几率 = 10.0 + num2 * num3;
									base.人反伤几率 = 3.0 + num2 * 得到气功加成值(Player_Job, i, 1);
									break;
								case 9:
									base.暗影绝杀 = 5.0 + num2 * num3;
									break;
								case 10:
									base.刀_梵音破镜 = num2 * num3;
									break;
								case 11:
									base.流光乱舞 = num2 * num3;
									break;
								}
								break;
							case 2:
								switch (i)
								{
								case 0:
								{
									double num10 = (double)FLD_最大攻击 * num2 * num3 / 100.0 / 5.0;
									if (num10 < 1.0)
									{
										num10 = 1.0;
									}
									FLD_人物_气功_攻击 = (int)(num10 + 0.5);
									break;
								}
								case 1:
									FLD_人物_追加百分比_回避 = 0.1 + num2 * num3;
									break;
								case 2:
									base.剑_连环飞舞 = 10.0 + num2 * num3;
									break;
								case 3:
									base.剑_破天一剑 = num2 * num3 * 0.01;
									break;
								case 4:
									base.狂风万破 = num2 * num3;
									break;
								case 5:
									base.剑_移花接木 = num2 * num3;
									break;
								case 6:
									base.气沉丹田 = num2 * num3;
									break;
								case 7:
									base.剑_怒海狂澜 = num2 * num3;
									break;
								case 8:
									base.剑_回柳身法 = num2 * num3;
									FLD_人物_气功_武功攻击力增加百分比 = num2 * 得到气功加成值(Player_Job, i, 1);
									break;
								case 9:
									base.剑_无坚不摧 = num2 * num3;
									break;
								case 10:
									base.剑_乘胜追击 = num2 * num3;
									break;
								case 11:
									base.剑_冲冠一怒 = 5.0 + num2 * num3;
									break;
								}
								break;
							case 3:
								switch (i)
								{
								case 0:
									FLD_人物_气功_防御 = (int)(num2 * num3);
									break;
								case 1:
									base.枪_运气疗伤 = num2 * num3 + 0.1;
									break;
								case 2:
									base.枪_连环飞舞 = 10.0 + num2 * num3;
									break;
								case 3:
									base.狂风万破 = num2 * num3;
									break;
								case 4:
									人物_气功_追加_HP = (int)(num2 * num3);
									break;
								case 5:
									base.枪_转攻为守 = 5.0 + num2 * num3;
									break;
								case 6:
									base.气沉丹田 = num2 * num3;
									break;
								case 7:
									base.枪_狂神降世 = num2 * num3;
									break;
								case 8:
									FLD_人物_气功_武功攻击力增加百分比 = num2 * num3;
									base.枪_连环飞舞 *= 1.0 + num2 * 得到气功加成值(Player_Job, i, 1);
									break;
								case 9:
									base.枪_末日狂舞 = num2 * num3;
									break;
								case 10:
									base.枪_怒意之吼 = num2 * num3;
									break;
								case 11:
									FLD_人物_气功_武功防御力增加百分比 = num2 * num3;
									break;
								}
								break;
							case 4:
								switch (i)
								{
								case 0:
									FLD_追加百分比_命中 = num2 * num3;
									break;
								case 1:
									base.弓_猎鹰之眼 = (int)(num2 * num3);
									break;
								case 2:
								{
									double num9 = (double)FLD_最小攻击 * num2 * num3 / 100.0 / 2.0;
									if (num9 < 1.0)
									{
										num9 = 1.0;
									}
									FLD_人物_气功_攻击 = (int)(num9 + 0.5);
									break;
								}
								case 3:
									base.狂风万破 = num2 * num3;
									break;
								case 4:
									人物_气功_追加_HP = (int)(num2 * num3);
									break;
								case 5:
									base.弓_锐利之箭 = 5.0 + num2 * num3;
									break;
								case 6:
									base.气沉丹田 = num2 * num3;
									break;
								case 7:
									base.弓_心神凝聚 = 10.0 + num2 * num3;
									break;
								case 8:
									base.弓_流星三矢 = 10.0 + num2 * num3;
									break;
								case 9:
									base.弓_回流真气 = num2 * num3;
									break;
								case 10:
									base.弓_无明暗矢 = num2 * num3;
									break;
								case 11:
									base.弓_致命绝杀 = 10.0 + num2 * num3;
									break;
								}
								break;
							case 5:
								switch (i)
								{
								case 0:
									base.医_运气疗心 = num2 * num3;
									break;
								case 1:
									base.医_太极心法 = num2 * num3;
									break;
								case 2:
									人物_气功_追加_HP = (int)(num2 * num3);
									break;
								case 3:
									人物_气功_追加_MP = (int)(num2 * num3);
									break;
								case 4:
									base.医_妙手回春 = 10.0 + num2 * num3;
									break;
								case 5:
									base.医_长攻击力 = num2 * num3;
									break;
								case 6:
									base.气沉丹田 = num2 * num3;
									break;
								case 7:
									base.真武绝击 = num2 * num3;
									break;
								case 8:
									base.医_吸星大法 = num2 * num3;
									break;
								case 9:
									base.医_狂意护体 = num2 * num3;
									break;
								case 10:
									base.医_无中生有 = num2 * num3;
									break;
								case 11:
									base.医_九天真气 = num2 * num3;
									break;
								}
								break;
							case 6:
								switch (i)
								{
								case 0:
								{
									double num8 = (double)FLD_最小攻击 * num2 * num3 / 100.0 / 2.0;
									if (num8 < 1.0)
									{
										num8 = 1.0;
									}
									FLD_人物_气功_攻击 = (int)(num8 + 0.5);
									base.刺_荆轲之怒 = num2 * 得到气功加成值(Player_Job, i, 1);
									break;
								}
								case 1:
									base.刺_三花聚顶 = 10.0 + num2 * num3;
									break;
								case 2:
									base.刺_连环飞舞 = 10.0 + num2 * num3;
									break;
								case 3:
									base.刺_心神凝聚 = 10.0 + num2 * num3;
									break;
								case 4:
									base.刺_致手绝命 = num2 * num3;
									break;
								case 5:
									base.刺_以怒还怒 = num2 * num3;
									break;
								case 6:
									base.气沉丹田 = num2 * num3;
									break;
								case 7:
									base.刺_先发制人 = num2 * num3;
									break;
								case 8:
									base.刺_千蛛万手 = num2 * num3;
									break;
								case 9:
									base.刺_连消带打 = num2 * num3;
									break;
								case 10:
									base.刺_剑刃乱舞 = num2 * num3;
									break;
								case 11:
									base.刺_一招残杀 = num2 * num3;
									break;
								}
								break;
							case 7:
								switch (i)
								{
								case 0:
								{
									double num7 = (double)FLD_最大攻击 * num2 * num3 / 100.0 / 5.0;
									if (num7 < 1.0)
									{
										num7 = 1.0;
									}
									FLD_人物_气功_攻击 = (int)(num7 + 0.5);
									break;
								}
								case 1:
									人物_气功_追加_HP = (int)(num2 * num3);
									break;
								case 2:
									人物_气功_追加_MP = (int)(num2 * num3);
									break;
								case 3:
									FLD_人物_气功_防御 = (int)(num2 * num3);
									人物_气功_追加_武功防御力 = (int)(num2 * 得到气功加成值(Player_Job, i, 1));
									FLD_人物_气功_武功防御力增加百分比 = (double)人物_气功_追加_武功防御力 * (1.0 - World.武功防降低百分比) * 0.01;
									break;
								case 4:
									FLD_人物_气功_武功攻击力增加百分比 = num2 * num3;
									break;
								case 5:
									base.琴师_高山流水 = num2 * num3;
									break;
								case 6:
									base.气沉丹田 = num2 * num3;
									break;
								case 7:
									base.琴师_岳阳三醉 = num2 * num3;
									break;
								case 8:
									base.琴师_梅花三弄 = num2 * num3;
									break;
								case 9:
									base.琴师_鸾凤和鸣 = num2 * num3;
									break;
								case 10:
									base.琴师_阳明春晓 = num2 * num3;
									break;
								case 11:
									base.琴师_潇湘雨夜 = num2 * num3;
									break;
								}
								break;
							case 8:
								switch (i)
								{
								case 0:
								{
									double num6 = (double)FLD_最小攻击 * num2 * num3 / 100.0 / 2.0;
									if (num6 < 1.0)
									{
										num6 = 1.0;
									}
									FLD_人物_气功_攻击 = (int)(num6 + 0.5);
									break;
								}
								case 1:
									FLD_人物_气功_命中 = (int)((double)FLD_命中 * (0.1 + num2 * num3));
									break;
								case 2:
									FLD_人物_追加百分比_回避 = 0.1 + num2 * num3;
									break;
								case 3:
									base.狂风万破 = num2 * num3;
									break;
								case 4:
									base.韩_天魔狂血 = num2 * num3;
									break;
								case 5:
									base.韩_追骨吸元 = num2 * num3;
									break;
								case 6:
									base.气沉丹田 = num2 * num3;
									break;
								case 7:
									base.破甲几率 = 5.0 + num2 * num3;
									break;
								case 8:
									base.真武绝击 = num2 * num3;
									break;
								case 9:
									base.韩_火龙问鼎 = num2 * num3;
									break;
								case 10:
									base.流光乱舞 = num2 * num3;
									break;
								case 11:
									base.暗影绝杀 = 5.0 + num2 * num3;
									break;
								}
								break;
							case 9:
								switch (i)
								{
								case 0:
								{
									double num5 = (double)FLD_最大攻击 * num2 * num3 / 100.0 / 5.0;
									if (num5 < 1.0)
									{
										num5 = 1.0;
									}
									FLD_人物_气功_攻击 = (int)(num5 + 0.5);
									break;
								}
								case 1:
									FLD_人物_追加百分比_回避 = 0.1 + num2 * num3;
									break;
								case 2:
									base.谭_连环飞舞 = 20.0 + num2 * num3;
									break;
								case 3:
									base.谭_招式新法 = 1000.0 * num3;
									break;
								case 4:
									base.狂风万破 = num2 * num3;
									break;
								case 5:
									base.谭_护身罡气 = 10.0 + num2 * num3;
									break;
								case 6:
									base.气沉丹田 = num2 * num3;
									break;
								case 7:
									base.谭_移花接木 = num2 * num3;
									break;
								case 8:
									base.谭_纵横无双 = 5.0 + num2 * num3;
									break;
								case 9:
									base.谭_回柳身法 = num2 * num3;
									FLD_人物_气功_武功攻击力增加百分比 = num2 * 得到气功加成值(Player_Job, i, 1);
									break;
								case 10:
									base.谭_怒海狂澜 = 5.0 + num2 * num3;
									break;
								case 11:
									base.谭_冲冠一怒 = 5.0 + num2 * num3;
									break;
								}
								break;
							case 10:
								switch (i)
								{
								case 0:
									base.拳师_狂神降世 = num3 * num2;
									break;
								case 1:
									base.枪_运气疗伤 = num3 * num2;
									break;
								case 2:
								{
									double num4 = (double)FLD_最小攻击 * num2 * num3 / 100.0 / 2.0;
									if (num4 < 1.0)
									{
										num4 = 1.0;
									}
									FLD_人物_气功_攻击 = (int)(num4 + 0.5);
									break;
								}
								case 3:
									base.狂风万破 = num2 * num3;
									break;
								case 4:
									FLD_人物_气功_武功防御力增加百分比 = num2 * num3;
									break;
								case 5:
									base.拳师_磨杵成针 = 10.0 + num2 * num3;
									break;
								case 6:
									base.气沉丹田 = num2 * num3;
									break;
								case 7:
									base.拳师_水火一体 = num2 * num3;
									break;
								case 8:
									base.拳师_金刚不坏 = 10.0 + num3 * num2;
									break;
								case 9:
									base.拳师_转攻为守 = 5.0 + num2 * num3;
									break;
								case 10:
									base.拳师_会心一击 = num2 * num3;
									break;
								case 11:
									base.拳师_末日狂舞 = num2 * num3;
									break;
								}
								break;
							case 11:
								switch (i)
								{
								case 0:
									base.梅_障力激活 = 5.0 + num2;
									break;
								case 1:
									base.梅_障力运用 = 10.0 + num2 * num3;
									break;
								case 2:
									FLD_人物_追加百分比_回避 = 0.1 + num2 * num3;
									break;
								case 3:
									base.梅_玄武神功 = num2 * num3;
									break;
								case 4:
									base.梅_玄武的指点 = 8.0 + num2 * num3;
									FLD_人物_气功_攻击 = (double)FLD_最大攻击 * num2 * 得到气功加成值(Player_Job, i, 1) / 2.0;
									break;
								case 5:
									base.梅_玄武强击 = num2;
									break;
								case 6:
									base.气沉丹田 = num2 * num3;
									break;
								case 7:
									base.梅_玄武危化 = num2 * num3;
									break;
								case 8:
									base.梅_障力恢复 = num2 * num3;
									break;
								case 9:
									base.梅_嫉妒的化身 = num2 * num3;
									break;
								case 10:
									base.梅_愤怒爆发 = num2 * num3;
									break;
								case 11:
									base.梅_吸血进击 = num2 * num3;
									break;
								}
								break;
							case 12:
								switch (i)
								{
								case 0:
									FLD_人物_气功_防御 = (int)(num2 * num3);
									break;
								case 1:
									base.枪_运气疗伤 = num2 * num3 + 0.1;
									break;
								case 2:
									base.枪_连环飞舞 = 10.0 + num2 * num3;
									break;
								case 3:
									人物_气功_追加_HP = (int)(num2 * num3);
									break;
								case 4:
									base.狂风万破 = num2 * num3;
									break;
								case 5:
									base.真武绝击 = num2 * num3;
									break;
								case 6:
									base.气沉丹田 = num2 * num3;
									break;
								case 7:
									base.流星漫天 = num2 * num3;
									if (Player_Job_leve == 3)
									{
										base.流星漫天 += 5.0;
									}
									else if (Player_Job_leve == 4)
									{
										base.流星漫天 += 10.0;
									}
									else if (Player_Job_leve == 5)
									{
										base.流星漫天 += 15.0;
									}
									else if (Player_Job_leve >= 6)
									{
										base.流星漫天 += 20.0;
									}
									break;
								case 8:
									FLD_人物_气功_武功攻击力增加百分比 = num2 * num3;
									base.枪_连环飞舞 *= 1.0 + num2 * 得到气功加成值(Player_Job, i, 1);
									break;
								case 9:
									base.卢_转攻为守 = num2 * num3;
									break;
								case 10:
									base.弱点攻破 = 10.0 + num2 * num3;
									break;
								case 11:
									base.牢不可破 = num2 * num3;
									break;
								}
								break;
							case 13:
								switch (i)
								{
								case 0:
									base.神女运气行心 = num2 * num3;
									break;
								case 1:
									base.神女太极心法 = num2 * num3;
									break;
								case 2:
									base.神女神力激发 = num2 * num3;
									break;
								case 3:
									base.神女杀星义气 = num2 * num3;
									break;
								case 4:
									人物_气功_追加_MP = (int)(num2 * num3);
									break;
								case 5:
									base.气沉丹田 = num2 * num3;
									break;
								case 6:
									base.神女黑花漫开 = num2 * num3;
									break;
								case 7:
									base.神女妙手回春 = num2 * num3;
									break;
								case 8:
									base.神女长功击力 = num2 * num3;
									break;
								case 9:
									base.神女黑花集中 = num2 * num3;
									break;
								case 10:
									base.神女真武绝击 = num2 * num3;
									break;
								case 11:
									base.神女万毒不侵 = num2 * num3;
									break;
								}
								break;
							}
						}
					}
				}
				if (base.气沉丹田 > 0.0)
				{
					int num12 = (int)((double)FLD_防御 * base.气沉丹田 / 100.0);
					人物_气功_追加_HP += num12;
					人物_气功_追加_武功防御力 += num12;
					FLD_人物_气功_武功防御力增加百分比 += (double)人物_气功_追加_武功防御力 * (1.0 - World.武功防降低百分比) * 0.01;
				}
				try
				{
					if (Player_Job_leve >= 6 && 升天气功 != null)
					{
						foreach (升天气功类 value in 升天气功.Values)
						{
							if (value.气功量 > 0)
							{
								double num13 = (double)(value.气功量 + FLD_装备_追加_气功 + FLD_人物_追加_气功 + 人物_WX_BUFF_气功) + 得到单项气功增加值(value.气功ID) + (double)FLD_药品_追加_气功;
								double num14 = 得到升天气功加成值(value.气功ID);
								switch (value.气功ID)
								{
								case 25:
									base.剑_升天三气功_护身罡气 = 10.0 + num13 * num14;
									break;
								case 13:
									base.刀_升天三气功_火龙之火 = num13 * num14;
									break;
								case 150:
									base.医_升天二气功_万物回春 = num13 * num14;
									break;
								case 58:
									FLD_人物_气功_防御 += (int)(num13 * num14 * (double)FLD_人物基本_攻击);
									break;
								case 33:
									base.枪_升天三气功_怒意之火 = num13 * num14;
									break;
								case 370:
									base.刺_升天一气功_夜魔缠身 = num13 * num14;
									break;
								case 371:
									base.刺_升天二气功_顺水推舟 = num13 * num14;
									break;
								case 373:
									base.升天四式_满月狂风 = num13 * num14;
									break;
								case 374:
									base.升天四式_烈日炎炎 = num13 * num14;
									break;
								case 380:
									if (Player_Job != 1 && Player_Job != 4 && Player_Job != 8 && Player_Job != 10)
									{
										FLD_人物_气功_攻击 += (int)((double)FLD_最小攻击 * num13 * num14 * 0.01 / 2.0);
									}
									break;
								case 381:
									if (Player_Job != 2 && Player_Job != 9)
									{
										double num15 = (double)FLD_最大攻击 * num13 * num14 / 100.0 / 5.0;
										if (num15 < 1.0)
										{
											num15 = 1.0;
										}
										FLD_人物_气功_攻击 += (int)(num15 + 0.5);
									}
									break;
								case 382:
									if (Player_Job != 3 && Player_Job != 7)
									{
										FLD_人物_气功_防御 += (int)(num13 * num14);
									}
									break;
								case 383:
									if (Player_Job != 5)
									{
										base.升天一气功_运气行心 = num13 * num14;
									}
									break;
								case 384:
									if (Player_Job != 4 && Player_Job != 7)
									{
										人物_气功_追加_HP += (int)(num13 * num14);
									}
									break;
								case 385:
									if (Player_Job != 3 && Player_Job != 10)
									{
										base.升天一气功_运气疗伤 = 10.0 + num13 * num14;
									}
									break;
								case 386:
									if (Player_Job != 2 && Player_Job != 6 && Player_Job != 8 && Player_Job != 9)
									{
										FLD_人物_追加百分比_回避 += 0.1 + num13 * num14;
									}
									break;
								case 387:
									if (Player_Job == 5)
									{
										base.升天一气功_狂风天意 = num13 * num14;
									}
									break;
								case 390:
									base.琴师_升天一气功_飞花点翠 = num13 * num14;
									break;
								case 391:
									base.琴师_升天二气功_三潭映月 = num13 * num14;
									break;
								case 392:
									base.琴师_升天三气功_子夜秋歌 = num13 * num14;
									break;
								case 393:
									base.升天四式_红月狂风 = num13 * num14;
									break;
								case 394:
									base.升天四式_悬丝诊脉 = num13 * num14;
									break;
								case 310:
									base.刀_升天一气功_遁出逆境 = num13 * num14;
									break;
								case 311:
									base.刀_升天二气功_穷途末路 = num13 * num14;
									break;
								case 313:
									base.升天四式_红月狂风 = num13 * num14;
									break;
								case 314:
									base.升天四式_毒蛇出洞 = num13 * num14;
									break;
								case 315:
									base.梅_升天三气功_杀人鬼 = num13 * num14;
									break;
								case 316:
									base.梅_升天一气功_玄武雷电 = num13 * num14;
									break;
								case 321:
									if (Player_Job == 2)
									{
										base.剑_升天二气功_天地同寿 = num13 * num14;
									}
									else if (Player_Job == 9)
									{
										base.谭_升天二气功_天地同寿 = num13 * num14;
									}
									break;
								case 322:
									if (Player_Job == 2)
									{
										base.剑_升天三气功_火凤临朝 = num13 * num14;
									}
									else if (Player_Job == 9)
									{
										base.谭_升天三气功_火凤临朝 = num13 * num14;
									}
									break;
								case 323:
									base.升天四式_红月狂风 = num13 * num14;
									break;
								case 324:
									base.升天四式_毒蛇出洞 = num13 * num14;
									break;
								case 325:
									base.梅_升天二气功_玄武诅咒 = num13 * num14;
									break;
								case 326:
									base.升天四式_烈日炎炎 = num13 * num14;
									break;
								case 327:
									base.升天四式_满月狂风 = num13 * num14;
									break;
								case 330:
									base.枪_升天一气功_破甲刺魂 = num13 * num14;
									break;
								case 331:
									base.枪_升天二气功_以退为进 = num13 * num14;
									break;
								case 333:
									base.升天四式_红月狂风 = num13 * num14;
									break;
								case 334:
									base.升天四式_毒蛇出洞 = num13 * num14;
									break;
								case 340:
									base.弓_升天一气功_绝影射魂 = num13 * num14;
									break;
								case 341:
									FLD_人物_气功_负重 += (int)((double)人物负重总 * num13 * 0.003);
									FLD_人物_气功_防御 += (int)(num13 * num14);
									break;
								case 342:
									base.弓_升天三气功_天外三矢 = num13 * num14;
									break;
								case 343:
									base.升天四式_满月狂风 = num13 * num14;
									break;
								case 344:
									base.升天四式_烈日炎炎 = num13 * num14;
									break;
								case 352:
									base.医_升天三气功_明镜止水 = num13 * num14;
									break;
								case 353:
									base.升天四式_满月狂风 = num13 * num14;
									break;
								case 354:
									base.升天四式_望梅添花 = num13 * num14;
									break;
								case 170:
									base.刺_升天三气功_无情打击 = 0.1 + num13 * num14;
									break;
								case 662:
									base.陵劲淬砺 = num13 * num14;
									break;
								case 663:
									base.卢_破血狂风 = 10.0 + num13 * num14;
									break;
								case 664:
									base.技冠群雄 = 10.0 + num13 * num14;
									break;
								case 665:
									base.升天四式_毒蛇出洞 = num13 * num14;
									break;
								case 666:
									base.升天四式_红月狂风 = num13 * num14;
									break;
								case 679:
									base.升天五式_龙魂附体 = num13 * num14;
									break;
								case 680:
									base.升天五式_惊天动地 = num13 * num14;
									break;
								case 681:
									base.升天五式_灭世狂舞 = num13 * num14;
									break;
								case 682:
									base.升天五式_千里一击 = num13 * num14;
									break;
								case 683:
									base.升天五式_形移妖相 = num13 * num14;
									break;
								case 684:
									base.升天五式_一招杀神 = num13 * num14;
									break;
								case 685:
									base.升天五式_龙爪纤指手 = num13 * num14;
									break;
								case 686:
									base.升天五式_天魔之力 = num13 * num14;
									break;
								case 687:
									base.升天五式_惊涛骇浪 = num13 * num14;
									break;
								case 688:
									base.升天五式_不死之躯 = num13 * num14;
									break;
								case 689:
									base.升天五式_魔魂之力 = num13 * num14;
									break;
								case 690:
									base.升天五式_破空坠星 = 1.0 + num13 * num14;
									break;
								case 700:
									base.谭_升天三气功_以柔克刚 = num13 * num14;
									break;
								case 701:
									base.升天四式_长虹贯天 = num13 * num14;
									break;
								case 702:
									base.升天四式_哀鸿遍野 = num13 * num14;
									break;
								case 600:
									base.韩_升天一气功_行风弄舞 = num13 * num14;
									break;
								case 601:
									base.韩_升天二气功_天魔护体 = num13 * num14;
									break;
								case 602:
									base.韩_升天二气功_内息行心 = num13 * num14;
									break;
								case 603:
									base.升天四式_长虹贯天 = num13 * num14;
									break;
								case 604:
									base.升天四式_哀鸿遍野 = num13 * num14;
									break;
								case 610:
									base.神女愤怒调节 = num13 * num14;
									break;
								case 611:
									base.神女蛊毒解除 = num13 * num14;
									break;
								case 612:
									base.神女神力保护 = num13 * num14;
									break;
								case 613:
									base.升天四式_满月狂风 = num13 * num14;
									break;
								case 614:
									base.升天四式_望梅添花 = num13 * num14;
									break;
								case 615:
								case 667:
								case 668:
								case 669:
								case 670:
								case 671:
								case 672:
								case 673:
								case 674:
								case 675:
								case 676:
								case 677:
								case 678:
									base.升天五式_致残 = 3.0 + num13 * num14;
									break;
								case 616:
									base.神女尸毒爆发 = num13 * num14;
									break;
								case 561:
									base.拳_升天一气功_夺命连环 = num13 * num14;
									break;
								case 562:
									base.拳_升天二气功_电光石火 = 10.0 + num13 * num14;
									break;
								case 563:
									base.拳_升天三气功_精益求精 = num13 * num14;
									break;
								case 564:
									base.升天四式_红月狂风 = num13 * num14;
									break;
								case 565:
									base.升天四式_毒蛇出洞 = num13 * num14;
									break;
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					Form1.WriteLine(1, "计算升天气功出错" + ex.ToString());
				}
			}
		}

		public int 得到气功ID(int int_109, int int_110)
		{
			int result = 0;
			foreach (气功加成属性 value in World.气功加成.Values)
			{
				if (value.FLD_JOB == int_110 && value.FLD_INDEX == int_109)
				{
					result = value.FLD_PID;
				}
			}
			return result;
		}

		public void 读出人物数据()
		{
			int num = 0;
			try
			{
				Clear();
				DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("select  *  from  [TBL_XWWL_Char]  where  FLD_ID=@Userid  and  FLD_NAME  =@Username"), new SqlParameter[2]
				{
					SqlDBA.MakeInParam("@Userid", SqlDbType.VarChar, 30, Userid),
					SqlDBA.MakeInParam("@Username", SqlDbType.VarChar, 30, UserName)
				});
				if (dBToDataTable.Rows.Count == 0 && Client != null)
				{
					Client.Dispose();
				}
				num = 2;
				GM模式 = (int)dBToDataTable.Rows[0]["FLD_J9"];
				num = 3;
				人物位置 = (int)dBToDataTable.Rows[0]["FLD_INDEX"];
				num = 4;
				int_16 = (int)dBToDataTable.Rows[0]["FLD_FIGHT_EXP"];
				num = 5;
				long_0 = long.Parse(dBToDataTable.Rows[0]["FLD_EXP"].ToString());
				try
				{
					long_2 = long.Parse(dBToDataTable.Rows[0]["FLD_MONEY"].ToString());
					int_108 = (int)dBToDataTable.Rows[0]["FLD_WHTB"];
				}
				catch
				{
					long_2 = 0L;
					int_108 = 0;
				}
				num = 6;
				int_40 = (int)dBToDataTable.Rows[0]["FLD_POINT"];
				num = 7;
				int_41 = (int)dBToDataTable.Rows[0]["FLD_ZX"];
				num = 8;
				int_42 = (int)dBToDataTable.Rows[0]["FLD_LEVEL"];
				num = 9;
				int_46 = (int)dBToDataTable.Rows[0]["FLD_JOB"];
				num = 10;
				int_47 = (int)dBToDataTable.Rows[0]["FLD_JOB_LEVEL"];
				num = 11;
				New人物模版 = new 人物模板类((byte[])dBToDataTable.Rows[0]["FLD_FACE"]);
				num = 12;
				_人物名字模版 = (byte[])dBToDataTable.Rows[0]["FLD_NAMETYPE"];
				num = 13;
				int_48 = New人物模版.性别;
				num = 14;
				int_20 = (int)dBToDataTable.Rows[0]["FLD_HP"];
				num = 15;
				int_32 = (int)dBToDataTable.Rows[0]["FLD_MP"];
				num = 16;
				int_38 = (int)dBToDataTable.Rows[0]["FLD_SP"];
				num = 17;
				FLD_PVP_Piont = (int)dBToDataTable.Rows[0]["FLD_PVP_Piont"];
				num = 18;
				FLD_制作类型 = (int)dBToDataTable.Rows[0]["FLD_ZzType"];
				num = 19;
				FLD_制作熟练度 = (int)dBToDataTable.Rows[0]["FLD_ZzSl"];
				num = 20;
				float_0 = float.Parse(dBToDataTable.Rows[0]["FLD_X"].ToString());
				num = 21;
				float_1 = float.Parse(dBToDataTable.Rows[0]["FLD_Y"].ToString());
				num = 22;
				float_2 = float.Parse(dBToDataTable.Rows[0]["FLD_Z"].ToString());
				num = 23;
				装备数据版本 = (int)dBToDataTable.Rows[0]["FLD_ZBVER"];
				num = 24;
				int_49 = (int)dBToDataTable.Rows[0]["FLD_MENOW"];
				if ((int_48 < 1 || int_48 > 2) && Client != null)
				{
					Client.Dispose();
				}
				新坐标 = new 坐标Class(人物坐标_X, 人物坐标_Y, 人物坐标_Z, 人物坐标_地图);
				num = 25;
				Player_WuXun = (int)dBToDataTable.Rows[0]["FLD_WX"];
				num = 26;
				人物善恶 = (int)dBToDataTable.Rows[0]["FLD_SE"];
				num = 27;
				人物轻功 = (int)dBToDataTable.Rows[0]["FLD_JQ"];
				num = 28;
				FLD_情侣 = dBToDataTable.Rows[0]["FLD_QlNAME"].ToString();
				num = 29;
				FLD_情侣戒指 = dBToDataTable.Rows[0]["FLD_QlJZNAME"].ToString();
				num = 30;
				FLD_情侣_爱情度 = (int)dBToDataTable.Rows[0]["FLD_QlDu"];
				num = 31;
				婚戒刻字 = dBToDataTable.Rows[0]["FLD_LOVE_WORD"].ToString();
				num = 32;
				解除关系倒计时 = (int)dBToDataTable.Rows[0]["FLD_MARITAL_STATUS"];
				num = 33;
				是否已婚 = (int)dBToDataTable.Rows[0]["FLD_MARRIED"];
				num = 34;
				升天武功点数 = (int)dBToDataTable.Rows[0]["FLD_升天武功点"];
				num = 35;
				升天历练数 = (int)dBToDataTable.Rows[0]["FLD_升天历练"];
				称号积分 = (int)dBToDataTable.Rows[0]["FLD_称号积分"];
				num = 36;
				dateTime_2 = (DateTime)dBToDataTable.Rows[0]["FLD_JH_DATE"];
				num = 37;
				修炼地图剩余时间 = (int)dBToDataTable.Rows[0]["FLD_FB_TIME"];
				num = 38;
				活动地图剩余时间 = (int)dBToDataTable.Rows[0]["FLD_HD_TIME"];
				num = 39;
				丢失武勋 = (int)dBToDataTable.Rows[0]["FLD_LOST_WX"];
				num = 40;
				每日获得武勋 = (int)dBToDataTable.Rows[0]["FLD_GET_WX"];
				num = 41;
				_人物分区ID = dBToDataTable.Rows[0]["FLD_FQID"].ToString();
				num = 42;
				玫瑰称号积分 = (int)dBToDataTable.Rows[0]["FLD_玫瑰称号积分"];
				num = 43;
				_门派贡献度 = (int)dBToDataTable.Rows[0]["门派贡献度"];
				num = 44;
				客户端设置 = dBToDataTable.Rows[0]["FLD_CONFIG"].ToString();
				num = 45;
				神女武功点数 = (int)dBToDataTable.Rows[0]["FLD_神女武功点"];
				if (人物分区ID != World.分区编号)
				{
					_人物分区ID = World.分区编号;
					DBA.ExeSqlCommand(string.Format("UPDATE    [TBL_XWWL_Char]  SET  FLD_FQID='{0}'  WHERE  FLD_ID='{1}'", World.分区编号, Userid), "GameServer");
				}
				if (Player_ExpErience < 0)
				{
					Player_ExpErience = 0;
				}
				if (Player_Qigong_point < 0)
				{
					Player_Qigong_point = 0;
				}
				num = 1;
				师傅数据.TID = -1;
				for (int i = 0; i < 3; i++)
				{
					徒弟数据[i] = new 师徒类();
					徒弟数据[i].TID = -1;
				}
				DataTable dataTable = RxjhClass.得到师傅数据(UserName);
				if (dataTable != null)
				{
					师傅数据.TID = (int)dataTable.Rows[0]["FLD_INDEX"];
					师傅数据.STNAME = dataTable.Rows[0]["FLD_SNAME"].ToString();
					师傅数据.TLEVEL = (int)dataTable.Rows[0]["FLD_TLEVEL"];
					师傅数据.STLEVEL = (int)dataTable.Rows[0]["FLD_STLEVEL"];
					师傅数据.STYHD = (int)dataTable.Rows[0]["FLD_STYHD"];
					师傅数据.STWG1 = (int)dataTable.Rows[0]["FLD_STWG1"];
					师傅数据.STWG2 = (int)dataTable.Rows[0]["FLD_STWG2"];
					师傅数据.STWG3 = (int)dataTable.Rows[0]["FLD_STWG3"];
					dataTable.Dispose();
				}
				else
				{
					DataTable dataTable2 = RxjhClass.得到徒弟数据(UserName);
					if (dataTable2 != null)
					{
						for (int j = 0; j < dataTable2.Rows.Count; j++)
						{
							int num2 = (int)dataTable2.Rows[j]["FLD_INDEX"];
							if (num2 <= 2)
							{
								徒弟数据[num2].TID = (int)dataTable2.Rows[j]["FLD_INDEX"];
								徒弟数据[num2].STNAME = dataTable2.Rows[j]["FLD_TNAME"].ToString();
								徒弟数据[num2].TLEVEL = (int)dataTable2.Rows[j]["FLD_TLEVEL"];
								徒弟数据[num2].STLEVEL = (int)dataTable2.Rows[j]["FLD_STLEVEL"];
								徒弟数据[num2].STYHD = (int)dataTable2.Rows[j]["FLD_STYHD"];
								徒弟数据[num2].STWG1 = (int)dataTable2.Rows[j]["FLD_STWG1"];
								徒弟数据[num2].STWG2 = (int)dataTable2.Rows[j]["FLD_STWG2"];
								徒弟数据[num2].STWG3 = (int)dataTable2.Rows[j]["FLD_STWG3"];
							}
						}
						dataTable2.Dispose();
					}
				}
				int num3 = 0;
				if (dBToDataTable.Rows[0]["FLD_升天气功"] != DBNull.Value)
				{
					byte[] array = (byte[])dBToDataTable.Rows[0]["FLD_升天气功"];
					if (Player_Job_leve >= 6)
					{
						for (int k = 0; k < 15; k++)
						{
							byte[] array2 = new byte[4];
							try
							{
								if (array.Length >= k * 4 + 4)
								{
									System.Buffer.BlockCopy(array, k * 4, array2, 0, 4);
									升天气功类 升天气功类 = new 升天气功类(array2);
									升天气功总类 value;
									if (World.升天气功List.TryGetValue(升天气功类.气功ID, out value))
									{
										switch (Player_Job)
										{
										case 1:
											if (value.人物职业1 == 1 && !GetSTQG(升天气功类.气功ID))
											{
												升天气功.Add(升天气功类.气功ID, 升天气功类);
												num3 += 升天气功类.气功量;
											}
											break;
										case 2:
											if (value.人物职业2 == 1 && !GetSTQG(升天气功类.气功ID))
											{
												升天气功.Add(升天气功类.气功ID, 升天气功类);
												num3 += 升天气功类.气功量;
											}
											break;
										case 3:
											if (value.人物职业3 == 1 && !GetSTQG(升天气功类.气功ID))
											{
												升天气功.Add(升天气功类.气功ID, 升天气功类);
												num3 += 升天气功类.气功量;
											}
											break;
										case 4:
											if (value.人物职业4 == 1 && !GetSTQG(升天气功类.气功ID))
											{
												升天气功.Add(升天气功类.气功ID, 升天气功类);
												num3 += 升天气功类.气功量;
											}
											break;
										case 5:
											if (value.人物职业5 == 1 && !GetSTQG(升天气功类.气功ID))
											{
												升天气功.Add(升天气功类.气功ID, 升天气功类);
												num3 += 升天气功类.气功量;
											}
											break;
										case 6:
											if (value.人物职业6 == 1 && !GetSTQG(升天气功类.气功ID))
											{
												升天气功.Add(升天气功类.气功ID, 升天气功类);
												num3 += 升天气功类.气功量;
											}
											break;
										case 7:
											if (value.人物职业7 == 1 && !GetSTQG(升天气功类.气功ID))
											{
												升天气功.Add(升天气功类.气功ID, 升天气功类);
												num3 += 升天气功类.气功量;
											}
											break;
										case 8:
											if (value.人物职业8 == 1 && !GetSTQG(升天气功类.气功ID))
											{
												升天气功.Add(升天气功类.气功ID, 升天气功类);
												num3 += 升天气功类.气功量;
											}
											break;
										case 9:
											if (value.人物职业9 == 1 && !GetSTQG(升天气功类.气功ID))
											{
												升天气功.Add(升天气功类.气功ID, 升天气功类);
												num3 += 升天气功类.气功量;
											}
											break;
										case 10:
											if (value.人物职业10 == 1 && !GetSTQG(升天气功类.气功ID))
											{
												升天气功.Add(升天气功类.气功ID, 升天气功类);
												num3 += 升天气功类.气功量;
											}
											break;
										case 11:
											if (value.人物职业11 == 1 && !GetSTQG(升天气功类.气功ID))
											{
												升天气功.Add(升天气功类.气功ID, 升天气功类);
												num3 += 升天气功类.气功量;
											}
											break;
										case 12:
											if (value.人物职业12 == 1 && !GetSTQG(升天气功类.气功ID))
											{
												升天气功.Add(升天气功类.气功ID, 升天气功类);
												num3 += 升天气功类.气功量;
											}
											break;
										case 13:
											if (value.人物职业13 == 1 && !GetSTQG(升天气功类.气功ID))
											{
												升天气功.Add(升天气功类.气功ID, 升天气功类);
												num3 += 升天气功类.气功量;
											}
											break;
										}
									}
									continue;
								}
							}
							catch
							{
								continue;
							}
							break;
						}
					}
				}
				num = 5;
				byte[] array3 = new byte[20];
				byte[] array4 = (byte[])dBToDataTable.Rows[0]["FLD_SKILLS"];
				System.Buffer.BlockCopy(array4, 0, array3, 0, array4.Length);
				for (int l = 0; l < 15; l++)
				{
					byte[] array5 = new byte[2];
					try
					{
						if (array3.Length > l + 1)
						{
							System.Buffer.BlockCopy(array3, l, array5, 0, 1);
						}
					}
					catch
					{
					}
					气功[l] = new 气功类(array5);
					switch (l)
					{
					default:
						if (l < 12)
						{
							气功[l].气功ID = 得到气功ID(l, Player_Job);
						}
						break;
					case 0:
						if (Player_Level >= 1)
						{
							气功[l].气功ID = 得到气功ID(l, Player_Job);
							if (气功[l].气功量 == 255)
							{
								气功[l].气功量 = 0;
							}
						}
						break;
					case 1:
						if (Player_Level >= 1)
						{
							气功[l].气功ID = 得到气功ID(l, Player_Job);
							if (气功[l].气功量 == 255)
							{
								气功[l].气功量 = 0;
							}
						}
						break;
					case 2:
						if (Player_Level >= 1)
						{
							气功[l].气功ID = 得到气功ID(l, Player_Job);
							if (气功[l].气功量 == 255)
							{
								气功[l].气功量 = 0;
							}
						}
						break;
					case 3:
						if (Player_Level >= 1)
						{
							气功[l].气功ID = 得到气功ID(l, Player_Job);
							if (气功[l].气功量 == 255)
							{
								气功[l].气功量 = 0;
							}
						}
						break;
					case 4:
						if (Player_Level >= 1)
						{
							气功[l].气功ID = 得到气功ID(l, Player_Job);
							if (气功[l].气功量 == 255)
							{
								气功[l].气功量 = 0;
							}
						}
						break;
					case 5:
						if (Player_Level >= 10 && Player_Job_leve >= 1)
						{
							气功[l].气功ID = 得到气功ID(l, Player_Job);
							if (气功[l].气功量 == 255)
							{
								气功[l].气功量 = 0;
							}
						}
						break;
					case 6:
						if (Player_Level >= 10 && Player_Job_leve >= 1)
						{
							气功[l].气功ID = 得到气功ID(l, Player_Job);
							if (气功[l].气功量 == 255)
							{
								气功[l].气功量 = 0;
							}
						}
						break;
					case 7:
						if (Player_Level >= 35 && Player_Job_leve >= 2)
						{
							气功[l].气功ID = 得到气功ID(l, Player_Job);
							if (气功[l].气功量 == 255)
							{
								气功[l].气功量 = 0;
							}
						}
						break;
					case 8:
						if (Player_Level >= 60 && Player_Job_leve >= 3)
						{
							气功[l].气功ID = 得到气功ID(l, Player_Job);
							if (气功[l].气功量 == 255)
							{
								气功[l].气功量 = 0;
							}
						}
						break;
					case 9:
						if (Player_Level >= 80 && Player_Job_leve >= 4)
						{
							气功[l].气功ID = 得到气功ID(l, Player_Job);
							if (气功[l].气功量 == 255)
							{
								气功[l].气功量 = 0;
							}
						}
						break;
					case 10:
						if (Player_Level >= 90 && Player_Job_leve >= 4)
						{
							气功[l].气功ID = 得到气功ID(l, Player_Job);
							if (气功[l].气功量 == 255)
							{
								气功[l].气功量 = 0;
							}
						}
						break;
					case 11:
						if (Player_Level >= 100 && Player_Job_leve >= 5)
						{
							气功[l].气功ID = 得到气功ID(l, Player_Job);
							if (气功[l].气功量 == 255)
							{
								气功[l].气功量 = 0;
							}
						}
						break;
					}
				}
				int num4 = 0;
				for (int m = 0; m < 12; m++)
				{
					byte[] 气功_byte = 气功[m].气功_byte;
					int num5 = BitConverter.ToInt16(气功_byte, 0);
					if (气功_byte[0] != byte.MaxValue)
					{
						num4 += num5;
					}
				}
				int num6 = (Player_Level <= 34) ? (Player_Level - 1) : (34 + (Player_Level - 35) * 2);
				if (num4 + Player_Qigong_point + num3 != num6)
				{
					if (num4 + num3 > num6 - Player_Qigong_point)
					{
						Player_Qigong_point = num6;
						for (int n = 0; n < 12; n++)
						{
							if (BitConverter.ToInt16(气功[n].气功_byte, 0) != 255)
							{
								气功[n].气功_byte = new byte[2];
							}
						}
						foreach (升天气功类 value8 in 升天气功.Values)
						{
							value8.气功量 = 0;
						}
					}
					else
					{
						Player_Qigong_point = num6 - num4 - num3;
					}
				}
				num = 6;
				byte[] array6 = (byte[])dBToDataTable.Rows[0]["FLD_KONGFU"];
				for (int num7 = 0; num7 < 78; num7++)
				{
					byte[] array7 = new byte[4];
					byte[] array8 = new byte[4];
					try
					{
						if (array6.Length >= num7 * 8 + 8)
						{
							System.Buffer.BlockCopy(array6, num7 * 8, array7, 0, 4);
							System.Buffer.BlockCopy(array6, num7 * 8 + 4, array8, 0, 4);
							int num8 = BitConverter.ToInt32(array7, 0);
							if (num8 != 0)
							{
								int num9 = BitConverter.ToInt32(array8, 0);
								if (num8 == 1000701)
								{
									num8 = ((Player_Zx != 1) ? 1020701 : 1010701);
								}
								if (num8 != 0)
								{
									武功类 武功类 = new 武功类(num8);
									if ((武功类.FLD_JOB == 0 || Player_Job == 武功类.FLD_JOB) && (武功类.FLD_ZX == 0 || Player_Zx == 武功类.FLD_ZX) && Player_Job_leve >= 武功类.FLD_JOBLEVEL && Player_Level >= 武功类.FLD_LEVEL)
									{
										武功类.武功_等级 = ((num9 < 武功类.FLD_武功最高级别) ? num9 : 武功类.FLD_武功最高级别);
										武功新[武功类.FLD_武功类型, 武功类.FLD_INDEX] = 武功类;
									}
								}
							}
							continue;
						}
					}
					catch
					{
						continue;
					}
					break;
				}
				if (Player_Job_leve >= 5 && ((Player_Job != 8) & (Player_Job != 13)))
				{
					if (武功新[0, 25] == null)
					{
						Client.Player.学习技能(0, 25);
					}
					if (武功新[0, 26] == null)
					{
						Client.Player.学习技能(0, 26);
					}
					if (武功新[0, 27] == null)
					{
						Client.Player.学习技能(0, 27);
					}
				}
				if (武功新[1, 2] != null)
				{
					人物轻功 = 2;
				}
				else if (武功新[1, 1] != null)
				{
					人物轻功 = 1;
				}
				if (dBToDataTable.Rows[0]["FLD_升天武功"] != DBNull.Value)
				{
					byte[] array9 = (byte[])dBToDataTable.Rows[0]["FLD_升天武功"];
					for (int num10 = 0; num10 < 32 && array9.Length >= num10 * 8 + 8; num10++)
					{
						int fLD_PID_ = BitConverter.ToInt32(array9, num10 * 8);
						int num11 = BitConverter.ToInt32(array9, num10 * 8 + 4);
						武功类 武功类2 = new 武功类(fLD_PID_);
						武功类2.武功_等级 = ((num11 < 武功类2.FLD_武功最高级别) ? num11 : 武功类2.FLD_武功最高级别);
						if ((武功类2.FLD_JOB == 0 || Player_Job == 武功类2.FLD_JOB) && (武功类2.FLD_ZX == 0 || Player_Zx == 武功类2.FLD_ZX) && Player_Job_leve >= 武功类2.FLD_JOBLEVEL && Player_Level >= 武功类2.FLD_LEVEL)
						{
							武功新[武功类2.FLD_武功类型, 武功类2.FLD_INDEX] = 武功类2;
						}
					}
				}
				if (Player_Job_leve >= 6 && Player_Job == 8)
				{
					if (武功新[3, 9] == null)
					{
						Client.Player.学习技能(3, 9);
					}
					if (武功新[3, 10] == null)
					{
						Client.Player.学习技能(3, 10);
					}
					if (武功新[3, 11] == null)
					{
						Client.Player.学习技能(3, 11);
					}
				}
				num = 7;
				byte[] array10 = (byte[])dBToDataTable.Rows[0]["FLD_QITEM"];
				for (int num12 = 0; num12 < 36; num12++)
				{
					byte[] array11 = new byte[8];
					if (array10.Length >= num12 * 8 + 8)
					{
						try
						{
							System.Buffer.BlockCopy(array10, num12 * 8, array11, 0, 8);
						}
						catch (Exception ex)
						{
							Console.WriteLine(num12 + "  " + ((ex != null) ? ex.ToString() : null));
						}
					}
					任务物品[num12] = new 任务物品类(array11);
				}
				num = 8;
				byte[] array12 = (byte[])dBToDataTable.Rows[0]["FLD_ITEM"];
				for (int num13 = 0; num13 < 66; num13++)
				{
					byte[] array13 = new byte[World.数据库单个物品大小];
					if (array12.Length >= num13 * World.数据库单个物品大小 + World.数据库单个物品大小)
					{
						try
						{
							System.Buffer.BlockCopy(array12, num13 * World.数据库单个物品大小, array13, 0, World.数据库单个物品大小);
						}
						catch (Exception ex2)
						{
							Form1.WriteLine(num13, "  " + ((ex2 != null) ? ex2.ToString() : null));
						}
					}
					装备栏包裹[num13] = new 物品类(array13, num13);
					if (装备栏包裹[num13].Get物品ID == 1008001507L)
					{
						是否携带披风行囊 = true;
					}
					if (num13 < 36)
					{
						int_50 += 装备栏包裹[num13].物品总重量;
					}
					byte[] array14 = new byte[4];
					System.Buffer.BlockCopy(装备栏包裹[num13].物品_byte, World.物品属性大小, array14, 0, 4);
					int num14 = BitConverter.ToInt32(array14, 0);
					if (num14 > 0 && DateTime.Now.Subtract(new DateTime(1970, 1, 1, 8, 0, 0).AddSeconds(num14)).TotalSeconds >= 0.0)
					{
						系统提示("背包有物品过期[" + 装备栏包裹[num13].得到物品名称() + "],系统已删除！", 9, "系统提示");
						装备栏包裹[num13].物品_byte = new byte[World.数据库单个物品大小];
					}
					if (World.AllItmelog == 1)
					{
						try
						{
							if (装备栏包裹[num13].得到物品位置类型() != 1 && 装备栏包裹[num13].得到物品位置类型() != 2 && 装备栏包裹[num13].得到物品位置类型() != 5 && 装备栏包裹[num13].得到物品位置类型() != 6)
							{
								if (装备栏包裹[num13].得到物品位置类型() != 4 && 装备栏包裹[num13].得到物品位置类型() == 12 && (装备栏包裹[num13].属性1.属性类型 == 7 || 装备栏包裹[num13].属性2.属性类型 == 7 || 装备栏包裹[num13].属性3.属性类型 == 7 || 装备栏包裹[num13].属性4.属性类型 == 7))
								{
									Form1.WriteLine(6, "发现WG防物品  装备栏包裹  [" + Userid + "]-[" + UserName + "]  位置[" + num13 + "]  编号[" + BitConverter.ToInt32(装备栏包裹[num13].物品全局ID, 0) + "]  物品名称[" + 装备栏包裹[num13].得到物品名称() + "]  物品数量[" + BitConverter.ToInt32(装备栏包裹[num13].物品数量, 0) + "]  属性:[" + 装备栏包裹[num13].FLD_MAGIC0 + "," + 装备栏包裹[num13].FLD_MAGIC1 + "," + 装备栏包裹[num13].FLD_MAGIC2 + "," + 装备栏包裹[num13].FLD_MAGIC3 + "," + 装备栏包裹[num13].FLD_MAGIC4 + "]");
									装备栏包裹[num13].物品_byte = new byte[World.数据库单个物品大小];
								}
							}
							else if (装备栏包裹[num13].属性1.属性类型 == 7 || 装备栏包裹[num13].属性2.属性类型 == 7 || 装备栏包裹[num13].属性3.属性类型 == 7 || 装备栏包裹[num13].属性4.属性类型 == 7)
							{
								Form1.WriteLine(6, "发现WG防物品  装备栏包裹  [" + Userid + "]-[" + UserName + "]  位置[" + num13 + "]  编号[" + BitConverter.ToInt32(装备栏包裹[num13].物品全局ID, 0) + "]  物品名称[" + 装备栏包裹[num13].得到物品名称() + "]  物品数量[" + BitConverter.ToInt32(装备栏包裹[num13].物品数量, 0) + "]  属性:[" + 装备栏包裹[num13].FLD_MAGIC0 + "," + 装备栏包裹[num13].FLD_MAGIC1 + "," + 装备栏包裹[num13].FLD_MAGIC2 + "," + 装备栏包裹[num13].FLD_MAGIC3 + "," + 装备栏包裹[num13].FLD_MAGIC4 + "]");
								装备栏包裹[num13].物品_byte = new byte[World.数据库单个物品大小];
							}
						}
						catch (Exception ex3)
						{
							string[] array15 = new string[24]
							{
								"查物品错误        装备栏包裹  错误[",
								Userid,
								"]-[",
								UserName,
								"]  位置[",
								num13.ToString(),
								"]  编号[",
								BitConverter.ToInt32(装备栏包裹[num13].物品全局ID, 0).ToString(),
								"]  物品名称[",
								装备栏包裹[num13].得到物品名称(),
								"]  物品数量[",
								BitConverter.ToInt32(装备栏包裹[num13].物品数量, 0).ToString(),
								"]  属性:[",
								装备栏包裹[num13].FLD_MAGIC0.ToString(),
								",",
								null,
								null,
								null,
								null,
								null,
								null,
								null,
								null,
								null
							};
							array15[15] = 装备栏包裹[num13].FLD_MAGIC1.ToString();
							array15[16] = ",";
							array15[17] = 装备栏包裹[num13].FLD_MAGIC2.ToString();
							array15[18] = ",";
							array15[19] = 装备栏包裹[num13].FLD_MAGIC3.ToString();
							array15[20] = ",";
							array15[21] = 装备栏包裹[num13].FLD_MAGIC4.ToString();
							array15[22] = "]";
							array15[23] = ((ex3 != null) ? ex3.ToString() : null);
							Form1.WriteLine(1, string.Concat(array15));
						}
					}
				}
				num = 9;
				byte[] array16 = (byte[])dBToDataTable.Rows[0]["FLD_FASHION_ITEM"];
				for (int num15 = 0; num15 < 66; num15++)
				{
					byte[] array17 = new byte[World.数据库单个物品大小];
					if (array16.Length >= num15 * World.数据库单个物品大小 + World.数据库单个物品大小)
					{
						try
						{
							System.Buffer.BlockCopy(array16, num15 * World.数据库单个物品大小, array17, 0, World.数据库单个物品大小);
						}
						catch (Exception ex4)
						{
							Form1.WriteLine(num15, "  " + ((ex4 != null) ? ex4.ToString() : null));
						}
					}
					披风行囊[num15] = new 物品类(array17, num15);
					byte[] array18 = new byte[4];
					System.Buffer.BlockCopy(披风行囊[num15].物品_byte, World.物品属性大小, array18, 0, 4);
					int num16 = BitConverter.ToInt32(array18, 0);
					if (num16 > 0 && DateTime.Now.Subtract(new DateTime(1970, 1, 1, 8, 0, 0).AddSeconds(num16)).TotalSeconds >= 0.0)
					{
						系统提示("披风行囊有物品过期[" + 披风行囊[num15].得到物品名称() + "],系统已删除！", 9, "系统提示");
						披风行囊[num15].物品_byte = new byte[World.数据库单个物品大小];
					}
				}
				num = 10;
				byte[] array19 = (byte[])dBToDataTable.Rows[0]["FLD_WEARITEM"];
				for (int num17 = 0; num17 < 31; num17++)
				{
					byte[] array20 = new byte[World.数据库单个物品大小];
					if (num17 >= 16)
					{
						if (array19.Length >= num17 * World.数据库单个物品大小 + World.数据库单个物品大小)
						{
							try
							{
								System.Buffer.BlockCopy(array19, num17 * World.数据库单个物品大小, array20, 0, World.数据库单个物品大小);
							}
							catch (Exception ex5)
							{
								Form1.WriteLine(num17, "  " + ((ex5 != null) ? ex5.ToString() : null));
							}
						}
						辅助装备栏装备[num17 - 16] = new 物品类(array20, num17 - 16);
						byte[] array21 = new byte[4];
						System.Buffer.BlockCopy(辅助装备栏装备[num17 - 16].物品_byte, World.物品属性大小, array21, 0, 4);
						int num18 = BitConverter.ToInt32(array21, 0);
						if (num18 > 0 && DateTime.Now.Subtract(new DateTime(1970, 1, 1, 8, 0, 0).AddSeconds(num18)).TotalSeconds >= 0.0)
						{
							系统提示("已穿装备栏有物品过期[" + 辅助装备栏装备[num17 - 16].得到物品名称() + "],系统已删除！", 9, "系统提示");
							辅助装备栏装备[num17 - 16].物品_byte = new byte[World.数据库单个物品大小];
						}
						if (World.AllItmelog == 1)
						{
							try
							{
								if (辅助装备栏装备[num17 - 16].得到物品位置类型() != 1 && 辅助装备栏装备[num17 - 16].得到物品位置类型() != 2 && 辅助装备栏装备[num17 - 16].得到物品位置类型() != 5 && 辅助装备栏装备[num17 - 16].得到物品位置类型() != 6)
								{
									if (辅助装备栏装备[num17 - 16].得到物品位置类型() != 4 && 辅助装备栏装备[num17 - 16].得到物品位置类型() == 12 && (辅助装备栏装备[num17 - 16].属性1.属性类型 == 7 || 辅助装备栏装备[num17 - 16].属性2.属性类型 == 7 || 辅助装备栏装备[num17 - 16].属性3.属性类型 == 7 || 辅助装备栏装备[num17 - 16].属性4.属性类型 == 7))
									{
										Form1.WriteLine(6, "发现WG防物品  辅助装备栏装备  [" + Userid + "]-[" + UserName + "]  位置[" + (num17 - 16) + "]  编号[" + BitConverter.ToInt32(辅助装备栏装备[num17 - 16].物品全局ID, 0) + "]  物品名称[" + 辅助装备栏装备[num17 - 16].得到物品名称() + "]  物品数量[" + BitConverter.ToInt32(辅助装备栏装备[num17 - 16].物品数量, 0) + "]  属性:[" + 辅助装备栏装备[num17 - 16].FLD_MAGIC0 + "," + 辅助装备栏装备[num17 - 16].FLD_MAGIC1 + "," + 辅助装备栏装备[num17 - 16].FLD_MAGIC2 + "," + 辅助装备栏装备[num17 - 16].FLD_MAGIC3 + "," + 辅助装备栏装备[num17 - 16].FLD_MAGIC4 + "]");
										辅助装备栏装备[num17 - 16].物品_byte = new byte[World.数据库单个物品大小];
									}
								}
								else if (辅助装备栏装备[num17 - 16].属性1.属性类型 == 7 || 辅助装备栏装备[num17 - 16].属性2.属性类型 == 7 || 辅助装备栏装备[num17 - 16].属性3.属性类型 == 7 || 辅助装备栏装备[num17 - 16].属性4.属性类型 == 7)
								{
									Form1.WriteLine(6, "发现WG防物品  辅助装备栏装备  [" + Userid + "]-[" + UserName + "]  位置[" + (num17 - 16) + "]  编号[" + BitConverter.ToInt32(辅助装备栏装备[num17 - 16].物品全局ID, 0) + "]  物品名称[" + 辅助装备栏装备[num17 - 16].得到物品名称() + "]  物品数量[" + BitConverter.ToInt32(辅助装备栏装备[num17 - 16].物品数量, 0) + "]  属性:[" + 辅助装备栏装备[num17 - 16].FLD_MAGIC0 + "," + 辅助装备栏装备[num17 - 16].FLD_MAGIC1 + "," + 辅助装备栏装备[num17 - 16].FLD_MAGIC2 + "," + 辅助装备栏装备[num17 - 16].FLD_MAGIC3 + "," + 辅助装备栏装备[num17 - 16].FLD_MAGIC4 + "]");
									辅助装备栏装备[num17 - 16].物品_byte = new byte[World.数据库单个物品大小];
								}
							}
							catch (Exception ex6)
							{
								string[] array22 = new string[24]
								{
									"查物品错误        装备栏包裹  错误  [",
									Userid,
									"]-[",
									UserName,
									"]  位置[",
									(num17 - 16).ToString(),
									"]  编号[",
									BitConverter.ToInt32(辅助装备栏装备[num17 - 16].物品全局ID, 0).ToString(),
									"]  物品名称[",
									辅助装备栏装备[num17 - 16].得到物品名称(),
									"]  物品数量[",
									BitConverter.ToInt32(辅助装备栏装备[num17 - 16].物品数量, 0).ToString(),
									"]  属性:[",
									null,
									null,
									null,
									null,
									null,
									null,
									null,
									null,
									null,
									null,
									null
								};
								array22[13] = 辅助装备栏装备[num17 - 16].FLD_MAGIC0.ToString();
								array22[14] = ",";
								array22[15] = 辅助装备栏装备[num17 - 16].FLD_MAGIC1.ToString();
								array22[16] = ",";
								array22[17] = 辅助装备栏装备[num17 - 16].FLD_MAGIC2.ToString();
								array22[18] = ",";
								array22[19] = 辅助装备栏装备[num17 - 16].FLD_MAGIC3.ToString();
								array22[20] = ",";
								array22[21] = 辅助装备栏装备[num17 - 16].FLD_MAGIC4.ToString();
								array22[22] = "]";
								array22[23] = ((ex6 != null) ? ex6.ToString() : null);
								Form1.WriteLine(1, string.Concat(array22));
							}
						}
					}
					else
					{
						if (array19.Length >= num17 * World.数据库单个物品大小 + World.数据库单个物品大小)
						{
							try
							{
								System.Buffer.BlockCopy(array19, num17 * World.数据库单个物品大小, array20, 0, World.数据库单个物品大小);
							}
							catch (Exception ex7)
							{
								Form1.WriteLine(num17, "  " + ((ex7 != null) ? ex7.ToString() : null));
							}
						}
						装备栏已穿装备[num17] = new 物品类(array20, num17);
						byte[] array23 = new byte[4];
						System.Buffer.BlockCopy(装备栏已穿装备[num17].物品_byte, World.物品属性大小, array23, 0, 4);
						int num19 = BitConverter.ToInt32(array23, 0);
						if (num19 > 0 && DateTime.Now.Subtract(new DateTime(1970, 1, 1, 8, 0, 0).AddSeconds(num19)).TotalSeconds >= 0.0)
						{
							系统提示("已穿装备栏有物品过期[" + 装备栏已穿装备[num17].得到物品名称() + "],系统已删除！", 9, "系统提示");
							装备栏已穿装备[num17].物品_byte = new byte[World.数据库单个物品大小];
						}
						if (World.AllItmelog == 1)
						{
							try
							{
								if (装备栏已穿装备[num17].得到物品位置类型() != 1 && 装备栏已穿装备[num17].得到物品位置类型() != 2 && 装备栏已穿装备[num17].得到物品位置类型() != 5 && 装备栏已穿装备[num17].得到物品位置类型() != 6)
								{
									if (装备栏已穿装备[num17].得到物品位置类型() != 4 && 装备栏已穿装备[num17].得到物品位置类型() == 12 && (装备栏已穿装备[num17].属性1.属性类型 == 7 || 装备栏已穿装备[num17].属性2.属性类型 == 7 || 装备栏已穿装备[num17].属性3.属性类型 == 7 || 装备栏已穿装备[num17].属性4.属性类型 == 7))
									{
										Form1.WriteLine(6, "发现WG防物品  装备栏已穿装备  [" + Userid + "]-[" + UserName + "]  位置[" + num17 + "]  编号[" + BitConverter.ToInt32(装备栏已穿装备[num17].物品全局ID, 0) + "]  物品名称[" + 装备栏已穿装备[num17].得到物品名称() + "]  物品数量[" + BitConverter.ToInt32(装备栏已穿装备[num17].物品数量, 0) + "]  属性:[" + 装备栏已穿装备[num17].FLD_MAGIC0 + "," + 装备栏已穿装备[num17].FLD_MAGIC1 + "," + 装备栏已穿装备[num17].FLD_MAGIC2 + "," + 装备栏已穿装备[num17].FLD_MAGIC3 + "," + 装备栏已穿装备[num17].FLD_MAGIC4 + "]");
										装备栏已穿装备[num17].物品_byte = new byte[World.数据库单个物品大小];
									}
								}
								else if (装备栏已穿装备[num17].属性1.属性类型 == 7 || 装备栏已穿装备[num17].属性2.属性类型 == 7 || 装备栏已穿装备[num17].属性3.属性类型 == 7 || 装备栏已穿装备[num17].属性4.属性类型 == 7)
								{
									Form1.WriteLine(6, "发现WG防物品  装备栏已穿装备  [" + Userid + "]-[" + UserName + "]  位置[" + num17 + "]  编号[" + BitConverter.ToInt32(装备栏已穿装备[num17].物品全局ID, 0) + "]  物品名称[" + 装备栏已穿装备[num17].得到物品名称() + "]  物品数量[" + BitConverter.ToInt32(装备栏已穿装备[num17].物品数量, 0) + "]  属性:[" + 装备栏已穿装备[num17].FLD_MAGIC0 + "," + 装备栏已穿装备[num17].FLD_MAGIC1 + "," + 装备栏已穿装备[num17].FLD_MAGIC2 + "," + 装备栏已穿装备[num17].FLD_MAGIC3 + "," + 装备栏已穿装备[num17].FLD_MAGIC4 + "]");
									装备栏已穿装备[num17].物品_byte = new byte[World.数据库单个物品大小];
								}
							}
							catch (Exception ex8)
							{
								string[] array24 = new string[24]
								{
									"查物品错误        装备栏包裹  错误  [",
									Userid,
									"]-[",
									UserName,
									"]  位置[",
									num17.ToString(),
									"]  编号[",
									BitConverter.ToInt32(装备栏已穿装备[num17].物品全局ID, 0).ToString(),
									"]  物品名称[",
									装备栏已穿装备[num17].得到物品名称(),
									"]  物品数量[",
									BitConverter.ToInt32(装备栏已穿装备[num17].物品数量, 0).ToString(),
									"]  属性:[",
									装备栏已穿装备[num17].FLD_MAGIC0.ToString(),
									",",
									null,
									null,
									null,
									null,
									null,
									null,
									null,
									null,
									null
								};
								array24[15] = 装备栏已穿装备[num17].FLD_MAGIC1.ToString();
								array24[16] = ",";
								array24[17] = 装备栏已穿装备[num17].FLD_MAGIC2.ToString();
								array24[18] = ",";
								array24[19] = 装备栏已穿装备[num17].FLD_MAGIC3.ToString();
								array24[20] = ",";
								array24[21] = 装备栏已穿装备[num17].FLD_MAGIC4.ToString();
								array24[22] = "]";
								array24[23] = ((ex8 != null) ? ex8.ToString() : null);
								Form1.WriteLine(1, string.Concat(array24));
							}
						}
					}
				}
				num = 11;
				byte[] array25 = (byte[])dBToDataTable.Rows[0]["FLD_QUEST"];
				for (int num20 = 0; num20 < 100; num20++)
				{
					byte[] array26 = new byte[4];
					try
					{
						if (array25.Length >= num20 * 4 + 4)
						{
							System.Buffer.BlockCopy(array25, num20 * 4, array26, 0, 4);
							任务类 任务类 = new 任务类(array26);
							if (任务类.任务ID != 0 && !任务.ContainsKey(任务类.任务ID))
							{
								任务.Add(任务类.任务ID, 任务类);
							}
							continue;
						}
					}
					catch (Exception value2)
					{
						Console.WriteLine(value2);
						continue;
					}
					break;
				}
				num = 12;
				byte[] array27 = (byte[])dBToDataTable.Rows[0]["FLD_QUEST_FINISH"];
				for (int num21 = 0; num21 < 500; num21++)
				{
					byte[] array28 = new byte[2];
					try
					{
						if (array27.Length >= num21 * 2 + 2)
						{
							System.Buffer.BlockCopy(array27, num21 * 2, array28, 0, 2);
							int num22 = BitConverter.ToInt16(array28, 0);
							if (num22 != 0 && !已完成任务.ContainsValue(num22))
							{
								已完成任务.Add(num22, num22);
							}
							continue;
						}
					}
					catch
					{
						continue;
					}
					break;
				}
				num = 13;
				传书列表.Clear();
				DataTable dataTable3 = RxjhClass.得到传书列表(UserName);
				if (dataTable3 != null)
				{
					for (int num23 = 0; num23 < dataTable3.Rows.Count; num23++)
					{
						个人传书类 个人传书类 = new 个人传书类();
						个人传书类.传书ID = (int)dataTable3.Rows[num23]["ID"];
						个人传书类.是否NPC = (int)dataTable3.Rows[num23]["发送NPC"];
						个人传书类.传书发送人 = dataTable3.Rows[num23]["发送人物名"].ToString();
						个人传书类.传书内容 = dataTable3.Rows[num23]["传书内容"].ToString();
						个人传书类.传书时间 = DateTime.Parse(dataTable3.Rows[num23]["传书时间"].ToString());
						个人传书类.是否已读 = (int)dataTable3.Rows[num23]["阅读标识"];
						传书列表.Add(个人传书类.传书ID, 个人传书类);
					}
					dataTable3.Dispose();
				}
				num = 14;
				DataTable userWarehouse = RxjhClass.GetUserWarehouse(Userid, UserName);
				if (userWarehouse == null && Client != null)
				{
					Client.Dispose();
				}
				if (userWarehouse.Rows[0] == null && Client != null)
				{
					Client.Dispose();
				}
				byte[] array29 = (byte[])userWarehouse.Rows[0]["FLD_ITEM"];
				try
				{
					个人仓库钱数 = long.Parse(userWarehouse.Rows[0]["FLD_MONEY"].ToString());
				}
				catch
				{
					个人仓库钱数 = 0L;
				}
				for (int num24 = 0; num24 < 60; num24++)
				{
					byte[] array30 = new byte[World.数据库单个物品大小];
					if (array29.Length >= num24 * World.数据库单个物品大小 + World.数据库单个物品大小)
					{
						try
						{
							System.Buffer.BlockCopy(array29, num24 * World.数据库单个物品大小, array30, 0, World.数据库单个物品大小);
						}
						catch (Exception value3)
						{
							Console.WriteLine(value3);
						}
					}
					个人仓库[num24] = new 物品类(array30, num24);
					if (个人仓库[num24].Get物品ID == 1008001507L)
					{
						是否携带披风行囊 = true;
					}
					byte[] array31 = new byte[4];
					System.Buffer.BlockCopy(个人仓库[num24].物品_byte, World.物品属性大小, array31, 0, 4);
					int num25 = BitConverter.ToInt32(array31, 0);
					if (num25 > 0 && DateTime.Now.Subtract(new DateTime(1970, 1, 1, 8, 0, 0).AddSeconds(num25)).TotalSeconds >= 0.0)
					{
						系统提示("个人仓库有物品过期[" + 个人仓库[num24].得到物品名称() + "],系统已删除！", 9, "系统提示");
						个人仓库[num24].物品_byte = new byte[World.数据库单个物品大小];
					}
					if (World.AllItmelog == 1)
					{
						try
						{
							if (个人仓库[num24].得到物品位置类型() != 1 && 个人仓库[num24].得到物品位置类型() != 2 && 个人仓库[num24].得到物品位置类型() != 5 && 个人仓库[num24].得到物品位置类型() != 6)
							{
								if (个人仓库[num24].得到物品位置类型() != 4 && 个人仓库[num24].得到物品位置类型() == 12 && (个人仓库[num24].属性1.属性类型 == 7 || 个人仓库[num24].属性2.属性类型 == 7 || 个人仓库[num24].属性3.属性类型 == 7 || 个人仓库[num24].属性4.属性类型 == 7))
								{
									Form1.WriteLine(6, "发现WG防物品  个人仓库  [" + Userid + "]-[" + UserName + "]  位置[" + num24 + "]  编号[" + BitConverter.ToInt32(个人仓库[num24].物品全局ID, 0) + "]  物品名称[" + 个人仓库[num24].得到物品名称() + "]  物品数量[" + BitConverter.ToInt32(个人仓库[num24].物品数量, 0) + "]  属性:[" + 个人仓库[num24].FLD_MAGIC0 + "," + 个人仓库[num24].FLD_MAGIC1 + "," + 个人仓库[num24].FLD_MAGIC2 + "," + 个人仓库[num24].FLD_MAGIC3 + "," + 个人仓库[num24].FLD_MAGIC4 + "]");
									个人仓库[num24].物品_byte = new byte[World.数据库单个物品大小];
								}
							}
							else if (个人仓库[num24].属性1.属性类型 == 7 || 个人仓库[num24].属性2.属性类型 == 7 || 个人仓库[num24].属性3.属性类型 == 7 || 个人仓库[num24].属性4.属性类型 == 7)
							{
								Form1.WriteLine(6, "发现WG防物品  个人仓库  [" + Userid + "]-[" + UserName + "]  位置[" + num24 + "]  编号[" + BitConverter.ToInt32(个人仓库[num24].物品全局ID, 0) + "]  物品名称[" + 个人仓库[num24].得到物品名称() + "]  物品数量[" + BitConverter.ToInt32(个人仓库[num24].物品数量, 0) + "]  属性:[" + 个人仓库[num24].FLD_MAGIC0 + "," + 个人仓库[num24].FLD_MAGIC1 + "," + 个人仓库[num24].FLD_MAGIC2 + "," + 个人仓库[num24].FLD_MAGIC3 + "," + 个人仓库[num24].FLD_MAGIC4 + "]");
								个人仓库[num24].物品_byte = new byte[World.数据库单个物品大小];
							}
						}
						catch (Exception ex9)
						{
							string[] array32 = new string[24]
							{
								"查物品错误                个人仓库  错误    [",
								Userid,
								"]-[",
								UserName,
								"]  位置[",
								num24.ToString(),
								"]  编号[",
								BitConverter.ToInt32(个人仓库[num24].物品全局ID, 0).ToString(),
								"]  物品名称[",
								个人仓库[num24].得到物品名称(),
								"]  物品数量[",
								BitConverter.ToInt32(个人仓库[num24].物品数量, 0).ToString(),
								"]  属性:[",
								个人仓库[num24].FLD_MAGIC0.ToString(),
								",",
								null,
								null,
								null,
								null,
								null,
								null,
								null,
								null,
								null
							};
							array32[15] = 个人仓库[num24].FLD_MAGIC1.ToString();
							array32[16] = ",";
							array32[17] = 个人仓库[num24].FLD_MAGIC2.ToString();
							array32[18] = ",";
							array32[19] = 个人仓库[num24].FLD_MAGIC3.ToString();
							array32[20] = ",";
							array32[21] = 个人仓库[num24].FLD_MAGIC4.ToString();
							array32[22] = "]";
							array32[23] = ((ex9 != null) ? ex9.ToString() : null);
							Form1.WriteLine(1, string.Concat(array32));
						}
					}
				}
				userWarehouse.Dispose();
				num = 15;
				DataTable userPublicWarehouse = RxjhClass.GetUserPublicWarehouse(Userid);
				if (userPublicWarehouse == null && Client != null)
				{
					Client.Dispose();
				}
				byte[] array33 = (byte[])userPublicWarehouse.Rows[0]["FLD_ITEM"];
				综合仓库装备数据版本 = (int)userPublicWarehouse.Rows[0]["FLD_ZBVER"];
				byte[] src = (byte[])userPublicWarehouse.Rows[0]["FLD_ITIME"];
				try
				{
					综合仓库钱数 = long.Parse(userPublicWarehouse.Rows[0]["FLD_MONEY"].ToString());
				}
				catch
				{
					综合仓库钱数 = 0L;
				}
				for (int num26 = 0; num26 < 60; num26++)
				{
					byte[] array34 = new byte[World.数据库单个物品大小];
					if (array33.Length >= num26 * World.数据库单个物品大小 + World.数据库单个物品大小)
					{
						try
						{
							System.Buffer.BlockCopy(array33, num26 * World.数据库单个物品大小, array34, 0, World.数据库单个物品大小);
						}
						catch (Exception value4)
						{
							Console.WriteLine(value4);
						}
					}
					公共仓库[num26] = new 物品类(array34, num26);
					if (公共仓库[num26].Get物品ID == 1008001507L)
					{
						是否携带披风行囊 = true;
					}
					byte[] array35 = new byte[4];
					System.Buffer.BlockCopy(公共仓库[num26].物品_byte, World.物品属性大小, array35, 0, 4);
					int num27 = BitConverter.ToInt32(array35, 0);
					if (num27 > 0 && DateTime.Now.Subtract(new DateTime(1970, 1, 1, 8, 0, 0).AddSeconds(num27)).TotalSeconds >= 0.0)
					{
						系统提示("公共仓库有物品过期[" + 公共仓库[num26].得到物品名称() + "],系统已删除！", 9, "系统提示");
						公共仓库[num26].物品_byte = new byte[World.数据库单个物品大小];
					}
					if (World.AllItmelog == 1)
					{
						try
						{
							if (公共仓库[num26].得到物品位置类型() != 1 && 公共仓库[num26].得到物品位置类型() != 2 && 公共仓库[num26].得到物品位置类型() != 5 && 公共仓库[num26].得到物品位置类型() != 6)
							{
								if (公共仓库[num26].得到物品位置类型() != 4 && 公共仓库[num26].得到物品位置类型() == 12 && (公共仓库[num26].属性1.属性类型 == 7 || 公共仓库[num26].属性2.属性类型 == 7 || 公共仓库[num26].属性3.属性类型 == 7 || 公共仓库[num26].属性4.属性类型 == 7))
								{
									Form1.WriteLine(6, "发现WG防物品  公共仓库  [" + Userid + "]-[" + UserName + "]  位置[" + num26 + "]  编号[" + BitConverter.ToInt32(公共仓库[num26].物品全局ID, 0) + "]  物品名称[" + 公共仓库[num26].得到物品名称() + "]  物品数量[" + BitConverter.ToInt32(公共仓库[num26].物品数量, 0) + "]  属性:[" + 公共仓库[num26].FLD_MAGIC0 + "," + 公共仓库[num26].FLD_MAGIC1 + "," + 公共仓库[num26].FLD_MAGIC2 + "," + 公共仓库[num26].FLD_MAGIC3 + "," + 公共仓库[num26].FLD_MAGIC4 + "]");
									公共仓库[num26].物品_byte = new byte[World.数据库单个物品大小];
								}
							}
							else if (公共仓库[num26].属性1.属性类型 == 7 || 公共仓库[num26].属性2.属性类型 == 7 || 公共仓库[num26].属性3.属性类型 == 7 || 公共仓库[num26].属性4.属性类型 == 7)
							{
								Form1.WriteLine(6, "发现WG防物品  公共仓库  [" + Userid + "]-[" + UserName + "]  位置[" + num26 + "]  编号[" + BitConverter.ToInt32(公共仓库[num26].物品全局ID, 0) + "]  物品名称[" + 公共仓库[num26].得到物品名称() + "]  物品数量[" + BitConverter.ToInt32(公共仓库[num26].物品数量, 0) + "]  属性:[" + 公共仓库[num26].FLD_MAGIC0 + "," + 公共仓库[num26].FLD_MAGIC1 + "," + 公共仓库[num26].FLD_MAGIC2 + "," + 公共仓库[num26].FLD_MAGIC3 + "," + 公共仓库[num26].FLD_MAGIC4 + "]");
								公共仓库[num26].物品_byte = new byte[World.数据库单个物品大小];
							}
						}
						catch (Exception ex10)
						{
							string[] array36 = new string[24]
							{
								"查物品错误                个人仓库  错误  [",
								Userid,
								"]-[",
								UserName,
								"]  位置[",
								num26.ToString(),
								"]  编号[",
								BitConverter.ToInt32(公共仓库[num26].物品全局ID, 0).ToString(),
								"]  物品名称[",
								公共仓库[num26].得到物品名称(),
								"]  物品数量[",
								BitConverter.ToInt32(公共仓库[num26].物品数量, 0).ToString(),
								"]  属性:[",
								公共仓库[num26].FLD_MAGIC0.ToString(),
								",",
								null,
								null,
								null,
								null,
								null,
								null,
								null,
								null,
								null
							};
							array36[15] = 公共仓库[num26].FLD_MAGIC1.ToString();
							array36[16] = ",";
							array36[17] = 公共仓库[num26].FLD_MAGIC2.ToString();
							array36[18] = ",";
							array36[19] = 公共仓库[num26].FLD_MAGIC3.ToString();
							array36[20] = ",";
							array36[21] = 公共仓库[num26].FLD_MAGIC4.ToString();
							array36[22] = "]";
							array36[23] = ((ex10 != null) ? ex10.ToString() : null);
							Form1.WriteLine(1, string.Concat(array36));
						}
					}
				}
				userPublicWarehouse.Dispose();
				byte[] array37 = (byte[])dBToDataTable.Rows[0]["FLD_STIME"];
				if (array37 != null && array37.Length > 1)
				{
					byte[] array38 = new byte[16];
					System.Buffer.BlockCopy(array37, 0, array38, 0, 16);
					for (int num28 = 0; num28 < 40; num28++)
					{
						try
						{
							byte[] array39 = new byte[4];
							byte[] array40 = new byte[4];
							System.Buffer.BlockCopy(array38, num28 * 8, array39, 0, 4);
							System.Buffer.BlockCopy(array38, num28 * 8 + 4, array40, 0, 4);
							if (BitConverter.ToInt32(array39, 0) > 0)
							{
								if (!时间药品.ContainsKey(BitConverter.ToInt32(array39, 0)))
								{
									时间药品类 时间药品类 = new 时间药品类();
									时间药品类.药品ID = BitConverter.ToInt32(array39, 0);
									时间药品类.时间 = BitConverter.ToInt32(array40, 0);
									时间药品.Add(时间药品类.药品ID, 时间药品类);
								}
								continue;
							}
						}
						catch (Exception value5)
						{
							Console.WriteLine(value5);
							continue;
						}
						break;
					}
				}
				byte[] array41 = (byte[])dBToDataTable.Rows[0]["FLD_CHTIME"];
				if (array41 != null && array41.Length > 1)
				{
					byte[] array42 = new byte[16];
					System.Buffer.BlockCopy(array41, 0, array42, 0, 16);
					for (int num29 = 0; num29 < 40; num29++)
					{
						try
						{
							byte[] array43 = new byte[4];
							byte[] array44 = new byte[4];
							System.Buffer.BlockCopy(array42, num29 * 8, array43, 0, 4);
							System.Buffer.BlockCopy(array42, num29 * 8 + 4, array44, 0, 4);
							if (BitConverter.ToInt32(array43, 0) > 0)
							{
								if (!称号药品.ContainsKey(BitConverter.ToInt32(array43, 0)))
								{
									称号药品类 称号药品类 = new 称号药品类();
									称号药品类.药品ID = BitConverter.ToInt32(array43, 0);
									称号药品类.时间 = BitConverter.ToInt32(array44, 0);
									称号药品.Add(称号药品类.药品ID, 称号药品类);
								}
								continue;
							}
						}
						catch (Exception value6)
						{
							Console.WriteLine(value6);
							continue;
						}
						break;
					}
				}
				num = 16;
				个人药品 = null;
				if (!dBToDataTable.Rows[0]["FLD_CTIME"].Equals(null))
				{
					个人药品 = (byte[])dBToDataTable.Rows[0]["FLD_CTIME"];
				}
				if (!dBToDataTable.Rows[0]["FLD_CTIMENEW"].Equals(null))
				{
					追加状态物品New = (byte[])dBToDataTable.Rows[0]["FLD_CTIMENEW"];
				}
				byte[] array45 = new byte[16];
				System.Buffer.BlockCopy(src, 0, array45, 0, 16);
				for (int num30 = 0; num30 < 2; num30++)
				{
					try
					{
						byte[] array46 = new byte[4];
						byte[] array47 = new byte[4];
						System.Buffer.BlockCopy(array45, num30 * 8, array46, 0, 4);
						System.Buffer.BlockCopy(array45, num30 * 8 + 4, array47, 0, 4);
						DateTime t = new DateTime(1970, 1, 1, 8, 0, 0).AddSeconds(BitConverter.ToInt32(array47, 0));
						if (!(t < DateTime.Now) && BitConverter.ToInt32(array46, 0) > 0 && !公有药品.ContainsKey(BitConverter.ToInt32(array46, 0)))
						{
							公有药品类 公有药品类 = new 公有药品类();
							公有药品类.药品ID = BitConverter.ToInt32(array46, 0);
							公有药品类.时间 = BitConverter.ToInt32(array47, 0);
							公有药品.Add(公有药品类.药品ID, 公有药品类);
						}
					}
					catch (Exception value7)
					{
						Console.WriteLine(value7);
					}
				}
				num = 17;
				byte[] array48 = null;
				if (dBToDataTable.Rows[0]["FLD_DOORS"] != null)
				{
					array48 = (byte[])dBToDataTable.Rows[0]["FLD_DOORS"];
				}
				土灵符坐标.Clear();
				if (array48.Length >= 128)
				{
					for (int num31 = 0; num31 < 30; num31++)
					{
						try
						{
							byte[] array49 = new byte[4];
							byte[] array50 = new byte[4];
							byte[] array51 = new byte[4];
							byte[] array52 = new byte[4];
							byte[] array53 = new byte[14];
							System.Buffer.BlockCopy(array48, num31 * 32 + 15, array52, 0, 4);
							System.Buffer.BlockCopy(array48, num31 * 32 + 19, array49, 0, 4);
							System.Buffer.BlockCopy(array48, num31 * 32 + 23, array50, 0, 4);
							System.Buffer.BlockCopy(array48, num31 * 32 + 27, array51, 0, 4);
							System.Buffer.BlockCopy(array48, num31 * 32, array53, 0, 14);
							string rxjh_name = Encoding.Default.GetString(array53).Trim();
							if ((double)BitConverter.ToSingle(array49, 0) != 0.0 || (double)BitConverter.ToSingle(array50, 0) != 0.0 || BitConverter.ToInt32(array52, 0) != 0)
							{
								坐标Class 坐标Class = new 坐标Class(BitConverter.ToSingle(array49, 0), BitConverter.ToSingle(array50, 0), BitConverter.ToSingle(array51, 0), BitConverter.ToInt32(array52, 0));
								坐标Class.Rxjh_name = rxjh_name;
								if (土灵符坐标.ContainsKey(10 + num31))
								{
									土灵符坐标.Remove(10 + num31);
								}
								土灵符坐标.Add(10 + num31, 坐标Class);
							}
						}
						catch
						{
						}
					}
				}
				num = 18;
				DataTable userNameBp = RxjhClass.GetUserNameBp(UserName);
				if (userNameBp != null)
				{
					帮派Id = (int)userNameBp.Rows[0]["Id"];
					帮派名字 = userNameBp.Rows[0]["G_Name"].ToString();
					帮派人物等级 = (int)userNameBp.Rows[0]["leve"];
					DataTable dBToDataTable2 = DBA.GetDBToDataTable(string.Format("SELECT  leve  FROM  TBL_XWWL_Guild  WHERE  ID  ={0}", 帮派Id));
					if (dBToDataTable2 != null)
					{
						帮派等级 = (int)dBToDataTable2.Rows[0]["leve"];
						dBToDataTable2.Dispose();
					}
					帮派门服字 = (int)userNameBp.Rows[0]["门服字"];
					帮派门服颜色 = (int)userNameBp.Rows[0]["门服颜色"];
					try
					{
						if (userNameBp.Rows[0]["Mh"] != DBNull.Value)
						{
							帮派门徽 = (byte[])userNameBp.Rows[0]["Mh"];
						}
					}
					catch (Exception ex11)
					{
						Form1.WriteLine(2, "读帮派数据出错  " + Userid + "    " + ex11.Message);
					}
					userNameBp.Dispose();
				}
				num = 19;
				num = 20;
				计算人物基本数据();
				dBToDataTable.Dispose();
				num = 21;
				装备数据版本 = 1;
				综合仓库装备数据版本 = 1;
			}
			catch (Exception ex12)
			{
				Form1.WriteLine(1, num + "|读出人物数据出错  " + Userid + "    " + ex12.Message);
				Client.Dispose();
			}
		}

		public void 记算夫妻武功攻击力数据()
		{
			if (武功新[2, 16] == null)
			{
				return;
			}
			List<int> list = new List<int>();
			List<int> list2 = new List<int>();
			for (int i = 0; i < 32; i++)
			{
				if (武功新[3, i] != null)
				{
					int num = 武功新[3, i].FLD_AT + (武功新[3, i].武功_等级 - 1) * 武功新[3, i].FLD_每级加危害 / World.升天技能等级加成;
					if (num > 0)
					{
						升天气功武功等级 = 武功新[3, i].武功_等级;
						list.Add(num);
						int item = 武功新[3, i].FLD_MP + (武功新[3, i].武功_等级 - 1) * 武功新[3, i].FLD_每级加MP;
						list2.Add(item);
					}
				}
			}
			for (int j = 0; j < 32; j++)
			{
				if (武功新[0, j] != null)
				{
					int num2 = 武功新[0, j].FLD_AT + (武功新[0, j].武功_等级 - 1) * 武功新[0, j].FLD_每级加危害 / World.升天技能等级加成;
					if (num2 > 0)
					{
						list.Add(num2);
						list2.Add(武功新[0, j].FLD_MP);
					}
				}
			}
			int[] array = list.ToArray();
			int[] array2 = list2.ToArray();
			Array.Sort(array, array2);
			if (array.Length != 0)
			{
				夫妻武功攻击力 = array[array.Length - 1];
				夫妻武功攻击力MP = array2[array2.Length - 1];
			}
		}

		public void 读帮派数据()
		{
			DataTable userNameBp = RxjhClass.GetUserNameBp(UserName);
			if (userNameBp != null)
			{
				帮派Id = (int)userNameBp.Rows[0]["Id"];
				帮派名字 = userNameBp.Rows[0]["G_Name"].ToString();
				帮派人物等级 = (int)userNameBp.Rows[0]["leve"];
				DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  leve  FROM  TBL_XWWL_Guild  WHERE  ID  ={0}", 帮派Id));
				if (dBToDataTable != null)
				{
					帮派等级 = (int)dBToDataTable.Rows[0]["leve"];
					dBToDataTable.Dispose();
				}
				帮派门服字 = (int)userNameBp.Rows[0]["门服字"];
				帮派门服颜色 = (int)userNameBp.Rows[0]["门服颜色"];
				try
				{
					if (userNameBp.Rows[0]["Mh"] != DBNull.Value)
					{
						帮派门徽 = (byte[])userNameBp.Rows[0]["Mh"];
					}
				}
				catch (Exception ex)
				{
					Form1.WriteLine(2, "读出帮派数据出错      " + Userid + "            " + ex.Message);
				}
				userNameBp.Dispose();
			}
			else
			{
				帮派Id = 0;
				帮派名字 = string.Empty;
				帮派等级 = 0;
				帮派人物等级 = 0;
				帮派门服颜色 = 0;
				帮派门服字 = 0;
				帮派门徽 = null;
			}
		}

		public void 更新门派等级(string string_11)
		{
			try
			{
				DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  *  FROM  TBL_XWWL_Guild  WHERE  G_Master  ='{0}'", string_11));
				if (dBToDataTable != null)
				{
					int num = (int)dBToDataTable.Rows[0]["胜"];
					int num2 = (int)dBToDataTable.Rows[0]["ID"];
					int num3 = (int)dBToDataTable.Rows[0]["leve"];
					int num4 = 5;
					if (num >= 3 && num < 8)
					{
						num4 = 6;
					}
					else if (num >= 8)
					{
						num4 = 7;
					}
					int num5 = num4;
					if (num3 != num5)
					{
						try
						{
							DBA.ExeSqlCommand(string.Format("UPDATE  TBL_XWWL_Guild  SET  leve={1}  WHERE  ID={0}", num2, num4));
						}
						catch (Exception ex)
						{
							Form1.WriteLine(1, "帮战  更新门派等级()  出错：" + ((ex != null) ? ex.ToString() : null));
							Form1.WriteLine(100, "帮战  更新门派等级()  出错：" + ((ex != null) ? ex.ToString() : null));
						}
					}
					dBToDataTable.Dispose();
				}
			}
			catch (Exception ex2)
			{
				Form1.WriteLine(1, "帮战  更新门派等级()  出错：" + ((ex2 != null) ? ex2.ToString() : null));
				Form1.WriteLine(100, "帮战  更新门派等级    出错：" + ((ex2 != null) ? ex2.ToString() : null));
			}
		}

		public bool 判断星装(long long_5, int int_109)
		{
			switch (int_109)
			{
			case 1:
				if (long_5 != 115301001L && long_5 != 115302001L && long_5 != 125301001L && long_5 != 125302001L && long_5 != 215301001L && long_5 != 215302001L && long_5 != 225301001L && long_5 != 225302001L && long_5 != 315301001L && long_5 != 315302001L && long_5 != 325301001L && long_5 != 325302001L && long_5 != 415301001L && long_5 != 415302001L && long_5 != 425301001L && long_5 != 425302001L && long_5 != 515301001L && long_5 != 515302001L && long_5 != 525301001L && long_5 != 525302001L && long_5 != 715301001L && long_5 != 715302001L && long_5 != 725301001L && long_5 != 725302001L && long_5 != 815301001L && long_5 != 815302001L && long_5 != 825301001L)
				{
					return long_5 == 825302001L;
				}
				return true;
			case 2:
				if (long_5 != 725502001L && long_5 != 725501001L && long_5 != 715502001L && long_5 != 715501001L && long_5 != 525502001L && long_5 != 525501001L && long_5 != 515502001L && long_5 != 515501001L && long_5 != 425502001L && long_5 != 425501001L && long_5 != 415502001L && long_5 != 415501001L && long_5 != 325502001L && long_5 != 325501001L && long_5 != 315502001L && long_5 != 315501001L && long_5 != 225502001L && long_5 != 225501001L && long_5 != 215502001L && long_5 != 215501001L && long_5 != 125502001L && long_5 != 125501001L && long_5 != 115502001L && long_5 != 115501001L && long_5 != 815501001L && long_5 != 815502001L && long_5 != 825501001L)
				{
					return long_5 == 825502001L;
				}
				return true;
			default:
				return false;
			case 5:
				if (long_5 != 115801001L && long_5 != 115802001L && long_5 != 125801001L && long_5 != 125802001L && long_5 != 215801001L && long_5 != 215802001L && long_5 != 225801001L && long_5 != 225802001L && long_5 != 315801001L && long_5 != 315802001L && long_5 != 325801001L && long_5 != 325802001L && long_5 != 415801001L && long_5 != 415802001L && long_5 != 425801001L && long_5 != 425802001L && long_5 != 515801001L && long_5 != 515802001L && long_5 != 525801001L && long_5 != 525802001L && long_5 != 715801001L && long_5 != 715802001L && long_5 != 725801001L && long_5 != 725802001L && long_5 != 815801001L && long_5 != 815802001L && long_5 != 825801001L)
				{
					return long_5 == 825802001L;
				}
				return true;
			case 6:
				if (long_5 != 115401001L && long_5 != 115402001L && long_5 != 125401001L && long_5 != 125402001L && long_5 != 215401001L && long_5 != 215402001L && long_5 != 225401001L && long_5 != 225402001L && long_5 != 315401001L && long_5 != 315402001L && long_5 != 325401001L && long_5 != 325402001L && long_5 != 415401001L && long_5 != 415402001L && long_5 != 425401001L && long_5 != 425402001L && long_5 != 515401001L && long_5 != 515402001L && long_5 != 525401001L && long_5 != 525402001L && long_5 != 715401001L && long_5 != 715402001L && long_5 != 725401001L && long_5 != 725402001L && long_5 != 815401001L && long_5 != 815402001L && long_5 != 825401001L)
				{
					return long_5 == 825402001L;
				}
				return true;
			}
		}

		public bool 判断PVP装备(int int_109, int int_110)
		{
			PVP类 value;
			if (World.PVP装备.TryGetValue(int_109, out value))
			{
				return value.物品等级 == int_110;
			}
			return false;
		}

		public bool 判断PVP装备强化(int int_109)
		{
			PVP类 value;
			return World.PVP装备.TryGetValue(int_109, out value);
		}

		public void PVP装备加成()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			for (int i = 0; i < 6; i++)
			{
				if (判断PVP装备((int)装备栏已穿装备[i].Get物品ID, 110))
				{
					num++;
				}
				else if (判断PVP装备((int)装备栏已穿装备[i].Get物品ID, 120))
				{
					num2++;
				}
				else if (判断PVP装备((int)装备栏已穿装备[i].Get物品ID, 130))
				{
					num3++;
				}
				else if (判断PVP装备((int)装备栏已穿装备[i].Get物品ID, 140))
				{
					num4++;
				}
				else if (判断PVP装备((int)装备栏已穿装备[i].Get物品ID, 150))
				{
					num5++;
				}
			}
			if (num > 0)
			{
				switch (Player_Job)
				{
				case 1:
					switch (num)
					{
					case 2:
						人物追加战力 += 5;
						break;
					case 3:
						人物追加战力 += 10;
						break;
					case 4:
						人物追加战力 += 15;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						break;
					case 5:
						人物追加战力 += 15;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						FLD_装备_追加_HP += 500;
						break;
					case 6:
						人物追加战力 += 25;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_HP += 500;
						FLD_装备_追加_防御 += 40;
						FLD_装备_追加_攻击 += 50;
						break;
					}
					break;
				case 2:
					switch (num)
					{
					case 2:
						人物追加战力 += 5;
						break;
					case 3:
						人物追加战力 += 10;
						break;
					case 4:
						人物追加战力 += 15;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						break;
					case 5:
						人物追加战力 += 15;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						FLD_装备_追加_HP += 500;
						break;
					case 6:
						人物追加战力 += 25;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_HP += 500;
						FLD_装备_追加_防御 += 90;
						break;
					}
					break;
				case 3:
					switch (num)
					{
					case 2:
						人物追加战力 += 5;
						break;
					case 3:
						人物追加战力 += 10;
						break;
					case 4:
						人物追加战力 += 15;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						break;
					case 5:
						人物追加战力 += 15;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						FLD_装备_追加_HP += 500;
						break;
					case 6:
						人物追加战力 += 25;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_HP += 500;
						FLD_装备_追加_防御 += 90;
						break;
					}
					break;
				case 4:
					switch (num)
					{
					case 2:
						人物追加战力 += 5;
						break;
					case 3:
						人物追加战力 += 10;
						break;
					case 4:
						人物追加战力 += 15;
						FLD_装备_追加_防御 += 40;
						FLD_装备_追加_攻击 += 20;
						break;
					case 5:
						人物追加战力 += 15;
						FLD_装备_追加_防御 += 40;
						FLD_装备_追加_HP += 500;
						FLD_装备_追加_攻击 += 20;
						break;
					case 6:
						人物追加战力 += 25;
						FLD_装备_武功攻击力增加百分比 += 0.2;
						FLD_装备_追加_HP += 500;
						FLD_装备_追加_防御 += 40;
						FLD_装备_追加_攻击 += 20;
						break;
					}
					break;
				case 5:
					switch (num)
					{
					case 2:
						人物追加战力 += 5;
						break;
					case 3:
						人物追加战力 += 10;
						break;
					case 4:
						人物追加战力 += 15;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						break;
					case 5:
						人物追加战力 += 15;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						FLD_装备_追加_HP += 400;
						FLD_装备_追加_MP += 1000;
						break;
					case 6:
						人物追加战力 += 25;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_HP += 400;
						FLD_装备_追加_防御 += 40;
						FLD_装备_追加_攻击 += 50;
						FLD_装备_追加_MP += 1000;
						break;
					}
					break;
				case 6:
					switch (num)
					{
					case 2:
						人物追加战力 += 5;
						break;
					case 3:
						人物追加战力 += 10;
						break;
					case 4:
						人物追加战力 += 15;
						FLD_装备_追加_防御 += 40;
						FLD_装备_追加_攻击 += 20;
						break;
					case 5:
						人物追加战力 += 15;
						FLD_装备_追加_防御 += 40;
						FLD_装备_追加_HP += 500;
						FLD_装备_追加_攻击 += 20;
						break;
					case 6:
						人物追加战力 += 25;
						FLD_装备_武功攻击力增加百分比 += 0.2;
						FLD_装备_追加_HP += 500;
						FLD_装备_追加_防御 += 40;
						FLD_装备_追加_攻击 += 20;
						break;
					}
					break;
				case 7:
					switch (num)
					{
					case 2:
						人物追加战力 += 5;
						break;
					case 3:
						人物追加战力 += 10;
						break;
					case 4:
						人物追加战力 += 15;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						break;
					case 5:
						人物追加战力 += 15;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						FLD_装备_追加_HP += 400;
						FLD_装备_追加_MP += 1000;
						break;
					case 6:
						人物追加战力 += 25;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_HP += 400;
						FLD_装备_追加_防御 += 90;
						FLD_装备_追加_MP += 1000;
						break;
					}
					break;
				case 8:
					switch (num)
					{
					case 2:
						人物追加战力 += 5;
						break;
					case 3:
						人物追加战力 += 12;
						break;
					case 4:
						人物追加战力 += 12;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						break;
					case 5:
						人物追加战力 += 12;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						FLD_装备_追加_HP += 500;
						break;
					case 6:
						人物追加战力 += 25;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_HP += 500;
						FLD_装备_追加_防御 += 40;
						FLD_装备_追加_攻击 += 50;
						break;
					}
					break;
				case 9:
					switch (num)
					{
					case 2:
						人物追加战力 += 5;
						break;
					case 3:
						人物追加战力 += 12;
						break;
					case 4:
						人物追加战力 += 12;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						break;
					case 5:
						人物追加战力 += 12;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						FLD_装备_追加_HP += 500;
						break;
					case 6:
						人物追加战力 += 25;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_HP += 500;
						FLD_装备_追加_防御 += 40;
						FLD_装备_追加_攻击 += 50;
						break;
					}
					break;
				case 10:
					switch (num)
					{
					case 2:
						人物追加战力 += 5;
						break;
					case 3:
						人物追加战力 += 10;
						break;
					case 4:
						人物追加战力 += 15;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						break;
					case 5:
						人物追加战力 += 15;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						FLD_装备_追加_HP += 500;
						break;
					case 6:
						人物追加战力 += 25;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_HP += 500;
						FLD_装备_追加_防御 += 90;
						break;
					}
					break;
				case 11:
					switch (num)
					{
					case 2:
						人物追加战力 += 5;
						break;
					case 3:
						人物追加战力 += 10;
						break;
					case 4:
						人物追加战力 += 15;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						break;
					case 5:
						人物追加战力 += 15;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						FLD_装备_追加_HP += 500;
						break;
					case 6:
						人物追加战力 += 25;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_HP += 500;
						FLD_装备_追加_防御 += 90;
						break;
					}
					break;
				case 12:
					switch (num)
					{
					case 2:
						人物追加战力 += 5;
						break;
					case 3:
						人物追加战力 += 10;
						break;
					case 4:
						人物追加战力 += 15;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						break;
					case 5:
						人物追加战力 += 15;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						FLD_装备_追加_HP += 500;
						break;
					case 6:
						人物追加战力 += 25;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_HP += 500;
						FLD_装备_追加_防御 += 90;
						break;
					}
					break;
				}
			}
			if (num2 > 0)
			{
				switch (Player_Job)
				{
				case 1:
					switch (num2)
					{
					case 2:
						人物追加战力 += 5;
						break;
					case 3:
						人物追加战力 += 10;
						break;
					case 4:
						人物追加战力 += 10;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 30;
						break;
					case 5:
						人物追加战力 += 10;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 30;
						FLD_装备_追加_HP += 400;
						break;
					case 6:
						人物追加战力 += 25;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_HP += 400;
						FLD_装备_追加_防御 += 30;
						FLD_装备_追加_攻击 += 50;
						break;
					}
					break;
				case 2:
				case 3:
					switch (num2)
					{
					case 2:
						人物追加战力 += 5;
						break;
					case 3:
						人物追加战力 += 10;
						break;
					case 4:
						人物追加战力 += 10;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 30;
						break;
					case 5:
						人物追加战力 += 10;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 30;
						FLD_装备_追加_HP += 400;
						break;
					case 6:
						人物追加战力 += 25;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_HP += 400;
						FLD_装备_追加_防御 += 80;
						break;
					}
					break;
				case 5:
					switch (num2)
					{
					case 2:
						人物追加战力 += 5;
						break;
					case 3:
						人物追加战力 += 10;
						break;
					case 4:
						人物追加战力 += 10;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 30;
						break;
					case 5:
						人物追加战力 += 10;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 30;
						FLD_装备_追加_HP += 300;
						FLD_装备_追加_MP += 1000;
						break;
					case 6:
						人物追加战力 += 25;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_HP += 300;
						FLD_装备_追加_防御 += 30;
						FLD_装备_追加_攻击 += 50;
						FLD_装备_追加_MP += 1000;
						break;
					}
					break;
				case 4:
				case 6:
					switch (num2)
					{
					case 2:
						人物追加战力 += 5;
						break;
					case 3:
						人物追加战力 += 10;
						break;
					case 4:
						人物追加战力 += 10;
						FLD_装备_追加_防御 += 30;
						FLD_装备_追加_攻击 += 20;
						break;
					case 5:
						人物追加战力 += 10;
						FLD_装备_追加_防御 += 30;
						FLD_装备_追加_HP += 400;
						FLD_装备_追加_攻击 += 20;
						break;
					case 6:
						人物追加战力 += 25;
						FLD_装备_武功攻击力增加百分比 += 0.2;
						FLD_装备_追加_HP += 400;
						FLD_装备_追加_防御 += 30;
						FLD_装备_追加_攻击 += 20;
						break;
					}
					break;
				case 7:
					switch (num2)
					{
					case 2:
						人物追加战力 += 5;
						break;
					case 3:
						人物追加战力 += 10;
						break;
					case 4:
						人物追加战力 += 10;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 30;
						break;
					case 5:
						人物追加战力 += 10;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 30;
						FLD_装备_追加_HP += 300;
						FLD_装备_追加_MP += 1000;
						break;
					case 6:
						人物追加战力 += 25;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_HP += 300;
						FLD_装备_追加_防御 += 80;
						FLD_装备_追加_MP += 1000;
						break;
					}
					break;
				case 8:
					switch (num2)
					{
					case 2:
						人物追加战力 += 5;
						break;
					case 3:
						人物追加战力 += 10;
						break;
					case 4:
						人物追加战力 += 10;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 30;
						break;
					case 5:
						人物追加战力 += 10;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 30;
						FLD_装备_追加_HP += 100;
						break;
					case 6:
						人物追加战力 += 25;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_HP += 100;
						FLD_装备_追加_防御 += 30;
						FLD_装备_追加_攻击 += 50;
						break;
					}
					break;
				case 9:
					switch (num2)
					{
					case 2:
						人物追加战力 += 5;
						break;
					case 3:
						人物追加战力 += 10;
						break;
					case 4:
						人物追加战力 += 10;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 30;
						break;
					case 5:
						人物追加战力 += 10;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 30;
						FLD_装备_追加_HP += 100;
						break;
					case 6:
						人物追加战力 += 25;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_HP += 100;
						FLD_装备_追加_防御 += 80;
						break;
					}
					break;
				case 10:
					switch (num2)
					{
					case 2:
						人物追加战力 += 5;
						break;
					case 3:
						人物追加战力 += 12;
						break;
					case 4:
						人物追加战力 += 12;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 30;
						break;
					case 5:
						人物追加战力 += 15;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 30;
						FLD_装备_追加_HP += 100;
						break;
					case 6:
						人物追加战力 += 25;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_HP += 100;
						FLD_装备_追加_防御 += 80;
						break;
					}
					break;
				case 11:
					switch (num2)
					{
					case 2:
						人物追加战力 += 5;
						break;
					case 3:
						人物追加战力 += 7;
						break;
					case 4:
						人物追加战力 += 12;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 30;
						break;
					case 5:
						人物追加战力 += 15;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 30;
						FLD_装备_追加_HP += 100;
						break;
					case 6:
						人物追加战力 += 25;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_HP += 100;
						FLD_装备_追加_防御 += 80;
						break;
					}
					break;
				case 12:
					switch (num2)
					{
					case 2:
						人物追加战力 += 5;
						break;
					case 3:
						人物追加战力 += 7;
						break;
					case 4:
						人物追加战力 += 12;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 30;
						break;
					case 5:
						人物追加战力 += 15;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 30;
						FLD_装备_追加_HP += 100;
						break;
					case 6:
						人物追加战力 += 25;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_HP += 100;
						FLD_装备_追加_防御 += 80;
						break;
					}
					break;
				}
			}
			if (num3 > 0)
			{
				switch (Player_Job)
				{
				case 1:
					switch (num3)
					{
					case 2:
						人物追加战力 += 5;
						break;
					case 3:
						人物追加战力 += 10;
						break;
					case 4:
						人物追加战力 += 10;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						break;
					case 5:
						人物追加战力 += 10;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						FLD_装备_追加_HP += 500;
						break;
					case 6:
						人物追加战力 += 25;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_HP += 500;
						FLD_装备_追加_防御 += 40;
						FLD_装备_追加_攻击 += 50;
						break;
					}
					break;
				case 2:
				case 3:
					switch (num3)
					{
					case 2:
						人物追加战力 += 5;
						break;
					case 3:
						人物追加战力 += 10;
						break;
					case 4:
						人物追加战力 += 10;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						break;
					case 5:
						人物追加战力 += 10;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						FLD_装备_追加_HP += 500;
						break;
					case 6:
						人物追加战力 += 25;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_HP += 500;
						FLD_装备_追加_防御 += 90;
						break;
					}
					break;
				case 5:
					switch (num3)
					{
					case 2:
						人物追加战力 += 5;
						break;
					case 3:
						人物追加战力 += 10;
						break;
					case 4:
						人物追加战力 += 10;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						break;
					case 5:
						人物追加战力 += 10;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						FLD_装备_追加_HP += 400;
						FLD_装备_追加_MP += 1000;
						break;
					case 6:
						人物追加战力 += 25;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_HP += 400;
						FLD_装备_追加_防御 += 40;
						FLD_装备_追加_攻击 += 50;
						FLD_装备_追加_MP += 1000;
						break;
					}
					break;
				case 4:
				case 6:
					switch (num3)
					{
					case 2:
						人物追加战力 += 5;
						break;
					case 3:
						人物追加战力 += 10;
						break;
					case 4:
						人物追加战力 += 10;
						FLD_装备_追加_防御 += 40;
						FLD_装备_追加_攻击 += 20;
						break;
					case 5:
						人物追加战力 += 10;
						FLD_装备_追加_防御 += 40;
						FLD_装备_追加_HP += 500;
						FLD_装备_追加_攻击 += 20;
						break;
					case 6:
						人物追加战力 += 25;
						FLD_装备_武功攻击力增加百分比 += 0.2;
						FLD_装备_追加_HP += 500;
						FLD_装备_追加_防御 += 40;
						FLD_装备_追加_攻击 += 20;
						break;
					}
					break;
				case 7:
					switch (num3)
					{
					case 2:
						人物追加战力 += 5;
						break;
					case 3:
						人物追加战力 += 10;
						break;
					case 4:
						人物追加战力 += 10;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						break;
					case 5:
						人物追加战力 += 10;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						FLD_装备_追加_HP += 400;
						FLD_装备_追加_MP += 1000;
						break;
					case 6:
						人物追加战力 += 25;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_HP += 400;
						FLD_装备_追加_防御 += 90;
						FLD_装备_追加_MP += 1000;
						break;
					}
					break;
				case 8:
					switch (num3)
					{
					case 2:
						人物追加战力 += 5;
						break;
					case 3:
						人物追加战力 += 10;
						break;
					case 4:
						人物追加战力 += 10;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						break;
					case 5:
						人物追加战力 += 10;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						FLD_装备_追加_HP += 150;
						break;
					case 6:
						人物追加战力 += 25;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_HP += 150;
						FLD_装备_追加_防御 += 40;
						FLD_装备_追加_攻击 += 50;
						break;
					}
					break;
				case 9:
					switch (num3)
					{
					case 2:
						人物追加战力 += 5;
						break;
					case 3:
						人物追加战力 += 10;
						break;
					case 4:
						人物追加战力 += 10;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						break;
					case 5:
						人物追加战力 += 10;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						FLD_装备_追加_HP += 150;
						break;
					case 6:
						人物追加战力 += 25;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_HP += 150;
						FLD_装备_追加_防御 += 90;
						break;
					}
					break;
				case 10:
					switch (num3)
					{
					case 2:
						人物追加战力 += 5;
						break;
					case 3:
						人物追加战力 += 12;
						break;
					case 4:
						人物追加战力 += 12;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						break;
					case 5:
						人物追加战力 += 15;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						FLD_装备_追加_HP += 150;
						break;
					case 6:
						人物追加战力 += 25;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_HP += 150;
						FLD_装备_追加_防御 += 90;
						break;
					}
					break;
				case 11:
					switch (num3)
					{
					case 2:
						人物追加战力 += 5;
						break;
					case 3:
						人物追加战力 += 12;
						break;
					case 4:
						人物追加战力 += 12;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						break;
					case 5:
						人物追加战力 += 15;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						FLD_装备_追加_HP += 150;
						break;
					case 6:
						人物追加战力 += 25;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_HP += 150;
						FLD_装备_追加_防御 += 90;
						break;
					}
					break;
				case 12:
					switch (num3)
					{
					case 2:
						人物追加战力 += 5;
						break;
					case 3:
						人物追加战力 += 12;
						break;
					case 4:
						人物追加战力 += 12;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						break;
					case 5:
						人物追加战力 += 15;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						FLD_装备_追加_HP += 150;
						break;
					case 6:
						人物追加战力 += 25;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_HP += 150;
						FLD_装备_追加_防御 += 90;
						break;
					}
					break;
				}
			}
			if (num4 > 0)
			{
				switch (Player_Job)
				{
				case 1:
					switch (num4)
					{
					case 2:
						人物追加战力 += 5;
						break;
					case 3:
						人物追加战力 += 10;
						break;
					case 4:
						人物追加战力 += 10;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 50;
						break;
					case 5:
						人物追加战力 += 10;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 50;
						FLD_装备_追加_HP += 600;
						break;
					case 6:
						人物追加战力 += 25;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_HP += 600;
						FLD_装备_追加_防御 += 50;
						FLD_装备_追加_攻击 += 50;
						break;
					}
					return;
				case 2:
				case 3:
					switch (num4)
					{
					case 2:
						人物追加战力 += 5;
						break;
					case 3:
						人物追加战力 += 10;
						break;
					case 4:
						人物追加战力 += 10;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 50;
						break;
					case 5:
						人物追加战力 += 10;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 50;
						FLD_装备_追加_HP += 600;
						break;
					case 6:
						人物追加战力 += 25;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_HP += 600;
						FLD_装备_追加_防御 += 100;
						break;
					}
					return;
				case 5:
					switch (num4)
					{
					case 2:
						人物追加战力 += 5;
						break;
					case 3:
						人物追加战力 += 12;
						break;
					case 4:
						人物追加战力 += 12;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 50;
						break;
					case 5:
						人物追加战力 += 12;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						FLD_装备_追加_HP += 500;
						FLD_装备_追加_MP += 1000;
						break;
					case 6:
						人物追加战力 += 25;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_HP += 500;
						FLD_装备_追加_防御 += 50;
						FLD_装备_追加_攻击 += 50;
						FLD_装备_追加_MP += 1000;
						break;
					}
					return;
				case 4:
				case 6:
					switch (num4)
					{
					case 2:
						人物追加战力 += 5;
						break;
					case 3:
						人物追加战力 += 12;
						break;
					case 4:
						人物追加战力 += 12;
						FLD_装备_武功攻击力增加百分比 += 0.2;
						FLD_装备_追加_防御 += 50;
						break;
					case 5:
						人物追加战力 += 12;
						FLD_装备_武功攻击力增加百分比 += 0.2;
						FLD_装备_追加_防御 += 50;
						FLD_装备_追加_HP += 600;
						break;
					case 6:
						人物追加战力 += 25;
						FLD_装备_武功攻击力增加百分比 += 0.4;
						FLD_装备_追加_HP += 600;
						FLD_装备_追加_防御 += 50;
						break;
					}
					return;
				case 7:
					switch (num4)
					{
					case 2:
						人物追加战力 += 5;
						break;
					case 3:
						人物追加战力 += 10;
						break;
					case 4:
						人物追加战力 += 10;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 50;
						break;
					case 5:
						人物追加战力 += 10;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 50;
						FLD_装备_追加_HP += 500;
						FLD_装备_追加_MP += 1000;
						break;
					case 6:
						人物追加战力 += 25;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_HP += 500;
						FLD_装备_追加_防御 += 100;
						FLD_装备_追加_MP += 1000;
						break;
					}
					return;
				case 8:
					switch (num4)
					{
					case 2:
						人物追加战力 += 5;
						break;
					case 3:
						人物追加战力 += 10;
						break;
					case 4:
						人物追加战力 += 10;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 50;
						break;
					case 5:
						人物追加战力 += 10;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 50;
						FLD_装备_追加_HP += 200;
						break;
					case 6:
						人物追加战力 += 25;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_HP += 200;
						FLD_装备_追加_防御 += 50;
						FLD_装备_追加_攻击 += 50;
						break;
					}
					return;
				case 9:
					switch (num4)
					{
					case 2:
						人物追加战力 += 5;
						break;
					case 3:
						人物追加战力 += 12;
						break;
					case 4:
						人物追加战力 += 10;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 50;
						break;
					case 5:
						人物追加战力 += 10;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 50;
						FLD_装备_追加_HP += 200;
						break;
					case 6:
						人物追加战力 += 25;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_HP += 200;
						FLD_装备_追加_防御 += 100;
						break;
					}
					return;
				case 10:
					switch (num4)
					{
					case 2:
						人物追加战力 += 5;
						break;
					case 3:
						人物追加战力 += 12;
						break;
					case 4:
						人物追加战力 += 12;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						break;
					case 5:
						人物追加战力 += 12;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						FLD_装备_追加_HP += 200;
						break;
					case 6:
						人物追加战力 += 25;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_HP += 200;
						FLD_装备_追加_防御 += 100;
						break;
					}
					return;
				case 11:
					switch (num4)
					{
					case 2:
						人物追加战力 += 5;
						break;
					case 3:
						人物追加战力 += 12;
						break;
					case 4:
						人物追加战力 += 12;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						break;
					case 5:
						人物追加战力 += 12;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						FLD_装备_追加_HP += 200;
						break;
					case 6:
						人物追加战力 += 25;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_HP += 200;
						FLD_装备_追加_防御 += 100;
						break;
					}
					return;
				case 12:
					switch (num4)
					{
					case 2:
						人物追加战力 += 5;
						break;
					case 3:
						人物追加战力 += 12;
						break;
					case 4:
						人物追加战力 += 12;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						break;
					case 5:
						人物追加战力 += 12;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_防御 += 40;
						FLD_装备_追加_HP += 200;
						break;
					case 6:
						人物追加战力 += 25;
						FLD_装备_武功攻击力增加百分比 += 0.1;
						FLD_装备_追加_HP += 200;
						FLD_装备_追加_防御 += 100;
						break;
					}
					return;
				}
			}
			if (num5 <= 0)
			{
				return;
			}
			switch (Player_Job)
			{
			case 1:
				switch (num5)
				{
				case 2:
					人物追加战力 += 5;
					break;
				case 3:
					人物追加战力 += 10;
					break;
				case 4:
					人物追加战力 += 10;
					FLD_装备_武功攻击力增加百分比 += 0.1;
					FLD_装备_追加_防御 += 50;
					break;
				case 5:
					人物追加战力 += 10;
					FLD_装备_武功攻击力增加百分比 += 0.1;
					FLD_装备_追加_防御 += 50;
					FLD_装备_追加_HP += 600;
					break;
				case 6:
					人物追加战力 += 25;
					FLD_装备_武功攻击力增加百分比 += 0.1;
					FLD_装备_追加_HP += 600;
					FLD_装备_追加_防御 += 50;
					FLD_装备_追加_攻击 += 50;
					break;
				}
				break;
			case 2:
			case 3:
				switch (num5)
				{
				case 2:
					人物追加战力 += 5;
					break;
				case 3:
					人物追加战力 += 10;
					break;
				case 4:
					人物追加战力 += 10;
					FLD_装备_武功攻击力增加百分比 += 0.1;
					FLD_装备_追加_防御 += 50;
					break;
				case 5:
					人物追加战力 += 10;
					FLD_装备_武功攻击力增加百分比 += 0.1;
					FLD_装备_追加_防御 += 50;
					FLD_装备_追加_HP += 600;
					break;
				case 6:
					人物追加战力 += 25;
					FLD_装备_武功攻击力增加百分比 += 0.1;
					FLD_装备_追加_HP += 600;
					FLD_装备_追加_防御 += 100;
					break;
				}
				break;
			case 5:
				switch (num5)
				{
				case 2:
					人物追加战力 += 5;
					break;
				case 3:
					人物追加战力 += 12;
					break;
				case 4:
					人物追加战力 += 12;
					FLD_装备_武功攻击力增加百分比 += 0.1;
					FLD_装备_追加_防御 += 50;
					break;
				case 5:
					人物追加战力 += 12;
					FLD_装备_武功攻击力增加百分比 += 0.1;
					FLD_装备_追加_防御 += 40;
					FLD_装备_追加_HP += 500;
					FLD_装备_追加_MP += 1000;
					break;
				case 6:
					人物追加战力 += 25;
					FLD_装备_武功攻击力增加百分比 += 0.1;
					FLD_装备_追加_HP += 500;
					FLD_装备_追加_防御 += 50;
					FLD_装备_追加_攻击 += 50;
					FLD_装备_追加_MP += 1000;
					break;
				}
				break;
			case 4:
			case 6:
				switch (num5)
				{
				case 2:
					人物追加战力 += 5;
					break;
				case 3:
					人物追加战力 += 12;
					break;
				case 4:
					人物追加战力 += 12;
					FLD_装备_武功攻击力增加百分比 += 0.2;
					FLD_装备_追加_防御 += 50;
					break;
				case 5:
					人物追加战力 += 12;
					FLD_装备_武功攻击力增加百分比 += 0.2;
					FLD_装备_追加_防御 += 50;
					FLD_装备_追加_HP += 600;
					break;
				case 6:
					人物追加战力 += 25;
					FLD_装备_武功攻击力增加百分比 += 0.4;
					FLD_装备_追加_HP += 600;
					FLD_装备_追加_防御 += 50;
					break;
				}
				break;
			case 7:
				switch (num5)
				{
				case 2:
					人物追加战力 += 5;
					break;
				case 3:
					人物追加战力 += 10;
					break;
				case 4:
					人物追加战力 += 10;
					FLD_装备_武功攻击力增加百分比 += 0.1;
					FLD_装备_追加_防御 += 50;
					break;
				case 5:
					人物追加战力 += 10;
					FLD_装备_武功攻击力增加百分比 += 0.1;
					FLD_装备_追加_防御 += 50;
					FLD_装备_追加_HP += 500;
					FLD_装备_追加_MP += 1000;
					break;
				case 6:
					人物追加战力 += 25;
					FLD_装备_武功攻击力增加百分比 += 0.1;
					FLD_装备_追加_HP += 500;
					FLD_装备_追加_防御 += 100;
					FLD_装备_追加_MP += 1000;
					break;
				}
				break;
			case 8:
				switch (num5)
				{
				case 2:
					人物追加战力 += 5;
					break;
				case 3:
					人物追加战力 += 10;
					break;
				case 4:
					人物追加战力 += 10;
					FLD_装备_武功攻击力增加百分比 += 0.1;
					FLD_装备_追加_防御 += 50;
					break;
				case 5:
					人物追加战力 += 10;
					FLD_装备_武功攻击力增加百分比 += 0.1;
					FLD_装备_追加_防御 += 50;
					FLD_装备_追加_HP += 200;
					break;
				case 6:
					人物追加战力 += 25;
					FLD_装备_武功攻击力增加百分比 += 0.1;
					FLD_装备_追加_HP += 200;
					FLD_装备_追加_防御 += 50;
					FLD_装备_追加_攻击 += 50;
					break;
				}
				break;
			case 9:
				switch (num5)
				{
				case 2:
					人物追加战力 += 5;
					break;
				case 3:
					人物追加战力 += 12;
					break;
				case 4:
					人物追加战力 += 10;
					FLD_装备_武功攻击力增加百分比 += 0.1;
					FLD_装备_追加_防御 += 50;
					break;
				case 5:
					人物追加战力 += 10;
					FLD_装备_武功攻击力增加百分比 += 0.1;
					FLD_装备_追加_防御 += 50;
					FLD_装备_追加_HP += 200;
					break;
				case 6:
					人物追加战力 += 25;
					FLD_装备_武功攻击力增加百分比 += 0.1;
					FLD_装备_追加_HP += 200;
					FLD_装备_追加_防御 += 100;
					break;
				}
				break;
			case 10:
				switch (num5)
				{
				case 2:
					人物追加战力 += 5;
					break;
				case 3:
					人物追加战力 += 12;
					break;
				case 4:
					人物追加战力 += 12;
					FLD_装备_武功攻击力增加百分比 += 0.1;
					FLD_装备_追加_防御 += 40;
					break;
				case 5:
					人物追加战力 += 12;
					FLD_装备_武功攻击力增加百分比 += 0.1;
					FLD_装备_追加_防御 += 40;
					FLD_装备_追加_HP += 200;
					break;
				case 6:
					人物追加战力 += 25;
					FLD_装备_武功攻击力增加百分比 += 0.1;
					FLD_装备_追加_HP += 200;
					FLD_装备_追加_防御 += 100;
					break;
				}
				break;
			case 11:
				switch (num5)
				{
				case 2:
					人物追加战力 += 5;
					break;
				case 3:
					人物追加战力 += 12;
					break;
				case 4:
					人物追加战力 += 12;
					FLD_装备_武功攻击力增加百分比 += 0.1;
					FLD_装备_追加_防御 += 40;
					break;
				case 5:
					人物追加战力 += 12;
					FLD_装备_武功攻击力增加百分比 += 0.1;
					FLD_装备_追加_防御 += 40;
					FLD_装备_追加_HP += 200;
					break;
				case 6:
					人物追加战力 += 25;
					FLD_装备_武功攻击力增加百分比 += 0.1;
					FLD_装备_追加_HP += 200;
					FLD_装备_追加_防御 += 100;
					break;
				}
				break;
			case 12:
				switch (num5)
				{
				case 2:
					人物追加战力 += 5;
					break;
				case 3:
					人物追加战力 += 12;
					break;
				case 4:
					人物追加战力 += 12;
					FLD_装备_武功攻击力增加百分比 += 0.1;
					FLD_装备_追加_防御 += 40;
					break;
				case 5:
					人物追加战力 += 12;
					FLD_装备_武功攻击力增加百分比 += 0.1;
					FLD_装备_追加_防御 += 40;
					FLD_装备_追加_HP += 200;
					break;
				case 6:
					人物追加战力 += 25;
					FLD_装备_武功攻击力增加百分比 += 0.1;
					FLD_装备_追加_HP += 200;
					FLD_装备_追加_防御 += 100;
					break;
				}
				break;
			}
		}

		public int 计算四神相克(int int_109, int int_110)
		{
			int result = 0;
			switch (int_109)
			{
			case 0:
				switch (int_110)
				{
				case 0:
					result = 0;
					break;
				case 1:
					result = -5;
					break;
				case 2:
					result = -5;
					break;
				case 3:
					result = -5;
					break;
				case 4:
					result = -5;
					break;
				}
				break;
			case 1:
				switch (int_110)
				{
				case 0:
					result = 5;
					break;
				case 1:
					result = 0;
					break;
				case 2:
					result = 15;
					break;
				case 3:
					result = 5;
					break;
				case 4:
					result = -15;
					break;
				}
				break;
			case 2:
				switch (int_110)
				{
				case 0:
					result = 5;
					break;
				case 1:
					result = -15;
					break;
				case 2:
					result = 0;
					break;
				case 3:
					result = 15;
					break;
				case 4:
					result = 5;
					break;
				}
				break;
			case 3:
				switch (int_110)
				{
				case 0:
					result = 5;
					break;
				case 1:
					result = 5;
					break;
				case 2:
					result = -15;
					break;
				case 3:
					result = 0;
					break;
				case 4:
					result = 15;
					break;
				}
				break;
			case 4:
				switch (int_110)
				{
				case 0:
					result = 5;
					break;
				case 1:
					result = 15;
					break;
				case 2:
					result = 5;
					break;
				case 3:
					result = -15;
					break;
				case 4:
					result = 0;
					break;
				}
				break;
			}
			return result;
		}

		public void 计算人物装备数据()
		{
			using (new Lock(thisLock, "计算人物装备数据"))
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				装备追加对怪防御 = 0;
				装备追加对怪攻击 = 0;
				武器攻击力 = 0;
				武器武功攻击力百分比 = 0.0;
				衣服防御力 = 0;
				衣服武功防御力百分比 = 0.0;
				FLD_装备_追加_降低百分比攻击 = 0.0;
				FLD_装备_追加_降低百分比防御 = 0.0;
				FLD_装备_追加_命中百分比 = 0.0;
				FLD_装备_追加_初始化愤怒概率百分比 = 0.0;
				FLD_装备_追加_中毒概率百分比 = 0.0;
				FLD_装备_降低_伤害值 = 0.0;
				FLD_装备_追加_回避百分比 = 0.0;
				FLD_装备_追加_愤怒 = 0;
				FLD_装备_追加_伤害值 = 0;
				FLD_装备_追加_升天三火龙之火 = 0.0;
				FLD_装备_追加_升天一护身罡气 = 0.0;
				FLD_装备_追加_升天一护身气甲 = 0.0;
				FLD_装备_追加_升天三怒意之火 = 0.0;
				FLD_装备_追加_升天二万物回春 = 0.0;
				FLD_装备_追加_升天二千钧压驼 = 0.0;
				FLD_装备_追加_升天二穷途末路 = 0.0;
				FLD_装备_追加_升天二三潭映月 = 0.0;
				FLD_装备_追加_升天二顺水推舟 = 0.0;
				FLD_装备_追加_升天二天地同寿 = 0.0;
				FLD_装备_追加_升天二天魔护体 = 0.0;
				FLD_装备_追加_升天二以退为进 = 0.0;
				FLD_装备_追加_升天三火凤临朝 = 0.0;
				FLD_装备_追加_升天三明镜止水 = 0.0;
				FLD_装备_追加_升天三无情打击 = 0.0;
				FLD_装备_追加_升天三内息行心 = 0.0;
				FLD_装备_追加_升天三天外三矢 = 0.0;
				FLD_装备_追加_升天三以柔克刚 = 0.0;
				FLD_装备_追加_升天三子夜秋歌 = 0.0;
				FLD_装备_追加_升天四哀鸿遍野 = 0.0;
				FLD_装备_追加_升天四毒蛇出洞 = 0.0;
				FLD_装备_追加_升天四红月狂风 = 0.0;
				FLD_装备_追加_升天四烈日炎炎 = 0.0;
				FLD_装备_追加_升天四满月狂风 = 0.0;
				FLD_装备_追加_升天四望梅添花 = 0.0;
				FLD_装备_追加_升天四悬丝诊脉 = 0.0;
				FLD_装备_追加_升天四长虹贯天 = 0.0;
				FLD_装备_追加_升天一百变神行 = 0.0;
				FLD_装备_追加_升天一遁出逆境 = 0.0;
				FLD_装备_追加_升天一飞花点翠 = 0.0;
				FLD_装备_追加_升天一行风弄舞 = 0.0;
				FLD_装备_追加_升天一金钟罡气 = 0.0;
				FLD_装备_追加_升天一绝影射魂 = 0.0;
				FLD_装备_追加_升天一狂风天意 = 0.0;
				FLD_装备_追加_升天一力劈华山 = 0.0;
				FLD_装备_追加_升天一破甲刺魂 = 0.0;
				FLD_装备_追加_升天一夜魔缠身 = 0.0;
				FLD_装备_追加_升天一运气行心 = 0.0;
				FLD_装备_追加_升天一运气疗伤 = 0.0;
				FLD_装备_追加_升天一长虹贯日 = 0.0;
				FLD_装备_追加_升天一正本培源 = 0.0;
				FLD_装备_追加_升天一夺命连环 = 0.0;
				FLD_装备_追加_升天一电光石火 = 0.0;
				FLD_装备_追加_升天一精益求精 = 0.0;
				FLD_装备_追加_合成成功率百分比 = 0.0;
				FLD_装备_追加_获得游戏币百分比 = 0.0;
				FLD_装备_武功攻击力增加百分比 = 0.0;
				FLD_装备_武功防御力增加百分比 = 0.0;
				FLD_装备_追加_障力 = 0;
				FLD_装备_武功防御力 = 0.0;
				FLD_装备_追加_攻击 = 0;
				FLD_装备_追加_防御 = 0;
				FLD_装备_追加_防御New = 0;
				FLD_装备_追加_命中 = 0;
				FLD_装备_追加_回避 = 0;
				FLD_装备_追加_气功 = 0;
				FLD_装备_追加_经验百分比 = 0.0;
				FLD_装备_追加_死亡损失经验减少 = 0.0;
				FLD_装备_追加_气功_0 = 0.0;
				FLD_装备_追加_气功_1 = 0.0;
				FLD_装备_追加_气功_2 = 0.0;
				FLD_装备_追加_气功_3 = 0.0;
				FLD_装备_追加_气功_4 = 0.0;
				FLD_装备_追加_气功_5 = 0.0;
				FLD_装备_追加_气功_6 = 0.0;
				FLD_装备_追加_气功_7 = 0.0;
				FLD_装备_追加_气功_8 = 0.0;
				FLD_装备_追加_气功_9 = 0.0;
				FLD_装备_追加_气功_10 = 0.0;
				FLD_装备_追加_气功_11 = 0.0;
				中级附魂_复仇 = 0;
				中级附魂_吸魂 = 0;
				中级附魂_奇缘 = 0;
				中级附魂_愤怒 = 0;
				中级附魂_移星 = 0;
				中级附魂_护体 = 0;
				中级附魂_混元 = 0;
				FLD_装备_追加_心 = 0;
				FLD_装备_追加_体 = 0;
				FLD_装备_追加_力 = 0;
				FLD_装备_追加_身 = 0;
				FLD_装备_追加_觉醒 = 0;
				FLD_装备_追加_HP = 0;
				FLD_装备_追加_障力恢复量 = 0;
				FLD_装备_追加_MP = 0;
				锁定人物几率 = 0;
				人物追加战力 = 0;
				FLD_装备_追加_武功回避 = 0;
				FLD_装备_追加_武功命中 = 0;
				FLD_装备_增加对方异常 = 0;
				FLD_装备_增加异常 = 0;
				减免对方伤害 = 0;
				if (装备栏已穿装备[15].Get物品ID == 1000001184L)
				{
					if (Player_Job_leve < 6)
					{
						FLD_灵宠_追加_经验百分比 = 3.0;
						FLD_灵宠_追加_历练百分比 += 3.0;
					}
					else if (Player_Job_leve != 6 && Player_Job_leve != 7)
					{
						if (Player_Job_leve == 8)
						{
							FLD_灵宠_追加_经验百分比 = 1.5;
						}
						else if (Player_Job_leve == 9)
						{
							FLD_灵宠_追加_经验百分比 = 1.0;
						}
					}
					else
					{
						FLD_灵宠_追加_经验百分比 = 2.0;
					}
				}
				else if (装备栏已穿装备[15].Get物品ID == 1000001276L)
				{
					if (Player_Job_leve < 6)
					{
						FLD_灵宠_追加_经验百分比 = 3.0;
						FLD_灵宠_追加_历练百分比 += 3.0;
					}
					else if (Player_Job_leve != 6 && Player_Job_leve != 7)
					{
						if (Player_Job_leve == 8)
						{
							FLD_灵宠_追加_历练百分比 += 1.5;
							FLD_灵宠_追加_经验百分比 = 1.5;
						}
						else if (Player_Job_leve == 9)
						{
							FLD_灵宠_追加_经验百分比 = 1.0;
							FLD_灵宠_追加_历练百分比 += 1.0;
						}
						else if (Player_Job_leve == 10)
						{
							FLD_灵宠_追加_经验百分比 = 0.5;
							FLD_灵宠_追加_历练百分比 += 0.5;
						}
					}
					else
					{
						FLD_灵宠_追加_经验百分比 = 2.0;
						FLD_灵宠_追加_历练百分比 += 2.0;
					}
				}
				else
				{
					FLD_灵宠_追加_经验百分比 = 0.0;
					FLD_灵宠_追加_历练百分比 = 0.0;
				}
				if (装备栏已穿装备[15].Get物品ID == 1000001184L)
				{
					if (Player_Job_leve == 9)
					{
						装备追加对怪防御 += 50;
					}
				}
				else if (装备栏已穿装备[15].Get物品ID == 1000001276L)
				{
					if (Player_Job_leve == 9)
					{
						装备追加对怪防御 += 100;
						装备追加对怪攻击 += 100;
					}
					else if (Player_Job_leve == 10)
					{
						装备追加对怪防御 += 200;
						装备追加对怪攻击 += 200;
					}
				}
				else
				{
					装备栏已穿装备[15].得到物品属性方法();
					FLD_装备_追加_攻击 += (装备栏已穿装备[15].物品攻击力 + 装备栏已穿装备[15].物品攻击力MAX) / 2;
					FLD_装备_追加_防御 += 装备栏已穿装备[15].物品防御力;
					FLD_装备_追加_防御New += 装备栏已穿装备[15].物品防御力New;
					FLD_装备_追加_HP += 装备栏已穿装备[15].物品属性_生命力增加;
					装备追加对怪攻击 = 装备栏已穿装备[15].物品对怪攻击力;
					装备追加对怪防御 = 装备栏已穿装备[15].物品对怪防御力;
				}
				for (int i = 0; i <= 15; i++)
				{
					ItmeClass value;
					if (装备栏已穿装备[i].Get物品ID != 0L && World.Itme.TryGetValue(Buffer.ToInt32(装备栏已穿装备[i].物品ID, 0), out value) && (value.FLD_RESIDE2 != 13 || Player_Job == 4 || Player_Job == 11))
					{
						if (value.FLD_NJ > 0 && 装备栏已穿装备[i].FLD_FJ_NJ <= 0)
						{
							装备栏已穿装备[i].FLD_FJ_NJ = 0;
						}
						else
						{
							if (value.FLD_NJ > 0)
							{
								num3++;
							}
							if ((value.FLD_RESIDE2 != 14 || 检查门甲条件((int)装备栏已穿装备[i].Get物品ID)) && Player_Level >= value.FLD_LEVEL && Player_Job_leve >= value.FLD_JOB_LEVEL)
							{
								if (value.FLD_RESIDE1 != 0)
								{
									if (value.FLD_RESIDE2 == 13)
									{
										if (Player_Job == 11)
										{
											if (value.FLD_PID == 1000000992 || value.FLD_PID == 1000000993 || value.FLD_PID == 1000000994 || value.FLD_PID == 1000000995)
											{
												continue;
											}
										}
										else if (Player_Job == 4 && (value.FLD_PID == 1000001536 || value.FLD_PID == 1000001537 || value.FLD_PID == 1000001538 || value.FLD_PID == 1000001539 || value.FLD_PID == 1000001540))
										{
											continue;
										}
									}
									else if (value.FLD_RESIDE1 != Player_Job)
									{
										continue;
									}
								}
								if (value.FLD_SEX == 0 || Player_Sex == value.FLD_SEX)
								{
									FLD_装备_追加_觉醒 = 0;
									装备栏已穿装备[i].得到物品属性方法(FLD_装备_追加_防具_强化, 触发属性提升);
									if (value.FLD_PID == 700022)
									{
										装备栏已穿装备[i].FLD_MAGIC1 = 70000013;
										装备栏已穿装备[i].FLD_MAGIC2 = 10000040;
									}
									FLD_装备_追加_攻击 += (装备栏已穿装备[i].物品攻击力 + 装备栏已穿装备[i].物品攻击力MAX) / 2;
									FLD_装备_追加_防御 += 装备栏已穿装备[i].物品防御力;
									FLD_装备_追加_防御New += 装备栏已穿装备[i].物品防御力New;
									if (i == 3)
									{
										武器攻击力 += (装备栏已穿装备[i].物品攻击力New + 装备栏已穿装备[i].物品攻击力MaxNew) / 2;
									}
									if (i == 0)
									{
										衣服防御力 += 装备栏已穿装备[i].物品防御力New;
									}
									FLD_装备_追加_降低百分比攻击 += 装备栏已穿装备[i].物品属性_降低百分比攻击;
									FLD_装备_追加_降低百分比防御 += 装备栏已穿装备[i].物品属性_降低百分比防御;
									FLD_装备_追加_愤怒 += 装备栏已穿装备[i].物品属性_愤怒值增加;
									FLD_装备_追加_初始化愤怒概率百分比 += 装备栏已穿装备[i].物品属性_初始化愤怒概率百分比;
									FLD_装备_追加_中毒概率百分比 += 装备栏已穿装备[i].物品属性_追加中毒几率百分比;
									FLD_装备_追加_命中 += 装备栏已穿装备[i].物品属性_命中率增加;
									FLD_装备_追加_命中百分比 += 装备栏已穿装备[i].物品属性_增加百分比命中;
									FLD_装备_追加_回避 += 装备栏已穿装备[i].物品属性_回避率增加;
									FLD_装备_追加_回避百分比 += 装备栏已穿装备[i].物品属性_增加百分比回避;
									FLD_装备_追加_伤害值 += 装备栏已穿装备[i].物品属性_追加伤害值;
									FLD_装备_降低_伤害值 += 装备栏已穿装备[i].物品属性_降低伤害值;
									if (判断PVP装备强化((int)装备栏已穿装备[i].Get物品ID))
									{
										if (装备栏已穿装备[0].物品属性强 + FLD_装备_追加_防具_强化 >= 13)
										{
											FLD_装备_追加_HP += 260;
										}
										else if (装备栏已穿装备[4].物品属性强 + FLD_装备_追加_防具_强化 >= 13)
										{
											FLD_装备_追加_HP += 260;
										}
										else if (装备栏已穿装备[1].物品属性强 + FLD_装备_追加_防具_强化 >= 13)
										{
											FLD_装备_追加_HP += 260;
										}
										else if (装备栏已穿装备[2].物品属性强 + FLD_装备_追加_防具_强化 >= 13)
										{
											FLD_装备_追加_HP += 260;
										}
										else if (装备栏已穿装备[5].物品属性强 + FLD_装备_追加_防具_强化 >= 13)
										{
											FLD_装备_追加_HP += 260;
										}
									}
									if (装备栏已穿装备[i].物品属性_武功防御力增加 > 0)
									{
										FLD_装备_武功防御力 += 装备栏已穿装备[i].物品属性_武功防御力增加;
										FLD_装备_武功防御力增加百分比 += (double)装备栏已穿装备[i].物品属性_武功防御力增加New * (1.0 - World.武功防降低百分比) * 0.01;
										if (i == 0)
										{
											衣服武功防御力百分比 += FLD_装备_武功防御力增加百分比;
										}
									}
									if (装备栏已穿装备[i].物品属性_武功攻击力 > 0)
									{
										FLD_装备_武功攻击力增加百分比 += (double)装备栏已穿装备[i].物品属性_武功攻击力New * World.武功攻击力百分比;
										if (i == 3)
										{
											武器武功攻击力百分比 += FLD_装备_武功攻击力增加百分比;
										}
									}
									FLD_装备_追加_气功 += 装备栏已穿装备[i].物品属性_全部气功等级增加;
									FLD_装备_追加_HP += 装备栏已穿装备[i].物品属性_生命力增加;
									FLD_装备_追加_MP += 装备栏已穿装备[i].物品属性_内功力增加;
									FLD_装备_追加_障力恢复量 += 装备栏已穿装备[i].物品属性_障力恢复量增加;
									装备追加对怪防御 += 装备栏已穿装备[i].物品对怪防御力;
									装备追加对怪攻击 += 装备栏已穿装备[i].物品对怪攻击力;
									if (Player_Job == 11)
									{
										FLD_装备_追加_障力 += 装备栏已穿装备[i].物品属性_障力增加;
									}
									else
									{
										FLD_装备_追加_障力 = 0;
									}
									if (装备栏已穿装备[i].FLD_FJ_中级附魂 <= 22 && 装备栏已穿装备[i].FLD_FJ_中级附魂 >= 21)
									{
										if (装备栏已穿装备[i].FLD_FJ_觉醒 > 0)
										{
											FLD_装备_追加_觉醒 = 装备栏已穿装备[i].FLD_FJ_中级附魂 - 20;
										}
									}
									else if (装备栏已穿装备[i].FLD_FJ_中级附魂 <= 20 && 装备栏已穿装备[i].FLD_FJ_中级附魂 >= 16)
									{
										FLD_装备_追加_身 = (int)((double)(装备栏已穿装备[i].FLD_FJ_中级附魂 - 15) * 0.01 * (double)FLD_身);
										FLD_装备_追加_命中 += FLD_装备_追加_身;
									}
									else if (装备栏已穿装备[i].FLD_FJ_中级附魂 <= 15 && 装备栏已穿装备[i].FLD_FJ_中级附魂 >= 11)
									{
										FLD_装备_追加_力 = (int)((double)(装备栏已穿装备[i].FLD_FJ_中级附魂 - 10) * 0.01 * (double)FLD_力);
										FLD_装备_追加_防御 += FLD_装备_追加_力;
									}
									else if (装备栏已穿装备[i].FLD_FJ_中级附魂 <= 10 && 装备栏已穿装备[i].FLD_FJ_中级附魂 >= 6)
									{
										FLD_装备_追加_体 = (int)((double)(装备栏已穿装备[i].FLD_FJ_中级附魂 - 5) * 0.01 * (double)FLD_体);
										FLD_装备_追加_攻击 += FLD_装备_追加_体;
									}
									else if (装备栏已穿装备[i].FLD_FJ_中级附魂 <= 5 && 装备栏已穿装备[i].FLD_FJ_中级附魂 >= 1)
									{
										FLD_装备_追加_心 = (int)((double)装备栏已穿装备[i].FLD_FJ_中级附魂 * 0.01 * (double)FLD_心);
										FLD_装备_追加_回避 += FLD_装备_追加_心;
									}
									if (装备栏已穿装备[i].FLD_FJ_中级附魂 <= 51 && 装备栏已穿装备[i].FLD_FJ_中级附魂 >= 47)
									{
										中级附魂_混元 = 装备栏已穿装备[i].FLD_FJ_中级附魂 - 46;
									}
									else if (装备栏已穿装备[i].FLD_FJ_中级附魂 <= 46 && 装备栏已穿装备[i].FLD_FJ_中级附魂 >= 42)
									{
										中级附魂_护体 = 装备栏已穿装备[i].FLD_FJ_中级附魂 - 41;
									}
									else if (装备栏已穿装备[i].FLD_FJ_中级附魂 <= 41 && 装备栏已穿装备[i].FLD_FJ_中级附魂 >= 37)
									{
										中级附魂_移星 = 装备栏已穿装备[i].FLD_FJ_中级附魂 - 36;
									}
									else if (装备栏已穿装备[i].FLD_FJ_中级附魂 <= 36 && 装备栏已穿装备[i].FLD_FJ_中级附魂 >= 34)
									{
										中级附魂_愤怒 = 装备栏已穿装备[i].FLD_FJ_中级附魂 - 33;
									}
									else if (装备栏已穿装备[i].FLD_FJ_中级附魂 <= 33 && 装备栏已穿装备[i].FLD_FJ_中级附魂 >= 31)
									{
										中级附魂_奇缘 = 装备栏已穿装备[i].FLD_FJ_中级附魂 - 30;
									}
									else if (装备栏已穿装备[i].FLD_FJ_中级附魂 <= 30 && 装备栏已穿装备[i].FLD_FJ_中级附魂 >= 28)
									{
										中级附魂_吸魂 = 装备栏已穿装备[i].FLD_FJ_中级附魂 - 27;
									}
									else if (装备栏已穿装备[i].FLD_FJ_中级附魂 <= 27 && 装备栏已穿装备[i].FLD_FJ_中级附魂 >= 23)
									{
										中级附魂_复仇 = 装备栏已穿装备[i].FLD_FJ_中级附魂 - 22;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 12)
									{
										检查五行披风属性符(装备栏已穿装备[i]);
										if (装备栏已穿装备[i].Get物品ID == 26900772L || 装备栏已穿装备[i].Get物品ID == 16900772L)
										{
											num3++;
										}
										FLD_装备_追加_命中百分比 += 装备栏已穿装备[i].物品属性_增加百分比命中;
										FLD_装备_追加_回避 += 装备栏已穿装备[i].物品属性_回避率增加;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 4 && 装备栏已穿装备[i].物品属性强 == 8)
									{
										FLD_装备_追加_攻击 += World.武器8阶段添加攻击;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 4 && 装备栏已穿装备[i].物品属性强 == 9)
									{
										FLD_装备_追加_攻击 += World.武器9阶段添加攻击;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 4 && 装备栏已穿装备[i].物品属性强 == 10)
									{
										FLD_装备_追加_攻击 += World.武器10阶段添加攻击;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 4 && 装备栏已穿装备[i].物品属性强 == 11)
									{
										FLD_装备_追加_攻击 += World.武器11阶段添加攻击;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 4 && 装备栏已穿装备[i].物品属性强 == 12)
									{
										FLD_装备_追加_攻击 += World.武器12阶段添加攻击;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 4 && 装备栏已穿装备[i].物品属性强 == 13)
									{
										FLD_装备_追加_攻击 += World.武器13阶段添加攻击;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 4 && 装备栏已穿装备[i].物品属性强 == 14)
									{
										FLD_装备_追加_攻击 += World.武器14阶段添加攻击;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 4 && 装备栏已穿装备[i].物品属性强 == 15)
									{
										FLD_装备_追加_攻击 += World.武器15阶段添加攻击;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 1 && 装备栏已穿装备[i].物品属性强 == 8)
									{
										FLD_装备_追加_防御 += World.衣服8阶段添加防御;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 1 && 装备栏已穿装备[i].物品属性强 == 9)
									{
										FLD_装备_追加_防御 += World.衣服9阶段添加防御;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 1 && 装备栏已穿装备[i].物品属性强 == 10)
									{
										FLD_装备_追加_防御 += World.衣服10阶段添加防御;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 1 && 装备栏已穿装备[i].物品属性强 == 11)
									{
										FLD_装备_追加_防御 += World.衣服11阶段添加防御;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 1 && 装备栏已穿装备[i].物品属性强 == 12)
									{
										FLD_装备_追加_防御 += World.衣服12阶段添加防御;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 1 && 装备栏已穿装备[i].物品属性强 == 13)
									{
										FLD_装备_追加_防御 += World.衣服13阶段添加防御;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 1 && 装备栏已穿装备[i].物品属性强 == 14)
									{
										FLD_装备_追加_防御 += World.衣服14阶段添加防御;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 1 && 装备栏已穿装备[i].物品属性强 == 15)
									{
										FLD_装备_追加_防御 += World.衣服15阶段添加防御;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 5 && 装备栏已穿装备[i].物品属性强 == 8)
									{
										FLD_装备_追加_防御 += World.鞋子8阶段添加防御;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 5 && 装备栏已穿装备[i].物品属性强 == 9)
									{
										FLD_装备_追加_防御 += World.鞋子9阶段添加防御;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 5 && 装备栏已穿装备[i].物品属性强 == 10)
									{
										FLD_装备_追加_防御 += World.鞋子10阶段添加防御;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 5 && 装备栏已穿装备[i].物品属性强 == 11)
									{
										FLD_装备_追加_防御 += World.鞋子11阶段添加防御;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 5 && 装备栏已穿装备[i].物品属性强 == 12)
									{
										FLD_装备_追加_防御 += World.鞋子12阶段添加防御;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 5 && 装备栏已穿装备[i].物品属性强 == 13)
									{
										FLD_装备_追加_防御 += World.鞋子13阶段添加防御;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 5 && 装备栏已穿装备[i].物品属性强 == 14)
									{
										FLD_装备_追加_防御 += World.鞋子14阶段添加防御;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 5 && 装备栏已穿装备[i].物品属性强 == 15)
									{
										FLD_装备_追加_防御 += World.鞋子15阶段添加防御;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 2 && 装备栏已穿装备[i].物品属性强 == 8)
									{
										FLD_装备_追加_防御 += World.护手8阶段添加防御;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 2 && 装备栏已穿装备[i].物品属性强 == 9)
									{
										FLD_装备_追加_防御 += World.护手9阶段添加防御;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 2 && 装备栏已穿装备[i].物品属性强 == 10)
									{
										FLD_装备_追加_防御 += World.护手10阶段添加防御;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 2 && 装备栏已穿装备[i].物品属性强 == 11)
									{
										FLD_装备_追加_防御 += World.护手11阶段添加防御;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 2 && 装备栏已穿装备[i].物品属性强 == 12)
									{
										FLD_装备_追加_防御 += World.护手10阶段添加防御;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 2 && 装备栏已穿装备[i].物品属性强 == 13)
									{
										FLD_装备_追加_防御 += World.护手13阶段添加防御;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 2 && 装备栏已穿装备[i].物品属性强 == 14)
									{
										FLD_装备_追加_防御 += World.护手14阶段添加防御;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 2 && 装备栏已穿装备[i].物品属性强 == 15)
									{
										FLD_装备_追加_防御 += World.护手15阶段添加防御;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 6 && 装备栏已穿装备[i].物品属性强 == 8)
									{
										FLD_装备_追加_防御 += World.内甲8阶段添加防御;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 6 && 装备栏已穿装备[i].物品属性强 == 9)
									{
										FLD_装备_追加_防御 += World.内甲9阶段添加防御;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 6 && 装备栏已穿装备[i].物品属性强 == 10)
									{
										FLD_装备_追加_防御 += World.内甲10阶段添加防御;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 6 && 装备栏已穿装备[i].物品属性强 == 11)
									{
										FLD_装备_追加_防御 += World.内甲11阶段添加防御;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 6 && 装备栏已穿装备[i].物品属性强 == 12)
									{
										FLD_装备_追加_防御 += World.内甲12阶段添加防御;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 6 && 装备栏已穿装备[i].物品属性强 == 13)
									{
										FLD_装备_追加_防御 += World.内甲13阶段添加防御;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 6 && 装备栏已穿装备[i].物品属性强 == 14)
									{
										FLD_装备_追加_防御 += World.内甲14阶段添加防御;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 6 && 装备栏已穿装备[i].物品属性强 == 15)
									{
										FLD_装备_追加_防御 += World.内甲15阶段添加防御;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 14)
									{
										int num4 = BitConverter.ToInt32(装备栏已穿装备[i].物品ID, 0);
										if (装备栏已穿装备[i].FLD_强化数量 > 9)
										{
											人物追加战力 += 装备栏已穿装备[i].FLD_强化数量 * 3;
											FLD_装备_追加_HP += 60;
											if (num4 > 900104)
											{
												FLD_装备_武功攻击力增加百分比 += 0.1;
											}
										}
										else if (装备栏已穿装备[i].FLD_强化数量 > 5)
										{
											人物追加战力 += 装备栏已穿装备[i].FLD_强化数量 * 2;
											switch (装备栏已穿装备[i].FLD_强化数量)
											{
											case 6:
												FLD_装备_追加_HP += 10;
												break;
											case 7:
												FLD_装备_追加_HP += 20;
												break;
											case 8:
												FLD_装备_追加_HP += 30;
												break;
											case 9:
												FLD_装备_追加_HP += 40;
												break;
											case 10:
												FLD_装备_追加_HP += 60;
												break;
											}
										}
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 7)
									{
										FLD_装备_追加_防御 += 装备栏已穿装备[i].FLD_强化数量 * 3;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 8)
									{
										FLD_装备_追加_HP += 装备栏已穿装备[i].FLD_强化数量 * 10;
									}
									if (装备栏已穿装备[i].FLD_RESIDE2 == 10)
									{
										FLD_装备_追加_攻击 += 装备栏已穿装备[i].FLD_强化数量 * 5;
									}
									if (装备栏已穿装备[i].FLD_强化数量 > 5 && 装备栏已穿装备[i].FLD_RESIDE2 != 6)
									{
										int num5 = 装备栏已穿装备[i].FLD_强化数量 + FLD_装备_追加_防具_强化;
										if (装备栏已穿装备[i].FLD_LEVEL < 60)
										{
											FLD_装备_追加_HP += (num5 - 5) * 5;
										}
										else
										{
											减免对方伤害 += (num5 - 5) * 5;
										}
									}
									int fLD_强化数量 = 装备栏已穿装备[i].FLD_强化数量;
									switch (value.FLD_RESIDE2)
									{
									case 1:
										if (FLD_装备_追加_武器_强化 > 0 && 装备栏已穿装备[i].物品属性强 + FLD_装备_追加_武器_强化 > 15)
										{
											FLD_装备_增加对方异常 = 装备栏已穿装备[i].物品属性强 + FLD_装备_追加_武器_强化 - 10;
										}
										break;
									case 4:
									{
										long get物品ID = 装备栏已穿装备[i].Get物品ID;
										if (FLD_装备_追加_武器_强化 > 0)
										{
											int num6 = FLD_装备_追加_武器_强化 * 25;
											FLD_装备_追加_攻击 += num6;
											武器攻击力 += num6;
											if (装备栏已穿装备[i].物品属性阶段类型 != 0 && 装备栏已穿装备[i].物品属性阶段数 > 0)
											{
												int num7 = FLD_装备_追加_武器_强化 + FLD_夫妻辅助_追加_武器_属性 + FLD_结婚礼物_追加_属性石;
												switch (装备栏已穿装备[i].物品属性阶段类型)
												{
												case 1:
													FLD_装备_追加_降低百分比防御 += (double)num7 * 0.005;
													break;
												case 2:
													FLD_装备_追加_初始化愤怒概率百分比 += num7;
													break;
												case 3:
													FLD_装备_追加_命中百分比 += (double)num7 * 0.01;
													break;
												case 4:
													FLD_装备_武功攻击力增加百分比 += (double)num7 * 0.5 * 0.01;
													break;
												case 5:
													FLD_装备_追加_伤害值 += num7 * 3;
													break;
												case 6:
													FLD_装备_追加_中毒概率百分比 += (double)num7 * 0.01;
													FLD_装备_追加_攻击 += num7 * 3;
													break;
												}
											}
											Dictionary<int, Itimesx> dictionary = new Dictionary<int, Itimesx>();
											dictionary.Add(0, 装备栏已穿装备[i].属性1);
											dictionary.Add(1, 装备栏已穿装备[i].属性2);
											dictionary.Add(2, 装备栏已穿装备[i].属性3);
											dictionary.Add(3, 装备栏已穿装备[i].属性4);
											for (int j = 0; j < 4; j++)
											{
												if (dictionary[j].属性类型 != 0)
												{
													switch (dictionary[j].属性类型)
													{
													case 3:
													{
														double num11 = 0.0;
														switch (fLD_强化数量)
														{
														case 5:
															if (j >= 2)
															{
																continue;
															}
															num11 = 1.0;
															break;
														case 6:
															num11 = 1.0;
															break;
														case 7:
															if (j >= 3)
															{
																continue;
															}
															num11 = 2.0;
															break;
														case 8:
															num11 = 2.0;
															break;
														case 9:
															num11 = 2.0;
															break;
														case 10:
															num11 = 2.0;
															break;
														case 11:
															num11 = 15.0;
															break;
														case 12:
															num11 = 15.0;
															break;
														case 13:
															num11 = 1.0;
															break;
														}
														FLD_装备_追加_HP += (int)num11;
														break;
													}
													case 1:
													{
														double num9 = 0.0;
														switch (fLD_强化数量)
														{
														case 5:
															if (j >= 2)
															{
																continue;
															}
															num9 = 1.0;
															break;
														case 6:
															num9 = 1.0;
															break;
														case 7:
															if (j >= 3)
															{
																continue;
															}
															num9 = 2.0;
															break;
														case 8:
															num9 = 2.0;
															break;
														case 9:
															num9 = 2.0;
															break;
														case 10:
															num9 = 2.0;
															break;
														case 11:
															num9 = 8.0;
															break;
														case 12:
															num9 = 8.0;
															break;
														case 13:
															num9 = 1.0;
															break;
														}
														FLD_装备_追加_攻击 += (int)num9;
														break;
													}
													case 10:
													{
														double num10 = 0.0;
														switch (fLD_强化数量)
														{
														case 5:
															if (j >= 2)
															{
																continue;
															}
															num10 = 1.0;
															break;
														case 6:
															num10 = 1.0;
															break;
														case 7:
															if (j >= 3)
															{
																continue;
															}
															num10 = 2.0;
															break;
														case 8:
															num10 = 2.0;
															break;
														case 9:
															num10 = 2.0;
															break;
														case 10:
															num10 = 2.0;
															break;
														case 11:
															num10 = 15.0;
															break;
														case 12:
															num10 = 15.0;
															break;
														case 13:
															num10 = 1.0;
															break;
														}
														FLD_装备_追加_伤害值 += (int)num10;
														break;
													}
													case 7:
													{
														double num8 = 0.0;
														switch (fLD_强化数量)
														{
														case 5:
															if (j >= 2)
															{
																continue;
															}
															num8 = 1.0;
															break;
														case 6:
															num8 = 1.0;
															break;
														case 7:
															if (j >= 3)
															{
																continue;
															}
															num8 = 2.0;
															break;
														case 8:
															num8 = 2.0;
															break;
														case 9:
															num8 = 2.0;
															break;
														case 10:
															num8 = 2.0;
															break;
														case 11:
															num8 = 11.0;
															break;
														case 12:
															num8 = 11.0;
															break;
														case 13:
															num8 = 1.0;
															break;
														}
														FLD_装备_武功攻击力增加百分比 += num8 * World.武功攻击力百分比;
														break;
													}
													}
												}
											}
											if (fLD_强化数量 >= 14)
											{
												锁定人物几率 = 10;
											}
											switch (fLD_强化数量)
											{
											case 8:
											{
												int num12 = ++FLD_装备_追加_气功;
												break;
											}
											case 9:
												FLD_装备_追加_气功 += 2;
												break;
											case 10:
												FLD_装备_追加_气功 += 2;
												break;
											case 11:
												FLD_装备_追加_气功 += 2;
												break;
											case 12:
											{
												int num12 = ++FLD_装备_追加_气功;
												break;
											}
											}
											dictionary.Clear();
										}
										FLD_装备_追加_命中 += 50;
										if (FLD_装备_追加_觉醒 > 0)
										{
											int num13 = FLD_装备_追加_觉醒 * 8;
											FLD_装备_追加_攻击 += num13;
											武器攻击力 += num13;
										}
										if (get物品ID != 101200001L && get物品ID != 201200001L && get物品ID != 301200001L && get物品ID != 401200001L && get物品ID != 501200001L && get物品ID != 701200001L && get物品ID != 801200001L && get物品ID != 101220001L && get物品ID != 201220001L && get物品ID != 301220001L && get物品ID != 401220001L && get物品ID != 501220001L && get物品ID != 701220001L && get物品ID != 801220001L)
										{
											if (FLD_装备_追加_武器_强化 > 0 && 装备栏已穿装备[i].物品属性强 + FLD_装备_追加_武器_强化 > 15)
											{
												FLD_装备_增加异常 = 装备栏已穿装备[i].物品属性强 + FLD_装备_追加_武器_强化 - 10;
											}
										}
										else
										{
											FLD_装备_追加_气功 += 3;
											FLD_装备_追加_经验百分比 += 0.5;
										}
										break;
									}
									case 2:
									case 5:
										if (FLD_装备_追加_防具_强化 > 0)
										{
											if (fLD_强化数量 <= 6)
											{
												int num14 = FLD_装备_追加_防具_强化 * 3;
												FLD_装备_追加_防御 += num14;
												FLD_装备_追加_防御New += num14;
												if (value.FLD_RESIDE2 == 1)
												{
													衣服防御力 += num14;
												}
												if (value.FLD_LEVEL < 60)
												{
													FLD_装备_追加_HP += FLD_装备_追加_防具_强化 * 5;
												}
												else
												{
													FLD_装备_降低_伤害值 += FLD_装备_追加_防具_强化 * 5;
												}
											}
											else
											{
												if (value.FLD_RESIDE2 == 1)
												{
													int num15 = (fLD_强化数量 - 6) * 6;
													FLD_装备_追加_防御 += num15;
													FLD_装备_追加_防御New += num15;
													衣服防御力 += num15;
												}
												else
												{
													FLD_装备_追加_防御 += FLD_装备_追加_防具_强化 * 6;
													FLD_装备_追加_防御New += FLD_装备_追加_防具_强化 * 6;
												}
												if (value.FLD_LEVEL < 60)
												{
													FLD_装备_追加_HP += FLD_装备_追加_防具_强化 * 10;
												}
												else
												{
													FLD_装备_降低_伤害值 += FLD_装备_追加_防具_强化 * 10;
												}
											}
										}
										if (value.FLD_RESIDE2 == 1)
										{
											if (装备栏已穿装备[i].物品属性阶段类型 != 0 && 装备栏已穿装备[i].物品属性阶段数 > 0)
											{
												int num16 = FLD_夫妻辅助_追加_防具_属性 + FLD_结婚礼物_追加_属性石;
												switch (装备栏已穿装备[i].物品属性阶段类型)
												{
												case 1:
													FLD_装备_追加_降低百分比攻击 += (double)num16 * 0.01;
													break;
												case 2:
													FLD_装备_追加_愤怒 += num16;
													break;
												case 3:
													FLD_装备_追加_回避百分比 += (double)num16 * 0.01;
													break;
												case 5:
													FLD_装备_追加_防御 += num16 * 3;
													FLD_装备_追加_防御New += num16 * 3;
													break;
												case 6:
													FLD_装备_追加_中毒概率百分比 += (double)num16 * 0.01;
													break;
												}
											}
											if (FLD_装备_追加_觉醒 > 0)
											{
												int num17 = FLD_装备_追加_觉醒 * 5;
												FLD_装备_追加_防御 += num17;
												FLD_装备_追加_防御New += num17;
												衣服防御力 += num17;
											}
										}
										if (判断星装(装备栏已穿装备[i].Get物品ID, 装备栏已穿装备[i].FLD_RESIDE2))
										{
											num2++;
										}
										break;
									case 6:
										if (判断星装(装备栏已穿装备[i].Get物品ID, 装备栏已穿装备[i].FLD_RESIDE2))
										{
											num2++;
										}
										break;
									case 8:
										if (装备栏已穿装备[i].Get物品ID == 15L && 装备栏已穿装备[i].FLD_MAGIC2 == 70000020)
										{
											装备栏已穿装备[i].物品_byte = new byte[World.数据库单个物品大小];
										}
										else if (装备栏已穿装备[i].Get物品ID == 1000500L || 装备栏已穿装备[i].Get物品ID == 1020500L)
										{
											num++;
										}
										break;
									case 10:
										if (装备栏已穿装备[i].Get物品ID == 1700500L || 装备栏已穿装备[i].Get物品ID == 1720500L)
										{
											num++;
										}
										break;
									case 12:
									case 14:
										FLD_装备_追加_合成成功率百分比 += (double)装备栏已穿装备[i].物品属性_升级成功率 * 0.01;
										FLD_装备_追加_获得游戏币百分比 += (double)装备栏已穿装备[i].物品属性_获得金钱增加 * 0.01;
										FLD_装备_追加_经验百分比 += (double)装备栏已穿装备[i].物品属性_经验获得增加 * 0.01;
										FLD_装备_追加_死亡损失经验减少 += (double)装备栏已穿装备[i].物品属性_死亡损失经验减少 * 0.01;
										if (装备栏已穿装备[i].Get物品ID == 26900772L || 装备栏已穿装备[i].Get物品ID == 16900772L || 装备栏已穿装备[i].Get物品ID == 26920772L || 装备栏已穿装备[i].Get物品ID == 16920772L)
										{
											num++;
										}
										switch (Player_Job)
										{
										case 1:
											if (装备栏已穿装备[i].物品属性_追加刀力劈华山 != 0)
											{
												FLD_装备_追加_气功_0 += 装备栏已穿装备[i].物品属性_追加刀力劈华山;
											}
											if (装备栏已穿装备[i].物品属性_追加刀摄魂一击 != 0)
											{
												FLD_装备_追加_气功_1 += 装备栏已穿装备[i].物品属性_追加刀摄魂一击;
											}
											if (装备栏已穿装备[i].物品属性_追加刀连环飞舞 != 0)
											{
												FLD_装备_追加_气功_2 += 装备栏已穿装备[i].物品属性_追加刀连环飞舞;
											}
											if (装备栏已穿装备[i].物品属性_追加刀狂风万破 != 0)
											{
												FLD_装备_追加_气功_3 += 装备栏已穿装备[i].物品属性_追加刀狂风万破;
											}
											if (装备栏已穿装备[i].物品属性_追加刀稳如泰山 != 0)
											{
												FLD_装备_追加_气功_4 += 装备栏已穿装备[i].物品属性_追加刀稳如泰山;
											}
											if (装备栏已穿装备[i].物品属性_追加刀霸气破甲 != 0)
											{
												FLD_装备_追加_气功_5 += 装备栏已穿装备[i].物品属性_追加刀霸气破甲;
											}
											if (装备栏已穿装备[i].物品属性_追加刀真武绝击 != 0)
											{
												FLD_装备_追加_气功_7 += 装备栏已穿装备[i].物品属性_追加刀真武绝击;
											}
											if (装备栏已穿装备[i].物品属性_追加刀四两千斤 != 0)
											{
												FLD_装备_追加_气功_8 += 装备栏已穿装备[i].物品属性_追加刀四两千斤;
											}
											if (装备栏已穿装备[i].物品属性_追加刀暗影绝杀 != 0)
											{
												FLD_装备_追加_气功_9 += 装备栏已穿装备[i].物品属性_追加刀暗影绝杀;
											}
											if (装备栏已穿装备[i].物品属性_追加刀梵音破镜 != 0)
											{
												FLD_装备_追加_气功_10 += 装备栏已穿装备[i].物品属性_追加刀梵音破镜;
											}
											if (装备栏已穿装备[i].物品属性_追加刀流光乱舞 != 0)
											{
												FLD_装备_追加_气功_11 += 装备栏已穿装备[i].物品属性_追加刀流光乱舞;
											}
											break;
										case 2:
											if (装备栏已穿装备[i].物品属性_追加剑长虹贯日 != 0)
											{
												FLD_装备_追加_气功_0 += 装备栏已穿装备[i].物品属性_追加剑长虹贯日;
											}
											if (装备栏已穿装备[i].物品属性_追加剑百变神行 != 0)
											{
												FLD_装备_追加_气功_1 += 装备栏已穿装备[i].物品属性_追加剑百变神行;
											}
											if (装备栏已穿装备[i].物品属性_追加剑连环飞舞 != 0)
											{
												FLD_装备_追加_气功_2 += 装备栏已穿装备[i].物品属性_追加剑连环飞舞;
											}
											if (装备栏已穿装备[i].物品属性_追加剑破天一剑 != 0)
											{
												FLD_装备_追加_气功_3 += 装备栏已穿装备[i].物品属性_追加剑破天一剑;
											}
											if (装备栏已穿装备[i].物品属性_追加剑狂风万破 != 0)
											{
												FLD_装备_追加_气功_4 += 装备栏已穿装备[i].物品属性_追加剑狂风万破;
											}
											if (装备栏已穿装备[i].物品属性_追加剑移花接木 != 0)
											{
												FLD_装备_追加_气功_5 += 装备栏已穿装备[i].物品属性_追加剑移花接木;
											}
											if (装备栏已穿装备[i].物品属性_追加剑怒海狂澜 != 0)
											{
												FLD_装备_追加_气功_7 += 装备栏已穿装备[i].物品属性_追加剑怒海狂澜;
											}
											if (装备栏已穿装备[i].物品属性_追加剑回柳身法 != 0)
											{
												FLD_装备_追加_气功_8 += 装备栏已穿装备[i].物品属性_追加剑回柳身法;
											}
											if (装备栏已穿装备[i].物品属性_追加剑无坚不摧 != 0)
											{
												FLD_装备_追加_气功_9 += 装备栏已穿装备[i].物品属性_追加剑无坚不摧;
											}
											if (装备栏已穿装备[i].物品属性_追加剑乘胜追击 != 0)
											{
												FLD_装备_追加_气功_10 += 装备栏已穿装备[i].物品属性_追加剑乘胜追击;
											}
											if (装备栏已穿装备[i].物品属性_追加剑冲冠一怒 != 0)
											{
												FLD_装备_追加_气功_11 += 装备栏已穿装备[i].物品属性_追加剑冲冠一怒;
											}
											break;
										case 3:
											if (装备栏已穿装备[i].物品属性_追加枪金钟罩气 != 0)
											{
												FLD_装备_追加_气功_0 += 装备栏已穿装备[i].物品属性_追加枪金钟罩气;
											}
											if (装备栏已穿装备[i].物品属性_追加枪运气疗伤 != 0)
											{
												FLD_装备_追加_气功_1 += 装备栏已穿装备[i].物品属性_追加枪运气疗伤;
											}
											if (装备栏已穿装备[i].物品属性_追加枪连环飞舞 != 0)
											{
												FLD_装备_追加_气功_2 += 装备栏已穿装备[i].物品属性_追加枪连环飞舞;
											}
											if (装备栏已穿装备[i].物品属性_追加枪狂风万破 != 0)
											{
												FLD_装备_追加_气功_3 += 装备栏已穿装备[i].物品属性_追加枪狂风万破;
											}
											if (装备栏已穿装备[i].物品属性_追加枪横练太保 != 0)
											{
												FLD_装备_追加_气功_4 += 装备栏已穿装备[i].物品属性_追加枪横练太保;
											}
											if (装备栏已穿装备[i].物品属性_追加枪转守为攻 != 0)
											{
												FLD_装备_追加_气功_5 += 装备栏已穿装备[i].物品属性_追加枪转守为攻;
											}
											if (装备栏已穿装备[i].物品属性_追加枪狂神降世 != 0)
											{
												FLD_装备_追加_气功_7 += 装备栏已穿装备[i].物品属性_追加枪狂神降世;
											}
											if (装备栏已穿装备[i].物品属性_追加枪乾坤挪移 != 0)
											{
												FLD_装备_追加_气功_8 += 装备栏已穿装备[i].物品属性_追加枪乾坤挪移;
											}
											if (装备栏已穿装备[i].物品属性_追加枪末日狂舞 != 0)
											{
												FLD_装备_追加_气功_9 += 装备栏已穿装备[i].物品属性_追加枪末日狂舞;
											}
											if (装备栏已穿装备[i].物品属性_追加枪怒意之吼 != 0)
											{
												FLD_装备_追加_气功_10 += 装备栏已穿装备[i].物品属性_追加枪怒意之吼;
											}
											if (装备栏已穿装备[i].物品属性_追加枪灵甲护身 != 0)
											{
												FLD_装备_追加_气功_11 += 装备栏已穿装备[i].物品属性_追加枪灵甲护身;
											}
											break;
										case 4:
											if (装备栏已穿装备[i].物品属性_追加弓百步穿杨 != 0)
											{
												FLD_装备_追加_气功_0 = 装备栏已穿装备[i].物品属性_追加弓百步穿杨;
											}
											if (装备栏已穿装备[i].物品属性_追加弓猎鹰之眼 != 0)
											{
												FLD_装备_追加_气功_1 = 装备栏已穿装备[i].物品属性_追加弓猎鹰之眼;
											}
											if (装备栏已穿装备[i].物品属性_追加弓凝神聚气 != 0)
											{
												FLD_装备_追加_气功_2 = 装备栏已穿装备[i].物品属性_追加弓凝神聚气;
											}
											if (装备栏已穿装备[i].物品属性_追加弓狂风万破 != 0)
											{
												FLD_装备_追加_气功_3 = 装备栏已穿装备[i].物品属性_追加弓狂风万破;
											}
											if (装备栏已穿装备[i].物品属性_追加弓正本培元 != 0)
											{
												FLD_装备_追加_气功_4 = 装备栏已穿装备[i].物品属性_追加弓正本培元;
											}
											if (装备栏已穿装备[i].物品属性_追加弓锐利之箭 != 0)
											{
												FLD_装备_追加_气功_5 = 装备栏已穿装备[i].物品属性_追加弓锐利之箭;
											}
											if (装备栏已穿装备[i].物品属性_追加弓心神凝聚 != 0)
											{
												FLD_装备_追加_气功_7 = 装备栏已穿装备[i].物品属性_追加弓心神凝聚;
											}
											if (装备栏已穿装备[i].物品属性_追加弓流星三矢 != 0)
											{
												FLD_装备_追加_气功_8 = 装备栏已穿装备[i].物品属性_追加弓流星三矢;
											}
											if (装备栏已穿装备[i].物品属性_追加弓回流真气 != 0)
											{
												FLD_装备_追加_气功_9 = 装备栏已穿装备[i].物品属性_追加弓回流真气;
											}
											if (装备栏已穿装备[i].物品属性_追加弓无明暗矢 != 0)
											{
												FLD_装备_追加_气功_10 = 装备栏已穿装备[i].物品属性_追加弓无明暗矢;
											}
											if (装备栏已穿装备[i].物品属性_追加弓致命绝杀 != 0)
											{
												FLD_装备_追加_气功_11 = 装备栏已穿装备[i].物品属性_追加弓致命绝杀;
											}
											break;
										case 5:
											if (装备栏已穿装备[i].物品属性_追加医运气行心 != 0)
											{
												FLD_装备_追加_气功_0 += 装备栏已穿装备[i].物品属性_追加医运气行心;
											}
											if (装备栏已穿装备[i].物品属性_追加医太极心法 != 0)
											{
												FLD_装备_追加_气功_1 += 装备栏已穿装备[i].物品属性_追加医太极心法;
											}
											if (装备栏已穿装备[i].物品属性_追加医体血倍增 != 0)
											{
												FLD_装备_追加_气功_2 += 装备栏已穿装备[i].物品属性_追加医体血倍增;
											}
											if (装备栏已穿装备[i].物品属性_追加医洗髓易经 != 0)
											{
												FLD_装备_追加_气功_3 += 装备栏已穿装备[i].物品属性_追加医洗髓易经;
											}
											if (装备栏已穿装备[i].物品属性_追加医妙手回春 != 0)
											{
												FLD_装备_追加_气功_4 += 装备栏已穿装备[i].物品属性_追加医妙手回春;
											}
											if (装备栏已穿装备[i].物品属性_追加医长功攻击 != 0)
											{
												FLD_装备_追加_气功_5 += 装备栏已穿装备[i].物品属性_追加医长功攻击;
											}
											if (装备栏已穿装备[i].物品属性_追加医真武绝击 != 0)
											{
												FLD_装备_追加_气功_7 += 装备栏已穿装备[i].物品属性_追加医真武绝击;
											}
											if (装备栏已穿装备[i].物品属性_追加医吸星大法 != 0)
											{
												FLD_装备_追加_气功_8 += 装备栏已穿装备[i].物品属性_追加医吸星大法;
											}
											if (装备栏已穿装备[i].物品属性_追加医狂意护体 != 0)
											{
												FLD_装备_追加_气功_9 += 装备栏已穿装备[i].物品属性_追加医狂意护体;
											}
											if (装备栏已穿装备[i].物品属性_追加医无中生有 != 0)
											{
												FLD_装备_追加_气功_10 += 装备栏已穿装备[i].物品属性_追加医无中生有;
											}
											if (装备栏已穿装备[i].物品属性_追加医九天真气 != 0)
											{
												FLD_装备_追加_气功_11 += 装备栏已穿装备[i].物品属性_追加医九天真气;
											}
											break;
										case 6:
											if (装备栏已穿装备[i].物品属性_追加刺荆轲之怒 != 0)
											{
												FLD_装备_追加_气功_0 += 装备栏已穿装备[i].物品属性_追加刺荆轲之怒;
											}
											if (装备栏已穿装备[i].物品属性_追加刺三花聚顶 != 0)
											{
												FLD_装备_追加_气功_1 += 装备栏已穿装备[i].物品属性_追加刺三花聚顶;
											}
											if (装备栏已穿装备[i].物品属性_追加刺连环飞舞 != 0)
											{
												FLD_装备_追加_气功_2 += 装备栏已穿装备[i].物品属性_追加刺连环飞舞;
											}
											if (装备栏已穿装备[i].物品属性_追加刺心神凝聚 != 0)
											{
												FLD_装备_追加_气功_3 += 装备栏已穿装备[i].物品属性_追加刺心神凝聚;
											}
											if (装备栏已穿装备[i].物品属性_追加刺致手绝命 != 0)
											{
												FLD_装备_追加_气功_4 += 装备栏已穿装备[i].物品属性_追加刺致手绝命;
											}
											if (装备栏已穿装备[i].物品属性_追加刺以怒还怒 != 0)
											{
												FLD_装备_追加_气功_5 += 装备栏已穿装备[i].物品属性_追加刺以怒还怒;
											}
											if (装备栏已穿装备[i].物品属性_追加刺先发制人 != 0)
											{
												FLD_装备_追加_气功_7 += 装备栏已穿装备[i].物品属性_追加刺先发制人;
											}
											if (装备栏已穿装备[i].物品属性_追加刺千株万手 != 0)
											{
												FLD_装备_追加_气功_8 += 装备栏已穿装备[i].物品属性_追加刺千株万手;
											}
											if (装备栏已穿装备[i].物品属性_追加刺连消带打 != 0)
											{
												FLD_装备_追加_气功_9 += 装备栏已穿装备[i].物品属性_追加刺连消带打;
											}
											if (装备栏已穿装备[i].物品属性_追加刺剑刃乱舞 != 0)
											{
												FLD_装备_追加_气功_10 += 装备栏已穿装备[i].物品属性_追加刺剑刃乱舞;
											}
											if (装备栏已穿装备[i].物品属性_追加刺一招残杀 != 0)
											{
												FLD_装备_追加_气功_11 += 装备栏已穿装备[i].物品属性_追加刺一招残杀;
											}
											break;
										case 7:
											if (装备栏已穿装备[i].物品属性_追加琴战马奔腾 != 0)
											{
												FLD_装备_追加_气功_0 += 装备栏已穿装备[i].物品属性_追加琴战马奔腾;
											}
											if (装备栏已穿装备[i].物品属性_追加琴秋江夜泊 != 0)
											{
												FLD_装备_追加_气功_1 += 装备栏已穿装备[i].物品属性_追加琴秋江夜泊;
											}
											if (装备栏已穿装备[i].物品属性_追加琴清心普善 != 0)
											{
												FLD_装备_追加_气功_2 += 装备栏已穿装备[i].物品属性_追加琴清心普善;
											}
											if (装备栏已穿装备[i].物品属性_追加琴阳关三叠 != 0)
											{
												FLD_装备_追加_气功_3 += 装备栏已穿装备[i].物品属性_追加琴阳关三叠;
											}
											if (装备栏已穿装备[i].物品属性_追加琴汉宫秋月 != 0)
											{
												FLD_装备_追加_气功_4 += 装备栏已穿装备[i].物品属性_追加琴汉宫秋月;
											}
											if (装备栏已穿装备[i].物品属性_追加琴高山流水 != 0)
											{
												FLD_装备_追加_气功_5 += 装备栏已穿装备[i].物品属性_追加琴高山流水;
											}
											if (装备栏已穿装备[i].物品属性_追加琴岳阳三醉 != 0)
											{
												FLD_装备_追加_气功_7 += 装备栏已穿装备[i].物品属性_追加琴岳阳三醉;
											}
											if (装备栏已穿装备[i].物品属性_追加琴梅花三弄 != 0)
											{
												FLD_装备_追加_气功_8 += 装备栏已穿装备[i].物品属性_追加琴梅花三弄;
											}
											if (装备栏已穿装备[i].物品属性_追加琴鸾凤和鸣 != 0)
											{
												FLD_装备_追加_气功_9 += 装备栏已穿装备[i].物品属性_追加琴鸾凤和鸣;
											}
											if (装备栏已穿装备[i].物品属性_追加琴阳明春晓 != 0)
											{
												FLD_装备_追加_气功_10 += 装备栏已穿装备[i].物品属性_追加琴阳明春晓;
											}
											if (装备栏已穿装备[i].物品属性_追加琴潇湘雨夜 != 0)
											{
												FLD_装备_追加_气功_11 += 装备栏已穿装备[i].物品属性_追加琴潇湘雨夜;
											}
											break;
										case 8:
											if (装备栏已穿装备[i].物品属性_追加韩力劈华山 != 0)
											{
												FLD_装备_追加_气功_0 += 装备栏已穿装备[i].物品属性_追加韩力劈华山;
											}
											if (装备栏已穿装备[i].物品属性_追加韩摄魂一击 != 0)
											{
												FLD_装备_追加_气功_1 += 装备栏已穿装备[i].物品属性_追加韩摄魂一击;
											}
											if (装备栏已穿装备[i].物品属性_追加韩百变神行 != 0)
											{
												FLD_装备_追加_气功_2 += 装备栏已穿装备[i].物品属性_追加韩百变神行;
											}
											if (装备栏已穿装备[i].物品属性_追加韩狂风万破 != 0)
											{
												FLD_装备_追加_气功_3 += 装备栏已穿装备[i].物品属性_追加韩狂风万破;
											}
											if (装备栏已穿装备[i].物品属性_追加韩天魔狂血 != 0)
											{
												FLD_装备_追加_气功_4 += 装备栏已穿装备[i].物品属性_追加韩天魔狂血;
											}
											if (装备栏已穿装备[i].物品属性_追加韩追骨吸元 != 0)
											{
												FLD_装备_追加_气功_5 += 装备栏已穿装备[i].物品属性_追加韩追骨吸元;
											}
											if (装备栏已穿装备[i].物品属性_追加韩霸气破甲 != 0)
											{
												FLD_装备_追加_气功_7 += 装备栏已穿装备[i].物品属性_追加韩霸气破甲;
											}
											if (装备栏已穿装备[i].物品属性_追加韩真武绝击 != 0)
											{
												FLD_装备_追加_气功_8 += 装备栏已穿装备[i].物品属性_追加韩真武绝击;
											}
											if (装备栏已穿装备[i].物品属性_追加韩火龙问鼎 != 0)
											{
												FLD_装备_追加_气功_9 += 装备栏已穿装备[i].物品属性_追加韩火龙问鼎;
											}
											if (装备栏已穿装备[i].物品属性_追加韩流光乱舞 != 0)
											{
												FLD_装备_追加_气功_10 += 装备栏已穿装备[i].物品属性_追加韩流光乱舞;
											}
											if (装备栏已穿装备[i].物品属性_追加韩暗影绝杀 != 0)
											{
												FLD_装备_追加_气功_11 += 装备栏已穿装备[i].物品属性_追加韩暗影绝杀;
											}
											break;
										case 9:
											if (装备栏已穿装备[i].物品属性_追加谭长虹贯日 != 0)
											{
												FLD_装备_追加_气功_0 += 装备栏已穿装备[i].物品属性_追加谭长虹贯日;
											}
											if (装备栏已穿装备[i].物品属性_追加谭百变神行 != 0)
											{
												FLD_装备_追加_气功_1 += 装备栏已穿装备[i].物品属性_追加谭百变神行;
											}
											if (装备栏已穿装备[i].物品属性_追加谭新_连环飞舞 != 0)
											{
												FLD_装备_追加_气功_2 += 装备栏已穿装备[i].物品属性_追加谭新_连环飞舞;
											}
											if (装备栏已穿装备[i].物品属性_追加谭招式新法 != 0)
											{
												FLD_装备_追加_气功_3 += 装备栏已穿装备[i].物品属性_追加谭招式新法;
											}
											if (装备栏已穿装备[i].物品属性_追加韩狂风万破 != 0)
											{
												FLD_装备_追加_气功_4 += 装备栏已穿装备[i].物品属性_追加韩狂风万破;
											}
											if (装备栏已穿装备[i].物品属性_追加谭护身罡气 != 0)
											{
												FLD_装备_追加_气功_5 += 装备栏已穿装备[i].物品属性_追加谭护身罡气;
											}
											if (装备栏已穿装备[i].物品属性_追加谭移花接木 != 0)
											{
												FLD_装备_追加_气功_7 += 装备栏已穿装备[i].物品属性_追加谭移花接木;
											}
											if (装备栏已穿装备[i].物品属性_追加谭纵横无双 != 0)
											{
												FLD_装备_追加_气功_8 += 装备栏已穿装备[i].物品属性_追加谭纵横无双;
											}
											if (装备栏已穿装备[i].物品属性_追加谭回柳身法 != 0)
											{
												FLD_装备_追加_气功_9 += 装备栏已穿装备[i].物品属性_追加谭回柳身法;
											}
											if (装备栏已穿装备[i].物品属性_追加谭怒海狂澜 != 0)
											{
												FLD_装备_追加_气功_10 += 装备栏已穿装备[i].物品属性_追加谭怒海狂澜;
											}
											if (装备栏已穿装备[i].物品属性_追加谭冲冠一怒 != 0)
											{
												FLD_装备_追加_气功_11 += 装备栏已穿装备[i].物品属性_追加谭冲冠一怒;
											}
											break;
										}
										if (Player_Job_leve >= 6)
										{
											foreach (升天气功类 value2 in 升天气功.Values)
											{
												if (value2.气功量 > 0)
												{
													switch (value2.气功ID)
													{
													case 33:
														FLD_装备_追加_升天三怒意之火 += 装备栏已穿装备[i].物品属性_追加升天三怒意之火;
														break;
													case 25:
														FLD_装备_追加_升天一护身罡气 += 装备栏已穿装备[i].物品属性_追加升天一护身罡气;
														break;
													case 13:
														FLD_装备_追加_升天三火龙之火 += 装备栏已穿装备[i].物品属性_追加升天三火龙之火;
														break;
													case 170:
														FLD_装备_追加_升天三无情打击 += 装备栏已穿装备[i].物品属性_追加升天三无情打击;
														break;
													case 150:
														FLD_装备_追加_升天二万物回春 += 装备栏已穿装备[i].物品属性_追加升天二万物回春;
														break;
													case 58:
														FLD_装备_追加_升天一护身气甲 += 装备栏已穿装备[i].物品属性_追加升天一护身气甲;
														break;
													case 352:
														FLD_装备_追加_升天三明镜止水 += 装备栏已穿装备[i].物品属性_追加升天三明镜止水;
														break;
													case 354:
														FLD_装备_追加_升天四望梅添花 += 装备栏已穿装备[i].物品属性_追加升天四望梅添花;
														break;
													case 330:
														FLD_装备_追加_升天一破甲刺魂 += 装备栏已穿装备[i].物品属性_追加升天一破甲刺魂;
														break;
													case 331:
														FLD_装备_追加_升天二以退为进 += 装备栏已穿装备[i].物品属性_追加升天二以退为进;
														break;
													case 340:
														FLD_装备_追加_升天一绝影射魂 += 装备栏已穿装备[i].物品属性_追加升天一绝影射魂;
														break;
													case 341:
														FLD_装备_追加_升天二千钧压驼 += 装备栏已穿装备[i].物品属性_追加升天二千钧压驼;
														break;
													case 342:
														FLD_装备_追加_升天三天外三矢 += 装备栏已穿装备[i].物品属性_追加升天三天外三矢;
														break;
													case 310:
														FLD_装备_追加_升天一遁出逆境 += 装备栏已穿装备[i].物品属性_追加升天一遁出逆境;
														break;
													case 311:
														FLD_装备_追加_升天二穷途末路 += 装备栏已穿装备[i].物品属性_追加升天二穷途末路;
														break;
													case 321:
														FLD_装备_追加_升天二天地同寿 += 装备栏已穿装备[i].物品属性_追加升天二天地同寿;
														break;
													case 322:
														FLD_装备_追加_升天三火凤临朝 += 装备栏已穿装备[i].物品属性_追加升天三火凤临朝;
														break;
													case 561:
														FLD_装备_追加_升天一夺命连环 += 装备栏已穿装备[i].物品属性_追加升天夺命连环;
														break;
													case 562:
														FLD_装备_追加_升天一电光石火 += 装备栏已穿装备[i].物品属性_追加升天电光石火;
														break;
													case 563:
														FLD_装备_追加_升天一精益求精 += 装备栏已穿装备[i].物品属性_追加升天精益求精;
														break;
													case 314:
													case 324:
													case 334:
													case 565:
														FLD_装备_追加_升天四毒蛇出洞 += 装备栏已穿装备[i].物品属性_追加升天四毒蛇出洞;
														break;
													case 370:
														FLD_装备_追加_升天一夜魔缠身 += 装备栏已穿装备[i].物品属性_追加升天一夜魔缠身;
														break;
													case 371:
														FLD_装备_追加_升天二顺水推舟 += 装备栏已穿装备[i].物品属性_追加升天二顺水推舟;
														break;
													case 343:
													case 353:
													case 373:
														FLD_装备_追加_升天四满月狂风 += 装备栏已穿装备[i].物品属性_追加升天四满月狂风;
														break;
													case 344:
													case 374:
														FLD_装备_追加_升天四烈日炎炎 += 装备栏已穿装备[i].物品属性_追加升天四烈日炎炎;
														break;
													case 380:
														FLD_装备_追加_升天一力劈华山 += 装备栏已穿装备[i].物品属性_追加升天一力劈华山;
														break;
													case 381:
														FLD_装备_追加_升天一长虹贯日 += 装备栏已穿装备[i].物品属性_追加升天一长虹贯日;
														break;
													case 382:
														FLD_装备_追加_升天一金钟罡气 += 装备栏已穿装备[i].物品属性_追加升天一金钟罡气;
														break;
													case 383:
														FLD_装备_追加_升天一运气行心 += 装备栏已穿装备[i].物品属性_追加升天一运气行心;
														break;
													case 384:
														FLD_装备_追加_升天一正本培源 += 装备栏已穿装备[i].物品属性_追加升天一正本培源;
														break;
													case 385:
														FLD_装备_追加_升天一运气疗伤 += 装备栏已穿装备[i].物品属性_追加升天一运气疗伤;
														break;
													case 386:
														FLD_装备_追加_升天一百变神行 += 装备栏已穿装备[i].物品属性_追加升天一百变神行;
														break;
													case 387:
														FLD_装备_追加_升天一狂风天意 += 装备栏已穿装备[i].物品属性_追加升天一狂风天意;
														break;
													case 390:
														FLD_装备_追加_升天一飞花点翠 += 装备栏已穿装备[i].物品属性_追加升天一飞花点翠;
														break;
													case 391:
														FLD_装备_追加_升天二三潭映月 += 装备栏已穿装备[i].物品属性_追加升天二三潭映月;
														break;
													case 392:
														FLD_装备_追加_升天三子夜秋歌 += 装备栏已穿装备[i].物品属性_追加升天三子夜秋歌;
														break;
													case 313:
													case 323:
													case 333:
													case 393:
													case 564:
														FLD_装备_追加_升天四红月狂风 += 装备栏已穿装备[i].物品属性_追加升天四红月狂风;
														break;
													case 394:
														FLD_装备_追加_升天四悬丝诊脉 += 装备栏已穿装备[i].物品属性_追加升天四悬丝诊脉;
														break;
													case 700:
														FLD_装备_追加_升天三以柔克刚 += 装备栏已穿装备[i].物品属性_追加升天三以柔克刚;
														break;
													case 600:
														FLD_装备_追加_升天一行风弄舞 += 装备栏已穿装备[i].物品属性_追加升天一行风弄舞;
														break;
													case 601:
														FLD_装备_追加_升天二天魔护体 += 装备栏已穿装备[i].物品属性_追加升天二天魔护体;
														break;
													case 602:
														FLD_装备_追加_升天三内息行心 += 装备栏已穿装备[i].物品属性_追加升天三内息行心;
														break;
													case 603:
													case 701:
														FLD_装备_追加_升天四长虹贯天 += 装备栏已穿装备[i].物品属性_追加升天四长虹贯天;
														break;
													case 604:
													case 702:
														FLD_装备_追加_升天四哀鸿遍野 += 装备栏已穿装备[i].物品属性_追加升天四哀鸿遍野;
														break;
													}
												}
											}
										}
										break;
									}
								}
							}
						}
					}
				}
				if (num == 3)
				{
					FLD_装备_追加_HP += 80;
					FLD_装备_追加_攻击 += 10;
					FLD_装备_武功攻击力增加百分比 += 0.09;
				}
				if (num2 >= 2)
				{
					switch (Player_Job)
					{
					case 1:
						switch (num2)
						{
						case 2:
							FLD_装备_追加_防御 += 20;
							break;
						case 3:
							FLD_装备_追加_防御 += 20;
							FLD_装备_追加_气功_0 += 2.0;
							break;
						case 4:
						{
							FLD_装备_追加_防御 += 20;
							FLD_装备_追加_气功_0 += 2.0;
							int num18 = ++FLD_装备_追加_气功;
							break;
						}
						case 5:
						{
							FLD_装备_追加_防御 += 20;
							FLD_装备_追加_气功_0 += 2.0;
							int num18 = ++FLD_装备_追加_气功;
							FLD_装备_追加_气功_8 += 2.0;
							break;
						}
						}
						break;
					case 2:
						switch (num2)
						{
						case 2:
							FLD_装备_追加_防御 += 10;
							FLD_装备_追加_回避 += 20;
							break;
						case 3:
							FLD_装备_追加_防御 += 10;
							FLD_装备_追加_回避 += 20;
							FLD_装备_追加_气功_0 += 2.0;
							break;
						case 4:
						{
							FLD_装备_追加_防御 += 10;
							FLD_装备_追加_回避 += 20;
							FLD_装备_追加_气功_0 += 2.0;
							int num18 = ++FLD_装备_追加_气功;
							break;
						}
						case 5:
						{
							FLD_装备_追加_防御 += 10;
							FLD_装备_追加_回避 += 20;
							FLD_装备_追加_气功_0 += 2.0;
							int num18 = ++FLD_装备_追加_气功;
							FLD_装备_追加_气功_6 += 2.0;
							break;
						}
						}
						break;
					case 3:
						switch (num2)
						{
						case 2:
							FLD_装备_追加_攻击 += 10;
							FLD_装备_追加_防御 += 20;
							break;
						case 3:
							FLD_装备_追加_攻击 += 10;
							FLD_装备_追加_防御 += 20;
							FLD_装备_追加_气功_0 += 2.0;
							break;
						case 4:
						{
							FLD_装备_追加_攻击 += 10;
							FLD_装备_追加_防御 += 20;
							FLD_装备_追加_气功_0 += 2.0;
							int num18 = ++FLD_装备_追加_气功;
							break;
						}
						case 5:
						{
							FLD_装备_追加_攻击 += 10;
							FLD_装备_追加_防御 += 20;
							FLD_装备_追加_气功_0 += 2.0;
							int num18 = ++FLD_装备_追加_气功;
							FLD_装备_追加_气功_6 += 2.0;
							break;
						}
						}
						break;
					case 4:
						switch (num2)
						{
						case 2:
							FLD_装备_追加_防御 += 10;
							FLD_装备_追加_命中 += 20;
							break;
						case 3:
							FLD_装备_追加_防御 += 10;
							FLD_装备_追加_命中 += 20;
							FLD_装备_追加_气功_0 += 2.0;
							break;
						case 4:
						{
							FLD_装备_追加_防御 += 10;
							FLD_装备_追加_命中 += 20;
							FLD_装备_追加_气功_0 += 2.0;
							int num18 = ++FLD_装备_追加_气功;
							break;
						}
						case 5:
						{
							FLD_装备_追加_防御 += 10;
							FLD_装备_追加_命中 += 20;
							FLD_装备_追加_气功_0 += 2.0;
							int num18 = ++FLD_装备_追加_气功;
							FLD_装备_追加_气功_5 += 2.0;
							break;
						}
						}
						break;
					case 5:
						switch (num2)
						{
						case 2:
							FLD_装备_追加_HP += 100;
							FLD_装备_追加_防御 += 10;
							break;
						case 3:
							FLD_装备_追加_HP += 100;
							FLD_装备_追加_防御 += 10;
							FLD_装备_追加_气功_2 += 2.0;
							break;
						case 4:
						{
							FLD_装备_追加_HP += 100;
							FLD_装备_追加_防御 += 10;
							FLD_装备_追加_气功_2 += 2.0;
							int num18 = ++FLD_装备_追加_气功;
							break;
						}
						case 5:
						{
							FLD_装备_追加_HP += 100;
							FLD_装备_追加_防御 += 10;
							FLD_装备_追加_气功_2 += 2.0;
							int num18 = ++FLD_装备_追加_气功;
							break;
						}
						}
						break;
					case 6:
						switch (num2)
						{
						case 2:
							FLD_装备_追加_攻击 += 10;
							FLD_装备_追加_回避 += 20;
							break;
						case 3:
							FLD_装备_追加_攻击 += 10;
							FLD_装备_追加_回避 += 20;
							FLD_装备_追加_气功_0 += 2.0;
							break;
						case 4:
						{
							FLD_装备_追加_攻击 += 10;
							FLD_装备_追加_回避 += 20;
							FLD_装备_追加_气功_0 += 2.0;
							int num18 = ++FLD_装备_追加_气功;
							break;
						}
						case 5:
						{
							FLD_装备_追加_攻击 += 10;
							FLD_装备_追加_回避 += 20;
							FLD_装备_追加_气功_0 += 2.0;
							int num18 = ++FLD_装备_追加_气功;
							FLD_装备_追加_气功_8 += 2.0;
							break;
						}
						}
						break;
					case 7:
						switch (num2)
						{
						case 2:
							FLD_装备_追加_攻击 += 10;
							FLD_装备_追加_MP += 200;
							break;
						case 3:
							FLD_装备_追加_攻击 += 10;
							FLD_装备_追加_MP += 200;
							FLD_装备_追加_气功_6 += 2.0;
							break;
						case 4:
						{
							FLD_装备_追加_攻击 += 10;
							FLD_装备_追加_MP += 200;
							FLD_装备_追加_气功_6 += 2.0;
							int num18 = ++FLD_装备_追加_气功;
							break;
						}
						case 5:
						{
							FLD_装备_追加_攻击 += 10;
							FLD_装备_追加_MP += 200;
							FLD_装备_追加_气功_6 += 2.0;
							int num18 = ++FLD_装备_追加_气功;
							FLD_装备_追加_气功_8 += 2.0;
							break;
						}
						}
						break;
					case 8:
						switch (num2)
						{
						case 2:
							FLD_装备_追加_防御 += 20;
							break;
						case 3:
							FLD_装备_追加_防御 += 20;
							FLD_装备_追加_气功_0 += 2.0;
							break;
						case 4:
						{
							FLD_装备_追加_防御 += 20;
							FLD_装备_追加_气功_0 += 2.0;
							int num18 = ++FLD_装备_追加_气功;
							break;
						}
						case 5:
						{
							FLD_装备_追加_防御 += 20;
							FLD_装备_追加_气功_0 += 2.0;
							int num18 = ++FLD_装备_追加_气功;
							FLD_装备_追加_气功_10 += 2.0;
							break;
						}
						}
						break;
					case 9:
						switch (num2)
						{
						case 2:
							FLD_装备_追加_防御 += 10;
							FLD_装备_追加_回避 += 20;
							break;
						case 3:
							FLD_装备_追加_防御 += 10;
							FLD_装备_追加_回避 += 20;
							FLD_装备_追加_气功_0 += 2.0;
							break;
						case 4:
						{
							FLD_装备_追加_防御 += 10;
							FLD_装备_追加_回避 += 20;
							FLD_装备_追加_气功_0 += 2.0;
							int num18 = ++FLD_装备_追加_气功;
							break;
						}
						case 5:
						{
							FLD_装备_追加_防御 += 10;
							FLD_装备_追加_回避 += 20;
							FLD_装备_追加_气功_0 += 2.0;
							int num18 = ++FLD_装备_追加_气功;
							FLD_装备_追加_气功_9 += 2.0;
							break;
						}
						}
						break;
					}
				}
				if (num3 >= 2)
				{
					switch (Player_Job)
					{
					case 1:
						switch (num3)
						{
						case 4:
							FLD_装备_追加_防御 += 40;
							FLD_装备_武功攻击力增加百分比 += 0.1;
							break;
						case 5:
							FLD_装备_追加_防御 += 40;
							FLD_装备_武功攻击力增加百分比 += 0.1;
							FLD_装备_追加_HP += 500;
							break;
						case 6:
							FLD_装备_追加_防御 += 40;
							FLD_装备_武功攻击力增加百分比 += 0.1;
							FLD_装备_追加_HP += 500;
							FLD_装备_追加_攻击 += 50;
							break;
						}
						break;
					case 2:
					case 3:
						switch (num3)
						{
						case 4:
							FLD_装备_追加_防御 += 40;
							FLD_装备_武功攻击力增加百分比 += 0.1;
							break;
						case 5:
							FLD_装备_追加_防御 += 40;
							FLD_装备_武功攻击力增加百分比 += 0.1;
							FLD_装备_追加_HP += 500;
							break;
						case 6:
							FLD_装备_追加_防御 += 90;
							FLD_装备_武功攻击力增加百分比 += 0.1;
							FLD_装备_追加_HP += 500;
							break;
						}
						break;
					case 4:
						switch (num3)
						{
						case 4:
							FLD_装备_追加_防御 += 40;
							FLD_装备_追加_攻击 += 10;
							break;
						case 5:
							FLD_装备_追加_防御 += 40;
							FLD_装备_追加_攻击 += 10;
							FLD_装备_追加_HP += 500;
							break;
						case 6:
							FLD_装备_追加_防御 += 40;
							FLD_装备_追加_攻击 += 10;
							FLD_装备_追加_HP += 500;
							FLD_装备_武功攻击力增加百分比 += 0.2;
							break;
						}
						break;
					case 5:
						switch (num3)
						{
						case 4:
							FLD_装备_追加_防御 += 40;
							FLD_装备_追加_攻击 += 10;
							break;
						case 5:
							FLD_装备_追加_防御 += 40;
							FLD_装备_追加_攻击 += 10;
							FLD_装备_追加_HP += 500;
							FLD_装备_追加_MP += 1000;
							break;
						case 6:
							FLD_装备_追加_防御 += 40;
							FLD_装备_追加_HP += 500;
							FLD_装备_追加_MP += 1000;
							FLD_装备_追加_攻击 += 60;
							break;
						}
						break;
					case 6:
						switch (num3)
						{
						case 4:
							FLD_装备_追加_防御 += 40;
							FLD_装备_追加_攻击 += 10;
							break;
						case 5:
							FLD_装备_追加_防御 += 40;
							FLD_装备_追加_攻击 += 10;
							FLD_装备_追加_HP += 500;
							break;
						case 6:
							FLD_装备_追加_防御 += 40;
							FLD_装备_追加_攻击 += 10;
							FLD_装备_追加_HP += 500;
							FLD_装备_武功攻击力增加百分比 += 0.2;
							break;
						}
						break;
					case 7:
						switch (num3)
						{
						case 4:
							FLD_装备_追加_防御 += 40;
							FLD_装备_追加_攻击 += 10;
							break;
						case 5:
							FLD_装备_追加_防御 += 40;
							FLD_装备_追加_攻击 += 10;
							FLD_装备_追加_HP += 500;
							FLD_装备_追加_MP += 1000;
							break;
						case 6:
							FLD_装备_追加_防御 += 90;
							FLD_装备_追加_攻击 += 10;
							FLD_装备_追加_HP += 500;
							FLD_装备_追加_MP += 1000;
							break;
						}
						break;
					case 8:
						switch (num3)
						{
						case 4:
							FLD_装备_追加_防御 += 40;
							FLD_装备_武功攻击力增加百分比 += 0.1;
							break;
						case 5:
							FLD_装备_追加_防御 += 40;
							FLD_装备_武功攻击力增加百分比 += 0.1;
							FLD_装备_追加_HP += 500;
							break;
						case 6:
							FLD_装备_追加_防御 += 40;
							FLD_装备_武功攻击力增加百分比 += 0.1;
							FLD_装备_追加_HP += 500;
							FLD_装备_追加_攻击 += 50;
							break;
						}
						break;
					}
				}
				PVP装备加成();
			}
			更新气功();
		}

		public void 计算人物制作等级()
		{
			int fLD_制作等级 = FLD_制作等级;
			FLD_制作等级 = ((FLD_制作熟练度 >= 800) ? 8 : ((FLD_制作熟练度 >= 700) ? 7 : ((FLD_制作熟练度 >= 600) ? 6 : ((FLD_制作熟练度 >= 500) ? 5 : ((FLD_制作熟练度 >= 400) ? 4 : ((FLD_制作熟练度 >= 300) ? 3 : ((FLD_制作熟练度 < 100) ? 1 : 2)))))));
			if (FLD_制作等级 > fLD_制作等级)
			{
				更新制作系统();
			}
		}

		public void 计算人物基本数据3()
		{
			int player_Level = Player_Level;
			int num = Player_Level;
			long 人物经验 = this.人物经验;
			long num2 = 人物最大经验;
			人物最大经验 = (long)World.lever[Player_Level];
			int num3 = 0;
			while (Player_Level < World.限制最高级别)
			{
				if (人物经验 >= num2)
				{
					if (num3 <= 270 && Client.Running)
					{
						num++;
						num2 = (long)World.lever[num];
						num3++;
						continue;
					}
					return;
				}
				if ((double)(this.人物经验 - Convert.ToInt64(World.lever[Player_Level - 1])) < 1.0)
				{
					this.人物经验 = Convert.ToInt64(World.lever[Player_Level - 1]);
					num--;
					double num4 = World.lever[num];
				}
				break;
			}
			if (num - player_Level != 0)
			{
				计算人物基本数据();
				Players players = World.检查玩家世界ID(人物全服ID);
				if (players != null)
				{
					players.更新HP_MP_SP();
					players.更新武功和状态();
				}
				保存帮派数据();
			}
		}

		public void 计算人物基本数据()
		{
			if (Player_Level > World.限制最高级别)
			{
				Player_Level = World.限制最高级别;
			}
			人物最大经验 = (long)World.lever[Player_Level];
			int player_Level = Player_Level;
			while (Player_Level < World.限制最高级别)
			{
				if (Client == null || !Client.Running)
				{
					return;
				}
				int num;
				if (人物经验 < 人物最大经验)
				{
					if (Player_Level != 1 && (double)(人物经验 - Convert.ToInt64(World.lever[Player_Level - 1])) < 1.0)
					{
						num = --Player_Level;
						人物最大经验 = (long)World.lever[Player_Level];
					}
					break;
				}
				num = ++Player_Level;
				人物最大经验 = (long)World.lever[Player_Level];
			}
			if (Player_Level - player_Level > 0)
			{
				升级后的提示(1);
				int num2 = Player_Level - player_Level;
				if (num2 > 0)
				{
					for (int i = 0; i < num2; i++)
					{
						if (Player_Level <= 34)
						{
							int num = ++Player_Qigong_point;
						}
						else
						{
							Player_Qigong_point += 2;
						}
					}
				}
			}
			else if (Player_Level - player_Level < 0)
			{
				int num3 = player_Level - Player_Level;
				if (num3 > 0)
				{
					for (int j = 0; j < num3; j++)
					{
						if (Player_Level >= 34)
						{
							if (Player_Qigong_point >= 2)
							{
								Player_Qigong_point -= 2;
								continue;
							}
							for (int k = 0; k < 12; k++)
							{
								if (气功[k].气功量 >= 2)
								{
									气功[k].气功量 -= 2;
									初始化气功();
									break;
								}
							}
							continue;
						}
						if (Player_Qigong_point >= 1)
						{
							int num = --Player_Qigong_point;
							continue;
						}
						for (int l = 0; l < 5; l++)
						{
							if (气功[l].气功量 >= 1)
							{
								int num = --气功[l].气功量;
								初始化气功();
								break;
							}
						}
					}
				}
			}
			人物最大_SP = 100 + Player_Level * 10;
			int_51 = 500 + 20 * Player_Level;
			人物基本最大_HP = 0;
			人物基本最大_MP = 0;
			人物基本最大_障力 = 0;
			FLD_心 = 0;
			FLD_身 = 0;
			FLD_命中 = 0;
			FLD_回避 = 0;
			FLD_力 = 0;
			FLD_体 = 0;
			FLD_最小攻击 = 0;
			FLD_最大攻击 = 0;
			FLD_攻击 = 0;
			FLD_防御 = 0;
			switch (Player_Job)
			{
			case 1:
			{
				int num8 = Player_Level;
				if (Player_Level >= 130)
				{
					num8 += 5;
				}
				人物基本最大_HP = 145 + (num8 - 1) * 12;
				人物基本最大_MP = 116 + (num8 - 1) * 2;
				FLD_攻击 = 8;
				FLD_防御 = 15;
				FLD_命中 = 2 + (int)((double)(num8 - 1) / 2.9 + 0.5);
				FLD_回避 = 4 + (int)((double)(num8 - 1) / 1.9 + 0.5);
				FLD_心 = 8 + (num8 - 1);
				FLD_力 = 8;
				FLD_体 = 15;
				FLD_身 = 9 + (num8 - 1);
				for (int num9 = 2; num9 <= num8; num9++)
				{
					if (num9 % 2 == 0)
					{
						int num7 = ++FLD_力;
						num7 = ++FLD_体;
						num7 = ++FLD_攻击;
						num7 = ++FLD_防御;
					}
					else
					{
						FLD_力 += 2;
						FLD_体 += 2;
						FLD_攻击 += 2;
						FLD_防御 += 2;
					}
				}
				if (Player_Job_leve >= 6 && Player_Level >= 115)
				{
					FLD_命中 += 17;
					FLD_回避 += 27;
					FLD_心 += 50;
					FLD_力 += 76;
					FLD_体 += 77;
					FLD_身 += 54;
				}
				break;
			}
			case 2:
			{
				int num16 = Player_Level;
				if (Player_Level >= 130)
				{
					num16 += 5;
				}
				人物基本最大_HP = 133 + (num16 - 1) * 9;
				人物基本最大_MP = 118;
				FLD_攻击 = 11 + (num16 - 1) * 2;
				FLD_防御 = 11 + num16 - 1;
				FLD_命中 = 2 + (num16 - 1);
				FLD_回避 = 4 + (num16 - 1);
				FLD_心 = 9;
				FLD_力 = 11 + (num16 - 1) * 2;
				FLD_体 = 11 + (num16 - 1);
				FLD_身 = 9 + (num16 - 1) * 2;
				for (int num17 = 2; num17 <= num16; num17++)
				{
					if (num17 % 2 == 0)
					{
						int num7 = ++FLD_心;
						人物基本最大_MP += 2;
					}
					else
					{
						FLD_心 += 2;
						人物基本最大_MP += 4;
					}
				}
				if (Player_Level >= 115 && Player_Job_leve >= 6)
				{
					FLD_命中 += 41;
					FLD_回避 += 67;
					FLD_心 += 75;
					FLD_力 += 100;
					FLD_体 += 52;
					FLD_身 += 99;
				}
				break;
			}
			case 3:
			{
				int num12 = Player_Level;
				if (Player_Level >= 130)
				{
					num12 += 5;
				}
				人物基本最大_HP = 133 + (num12 - 1) * 7;
				人物基本最大_MP = 118 + (num12 - 1) * 2;
				FLD_攻击 = 13 + (num12 - 1) * 3;
				FLD_防御 = 11 + (num12 - 1);
				FLD_命中 = 2 + (int)((double)(num12 - 1) / 3.4 + 0.5);
				FLD_回避 = 3 + (int)((double)(num12 - 1) / 2.0 + 0.5);
				FLD_心 = 9 + (num12 - 1);
				FLD_力 = 13 + (num12 - 1) * 3;
				FLD_体 = 11 + (num12 - 1);
				FLD_身 = 7 + (num12 - 1);
				if (Player_Level >= 115 && Player_Job_leve >= 6)
				{
					FLD_命中 += 12;
					FLD_回避 += 27;
					FLD_心 += 51;
					FLD_力 += 147;
					FLD_体 += 52;
					FLD_身 += 53;
				}
				break;
			}
			case 4:
			{
				int num20 = Player_Level;
				if (Player_Level >= 130)
				{
					num20 += 5;
				}
				人物基本最大_HP = 133 + (num20 - 1) * 6;
				人物基本最大_MP = 118 + (num20 - 1) * 4;
				FLD_攻击 = 11;
				FLD_防御 = 9 + (num20 - 1);
				FLD_命中 = 3 + (num20 - 1);
				FLD_回避 = 5;
				FLD_心 = 9 + (num20 - 1) * 2;
				FLD_力 = 11;
				FLD_体 = 9 + (num20 - 1);
				FLD_身 = 11 + (num20 - 1) * 3;
				for (int num21 = 2; num21 <= num20; num21++)
				{
					if (num21 % 2 == 0)
					{
						FLD_回避 += 2;
						FLD_力 += 2;
						FLD_攻击 += 2;
					}
					else
					{
						int num7 = ++FLD_回避;
						FLD_力 += 3;
						FLD_攻击 += 3;
					}
				}
				if (Player_Level >= 115 && Player_Job_leve >= 6)
				{
					FLD_命中 += 31;
					FLD_回避 += 71;
					FLD_心 += 99;
					FLD_力 += 118;
					FLD_体 += 49;
					FLD_身 += 143;
				}
				break;
			}
			case 5:
			{
				int num22 = Player_Level;
				if (Player_Level >= 130)
				{
					num22 += 5;
				}
				人物基本最大_HP = 124 + (num22 - 1) * 7;
				人物基本最大_MP = 136;
				FLD_攻击 = 7 + (int)((double)(num22 - 1) * 2.1);
				FLD_防御 = 8 + (num22 - 1);
				FLD_命中 = 2 + (int)((double)num22 / 4.0 + 0.5);
				FLD_回避 = 3 + (int)((double)num22 / 3.0 + 0.5);
				FLD_心 = 18;
				FLD_力 = 7 + (num22 - 1) * 2;
				FLD_体 = 8 + (num22 - 1);
				FLD_身 = 7 + (num22 - 1);
				for (int num23 = 2; num23 <= num22; num23++)
				{
					if (num23 % 2 == 0)
					{
						人物基本最大_MP += 6;
						FLD_心 += 3;
					}
					else
					{
						人物基本最大_MP += 8;
						FLD_心 += 4;
					}
				}
				if (Player_Level >= 115 && Player_Job_leve >= 6)
				{
					FLD_命中 += 21;
					FLD_回避 += 46;
					FLD_心 += 169;
					FLD_力 += 96;
					FLD_体 += 48;
					FLD_身 += 53;
				}
				break;
			}
			case 6:
			{
				int num13 = Player_Level;
				if (Player_Level >= 130)
				{
					num13 += 5;
				}
				人物基本最大_HP = 133 + (num13 - 1) * 9;
				人物基本最大_MP = 114;
				FLD_攻击 = 10 + (int)((double)(num13 - 1) * 2.1);
				FLD_防御 = 9 + (num13 - 1);
				FLD_命中 = 4 + (num13 - 1);
				FLD_回避 = 7 + (num13 - 1) * 2;
				FLD_心 = 7 + (num13 - 1) * 2;
				FLD_力 = 10 + (num13 - 1) * 2;
				FLD_体 = 9 + (num13 - 1);
				FLD_身 = 14;
				for (int num14 = 2; num14 <= num13; num14++)
				{
					if (num14 % 2 == 0)
					{
						人物基本最大_MP += 2;
						FLD_身 += 3;
					}
					else
					{
						人物基本最大_MP += 4;
						FLD_身 += 4;
					}
				}
				if (Player_Level >= 115 && Player_Job_leve >= 6)
				{
					FLD_命中 += 56;
					FLD_回避 += 83;
					FLD_心 += 99;
					FLD_力 += 102;
					FLD_体 += 51;
					FLD_身 += 168;
				}
				break;
			}
			case 7:
			{
				int num5 = Player_Level;
				if (Player_Level >= 130)
				{
					num5 += 5;
				}
				人物基本最大_HP = ((Player_Level > 2) ? (124 + (num5 - 2) * 6) : 124);
				人物基本最大_MP = 136 + (num5 - 1) * 8;
				FLD_攻击 = 7 + num5 * 2;
				FLD_防御 = ((num5 != 1) ? (7 + (num5 - 2)) : 8);
				FLD_命中 = 2 + (int)((double)(num5 - 1) / 3.5 + 0.5);
				FLD_回避 = 4 + (int)((double)(num5 - 1) / 2.0 + 0.5);
				FLD_心 = 18 + (num5 - 1) * 4;
				FLD_力 = 7 + (num5 - 1) * 2;
				switch (num5)
				{
				default:
					FLD_体 = 8 + (num5 - 3);
					break;
				case 2:
					FLD_体 = 7;
					break;
				case 1:
					FLD_体 = 8;
					break;
				}
				FLD_身 = 7 + (num5 - 1);
				if (Player_Level >= 115 && Player_Job_leve >= 6)
				{
					FLD_命中 += 22;
					FLD_回避 += 46;
					FLD_心 += 191;
					FLD_力 += 101;
					FLD_体 += 50;
					FLD_身 += 53;
				}
				break;
			}
			case 8:
			{
				int num6 = Player_Level;
				if (Player_Level >= 130)
				{
					num6 += 5;
				}
				人物基本最大_HP = 145 + (num6 - 1) * 12;
				人物基本最大_MP = 116 + (num6 - 1) * 2;
				FLD_攻击 = 8;
				FLD_防御 = 15;
				FLD_命中 = 2 + (int)((double)(num6 - 1) / 3.0 + 0.5);
				FLD_回避 = 4 + (int)((double)(num6 - 1) / 3.0 + 0.5);
				FLD_心 = 8 + (num6 - 1);
				FLD_力 = 8;
				FLD_体 = 15;
				FLD_身 = 9 + (num6 - 1);
				for (int n = 2; n <= num6; n++)
				{
					if (n % 2 == 0)
					{
						int num7 = ++FLD_力;
						num7 = ++FLD_体;
						num7 = ++FLD_攻击;
						num7 = ++FLD_防御;
					}
					else
					{
						FLD_力 += 2;
						FLD_体 += 2;
						FLD_攻击 += 2;
						FLD_防御 += 2;
					}
				}
				if (Player_Level >= 115 && Player_Job_leve >= 6)
				{
					FLD_命中 += 18;
					FLD_回避 += 57;
					FLD_心 += 50;
					FLD_力 += 76;
					FLD_体 += 77;
					FLD_身 += 54;
				}
				break;
			}
			case 9:
			{
				int num10 = Player_Level;
				if (Player_Level >= 130)
				{
					num10 += 5;
				}
				人物基本最大_HP = 133 + (num10 - 1) * 9;
				人物基本最大_MP = 118;
				FLD_攻击 = 11 + (num10 - 1) * 2;
				FLD_防御 = 11 + (num10 - 1);
				FLD_命中 = 2;
				FLD_回避 = 4 + (num10 - 1);
				FLD_心 = 9;
				FLD_力 = 11 + (num10 - 1) * 2;
				FLD_体 = 11 + (num10 - 1);
				FLD_身 = 9 + (num10 - 1) * 2;
				for (int num11 = 2; num11 <= num10; num11++)
				{
					if (num11 % 2 == 0)
					{
						人物基本最大_MP += 2;
						int num7 = ++FLD_命中;
						num7 = ++FLD_心;
					}
					else
					{
						FLD_心 += 2;
						人物基本最大_MP += 4;
					}
				}
				if (Player_Level >= 115 && Player_Job_leve >= 6)
				{
					FLD_命中 += 41;
					FLD_回避 += 67;
					FLD_心 += 75;
					FLD_力 += 100;
					FLD_体 += 52;
					FLD_身 += 99;
				}
				break;
			}
			case 10:
			{
				int num18 = Player_Level;
				if (Player_Level >= 130)
				{
					num18 += 5;
				}
				人物基本最大_HP = 145 + (num18 - 1) * 12;
				人物基本最大_MP = 114 + (num18 - 1) * 2;
				FLD_攻击 = 9;
				FLD_防御 = 16 + (num18 - 1) * 2;
				FLD_命中 = 2 + (int)((double)(num18 - 1) / 3.0 + 0.5);
				FLD_回避 = 4 + (int)((double)(num18 - 1) / 2.0 + 0.5);
				FLD_心 = 7 + (num18 - 1);
				FLD_力 = 9;
				FLD_体 = 16 + (num18 - 1) * 2;
				FLD_身 = 8;
				for (int num19 = 2; num19 <= num18; num19++)
				{
					if (num19 % 2 == 0)
					{
						int num7 = ++FLD_力;
						num7 = ++FLD_身;
						num7 = ++FLD_攻击;
					}
					else
					{
						FLD_力 += 2;
						FLD_身 += 2;
						FLD_攻击 += 2;
					}
				}
				if (Player_Level >= 115 && Player_Job_leve >= 6)
				{
					FLD_命中 += 37;
					FLD_回避 += 67;
					FLD_心 += 50;
					FLD_力 += 75;
					FLD_身 += 74;
				}
				break;
			}
			case 11:
			{
				int num24 = Player_Level;
				if (Player_Level >= 130)
				{
					num24 += 5;
				}
				人物基本最大_HP = 133 + (num24 - 1) * 4;
				人物基本最大_MP = 118 + (num24 - 1) * 3;
				人物基本最大_障力 = 145 + (int)((double)(num24 - 1) * 14.07563 + 0.5);
				FLD_攻击 = 11;
				FLD_防御 = 9 + (num24 - 1);
				FLD_命中 = 3 + (int)((double)(num24 - 1) / 3.0 + 0.5);
				FLD_回避 = 5 + (int)((double)(num24 - 1) / 2.0 + 0.5);
				FLD_心 = 9 + (num24 - 1);
				FLD_力 = 11 + (int)((double)(num24 - 1) / 2.0 + 0.5);
				FLD_体 = 9 + (num24 - 1);
				FLD_身 = 11 + (int)((double)(num24 - 1) / 3.0 + 0.5);
				for (int num25 = 2; num25 <= num24; num25++)
				{
					if (num25 % 2 == 0)
					{
						int num7 = ++FLD_攻击;
					}
					else
					{
						FLD_攻击 += 2;
					}
				}
				if (Player_Level >= 115 && Player_Job_leve >= 6)
				{
					FLD_命中 += 12;
					FLD_回避 += 36;
					FLD_心 += 52;
					FLD_力 += 190;
					FLD_体 += 47;
					FLD_身 += 133;
				}
				break;
			}
			case 12:
			{
				int num15 = Player_Level;
				if (Player_Level >= 130)
				{
					num15 += 5;
				}
				人物基本最大_HP = 133 + (num15 - 1) * 7;
				人物基本最大_MP = 118 + (num15 - 1) * 2;
				FLD_攻击 = 13 + (int)((double)(num15 - 1) * 1.5);
				FLD_防御 = 11 + (num15 - 1);
				FLD_命中 = 2 + (int)((double)(num15 - 1) / 3.4 + 0.5);
				FLD_回避 = 3 + (int)((double)(num15 - 1) / 2.0 + 0.5);
				FLD_心 = 9 + (num15 - 1);
				FLD_力 = 13 + (num15 - 1) * 3;
				FLD_体 = 11 + (num15 - 1);
				FLD_身 = 7 + (num15 - 1);
				if (Player_Level >= 115 && Player_Job_leve >= 6)
				{
					FLD_命中 += 12;
					FLD_回避 += 27;
					FLD_心 += 51;
					FLD_力 += 147;
					FLD_体 += 52;
					FLD_身 += 53;
				}
				break;
			}
			case 13:
			{
				int num4 = Player_Level;
				if (Player_Level >= 130)
				{
					num4 += 5;
				}
				人物基本最大_HP = 124 + (num4 - 1) * 7;
				人物基本最大_MP = 136;
				FLD_攻击 = 7 + (int)((double)(num4 - 1) * 1.5);
				FLD_防御 = 8 + (num4 - 1);
				FLD_命中 = 2 + (int)((double)num4 / 4.0 + 0.5);
				FLD_回避 = 3 + (int)((double)num4 / 3.0 + 0.5);
				FLD_心 = 18;
				FLD_力 = 7 + (num4 - 1) * 2;
				FLD_体 = 8 + (num4 - 1);
				FLD_身 = 7 + (num4 - 1);
				for (int m = 2; m <= num4; m++)
				{
					if (m % 2 == 0)
					{
						人物基本最大_MP += 6;
						FLD_心 += 3;
					}
					else
					{
						人物基本最大_MP += 8;
						FLD_心 += 4;
					}
				}
				if (Player_Level >= 115 && Player_Job_leve >= 6)
				{
					FLD_命中 += 21;
					FLD_回避 += 46;
					FLD_心 += 169;
					FLD_力 += 96;
					FLD_体 += 48;
					FLD_身 += 53;
				}
				break;
			}
			}
			FLD_最小攻击 = FLD_攻击;
			switch (Player_Job_leve)
			{
			case 1:
				if (Player_Job == 11)
				{
					FLD_攻击 += 5;
					FLD_防御 += 5;
					人物基本最大_HP += 25;
					人物基本最大_MP += 25;
				}
				else
				{
					FLD_攻击 += 5;
					FLD_防御 += 5;
					人物基本最大_HP += 50;
					人物基本最大_MP += 50;
				}
				break;
			case 2:
				if (Player_Job == 11)
				{
					FLD_攻击 += 15;
					FLD_防御 += 15;
					人物基本最大_HP += 75;
					人物基本最大_MP += 75;
				}
				else
				{
					FLD_攻击 += 15;
					FLD_防御 += 15;
					人物基本最大_HP += 150;
					人物基本最大_MP += 150;
				}
				break;
			case 3:
				if (Player_Job == 11)
				{
					FLD_攻击 += 30;
					FLD_防御 += 30;
					人物基本最大_HP += 175;
					人物基本最大_MP += 175;
				}
				else
				{
					FLD_攻击 += 30;
					FLD_防御 += 30;
					人物基本最大_HP += 350;
					人物基本最大_MP += 350;
				}
				break;
			case 4:
				if (Player_Job == 1)
				{
					FLD_攻击 += 37;
					FLD_防御 += 54;
					人物基本最大_HP += 613;
					人物基本最大_MP += 649;
				}
				else if (Player_Job == 2)
				{
					FLD_攻击 += 40;
					FLD_防御 += 47;
					人物基本最大_HP += 613;
					人物基本最大_MP += 624;
				}
				else if (Player_Job == 3)
				{
					FLD_攻击 += 50;
					FLD_防御 += 50;
					人物基本最大_HP += 650;
					人物基本最大_MP += 650;
				}
				else if (Player_Job == 4)
				{
					FLD_攻击 += 43;
					FLD_防御 += 45;
					人物基本最大_HP += 650;
					人物基本最大_MP += 636;
				}
				else if (Player_Job == 5)
				{
					FLD_攻击 += 35;
					FLD_防御 += 41;
					人物基本最大_HP += 577;
					人物基本最大_MP += 750;
				}
				else if (Player_Job == 6)
				{
					FLD_攻击 += 40;
					FLD_防御 += 42;
					人物基本最大_HP += 577;
					人物基本最大_MP += 745;
				}
				else if (Player_Job == 7)
				{
					FLD_攻击 += 40;
					FLD_防御 += 43;
					人物基本最大_HP += 598;
					人物基本最大_MP += 762;
				}
				else if (Player_Job == 8)
				{
					FLD_攻击 += 37;
					FLD_防御 += 54;
					人物基本最大_HP += 613;
					人物基本最大_MP += 649;
				}
				else if (Player_Job == 9)
				{
					FLD_攻击 += 40;
					FLD_防御 += 47;
					人物基本最大_HP += 613;
					人物基本最大_MP += 624;
				}
				else if (Player_Job == 10)
				{
					FLD_攻击 += 40;
					FLD_防御 += 59;
					人物基本最大_HP += 638;
					人物基本最大_MP += 649;
				}
				else if (Player_Job == 11)
				{
					FLD_攻击 += 37;
					FLD_防御 += 32;
					人物基本最大_HP += 332;
					人物基本最大_MP += 594;
				}
				else if (Player_Job == 12)
				{
					FLD_攻击 += 50;
					FLD_防御 += 50;
					人物基本最大_HP += 650;
					人物基本最大_MP += 650;
				}
				else if (Player_Job == 13)
				{
					FLD_攻击 += 35;
					FLD_防御 += 41;
					人物基本最大_HP += 577;
					人物基本最大_MP += 750;
				}
				break;
			case 5:
				if (Player_Job == 1)
				{
					FLD_攻击 += 70;
					FLD_防御 += 97;
					人物基本最大_HP += 1223;
					人物基本最大_MP += 1177;
				}
				else if (Player_Job == 2)
				{
					FLD_攻击 += 76;
					FLD_防御 += 84;
					人物基本最大_HP += 1223;
					人物基本最大_MP += 1130;
				}
				else if (Player_Job == 3)
				{
					FLD_攻击 += 94;
					FLD_防御 += 90;
					人物基本最大_HP += 1296;
					人物基本最大_MP += 1178;
				}
				else if (Player_Job == 4)
				{
					FLD_攻击 += 81;
					FLD_防御 += 82;
					人物基本最大_HP += 1296;
					人物基本最大_MP += 1152;
				}
				else if (Player_Job == 5)
				{
					FLD_攻击 += 66;
					FLD_防御 += 74;
					人物基本最大_HP += 1150;
					人物基本最大_MP += 1359;
				}
				else if (Player_Job == 6)
				{
					FLD_攻击 += 75;
					FLD_防御 += 75;
					人物基本最大_HP += 1150;
					人物基本最大_MP += 1350;
				}
				else if (Player_Job == 7)
				{
					FLD_攻击 += 76;
					FLD_防御 += 76;
					人物基本最大_HP += 1193;
					人物基本最大_MP += 1380;
				}
				else if (Player_Job == 8)
				{
					FLD_攻击 += 70;
					FLD_防御 += 97;
					人物基本最大_HP += 1223;
					人物基本最大_MP += 1176;
				}
				else if (Player_Job == 9)
				{
					FLD_攻击 += 76;
					FLD_防御 += 84;
					人物基本最大_HP += 1223;
					人物基本最大_MP += 1130;
				}
				else if (Player_Job == 10)
				{
					FLD_攻击 += 76;
					FLD_防御 += 105;
					人物基本最大_HP += 1272;
					人物基本最大_MP += 1177;
				}
				else if (Player_Job == 11)
				{
					FLD_攻击 += 69;
					FLD_防御 += 57;
					人物基本最大_HP += 662;
					人物基本最大_MP += 1076;
				}
				else if (Player_Job == 12)
				{
					FLD_攻击 += 94;
					FLD_防御 += 90;
					人物基本最大_HP += 1296;
					人物基本最大_MP += 1178;
				}
				else if (Player_Job == 13)
				{
					FLD_攻击 += 66;
					FLD_防御 += 74;
					人物基本最大_HP += 1150;
					人物基本最大_MP += 1359;
				}
				break;
			case 6:
				if (Player_Job == 1)
				{
					FLD_攻击 += 207;
					FLD_防御 += 195;
					人物基本最大_HP += 2280;
					人物基本最大_MP += 2411;
				}
				else if (Player_Job == 2)
				{
					FLD_攻击 += 223;
					FLD_防御 += 169;
					人物基本最大_HP += 2280;
					人物基本最大_MP += 2314;
				}
				else if (Player_Job == 3)
				{
					FLD_攻击 += 235;
					FLD_防御 += 180;
					人物基本最大_HP += 2417;
					人物基本最大_MP += 2413;
				}
				else if (Player_Job == 4)
				{
					FLD_攻击 += 238;
					FLD_防御 += 163;
					人物基本最大_HP += 2417;
					人物基本最大_MP += 2361;
				}
				else if (Player_Job == 5)
				{
					FLD_攻击 += 194;
					FLD_防御 += 148;
					人物基本最大_HP += 2144;
					人物基本最大_MP += 2785;
				}
				else if (Player_Job == 6)
				{
					FLD_攻击 += 220;
					FLD_防御 += 150;
					人物基本最大_HP += 2144;
					人物基本最大_MP += 2766;
				}
				else if (Player_Job == 7)
				{
					FLD_攻击 += 222;
					FLD_防御 += 153;
					人物基本最大_HP += 2225;
					人物基本最大_MP += 2827;
				}
				else if (Player_Job == 8)
				{
					FLD_攻击 += 207;
					FLD_防御 += 195;
					人物基本最大_HP += 2280;
					人物基本最大_MP += 2411;
				}
				else if (Player_Job == 9)
				{
					FLD_攻击 += 223;
					FLD_防御 += 169;
					人物基本最大_HP += 2280;
					人物基本最大_MP += 2314;
				}
				else if (Player_Job == 10)
				{
					FLD_攻击 += 223;
					FLD_防御 += 211;
					人物基本最大_HP += 2371;
					人物基本最大_MP += 2411;
				}
				else if (Player_Job == 11)
				{
					FLD_攻击 += 202;
					FLD_防御 += 114;
					人物基本最大_HP += 1234;
					人物基本最大_MP += 2204;
				}
				else if (Player_Job == 12)
				{
					FLD_攻击 += 235;
					FLD_防御 += 180;
					人物基本最大_HP += 2417;
					人物基本最大_MP += 2413;
				}
				else if (Player_Job == 13)
				{
					FLD_攻击 += 194;
					FLD_防御 += 148;
					人物基本最大_HP += 2144;
					人物基本最大_MP += 2785;
				}
				break;
			case 7:
				switch (Player_Job)
				{
				case 1:
					人物基本最大_HP += 2510;
					人物基本最大_MP += 2500;
					FLD_攻击 += 246;
					FLD_防御 += 267;
					break;
				case 2:
					FLD_攻击 += 265;
					FLD_防御 += 232;
					人物基本最大_HP += 2510;
					人物基本最大_MP += 2400;
					break;
				case 3:
					人物基本最大_HP += 2660;
					人物基本最大_MP += 2502;
					FLD_攻击 += 275;
					FLD_防御 += 247;
					break;
				case 4:
					人物基本最大_HP += 2660;
					人物基本最大_MP += 2448;
					FLD_攻击 += 283;
					FLD_防御 += 224;
					break;
				case 5:
					人物基本最大_HP += 2360;
					人物基本最大_MP += 2888;
					FLD_攻击 += 231;
					FLD_防御 += 203;
					break;
				case 6:
					人物基本最大_HP += 2360;
					人物基本最大_MP += 2868;
					FLD_攻击 += 262;
					FLD_防御 += 206;
					break;
				case 7:
					人物基本最大_HP += 2449;
					人物基本最大_MP += 2932;
					FLD_攻击 += 264;
					FLD_防御 += 210;
					break;
				case 8:
					人物基本最大_HP += 2510;
					人物基本最大_MP += 2500;
					FLD_攻击 += 246;
					FLD_防御 += 267;
					break;
				case 9:
					人物基本最大_HP += 2510;
					人物基本最大_MP += 2400;
					FLD_攻击 += 265;
					FLD_防御 += 232;
					break;
				case 10:
					人物基本最大_HP += 2610;
					人物基本最大_MP += 2500;
					FLD_攻击 += 265;
					FLD_防御 += 289;
					break;
				case 11:
					人物基本最大_HP += 1358;
					人物基本最大_MP += 2285;
					FLD_攻击 += 241;
					FLD_防御 += 157;
					break;
				case 12:
					人物基本最大_HP += 2660;
					人物基本最大_MP += 2502;
					FLD_攻击 += 275;
					FLD_防御 += 247;
					break;
				case 13:
					人物基本最大_HP += 2360;
					人物基本最大_MP += 2888;
					FLD_攻击 += 231;
					FLD_防御 += 203;
					break;
				}
				break;
			case 8:
				switch (Player_Job)
				{
				case 1:
					人物基本最大_HP += 3910;
					人物基本最大_MP += 3500;
					FLD_攻击 += 346;
					FLD_防御 += 382;
					break;
				case 2:
					人物基本最大_HP += 3910;
					人物基本最大_MP += 3360;
					FLD_攻击 += 373;
					FLD_防御 += 332;
					break;
				case 3:
					人物基本最大_HP += 4144;
					人物基本最大_MP += 3503;
					FLD_攻击 += 383;
					FLD_防御 += 353;
					break;
				case 4:
					人物基本最大_HP += 4144;
					人物基本最大_MP += 3427;
					FLD_攻击 += 398;
					FLD_防御 += 320;
					break;
				case 5:
					人物基本最大_HP += 3676;
					人物基本最大_MP += 4043;
					FLD_攻击 += 325;
					FLD_防御 += 290;
					break;
				case 6:
					人物基本最大_HP += 3676;
					人物基本最大_MP += 4015;
					FLD_攻击 += 369;
					FLD_防御 += 295;
					break;
				case 7:
					人物基本最大_HP += 3815;
					人物基本最大_MP += 4105;
					FLD_攻击 += 371;
					FLD_防御 += 300;
					break;
				case 8:
					人物基本最大_HP += 3910;
					人物基本最大_MP += 3500;
					FLD_攻击 += 346;
					FLD_防御 += 382;
					break;
				case 9:
					人物基本最大_HP += 3910;
					人物基本最大_MP += 3360;
					FLD_攻击 += 373;
					FLD_防御 += 332;
					break;
				case 10:
					人物基本最大_HP += 4066;
					人物基本最大_MP += 3500;
					FLD_攻击 += 373;
					FLD_防御 += 413;
					break;
				case 11:
					人物基本最大_HP += 2115;
					人物基本最大_MP += 3199;
					FLD_攻击 += 398;
					FLD_防御 += 225;
					break;
				case 12:
					人物基本最大_HP += 4144;
					人物基本最大_MP += 3503;
					FLD_攻击 += 383;
					FLD_防御 += 353;
					break;
				case 13:
					人物基本最大_HP += 3676;
					人物基本最大_MP += 4043;
					FLD_攻击 += 325;
					FLD_防御 += 290;
					break;
				}
				break;
			case 9:
				switch (Player_Job)
				{
				case 1:
					人物基本最大_HP += 6091;
					人物基本最大_MP += 4900;
					FLD_攻击 += 487;
					FLD_防御 += 547;
					break;
				case 2:
					人物基本最大_HP += 6091;
					人物基本最大_MP += 4704;
					FLD_攻击 += 524;
					FLD_防御 += 475;
					break;
				case 3:
					人物基本最大_HP += 6455;
					人物基本最大_MP += 4904;
					FLD_攻击 += 550;
					FLD_防御 += 506;
					break;
				case 4:
					人物基本最大_HP += 6455;
					人物基本最大_MP += 4798;
					FLD_攻击 += 560;
					FLD_防御 += 459;
					break;
				case 5:
					人物基本最大_HP += 5727;
					人物基本最大_MP += 5660;
					FLD_攻击 += 457;
					FLD_防御 += 416;
					break;
				case 6:
					人物基本最大_HP += 5727;
					人物基本最大_MP += 5621;
					FLD_攻击 += 518;
					FLD_防御 += 422;
					break;
				case 7:
					人物基本最大_HP += 5943;
					人物基本最大_MP += 5747;
					FLD_攻击 += 522;
					FLD_防御 += 430;
					break;
				case 8:
					人物基本最大_HP += 6091;
					人物基本最大_MP += 4900;
					FLD_攻击 += 487;
					FLD_防御 += 547;
					break;
				case 9:
					人物基本最大_HP += 6091;
					人物基本最大_MP += 4704;
					FLD_攻击 += 524;
					FLD_防御 += 475;
					break;
				case 10:
					人物基本最大_HP += 6334;
					人物基本最大_MP += 4900;
					FLD_攻击 += 524;
					FLD_防御 += 592;
					break;
				case 11:
					人物基本最大_HP += 3295;
					人物基本最大_MP += 4479;
					FLD_攻击 += 560;
					FLD_防御 += 321;
					break;
				case 12:
					人物基本最大_HP += 6455;
					人物基本最大_MP += 4904;
					FLD_攻击 += 550;
					FLD_防御 += 506;
					break;
				case 13:
					人物基本最大_HP += 5727;
					人物基本最大_MP += 5660;
					FLD_攻击 += 457;
					FLD_防御 += 416;
					break;
				}
				break;
			case 10:
				switch (Player_Job)
				{
				case 1:
					人物基本最大_HP += 9488;
					人物基本最大_MP += 6860;
					FLD_攻击 += 684;
					FLD_防御 += 782;
					break;
				case 2:
					人物基本最大_HP += 9488;
					人物基本最大_MP += 6586;
					FLD_攻击 += 737;
					FLD_防御 += 679;
					break;
				case 3:
					人物基本最大_HP += 10055;
					人物基本最大_MP += 6865;
					FLD_攻击 += 750;
					FLD_防御 += 723;
					break;
				case 4:
					人物基本最大_HP += 10055;
					人物基本最大_MP += 6717;
					FLD_攻击 += 787;
					FLD_防御 += 656;
					break;
				case 5:
					人物基本最大_HP += 8921;
					人物基本最大_MP += 7925;
					FLD_攻击 += 643;
					FLD_防御 += 594;
					break;
				case 6:
					人物基本最大_HP += 8921;
					人物基本最大_MP += 7870;
					FLD_攻击 += 729;
					FLD_防御 += 603;
					break;
				case 7:
					人物基本最大_HP += 9258;
					人物基本最大_MP += 8045;
					FLD_攻击 += 735;
					FLD_防御 += 615;
					break;
				case 8:
					人物基本最大_HP += 9488;
					人物基本最大_MP += 6860;
					FLD_攻击 += 684;
					FLD_防御 += 782;
					break;
				case 9:
					人物基本最大_HP += 9488;
					人物基本最大_MP += 6586;
					FLD_攻击 += 737;
					FLD_防御 += 679;
					break;
				case 10:
					人物基本最大_HP += 9866;
					人物基本最大_MP += 6860;
					FLD_攻击 += 737;
					FLD_防御 += 846;
					break;
				case 11:
					人物基本最大_HP += 5133;
					人物基本最大_MP += 6270;
					FLD_攻击 += 780;
					FLD_防御 += 460;
					break;
				case 12:
					人物基本最大_HP += 10055;
					人物基本最大_MP += 6865;
					FLD_攻击 += 750;
					FLD_防御 += 723;
					break;
				case 13:
					人物基本最大_HP += 8921;
					人物基本最大_MP += 7925;
					FLD_攻击 += 643;
					FLD_防御 += 594;
					break;
				}
				break;
			}
			FLD_最大攻击 = FLD_攻击;
			计算人物装备数据();
			计算人物制作等级();
		}

		public void 更新经验和历练()
		{
			double num = Convert.ToInt64(World.lever[Player_Level]) - Convert.ToInt64(World.lever[Player_Level - 1]);
			double num2 = 人物经验 - Convert.ToInt64(World.lever[Player_Level - 1]);
			if (num2 < 1.0)
			{
				人物经验 = Convert.ToInt64(World.lever[Player_Level - 1]);
				num2 = 0.0;
			}
			发包类 发包类 = new 发包类();
			发包类.Write8((long)num2);
			发包类.Write8((long)num);
			发包类.Write4(0);
			if (Player_ExpErience >= 2000000000)
			{
				Player_ExpErience = 2000000000;
			}
			else if (Player_ExpErience <= 0)
			{
				Player_ExpErience = 0;
			}
			发包类.Write4(Player_ExpErience);
			发包类.Write2(FLD_制作类型);
			发包类.Write2(FLD_制作等级);
			发包类.Write4(FLD_制作熟练度);
			if (Player_Job_leve >= 6)
			{
				升天历练数 += 升天历练当前获得数;
				if (升天历练数 >= 50000000)
				{
					int num3 = 得到包裹空位位置();
					if (num3 != -1)
					{
						升天历练数 -= 50000000;
						增加物品3(Buffer.GetBytes(RxjhClass.GetDBItmeId()), Buffer.GetBytes(1000000714), num3, Buffer.GetBytes(1), new byte[56]);
					}
					else
					{
						系统提示("人物背包没有空位了。");
					}
				}
				发包类.Write4(升天历练数);
				发包类.Write4(升天历练当前获得数);
			}
			else
			{
				发包类.Write4(0);
				发包类.Write4(0);
			}
			发包类.Write4(0);
			发包类.Write4(0);
			升天历练当前获得数 = 0;
			if (Client != null)
			{
				Client.SendPak(发包类, 27136, 人物全服ID);
			}
		}

		public void 更新金钱和负重()
		{
			if (Player_Money < 0L)
			{
				Player_Money = 0L;
			}
			int_50 = 0;
			for (int i = 0; i < 36; i++)
			{
				int_50 += 装备栏包裹[i].物品总重量;
			}
			发包类 发包类 = new 发包类();
			发包类.Write8(Player_Money);
			发包类.Write4(人物当前负重);
			发包类.Write4(人物负重总);
			if (Client != null)
			{
				Client.SendPak(发包类, 31744, 人物全服ID);
			}
		}

		public void 初始化气功()
		{
			发包类 发包类 = new 发包类();
			发包类.Write2(43940);
			发包类.Write2(10);
			发包类.Write4(0);
			发包类.Write4(0);
			发包类.Write2(0);
			for (int i = 0; i < 15; i++)
			{
				if (i < 12)
				{
					发包类.Write2(气功[i].气功ID);
					if (气功[i].气功ID != 0)
					{
						if (气功[i].气功量 != 0)
						{
							发包类.Write2(气功[i].气功量 + FLD_装备_追加_气功 + FLD_人物_追加_气功 + 人物_WX_BUFF_气功 + (int)得到单项气功增加值(i) + FLD_药品_追加_气功);
						}
						else
						{
							发包类.Write2(0);
						}
					}
					else
					{
						发包类.Write2(0);
					}
				}
				else
				{
					发包类.Write4(0);
				}
			}
			发包类.Write2(0);
			发包类.Write2(65520);
			发包类.Write2(7);
			发包类.Write4(0);
			if (Client != null)
			{
				Client.SendPak(发包类, 27648, 人物全服ID);
			}
		}

		public void 更新武勋效果()
		{
			人物_WX_BUFF_生命 = 0;
			人物_WX_BUFF_攻击 = 0;
			人物_WX_BUFF_防御 = 0;
			人物_WX_BUFF_回避 = 0;
			人物_WX_BUFF_内功 = 0;
			人物_WX_BUFF_命中 = 0;
			人物_WX_BUFF_气功 = 0;
			人物追加武勋战力 = 0;
			if (Config.武勋开关 != 0)
			{
				switch (武勋阶段)
				{
				case 2:
					人物_WX_BUFF_攻击 = 5;
					人物_WX_BUFF_防御 = 5;
					break;
				case 3:
					人物_WX_BUFF_攻击 = 10;
					人物_WX_BUFF_防御 = 10;
					break;
				case 4:
					人物_WX_BUFF_生命 = 250;
					人物_WX_BUFF_内功 = 250;
					人物_WX_BUFF_攻击 = 20;
					人物_WX_BUFF_防御 = 20;
					break;
				case 5:
					人物_WX_BUFF_生命 = 500;
					人物_WX_BUFF_内功 = 500;
					人物_WX_BUFF_攻击 = 30;
					人物_WX_BUFF_防御 = 30;
					break;
				case 6:
					人物_WX_BUFF_生命 = 750;
					人物_WX_BUFF_内功 = 750;
					人物_WX_BUFF_攻击 = 70;
					人物_WX_BUFF_防御 = 70;
					break;
				case 7:
					人物_WX_BUFF_生命 = 1000;
					人物_WX_BUFF_内功 = 1000;
					人物_WX_BUFF_攻击 = 120;
					人物_WX_BUFF_防御 = 120;
					break;
				case 8:
					人物_WX_BUFF_生命 = 1200;
					人物_WX_BUFF_内功 = 1200;
					人物_WX_BUFF_攻击 = 140;
					人物_WX_BUFF_防御 = 140;
					人物_WX_BUFF_气功 = 2;
					if (称号药品.ContainsKey(1008001042) || !称号药品.ContainsKey(1008001043))
					{
						人物追加武勋战力 += FLD_攻击 / 50;
					}
					break;
				case 9:
					人物_WX_BUFF_生命 = 1800;
					人物_WX_BUFF_内功 = 2100;
					人物_WX_BUFF_攻击 = 210;
					人物_WX_BUFF_防御 = 210;
					人物_WX_BUFF_气功 = 2;
					if (称号药品.ContainsKey(1008002376) || 称号药品.ContainsKey(1008002377))
					{
						人物追加武勋战力 += FLD_攻击 / 40;
					}
					break;
				}
			}
			Players players = World.检查玩家世界ID(人物全服ID);
			if (players != null)
			{
				players.更新HP_MP_SP();
			}
		}

		public void 计算人物武勋阶段和荣誉()
		{
			try
			{
				if (荣誉ID_ != 0)
				{
					更新荣誉();
					if (荣誉ID_ != 0)
					{
						if (追加状态列表 != null && !GetAddState(荣誉ID_))
						{
							Players players = 得到人物数据(人物全服ID);
							if (players != null)
							{
								追加状态类 追加状态类 = new 追加状态类(players, 604800000, 荣誉ID_, 0);
								players.追加状态列表.Add(追加状态类.FLD_PID, 追加状态类);
								players.状态效果(Buffer.GetBytes(荣誉ID_), 1, 604800000);
							}
						}
					}
					else
					{
						int num = 当前荣誉称号();
						if (num != 0)
						{
							追加状态列表[num].时间结束事件();
							荣誉ID_ = 0;
							FLD_荣誉ID = 0;
						}
					}
				}
			}
			catch
			{
			}
		}

		public int 当前荣誉称号()
		{
			try
			{
				if (追加状态列表 != null && 追加状态列表.Count != 0)
				{
					if (GetAddState(1008001300))
					{
						return 1008001300;
					}
					if (GetAddState(1008001301))
					{
						return 1008001301;
					}
					if (GetAddState(1008001302))
					{
						return 1008001302;
					}
					if (GetAddState(1008001303))
					{
						return 1008001303;
					}
					if (GetAddState(1008001304))
					{
						return 1008001304;
					}
					if (GetAddState(1008001305))
					{
						return 1008001305;
					}
					if (GetAddState(1008001306))
					{
						return 1008001306;
					}
					if (GetAddState(1008001307))
					{
						return 1008001307;
					}
					if (GetAddState(1008001308))
					{
						return 1008001308;
					}
					if (GetAddState(1008001309))
					{
						return 1008001309;
					}
					if (GetAddState(1008001310))
					{
						return 1008001310;
					}
					if (GetAddState(1008001311))
					{
						return 1008001311;
					}
					if (GetAddState(1008001312))
					{
						return 1008001312;
					}
					if (GetAddState(1008001313))
					{
						return 1008001313;
					}
					if (GetAddState(1008001314))
					{
						return 1008001314;
					}
					if (GetAddState(1008001315))
					{
						return 1008001315;
					}
					if (GetAddState(1008001316))
					{
						return 1008001316;
					}
					if (GetAddState(1008001317))
					{
						return 1008001317;
					}
					if (GetAddState(1008001318))
					{
						return 1008001318;
					}
					if (GetAddState(1008001319))
					{
						return 1008001319;
					}
					if (GetAddState(1008001200))
					{
						return 1008001200;
					}
					if (GetAddState(1008001201))
					{
						return 1008001201;
					}
					if (GetAddState(1008001202))
					{
						return 1008001202;
					}
					if (GetAddState(1008001203))
					{
						return 1008001203;
					}
					if (GetAddState(1008001204))
					{
						return 1008001204;
					}
					if (GetAddState(1008001205))
					{
						return 1008001205;
					}
					if (GetAddState(1008001206))
					{
						return 1008001206;
					}
					if (GetAddState(1008001207))
					{
						return 1008001207;
					}
					if (GetAddState(1008001208))
					{
						return 1008001208;
					}
					if (GetAddState(1008001209))
					{
						return 1008001209;
					}
					if (GetAddState(1008001210))
					{
						return 1008001210;
					}
					if (GetAddState(1008001211))
					{
						return 1008001211;
					}
					if (GetAddState(1008001212))
					{
						return 1008001212;
					}
					if (GetAddState(1008001213))
					{
						return 1008001213;
					}
					if (GetAddState(1008001214))
					{
						return 1008001214;
					}
					if (GetAddState(1008001215))
					{
						return 1008001215;
					}
					if (GetAddState(1008001216))
					{
						return 1008001216;
					}
					if (GetAddState(1008001217))
					{
						return 1008001217;
					}
					if (GetAddState(1008001218))
					{
						return 1008001218;
					}
					if (GetAddState(1008001219))
					{
						return 1008001219;
					}
					if (GetAddState(1008001220))
					{
						return 1008001220;
					}
					if (GetAddState(1008001221))
					{
						return 1008001221;
					}
					if (GetAddState(1008001222))
					{
						return 1008001222;
					}
					if (GetAddState(1008001223))
					{
						return 1008001223;
					}
					if (GetAddState(1008001224))
					{
						return 1008001224;
					}
					if (GetAddState(1008001225))
					{
						return 1008001225;
					}
					if (GetAddState(1008001226))
					{
						return 1008001226;
					}
					if (GetAddState(1008001227))
					{
						return 1008001227;
					}
					if (GetAddState(1008001228))
					{
						return 1008001228;
					}
					if (GetAddState(1008001229))
					{
						return 1008001229;
					}
					if (GetAddState(1008001230))
					{
						return 1008001230;
					}
					if (GetAddState(1008001231))
					{
						return 1008001231;
					}
					if (GetAddState(1008001232))
					{
						return 1008001232;
					}
					if (GetAddState(1008001233))
					{
						return 1008001233;
					}
					if (GetAddState(1008001234))
					{
						return 1008001234;
					}
					if (GetAddState(1008001235))
					{
						return 1008001235;
					}
					if (GetAddState(1008001236))
					{
						return 1008001236;
					}
					if (GetAddState(1008001237))
					{
						return 1008001237;
					}
					if (GetAddState(1008001238))
					{
						return 1008001238;
					}
					if (GetAddState(1008001239))
					{
						return 1008001239;
					}
					if (GetAddState(1008001240))
					{
						return 1008001240;
					}
					if (GetAddState(1008001241))
					{
						return 1008001241;
					}
					if (GetAddState(1008001242))
					{
						return 1008001242;
					}
					if (GetAddState(1008001243))
					{
						return 1008001243;
					}
					if (GetAddState(1008001244))
					{
						return 1008001244;
					}
					if (GetAddState(1008001245))
					{
						return 1008001245;
					}
					if (GetAddState(1008001246))
					{
						return 1008001246;
					}
					if (GetAddState(1008001247))
					{
						return 1008001247;
					}
					if (GetAddState(1008001248))
					{
						return 1008001248;
					}
					if (GetAddState(1008001249))
					{
						return 1008001249;
					}
					if (GetAddState(1008001250))
					{
						return 1008001250;
					}
					if (GetAddState(1008001251))
					{
						return 1008001251;
					}
					if (GetAddState(1008001252))
					{
						return 1008001252;
					}
					if (GetAddState(1008001253))
					{
						return 1008001253;
					}
					if (GetAddState(1008001254))
					{
						return 1008001254;
					}
					if (GetAddState(1008001255))
					{
						return 1008001255;
					}
					if (GetAddState(1008001256))
					{
						return 1008001256;
					}
					if (GetAddState(1008001257))
					{
						return 1008001257;
					}
					if (GetAddState(1008001258))
					{
						return 1008001258;
					}
					if (GetAddState(1008001259))
					{
						return 1008001259;
					}
					if (GetAddState(1008001260))
					{
						return 1008001260;
					}
					if (GetAddState(1008001261))
					{
						return 1008001261;
					}
					if (GetAddState(1008001262))
					{
						return 1008001262;
					}
					if (GetAddState(1008001263))
					{
						return 1008001263;
					}
					if (GetAddState(1008001264))
					{
						return 1008001264;
					}
					if (GetAddState(1008001265))
					{
						return 1008001265;
					}
					if (GetAddState(1008001266))
					{
						return 1008001266;
					}
					if (GetAddState(1008001267))
					{
						return 1008001267;
					}
					if (GetAddState(1008001268))
					{
						return 1008001268;
					}
					if (GetAddState(1008001269))
					{
						return 1008001269;
					}
					if (GetAddState(1008001270))
					{
						return 1008001270;
					}
					if (GetAddState(1008001271))
					{
						return 1008001271;
					}
					if (GetAddState(1008001272))
					{
						return 1008001272;
					}
					if (GetAddState(1008001273))
					{
						return 1008001273;
					}
					if (GetAddState(1008001274))
					{
						return 1008001274;
					}
					if (GetAddState(1008001275))
					{
						return 1008001275;
					}
					if (GetAddState(1008001276))
					{
						return 1008001276;
					}
					if (GetAddState(1008001277))
					{
						return 1008001277;
					}
					if (GetAddState(1008001278))
					{
						return 1008001278;
					}
					if (GetAddState(1008001279))
					{
						return 1008001279;
					}
					if (GetAddState(1008001280))
					{
						return 1008001280;
					}
					if (GetAddState(1008001281))
					{
						return 1008001281;
					}
					if (GetAddState(1008001282))
					{
						return 1008001282;
					}
					if (GetAddState(1008001283))
					{
						return 1008001283;
					}
					if (GetAddState(1008001284))
					{
						return 1008001284;
					}
					if (GetAddState(1008001285))
					{
						return 1008001285;
					}
					if (GetAddState(1008001286))
					{
						return 1008001286;
					}
					if (GetAddState(1008001287))
					{
						return 1008001287;
					}
					if (GetAddState(1008001288))
					{
						return 1008001288;
					}
					if (GetAddState(1008001289))
					{
						return 1008001289;
					}
					if (GetAddState(1008001290))
					{
						return 1008001290;
					}
					if (GetAddState(1008001291))
					{
						return 1008001291;
					}
					if (GetAddState(1008001292))
					{
						return 1008001292;
					}
					if (GetAddState(1008001293))
					{
						return 1008001293;
					}
					if (GetAddState(1008001294))
					{
						return 1008001294;
					}
					if (GetAddState(1008001295))
					{
						return 1008001295;
					}
					if (GetAddState(1008001296))
					{
						return 1008001296;
					}
					if (GetAddState(1008001297))
					{
						return 1008001297;
					}
					return GetAddState(1008001298) ? 1008001298 : (GetAddState(1008001299) ? 1008001299 : 0);
				}
				return 0;
			}
			catch
			{
				return 0;
			}
		}

		public bool 荣誉前十名()
		{
			try
			{
				return 追加状态列表 != null && 追加状态列表.Count != 0 && (GetAddState(1008001300) || GetAddState(1008001301) || GetAddState(1008001302) || GetAddState(1008001303) || GetAddState(1008001304) || GetAddState(1008001305) || GetAddState(1008001306) || GetAddState(1008001307) || GetAddState(1008001308) || GetAddState(1008001309) || GetAddState(1008001310) || GetAddState(1008001311) || GetAddState(1008001312) || GetAddState(1008001313) || GetAddState(1008001314) || GetAddState(1008001315) || GetAddState(1008001316) || GetAddState(1008001317) || GetAddState(1008001318) || GetAddState(1008001319));
			}
			catch
			{
				return false;
			}
		}

		public void 更新荣誉()
		{
            try
            {
                int 荣誉Id = this.get_荣誉ID(this.UserName, 3);
                if (荣誉Id == 0)
                {
                    荣誉Id = this.get_荣誉ID(this.UserName, 2);
                    if (荣誉Id == 0)
                        荣誉Id = this.get_荣誉ID(this.UserName, 1);
                }
                if (荣誉Id == 0)
                {
                    this.FLD_荣誉ID = 0;
                    this.荣誉ID_ = 0;
                }
                else
                {
                    this.荣誉ID_ = 荣誉Id;
                    if (荣誉Id < 1008001250)
                        this.FLD_荣誉ID = 荣誉Id - 1008001099;
                    else
                        this.FLD_荣誉ID = 荣誉Id - 1008001049;
                }
            }
            catch
            {
            }
        }

		public void 更新武功和状态()
		{
			int num = 0;
			bool flag = false;
			bool flag2 = false;
			if ((Player_Zx == 1 && 称号药品.ContainsKey(1008001042)) || (Player_Zx == 2 && 称号药品.ContainsKey(1008001043)))
			{
				flag = true;
			}
			if ((Player_Zx == 1 && 称号药品.ContainsKey(1008002376)) || (Player_Zx == 2 && 称号药品.ContainsKey(1008002377)))
			{
				flag2 = true;
			}
			if ((double)Player_WuXun > World.Wxlever[8] && flag2)
			{
				武勋阶段 = 9;
			}
			else if ((double)Player_WuXun > World.Wxlever[7] && flag)
			{
				武勋阶段 = 8;
			}
			else if ((double)Player_WuXun > World.Wxlever[6])
			{
				武勋阶段 = 7;
			}
			else if ((double)Player_WuXun > World.Wxlever[5])
			{
				武勋阶段 = 6;
			}
			else if ((double)Player_WuXun > World.Wxlever[4])
			{
				武勋阶段 = 5;
			}
			else if ((double)Player_WuXun > World.Wxlever[3])
			{
				武勋阶段 = 4;
			}
			else if ((double)Player_WuXun > World.Wxlever[2])
			{
				武勋阶段 = 3;
			}
			else if ((double)Player_WuXun > World.Wxlever[1])
			{
				武勋阶段 = 2;
			}
			else if ((double)Player_WuXun > World.Wxlever[0])
			{
				武勋阶段 = 1;
			}
			try
			{
				更新武勋效果();
				计算人物武勋阶段和荣誉();
				num = 1;
				发包类 发包类 = new 发包类();
				发包类.Write2(Player_Level);
				发包类.Write2(FLD_心 + FLD_装备_追加_心);
				发包类.Write2(FLD_力 + FLD_装备_追加_力);
				发包类.Write2(FLD_体 + FLD_装备_追加_体);
				发包类.Write2(FLD_身 + FLD_装备_追加_身);
				发包类.Write2(0);
				发包类.Write2(FLD_人物基本_攻击);
				发包类.Write2(FLD_人物基本_防御);
				发包类.Write2(FLD_人物基本_命中);
				发包类.Write2(FLD_人物基本_回避);
				发包类.Write2(Player_Qigong_point);
				num = 2;
				for (int i = 0; i < 15; i++)
				{
					if (i < 12)
					{
						发包类.Write2(气功[i].气功ID);
						if (气功[i].气功ID != 0)
						{
							if (气功[i].气功量 != 0)
							{
								发包类.Write2(气功[i].气功量 + FLD_装备_追加_气功 + FLD_人物_追加_气功 + 人物_WX_BUFF_气功 + (int)得到单项气功增加值(i) + FLD_药品_追加_气功);
							}
							else
							{
								发包类.Write2(0);
							}
						}
						else
						{
							发包类.Write2(0);
						}
					}
					else
					{
						发包类.Write4(0);
					}
				}
				num = 3;
				发包类.Write2(0);
				for (int j = 0; j < 32; j++)
				{
					if (武功新[0, j] != null)
					{
						发包类.Write4(武功新[0, j].FLD_PID);
					}
					else
					{
						发包类.Write4(0);
					}
				}
				for (int k = 0; k < 28; k++)
				{
					if (武功新[1, k] != null)
					{
						发包类.Write4(武功新[1, k].FLD_PID);
					}
					else
					{
						发包类.Write4(0);
					}
				}
				发包类.Write4(0);
				for (int l = 0; l < 15; l++)
				{
					if (武功新[2, l] != null)
					{
						发包类.Write4(武功新[2, l].FLD_PID);
					}
					else
					{
						发包类.Write4(0);
					}
				}
				num = 4;
				for (int m = 0; m < 32; m++)
				{
					if (武功新[0, m] != null)
					{
						发包类.Write2(武功新[0, m].武功_等级);
					}
					else
					{
						发包类.Write2(0);
					}
				}
				for (int n = 0; n < 28; n++)
				{
					if (武功新[1, n] != null)
					{
						发包类.Write2(武功新[1, n].武功_等级);
					}
					else
					{
						发包类.Write2(0);
					}
				}
				for (int num2 = 0; num2 < 16; num2++)
				{
					if (武功新[2, num2] != null)
					{
						发包类.Write2(武功新[2, num2].武功_等级);
					}
					else
					{
						发包类.Write2(0);
					}
				}
				num = 5;
				for (int num3 = 0; num3 < 32; num3++)
				{
					if (武功新[0, num3] != null)
					{
						发包类.Write2(武功新[0, num3].FLD_武功最高级别);
					}
					else
					{
						发包类.Write2(0);
					}
				}
				for (int num4 = 0; num4 < 28; num4++)
				{
					if (武功新[1, num4] != null)
					{
						发包类.Write2(武功新[1, num4].FLD_武功最高级别);
					}
					else
					{
						发包类.Write2(0);
					}
				}
				for (int num5 = 0; num5 < 16; num5++)
				{
					if (武功新[2, num5] != null)
					{
						发包类.Write2(武功新[2, num5].FLD_武功最高级别);
					}
					else
					{
						发包类.Write2(0);
					}
				}
				num = 6;
				if (武功新[2, 16] != null)
				{
					发包类.Write4(武功新[2, 16].FLD_PID);
				}
				else
				{
					发包类.Write4(0);
				}
				if (武功新[2, 17] != null)
				{
					发包类.Write4(武功新[2, 17].FLD_PID);
				}
				else
				{
					发包类.Write4(1);
				}
				num = 7;
				发包类.Write4((int)((FLD_装备_武功防御力 + (double)人物_气功_追加_武功防御力) * (1.0 + FLD_人物_武功防御力增加百分比 + FLD_人物_气功_武功防御力增加百分比)));
				if (Player_WuXun < 1500000)
				{
					if (GetAddState(1008001042))
					{
						追加状态列表[1008001042].时间结束事件();
					}
					if (GetAddState(1008001043))
					{
						追加状态列表[1008001043].时间结束事件();
					}
				}
				发包类.Write4(Player_WuXun);
				发包类.Write4(人物善恶);
				发包类.Write4(Player_Job);
				发包类.Write4(100);
				发包类.Write2(1);
				num = 8;
				if (升天气功 != null && 升天气功.Count > 0)
				{
					foreach (升天气功类 value2 in 升天气功.Values)
					{
						发包类.Write2(value2.气功ID);
						if (value2.气功量 != 0)
						{
							发包类.Write2(value2.气功量 + FLD_装备_追加_气功 + FLD_人物_追加_气功 + 人物_WX_BUFF_气功 + (int)得到单项气功增加值(value2.气功ID) + FLD_药品_追加_气功);
						}
						else
						{
							发包类.Write2(0);
						}
					}
					for (int num6 = 0; num6 < 17 - 升天气功.Count; num6++)
					{
						发包类.Write4(0);
					}
				}
				else
				{
					for (int num7 = 0; num7 < 17; num7++)
					{
						发包类.Write4(0);
					}
				}
				发包类.Write2(0);
				num = 9;
				for (int num8 = 1; num8 < 28; num8++)
				{
					if (武功新[3, num8] != null)
					{
						发包类.Write4(武功新[3, num8].FLD_PID);
						发包类.Write4(武功新[3, num8].武功_等级);
					}
					else
					{
						发包类.Write4(0);
						发包类.Write4(0);
					}
				}
				num = 10;
				发包类.Write4(升天武功点数);
				for (int num9 = 0; num9 < 15; num9++)
				{
					if (num9 < 12)
					{
						if (气功[num9].气功ID != 0)
						{
							发包类.Write((byte)气功[num9].气功量);
						}
						else
						{
							发包类.Write(0);
						}
					}
					else
					{
						发包类.Write(0);
					}
				}
				num = 11;
				if (升天气功 != null && 升天气功.Count > 0)
				{
					foreach (升天气功类 value3 in 升天气功.Values)
					{
						发包类.Write((byte)value3.气功量);
					}
					for (int num10 = 0; num10 < 15 - 升天气功.Count; num10++)
					{
						发包类.Write(0);
					}
				}
				else
				{
					for (int num11 = 0; num11 < 15; num11++)
					{
						发包类.Write(0);
					}
				}
				num = 12;
				发包类.Write2(0);
				int value = (int)((double)(FLD_心 + FLD_装备_追加_心 + FLD_力 + FLD_装备_追加_力 + FLD_体 + FLD_装备_追加_体 + FLD_身 + FLD_装备_追加_身) * 0.5);
				发包类.Write4(value);
				发包类.Write4(value);
				发包类.Write4((int)((double)FLD_人物基本_命中 * 0.7));
				发包类.Write4(Player_Whtb);
				发包类.Write2(人物_追加_PVP战力);
				int num12 = 计算每日武勋量(Player_Job_leve);
				if (num12 > 30000)
				{
					发包类.Write2(0);
				}
				else
				{
					发包类.Write2(num12);
				}
				发包类.Write2(丢失武勋);
				发包类.Write2(装备追加对怪攻击 + 药品追加对怪攻击);
				发包类.Write2(装备追加对怪防御 + (int)base.升天五式_魔魂之力 + 药品追加对怪防御);
				发包类.Write2(0);
				if (Player_Job == 13)
				{
					for (int num13 = 5; num13 < 23; num13++)
					{
						if (武功新[1, num13] != null)
						{
							发包类.Write4(武功新[1, num13].FLD_PID);
							发包类.Write4(武功新[1, num13].武功_等级);
							发包类.Write4(武功新[1, num13].FLD_武功最高级别);
						}
						else
						{
							发包类.Write4(0);
							发包类.Write4(0);
							发包类.Write4(0);
						}
					}
					发包类.Write2(神女武功点数);
				}
				num = 13;
				if (Client != null)
				{
					Client.SendPak(发包类, 27392, 人物全服ID);
				}
			}
			catch (Exception ex)
			{
				logo.FileTxtLog("更新武功和状态出错[" + Userid + "]-[" + UserName + "][" + num + "]" + ex.Message);
				Form1.WriteLine(1, "更新武功和状态出错[" + Userid + "]-[" + UserName + "] " + ex.Message);
			}
		}

		public int 计算每日武勋量(int int_109)
		{
			if (人物坐标_地图 != 101 && 人物坐标_地图 != 201 && 人物坐标_地图 != 301 && 人物坐标_地图 != 1001 && 人物坐标_地图 != 1101)
			{
				if (World.week != 0 && World.week != 6)
				{
					if (int_109 < 2)
					{
						return 0;
					}
					switch (int_109)
					{
					default:
						return 0;
					case 2:
						return World.二转每日武勋上限;
					case 3:
						return World.三转每日武勋上限;
					case 4:
						return World.四转每日武勋上限;
					case 5:
						return World.五转每日武勋上限;
					case 6:
						return World.六转每日武勋上限;
					case 7:
						return World.七转每日武勋上限;
					case 8:
						return World.八转每日武勋上限;
					case 9:
						return World.九转每日武勋上限;
					case 10:
						return World.十转每日武勋上限;
					}
				}
				return World.周末武勋量;
			}
			return 1000000;
		}

		public void 发送任务物品列表()
		{
			try
			{
				using (发包类 发包类 = new 发包类())
				{
					发包类.Write4(36);
					for (int i = 0; i < 36; i++)
					{
						发包类.Write4(i);
						发包类.Write4(0);
						发包类.Write4(任务物品[i].物品ID);
						发包类.Write4(0);
						发包类.Write4(任务物品[i].物品数量);
					}
					if (Client != null)
					{
						Client.SendPak(发包类, 33024, 人物全服ID);
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "发送任务物品列表出错![" + Userid + "]-[" + UserName + "]" + ((ex != null) ? ex.ToString() : null));
			}
		}

		public void 初始化行囊凝神珠包裹()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("AA5522022C0171001402ABFB010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000055AA");
			byte[] array = Converter.hexStringToByte(stringBuilder.ToString());
			System.Buffer.BlockCopy(BitConverter.GetBytes(人物全服ID), 0, array, 4, 2);
			if (Client != null)
			{
				Client.Send(array, array.Length);
			}
		}

		public void 初始化披风行囊()
		{
			发包类 发包类 = new 发包类();
			发包类.Write4(169);
			发包类.Write4(1);
			for (int i = 0; i < 66; i++)
			{
				if (Buffer.ToInt32(披风行囊[i].物品数量, 0) == 0)
				{
					披风行囊[i].物品_byte = new byte[World.数据库单个物品大小];
					发包类.Write(new byte[World.发包单个物品大小], 0, World.发包单个物品大小);
				}
				else
				{
					发包类.Write(披风行囊[i].GetByte(), 0, World.发包单个物品大小);
				}
			}
			if (Client != null)
			{
				Client.SendPak(发包类, 40448, 人物全服ID);
			}
		}

		public void 初始化装备篮包裹()
		{
			try
			{
				发包类 发包类 = new 发包类();
				发包类.Write1(1);
				发包类.Write1(251);
				发包类.Write1(1);
				发包类.Write1(0);
				发包类.Write4(2);
				for (int i = 0; i < 66; i++)
				{
					if (BitConverter.ToInt32(装备栏包裹[i].物品数量, 0) == 0)
					{
						装备栏包裹[i].物品_byte = new byte[73];
					}
					else
					{
						检查物品系统("装备栏包裹", ref 装备栏包裹[i]);
					}
					if (装备栏包裹[i].FLD_FJ_中级附魂 <= 22 && 装备栏包裹[i].FLD_FJ_中级附魂 >= 21 && 装备栏包裹[i].FLD_FJ_觉醒 > 0)
					{
						装备栏包裹[i].物品_中级附魂_追加_觉醒 = 装备栏包裹[i].FLD_FJ_中级附魂 - 20;
					}
					发包类.Write(装备栏包裹[i].GetByte(), 0, 96);
				}
				if (Client != null)
				{
					Client.SendPak(发包类, 28928, 人物全服ID);
				}
			}
			catch (Exception)
			{
			}
		}

		public void 初始化已装备物品()
		{
			try
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("AA55920C3905A0008C0C01000000390500008157D2B9C9EEC8CBBEB2ECE100000000000000000000000000000000000000000000000600000100780007000201FEFFD307D10701010000000000C100007041000092C2B10400000000000001000100000000000000000000000000FFFFFFFFFFFFFFFF0100000001000000FF9666FFFF9666FF0200000006000000FFFFFFFFFF5000FF000000000000000000000000000000000000010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000ADF496F42464411749CFEE0B000000000100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000269369A8AE48411741CFEE0B00000000010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000055AA");
				byte[] array = Converter.hexStringToByte(stringBuilder.ToString());
				byte[] bytes = Encoding.Default.GetBytes(UserName);
				System.Buffer.BlockCopy(bytes, 0, array, 18, bytes.Length);
				System.Buffer.BlockCopy(BitConverter.GetBytes(人物坐标_X), 0, array, 74, 4);
				System.Buffer.BlockCopy(BitConverter.GetBytes(人物坐标_Z), 0, array, 78, 4);
				System.Buffer.BlockCopy(BitConverter.GetBytes(人物坐标_Y), 0, array, 82, 4);
				System.Buffer.BlockCopy(BitConverter.GetBytes(人物坐标_地图), 0, array, 86, 2);
				System.Buffer.BlockCopy(BitConverter.GetBytes(人物全服ID), 0, array, 4, 2);
				System.Buffer.BlockCopy(BitConverter.GetBytes(人物全服ID), 0, array, 14, 2);
				System.Buffer.BlockCopy(BitConverter.GetBytes(Player_Zx), 0, array, 56, 1);
				System.Buffer.BlockCopy(BitConverter.GetBytes(Player_Level), 0, array, 59, 1);
				System.Buffer.BlockCopy(BitConverter.GetBytes(Player_Job_leve), 0, array, 60, 1);
				System.Buffer.BlockCopy(BitConverter.GetBytes(Player_Job), 0, array, 62, 1);
				if (帮派Id != 0)
				{
					byte[] bytes2 = BitConverter.GetBytes(帮派Id);
					System.Buffer.BlockCopy(bytes2, 0, array, 34, bytes2.Length);
					byte[] bytes3 = Encoding.Default.GetBytes(帮派名字);
					System.Buffer.BlockCopy(bytes3, 0, array, 38, bytes3.Length);
					System.Buffer.BlockCopy(BitConverter.GetBytes(帮派人物等级), 0, array, 53, 1);
					if (帮派门徽 != null)
					{
						System.Buffer.BlockCopy(BitConverter.GetBytes(World.服务器组ID), 0, array, 54, 1);
					}
				}
				System.Buffer.BlockCopy(BitConverter.GetBytes(New人物模版.发色), 0, array, 64, 2);
				System.Buffer.BlockCopy(BitConverter.GetBytes(New人物模版.发型), 0, array, 66, 2);
				System.Buffer.BlockCopy(BitConverter.GetBytes(New人物模版.性别), 0, array, 71, 1);
				System.Buffer.BlockCopy(人物名字模版, 0, array, 102, 48);
				for (int i = 0; i < 15; i++)
				{
					if (BitConverter.ToInt32(装备栏已穿装备[i].物品数量, 0) == 0)
					{
						装备栏已穿装备[i].物品_byte = new byte[73];
					}
					if (装备栏已穿装备[i].FLD_FJ_中级附魂 <= 22 && 装备栏已穿装备[i].FLD_FJ_中级附魂 >= 21 && 装备栏已穿装备[i].FLD_FJ_觉醒 > 0)
					{
						装备栏已穿装备[i].物品_中级附魂_追加_觉醒 = 装备栏已穿装备[i].FLD_FJ_中级附魂 - 20;
					}
					System.Buffer.BlockCopy(装备栏已穿装备[i].GetByte(), 0, array, 150 + i * World.发包单个物品大小, World.发包单个物品大小);
				}
				for (int j = 0; j < 15; j++)
				{
					if (BitConverter.ToInt32(辅助装备栏装备[j].物品数量, 0) == 0)
					{
						辅助装备栏装备[j].物品_byte = new byte[73];
					}
					System.Buffer.BlockCopy(辅助装备栏装备[j].GetByte(), 0, array, 1590 + j * World.发包单个物品大小, World.发包单个物品大小);
				}
				if (BitConverter.ToInt32(装备栏已穿装备[15].物品数量, 0) != 0)
				{
					System.Buffer.BlockCopy(装备栏已穿装备[15].GetByte(), 0, array, 3030, World.发包单个物品大小);
				}
				System.Buffer.BlockCopy(BitConverter.GetBytes(人物全服ID), 0, array, 4, 2);
				if (Client != null)
				{
					Client.Send多包(array, array.Length);
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "初始话已装备物品出错[" + Userid + "]-[" + UserName + "]" + ex.Message);
			}
		}

		public void 更新制作系统()
		{
			List<int> list = 制作物品类.Get制作物品类列表(FLD_制作类型, FLD_制作等级);
			if (list != null && list.Count > 0)
			{
				发包类 发包类 = new 发包类();
				发包类.Write2(list.Count);
				foreach (int item in list)
				{
					发包类.Write8(item);
					发包类.Write4(10000);
					发包类.Write2(0);
					发包类.Write2(1);
					发包类.Write2(1);
					if (FLD_制作类型 == 3)
					{
						发包类.Write2(FLD_制作类型);
						发包类.Write2(16);
					}
					else
					{
						发包类.Write2(FLD_制作类型);
					}
				}
				if (Client != null)
				{
					Client.SendPak(发包类, 13079, 人物全服ID);
				}
			}
		}

		public void 更新情侣系统(int int_109, string string_11, string string_12, int int_110, DateTime dateTime_3)
		{
			byte[] array = Converter.hexStringToByte("AA558E00A6007C17800001000000714C7E0000000000C4687E0000000000BDD600000000000000000000000000B7709C000000000000AC89014D00000000AC89014D040000002330000002D0A9B77406000000000000A59D0300CB1C0A4D00000000010000000000000000000000000000000000000000000000000000000000000000000000001F86A3000000000000568055AA");
			DateTime value = new DateTime(1970, 1, 1, 8, 0, 0);
			System.Buffer.BlockCopy(BitConverter.GetBytes(int_109), 0, array, 10, 2);
			byte[] bytes = Encoding.Default.GetBytes(string_11);
			System.Buffer.BlockCopy(bytes, 0, array, 30, bytes.Length);
			if (int_110 == 0)
			{
				System.Buffer.BlockCopy(BitConverter.GetBytes(int_110), 0, array, 58, 4);
				System.Buffer.BlockCopy(BitConverter.GetBytes(0), 0, array, 62, 4);
			}
			else
			{
				System.Buffer.BlockCopy(BitConverter.GetBytes(1), 0, array, 58, 4);
				System.Buffer.BlockCopy(BitConverter.GetBytes((int)DateTime.Now.AddMinutes(int_110 - 4320 - 5760).Subtract(value).TotalSeconds), 0, array, 62, 4);
			}
			System.Buffer.BlockCopy(BitConverter.GetBytes(FLD_爱情度等级), 0, array, 66, 4);
			System.Buffer.BlockCopy(BitConverter.GetBytes(FLD_情侣_爱情度), 0, array, 70, 4);
			if (是否已婚 == 1)
			{
				System.Buffer.BlockCopy(BitConverter.GetBytes(1), 0, array, 74, 1);
			}
			else
			{
				System.Buffer.BlockCopy(BitConverter.GetBytes(0), 0, array, 74, 1);
			}
			System.Buffer.BlockCopy(BitConverter.GetBytes((int)FLD_结婚纪念日.Subtract(value).TotalSeconds), 0, array, 90, 4);
			if (string_12.Length != 0)
			{
				byte[] bytes2 = Encoding.Default.GetBytes(string_12);
				System.Buffer.BlockCopy(bytes2, 0, array, 102, bytes2.Length);
			}
			System.Buffer.BlockCopy(BitConverter.GetBytes(人物全服ID), 0, array, 4, 2);
			if (Client != null)
			{
				Client.Send多包(array, array.Length);
			}
		}

		public void 保存人物数据存储过程()
		{
			if (UserName.Length != 0)
			{
				try
				{
					SqlParameter[] prams = new SqlParameter[59]
					{
						SqlDBA.MakeInParam("@id", SqlDbType.VarChar, 20, Userid),
						SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 20, UserName),
						SqlDBA.MakeInParam("@level", SqlDbType.Int, 0, Player_Level),
						SqlDBA.MakeInParam("@strFace", SqlDbType.VarBinary, 20, New人物模版.人物模板_byte),
						SqlDBA.MakeInParam("@job", SqlDbType.Int, 0, Player_Job),
						SqlDBA.MakeInParam("@exp", SqlDbType.VarChar, 50, 人物经验),
						SqlDBA.MakeInParam("@zx", SqlDbType.Int, 0, Player_Zx),
						SqlDBA.MakeInParam("@job_level", SqlDbType.Int, 0, Player_Job_leve),
						SqlDBA.MakeInParam("@x", SqlDbType.Float, 0, 人物坐标_X),
						SqlDBA.MakeInParam("@y", SqlDbType.Float, 0, 人物坐标_Y),
						SqlDBA.MakeInParam("@z", SqlDbType.Float, 0, 人物坐标_Z),
						SqlDBA.MakeInParam("@menow", SqlDbType.Int, 0, 人物坐标_地图),
						SqlDBA.MakeInParam("@money", SqlDbType.VarChar, 0, Player_Money),
						SqlDBA.MakeInParam("@hp", SqlDbType.Int, 0, 人物_HP),
						SqlDBA.MakeInParam("@mp", SqlDbType.Int, 0, 人物_MP),
						SqlDBA.MakeInParam("@sp", SqlDbType.Int, 0, 人物_SP),
						SqlDBA.MakeInParam("@wx", SqlDbType.Int, 0, Player_WuXun),
						SqlDBA.MakeInParam("@se", SqlDbType.Int, 0, 人物善恶),
						SqlDBA.MakeInParam("@point", SqlDbType.Int, 0, Player_Qigong_point),
						SqlDBA.MakeInParam("@strSkills", SqlDbType.VarBinary, 20, GetWgCodesbyte()),
						SqlDBA.MakeInParam("@strWearitem", SqlDbType.VarBinary, 2464, GetWEARITEMCodesbyte()),
						SqlDBA.MakeInParam("@strItem", SqlDbType.VarBinary, 5082, GetFLD_ITEMCodesbyte()),
						SqlDBA.MakeInParam("@strFaskion", SqlDbType.VarBinary, 5082, GetFLD_FASHION_ITEMCodesbyte()),
						SqlDBA.MakeInParam("@strQusetItem", SqlDbType.VarBinary, 300, GetQuestITEMCodesbyte()),
						SqlDBA.MakeInParam("@strKongfu", SqlDbType.VarBinary, 768, GetFLD_KONGFUCodesbyte()),
						SqlDBA.MakeInParam("@strCtime", SqlDbType.VarBinary, 320, Get个人药品byte()),
						SqlDBA.MakeInParam("@strDoors", SqlDbType.VarBinary, 1200, Get土灵符byte()),
						SqlDBA.MakeInParam("@strQuest", SqlDbType.VarBinary, 400, Get任务byte()),
						SqlDBA.MakeInParam("@fight_exp", SqlDbType.Int, 0, Player_ExpErience),
						SqlDBA.MakeInParam("@rwqg", SqlDbType.Int, 0, 人物轻功),
						SqlDBA.MakeInParam("@NameType", SqlDbType.VarBinary, 48, 人物名字模版),
						SqlDBA.MakeInParam("@zbver", SqlDbType.Int, 0, 装备数据版本),
						SqlDBA.MakeInParam("@zzlx", SqlDbType.Int, 0, FLD_制作类型),
						SqlDBA.MakeInParam("@zzsld", SqlDbType.Int, 0, FLD_制作熟练度),
						SqlDBA.MakeInParam("@strCtimeNew", SqlDbType.VarBinary, 240, Get个人药品Newbyte()),
						SqlDBA.MakeInParam("@qlname", SqlDbType.VarChar, 20, FLD_情侣),
						SqlDBA.MakeInParam("@qlaqd", SqlDbType.Int, 0, FLD_情侣_爱情度),
						SqlDBA.MakeInParam("@qljzname", SqlDbType.VarChar, 0, FLD_情侣戒指),
						SqlDBA.MakeInParam("@maritalstatus", SqlDbType.Int, 0, 解除关系倒计时),
						SqlDBA.MakeInParam("@maried", SqlDbType.Int, 0, 是否已婚),
						SqlDBA.MakeInParam("@loveword", SqlDbType.VarChar, 50, 婚戒刻字),
						SqlDBA.MakeInParam("@strStSkills", SqlDbType.VarBinary, 64, Get升天气功Codesbyte()),
						SqlDBA.MakeInParam("@strStKongfu", SqlDbType.VarBinary, 256, Get升天武功Codesbyte()),
						SqlDBA.MakeInParam("@stlilian", SqlDbType.Int, 0, 升天历练数),
						SqlDBA.MakeInParam("@stwugongdian", SqlDbType.Int, 0, 升天武功点数),
						SqlDBA.MakeInParam("@chjh", SqlDbType.Int, 0, 称号积分),
						SqlDBA.MakeInParam("@jhdate", SqlDbType.DateTime, 0, FLD_结婚纪念日),
						SqlDBA.MakeInParam("@pvpiont", SqlDbType.Int, 0, FLD_PVP_Piont),
						SqlDBA.MakeInParam("@fbtime", SqlDbType.Int, 0, 修炼地图剩余时间),
						SqlDBA.MakeInParam("@hdtime", SqlDbType.Int, 0, 活动地图剩余时间),
						SqlDBA.MakeInParam("@lostwx", SqlDbType.Int, 0, 丢失武勋),
						SqlDBA.MakeInParam("@getwx", SqlDbType.Int, 0, 每日获得武勋),
						SqlDBA.MakeInParam("@mgchjh", SqlDbType.Int, 0, 玫瑰称号积分),
						SqlDBA.MakeInParam("@mpgxd", SqlDbType.Int, 0, 门派贡献度),
						SqlDBA.MakeInParam("@whtb", SqlDbType.Int, 0, Player_Whtb),
						SqlDBA.MakeInParam("@strCHtime", SqlDbType.VarBinary, 320, Get称号药品byte()),
						SqlDBA.MakeInParam("@strStime", SqlDbType.VarBinary, 320, Get时间药品byte()),
						SqlDBA.MakeInParam("@snwugongdian", SqlDbType.Int, 0, 神女武功点数),
						SqlDBA.MakeInParam("@config", SqlDbType.VarChar, 100, 客户端设置)
					};
					World.SqlPool.Enqueue(new DbPoolClass
					{
						Conn = DBA.getstrConnection(null),
						Prams = prams,
						Sql = "XWWL_UPDATE_USER_DATA_NEW"
					});
					if (师傅数据.TID != -1)
					{
						保存师徒数据存储过程();
					}
				}
				catch (Exception ex)
				{
					Form1.WriteLine(1, "保存人物数据出错[" + Userid + "]-[" + UserName + "]" + ex.Message);
				}
			}
		}

		public void 保存师徒数据存储过程()
		{
			if (World.jlMsg == 1)
			{
				Form1.WriteLine(0, "PlayersBes_保存师徒数据存储过程()");
			}
			try
			{
				SqlParameter[] prams = new SqlParameter[7]
				{
					SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 20, UserName),
					SqlDBA.MakeInParam("@level", SqlDbType.Int, 0, 师傅数据.TLEVEL),
					SqlDBA.MakeInParam("@stlevel", SqlDbType.Int, 0, 师傅数据.STLEVEL),
					SqlDBA.MakeInParam("@styhd", SqlDbType.Int, 0, 师傅数据.STYHD),
					SqlDBA.MakeInParam("@stwg1", SqlDbType.Int, 0, 师傅数据.STWG1),
					SqlDBA.MakeInParam("@stwg2", SqlDbType.Int, 0, 师傅数据.STWG2),
					SqlDBA.MakeInParam("@stwg3", SqlDbType.Int, 0, 师傅数据.STWG3)
				};
				World.SqlPool.Enqueue(new DbPoolClass
				{
					Conn = DBA.getstrConnection(null),
					Prams = prams,
					Sql = "UPDATE_St_DATA"
				});
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存师徒数据出错[" + Userid + "]-[" + UserName + "]" + ex.Message);
			}
		}

		public void 保存个人仓库存储过程()
		{
			if (UserName.Length != 0 && !Client.挂机)
			{
				try
				{
					SqlParameter[] prams = new SqlParameter[4]
					{
						SqlDBA.MakeInParam("@id", SqlDbType.VarChar, 20, Userid),
						SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 20, UserName),
						SqlDBA.MakeInParam("@money", SqlDbType.VarChar, 0, 个人仓库钱数),
						SqlDBA.MakeInParam("@strItem", SqlDbType.VarBinary, 4620, Get个人仓库byte())
					};
					World.SqlPool.Enqueue(new DbPoolClass
					{
						Conn = DBA.getstrConnection(null),
						Prams = prams,
						Sql = "XWWL_UPDATE_USER_Warehouse"
					});
				}
				catch (Exception ex)
				{
					Form1.WriteLine(1, "保存个人仓库数据出错[" + Userid + "]-[" + UserName + "]" + ex.Message);
				}
			}
		}

		public void 保存综合仓库存储过程()
		{
			if (UserName.Length != 0 && !Client.挂机)
			{
				try
				{
					SqlParameter[] prams = new SqlParameter[5]
					{
						SqlDBA.MakeInParam("@id", SqlDbType.VarChar, 20, Userid),
						SqlDBA.MakeInParam("@money", SqlDbType.VarChar, 0, 综合仓库钱数),
						SqlDBA.MakeInParam("@strItem", SqlDbType.VarBinary, 4620, Get综合仓库byte()),
						SqlDBA.MakeInParam("@strItime", SqlDbType.VarBinary, 50, Get综合仓库品byte()),
						SqlDBA.MakeInParam("@zbver", SqlDbType.Int, 0, 综合仓库装备数据版本)
					};
					World.SqlPool.Enqueue(new DbPoolClass
					{
						Conn = DBA.getstrConnection(null),
						Prams = prams,
						Sql = "XWWL_UPDATE_ID_Warehouse"
					});
				}
				catch (Exception ex)
				{
					Form1.WriteLine(1, "保存综合仓库数据出错[" + Userid + "]-[" + UserName + "]" + ex.Message);
				}
			}
		}

		public void 检察元宝数据(int int_109, int int_110)
		{
			if (int_109 <= 0)
			{
				return;
			}
			if (World.元宝检测 == 1)
			{
				if (int_109 >= World.单次交易元宝数量上限)
				{
					Form1.WriteLine(77, "元宝交易数量超出系统允许上限[" + Userid + "]-[" + UserName + "]            [交易数量：" + int_109 + "]      [系统允许上限数量：" + World.单次交易元宝数量上限 + "]");
					switch (World.元宝检测操作)
					{
					case 1:
						return;
					case 2:
						封号(999999, Userid, "元宝检测操作2-1");
						break;
					}
				}
				if (FLD_RXPIONT >= World.帐号总元宝上限)
				{
					string[] array = new string[9]
					{
						"玩家元宝总数超出系统允许上限[",
						Userid,
						"]-[",
						UserName,
						"]            [元宝总数：",
						null,
						null,
						null,
						null
					};
					array[5] = FLD_RXPIONT.ToString();
					array[6] = "]      [系统允许上限数量：";
					array[7] = World.帐号总元宝上限.ToString();
					array[8] = "]";
					Form1.WriteLine(77, string.Concat(array));
					switch (World.元宝检测操作)
					{
					case 2:
						封号(999999, Userid, "元宝检测操作2-2");
						break;
					case 1:
						FLD_RXPIONT = 0;
						保存元宝数据();
						return;
					}
				}
			}
			if (int_110 == 0)
			{
				FLD_RXPIONT -= int_109;
				系统提示("消费" + int_109 + "个元宝      [" + DateTime.Now.ToString() + "]。", 22, "系统提示");
			}
			else
			{
				FLD_RXPIONT += int_109;
				系统提示("获得" + int_109 + "个元宝      [" + DateTime.Now.ToString() + "]。", 22, "系统提示");
			}
		}

		public void 检察元宝积分数据(int int_109, int int_110)
		{
			if (int_109 > 0)
			{
				if (int_110 == 0)
				{
					FLD_RXPIONTX -= int_109;
				}
				else
				{
					FLD_RXPIONTX += int_109;
				}
			}
		}

		public void 检察华夏币数据(int int_109, int int_110)
		{
			if (int_109 > 0)
			{
				if (int_110 == 0)
				{
					FLD_Coin -= int_109;
					系统提示("消费" + int_109 + "个赠品元宝      [" + DateTime.Now.ToString() + "]。", 22, "系统提示");
				}
				else
				{
					FLD_Coin += int_109;
					系统提示("获得" + int_109 + "个赠品元宝      [" + DateTime.Now.ToString() + "]。", 22, "系统提示");
				}
			}
		}

		public void 保存元宝数据()
		{
			try
			{
				SqlParameter[] prams = new SqlParameter[5]
				{
					SqlDBA.MakeInParam("@id", SqlDbType.VarChar, 20, Userid),
					SqlDBA.MakeInParam("@rxpiont", SqlDbType.Int, 0, FLD_RXPIONT),
					SqlDBA.MakeInParam("@rxpiontx", SqlDbType.Int, 0, FLD_RXPIONTX),
					SqlDBA.MakeInParam("@coin", SqlDbType.Int, 0, FLD_Coin),
					SqlDBA.MakeInParam("@safeword", SqlDbType.VarChar, 20, 游戏安全码)
				};
				World.SqlPool.Enqueue(new DbPoolClass
				{
					Conn = DBA.getstrConnection("rxjhaccount"),
					Prams = prams,
					Sql = "XWWL_UPDATE_RXPIONT"
				});
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存ID      元宝      数据出错[" + Userid + "]-[" + UserName + "]" + ex.Message);
			}
		}

		public void 保存会员数据()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("UPDATE  TBL_ACCOUNT  SET      FLD_VIP={1},FLD_VIPTIM='{2}'      WHERE      FLD_ID='{0}'", Userid, 1, FLD_VIPTIM);
			if (DBA.ExeSqlCommand(stringBuilder.ToString(), "rxjhaccount") == -1)
			{
				Form1.WriteLine(1, "保存ID      会员      数据出错[" + Userid + "]-[" + UserName + "]");
			}
		}

		public void 保存人物的数据()
		{
			try
			{
				if (UserName.Length != 0)
				{
					保存人物数据存储过程();
					保存个人仓库存储过程();
					保存综合仓库存储过程();
					if (人物灵兽 != null)
					{
						人物灵兽.保存数据();
					}
					存档时间 = true;
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存的数据出错[" + Userid + "]-[" + UserName + "]" + ex.Message);
			}
		}

		public void 保存帮派数据()
		{
			try
			{
				if (UserName.Length != 0 && 帮派Id != 0)
				{
					StringBuilder stringBuilder = new StringBuilder();
					stringBuilder.AppendFormat("UPDATE  TBL_XWWL_GuildMember  SET  FLD_LEVEL   =  @zw   WHERE  FLD_NAME  =   @Username");
					SqlParameter[] sqlParameter_ = new SqlParameter[2]
					{
						SqlDBA.MakeInParam("@zw", SqlDbType.Int, 0, Player_Level),
						SqlDBA.MakeInParam("@Username", SqlDbType.VarChar, 30, UserName)
					};
					if (DBA.ExeSqlCommand(stringBuilder.ToString(), sqlParameter_) == -1)
					{
						Form1.WriteLine(3, "保存人物帮派等级数据出错1[" + Userid + "]-[" + UserName + "]");
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存人物帮派等级数据出错2[" + Userid + "]-[" + UserName + "]" + ex.Message);
			}
		}

		public byte[] Get时间药品byte()
		{
			byte[] array = new byte[320];
			try
			{
				int num = 0;
				foreach (时间药品类 value in 时间药品.Values)
				{
					System.Buffer.BlockCopy(BitConverter.GetBytes(value.药品ID), 0, array, num * 8, 4);
					System.Buffer.BlockCopy(BitConverter.GetBytes(value.时间), 0, array, num * 8 + 4, 4);
					num++;
				}
				return array;
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存的数据出错_Get时间药品byte[" + Userid + "]-[" + UserName + "][" + 时间药品.Count + "]" + ex.Message);
				return array;
			}
		}

		public byte[] Get称号药品byte()
		{
			byte[] array = new byte[320];
			try
			{
				int num = 0;
				foreach (称号药品类 value in 称号药品.Values)
				{
					System.Buffer.BlockCopy(BitConverter.GetBytes(value.药品ID), 0, array, num * 8, 4);
					System.Buffer.BlockCopy(BitConverter.GetBytes(value.时间), 0, array, num * 8 + 4, 4);
					num++;
				}
				return array;
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存的数据出错_Get称号药品byte[" + Userid + "]-[" + UserName + "][" + 称号药品.Count + "]" + ex.Message);
				return array;
			}
		}

		public byte[] Get任务byte()
		{
			发包类 发包类 = new 发包类();
			try
			{
				if (任务 == null)
				{
					return new byte[400];
				}
				foreach (任务类 value in 任务.Values)
				{
					发包类.Write2(value.任务ID);
					发包类.Write2(value.任务阶段ID);
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存的数据出错_Get任务byte[" + Userid + "]-[" + UserName + "]" + ex.Message);
			}
			return 发包类.ToArray3();
		}

		public byte[] Get土灵符byte()
		{
			byte[] array = new byte[990];
			try
			{
				foreach (DictionaryEntry item in 土灵符坐标)
				{
					坐标Class 坐标Class = (坐标Class)item.Value;
					int num = (int)item.Key;
					if (num >= 10)
					{
						System.Buffer.BlockCopy(Encoding.Default.GetBytes(坐标Class.Rxjh_name), 0, array, (num - 10) * 32, Encoding.Default.GetBytes(坐标Class.Rxjh_name).Length);
						System.Buffer.BlockCopy(Buffer.GetBytes(坐标Class.Rxjh_Map), 0, array, (num - 10) * 32 + 15, 4);
						System.Buffer.BlockCopy(BitConverter.GetBytes(坐标Class.Rxjh_X), 0, array, (num - 10) * 32 + 19, 4);
						System.Buffer.BlockCopy(BitConverter.GetBytes(坐标Class.Rxjh_Y), 0, array, (num - 10) * 32 + 23, 4);
						System.Buffer.BlockCopy(BitConverter.GetBytes(坐标Class.Rxjh_Z), 0, array, (num - 10) * 32 + 27, 4);
					}
				}
				return array;
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存的数据出错_Get土灵符byte[" + Userid + "]-[" + UserName + "]" + ex.Message);
				return array;
			}
		}

		public byte[] Get个人药品byte()
		{
			int num = 0;
			byte[] array = new byte[320];
			try
			{
				if (追加状态列表 != null)
				{
					{
						foreach (追加状态类 value in 追加状态列表.Values)
						{
							if (value.FLD_RESIDE1 == 1)
							{
								System.Buffer.BlockCopy(Buffer.GetBytes(value.FLD_PID), 0, array, num * 8, 4);
								System.Buffer.BlockCopy(Buffer.GetBytes(value.FLD_sj), 0, array, num * 8 + 4, 4);
								num++;
							}
						}
						return array;
					}
				}
				return array;
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存的数据出错_Get个人药品byte[" + Userid + "]-[" + UserName + "]" + ex.Message);
				return array;
			}
		}

		public byte[] Get个人药品Newbyte()
		{
			int num = 0;
			byte[] array = new byte[240];
			try
			{
				if (追加状态New列表 != null)
				{
					{
						foreach (追加状态New类 value in 追加状态New列表.Values)
						{
							System.Buffer.BlockCopy(Buffer.GetBytes(value.FLD_PID), 0, array, num * 16, 4);
							System.Buffer.BlockCopy(Buffer.GetBytes(value.FLD_sj), 0, array, num * 16 + 4, 4);
							System.Buffer.BlockCopy(Buffer.GetBytes(value.数量), 0, array, num * 16 + 8, 4);
							System.Buffer.BlockCopy(Buffer.GetBytes(value.数量类型), 0, array, num * 16 + 12, 4);
							num++;
						}
						return array;
					}
				}
				return array;
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存的数据出错_Get个人药品Newbyte[" + Userid + "]-[" + UserName + "]" + ex.Message);
				return array;
			}
		}

		public byte[] Get个人仓库byte()
		{
			byte[] array = new byte[4620];
			try
			{
				for (int i = 0; i < 60; i++)
				{
					try
					{
						System.Buffer.BlockCopy(个人仓库[i].物品_byte, 0, array, i * World.数据库单个物品大小, World.数据库单个物品大小);
					}
					catch
					{
						System.Buffer.BlockCopy(new byte[World.数据库单个物品大小], 0, array, i * World.数据库单个物品大小, World.数据库单个物品大小);
					}
				}
				return array;
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存的数据出错_Get个人仓库byte[" + Userid + "]-[" + UserName + "]" + ex.Message);
				return array;
			}
		}

		public byte[] Get综合仓库byte()
		{
			byte[] array = new byte[4620];
			try
			{
				for (int i = 0; i < 60; i++)
				{
					try
					{
						System.Buffer.BlockCopy(公共仓库[i].物品_byte, 0, array, i * World.数据库单个物品大小, World.数据库单个物品大小);
					}
					catch
					{
						System.Buffer.BlockCopy(new byte[World.数据库单个物品大小], 0, array, i * World.数据库单个物品大小, World.数据库单个物品大小);
					}
				}
				return array;
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存的数据出错_Get综合仓库byte[" + Userid + "]-[" + UserName + "]" + ex.Message);
				return array;
			}
		}

		public byte[] Get综合仓库品byte()
		{
			byte[] array = new byte[16];
			try
			{
				if (公有药品 != null)
				{
					int num = 0;
					{
						foreach (公有药品类 value in 公有药品.Values)
						{
							System.Buffer.BlockCopy(Buffer.GetBytes(value.药品ID), 0, array, num * 8, 4);
							System.Buffer.BlockCopy(Buffer.GetBytes(value.时间), 0, array, num * 8 + 4, 4);
							num++;
						}
						return array;
					}
				}
				return array;
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存的数据出错_Get综合仓库品byte[" + Userid + "]-[" + UserName + "][" + 公有药品.Count + "]" + ex.Message);
				return array;
			}
		}

		public byte[] GetWgCodesbyte()
		{
			byte[] array = new byte[20];
			try
			{
				for (int i = 0; i < 12; i++)
				{
					byte[] src;
					try
					{
						src = 气功[i].气功_byte;
					}
					catch
					{
						src = new byte[2];
					}
					System.Buffer.BlockCopy(src, 0, array, i, 1);
				}
				return array;
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存的数据出错_GetWgCodesbyte[" + Userid + "]-[" + UserName + "]" + ex.Message);
				return array;
			}
		}

		public byte[] GetWEARITEMCodesbyte()
		{
			byte[] array = new byte[2464];
			try
			{
				for (int i = 0; i < 16; i++)
				{
					try
					{
						System.Buffer.BlockCopy(装备栏已穿装备[i].物品_byte, 0, array, i * World.数据库单个物品大小, World.数据库单个物品大小);
					}
					catch
					{
						System.Buffer.BlockCopy(new byte[World.数据库单个物品大小], 0, array, i * World.数据库单个物品大小, World.数据库单个物品大小);
					}
				}
				for (int j = 0; j < 15; j++)
				{
					try
					{
						System.Buffer.BlockCopy(辅助装备栏装备[j].物品_byte, 0, array, (j + 16) * World.数据库单个物品大小, World.数据库单个物品大小);
					}
					catch
					{
						System.Buffer.BlockCopy(new byte[World.数据库单个物品大小], 0, array, (j + 16) * World.数据库单个物品大小, World.数据库单个物品大小);
					}
				}
				return array;
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存的数据出错_GetWEARITEMCodesbyte[" + Userid + "]-[" + UserName + "]" + ex.Message);
				return array;
			}
		}

		public byte[] GetFLD_ITEMCodesbyte()
		{
			byte[] array = new byte[5082];
			try
			{
				for (int i = 0; i < 66; i++)
				{
					try
					{
						System.Buffer.BlockCopy(装备栏包裹[i].物品_byte, 0, array, i * World.数据库单个物品大小, World.数据库单个物品大小);
					}
					catch
					{
						System.Buffer.BlockCopy(new byte[World.数据库单个物品大小], 0, array, i * World.数据库单个物品大小, World.数据库单个物品大小);
					}
				}
				return array;
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存的数据出错_GetFLD_ITEMCodesbyte[" + Userid + "]-[" + UserName + "]" + ex.Message);
				return array;
			}
		}

		public byte[] GetFLD_FASHION_ITEMCodesbyte()
		{
			byte[] array = new byte[4620];
			try
			{
				for (int i = 0; i < 60; i++)
				{
					try
					{
						System.Buffer.BlockCopy(披风行囊[i].物品_byte, 0, array, i * World.数据库单个物品大小, World.数据库单个物品大小);
					}
					catch
					{
						System.Buffer.BlockCopy(new byte[World.数据库单个物品大小], 0, array, i * World.数据库单个物品大小, World.数据库单个物品大小);
					}
				}
				return array;
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存的数据出错_GetFLD_FASHION_ITEMCodesbyte[" + Userid + "]-[" + UserName + "]" + ex.Message);
				return array;
			}
		}

		public byte[] GetQuestITEMCodesbyte()
		{
			byte[] array = new byte[288];
			try
			{
				for (int i = 0; i < 36; i++)
				{
					try
					{
						System.Buffer.BlockCopy(任务物品[i].物品_byte, 0, array, i * 8, 8);
					}
					catch
					{
						System.Buffer.BlockCopy(new byte[8], 0, array, i * 8, 8);
					}
				}
				return array;
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存的数据出错GetQuestITEMCodesbyte[" + Userid + "]-[" + UserName + "]" + ex.Message);
				return array;
			}
		}

		public byte[] GetFLD_KONGFUCodesbyte()
		{
			发包类 发包类 = new 发包类();
			try
			{
				for (int i = 0; i < 3; i++)
				{
					for (int j = 0; j < 32; j++)
					{
						if (武功新[i, j] != null)
						{
							发包类.Write4(武功新[i, j].FLD_PID);
							发包类.Write4(武功新[i, j].武功_等级);
						}
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存的数据出错_GetFLD_KONGFUCodesbyte[" + Userid + "]-[" + UserName + "]" + ex.Message);
			}
			return 发包类.ToArray3();
		}

		public byte[] Get升天武功Codesbyte()
		{
			发包类 发包类 = new 发包类();
			try
			{
				for (int i = 0; i < 32; i++)
				{
					if (武功新[3, i] != null)
					{
						发包类.Write4(武功新[3, i].FLD_PID);
						发包类.Write4(武功新[3, i].武功_等级);
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存的数据出错_Get升天武功Codesbyte[" + Userid + "]-[" + UserName + "]" + ex.Message);
			}
			return 发包类.ToArray3();
		}

		public byte[] Get升天气功Codesbyte()
		{
			发包类 发包类 = new 发包类();
			try
			{
				foreach (升天气功类 value in 升天气功.Values)
				{
					发包类.Write2(value.气功ID);
					发包类.Write2(value.气功量);
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存的数据出错_Get升天气功odesbyte[" + Userid + "]-[" + UserName + "]" + ex.Message);
			}
			return 发包类.ToArray3();
		}

		public void 地面物品增加(byte[] byte_0, float float_3, float float_4, float float_5)
		{
			try
			{
				发包类 发包类 = new 发包类();
				发包类.Write4(1);
				发包类.Write(byte_0, 0, 16);
				发包类.Write(float_3);
				发包类.Write(15f);
				发包类.Write(float_4);
				发包类.Write(byte_0, 16, 60);
				if (Client != null)
				{
					Client.SendPak(发包类, 29184, 9999);
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "地面物品增加数据113      出错" + Client.WorldId + "|" + Client.ToString() + "      " + ((ex != null) ? ex.ToString() : null));
			}
		}

		public void 地面物品增加(Dictionary<long, 地面物品类> dictionary_0)
		{
			try
			{
				if (dictionary_0 != null && dictionary_0.Count > 0)
				{
					using (发包类 发包类 = new 发包类())
					{
						发包类.Write4(dictionary_0.Count);
						foreach (地面物品类 value in dictionary_0.Values)
						{
							发包类.Write(value.物品_byte, 0, 12);
							发包类.Write4(0);
							发包类.Write(value.物品_byte, 12, 4);
							发包类.Write(value.Rxjh_X);
							发包类.Write(15f);
							发包类.Write(value.Rxjh_Y);
							发包类.Write(value.物品_byte, 16, 56);
							发包类.Write4(0);
							发包类.Write4(0);
						}
						if (Client != null)
						{
							Client.SendPak(发包类, 29184, 人物全服ID);
						}
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "地面物品增加数据 出错" + Client.WorldId + "|" + Client.ToString() + " " + ex);
			}
		}

		public void 地面物品消失(long long_5)
		{
			try
			{
				发包类 发包类 = new 发包类();
				发包类.Write8(long_5);
				if (Client != null)
				{
					Client.SendPak(发包类, 29440, 人物全服ID);
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "地面物品消失数据      出错" + Client.WorldId + "|" + Client.ToString() + "      " + ((ex != null) ? ex.ToString() : null));
			}
		}

		public 发包类 得到更新人物数据(Players players_0)
		{
			发包类 发包类 = new 发包类();
			try
			{
				if (players_0 == null)
				{
					return null;
				}
				if (players_0.Client == null)
				{
					return null;
				}
				发包类.Write4(1);
				发包类.Write4(players_0.人物全服ID);
				发包类.WriteName(players_0.UserName);
				发包类.Write(0);
				发包类.Write4(players_0.帮派Id);
				发包类.WriteName(players_0.帮派名字);
				发包类.Write(players_0.帮派人物等级);
				if (players_0.帮派门徽 != null)
				{
					发包类.Write2(World.服务器组ID);
				}
				else
				{
					发包类.Write2(0);
				}
				发包类.Write(players_0.Player_Zx);
				发包类.Write(players_0.Player_Level);
				发包类.Write(players_0.Player_Job_leve);
				发包类.Write(players_0.Player_Job);
				发包类.Write2(0);
				发包类.Write2(players_0.New人物模版.发色);
				发包类.Write2(players_0.New人物模版.发型);
				发包类.Write2(players_0.New人物模版.脸型);
				发包类.Write(players_0.New人物模版.声音);
				发包类.Write(players_0.New人物模版.性别);
				发包类.Write(players_0.人物坐标_X);
				发包类.Write(players_0.人物坐标_Z);
				发包类.Write(players_0.人物坐标_Y);
				发包类.Write4(players_0.人物坐标_地图);
				发包类.Write4(BitConverter.ToInt32(players_0.装备栏已穿装备[0].物品ID, 0));
				发包类.Write4(0);
				发包类.Write4(BitConverter.ToInt32(players_0.装备栏已穿装备[1].物品ID, 0));
				发包类.Write4(0);
				发包类.Write4(BitConverter.ToInt32(players_0.装备栏已穿装备[2].物品ID, 0));
				发包类.Write4(0);
				发包类.Write4(BitConverter.ToInt32(players_0.装备栏已穿装备[4].物品ID, 0));
				发包类.Write4(0);
				发包类.Write4(BitConverter.ToInt32(players_0.装备栏已穿装备[3].物品ID, 0));
				发包类.Write4(0);
				发包类.Write4(BitConverter.ToInt32(players_0.装备栏已穿装备[5].物品ID, 0));
				发包类.Write4(0);
				发包类.Write4(BitConverter.ToInt32(players_0.装备栏已穿装备[9].物品ID, 0));
				发包类.Write4(0);
				发包类.Write4(BitConverter.ToInt32(players_0.装备栏已穿装备[10].物品ID, 0));
				发包类.Write4(0);
				if (players_0.人物坐标_地图 != 9001 && players_0.人物坐标_地图 != 9101 && players_0.人物坐标_地图 != 9201)
				{
					发包类.Write4(players_0.装备栏已穿装备[3].FLD_强化数量);
				}
				else
				{
					发包类.Write4(0);
				}
				if (players_0.人物坐标_地图 == 801)
				{
					if (players_0.势力战派别 == "仙族")
					{
						if (players_0.Player_Sex == 1)
						{
							发包类.Write4(16900001);
						}
						else
						{
							发包类.Write4(26900075);
						}
					}
					else if (players_0.Player_Sex == 1)
					{
						发包类.Write4(16900672);
					}
					else
					{
						发包类.Write4(26900672);
					}
				}
				else
				{
					发包类.Write4(BitConverter.ToInt32(players_0.装备栏已穿装备[11].物品ID, 0));
				}
				发包类.Write4(0);
				int num = ConfigClass.GetConfig(players_0.Config, players_0.人物坐标_地图);
				if (players_0.追加状态列表 != null && players_0.追加状态列表.ContainsKey(700014))
				{
					num += 8;
				}
				if (players_0.行走状态id1 == 1)
				{
					发包类.Write(num + 1);
				}
				else if (players_0.行走状态id1 == 0)
				{
					发包类.Write(num);
				}
				if (players_0.Player_Job == 7)
				{
					if (players_0.追加状态列表 != null)
					{
						if (players_0.追加状态列表.ContainsKey(900401))
						{
							发包类.Write(18);
						}
						else if (players_0.追加状态列表.ContainsKey(900402))
						{
							发包类.Write(34);
						}
						else if (players_0.追加状态列表.ContainsKey(900403))
						{
							发包类.Write(66);
						}
						else if (players_0.Config.武勋开关 == 90 && players_0.称号药品.ContainsKey(1008001478))
						{
							发包类.Write(8);
						}
						else if (players_0.Config.武勋开关 != 0)
						{
							发包类.Write(1);
						}
						else
						{
							发包类.Write(0);
						}
					}
					else if (players_0.Config.武勋开关 == 90 && players_0.称号药品.ContainsKey(1008001478))
					{
						if (players_0.Config.头发开关 != 1 && players_0.Config.头发开关 != 0)
						{
							发包类.Write(136);
						}
						else
						{
							发包类.Write(8);
						}
					}
					else if (players_0.Config.武勋开关 != 0)
					{
						if (players_0.Config.头发开关 != 1 && players_0.Config.头发开关 != 0)
						{
							发包类.Write(129);
						}
						else
						{
							发包类.Write(1);
						}
					}
					else if (players_0.Config.武勋开关 == 0)
					{
						if (players_0.Config.头发开关 != 1 && players_0.Config.头发开关 != 0)
						{
							发包类.Write(128);
						}
						else
						{
							发包类.Write(0);
						}
					}
					else
					{
						发包类.Write(0);
					}
				}
				else if (players_0.Config.武勋开关 == 90 && players_0.称号药品.ContainsKey(1008001478))
				{
					if (players_0.Config.头发开关 != 1 && players_0.Config.头发开关 != 0)
					{
						发包类.Write(136);
					}
					else
					{
						发包类.Write(8);
					}
				}
				else if (players_0.Config.武勋开关 != 0)
				{
					if (players_0.Config.头发开关 != 1 && players_0.Config.头发开关 != 0)
					{
						发包类.Write(129);
					}
					else
					{
						发包类.Write(1);
					}
				}
				else if (players_0.Config.武勋开关 == 0)
				{
					if (players_0.Config.头发开关 != 1 && players_0.Config.头发开关 != 0)
					{
						发包类.Write(128);
					}
					else
					{
						发包类.Write(0);
					}
				}
				else
				{
					发包类.Write(0);
				}
				发包类.Write2(琴师状态);
				发包类.Write(players_0.人物坐标_X);
				发包类.Write(players_0.人物坐标_Z);
				发包类.Write(players_0.人物坐标_Y);
				发包类.Write4(0);
				发包类.Write4(0);
				if (players_0.人物灵兽 != null)
				{
					if (players_0.人物灵兽.骑 == 1)
					{
						发包类.Write4(3);
					}
					else
					{
						发包类.Write4(0);
					}
				}
				else
				{
					发包类.Write4(255);
				}
				发包类.Write4(0);
				发包类.Write4(0);
				发包类.Write4(0);
				发包类.Write2(0);
				发包类.Write2(0);
				发包类.Write4(players_0.Player_WuXun);
				if (players_0.人物坐标_地图 == 801)
				{
					发包类.Write4(0);
				}
				else
				{
					发包类.Write4(players_0.人物善恶);
				}
				发包类.Write4(0);
				if (players_0.追加状态列表 != null)
				{
					if (players_0.追加状态列表.ContainsKey(1008000183))
					{
						发包类.Write4(2);
					}
					else if (players_0.追加状态列表.ContainsKey(1008000156))
					{
						发包类.Write4(1);
					}
					else if (players_0.追加状态列表.ContainsKey(1008000195))
					{
						发包类.Write4(4);
					}
					else if (players_0.追加状态列表.ContainsKey(1008000187))
					{
						发包类.Write4(3);
					}
					else
					{
						发包类.Write4(0);
					}
				}
				else
				{
					发包类.Write4(0);
				}
				发包类.Write4(players_0.潜行模式);
				if (players_0.追加状态列表 != null)
				{
					if (players_0.追加状态列表.ContainsKey(1008000188))
					{
						发包类.Write4(1);
					}
					else if (players_0.追加状态列表.ContainsKey(1008000252))
					{
						发包类.Write4(20);
					}
					else if (players_0.追加状态列表.ContainsKey(1008000245))
					{
						发包类.Write4(8);
					}
					else if (players_0.追加状态列表.ContainsKey(1008000232))
					{
						发包类.Write4(6);
					}
					else
					{
						发包类.Write4(0);
					}
				}
				else
				{
					发包类.Write4(0);
				}
				发包类.Write(players_0.人物名字模版, 0, 16);
				发包类.Write(players_0.人物名字模版, 16, 16);
				发包类.Write(players_0.人物名字模版, 32, 16);
				发包类.Write4(0);
				if (players_0.Config.蔬菜武器开关 == 1)
				{
					if (players_0.追加状态列表 != null)
					{
						if (!players_0.追加状态列表.ContainsKey(1008000240) && !players_0.追加状态列表.ContainsKey(1008000241) && !players_0.追加状态列表.ContainsKey(1008000242))
						{
							if (!players_0.追加状态列表.ContainsKey(1008000250) && !players_0.追加状态列表.ContainsKey(1008000251))
							{
								if (!players_0.追加状态列表.ContainsKey(1008000304) && !players_0.追加状态列表.ContainsKey(1008000305))
								{
									if (!players_0.追加状态列表.ContainsKey(1008000306) && !players_0.追加状态列表.ContainsKey(1008000307))
									{
										if (!players_0.追加状态列表.ContainsKey(1008000325) && !players_0.追加状态列表.ContainsKey(1008000326))
										{
											if (!players_0.追加状态列表.ContainsKey(1008001111) && !players_0.追加状态列表.ContainsKey(1008001112))
											{
												发包类.Write4(0);
											}
											else
											{
												发包类.Write4(5);
											}
										}
										else
										{
											发包类.Write4(4);
										}
									}
									else
									{
										发包类.Write4(3);
									}
								}
								else
								{
									发包类.Write4(3);
								}
							}
							else
							{
								发包类.Write4(2);
							}
						}
						else
						{
							发包类.Write4(1);
						}
					}
					else
					{
						发包类.Write4(0);
					}
				}
				else
				{
					发包类.Write4(0);
				}
				if (players_0.FLD_情侣.Length != 0)
				{
					发包类.Write(1);
					发包类.WriteName(players_0.FLD_情侣);
					if (players_0.是否已婚 == 1)
					{
						发包类.Write2(players_0.FLD_爱情度等级);
					}
					else
					{
						发包类.Write2(0);
					}
				}
				else
				{
					发包类.Write(0);
					发包类.WriteName(string.Empty);
					发包类.Write2(0);
				}
				发包类.Write2(0);
				发包类.Write(1);
				if (players_0.人物坐标_地图 != 9001 && players_0.人物坐标_地图 != 9101 && players_0.人物坐标_地图 != 9201)
				{
					发包类.Write(players_0.装备栏已穿装备[3].FLD_FJ_进化);
					发包类.Write(players_0.装备栏已穿装备[3].FLD_属性类型);
					发包类.Write(players_0.装备栏已穿装备[3].FLD_属性数量);
				}
				else
				{
					发包类.Write(0);
					发包类.Write(0);
					发包类.Write(0);
				}
				if (players_0.人物坐标_地图 == 801)
				{
					if (players_0.势力战派别 == "仙族")
					{
						发包类.Write2(1);
					}
					else
					{
						发包类.Write2(0);
					}
				}
				else
				{
					发包类.Write2(0);
				}
				发包类.Write2(0);
				if (players_0.人物坐标_地图 != 9001 && players_0.人物坐标_地图 != 9101 && players_0.人物坐标_地图 != 9201)
				{
					发包类.Write4(players_0.武勋阶段);
					发包类.Write2(players_0.FLD_荣誉ID);
				}
				else
				{
					发包类.Write4(0);
					发包类.Write2(0);
				}
				if (players_0.人物坐标_地图 == 801)
				{
					发包类.Write2(0);
				}
				else if (players_0.人物坐标_地图 != 9001 && players_0.人物坐标_地图 != 9101 && players_0.人物坐标_地图 != 9201)
				{
					if (players_0.人物坐标_地图 == 7301)
					{
						if (players_0.帮派人物等级 == 6)
						{
							发包类.Write2(1);
						}
						else
						{
							发包类.Write2(0);
						}
					}
					else
					{
						发包类.Write2(称号排名);
					}
				}
				else
				{
					发包类.Write2(0);
				}
				发包类.Write2(players_0.门派称号类型);
				if (players_0.人物灵兽 != null)
				{
					if (players_0.人物坐标_地图 != 9001 && players_0.人物坐标_地图 != 9101 && players_0.人物坐标_地图 != 9201)
					{
						发包类.Write2(1);
						发包类.Write2(players_0.人物灵兽全服ID);
						发包类.WriteString(players_0.人物灵兽.Name, 16);
						发包类.Write4(0);
						发包类.Write1(players_0.人物灵兽.FLD_LEVEL);
						发包类.Write1(players_0.人物灵兽.FLD_JOB_LEVEL);
						发包类.Write1(players_0.人物灵兽.FLD_JOB);
						发包类.Write1(0);
						发包类.Write1(players_0.人物灵兽.Bs);
						发包类.Write1(0);
						if (players_0.人物灵兽.武功新[0, 3] != null)
						{
							发包类.Write4(players_0.人物灵兽.武功新[0, 3].FLD_PID);
						}
						else if (players_0.人物灵兽.武功新[0, 2] != null)
						{
							发包类.Write4(players_0.人物灵兽.武功新[0, 2].FLD_PID);
						}
						else if (players_0.人物灵兽.武功新[0, 1] != null)
						{
							发包类.Write4(players_0.人物灵兽.武功新[0, 1].FLD_PID);
						}
						else
						{
							发包类.Write4(0);
						}
						发包类.Write4(3);
						for (int i = 0; i < 4; i++)
						{
							发包类.Write4((int)players_0.人物灵兽.宠物以装备[i].Get物品ID);
						}
						发包类.Write4(256);
					}
					else
					{
						发包类.Write2(0);
						for (int j = 0; j < 14; j++)
						{
							发包类.Write4(0);
						}
					}
				}
				else
				{
					发包类.Write2(0);
					for (int k = 0; k < 14; k++)
					{
						发包类.Write4(0);
					}
				}
				发包类.Write4(0);
				发包类.Write4(0);
				if (players_0.检查烈日炎炎状态() && players_0.检查毒蛇出洞状态() && players_0.检查哀鸿遍野状态() && 检查致残状态())
				{
					发包类.Write2(71);
				}
				else if (players_0.检查毒蛇出洞状态() && players_0.检查哀鸿遍野状态() && 检查致残状态())
				{
					发包类.Write2(69);
				}
				else if (players_0.检查烈日炎炎状态() && players_0.检查毒蛇出洞状态() && players_0.检查哀鸿遍野状态())
				{
					发包类.Write2(7);
				}
				else if (players_0.检查毒蛇出洞状态() && 检查致残状态())
				{
					发包类.Write2(66);
				}
				else if (players_0.检查哀鸿遍野状态() && 检查致残状态())
				{
					发包类.Write2(68);
				}
				else if (players_0.检查烈日炎炎状态() && 检查致残状态())
				{
					发包类.Write2(65);
				}
				else if (players_0.检查烈日炎炎状态() && players_0.检查毒蛇出洞状态())
				{
					发包类.Write2(3);
				}
				else if (players_0.检查烈日炎炎状态() && players_0.检查哀鸿遍野状态())
				{
					发包类.Write2(5);
				}
				else if (players_0.检查毒蛇出洞状态() && players_0.检查哀鸿遍野状态())
				{
					发包类.Write2(6);
				}
				else if (players_0.检查致残状态())
				{
					发包类.Write2(64);
				}
				else if (players_0.检查烈日炎炎状态())
				{
					发包类.Write2(1);
				}
				else if (players_0.检查毒蛇出洞状态())
				{
					发包类.Write2(2);
				}
				else if (players_0.检查哀鸿遍野状态())
				{
					发包类.Write2(4);
				}
				else
				{
					发包类.Write2(0);
				}
				发包类.Write2(0);
				if (players_0.装备栏已穿装备[0].FLD_强化数量 == 15 && players_0.装备栏已穿装备[1].FLD_强化数量 == 15 && players_0.装备栏已穿装备[2].FLD_强化数量 == 15 && players_0.装备栏已穿装备[4].FLD_强化数量 == 15 && players_0.装备栏已穿装备[5].FLD_强化数量 == 15)
				{
					发包类.Write2(1);
				}
				else
				{
					发包类.Write2(0);
				}
				if (players_0.人物坐标_地图 != 9001 && players_0.人物坐标_地图 != 9101 && players_0.人物坐标_地图 != 9201)
				{
					if (players_0.装备栏已穿装备[3].FLD_强化数量 == 15)
					{
						发包类.Write2(1);
					}
					else
					{
						发包类.Write2(0);
					}
				}
				else
				{
					发包类.Write2(0);
				}
				发包类.Write4(uint.MaxValue);
				if (players_0.装备栏已穿装备[3].FLD_FJ_四神之力 != 0)
				{
					发包类.Write2(players_0.装备栏已穿装备[3].FLD_FJ_四神之力);
				}
				else
				{
					发包类.Write2(0);
				}
				发包类.Write2(1);
				发包类.Write4(0);
				发包类.Write4(0);
				发包类.Write4((int)players_0.装备栏已穿装备[15].Get物品ID);
				发包类.Write4(0);
				发包类.Write4(players_0.装备栏已穿装备[15].FLD_MAGIC1);
				发包类.Write4(players_0.装备栏已穿装备[15].FLD_MAGIC2);
				发包类.Write4(0);
				发包类.Write4(0);
				发包类.Write4(0);
				发包类.Write4(0);
				return 发包类;
			}
			catch (Exception ex)
			{
				string[] obj = new string[8]
				{
					"得到更新人物数据  出错",
					Client.WorldId.ToString(),
					"|",
					Client.ToString(),
					"  ",
					Converter.ToString(发包类.ToArray3()),
					"  ",
					null
				};
				obj[7] = ((ex != null) ? ex.ToString() : null);
				Form1.WriteLine(1, string.Concat(obj));
				return null;
			}
		}

		public void 更新广播人物数据()
		{
			try
			{
				发包类 发包类 = 得到更新人物数据(Client.Player);
				if (发包类 != null)
				{
					发送当前范围广播数据(发包类, 25600, 人物全服ID);
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "更新广播人物数据      出错" + Client.WorldId + "|" + Client.ToString() + "      " + ((ex != null) ? ex.ToString() : null));
			}
		}

		public void 头顶发光()
		{
			try
			{
				byte[] array = Converter.hexStringToByte("AA551E00DC0102311000DC0100000000000001000000FFEF0100000000000000000055AA");
				System.Buffer.BlockCopy(BitConverter.GetBytes(人物全服ID), 0, array, 4, 2);
				System.Buffer.BlockCopy(BitConverter.GetBytes(人物全服ID), 0, array, 10, 2);
				if (Client != null)
				{
					Client.Send(array, array.Length);
				}
				发送当前范围广播数据(array, array.Length);
			}
			catch (Exception)
			{
			}
		}

		public void 头顶发光(Players players_0)
		{
			try
			{
				byte[] array = Converter.hexStringToByte("AA551E00DC0102311000DC0100000000000001000000FFEF0100000000000000000055AA");
				System.Buffer.BlockCopy(BitConverter.GetBytes(players_0.人物全服ID), 0, array, 4, 2);
				System.Buffer.BlockCopy(BitConverter.GetBytes(players_0.人物全服ID), 0, array, 10, 2);
				if (Client != null)
				{
					Client.Send(array, array.Length);
				}
				发送当前范围广播数据(array, array.Length);
			}
			catch (Exception)
			{
			}
		}

		public void 更新人物数据(Players players_0)
		{
			try
			{
				发包类 发包类 = 得到更新人物数据(players_0);
				if (发包类 != null)
				{
					Client.SendPak(发包类, 25600, players_0.人物全服ID);
				}
				if (发包类.Length < 224)
				{
					string str = Converter.ToString(发包类.ToArray3());
					Form1.WriteLine(100, "更新人物数据" + 发包类.Length + "      " + str);
				}
				if (players_0.个人商店 != null)
				{
					更新个人商店数据(players_0);
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "更新人物数据      出错" + Client.WorldId + "|" + Client.ToString() + "      " + ((ex != null) ? ex.ToString() : null));
			}
		}

		public void 更新个人商店数据(Players players_0)
		{
			if (players_0.个人商店.个人商店是否开启)
			{
				发包类 发包类 = new 发包类();
				发包类.Write4(1);
				发包类.Write4(players_0.人物全服ID);
				发包类.Write4(players_0.人物全服ID);
				发包类.Write2((byte)players_0.个人商店.商店名.Length);
				发包类.Write(players_0.个人商店.商店名, 0, players_0.个人商店.商店名.Length);
				if (Client != null)
				{
					Client.SendPak(发包类, 51712, 人物全服ID);
				}
			}
		}

		public bool 检查红月狂风状态()
		{
			return GetAddState(1008001172);
		}

		public bool 检查哀鸿遍野状态()
		{
			return GetAddState(1008001176);
		}

		public bool 检查满月狂风状态()
		{
			if (!GetAddState(1008001171))
			{
				return 怒;
			}
			return true;
		}

		public bool 检查毒蛇出洞状态()
		{
			return GetAddState(1008001170);
		}

		public bool 检查致残状态()
		{
			return GetAddState(1008002012);
		}

		public bool 检查烈日炎炎状态()
		{
			return GetAddState(1008001169);
		}

		public bool 检查长虹贯天状态()
		{
			return GetAddState(1008001173);
		}

		public bool 检查和弦状态()
		{
			if (!追加状态列表.ContainsKey(900401) && !追加状态列表.ContainsKey(900402))
			{
				return 追加状态列表.ContainsKey(900403);
			}
			return true;
		}

		public void 更换装备位置(int int_109, int int_110, int int_111, int int_112, byte[] byte_0, int int_113)
		{
			try
			{
				int num = BitConverter.ToInt32(byte_0, 8);
				if (int_109 == 1 && int_111 == 0)
				{
					num = (int)装备栏已穿装备[int_112].Get物品ID;
					if (装备栏已穿装备[int_112].FLD_Intrgration == 1)
					{
						num -= 5000;
					}
				}
				byte[] array = Converter.hexStringToByte("AA55820098011B0074000100000001000003010000002F2724060000000042EEF80500000000010000000000000000030100640100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000E8030000000000000000000000000000000000000000000000000000000000000000000055AA");
				byte[] bytes = BitConverter.GetBytes(int_109);
				byte[] bytes2 = BitConverter.GetBytes(int_110);
				byte[] bytes3 = BitConverter.GetBytes(int_111);
				byte[] bytes4 = BitConverter.GetBytes(int_112);
				System.Buffer.BlockCopy(bytes, 0, array, 14, 1);
				System.Buffer.BlockCopy(bytes2, 0, array, 15, 1);
				System.Buffer.BlockCopy(bytes3, 0, array, 16, 1);
				System.Buffer.BlockCopy(bytes4, 0, array, 17, 1);
				System.Buffer.BlockCopy(BitConverter.GetBytes(int_113), 0, array, 18, 4);
				System.Buffer.BlockCopy(byte_0, 0, array, 22, 8);
				System.Buffer.BlockCopy(BitConverter.GetBytes(num), 0, array, 30, 4);
				System.Buffer.BlockCopy(BitConverter.GetBytes(int_113), 0, array, 38, 4);
				System.Buffer.BlockCopy(bytes, 0, array, 48, 1);
				System.Buffer.BlockCopy(bytes2, 0, array, 49, 1);
				System.Buffer.BlockCopy(bytes3, 0, array, 46, 1);
				System.Buffer.BlockCopy(bytes4, 0, array, 47, 1);
				System.Buffer.BlockCopy(BitConverter.GetBytes(人物全服ID), 0, array, 4, 2);
				if (Client != null)
				{
					Client.Send(array, array.Length);
				}
			}
			catch
			{
			}
		}

		public void 增加物品3(byte[] byte_0, byte[] byte_1, int int_109, byte[] byte_2, byte[] byte_3)
		{
			try
			{
				ItmeClass value;
				if (World.Itme.TryGetValue(BitConverter.ToInt32(byte_1, 0), out value))
				{
					byte[] array = Converter.hexStringToByte("AA557200940223006400010000008716E567818320060208AF2F000000000100000000000000010F020F00020000470D0300000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000C3E755AA");
					byte[] array2 = new byte[World.数据库单个物品大小];
					if (value.FLD_SIDE != 0)
					{
						byte[] array3 = new byte[4];
						System.Buffer.BlockCopy(byte_3, 0, array3, 0, 4);
						物品类 物品类 = 得到人物物品类型(BitConverter.ToInt32(byte_1, 0), BitConverter.ToInt32(array3, 0));
						if (BitConverter.ToInt32(byte_1, 0) != 1008000044 && BitConverter.ToInt32(byte_1, 0) != 1008000045)
						{
							if (物品类 != null)
							{
								int_109 = 物品类.物品位置;
								byte_0 = 物品类.物品全局ID;
								byte_2 = BitConverter.GetBytes(BitConverter.ToInt32(物品类.物品数量, 0) + BitConverter.ToInt32(byte_2, 0));
							}
						}
						else
						{
							byte_0 = BitConverter.GetBytes(RxjhClass.GetDBItmeId());
							byte_2 = BitConverter.GetBytes(BitConverter.ToInt32(byte_2, 0));
						}
					}
					else
					{
						byte_2 = BitConverter.GetBytes(1);
					}
					System.Buffer.BlockCopy(byte_0, 0, array2, 0, 8);
					System.Buffer.BlockCopy(byte_1, 0, array2, 8, 4);
					System.Buffer.BlockCopy(byte_2, 0, array2, 12, 4);
					System.Buffer.BlockCopy(byte_3, 0, array2, 16, byte_3.Length);
					System.Buffer.BlockCopy(BitConverter.GetBytes(int_109), 0, array, 39, 2);
					System.Buffer.BlockCopy(array2, 0, array, 14, 12);
					System.Buffer.BlockCopy(array2, 12, array, 30, 4);
					System.Buffer.BlockCopy(array2, 16, array, 46, byte_3.Length);
					装备栏包裹[int_109].物品_byte = array2;
					System.Buffer.BlockCopy(BitConverter.GetBytes(人物全服ID), 0, array, 4, 2);
					if (Client != null)
					{
						Client.Send(array, array.Length);
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "增加物品出错66  [" + Userid + "][" + UserName + "]  位置[" + int_109 + "]  数量[" + BitConverter.ToInt32(byte_2, 0) + "]" + ex.Message);
			}
		}

		public void 显示大字(int int_109, int int_110)
		{
			try
			{
				using (发包类 发包类 = new 发包类())
				{
					发包类.Write4(int_109);
					发包类.Write4(int_110);
					发包类.Write4(0);
					if (Client != null)
					{
						Client.SendPak(发包类, 35072, 人物全服ID);
						发送当前范围广播数据(发包类, 35072, 人物全服ID);
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "xsz出错!" + ex.Message);
			}
		}

		public void 物品使用(int int_109, int int_110, int int_111)
		{
			Buffer.GetBytes(int_110);
			Buffer.GetBytes(int_111);
			int num = Buffer.ToInt32((int_109 != 1) ? 人物灵兽.宠物装备栏[int_110].物品ID : 装备栏包裹[int_110].物品ID, 0);
			if (int_109 == 1)
			{
				if (Buffer.ToInt32(装备栏包裹[int_110].物品数量, 0) <= int_111)
				{
					装备栏包裹[int_110].物品_byte = new byte[World.数据库单个物品大小];
					Buffer.GetBytes(0);
				}
				else
				{
					byte[] bytes = Buffer.GetBytes(Buffer.ToInt32(装备栏包裹[int_110].物品数量, 0) - int_111);
					装备栏包裹[int_110].物品数量 = bytes;
				}
			}
			else if (Buffer.ToInt32(人物灵兽.宠物装备栏[int_110].物品数量, 0) <= int_111)
			{
				人物灵兽.宠物装备栏[int_110].物品_byte = new byte[World.数据库单个物品大小];
				Buffer.GetBytes(0);
			}
			else
			{
				byte[] bytes2 = Buffer.GetBytes(Buffer.ToInt32(人物灵兽.宠物装备栏[int_110].物品数量, 0) - int_111);
				人物灵兽.宠物装备栏[int_110].物品数量 = bytes2;
			}
			发包类 发包类 = new 发包类();
			发包类.Write1(int_109);
			发包类.Write1(int_110);
			发包类.Write2(0);
			发包类.Write8(装备栏包裹[int_110].Get物品ID);
			if (int_111 == 0)
			{
				if (int_109 == 1)
				{
					发包类.Write4(装备栏包裹[int_110].Get物品数量);
				}
				else
				{
					发包类.Write4(人物灵兽.宠物装备栏[int_110].Get物品数量);
				}
			}
			else
			{
				发包类.Write4(int_111);
			}
			if (int_109 == 1)
			{
				发包类.Write4(装备栏包裹[int_110].Get物品数量);
			}
			else
			{
				发包类.Write4(人物灵兽.宠物装备栏[int_110].Get物品数量);
			}
			if (int_109 == 1 && num == 1700101)
			{
				发包类.Write4(111);
			}
			else
			{
				发包类.Write4(0);
			}
			发包类.Write4(0);
			if (Client != null)
			{
				Client.SendPak(发包类, 15104, 人物全服ID);
			}
		}

		public void 物品使用戒指(int int_109, int int_110, int int_111)
		{
			byte[] array = Converter.hexStringToByte("AA55220000003B001400010A000065CA9A3B010000006100000000000000000000000000000055AAA");
			System.Buffer.BlockCopy(BitConverter.GetBytes(int_109), 0, array, 11, 2);
			System.Buffer.BlockCopy(装备栏包裹[int_109].物品ID, 0, array, 14, 4);
			System.Buffer.BlockCopy(BitConverter.GetBytes(int_111), 0, array, 18, 2);
			System.Buffer.BlockCopy(BitConverter.GetBytes(int_110), 0, array, 22, 4);
			System.Buffer.BlockCopy(BitConverter.GetBytes(人物全服ID), 0, array, 4, 2);
			if (Client != null)
			{
				Client.Send(array, array.Length);
			}
		}

		public void 物品使用千年雪参(int int_109, int int_110)
		{
			try
			{
				if (中毒)
				{
					int_110 *= 2;
				}
				byte[] array = Converter.hexStringToByte("AA552B002C013B001C000105000065CA9A3B000000000100000009000000000000000000000000000000000000000055AA");
				byte[] array2 = new byte[4];
				System.Buffer.BlockCopy(装备栏包裹[int_109].物品_byte, 20, array2, 0, 4);
				int num = BitConverter.ToInt32(array2, 0) - 2010000000 - int_110;
				System.Buffer.BlockCopy(BitConverter.GetBytes(int_109), 0, array, 11, 2);
				System.Buffer.BlockCopy(装备栏包裹[int_109].物品ID, 0, array, 14, 4);
				if (num <= 0)
				{
					if (BitConverter.ToInt32(装备栏包裹[int_109].物品数量, 0) <= 1)
					{
						System.Buffer.BlockCopy(BitConverter.GetBytes(0), 0, array, 26, 4);
						System.Buffer.BlockCopy(BitConverter.GetBytes(2010000000), 0, array, 30, 4);
						装备栏包裹[int_109].物品_byte = new byte[World.数据库单个物品大小];
					}
					else
					{
						int value = BitConverter.ToInt32(装备栏包裹[int_109].物品数量, 0) - 1;
						装备栏包裹[int_109].物品数量 = BitConverter.GetBytes(value);
						if (装备栏包裹[int_109].Get物品ID != 1008000044L && 装备栏包裹[int_109].Get物品ID != 1008000045L)
						{
							if (装备栏包裹[int_109].Get物品ID != 1008000003L && 装备栏包裹[int_109].Get物品ID != 1008000006L)
							{
								if (装备栏包裹[int_109].Get物品ID != 1008000007L && 装备栏包裹[int_109].Get物品ID != 1008000008L)
								{
									if (装备栏包裹[int_109].Get物品ID != 1008000068L && 装备栏包裹[int_109].Get物品ID != 1008000069L)
									{
										System.Buffer.BlockCopy(BitConverter.GetBytes(2010600000), 0, 装备栏包裹[int_109].物品_byte, 20, 4);
									}
									else
									{
										System.Buffer.BlockCopy(BitConverter.GetBytes(2011000000), 0, 装备栏包裹[int_109].物品_byte, 20, 4);
									}
								}
								else
								{
									System.Buffer.BlockCopy(BitConverter.GetBytes(2010400000), 0, 装备栏包裹[int_109].物品_byte, 20, 4);
								}
							}
							else
							{
								System.Buffer.BlockCopy(BitConverter.GetBytes(2011000000), 0, 装备栏包裹[int_109].物品_byte, 20, 4);
							}
						}
						else
						{
							System.Buffer.BlockCopy(BitConverter.GetBytes(2019999999), 0, 装备栏包裹[int_109].物品_byte, 20, 4);
						}
						System.Buffer.BlockCopy(装备栏包裹[int_109].物品数量, 0, array, 26, 4);
						if (装备栏包裹[int_109].Get物品ID != 1008000044L && 装备栏包裹[int_109].Get物品ID != 1008000045L)
						{
							if (装备栏包裹[int_109].Get物品ID != 1008000003L && 装备栏包裹[int_109].Get物品ID != 1008000006L)
							{
								if (装备栏包裹[int_109].Get物品ID != 1008000007L && 装备栏包裹[int_109].Get物品ID != 1008000008L)
								{
									if (装备栏包裹[int_109].Get物品ID != 1008000068L && 装备栏包裹[int_109].Get物品ID != 1008000069L)
									{
										System.Buffer.BlockCopy(BitConverter.GetBytes(2010600000), 0, array, 30, 4);
									}
									else
									{
										System.Buffer.BlockCopy(BitConverter.GetBytes(2011000000), 0, array, 30, 4);
									}
								}
								else
								{
									System.Buffer.BlockCopy(BitConverter.GetBytes(2010400000), 0, array, 30, 4);
								}
							}
							else
							{
								System.Buffer.BlockCopy(BitConverter.GetBytes(2011000000), 0, array, 30, 4);
							}
						}
						else
						{
							System.Buffer.BlockCopy(BitConverter.GetBytes(2019999999), 0, array, 30, 4);
						}
					}
				}
				else
				{
					System.Buffer.BlockCopy(BitConverter.GetBytes(num + 2010000000), 0, 装备栏包裹[int_109].物品_byte, 20, 4);
					System.Buffer.BlockCopy(装备栏包裹[int_109].物品数量, 0, array, 26, 4);
					System.Buffer.BlockCopy(BitConverter.GetBytes(num + 2010000000), 0, array, 30, 4);
				}
				System.Buffer.BlockCopy(BitConverter.GetBytes(人物全服ID), 0, array, 4, 2);
				if (Client != null)
				{
					Client.Send(array, array.Length);
				}
			}
			catch
			{
			}
		}

		public void 物品使用无双九转丹(int int_109, int int_110)
		{
			try
			{
				if (中毒)
				{
					int_110 *= 2;
				}
				byte[] array = Converter.hexStringToByte("AA552200FF033B001C00010000004DDC143C000000000100000001000000923192410000000055AA");
				byte[] array2 = new byte[4];
				System.Buffer.BlockCopy(装备栏包裹[int_109].物品_byte, 20, array2, 0, 4);
				int num = (int)(((装备栏包裹[int_109].Get物品ID != 1008000077L) ? (((double)((BitConverter.ToInt32(array2, 0) - 1100000000) / 100 * 人物最大_HP) - (double)int_110) / (double)(1000 * 人物最大_HP)) : (((double)((BitConverter.ToInt32(array2, 0) - 1100000000) / 100 * 人物最大_HP) - (double)int_110) / (double)(1000 * 人物最大_HP))) * 100000.0);
				System.Buffer.BlockCopy(BitConverter.GetBytes(int_109), 0, array, 11, 2);
				System.Buffer.BlockCopy(装备栏包裹[int_109].物品ID, 0, array, 14, 4);
				if (num <= 0)
				{
					if (BitConverter.ToInt32(装备栏包裹[int_109].物品数量, 0) <= 1)
					{
						System.Buffer.BlockCopy(BitConverter.GetBytes(0), 0, array, 26, 4);
						System.Buffer.BlockCopy(BitConverter.GetBytes(1100000000), 0, array, 30, 4);
						装备栏包裹[int_109].物品_byte = new byte[World.数据库单个物品大小];
					}
					else
					{
						int value = BitConverter.ToInt32(装备栏包裹[int_109].物品数量, 0) - 1;
						装备栏包裹[int_109].物品数量 = BitConverter.GetBytes(value);
						System.Buffer.BlockCopy(BitConverter.GetBytes(1100100000), 0, 装备栏包裹[int_109].物品_byte, 20, 4);
						System.Buffer.BlockCopy(装备栏包裹[int_109].物品数量, 0, array, 26, 4);
						System.Buffer.BlockCopy(BitConverter.GetBytes(1100100000), 0, array, 30, 4);
					}
				}
				else
				{
					System.Buffer.BlockCopy(BitConverter.GetBytes(num + 1100000000), 0, 装备栏包裹[int_109].物品_byte, 20, 4);
					System.Buffer.BlockCopy(装备栏包裹[int_109].物品数量, 0, array, 26, 4);
					System.Buffer.BlockCopy(BitConverter.GetBytes(num + 1100000000), 0, array, 30, 4);
				}
				System.Buffer.BlockCopy(BitConverter.GetBytes(人物全服ID), 0, array, 4, 2);
				if (Client != null)
				{
					Client.Send(array, array.Length);
				}
			}
			catch
			{
			}
		}

		public void 物品使用无双千年雪参(int int_109, int int_110)
		{
			try
			{
				if (中毒)
				{
					int_110 *= 2;
				}
				byte[] array = Converter.hexStringToByte("AA552200FF033B001C00010000004DDC143C000000000100000001000000923192410000000055AA");
				byte[] array2 = new byte[4];
				System.Buffer.BlockCopy(装备栏包裹[int_109].物品_byte, 20, array2, 0, 4);
				int num = (int)(((装备栏包裹[int_109].Get物品ID != 1008000078L) ? (((double)((BitConverter.ToInt32(array2, 0) - 1110000000) / 100 * 人物最大_MP) - (double)int_110) / (double)(1000 * 人物最大_MP)) : (((double)((BitConverter.ToInt32(array2, 0) - 1110000000) / 100 * 人物最大_MP) - (double)int_110) / (double)(1000 * 人物最大_MP))) * 100000.0);
				System.Buffer.BlockCopy(BitConverter.GetBytes(int_109), 0, array, 11, 2);
				System.Buffer.BlockCopy(装备栏包裹[int_109].物品ID, 0, array, 14, 4);
				if (num <= 0)
				{
					if (BitConverter.ToInt32(装备栏包裹[int_109].物品数量, 0) <= 1)
					{
						System.Buffer.BlockCopy(BitConverter.GetBytes(0), 0, array, 26, 4);
						System.Buffer.BlockCopy(BitConverter.GetBytes(1110000000), 0, array, 30, 4);
						装备栏包裹[int_109].物品_byte = new byte[World.数据库单个物品大小];
					}
					else
					{
						int value = BitConverter.ToInt32(装备栏包裹[int_109].物品数量, 0) - 1;
						装备栏包裹[int_109].物品数量 = BitConverter.GetBytes(value);
						System.Buffer.BlockCopy(BitConverter.GetBytes(1110100000), 0, 装备栏包裹[int_109].物品_byte, 20, 4);
						System.Buffer.BlockCopy(装备栏包裹[int_109].物品数量, 0, array, 26, 4);
						System.Buffer.BlockCopy(BitConverter.GetBytes(1110100000), 0, array, 30, 4);
					}
				}
				else
				{
					System.Buffer.BlockCopy(BitConverter.GetBytes(num + 1110000000), 0, 装备栏包裹[int_109].物品_byte, 20, 4);
					System.Buffer.BlockCopy(装备栏包裹[int_109].物品数量, 0, array, 26, 4);
					System.Buffer.BlockCopy(BitConverter.GetBytes(num + 1110000000), 0, array, 30, 4);
				}
				System.Buffer.BlockCopy(BitConverter.GetBytes(人物全服ID), 0, array, 4, 2);
				if (Client != null)
				{
					Client.Send(array, array.Length);
				}
			}
			catch
			{
			}
		}

		public void 发送门徽2(byte[] byte_0, int int_109)
		{
			byte[] array = Converter.hexStringToByte("AA5518030A00EB000A036A42020001000100FF00FFFF00FF0000FF0000FFFF00FFFF00FFFF00FFFF00FFFF00FFFF00FFFFFF80FF00FFFFFF80FFFF80FFFF80FFFF80FF00FFFF00FF0000FF0000FF0000FFFF00FFFF00FFFF00FFFF00FFFF00FFFFFF80FF00FFFFFF80FFFF80FFFF80FFFF80FF00FFFF00FF0000FFFF00FF0000FFFF00FF0000FFFF00FFFF00FFFFFF80FF00FFFFFF80FFFF80FFFF80FF00FFFFFF80FF00FFFF00FF0000FFFF00FF0000FFFF00FF0000FFFF00FFFF00FFFFFF80FFFF80FFFF80FFFF80FF00FFFFFF80FFFF80FF00FFFF00FF0000FFFF00FF0000FF0000FF0000FFFF00FFFF00FFFFFF80FFFF80FFFF80FFFF80FF00FFFFFF80FFFF80FF00FFFF00FF0000FFFF00FFFF00FF0000FF0000FF0000FFFFFF80FFFF80FFFF80FFFF80FFFF80FFFF80FFFF80FF00FFFF00FFFF00FF0000FFFF00FFFF00FF0000FFFF00FF0000FFFFFF80FFFF80FF0000FFFF80FFFF80FFFF80FFFF80FF0000FF00FFFF0000FF0000FF0000FF0000FF0000FF0000FFFF80FFFF80FF0000FF0000FFFF80FFFF80FFFF80FF00FFFF00FFFF00FFFF00FFFF0000FF0000FF0000FF0000FFFF80FF0000FFFF80FF0000FF0000FFFF80FFFF80FFFF80FF0000FF0000FF0000FF0000FF0000FF0000FF0000FFFF80FF0000FF0000FFFF80FF0000FF0000FFFF80FFFF80FF0000FF0000FF0000FF00FFFF00FF0000FFFF00FFFFFF80FF00FFFF00FF0000FFFFFF80FF00FFFFFF80FFFF80FF0000FF0000FF00FFFF00FFFF0000FF0000FFFF80FFFF80FF0000FF0000FF0000FF0000FFFF80FFFF80FF0000FF0000FF0000FF0000FF0000FF0000FF00FFFF00FF0000FFFF00FFFF00FFFF00FFFF00FFFF00FFFFFF80FF00FFFF0000FF0000FF0000FF0000FF0000FF00FFFF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FFFF80FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF00FFFF00FFFF00FFFF00FFFF00FFFF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF00000000000000000000BC6F55AA");
			System.Buffer.BlockCopy(byte_0, 0, array, 18, byte_0.Length);
			System.Buffer.BlockCopy(BitConverter.GetBytes(int_109), 0, array, 10, 4);
			System.Buffer.BlockCopy(BitConverter.GetBytes(World.服务器组ID), 0, array, 16, 2);
			System.Buffer.BlockCopy(BitConverter.GetBytes(人物全服ID), 0, array, 4, 2);
			if (Client != null)
			{
				Client.Send(array, array.Length);
			}
		}

		public void 更新攻击速度()
		{
			byte[] array = Converter.hexStringToByte("AA551A00B20206200C00060000008801580064000000000000000000000055AA");
			System.Buffer.BlockCopy(BitConverter.GetBytes(人物全服ID), 0, array, 4, 2);
			System.Buffer.BlockCopy(BitConverter.GetBytes(FLD_攻击速度), 0, array, 18, 4);
			if (Client != null)
			{
				Client.Send(array, array.Length);
			}
			发送当前范围广播数据(array, array.Length);
		}

		public void 发送激活技能数据(int int_109, int int_110)
		{
			byte[] array = Converter.hexStringToByte("AA552E00A2013D00200026B706000100000000000000000000000000000000000000E803000001000000000000000000000055AA");
			System.Buffer.BlockCopy(Buffer.GetBytes(int_109), 0, array, 10, 4);
			System.Buffer.BlockCopy(Buffer.GetBytes(int_110), 0, array, 14, 1);
			System.Buffer.BlockCopy(Buffer.GetBytes(人物全服ID), 0, array, 4, 2);
			if (当前激活技能ID == 0)
			{
				System.Buffer.BlockCopy(Buffer.GetBytes(0), 0, array, 38, 2);
			}
			else
			{
				System.Buffer.BlockCopy(Buffer.GetBytes(1), 0, array, 38, 2);
			}
			if (Client != null)
			{
				Client.Send(array, array.Length);
			}
		}

		public void 解除召唤(Players players_0, Players players_1)
		{
			byte[] array = Converter.hexStringToByte("AA551600549C6300080001000000549C0001000000000000A37B55AA");
			System.Buffer.BlockCopy(BitConverter.GetBytes(players_1.人物灵兽.全服ID), 0, array, 14, 2);
			System.Buffer.BlockCopy(BitConverter.GetBytes(players_0.人物全服ID), 0, array, 4, 2);
			if (players_0.Client != null)
			{
				players_0.Client.Send多包(array, array.Length);
			}
			发送当前范围广播数据(array, array.Length);
		}

		public void 解除召唤2(Players players_0, Players players_1)
		{
			byte[] array = Converter.hexStringToByte("AA551600549C6300080001000000549C0001000000000000A37B55AA");
			System.Buffer.BlockCopy(BitConverter.GetBytes(players_1.人物灵兽.全服ID), 0, array, 14, 2);
			System.Buffer.BlockCopy(BitConverter.GetBytes(players_0.人物全服ID), 0, array, 4, 2);
			if (players_0.Client != null)
			{
				players_0.Client.Send多包(array, array.Length);
			}
		}

		public void 离开当前地图(Players players_0, Players players_1)
		{
			try
			{
				byte[] array = Converter.hexStringToByte("AA5513000300630008000100000003000000000000000000000055AA");
				System.Buffer.BlockCopy(BitConverter.GetBytes(players_1.人物全服ID), 0, array, 14, 2);
				System.Buffer.BlockCopy(BitConverter.GetBytes(players_0.人物全服ID), 0, array, 4, 2);
				if (players_0.Client != null)
				{
					players_0.Client.Send多包(array, array.Length);
				}
				if (players_1.人物灵兽 != null)
				{
					解除召唤2(players_0, players_1);
				}
			}
			catch
			{
			}
		}

		public void 发送组队消息广播数据(byte[] byte_0, int int_109, ThreadSafeDictionary<int, Players> threadSafeDictionary_0)
		{
			try
			{
				foreach (Players value in threadSafeDictionary_0.Values)
				{
					if (value.Client != null)
					{
						value.Client.Send(byte_0, int_109);
					}
				}
			}
			catch
			{
			}
		}

		public void 发送传音消息数据(byte[] byte_0, int int_109, string string_11, string string_12, int int_110)
		{
			try
			{
				foreach (Players value in World.allConnectedChars.Values)
				{
					if (Buffer.IsEquals(value.UserName, string_11))
					{
						if (value.Config.传音 == 0)
						{
							系统提示("对方设置不容许传音。");
						}
						else
						{
							if (Client != null)
							{
								Client.Send(byte_0, int_109);
							}
							发送传音消息(value, string_12, int_110);
						}
						break;
					}
				}
			}
			catch
			{
			}
		}

		public void 发送传音消息(Players players_0, string string_11, int int_109)
		{
			try
			{
				byte[] array = Converter.hexStringToByte("AA55A50000006600970000000000000000000000000000000000000000000000003000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000055AA");
				array[10] = (byte)int_109;
				byte[] bytes = Encoding.Default.GetBytes(UserName);
				byte[] bytes2 = Encoding.Default.GetBytes(string_11);
				System.Buffer.BlockCopy(bytes2, 0, array, 35, bytes2.Length);
				System.Buffer.BlockCopy(bytes, 0, array, 12, bytes.Length);
				System.Buffer.BlockCopy(BitConverter.GetBytes(人物全服ID), 0, array, 4, 2);
				if (players_0.Client != null)
				{
					players_0.Client.Send(array, array.Length);
				}
			}
			catch
			{
			}
		}

		public void 发送传音消息(string string_11, int int_109, Players players_0, string string_12, int int_110)
		{
			try
			{
				byte[] array = Converter.hexStringToByte("AA55A50000006600970000000000000000000000000000000000000000000000003000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000055AA");
				array[10] = (byte)int_110;
				byte[] bytes = Encoding.Default.GetBytes(string_11);
				byte[] bytes2 = Encoding.Default.GetBytes(string_12);
				System.Buffer.BlockCopy(bytes2, 0, array, 35, bytes2.Length);
				System.Buffer.BlockCopy(bytes, 0, array, 12, bytes.Length);
				System.Buffer.BlockCopy(Buffer.GetBytes(int_109), 0, array, 4, 2);
				if (players_0.Client != null)
				{
					players_0.Client.Send(array, array.Length);
				}
			}
			catch
			{
			}
		}

		public void 发送势力战邀请新()
		{
			byte[] array = Converter.hexStringToByte("AA552E000F2713222000010001000B00000001000000020000000500000005000000340E000000000000000000000000BD8455AA");
			System.Buffer.BlockCopy(BitConverter.GetBytes(2), 0, array, 22, 1);
			if (Client != null)
			{
				Client.Send(array, array.Length);
			}
		}

		public void 发送势力战邀请新2()
		{
			byte[] array = Converter.hexStringToByte("AA552E000F2713222000010001000B00000001000000030000000500000005000000620F000000000000000000000000BD8455AA");
			System.Buffer.BlockCopy(Buffer.GetBytes(World.势力战正人数), 0, array, 34, 4);
			System.Buffer.BlockCopy(Buffer.GetBytes(World.势力战邪人数), 0, array, 38, 4);
			System.Buffer.BlockCopy(Buffer.GetBytes(3), 0, array, 22, 1);
			System.Buffer.BlockCopy(Buffer.GetBytes(人物全服ID), 0, array, 4, 2);
			if (Client != null)
			{
				Client.Send(array, array.Length);
			}
		}

		public void 势力战复活选择()
		{
			byte[] array = Converter.hexStringToByte("AA552E000F2713222000010001000A000000010000000400000005000000050000000000000000000000000000000000153555AA");
			System.Buffer.BlockCopy(Buffer.GetBytes(人物全服ID), 0, array, 4, 2);
			if (Client != null)
			{
				Client.Send(array, array.Length);
			}
		}

		public void 势力战英雄复活提示(int int_109)
		{
			byte[] array = Converter.hexStringToByte("AA552E000F2713222000080001000100000001000000360E0000000000000000000000000000000000000000000000007D5C55AA");
			System.Buffer.BlockCopy(Buffer.GetBytes(人物全服ID), 0, array, 4, 2);
			System.Buffer.BlockCopy(Buffer.GetBytes(int_109), 0, array, 22, 1);
			if (Client != null)
			{
				Client.Send(array, array.Length);
			}
		}

		public void 发送势力战系统封包(int int_109, int int_110, int int_111)
		{
			using (发包类 发包类 = new 发包类())
			{
				发包类.Write4(int_110);
				发包类.Write2(1);
				if (int_109 == 14)
				{
					发包类.Write2(70);
				}
				else if (int_109 == 3 && int_111 == 11)
				{
					发包类.Write2(int_111);
				}
				else
				{
					发包类.Write2(70);
				}
				发包类.Write4(0);
				if (int_109 == 1 && int_111 == 2)
				{
					发包类.Write4(2);
				}
				else if (int_109 == 1 && int_111 != 2)
				{
					发包类.Write4(1);
				}
				else
				{
					发包类.Write4(int_109);
				}
				if (int_109 == 3 && int_111 == 11)
				{
					发包类.Write4(World.势力战正分数);
					发包类.Write4(World.势力战邪分数);
					发包类.Write4(World.势力战正人数);
					发包类.Write4(World.势力战邪人数);
				}
				else if (int_109 == 1 && int_111 == 2)
				{
					发包类.Write4(8);
					发包类.Write4(8);
					发包类.Write4(3636);
					发包类.Write4(0);
				}
				else if (int_109 == 1 && int_111 != 2)
				{
					发包类.Write4(8);
					发包类.Write4(8);
					发包类.Write4(3635);
					发包类.Write4(0);
				}
				else
				{
					发包类.Write4(int_111);
					发包类.Write4(0);
					发包类.Write4(0);
					发包类.Write4(0);
				}
				发包类.Write4(0);
				发包类.Write2(0);
				if (Client != null)
				{
					Client.SendPak(发包类, 4898, 人物全服ID);
				}
			}
		}

		public void 发送势力战开始倒计时(int int_109)
		{
			try
			{
				byte[] array = Converter.hexStringToByte("AA552E000F2713222000090001000B000000010000000C0000002101000000000000000000000000000000000000000002EE55AA");
				System.Buffer.BlockCopy(BitConverter.GetBytes(int_109), 0, array, 26, 2);
				System.Buffer.BlockCopy(BitConverter.GetBytes(人物全服ID), 0, array, 4, 2);
				if (Client != null)
				{
					Client.Send(array, array.Length);
				}
			}
			catch
			{
			}
		}

		public void 发送势力战快开始消息(int int_109)
		{
			try
			{
				byte[] array = Converter.hexStringToByte("AA551B00A205BA000D00020000100E0000000000000000000000000000AC4155AA");
				System.Buffer.BlockCopy(BitConverter.GetBytes(int_109), 0, array, 13, 2);
				System.Buffer.BlockCopy(BitConverter.GetBytes(人物全服ID), 0, array, 4, 2);
				System.Buffer.BlockCopy(BitConverter.GetBytes(World.势力战进程), 0, array, 10, 1);
				System.Buffer.BlockCopy(BitConverter.GetBytes(World.势力战正分数), 0, array, 15, 4);
				System.Buffer.BlockCopy(BitConverter.GetBytes(World.势力战邪分数), 0, array, 19, 4);
				if (Client != null)
				{
					Client.Send(array, array.Length);
				}
			}
			catch
			{
			}
		}

		public void 发送势力战消息2()
		{
			try
			{
				byte[] array = Converter.hexStringToByte("AA551B00A205BA000D000303271806FFFF0000FFFF000000000000000059DF55AA");
				System.Buffer.BlockCopy(BitConverter.GetBytes(2), 0, array, 10, 1);
				System.Buffer.BlockCopy(BitConverter.GetBytes(World.势力战时间), 0, array, 13, 2);
				System.Buffer.BlockCopy(BitConverter.GetBytes(World.势力战正分数), 0, array, 15, 4);
				System.Buffer.BlockCopy(BitConverter.GetBytes(World.势力战邪分数), 0, array, 19, 4);
				System.Buffer.BlockCopy(BitConverter.GetBytes(人物全服ID), 0, array, 4, 2);
				if (Client != null)
				{
					Client.Send(array, array.Length);
				}
			}
			catch
			{
			}
		}

		public void 发送势力战消息()
		{
			try
			{
				发送势力战战绩();
				byte[] array = Converter.hexStringToByte("AA551B00A205BA000D000303271806FFFF0000FFFF000000000000000059DF55AA");
				System.Buffer.BlockCopy(BitConverter.GetBytes(World.势力战进程), 0, array, 10, 1);
				System.Buffer.BlockCopy(BitConverter.GetBytes(World.势力战时间), 0, array, 13, 2);
				System.Buffer.BlockCopy(BitConverter.GetBytes(World.势力战正分数), 0, array, 15, 4);
				System.Buffer.BlockCopy(BitConverter.GetBytes(World.势力战邪分数), 0, array, 19, 4);
				System.Buffer.BlockCopy(BitConverter.GetBytes(人物全服ID), 0, array, 4, 2);
				if (Client != null)
				{
					Client.Send(array, array.Length);
				}
			}
			catch
			{
			}
		}

		public void 发送势力战战绩()
		{
			try
			{
				发包类 发包类 = new 发包类();
				发包类.Write2(World.EventTop.Count);
				发包类.Write2(0);
				发包类.Write2(0);
				发包类.Write2(0);
				foreach (EventTopClass value in World.EventTop.Values)
				{
					if (value.势力 == "仙族")
					{
						发包类.Write1(1);
					}
					else if (value.势力 == "魔族")
					{
						发包类.Write1(2);
					}
					发包类.WriteString(value.人物名, 15);
					发包类.Write1(value.等级);
					发包类.Write1(value.杀人数);
					发包类.Write2(value.死亡数);
					发包类.Write2(0);
					发包类.Write2((int)((double)(value.杀人数 - value.死亡数) * 1.5));
					发包类.Write4(0);
					发包类.Write4(0);
					发包类.Write2(0);
					发包类.Write1(0);
					发包类.Write1(0);
					发包类.Write1(0);
				}
				if (Client != null)
				{
					Client.SendPak(发包类, 5410, 人物全服ID);
				}
			}
			catch
			{
			}
		}

		public void 发送势力战消息1()
		{
			try
			{
				byte[] array = Converter.hexStringToByte("AA551D005400B7000F000212270300000064000000640002000000000000008E1B55AA");
				System.Buffer.BlockCopy(BitConverter.GetBytes(人物全服ID), 0, array, 4, 2);
				if (Client != null)
				{
					Client.Send(array, array.Length);
				}
			}
			catch
			{
			}
		}

		public void 发送势力战结束消息(int int_109)
		{
			try
			{
				byte[] array = Converter.hexStringToByte("AA551A00B902BA000C00041127031200000018000000000000000000822255AA");
				switch (int_109)
				{
				case 1:
					if (Player_Zx != 1 && !Buffer.IsEquals(势力战派别, "仙族"))
					{
						System.Buffer.BlockCopy(Buffer.GetBytes(2), 0, array, 13, 1);
					}
					else
					{
						System.Buffer.BlockCopy(Buffer.GetBytes(1), 0, array, 13, 1);
					}
					break;
				case 2:
					if (Player_Zx != 1 && !Buffer.IsEquals(势力战派别, "仙族"))
					{
						System.Buffer.BlockCopy(Buffer.GetBytes(1), 0, array, 13, 1);
					}
					else
					{
						System.Buffer.BlockCopy(Buffer.GetBytes(2), 0, array, 13, 1);
					}
					break;
				case 3:
					System.Buffer.BlockCopy(Buffer.GetBytes(3), 0, array, 13, 1);
					break;
				}
				System.Buffer.BlockCopy(Buffer.GetBytes(人物全服ID), 0, array, 4, 2);
				System.Buffer.BlockCopy(Buffer.GetBytes(World.势力战进程), 0, array, 10, 1);
				System.Buffer.BlockCopy(Buffer.GetBytes(World.势力战正分数), 0, array, 14, 4);
				System.Buffer.BlockCopy(Buffer.GetBytes(World.势力战邪分数), 0, array, 18, 4);
				if (Client != null)
				{
					Client.Send(array, array.Length);
				}
			}
			catch
			{
			}
		}

		public void 发送势力战关闭消息()
		{
			try
			{
				byte[] array = Converter.hexStringToByte("AA551B00A205BA000D0006132700000000000000000000000000000000AC4155AA");
				System.Buffer.BlockCopy(BitConverter.GetBytes(人物全服ID), 0, array, 4, 2);
				if (Client != null)
				{
					Client.Send(array, array.Length);
				}
			}
			catch
			{
			}
		}

		public void 发送安全码消息(int int_109)
		{
			try
			{
				byte[] array = Converter.hexStringToByte("AA552B002C0138151C000000000000000000000000000000000000000000000000000000000000000000000000000055AA");
				System.Buffer.BlockCopy(BitConverter.GetBytes(人物全服ID), 0, array, 4, 2);
				if (Client != null)
				{
					Client.Send(array, array.Length);
				}
				安全码操作ID = int_109;
			}
			catch
			{
			}
		}

		public void 发送帮派消息(string string_11, byte[] byte_0, int int_109)
		{
			try
			{
				foreach (Players value in World.allConnectedChars.Values)
				{
					if (Buffer.IsEquals(value.帮派名字, string_11) && value.Client != null)
					{
						value.Client.Send(byte_0, int_109);
					}
				}
			}
			catch
			{
			}
		}

		public Players 得到人物数据(int int_109)
		{
			Players value;
			if (World.allConnectedChars.TryGetValue(int_109, out value))
			{
				return value;
			}
			return null;
		}

		public Players 得到人物数据(string string_11)
		{
			try
			{
				foreach (Players value in World.allConnectedChars.Values)
				{
					if (Buffer.IsEquals(value.UserName, string_11))
					{
						return value;
					}
				}
				return null;
			}
			catch
			{
				return null;
			}
		}

		public 物品类 得到包裹物品(int int_109)
		{
			int num = 0;
			while (true)
			{
				if (num < 66)
				{
					if (Buffer.ToInt32(装备栏包裹[num].物品ID, 0) == int_109)
					{
						break;
					}
					num++;
					continue;
				}
				return null;
			}
			return 装备栏包裹[num];
		}

		public 任务物品类 得到任务包裹栏物品(int int_109)
		{
			int num = 0;
			while (true)
			{
				if (num < 36)
				{
					if (任务物品[num].物品ID == int_109)
					{
						break;
					}
					num++;
					continue;
				}
				return null;
			}
			return 任务物品[num];
		}

		public int 得到包裹空位(Players players_0)
		{
			int num = 0;
			while (true)
			{
				if (num < 66)
				{
					if (Buffer.ToInt32(players_0.装备栏包裹[num].物品ID, 0) == 0)
					{
						break;
					}
					num++;
					continue;
				}
				return -1;
			}
			return num;
		}

		public int 得到包裹空位位置()
		{
			int num = 0;
			while (true)
			{
				if (num < 66)
				{
					if (Buffer.ToInt32(装备栏包裹[num].物品ID, 0) == 0)
					{
						break;
					}
					num++;
					continue;
				}
				return -1;
			}
			return num;
		}

		public List<int> 得到包裹空位位置组(int int_109)
		{
			int num = 0;
			List<int> list = new List<int>();
			for (int i = 0; i < 66; i++)
			{
				if (Buffer.ToInt32(装备栏包裹[i].物品ID, 0) == 0)
				{
					num++;
					list.Add(i);
					if (num >= int_109)
					{
						break;
					}
				}
			}
			return list;
		}

		public int 得到包裹空位数()
		{
			int num = 0;
			for (int i = 0; i < 66; i++)
			{
				if (Buffer.ToInt32(装备栏包裹[i].物品ID, 0) == 0)
				{
					num++;
				}
			}
			return num;
		}

		public 物品类 得到人物公共仓库类型(int int_109, int int_110)
		{
			if (int_110 == 3)
			{
				物品类[] array = 个人仓库;
				foreach (物品类 物品类 in array)
				{
					if (Buffer.ToInt32(物品类.物品ID, 0) == int_109)
					{
						return 物品类;
					}
				}
			}
			else
			{
				物品类[] array = 公共仓库;
				foreach (物品类 物品类2 in array)
				{
					if (Buffer.ToInt32(物品类2.物品ID, 0) == int_109)
					{
						return 物品类2;
					}
				}
			}
			return null;
		}

		public 物品类 得到人物物品物品全局ID(Players players_0, long long_5)
		{
			物品类[] array = players_0.装备栏包裹;
			int num = 0;
			物品类 物品类;
			while (true)
			{
				if (num < array.Length)
				{
					物品类 = array[num];
					if (物品类.Get物品全局ID == long_5)
					{
						break;
					}
					num++;
					continue;
				}
				return null;
			}
			return 物品类;
		}

		public 物品类 得到人物物品类型(int int_109)
		{
			物品类[] array = 装备栏包裹;
			int num = 0;
			物品类 物品类;
			while (true)
			{
				if (num < array.Length)
				{
					物品类 = array[num];
					if (物品类.Get物品ID == int_109)
					{
						break;
					}
					num++;
					continue;
				}
				return null;
			}
			return 物品类;
		}

		public 物品类 得到人物物品类型(int int_109, int int_110)
		{
			物品类[] array = 装备栏包裹;
			int num = 0;
			物品类 物品类;
			while (true)
			{
				if (num < array.Length)
				{
					物品类 = array[num];
					if (物品类.Get物品ID == int_109 && 物品类.FLD_MAGIC0 == int_110)
					{
						break;
					}
					num++;
					continue;
				}
				return null;
			}
			return 物品类;
		}

		public 物品类 得到人物公共仓库类型(int int_109, int int_110, int int_111)
		{
			if (int_110 == 3)
			{
				物品类[] array = 个人仓库;
				foreach (物品类 物品类 in array)
				{
					if (Buffer.ToInt32(物品类.物品ID, 0) == int_109 && 物品类.FLD_MAGIC0 == int_111)
					{
						return 物品类;
					}
				}
			}
			else
			{
				物品类[] array = 公共仓库;
				foreach (物品类 物品类2 in array)
				{
					if (Buffer.ToInt32(物品类2.物品ID, 0) == int_109 && 物品类2.FLD_MAGIC0 == int_111)
					{
						return 物品类2;
					}
				}
			}
			return null;
		}

		public void 加血(int int_109)
		{
			if (中毒)
			{
				int_109 -= (int)((double)int_109 * 0.2);
			}
			if (Player_Job == 3)
			{
				int_109 = (int)((double)int_109 * (1.0 + base.枪_运气疗伤));
			}
			if (Player_Job != 3 && Player_Job_leve >= 6)
			{
				int_109 += (int)base.升天一气功_运气疗伤;
			}
			if (人物_HP + int_109 < 人物最大_HP)
			{
				人物_HP += int_109;
			}
			else
			{
				人物_HP = 人物最大_HP;
			}
		}

		public void 加魔(int int_109)
		{
			if (中毒)
			{
				int_109 -= (int)((double)int_109 * 0.2);
			}
			if (Player_Job == 5)
			{
				int_109 = (int)((double)int_109 * (1.0 + base.医_运气疗心));
			}
			if (Player_Job == 13)
			{
				int_109 = (int)((double)int_109 * (1.0 + base.神女运气行心));
			}
			if (Player_Job != 5 && Player_Job_leve >= 6)
			{
				int_109 = (int)((double)int_109 * (1.0 + base.升天一气功_运气行心));
			}
			if (人物_MP + int_109 < 人物最大_MP)
			{
				人物_MP += int_109;
			}
			else
			{
				人物_MP = 人物最大_MP;
			}
		}

		public void 加血灵兽(int int_109)
		{
			if (人物灵兽.FLD_HP + int_109 < 人物灵兽.灵兽基本最大_HP)
			{
				人物灵兽.FLD_HP += int_109;
			}
			else
			{
				人物灵兽.FLD_HP = 人物灵兽.灵兽基本最大_HP;
			}
		}

		public void 加魔灵兽(int int_109)
		{
			if (人物灵兽.FLD_MP + int_109 < 人物灵兽.灵兽基本最大_MP)
			{
				人物灵兽.FLD_MP += int_109;
			}
			else
			{
				人物灵兽.FLD_MP = 人物灵兽.灵兽基本最大_MP;
			}
		}

		public void 新吃药提示()
		{
			发包类 发包类 = new 发包类();
			发包类.Write4(1025);
			发包类.Write8(1008000093L);
			发包类.Write4(3);
			发包类.Write4(1);
			发包类.Write4(2000000012);
			发包类.Write4(0);
			if (Client != null)
			{
				Client.SendPak(发包类, 15104, 人物全服ID);
			}
		}

		public void 得到钱的提示(uint uint_0)
		{
			byte[] array = Converter.hexStringToByte("AA554200EA010D0034000100000000000000000000000094357700000000A701000000000000000000000000000000000000000000000000000000000000000000000000000055AA");
			byte[] bytes = BitConverter.GetBytes(uint_0);
			System.Buffer.BlockCopy(bytes, 0, array, 30, bytes.Length);
			System.Buffer.BlockCopy(BitConverter.GetBytes(人物全服ID), 0, array, 4, 2);
			if (Client != null)
			{
				Client.Send(array, array.Length);
			}
		}

		public void 升级后的提示(int int_109)
		{
			发包类 发包类 = new 发包类();
			发包类.Write(Player_Level);
			发包类.Write(int_109);
			发包类.Write4(0);
			发包类.Write4(0);
			if (Client != null)
			{
				Client.SendPak(发包类, 30464, 人物全服ID);
				发送当前范围广播数据(发包类, 30464, 人物全服ID);
			}
		}

		public void 分解物品提示(int int_109)
		{
			byte[] array = Converter.hexStringToByte("AA5512003B0231170400FEFFFFFF000000000000B0EB55AA");
			System.Buffer.BlockCopy(BitConverter.GetBytes(int_109), 0, array, 10, 4);
			System.Buffer.BlockCopy(BitConverter.GetBytes(人物全服ID), 0, array, 4, 2);
			if (Client != null)
			{
				Client.Send(array, array.Length);
			}
		}

		public void 购买物品提示(int int_109)
		{
			byte[] array = Converter.hexStringToByte("AA551300000093000800050000000E000000000000000000000055AA");
			System.Buffer.BlockCopy(BitConverter.GetBytes(int_109), 0, array, 14, 2);
			System.Buffer.BlockCopy(BitConverter.GetBytes(人物全服ID), 0, array, 4, 2);
			if (Client != null)
			{
				Client.Send(array, array.Length);
			}
		}

		public void 捡物品提示(int int_109, long long_5)
		{
			byte[] array = Converter.hexStringToByte("AA551A0000000D000C00030000006843030000000000000000000000000055AA");
			System.Buffer.BlockCopy(BitConverter.GetBytes(int_109), 0, array, 10, 1);
			System.Buffer.BlockCopy(BitConverter.GetBytes(long_5), 0, array, 14, 8);
			System.Buffer.BlockCopy(BitConverter.GetBytes(人物全服ID), 0, array, 4, 2);
			if (Client != null)
			{
				Client.Send(array, array.Length);
			}
		}

		public void 商店提示(int int_109)
		{
			byte[] array = Converter.hexStringToByte("AA5512000000CF000700010D0000000000000000000000000055AA");
			System.Buffer.BlockCopy(BitConverter.GetBytes(int_109), 0, array, 11, 1);
			System.Buffer.BlockCopy(BitConverter.GetBytes(人物全服ID), 0, array, 4, 2);
			if (Client != null)
			{
				Client.Send(array, array.Length);
			}
		}

		public void 组队传送符提示(int int_109, int int_110, int int_111)
		{
			byte[] array = Converter.hexStringToByte("AA552200D001121614000106000078DC143C010000000100000009943577000000000000A65455AA");
			System.Buffer.BlockCopy(BitConverter.GetBytes(int_110), 0, array, 11, 1);
			System.Buffer.BlockCopy(BitConverter.GetBytes(int_111), 0, array, 14, 4);
			System.Buffer.BlockCopy(BitConverter.GetBytes(int_109), 0, array, 18, 2);
			System.Buffer.BlockCopy(BitConverter.GetBytes(人物全服ID), 0, array, 4, 2);
			if (Client != null)
			{
				Client.Send(array, array.Length);
			}
		}

		public void 倒计时提示(int int_109)
		{
			发包类 发包类 = new 发包类();
			发包类.Write4(int_109);
			发包类.Write4(0);
			发包类.Write4(0);
			if (Client != null)
			{
				Client.SendPak(发包类, 5911, 人物全服ID);
			}
		}

		public void 帮派传送符提示(int int_109, int int_110, int int_111)
		{
			byte[] array = Converter.hexStringToByte("AA552000D001311614000106000078DC143C010000000100000009943577000000000000A65455AA");
			System.Buffer.BlockCopy(BitConverter.GetBytes(int_110), 0, array, 11, 1);
			System.Buffer.BlockCopy(BitConverter.GetBytes(int_111), 0, array, 14, 4);
			System.Buffer.BlockCopy(BitConverter.GetBytes(int_109), 0, array, 18, 2);
			System.Buffer.BlockCopy(BitConverter.GetBytes(人物全服ID), 0, array, 4, 2);
			if (Client != null)
			{
				Client.Send(array, array.Length);
			}
		}

		public void 滚动公告(int int_109)
		{
			if (!Client.挂机)
			{
				byte[] array = Converter.hexStringToByte("AA554D000F27B018480001000000941100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000055AA");
				System.Buffer.BlockCopy(BitConverter.GetBytes(int_109), 0, array, 14, 4);
				System.Buffer.BlockCopy(BitConverter.GetBytes(0), 0, array, 4, 2);
				if (Client != null)
				{
					Client.Send多包(array, array.Length);
				}
			}
		}

		public void 系统提示(string string_11, int int_109, string string_12)
		{
			byte[] array = Converter.hexStringToByte("AA55A50000006600970000000000000000000000000000000000000000000000003000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000055AA");
			array[10] = (byte)int_109;
			byte[] bytes = Encoding.Default.GetBytes(string_12);
			byte[] bytes2 = Encoding.Default.GetBytes(string_11);
			System.Buffer.BlockCopy(bytes, 0, array, 12, bytes.Length);
			System.Buffer.BlockCopy(bytes2, 0, array, 35, bytes2.Length);
			System.Buffer.BlockCopy(BitConverter.GetBytes(0), 0, array, 4, 2);
			if (Client != null)
			{
				Client.Send(array, array.Length);
			}
		}

		public void 系统提示(string string_11)
		{
			byte[] array = Converter.hexStringToByte("AA55A5000000660097000F000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000055AA");
			byte[] bytes = Encoding.Default.GetBytes(string_11);
			System.Buffer.BlockCopy(bytes, 0, array, 35, bytes.Length);
			System.Buffer.BlockCopy(BitConverter.GetBytes(0), 0, array, 4, 2);
			if (Client != null)
			{
				Client.Send(array, array.Length);
			}
		}

		public void 系统公告(string string_11)
		{
			byte[] array = Converter.hexStringToByte("AA55A50000006600970008000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000055AA");
			byte[] bytes = Encoding.Default.GetBytes(string_11);
			System.Buffer.BlockCopy(bytes, 0, array, 35, bytes.Length);
			if (Client != null)
			{
				Client.Send(array, array.Length);
			}
		}

		public void 系统滚动公告(string string_11)
		{
			byte[] array = Converter.hexStringToByte("AA55A50000006600970008000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000055AA");
			byte[] bytes = Encoding.Default.GetBytes(string_11);
			System.Buffer.BlockCopy(bytes, 0, array, 35, bytes.Length);
			if (Client != null)
			{
				Client.Send(array, array.Length);
			}
		}

		public virtual void 发送当前范围广播数据(byte[] data, int length)
		{
		}

		public virtual void 发送当前范围广播数据(发包类 pak, int id, int wordid)
		{
		}

		public void 有新传书提示(int int_109, int int_110)
		{
			foreach (个人传书类 value in 传书列表.Values)
			{
				if (value.是否已读 == 0)
				{
					byte[] array = Converter.hexStringToByte("AA550F000000B200010002000000000000F1A755AA");
					System.Buffer.BlockCopy(BitConverter.GetBytes(int_109), 0, array, 10, 1);
					if (int_109 == 3)
					{
						System.Buffer.BlockCopy(BitConverter.GetBytes(int_110), 0, array, 11, 4);
					}
					Client.Send(array, array.Length);
				}
			}
		}

		public void 查看传书()
		{
			try
			{
				if (传书列表 != null)
				{
					byte[] array = Converter.hexStringToByte("AA55D1010000B20023020000");
					byte[] array2 = Converter.hexStringToByte("00000000000000000055AA");
					byte[] array3 = new byte[array.Length + array2.Length + 传书列表.Count * 36];
					System.Buffer.BlockCopy(array, 0, array3, 0, array.Length);
					System.Buffer.BlockCopy(array2, 0, array3, array3.Length - array2.Length, array2.Length);
					System.Buffer.BlockCopy(BitConverter.GetBytes(传书列表.Count * 36 + 17), 0, array3, 2, 2);
					System.Buffer.BlockCopy(BitConverter.GetBytes(传书列表.Count * 36 + 9), 0, array3, 8, 2);
					System.Buffer.BlockCopy(BitConverter.GetBytes(传书列表.Count), 0, array3, 11, 2);
					int num = 0;
					foreach (个人传书类 value in 传书列表.Values)
					{
						byte[] array4 = new byte[32];
						System.Buffer.BlockCopy(BitConverter.GetBytes(value.传书ID), 0, array4, 0, 4);
						System.Buffer.BlockCopy(BitConverter.GetBytes(value.是否NPC), 0, array4, 4, 1);
						byte[] bytes = Encoding.Default.GetBytes(value.传书发送人);
						System.Buffer.BlockCopy(bytes, 0, array4, 5, bytes.Length);
						System.Buffer.BlockCopy(BitConverter.GetBytes(value.传书时间.Year - 2000), 0, array4, 25, 1);
						System.Buffer.BlockCopy(BitConverter.GetBytes(value.传书时间.Month), 0, array4, 26, 1);
						System.Buffer.BlockCopy(BitConverter.GetBytes(value.传书时间.Day), 0, array4, 27, 1);
						System.Buffer.BlockCopy(BitConverter.GetBytes(value.传书时间.Hour), 0, array4, 28, 1);
						System.Buffer.BlockCopy(BitConverter.GetBytes(value.传书时间.Minute), 0, array4, 29, 1);
						System.Buffer.BlockCopy(BitConverter.GetBytes(value.是否已读), 0, array4, 30, 2);
						System.Buffer.BlockCopy(array4, 0, array3, num * 36 + 13, array4.Length);
						num++;
					}
					Client.Send(array3, array3.Length);
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "查看传书出错()出错" + 人物全服ID + "|  " + ex.Message);
			}
		}

		public void NPC发送传书(string string_11, string string_12, int int_109)
		{
			个人传书类 个人传书类 = new 个人传书类();
			个人传书类.传书ID = (int)RxjhClass.GetDBItmeId();
			个人传书类.传书发送人 = string_11;
			个人传书类.传书内容 = string_12;
			个人传书类.传书时间 = DateTime.Now;
			个人传书类.是否NPC = 0;
			个人传书类.是否已读 = 0;
			传书列表.Add(个人传书类.传书ID, 个人传书类);
			查看传书();
			有新传书提示(2, 0);
			if (int_109 == 1)
			{
				RxjhClass.创建传书(string_11, UserName, 0, string_12, 2);
			}
		}

		public bool 检查五行披风属性符(物品类 物品类_0)
		{
			if (!追加状态列表.ContainsKey(1008001021) && !追加状态列表.ContainsKey(1008001026))
			{
				if (!追加状态列表.ContainsKey(1008001022) && !追加状态列表.ContainsKey(1008001027))
				{
					if (!追加状态列表.ContainsKey(1008001023) && !追加状态列表.ContainsKey(1008001028))
					{
						if (!追加状态列表.ContainsKey(1008001024) && !追加状态列表.ContainsKey(1008001029))
						{
							if (!追加状态列表.ContainsKey(1008001025) && !追加状态列表.ContainsKey(1008001030))
							{
								return false;
							}
							FLD_装备_追加_攻击 += (装备栏已穿装备[3].物品攻击力 + 装备栏已穿装备[3].物品攻击力MAX) * 5 / 200;
							FLD_装备_武功攻击力增加百分比 += 0.1;
							FLD_装备_追加_防御 += FLD_装备_追加_防御 / 10;
							FLD_装备_追加_HP += 500;
							FLD_装备_追加_MP += 500;
							return true;
						}
						FLD_装备_追加_气功 += 3;
						FLD_装备_追加_经验百分比 += 0.2;
						return true;
					}
					FLD_装备_追加_气功 += 3;
					FLD_装备_追加_经验百分比 += 0.2;
					FLD_装备_追加_攻击 += (装备栏已穿装备[3].物品攻击力 + 装备栏已穿装备[3].物品攻击力MAX) * 5 / 200;
					FLD_装备_武功攻击力增加百分比 += 0.1;
					FLD_装备_追加_防御 += FLD_装备_追加_防御 / 10;
					FLD_装备_追加_HP += 500;
					FLD_装备_追加_MP += 500;
					return true;
				}
				FLD_装备_追加_气功 += 3;
				FLD_装备_追加_经验百分比 += 0.4;
				FLD_装备_追加_攻击 += (装备栏已穿装备[3].物品攻击力 + 装备栏已穿装备[3].物品攻击力MAX) * 5 / 200;
				FLD_装备_武功攻击力增加百分比 += 0.1;
				FLD_装备_追加_防御 += FLD_装备_追加_防御 / 10;
				FLD_装备_追加_HP += 500;
				FLD_装备_追加_MP += 300;
				return true;
			}
			FLD_装备_追加_气功 += 3;
			FLD_装备_追加_经验百分比 += 0.4;
			FLD_装备_追加_攻击 += (装备栏已穿装备[3].物品攻击力 + 装备栏已穿装备[3].物品攻击力MAX) * 7 / 200;
			FLD_装备_武功攻击力增加百分比 += 0.12;
			FLD_装备_追加_防御 += FLD_装备_追加_防御 / 8;
			FLD_装备_追加_HP += 600;
			FLD_装备_追加_MP += 400;
			return true;
		}

		public bool 检查门甲条件(int int_109)
		{
			if (int_109 == 900102 && 帮派等级 < 4)
			{
				系统提示("必须加入门派,并且门派等级大于4级才可以佩戴。");
				return false;
			}
			if (int_109 == 900103 && 帮派等级 < 5)
			{
				系统提示("必须加入门派,并且门派等级大于5级才可以佩戴。");
				return false;
			}
			if (int_109 == 900104 && 帮派等级 < 6)
			{
				系统提示("必须加入门派,并且门派等级大于6级才可以佩戴。");
				return false;
			}
			if (int_109 >= 900105 && int_109 <= 900108)
			{
				if (帮派等级 < 7)
				{
					系统提示("必须加入门派,并且门派等级大于7级才可以佩戴。");
					return false;
				}
				if (帮派人物等级 < 2)
				{
					系统提示("必须是门派长老级别以上才可以佩戴。");
					return false;
				}
			}
			if (int_109 >= 900109 && int_109 <= 900112 && 帮派等级 < 7)
			{
				系统提示("必须加入门派,并且门派等级大于7级才可以佩戴。");
				return false;
			}
			return true;
		}

		public bool 查询天关地图(int int_109)
		{
			if (int_109 != 3101 && int_109 != 3001 && int_109 != 7001 && int_109 != 2311 && int_109 != 25210 && int_109 != 25209 && int_109 != 25208)
			{
				return int_109 == 32002;
			}
			return true;
		}

		public bool 查询天关条件(int int_109)
		{
			try
			{
				if (追加状态列表 != null)
				{
					switch (int_109)
					{
					case 3001:
						if (GetAddState(999000164))
						{
							return true;
						}
						break;
					case 2311:
						if (GetAddState(900000072))
						{
							return true;
						}
						break;
					case 25208:
						if (GetAddState(900000258))
						{
							return true;
						}
						break;
					case 25209:
						if (GetAddState(900000074))
						{
							return true;
						}
						break;
					case 25210:
						if (GetAddState(900000073))
						{
							return true;
						}
						break;
					case 7001:
						if (GetAddState(999000165))
						{
							return true;
						}
						break;
					case 3101:
						if (GetAddState(999000163))
						{
							return true;
						}
						break;
					}
				}
			}
			catch
			{
				return false;
			}
			return false;
		}

		public double 得到天关福利加成(int int_109, int int_110)
		{
			try
			{
				switch (int_110)
				{
				case 3101:
					return (int_109 == 0) ? World.天关经验提高百分比基数 : ((double)World.天关物品爆率提高基数);
				case 3001:
					return (int_109 == 0) ? (World.天关经验提高百分比基数 + World.天关经验提高百分比递增) : ((double)(World.天关物品爆率提高基数 + World.天关物品爆率提高递增));
				case 2311:
					return (int_109 == 0) ? (World.天关经验提高百分比基数 + World.天关经验提高百分比递增 * 3.0) : ((double)(World.天关物品爆率提高基数 + World.天关物品爆率提高递增 * 3));
				case 32002:
					return (int_109 == 0) ? 0.2 : ((double)World.暴率 * 1.2);
				case 25208:
					return (int_109 == 0) ? (World.天关经验提高百分比基数 + World.天关经验提高百分比递增 * 6.0) : ((double)(World.天关物品爆率提高基数 + World.天关物品爆率提高递增 * 6));
				case 25209:
					return (int_109 == 0) ? (World.天关经验提高百分比基数 + World.天关经验提高百分比递增 * 5.0) : ((double)(World.天关物品爆率提高基数 + World.天关物品爆率提高递增 * 5));
				case 25210:
					return (int_109 == 0) ? (World.天关经验提高百分比基数 + World.天关经验提高百分比递增 * 4.0) : ((double)(World.天关物品爆率提高基数 + World.天关物品爆率提高递增 * 4));
				case 7001:
					return (int_109 == 0) ? (World.天关经验提高百分比基数 + World.天关经验提高百分比递增 * 2.0) : ((double)(World.天关物品爆率提高基数 + World.天关物品爆率提高递增 * 2));
				}
			}
			catch
			{
				return 0.0;
			}
			return 0.0;
		}

		public bool 检查符()
		{
			if (公有药品 == null)
			{
				return false;
			}
			if (!公有药品.ContainsKey(1008000027) && !公有药品.ContainsKey(1008000058) && !公有药品.ContainsKey(1008000061) && !公有药品.ContainsKey(1008000028) && !公有药品.ContainsKey(1008000059) && !公有药品.ContainsKey(1008000062) && !公有药品.ContainsKey(1008000029) && !公有药品.ContainsKey(1008000060))
			{
				return 公有药品.ContainsKey(1008000063);
			}
			return true;
		}

		public bool 检查符2()
		{
			if (!公有药品.ContainsKey(1008000124) && !公有药品.ContainsKey(1008000141) && !公有药品.ContainsKey(1008000140) && !公有药品.ContainsKey(1008000311) && !公有药品.ContainsKey(1008000877) && !公有药品.ContainsKey(1008000312) && !公有药品.ContainsKey(1008000320))
			{
				return 公有药品.ContainsKey(1008000318);
			}
			return true;
		}

		public int 首饰升级取首饰(int int_109, int int_110, int int_111)
		{
			if (int_111 == 0)
			{
				switch (int_109)
				{
				case 7:
					switch (int_110)
					{
					case 100018:
						return 100020;
					case 100015:
						return 100018;
					default:
						int_110++;
						return int_110;
					case 100026:
						return 0;
					case 100021:
						return 100026;
					}
				case 8:
					switch (int_110)
					{
					default:
						int_110++;
						return int_110;
					case 18:
						return 0;
					case 16:
						return 18;
					case 11:
						return 14;
					}
				default:
					return 0;
				case 10:
					switch (int_110)
					{
					default:
						int_110++;
						return int_110;
					case 700911:
						return 0;
					case 700022:
						return 700911;
					case 700017:
						return 700020;
					}
				}
			}
			switch (int_109)
			{
			case 7:
				switch (int_110)
				{
				case 100018:
					return 100015;
				case 100001:
					return 0;
				default:
					int_110--;
					return int_110;
				case 100026:
					return 100021;
				case 100020:
					return 100018;
				}
			case 8:
				switch (int_110)
				{
				default:
					int_110--;
					return int_110;
				case 18:
					return 16;
				case 14:
					return 11;
				case 1:
					return 0;
				}
			default:
				return 0;
			case 10:
				switch (int_110)
				{
				default:
					int_110--;
					return int_110;
				case 700911:
					return 700022;
				case 700020:
					return 700017;
				case 700001:
					return 0;
				}
			}
		}

		public bool 是否灵兽(int int_109)
		{
			if (int_109 != 1000000065 && int_109 != 1000000066 && int_109 != 1000000067 && int_109 != 1000000068 && int_109 != 1000000083 && int_109 != 1000000084 && int_109 != 1000000085 && int_109 != 1000000086 && int_109 != 1000001011 && int_109 != 1000001377 && int_109 != 1000001378)
			{
				return int_109 == 1000001379;
			}
			return true;
		}

		public void 发送灵兽数据(long long_5, 灵兽类 灵兽类_0)
		{
			byte[] array = Converter.hexStringToByte("AA555A002D0159104C000B00000001000000000000000000000000000000000000000000000002036300000000000000000000000000000000000000000000000000000000000000000000000000DE071600000000000000000000000000000055AA");
			byte[] bytes = Encoding.Default.GetBytes(灵兽类_0.Name);
			System.Buffer.BlockCopy(bytes, 0, array, 18, bytes.Length);
			System.Buffer.BlockCopy(BitConverter.GetBytes(灵兽类_0.FLD_JOB), 0, array, 38, 1);
			System.Buffer.BlockCopy(BitConverter.GetBytes(灵兽类_0.FLD_JOB_LEVEL), 0, array, 39, 1);
			System.Buffer.BlockCopy(BitConverter.GetBytes(灵兽类_0.FLD_LEVEL), 0, array, 40, 2);
			System.Buffer.BlockCopy(BitConverter.GetBytes(灵兽类_0.FLD_MAGIC1), 0, array, 42, 4);
			System.Buffer.BlockCopy(BitConverter.GetBytes(灵兽类_0.FLD_MAGIC2), 0, array, 46, 4);
			System.Buffer.BlockCopy(BitConverter.GetBytes(灵兽类_0.FLD_MAGIC3), 0, array, 50, 4);
			System.Buffer.BlockCopy(BitConverter.GetBytes(灵兽类_0.FLD_MAGIC4), 0, array, 54, 4);
			System.Buffer.BlockCopy(BitConverter.GetBytes(灵兽类_0.FLD_MAGIC5), 0, array, 58, 4);
			double num = Convert.ToInt64(World.lever[人物灵兽.FLD_LEVEL]) - Convert.ToInt64(World.lever[人物灵兽.FLD_LEVEL - 1]);
			double num2 = 人物灵兽.FLD_EXP - Convert.ToInt64(World.lever[人物灵兽.FLD_LEVEL - 1]);
			if (num2 < 1.0)
			{
				人物灵兽.FLD_EXP = Convert.ToInt64(World.lever[人物灵兽.FLD_LEVEL - 1]);
				num2 = 0.0;
			}
			System.Buffer.BlockCopy(BitConverter.GetBytes((int)num2), 0, array, 62, 4);
			System.Buffer.BlockCopy(BitConverter.GetBytes((int)num), 0, array, 70, 4);
			System.Buffer.BlockCopy(BitConverter.GetBytes(long_5), 0, array, 78, 8);
			System.Buffer.BlockCopy(BitConverter.GetBytes(人物全服ID), 0, array, 4, 2);
			if (Client != null)
			{
				Client.Send多包(array, array.Length);
			}
		}

		public void 发送灵兽数据(long long_5)
		{
			try
			{
				DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  *  FROM  TBL_XWWL_Cw  WHERE  ItmeId  ={0}", long_5));
				if (dBToDataTable != null)
				{
					if (dBToDataTable.Rows.Count > 0)
					{
						byte[] array = Converter.hexStringToByte("AA555A002D0159104C000B00000001000000000000000000000000000000000000000000000002036300000000000000000000000000000000000000000000000000000000000000000000000000DE071600000000000000000000000000000055AA");
						System.Buffer.BlockCopy(BitConverter.GetBytes(人物全服ID), 0, array, 4, 2);
						string s = dBToDataTable.Rows[0]["Name"].ToString();
						long num = long.Parse(dBToDataTable.Rows[0]["FLD_EXP"].ToString());
						int num2 = (int)dBToDataTable.Rows[0]["FLD_LEVEL"];
						int value = (int)dBToDataTable.Rows[0]["FLD_JOB"];
						int value2 = (int)dBToDataTable.Rows[0]["FLD_JOB_LEVEL"];
						int num5 = (int)dBToDataTable.Rows[0]["FLD_HP"];
						int value3 = (int)dBToDataTable.Rows[0]["FLD_MAGIC1"];
						int value4 = (int)dBToDataTable.Rows[0]["FLD_MAGIC2"];
						int value5 = (int)dBToDataTable.Rows[0]["FLD_MAGIC3"];
						int value6 = (int)dBToDataTable.Rows[0]["FLD_MAGIC4"];
						int value7 = (int)dBToDataTable.Rows[0]["FLD_MAGIC5"];
						byte[] bytes = Encoding.Default.GetBytes(s);
						System.Buffer.BlockCopy(bytes, 0, array, 18, bytes.Length);
						System.Buffer.BlockCopy(BitConverter.GetBytes(value), 0, array, 38, 1);
						System.Buffer.BlockCopy(BitConverter.GetBytes(value2), 0, array, 39, 1);
						System.Buffer.BlockCopy(BitConverter.GetBytes(num2), 0, array, 40, 2);
						System.Buffer.BlockCopy(BitConverter.GetBytes(value3), 0, array, 42, 4);
						System.Buffer.BlockCopy(BitConverter.GetBytes(value4), 0, array, 46, 4);
						System.Buffer.BlockCopy(BitConverter.GetBytes(value5), 0, array, 50, 4);
						System.Buffer.BlockCopy(BitConverter.GetBytes(value6), 0, array, 54, 4);
						System.Buffer.BlockCopy(BitConverter.GetBytes(value7), 0, array, 58, 4);
						double num3 = Convert.ToInt64(World.lever[num2]) - Convert.ToInt64(World.lever[num2 - 1]);
						double num4 = num - Convert.ToInt64(World.lever[num2 - 1]);
						if (num4 < 1.0)
						{
							Convert.ToInt64(World.lever[num2 - 1]);
							num4 = 0.0;
						}
						System.Buffer.BlockCopy(BitConverter.GetBytes((int)num4), 0, array, 62, 4);
						System.Buffer.BlockCopy(BitConverter.GetBytes((int)num3), 0, array, 70, 4);
						System.Buffer.BlockCopy(BitConverter.GetBytes(long_5), 0, array, 78, 8);
						if (Client != null)
						{
							Client.Send多包(array, array.Length);
						}
					}
					dBToDataTable.Dispose();
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "发送灵兽数据(long  qjid)出错  [" + Userid + "][" + UserName + "][" + long_5 + "]  " + ex.Message);
			}
		}

		public void 更新玫瑰排行(Players players_0, Players players_1, int int_109)
		{
			try
			{
				DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT      *      FROM      TBL_XWWL_RoseTop      WHERE      FLD_NAME      =      '{0}'", players_0.UserName));
				if (dBToDataTable != null && dBToDataTable.Rows.Count > 0)
				{
					DBA.ExeSqlCommand(string.Format("UPDATE      TBL_XWWL_RoseTop      SET      FLD_OUTNUM=FLD_OUTNUM+{1}      WHERE      FLD_NAME='{0}'", players_0.UserName, int_109));
				}
				else
				{
					DBA.ExeSqlCommand(string.Format("INSERT      INTO      TBL_XWWL_RoseTop      (FLD_NAME,FLD_SEX,FLD_ZX,FLD_INNUM,FLD_OUTNUM)      VALUES      ('{0}',{1},{2},{3},{4})", players_0.UserName, players_0.Player_Sex, players_0.Player_Zx, 0, int_109));
				}
				DataTable dBToDataTable2 = DBA.GetDBToDataTable(string.Format("SELECT      *      FROM      TBL_XWWL_RoseTop      WHERE      FLD_NAME      =      '{0}'", players_1.UserName));
				if (dBToDataTable2 != null && dBToDataTable2.Rows.Count > 0)
				{
					DBA.ExeSqlCommand(string.Format("UPDATE      TBL_XWWL_RoseTop      SET      FLD_INNUM=FLD_INNUM+{1}      WHERE      FLD_NAME='{0}'", players_1.UserName, int_109));
				}
				else
				{
					DBA.ExeSqlCommand(string.Format("INSERT      INTO      TBL_XWWL_RoseTop      (FLD_NAME,FLD_SEX,FLD_ZX,FLD_INNUM,FLD_OUTNUM)      VALUES      ('{0}',{1},{2},{3},{4})", players_1.UserName, players_1.Player_Sex, players_1.Player_Zx, int_109, 0));
				}
				if (dBToDataTable2 != null)
				{
					dBToDataTable2.Dispose();
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "更新玫瑰排行()出错      [" + Userid + "][" + UserName + "][赠送数量:" + int_109 + "]      " + ex.Message);
			}
		}

		public void 打开玫瑰排行(byte[] byte_0, int int_109)
		{
			try
			{
				int num = 1;
				int num2 = 1;
				发包类 发包类 = new 发包类();
				for (int i = 0; i < 4; i++)
				{
					switch (i)
					{
					case 1:
						num = 2;
						num2 = 1;
						break;
					case 2:
						num = 1;
						num2 = 2;
						break;
					case 3:
						num = 2;
						num2 = 2;
						break;
					}
					DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  top  5  *  FROM  TBL_XWWL_RoseTop  where  FLD_SEX  =  {0}  and  FLD_ZX={1}  Order  By  FLD_INNUM  Desc", num2, num));
					if (dBToDataTable != null && dBToDataTable.Rows.Count > 0)
					{
						for (int j = 0; j < dBToDataTable.Rows.Count; j++)
						{
							int value = j + 1;
							发包类.Write1(value);
							发包类.WriteString(dBToDataTable.Rows[j]["FLD_NAME"].ToString(), 15);
							发包类.Write4((int)dBToDataTable.Rows[j]["FLD_INNUM"]);
							发包类.Write4(0);
						}
						if (dBToDataTable.Rows.Count < 5)
						{
							for (int k = 0; k < 5 - dBToDataTable.Rows.Count; k++)
							{
								发包类.Write8(0L);
								发包类.Write8(0L);
								发包类.Write8(0L);
							}
						}
						dBToDataTable.Dispose();
					}
					else
					{
						if (dBToDataTable != null)
						{
							dBToDataTable.Dispose();
						}
						for (int l = 0; l < 5; l++)
						{
							发包类.Write8(0L);
							发包类.Write8(0L);
							发包类.Write8(0L);
						}
					}
				}
				int num3 = 0;
				int num4 = 0;
				int num5 = 0;
				DataTable dBToDataTable2 = DBA.GetDBToDataTable("SELECT  FLD_NAME,FLD_INNUM,FLD_OUTNUM  FROM  TBL_XWWL_RoseTop  Order  By  FLD_INNUM  Desc");
				if (dBToDataTable2 != null && dBToDataTable2.Rows.Count > 0)
				{
					for (int m = 0; m < dBToDataTable2.Rows.Count; m++)
					{
						if (dBToDataTable2.Rows[m]["FLD_NAME"].ToString() == UserName)
						{
							num3 = m + 1;
							num4 = (int)dBToDataTable2.Rows[m]["FLD_OUTNUM"];
							num5 = (int)dBToDataTable2.Rows[m]["FLD_INNUM"];
							break;
						}
					}
				}
				if (dBToDataTable2 != null)
				{
					dBToDataTable2.Dispose();
				}
				发包类.Write8(num3);
				发包类.Write8(num4);
				发包类.Write8(num5);
				发包类.Write4(0);
				if (Client != null)
				{
					Client.SendPak(发包类, 1795, 人物全服ID);
				}
			}
			catch
			{
			}
		}

		public 发包类 得到更新人物排名数据(string string_11, string string_12, int int_109, int int_110, int int_111, int int_112, int int_113)
		{
			发包类 发包类 = new 发包类();
			try
			{
				DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  FLD_FACE,FLD_WEARITEM,FLD_JOB_LEVEL    FROM  TBL_XWWL_Char    where  FLD_NAME='{0}'", string_11), "GameServer");
				if (dBToDataTable != null && dBToDataTable.Rows.Count != 0)
				{
					人物模板类 人物模板类 = new 人物模板类((byte[])dBToDataTable.Rows[0]["FLD_FACE"]);
					int value = (int)dBToDataTable.Rows[0]["FLD_JOB_LEVEL"];
					byte[] array = (byte[])dBToDataTable.Rows[0]["FLD_WEARITEM"];
					物品类[] array2 = new 物品类[15];
					for (int i = 0; i < 15; i++)
					{
						byte[] array3 = new byte[World.数据库单个物品大小];
						if (array.Length >= i * World.数据库单个物品大小 + World.数据库单个物品大小)
						{
							try
							{
								System.Buffer.BlockCopy(array, i * World.数据库单个物品大小, array3, 0, World.数据库单个物品大小);
							}
							catch (Exception ex)
							{
								Form1.WriteLine(i, "  " + ((ex != null) ? ex.ToString() : null));
							}
						}
						array2[i] = new 物品类(array3, i);
					}
					int value2 = BitConverter.ToInt32(array2[0].物品ID, 0);
					int value3 = BitConverter.ToInt32(array2[1].物品ID, 0);
					int value4 = BitConverter.ToInt32(array2[2].物品ID, 0);
					int value5 = BitConverter.ToInt32(array2[4].物品ID, 0);
					int value6 = BitConverter.ToInt32(array2[3].物品ID, 0);
					int value7 = BitConverter.ToInt32(array2[5].物品ID, 0);
					int value8 = BitConverter.ToInt32(array2[6].物品ID, 0);
					int value9 = BitConverter.ToInt32(array2[7].物品ID, 0);
					int value10 = BitConverter.ToInt32(array2[11].物品ID, 0);
					int value11 = BitConverter.ToInt32(array2[13].物品ID, 0);
					int fLD_强化数量 = array2[3].FLD_强化数量;
					dBToDataTable.Dispose();
					发包类.WriteString(string_11, 14);
					发包类.Write4(0);
					发包类.Write2(0);
					发包类.WriteString(string_12, 14);
					发包类.Write4(0);
					发包类.Write(int_109);
					发包类.Write(int_110);
					发包类.Write(value);
					发包类.Write(int_111);
					发包类.Write2(0);
					发包类.Write2(人物模板类.发色);
					发包类.Write2(人物模板类.发型);
					发包类.Write2(人物模板类.脸型);
					发包类.Write(0);
					发包类.Write(人物模板类.性别);
					发包类.Write4(0);
					发包类.Write4(0);
					发包类.Write4(0);
					发包类.Write4(0);
					发包类.Write4(value2);
					发包类.Write4(0);
					发包类.Write4(value3);
					发包类.Write4(0);
					发包类.Write4(value4);
					发包类.Write4(0);
					发包类.Write4(value5);
					发包类.Write4(0);
					发包类.Write4(value6);
					发包类.Write4(0);
					发包类.Write4(value7);
					发包类.Write4(0);
					发包类.Write4(value8);
					发包类.Write4(0);
					发包类.Write4(value9);
					发包类.Write4(0);
					发包类.Write4(fLD_强化数量);
					发包类.Write4(value10);
					发包类.Write4(0);
					发包类.Write8(0L);
					发包类.Write8(0L);
					发包类.Write8(0L);
					发包类.Write8(0L);
					发包类.Write4(value11);
					发包类.Write4(0);
					发包类.Write2(0);
					发包类.Write2(0);
					发包类.Write4(0);
					发包类.Write4(0);
					发包类.Write2(0);
					发包类.Write2(0);
					发包类.Write4(0);
					发包类.Write4(0);
					发包类.Write4(0);
					发包类.Write(new byte[48], 0, 48);
					发包类.Write4(0);
					发包类.Write4(0);
					发包类.Write(0);
					发包类.WriteName("");
					发包类.Write(0);
					发包类.Write(0);
					发包类.Write(0);
					发包类.Write(0);
					发包类.Write(0);
					发包类.Write(0);
					发包类.Write(0);
					发包类.Write(0);
					发包类.Write2(0);
					发包类.Write2(0);
					发包类.Write2(0);
					发包类.Write2(0);
					发包类.Write2(0);
					发包类.Write2(0);
					发包类.Write2(0);
					发包类.Write(new byte[74]);
					发包类.Write4(int_113);
					发包类.Write4(0);
					发包类.Write4(0);
					发包类.Write4(0);
					发包类.Write4(0);
					发包类.Write2(0);
					发包类.Write4(0);
					发包类.Write4(0);
					发包类.Write2(0);
				}
				dBToDataTable.Dispose();
				return 发包类;
			}
			catch (Exception ex2)
			{
				string[] obj = new string[8]
				{
					"得到更新人物数据  出错",
					Client.WorldId.ToString(),
					"|",
					Client.ToString(),
					"  ",
					Converter.ToString(发包类.ToArray3()),
					"  ",
					null
				};
				obj[7] = ((ex2 != null) ? ex2.ToString() : null);
				Form1.WriteLine(1, string.Concat(obj));
				return null;
			}
		}

		public void 进入游戏发送传书(string string_11, string string_12, string string_13)
		{
			if (RxjhClass.GetUserName(string_12) != 1 && 得到人物数据(string_12) != null)
			{
				个人传书类 个人传书类 = new 个人传书类();
				个人传书类.传书ID = (int)RxjhClass.GetDBItmeId();
				个人传书类.传书发送人 = string_13;
				个人传书类.传书内容 = string_11;
				个人传书类.传书时间 = DateTime.Now;
				个人传书类.是否NPC = 1;
				个人传书类.是否已读 = 0;
				传书列表.Add(个人传书类.传书ID, 个人传书类);
				查看传书();
				有新传书提示(2, 0);
			}
		}

		public int 计算升天武功威力(武功类 武功类_0)
		{
			if (武功新[武功类_0.FLD_武功类型, 武功类_0.FLD_INDEX] != null)
			{
				if (武功类_0.FLD_武功类型 == 3)
				{
					return 武功类_0.FLD_AT + (武功新[武功类_0.FLD_武功类型, 武功类_0.FLD_INDEX].武功_等级 - 1) * 武功类_0.FLD_每级加危害 / World.升天技能等级加成;
				}
				if (武功新[武功类_0.FLD_武功类型, 武功类_0.FLD_INDEX].武功_等级 > 1)
				{
					return 武功类_0.FLD_AT + (武功新[武功类_0.FLD_武功类型, 武功类_0.FLD_INDEX].武功_等级 - 1) * 武功类_0.FLD_每级加危害;
				}
				return 武功类_0.FLD_AT;
			}
			return 0;
		}

		public void 更新服务器列表(string string_11)
		{
			try
			{
				string[] array = string_11.Split(',');
				ServerList serverList = new ServerList();
				serverList.服务器IP = array[1];
				serverList.服务器端口 = int.Parse(array[2]);
				serverList.服务器ID = int.Parse(array[3]);
				int key = int.Parse(array[0]);
				ServerList value;
				if (!SerList.TryGetValue(key, out value))
				{
					SerList.Add(key, serverList);
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "换线      获取服务器列表      出错      [" + Userid + "][" + UserName + "]      " + ex.Message);
			}
		}

		public void kickidlog(string string_11)
		{
			logo.kickid(Userid + "|" + UserName + "|" + Client.ToString() + "|" + string_11);
		}
	}
}
