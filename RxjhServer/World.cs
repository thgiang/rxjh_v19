using DNGuard;
using Newtonsoft.Json;
using RxjhServer.DbClss;
using RxjhServer.HelperTools;
using RxjhServer.Network;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace RxjhServer
{
	public class World
	{
		public static double ServerVer;

		public static double ServerVerD;

		public static string ServerRegTime;

		public static string[] 移动速度;

		public static int MainServer;

		public static bool Droplog;

		public static int ServerIDStart;

		public static int 离线数量;

		public static string Key;

		public static string Key2;

		public static AtapiDevice Keyk;

		public static int AllItmelog;

		public static int 是否开启共用银币市场;

		public static int 当前是否是银币线路;

		public static int 允许开店;

		public static int 允许交易;

		public static int 允许挂机;

		public static int PK开关;

		public static int 连续快速攻击次数;

		public static int 连续攻击有效时间;

		public static int 非法攻击外挂操作;

		public static bool AlWorldlog;

		public static bool Process;

		public static Dictionary<int, 装备检测类> 装备检测list;

		public static ThreadSafeDictionary<int, NetState> list;

		public static List<int> 普通气功ID;

		public static Dictionary<string, EventTopClass> EventTop;

		public static ThreadSafeDictionary<int, Players> allConnectedChars;

		public static Dictionary<string, string> 禁言列表;

		public static Dictionary<int, 升天气功总类> 升天气功List;

		public static Dictionary<int, 任务类> 任务list;

		public static Dictionary<string, DbClass> Db;

		public static Queue m_Disposed;

		public static Queue SqlPool;

		public static Dictionary<int, MapClass> Map;

		public static Dictionary<int, 帮战Class> 帮战list;

		public static Dictionary<int, 帮战Class> 帮战Namelist;

		public static Dictionary<int, string> Maplist;

		public static Dictionary<int, NpcClass> NpcList;

		public static Dictionary<int, Wedding> 婚礼list;

		public static Dictionary<int, 门派成员> 门派成员list;

		public static Dictionary<int, 百宝阁类> 百宝阁属性物品类list;

		public static Dictionary<int, PVP类> PVP装备;

		public static int 新门战进程;

		public static int 攻击时间间隔;

		public static int AtPort;

		public static bool 龙赡殿是否在使用中;

		public static bool 华婚殿是否在使用中;

		public static bool 圣礼殿是否在使用中;

		public static int 最大速度超出次数操作;

		public static int 三十秒内允许超出次数;

		public static int 周末武勋量;

		public static int 衣服附魂增加属性数量;

		public static int 武器附魂增加属性数量;

		public static int 耳环加工一阶段增加生命;

		public static int 项链加工一阶段增加防御;

		public static int 戒指加工一阶段增加攻击;

		public static int 二转每日武勋上限;

		public static int 三转每日武勋上限;

		public static int 四转每日武勋上限;

		public static int 五转每日武勋上限;

		public static int 六转每日武勋上限;

		public static int 七转每日武勋上限;

		public static int 八转每日武勋上限;

		public static int 九转每日武勋上限;

		public static int 十转每日武勋上限;

		public static double 一转经验百分比;

		public static double 二转经验百分比;

		public static double 三转经验百分比;

		public static double 四转经验百分比;

		public static double 五转经验百分比;

		public static double 六转经验百分比;

		public static double 七转经验百分比;

		public static double 八转经验百分比;

		public static double 九转经验百分比;

		public static double 十转经验百分比;

		public static List<DropClass> Drop_Jl;

		public static Dictionary<string, string> 势力战掉线玩家;

		public static Dictionary<int, 荣誉Class> 势力战排行数据;

		public static Dictionary<int, 荣誉Class> 武林血战排行数据;

		public static Dictionary<int, 荣誉Class> 帮派排行数据;

		public static List<门派排名> 门派排名数据;

		public static double 武功防御力控制;

		public static double 武功攻击力倍数;

		public static int 开启卡技能;

		public static int 卡技能等级;

		public static int 坐标刷新时间;

		public static int 攻击时间控制;

		public static int 贡献元宝数;

		public static int 贡献元宝荣誉点;

		public static int Script;

		public static int 双倍经验等级上限;

		public static int 双倍金钱等级上限;

		public static int 双倍历练等级上限;

		public static int 双倍暴率等级上限;

		public static double 双倍等级上限倍数;

		public static int 限制最高级别;

		public static int 发包单个物品大小;

		public static int 数据库单个物品大小;

		public static int 物品属性大小;

		public static int 升天技能等级加成;

		public static int 外挂PK时间;

		public static int 外挂打怪时间;

		public static int AutGC;

		public static double locklist;

		public static double locklist2;

		public static List<object> locklist3;

		public static int 每次狮吼功消耗元宝;

		public static int 允许多开数量;

		public static int 是否开启门战系统;

		public static int 申请门战需要元宝;

		public static int 门战系统开启时;

		public static int 门战系统开启分;

		public static int 门战系统开启秒;

		public static int 胜利帮派ID;

		public static int 每次分解消耗元宝数;

		public static int 游戏登陆端口最大连接数;

		public static int 游戏登陆端口最大连接时间数;

		public static int 查非法物品;

		public static int 查非法物品操作;

		public static bool 查绑定非法物品;

		public static int 物品最高攻击值;

		public static int 物品最高防御值;

		public static int 物品最高生命值;

		public static int 物品最高内功值;

		public static int 物品最高命中值;

		public static int 物品最高回避值;

		public static int 物品最高武功值;

		public static int 物品最高气功值;

		public static int 物品最高合成值;

		public static int 物品最高附魂值;

		public static int 物品最高武防值;

		public static int 组队级别限制;

		public static int 心跳检测开关;

		public static int 心跳检测操作;

		public static int 心跳检测时间阀值;

		public static int 心跳检测时长;

		public static int 安全模式消耗元宝;

		public static int 是否开启新手上线设置;

		public static int 上线等级;

		public static int 银票兑换元宝;

		public static int 是否开启银票兑换元宝;

		public static int 上线送礼包套装;

		public static int 获得经验等级差;

		public static int 移动间隔时间;

		public static int 是否开启装备加解锁功能;

		public static int 装备加锁消耗元宝;

		public static int 装备解锁消耗元宝;

		public static int 是否开启挂机奖励;

		public static int 挂机奖励时间周期;

		public static int 挂机奖励元宝;

		public static int 挂机奖励金钱;

		public static int 挂机奖励武勋;

		public static int 挂机消除善恶;

		public static int 挂机消除宠物忠诚度;

		public static int 挂机奖励要求等级;

		public static string 挂机双倍区域BOSS;

		public static bool 双倍区域BOSS是否开启;

		public static string 挂机双倍时间段;

		public static int 购买武勋装备消耗武勋;

		public static int 是否支持扩展物品属性位数;

		public static int 安全挂机时间;

		public static int 挂机奖励赠品元宝;

		public static double 灵宠进化率;

		public static double 灵宠强化率;

		public static double 道具强化概率;

		public static int 武器PK掉耐久度;

		public static int 防具PK掉耐久度;

		public static double 刀PK伤害参数;

		public static double 剑PK伤害参数;

		public static double 枪PK伤害参数;

		public static double 弓PK伤害参数;

		public static double 医PK伤害参数;

		public static double 刺PK伤害参数;

		public static double 乐PK伤害参数;

		public static double 韩PK伤害参数;

		public static double 谭PK伤害参数;

		public static double 拳PK伤害参数;

		public static double 梅PK伤害参数;

		public static double 卢PK伤害参数;

		public static int 单次交易元宝数量上限;

		public static int 帐号总元宝上限;

		public static int 元宝检测操作;

		public static int 是否开启武勋系统;

		public static int PK等级差;

		public static int 武勋保护等级;

		public static string 死亡减少武勋数量;

		public static string 系统回收数量;

		public static double 武勋回收百分比;

		public static int 物品记录;

		public static int 登陆记录;

		public static int 掉落记录;

		public static int 商店记录;

		public static int 药品记录;

		public static int 合成记录;

		public static int 记录保存天数;

		public static bool 封IP;

		public static List<IPAddress> BipList;

		public static int 自动连接时间;

		public static int 版本验证时间;

		public static bool 主Socket;

		public static string SocketState;

		public static bool 自动开启连接;

		public static int 允许最大连接数;

		public static bool 断开连接;

		public static bool 加入过滤列表;

		public static bool 关闭连接;

		public static int 世界时间;

		public static int W组队Id;

		public static int ver;

		public static int tf;

		public static int jlMsg;

		public static int week;

		public static int 是否允许快速攻击;

		public static int 是否开启四神系统;

		public static int 外挂检测操作;

		public static int 势力战进程;

		public static int 势力战时间;

		public static int 势力战正分数;

		public static int 势力战邪分数;

		public static int 势力战正人数;

		public static int 势力战邪人数;

		public static int 势力战是否开启;

		public static int 势力战开启小时;

		public static int 势力战开启分;

		public static int 势力战开启秒;

		public static int 势力战时长;

		public static int 势力战预备时间;

		public static int 第一名奖励元宝;

		public static int 势力战奖励类型;

		public static int 势力战奖励数量;

		public static int 势力战奖励套装;

		public static int 势力战随机奖励盒子ID;

		public static int 是否开启对练场赌元宝;

		public static int 允许玩家押注数量;

		public static float 场地有效范围;

		public static int 进场最低费用;

		public static double 场地佣金百分比;

		public static int 允许逃跑次数;

		public static int 分数扣完扣除元宝;

		public static int 分数扣完扣除金钱;

		public static int Eve90进程;

		public static int Eve90时间;

		public static ThreadSafeDictionary<int, Players> evePlayers;

		public static bool isvip;

		public static int 元宝合成;

		public static long 最大钱数;

		public static double 发送速度;

		public static double 广播发送速度;

		public static double 接收速度;

		public static int 经验倍数;

		public static int 吸魂机率;

		public static int 钱倍数;

		public static int 历练倍数;

		public static double 升天历练倍数;

		public static int 暴率;

		public static double 合成率;

		public static double 强化率;

		public static double 赋予属性率;

		public static double 附魂率;

		public static double 首饰加工率;

		public static double 披风强化率;

		public static double 装备升级率;

		public static double 首饰升级率;

		public static string 百宝阁地址;

		public static string 百宝阁服务器IP;

		public static int 百宝阁服务器端口;

		public static string 帐号验证服务器IP;

		public static int 帐号验证服务器端口;

		public static int 游戏服务器端口;

		public static int 游戏服务器端口1;

		public static int 游戏服务器端口2;

		public static int 游戏服务器端口3;

		public static int 转发器网关服务端口;

		public static int vip线;

		public static int 最大在线;

		public static int 服务器组ID;

		public static int 服务器ID;

		public static string 服务器名;

		public static string 进入公告;

		public static AtapiDevice KeykF;

		public static int 狮子吼ID;

		public static Queue 狮子吼List;

		public static Dictionary<int, 攻城战> 攻城战list;

		public static List<Players> 申请攻城人物列表;

		public static Dictionary<int, 攻城数据> 攻城数据list;

		public static int 天魔神宫雕像是否死亡;

		public static int 天魔神宫大门是否死亡;

		public static int 攻城战进程;

		public static int 攻城时间;

		public static int 攻城战是否开启;

		public static int 攻城战开启小时;

		public static int 攻城战开启分;

		public static int 攻城战开启秒;

		public static int 狮子吼最大数;

		public static int 是否加密;

		public static string 加密密钥;

		public static byte[] g_cur_key;

		public static int 是否加密2;

		public static int 封包封号;

		public static int 组队等级限制;

		public static int Vip上线公告;

		public static string Vip上线公告内容;

		public static int 普通上线公告;

		public static string 普通上线公告内容;

		public static string VIP地图;

		public static string 地图锁定;

		public static string SqlJl;

		public static int 元宝检测;

		public static int 装备最大数;

		public static int 自动存档;

		public static double 至尊强化率;

		public static string 灵宠强化总概率;

		public static double 灵宠强化一阶段概率;

		public static double 灵宠强化二阶段概率;

		public static double 灵宠强化三阶段概率;

		public static double 灵宠强化四阶段概率;

		public static double 灵宠强化五阶段概率;

		public static double 灵宠强化六阶段概率;

		public static double 灵宠强化七阶段概率;

		public static long 王龙的金币;

		public static double 是否开放九泉地图;

		public static double 九泉金币比率;

		public static double 其他地图金币比率;

		public static int 王龙地图ID;

		public static string 文件MD5;

		public static string 再造金刚石攻击;

		public static string 再造金刚石追伤;

		public static string 再造金刚石武功;

		public static string 再造金刚石命中;

		public static string 再造金刚石生命;

		public static string 再造寒玉石防御;

		public static string 再造寒玉石回避;

		public static string 再造寒玉石生命;

		public static string 再造寒玉石内功;

		public static string 再造寒玉石武防;

		public static double 武功防降低百分比;

		public static double 武功攻击力百分比;

		public static double 攻减防加乘;

		public static double 武功减武防加乘;

		public static int 是否开启死亡掉经验;

		public static double VIP经验增加百分比;

		public static double VIP历练增加百分比;

		public static double VIP金钱增加百分比;

		public static double 经验获得降低百分比;

		public static double 金钱获得降低百分比;

		public static double 历练获得降低百分比;

		public static double VIP合成率增加百分比;

		public static double 医生PK距离;

		public static double 弓箭手PK距离;

		public static double 其他职业PK距离;

		public static double 医生打怪距离;

		public static double 弓箭手打怪距离;

		public static double 其他职业打怪距离;

		public static double 经验提高倍数;

		public static int 高倍经验开始时间;

		public static int 高倍经验结束时间;

		public static double 天关经验提高百分比基数;

		public static int 天关物品爆率提高基数;

		public static double 天关经验提高百分比递增;

		public static int 天关物品爆率提高递增;

		public static int wg36;

		public static int wg37;

		public static int wg38;

		public static int wg39;

		public static int wg40;

		public static int wg35;

		public static int wg34;

		public static int wg33;

		public static int wg32;

		public static int wg31;

		public static int wg30;

		public static int wg29;

		public static int wg28;

		public static int wg27;

		public static int wg26;

		public static int wg25;

		public static int wf100;

		public static int wf95;

		public static int wf90;

		public static int wf85;

		public static int wf80;

		public static int wf78;

		public static int wf76;

		public static int wf74;

		public static int wf72;

		public static int wf70;

		public static int wf68;

		public static int g25;

		public static int g24;

		public static int g23;

		public static int g22;

		public static int g21;

		public static int g20;

		public static int f15;

		public static int f14;

		public static int f13;

		public static int f12;

		public static int f11;

		public static int f10;

		public static int 装备提真消耗;

		public static int 装备提真数量;

		public static int 门战奖励物品ID;

		public static int 修炼之地是否开启;

		public static int 修炼之地开启ID;

		public static double 队伍满人经验加成;

		public static string 随机BOSS出现时间表;

		public static int 是否开启锁人攻击检测;

		public static int 锁人攻击次数上限;

		public static int 锁人攻击检测操作;

		public static int 占卜费用;

		public static string ipaddress;

		public static Dictionary<int, 制作物品类> 制作物品列表;

		public static Dictionary<int, 制药物品类> 制药物品列表;

		public static string 进入传书内容;

		public static string 进入传书发送人;

		public static AtServerConnect ycServerConnect;

		public static string 贡献元宝命令;

		public static string[] 门派第一称号奖励;

		public static string[] 门派第二称号奖励;

		public static string[] 门派第三称号奖励;

		public static string[] 玫瑰第一名奖励;

		public static string[] 玫瑰第二名奖励;

		public static string[] 玫瑰第三名奖励;

		public static string[] 玫瑰第四名奖励;

		public static string[] 玫瑰第五名奖励;

		public static string 分区编号;

		public static 攻城Class 攻城;

		public static object 地面物品Lock;

		public static object 开箱Lock;

		public static Dictionary<int, double> lever;

		public static Dictionary<int, double> Wxlever;

		public static Dictionary<int, 公告类> 公告;

		public static Dictionary<int, 等级奖励类> 等级奖励;

		public static Dictionary<int, 气功加成属性> 气功加成;

		public static Dictionary<int, 物品兑换类> 物品兑换;

		public static ThreadSafeDictionary<long, 地面物品类> ItmeTeM;

		public static Dictionary<int, MonSterClss> MonSter;

		public static Dictionary<int, ItmeClass> Itme;

		public static Dictionary<int, 武功类> TBL_KONGFU;

		public static Dictionary<int, 组队Class> W组队;

		public static Dictionary<int, BbgSellClass> 百宝阁数据;

		public static 帮派战_血战 血战;

		public static 帮派战_门战 帮战;

		public static List<ShopClass> Shop;

		public static List<检查物品类> 物品检查;

		public static List<KillClass> Kill;

		public static List<DropClass> Drop;

		public static List<DropClass> Drop_GS;

		public static List<DropClass> BossDrop;

		public static List<OpenClass> Open;

		public static List<MoveClass> Mover;

		public static List<坐标Class> 移动;

		public static List<ItemSellClass> 套装数据;

		public static EventClass eve;

		public static 仙魔战循环公告 仙魔战公告;

		public static string 势力战奖励属性;

		public static string 势力战奖励物品;

		public static ThreadSafeDictionary<int, Players> allPVPChars;

		public static List<坐标Class> 对练区;

		public static List<坐标Class> 势力战区域;

		public static List<坐标Class> 帮战区;

		public static EvePVPClass EVEPVP;

		public static List<int> BOSSListTime;

		public static int Log;

		public static int 验证服务器log;

		public static int jllog;

		public static ScriptClass 脚本;

		public static Connect conn;

		public static int 每次消耗的数量;

		public static int 每次再造消耗设置;

		public static int 平砍间隔时间;

		public static double 强化一合成率;

		public static double 强化二合成率;

		public static double 强化三合成率;

		public static double 强化四合成率;

		public static double 强化五合成率;

		public static double 强化六合成率;

		public static double 强化七合成率;

		public static double 强化八合成率;

		public static double 强化九合成率;

		public static double 强化十合成率;

		public static double 强化十一合成率;

		public static double 强化十二合成率;

		public static double 强化十三合成率;

		public static double 强化十四合成率;

		public static double 强化十五合成率;

		public static double 至尊取玉强11;

		public static double 至尊取玉强12;

		public static double 至尊取玉强13;

		public static double 至尊取玉强14;

		public static double 至尊取玉强15;

		public static string[] 至高无上称号奖励;

		public static string[] 举世无双称号奖励;

		public static string[] 雄霸天下称号奖励;

		public static string[] 孤胆英雄称号奖励;

		public static string[] 英雄豪杰称号奖励;

		public static int 武器8阶段添加攻击;

		public static int 武器9阶段添加攻击;

		public static int 武器10阶段添加攻击;

		public static int 武器11阶段添加攻击;

		public static int 武器12阶段添加攻击;

		public static int 武器13阶段添加攻击;

		public static int 武器14阶段添加攻击;

		public static int 武器15阶段添加攻击;

		public static int 衣服8阶段添加防御;

		public static int 衣服9阶段添加防御;

		public static int 衣服10阶段添加防御;

		public static int 衣服11阶段添加防御;

		public static int 衣服12阶段添加防御;

		public static int 衣服13阶段添加防御;

		public static int 衣服14阶段添加防御;

		public static int 衣服15阶段添加防御;

		public static int 护手8阶段添加防御;

		public static int 护手9阶段添加防御;

		public static int 护手10阶段添加防御;

		public static int 护手11阶段添加防御;

		public static int 护手12阶段添加防御;

		public static int 护手13阶段添加防御;

		public static int 护手14阶段添加防御;

		public static int 护手15阶段添加防御;

		public static int 鞋子8阶段添加防御;

		public static int 鞋子9阶段添加防御;

		public static int 鞋子10阶段添加防御;

		public static int 鞋子11阶段添加防御;

		public static int 鞋子12阶段添加防御;

		public static int 鞋子13阶段添加防御;

		public static int 鞋子14阶段添加防御;

		public static int 鞋子15阶段添加防御;

		public static int 内甲8阶段添加防御;

		public static int 内甲9阶段添加防御;

		public static int 内甲10阶段添加防御;

		public static int 内甲11阶段添加防御;

		public static int 内甲12阶段添加防御;

		public static int 内甲13阶段添加防御;

		public static int 内甲14阶段添加防御;

		public static int 内甲15阶段添加防御;

		[SecureCallbackMethod]
		public void clear()
		{
			wg40 = 0;
			wg39 = 0;
			wg38 = 0;
			wg37 = 0;
			wg36 = 0;
			wg35 = 0;
			wg34 = 0;
			wg33 = 0;
			wg32 = 0;
			wg31 = 0;
			wg30 = 0;
			wg29 = 0;
			wg28 = 0;
			wg27 = 0;
			wg26 = 0;
			wg25 = 0;
			wf100 = 0;
			wf95 = 0;
			wf90 = 0;
			wf85 = 0;
			wf80 = 0;
			wf78 = 0;
			wf76 = 0;
			wf74 = 0;
			wf72 = 0;
			wf70 = 0;
			wf68 = 0;
			g25 = 0;
			g24 = 0;
			g23 = 0;
			g22 = 0;
			g21 = 0;
			g20 = 0;
			f15 = 0;
			f14 = 0;
			f13 = 0;
			f12 = 0;
			f11 = 0;
			f10 = 0;
		}

		public static void 更新所有排行数据()
		{
			try
			{
				势力战排行数据.Clear();
				DataTable dBToDataTable = DBA.GetDBToDataTable("SELECT  top  20  *  FROM TBL_荣誉系统  where  FLD_类型  =  1  Order  By  FLD_分数  Desc");
				if (dBToDataTable != null && dBToDataTable.Rows.Count != 0)
				{
					for (int i = 0; i < dBToDataTable.Rows.Count; i++)
					{
						势力战排行数据.Add(i, new 荣誉Class
						{
							人物名 = dBToDataTable.Rows[i]["FLD_人物名"].ToString(),
							帮派 = dBToDataTable.Rows[i]["FLD_帮派"].ToString(),
							职业 = (int)dBToDataTable.Rows[i]["FLD_职业"],
							势力 = (int)dBToDataTable.Rows[i]["FLD_势力"],
							等级 = (int)dBToDataTable.Rows[i]["FLD_等级"],
							分数 = (int)dBToDataTable.Rows[i]["FLD_分数"],
							类型 = 1
						});
					}
				}
				dBToDataTable.Dispose();
				武林血战排行数据.Clear();
				DataTable dBToDataTable2 = DBA.GetDBToDataTable("SELECT  top  20  *  FROM  TBL_荣誉系统  where  FLD_类型  =  2  Order  By  FLD_分数  Desc");
				if (dBToDataTable2 != null && dBToDataTable2.Rows.Count != 0)
				{
					for (int j = 0; j < dBToDataTable2.Rows.Count; j++)
					{
						武林血战排行数据.Add(j, new 荣誉Class
						{
							人物名 = dBToDataTable2.Rows[j]["FLD_人物名"].ToString(),
							帮派 = dBToDataTable2.Rows[j]["FLD_帮派"].ToString(),
							职业 = (int)dBToDataTable2.Rows[j]["FLD_职业"],
							势力 = (int)dBToDataTable2.Rows[j]["FLD_势力"],
							等级 = (int)dBToDataTable2.Rows[j]["FLD_等级"],
							分数 = (int)dBToDataTable2.Rows[j]["FLD_分数"],
							类型 = 2
						});
					}
				}
				dBToDataTable2.Dispose();
				帮派排行数据.Clear();
				DataTable dBToDataTable3 = DBA.GetDBToDataTable("SELECT  top  20  *  FROM  TBL_荣誉系统  where  FLD_类型  =  3  Order  By  FLD_分数  Desc");
				if (dBToDataTable3 != null && dBToDataTable3.Rows.Count != 0)
				{
					for (int k = 0; k < dBToDataTable3.Rows.Count; k++)
					{
						帮派排行数据.Add(k, new 荣誉Class
						{
							帮派 = dBToDataTable3.Rows[k]["FLD_帮派"].ToString(),
							帮派门主 = dBToDataTable3.Rows[k]["FLD_帮派门主"].ToString(),
							职业 = (int)dBToDataTable3.Rows[k]["FLD_职业"],
							势力 = (int)dBToDataTable3.Rows[k]["FLD_势力"],
							等级 = (int)dBToDataTable3.Rows[k]["FLD_等级"],
							分数 = (int)dBToDataTable3.Rows[k]["FLD_分数"],
							类型 = 3
						});
					}
				}
				dBToDataTable3.Dispose();
			}
			catch (Exception ex)
			{
				Form1.WriteLine(2, "更新所有排行数据错误" + ex.Message);
			}
		}

		public static void 发送全服大武圣称号获得消息(string string_0, int int_0)
		{
			try
			{
				byte[] array = Converter.hexStringToByte("AA55BA0060000051B400010000000A000000BC17000000000000000000000000000000000000000000000000000033300000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000055AA");
				byte[] bytes = Encoding.Default.GetBytes(string_0);
				System.Buffer.BlockCopy(bytes, 0, array, 46, bytes.Length);
				if (int_0 == 2)
				{
					System.Buffer.BlockCopy(Buffer.GetBytes(6077), 0, array, 18, 2);
				}
				foreach (Players value in allConnectedChars.Values)
				{
					if (value.Client != null)
					{
						System.Buffer.BlockCopy(Buffer.GetBytes(value.人物全服ID), 0, array, 4, 2);
						value.Client.Send(array, array.Length);
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "World发送全服武勋称号获得消息数据出错![" + string_0 + "]" + ex.Message);
			}
		}

		public static void 发送全服武勋称号获得消息(string string_0, int int_0)
		{
			try
			{
				byte[] array = Converter.hexStringToByte("AA55C200E8040051B400010000000A00000064110000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000055AA");
				byte[] bytes = Encoding.Default.GetBytes(string_0);
				System.Buffer.BlockCopy(bytes, 0, array, 46, bytes.Length);
				if (int_0 == 1)
				{
					System.Buffer.BlockCopy(Buffer.GetBytes(4451), 0, array, 18, 2);
				}
				foreach (Players value in allConnectedChars.Values)
				{
					if (value.Client != null)
					{
						System.Buffer.BlockCopy(Buffer.GetBytes(value.人物全服ID), 0, array, 4, 2);
						value.Client.Send(array, array.Length);
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "World发送全服武勋称号获得消息数据出错![" + string_0 + "]" + ex.Message);
			}
		}

		public static double 查队伍职业(组队Class 组队Class_0, Players players_0)
		{
			if (组队Class_0.队员列表.Count != 8)
			{
				return 0.0;
			}
			Players players = 检查玩家name(组队Class_0.队长Name);
			if (players != null)
			{
				foreach (Players value in 组队Class_0.队员列表.Values)
				{
					Players player = value;
					if (!players_0.查找范围玩家(700, players))
					{
						return 0.0;
					}
				}
			}
			return 队伍满人经验加成;
		}

		public static byte[] 封包转换(byte[] byte_0, int int_0, int int_1)
		{
			if (int_1 == 0)
			{
				byte[] array = new byte[int_0 + 1];
				System.Buffer.BlockCopy(byte_0, 0, array, 0, 4);
				System.Buffer.BlockCopy(byte_0, 4, array, 5, int_0 - 4);
				System.Buffer.BlockCopy(Buffer.GetBytes(byte_0[2] + 1), 0, array, 2, 2);
				System.Buffer.BlockCopy(Buffer.GetBytes(byte_0[8] + 1), 0, array, 9, 2);
				return array;
			}
			byte[] array2 = new byte[int_0 - 1];
			System.Buffer.BlockCopy(byte_0, 0, array2, 0, 4);
			System.Buffer.BlockCopy(byte_0, 5, array2, 4, int_0 - 5);
			System.Buffer.BlockCopy(Buffer.GetBytes(array2.Length - 6), 0, array2, 2, 2);
			System.Buffer.BlockCopy(Buffer.GetBytes(array2.Length - 12), 0, array2, 8, 2);
			return array2;
		}

		public static int 计算玩家下注结果(int int_0, int int_1, int int_2)
		{
			int num = RNG.Next(0, 9) + int_0 + int_1;
			try
			{
				int num2 = 0;
				int num3 = 0;
				foreach (Players value in allConnectedChars.Values)
				{
					if (!value.Client.挂机 && value.是否押注 && value.押注专场代码 == int_2)
					{
						if (value.押注单双 == "单")
						{
							num2++;
						}
						else
						{
							num3++;
						}
					}
				}
				if (num % 2 == 0)
				{
					if (num3 != 0 && num2 != 0)
					{
						int num4 = (int)((double)(num2 * 允许玩家押注数量) * (1.0 - 场地佣金百分比) / (double)num3);
						foreach (Players value2 in allConnectedChars.Values)
						{
							if (!value2.Client.挂机 && value2.是否押注 && value2.押注专场代码 == int_2)
							{
								if (value2.押注单双 == "双")
								{
									value2.查百宝阁元宝数();
									value2.检察元宝数据(num4, 1);
									value2.保存元宝数据();
									value2.系统提示("恭喜你，这回出的是【双】数。", 13, "系统提示");
									RxjhClass.百宝记录(value2.Userid, value2.UserName, 0.0, "押注赢", 1, num4);
								}
								else
								{
									value2.查百宝阁元宝数();
									value2.检察元宝数据(允许玩家押注数量, 0);
									value2.保存元宝数据();
									value2.系统提示("手气真差，这回出的是【双】数。", 13, "系统提示");
									RxjhClass.百宝记录(value2.Userid, value2.UserName, 0.0, "押注输", 1, 允许玩家押注数量);
								}
								value2.押注单双 = string.Empty;
								value2.押注专场代码 = 0;
								value2.是否押注 = false;
								value2.元宝账户状态 = false;
							}
						}
					}
					else if (num2 == 0)
					{
						foreach (Players value3 in allConnectedChars.Values)
						{
							if (!value3.Client.挂机 && value3.是否押注 && value3.押注专场代码 == int_2)
							{
								if (value3.押注单双 == "双")
								{
									value3.查百宝阁元宝数();
									value3.检察元宝数据((int)((double)允许玩家押注数量 * 场地佣金百分比), 0);
									value3.保存元宝数据();
									value3.系统提示("由于本场无人压【单】数,系统将扣除压【双】数玩家手续费" + (int)((double)允许玩家押注数量 * 场地佣金百分比) + "元宝！", 13, "系统提示");
									RxjhClass.百宝记录(value3.Userid, value3.UserName, 0.0, "押注手续费", 1, (int)((double)允许玩家押注数量 * 场地佣金百分比));
								}
								value3.押注单双 = string.Empty;
								value3.押注专场代码 = 0;
								value3.是否押注 = false;
								value3.元宝账户状态 = false;
							}
						}
					}
					else if (num3 == 0)
					{
						foreach (Players value4 in allConnectedChars.Values)
						{
							if (!value4.Client.挂机 && value4.是否押注 && value4.押注专场代码 == int_2)
							{
								if (value4.押注单双 == "单")
								{
									value4.查百宝阁元宝数();
									value4.检察元宝数据(允许玩家押注数量, 0);
									value4.保存元宝数据();
									value4.系统提示("手气真差,这回出的是【双】数。", 13, "系统提示");
									RxjhClass.百宝记录(value4.Userid, value4.UserName, 0.0, "押注输", 1, 允许玩家押注数量);
								}
								value4.押注单双 = string.Empty;
								value4.押注专场代码 = 0;
								value4.是否押注 = false;
								value4.元宝账户状态 = false;
							}
						}
					}
				}
				else if (num2 != 0 && num3 != 0)
				{
					int num5 = (int)((double)(num3 * 允许玩家押注数量) * (1.0 - 场地佣金百分比) / (double)num2);
					foreach (Players value5 in allConnectedChars.Values)
					{
						if (!value5.Client.挂机 && value5.是否押注 && value5.押注专场代码 == int_2)
						{
							if (value5.押注单双 == "单")
							{
								value5.查百宝阁元宝数();
								value5.检察元宝数据(num5, 1);
								value5.保存元宝数据();
								value5.系统提示("恭喜你，这回出的是【单】数。", 13, "系统提示");
								RxjhClass.百宝记录(value5.Userid, value5.UserName, 0.0, "押注赢", 1, num5);
							}
							else
							{
								value5.查百宝阁元宝数();
								value5.检察元宝数据(允许玩家押注数量, 0);
								value5.保存元宝数据();
								value5.系统提示("手气真差，这回出的是【单】数。", 13, "系统提示");
								RxjhClass.百宝记录(value5.Userid, value5.UserName, 0.0, "押注输", 1, 允许玩家押注数量);
							}
							value5.押注单双 = string.Empty;
							value5.押注专场代码 = 0;
							value5.是否押注 = false;
							value5.元宝账户状态 = false;
						}
					}
				}
				else if (num3 == 0)
				{
					foreach (Players value6 in allConnectedChars.Values)
					{
						if (!value6.Client.挂机 && value6.是否押注 && value6.押注专场代码 == int_2)
						{
							if (value6.押注单双 == "单")
							{
								value6.查百宝阁元宝数();
								value6.检察元宝数据((int)((double)允许玩家押注数量 * 场地佣金百分比), 0);
								value6.保存元宝数据();
								value6.系统提示("由于本场无人压【双】数,系统将扣除压【单】数玩家手续费" + (int)((double)允许玩家押注数量 * 场地佣金百分比) + "元宝。", 13, "系统提示");
								RxjhClass.百宝记录(value6.Userid, value6.UserName, 0.0, "押注手续费", 1, (int)((double)允许玩家押注数量 * 场地佣金百分比));
							}
							value6.押注单双 = string.Empty;
							value6.押注专场代码 = 0;
							value6.是否押注 = false;
							value6.元宝账户状态 = false;
						}
					}
				}
				else if (num2 == 0)
				{
					foreach (Players value7 in allConnectedChars.Values)
					{
						if (!value7.Client.挂机 && value7.是否押注 && value7.押注专场代码 == int_2)
						{
							if (value7.押注单双 == "双")
							{
								value7.查百宝阁元宝数();
								value7.检察元宝数据(允许玩家押注数量, 0);
								value7.保存元宝数据();
								value7.系统提示("手气真差，这回出的是【单】数。", 13, "系统提示");
								RxjhClass.百宝记录(value7.Userid, value7.UserName, 0.0, "押注输", 1, 允许玩家押注数量);
							}
							value7.押注单双 = string.Empty;
							value7.押注专场代码 = 0;
							value7.是否押注 = false;
							value7.元宝账户状态 = false;
						}
					}
				}
				return num;
			}
			catch
			{
				return num;
			}
		}

		public static Players 检查玩家(string string_0)
		{
			foreach (Players value in allConnectedChars.Values)
			{
				if (Buffer.IsEquals(value.Userid, string_0))
				{
					return value;
				}
			}
			return null;
		}

		public static Players 检查玩家世界ID(int int_0)
		{
			Players value;
			if (allConnectedChars.TryGetValue(int_0, out value))
			{
				return value;
			}
			return null;
		}

		public static Players 检查玩家name(string string_0)
		{
			foreach (Players value in allConnectedChars.Values)
			{
				if (value.UserName == string_0)
				{
					return value;
				}
			}
			return null;
		}

		public static void 发送公告(string string_0)
		{
			foreach (Players value in allConnectedChars.Values)
			{
				if (!value.Client.挂机)
				{
					value.系统公告(string_0);
				}
			}
		}

		public static void 系统滚动公告(string string_0)
		{
			foreach (Players value in allConnectedChars.Values)
			{
				if (!value.Client.挂机)
				{
					value.系统滚动公告(string_0);
				}
			}
		}

		public static void Process狮子吼Queue()
		{
			if (狮子吼List.Count > 0)
			{
				狮子吼Class 狮子吼Class = (狮子吼Class)狮子吼List.Dequeue();
				发送狮子吼消息广播数据(狮子吼Class.FLD_INDEX, 狮子吼Class.UserName, 狮子吼Class.TxtId, 狮子吼Class.Txt);
			}
		}

		private int method_0(int int_0, int int_1)
		{
			int result = 0;
			foreach (气功加成属性 value in 气功加成.Values)
			{
				if (value.FLD_JOB == int_1 && value.FLD_INDEX == int_0)
				{
					result = value.FLD_PID;
				}
			}
			return result;
		}

		public static void 发送狮子吼消息广播数据(int int_0, string string_0, int int_1, string string_1)
		{
			try
			{
				byte[] array = Converter.hexStringToByte("AA55B6002D016600A800CC00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000055AA");
				array[10] = 35;
				byte[] bytes = Encoding.Default.GetBytes(string_0);
				byte[] bytes2 = Encoding.Default.GetBytes(string_1);
				System.Buffer.BlockCopy(bytes2, 0, array, 35, bytes2.Length);
				System.Buffer.BlockCopy(bytes, 0, array, 12, bytes.Length);
				System.Buffer.BlockCopy(BitConverter.GetBytes(int_0), 0, array, 4, 2);
				array[34] = (byte)int_1;
				foreach (Players value in allConnectedChars.Values)
				{
					if (value.Client != null && !value.Client.挂机)
					{
						value.Client.Send(array, array.Length);
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "World发送狮子吼消息广播数据出错![" + int_0 + "]-[" + string_0 + "]-[" + string_1 + "]" + ex.Message);
			}
		}

		public static void 发送全服狮子吼消息广播数据(int int_0, string string_0, int int_1, string string_1, int int_2, int int_3, int int_4)
		{
			try
			{
				byte[] array = Converter.hexStringToByte("AA55B600E5026600A800260000000000000000000000000000000000000000000000560000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000065000000000000000000000055AA");
				array[10] = (byte)int_4;
				System.Buffer.BlockCopy(BitConverter.GetBytes(int_2), 0, array, 169, 2);
				System.Buffer.BlockCopy(BitConverter.GetBytes(int_3), 0, array, 174, 4);
				byte[] bytes = Encoding.Default.GetBytes(string_0);
				byte[] bytes2 = Encoding.Default.GetBytes(string_1);
				System.Buffer.BlockCopy(bytes2, 0, array, 35, bytes2.Length);
				System.Buffer.BlockCopy(bytes, 0, array, 12, bytes.Length);
				System.Buffer.BlockCopy(BitConverter.GetBytes(int_0), 0, array, 4, 2);
				array[34] = (byte)int_1;
				foreach (Players value in allConnectedChars.Values)
				{
					if (value.Client != null && !value.Client.挂机)
					{
						value.Client.Send(array, array.Length);
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "World发送狮子吼消息广播数据出错![" + int_0 + "]-[" + string_0 + "]-[" + string_1 + "]" + ex.Message);
			}
		}

		public static void 发送传音消息(int int_0, string string_0, string string_1, string string_2, int int_1, string string_3)
		{
			try
			{
				foreach (Players value in allConnectedChars.Values)
				{
					if (Buffer.IsEquals(value.UserName, string_1))
					{
						if (value.Config.传音 == 0)
						{
							value.系统提示("您有传音消息,请打开传音开关。", 50, "系统提示");
						}
						else
						{
							value.发送传音消息(string_0, int_0, value, string_2, int_1);
						}
						break;
					}
				}
			}
			catch
			{
			}
		}

		public static void 发送帮派消息(string string_0, byte[] byte_0, int int_0)
		{
			try
			{
				foreach (Players value in allConnectedChars.Values)
				{
					if (Buffer.IsEquals(value.帮派名字, string_0) && value.Client != null)
					{
						value.Client.Send(byte_0, int_0);
					}
				}
			}
			catch
			{
			}
		}

		public static int Add组队(组队Class 组队Class_0)
		{
			W组队Id++;
			W组队.Add(W组队Id, 组队Class_0);
			return W组队Id;
		}

		static World()
		{
			ServerVer = 2.0;
			ServerVerD = 0.0;
			ServerRegTime = string.Empty;
			移动速度 = new string[5];
			MainServer = 1;
			Droplog = false;
			ServerIDStart = 0;
			离线数量 = 0;
			Key = "192.168.0.4";
			Key2 = "192.168.0.4";
			Keyk = new AtapiDevice();
			AllItmelog = 1;
			是否开启共用银币市场 = 0;
			当前是否是银币线路 = 0;
			允许开店 = 0;
			允许交易 = 0;
			允许挂机 = 0;
			PK开关 = 0;
			连续快速攻击次数 = 1;
			连续攻击有效时间 = 1000;
			非法攻击外挂操作 = 0;
			AlWorldlog = true;
			Process = false;
			装备检测list = new Dictionary<int, 装备检测类>();
			list = new ThreadSafeDictionary<int, NetState>();
			普通气功ID = new List<int>();
			EventTop = new Dictionary<string, EventTopClass>();
			allConnectedChars = new ThreadSafeDictionary<int, Players>();
			禁言列表 = new Dictionary<string, string>();
			升天气功List = new Dictionary<int, 升天气功总类>();
			任务list = new Dictionary<int, 任务类>();
			Db = new Dictionary<string, DbClass>();
			m_Disposed = Queue.Synchronized(new Queue());
			SqlPool = Queue.Synchronized(new Queue());
			Map = new Dictionary<int, MapClass>();
			帮战list = new Dictionary<int, 帮战Class>();
			帮战Namelist = new Dictionary<int, 帮战Class>();
			Maplist = new Dictionary<int, string>();
			NpcList = new Dictionary<int, NpcClass>();
			婚礼list = new Dictionary<int, Wedding>();
			门派成员list = new Dictionary<int, 门派成员>();
			百宝阁属性物品类list = new Dictionary<int, 百宝阁类>();
			PVP装备 = new Dictionary<int, PVP类>();
			新门战进程 = 0;
			攻击时间间隔 = 1000;
			AtPort = 55980;
			龙赡殿是否在使用中 = false;
			华婚殿是否在使用中 = false;
			圣礼殿是否在使用中 = false;
			最大速度超出次数操作 = 0;
			三十秒内允许超出次数 = 0;
			周末武勋量 = 100000;
			二转每日武勋上限 = 0;
			三转每日武勋上限 = 0;
			四转每日武勋上限 = 0;
			五转每日武勋上限 = 0;
			六转每日武勋上限 = 0;
			七转每日武勋上限 = 0;
			八转每日武勋上限 = 0;
			九转每日武勋上限 = 0;
			十转每日武勋上限 = 0;
			一转经验百分比 = 0.0;
			二转经验百分比 = 0.0;
			三转经验百分比 = 0.0;
			四转经验百分比 = 0.0;
			五转经验百分比 = 0.0;
			六转经验百分比 = 0.0;
			七转经验百分比 = 0.0;
			八转经验百分比 = 0.0;
			九转经验百分比 = 0.0;
			十转经验百分比 = 0.0;
			Drop_Jl = new List<DropClass>();
			势力战掉线玩家 = new Dictionary<string, string>();
			势力战排行数据 = new Dictionary<int, 荣誉Class>();
			武林血战排行数据 = new Dictionary<int, 荣誉Class>();
			帮派排行数据 = new Dictionary<int, 荣誉Class>();
			门派排名数据 = new List<门派排名>();
			武功防御力控制 = 100.0;
			武功攻击力倍数 = 1.0;
			开启卡技能 = 1;
			卡技能等级 = 120;
			坐标刷新时间 = 3000;
			攻击时间控制 = 600;
			贡献元宝数 = 0;
			贡献元宝荣誉点 = 0;
			Script = 0;
			双倍经验等级上限 = 59;
			双倍金钱等级上限 = 59;
			双倍历练等级上限 = 59;
			双倍暴率等级上限 = 59;
			双倍等级上限倍数 = 2.0;
			限制最高级别 = 180;
			发包单个物品大小 = 96;
			数据库单个物品大小 = 73;
			物品属性大小 = 56;
			升天技能等级加成 = 3;
			外挂PK时间 = 0;
			外挂打怪时间 = 1000;
			AutGC = 0;
			locklist = 0.0;
			locklist2 = 0.0;
			locklist3 = new List<object>();
			每次狮吼功消耗元宝 = 20;
			允许多开数量 = 2;
			是否开启门战系统 = 0;
			申请门战需要元宝 = 0;
			门战系统开启时 = 0;
			门战系统开启分 = 0;
			门战系统开启秒 = 0;
			胜利帮派ID = 0;
			每次分解消耗元宝数 = 10;
			游戏登陆端口最大连接数 = 20;
			游戏登陆端口最大连接时间数 = 1000;
			查非法物品 = 0;
			查非法物品操作 = 3;
			查绑定非法物品 = false;
			物品最高攻击值 = 0;
			物品最高防御值 = 0;
			物品最高生命值 = 0;
			物品最高内功值 = 0;
			物品最高命中值 = 0;
			物品最高回避值 = 0;
			物品最高武功值 = 0;
			物品最高气功值 = 0;
			物品最高合成值 = 0;
			物品最高附魂值 = 0;
			物品最高武防值 = 0;
			组队级别限制 = 15;
			心跳检测开关 = 0;
			心跳检测操作 = 0;
			心跳检测时间阀值 = 10000;
			心跳检测时长 = 0;
			安全模式消耗元宝 = 0;
			是否开启新手上线设置 = 0;
			上线等级 = 0;
			银票兑换元宝 = 0;
			是否开启银票兑换元宝 = 0;
			上线送礼包套装 = 0;
			获得经验等级差 = 15;
			移动间隔时间 = 600;
			是否开启装备加解锁功能 = 0;
			装备加锁消耗元宝 = 0;
			装备解锁消耗元宝 = 0;
			是否开启挂机奖励 = 0;
			挂机奖励时间周期 = 0;
			挂机奖励元宝 = 0;
			挂机奖励金钱 = 0;
			挂机奖励武勋 = 50;
			挂机消除善恶 = 150;
			挂机消除宠物忠诚度 = 0;
			挂机奖励要求等级 = 0;
			挂机双倍区域BOSS = "";
			双倍区域BOSS是否开启 = false;
			挂机双倍时间段 = "20;22";
			购买武勋装备消耗武勋 = 1000;
			是否支持扩展物品属性位数 = 0;
			安全挂机时间 = 0;
			挂机奖励赠品元宝 = 0;
			灵宠进化率 = 0.0;
			灵宠强化率 = 0.0;
			道具强化概率 = 0.0;
			武器PK掉耐久度 = 0;
			防具PK掉耐久度 = 0;
			刀PK伤害参数 = 0.0;
			剑PK伤害参数 = 0.0;
			枪PK伤害参数 = 0.0;
			弓PK伤害参数 = 0.0;
			医PK伤害参数 = 0.0;
			刺PK伤害参数 = 0.0;
			乐PK伤害参数 = 0.0;
			韩PK伤害参数 = 0.0;
			谭PK伤害参数 = 0.0;
			拳PK伤害参数 = 0.0;
			梅PK伤害参数 = 0.0;
			卢PK伤害参数 = 0.0;
			单次交易元宝数量上限 = 0;
			帐号总元宝上限 = 0;
			元宝检测操作 = 0;
			是否开启武勋系统 = 0;
			PK等级差 = 20;
			武勋保护等级 = 80;
			死亡减少武勋数量 = "0;0;0;0;0;0";
			系统回收数量 = "0;0;0;0;0;0";
			武勋回收百分比 = 0.2;
			物品记录 = 0;
			登陆记录 = 0;
			掉落记录 = 0;
			商店记录 = 0;
			药品记录 = 0;
			合成记录 = 0;
			记录保存天数 = 30;
			封IP = true;
			BipList = new List<IPAddress>();
			自动连接时间 = 10;
			版本验证时间 = 10000;
			主Socket = false;
			SocketState = "Stoped";
			自动开启连接 = true;
			允许最大连接数 = 100;
			断开连接 = true;
			加入过滤列表 = true;
			关闭连接 = true;
			世界时间 = 0;
			W组队Id = 1;
			ver = 3;
			tf = 0;
			jlMsg = 0;
			week = (int)DateTime.Now.DayOfWeek;
			是否允许快速攻击 = 1;
			是否开启四神系统 = 0;
			外挂检测操作 = 0;
			势力战进程 = 0;
			势力战时间 = 0;
			势力战正分数 = 0;
			势力战邪分数 = 0;
			势力战正人数 = 0;
			势力战邪人数 = 0;
			势力战是否开启 = 0;
			势力战开启小时 = 0;
			势力战开启分 = 0;
			势力战开启秒 = 0;
			势力战时长 = 30;
			势力战预备时间 = 5;
			第一名奖励元宝 = 0;
			势力战奖励类型 = 0;
			势力战奖励数量 = 500;
			势力战奖励套装 = 0;
			势力战随机奖励盒子ID = 0;
			是否开启对练场赌元宝 = 0;
			允许玩家押注数量 = 100;
			场地有效范围 = 60f;
			进场最低费用 = 100;
			场地佣金百分比 = 0.2;
			允许逃跑次数 = 10;
			分数扣完扣除元宝 = 10;
			分数扣完扣除金钱 = 10000;
			Eve90进程 = 0;
			Eve90时间 = 0;
			evePlayers = new ThreadSafeDictionary<int, Players>();
			isvip = false;
			元宝合成 = 5;
			最大钱数 = 20000000000L;
			发送速度 = 0.0;
			广播发送速度 = 0.0;
			接收速度 = 0.0;
			经验倍数 = 100;
			吸魂机率 = 70;
			钱倍数 = 580;
			历练倍数 = 80;
			升天历练倍数 = 80.0;
			暴率 = 800;
			合成率 = 0.0;
			强化率 = 0.0;
			赋予属性率 = 0.0;
			附魂率 = 0.0;
			首饰加工率 = 0.0;
			披风强化率 = 0.0;
			装备升级率 = 0.0;
			首饰升级率 = 0.0;
			百宝阁地址 = "http://bbg.xwwl.net/login.aspx?server=1";
			百宝阁服务器IP = "127.0.0.1";
			百宝阁服务器端口 = 9001;
			帐号验证服务器IP = "127.0.0.1";
			帐号验证服务器端口 = 55970;
			游戏服务器端口 = 13001;
			游戏服务器端口1 = 13001;
			游戏服务器端口2 = 13001;
			游戏服务器端口3 = 13001;
			转发器网关服务端口 = 50020;
			vip线 = 0;
			最大在线 = 100;
			服务器组ID = 1;
			服务器ID = 0;
			服务器名 = "创新意江湖";
			进入公告 = "欢迎光临创新意江湖，本江湖网址http://rxjh.xwwl.net,打  !help  查看自定义命令";
			KeykF = new AtapiDevice();
			狮子吼ID = 0;
			狮子吼List = Queue.Synchronized(new Queue());
			攻城战list = new Dictionary<int, 攻城战>();
			申请攻城人物列表 = new List<Players>();
			攻城数据list = new Dictionary<int, 攻城数据>();
			天魔神宫雕像是否死亡 = 0;
			天魔神宫大门是否死亡 = 0;
			攻城战进程 = 0;
			攻城时间 = 30;
			攻城战是否开启 = 0;
			攻城战开启小时 = 0;
			攻城战开启分 = 0;
			攻城战开启秒 = 0;
			狮子吼最大数 = 100;
			是否加密 = 1;
			加密密钥 = "CCDA2343677C3790";
			g_cur_key = new byte[8]
			{
				204,
				218,
				35,
				67,
				103,
				124,
				55,
				144
			};
			是否加密2 = 0;
			封包封号 = 0;
			组队等级限制 = 10;
			Vip上线公告 = 0;
			Vip上线公告内容 = "尊贵的VIP玩家{0}上线了！大家欢迎！";
			普通上线公告 = 0;
			普通上线公告内容 = "尊贵的VIP玩家{0}上线了！大家欢迎！";
			VIP地图 = string.Empty;
			地图锁定 = string.Empty;
			SqlJl = string.Empty;
			元宝检测 = 0;
			装备最大数 = 36;
			自动存档 = 1;
			至尊强化率 = 0.0;
			灵宠强化总概率 = "20;180";
			灵宠强化一阶段概率 = 1.1;
			灵宠强化二阶段概率 = 1.1;
			灵宠强化三阶段概率 = 1.1;
			灵宠强化四阶段概率 = 1.1;
			灵宠强化五阶段概率 = 1.1;
			灵宠强化六阶段概率 = 1.1;
			灵宠强化七阶段概率 = 1.1;
			王龙的金币 = 0L;
			是否开放九泉地图 = 1.0;
			九泉金币比率 = 0.8;
			其他地图金币比率 = 0.8;
			王龙地图ID = 0;
			文件MD5 = string.Empty;
			再造金刚石攻击 = string.Empty;
			再造金刚石追伤 = string.Empty;
			再造金刚石武功 = string.Empty;
			再造金刚石命中 = string.Empty;
			再造金刚石生命 = string.Empty;
			再造寒玉石防御 = string.Empty;
			再造寒玉石回避 = string.Empty;
			再造寒玉石生命 = string.Empty;
			再造寒玉石内功 = string.Empty;
			再造寒玉石武防 = string.Empty;
			武功防降低百分比 = 0.925;
			武功攻击力百分比 = 0.01;
			攻减防加乘 = 1.5;
			武功减武防加乘 = 1.3;
			是否开启死亡掉经验 = 0;
			VIP经验增加百分比 = 0.0;
			VIP历练增加百分比 = 0.0;
			VIP金钱增加百分比 = 0.0;
			经验获得降低百分比 = 0.0;
			金钱获得降低百分比 = 0.0;
			历练获得降低百分比 = 0.0;
			VIP合成率增加百分比 = 0.0;
			医生PK距离 = 50.0;
			弓箭手PK距离 = 60.0;
			其他职业PK距离 = 40.0;
			医生打怪距离 = 50.0;
			弓箭手打怪距离 = 60.0;
			其他职业打怪距离 = 40.0;
			经验提高倍数 = 0.0;
			高倍经验开始时间 = 20;
			高倍经验结束时间 = 22;
			天关经验提高百分比基数 = 0.0;
			天关物品爆率提高基数 = 0;
			天关经验提高百分比递增 = 0.0;
			天关物品爆率提高递增 = 0;
			wg36 = 0;
			wg37 = 0;
			wg38 = 0;
			wg39 = 0;
			wg40 = 0;
			wg35 = 0;
			wg34 = 0;
			wg33 = 0;
			wg32 = 0;
			wg31 = 0;
			wg30 = 0;
			wg29 = 0;
			wg28 = 0;
			wg27 = 0;
			wg26 = 0;
			wg25 = 0;
			wf100 = 0;
			wf95 = 0;
			wf90 = 0;
			wf85 = 0;
			wf80 = 0;
			wf78 = 0;
			wf76 = 0;
			wf74 = 0;
			wf72 = 0;
			wf70 = 0;
			wf68 = 0;
			g25 = 0;
			g24 = 0;
			g23 = 0;
			g22 = 0;
			g21 = 0;
			g20 = 0;
			f15 = 0;
			f14 = 0;
			f13 = 0;
			f12 = 0;
			f11 = 0;
			f10 = 0;
			装备提真消耗 = 0;
			装备提真数量 = 0;
			门战奖励物品ID = 0;
			修炼之地是否开启 = 0;
			修炼之地开启ID = 0;
			队伍满人经验加成 = 0.2;
			随机BOSS出现时间表 = string.Empty;
			是否开启锁人攻击检测 = 0;
			锁人攻击次数上限 = 10;
			锁人攻击检测操作 = 0;
			占卜费用 = 1;
			ipaddress = Hasher.GetIP();
			制作物品列表 = new Dictionary<int, 制作物品类>();
			制药物品列表 = new Dictionary<int, 制药物品类>();
			进入传书内容 = "欢迎进入[{0}]创新意19.0仿官，本服长久稳定，公平公正，您值得信赖!";
			进入传书发送人 = "创新意江湖";
			平砍间隔时间 = 1000;
			强化一合成率 = 100.0;
			强化二合成率 = 90.0;
			强化三合成率 = 80.0;
			强化四合成率 = 70.0;
			强化五合成率 = 60.0;
			强化六合成率 = 50.0;
			强化七合成率 = 40.0;
			强化八合成率 = 30.0;
			强化九合成率 = 20.0;
			强化十合成率 = 10.0;
			强化十一合成率 = 5.0;
			强化十二合成率 = 5.0;
			强化十三合成率 = 5.0;
			强化十四合成率 = 5.0;
			强化十五合成率 = 5.0;
			至尊取玉强11 = 0.0;
			至尊取玉强12 = 0.0;
			至尊取玉强13 = 0.0;
			至尊取玉强14 = 0.0;
			至尊取玉强15 = 0.0;
			武器8阶段添加攻击 = 0;
			武器9阶段添加攻击 = 0;
			武器10阶段添加攻击 = 0;
			武器11阶段添加攻击 = 0;
			武器12阶段添加攻击 = 0;
			武器13阶段添加攻击 = 0;
			武器14阶段添加攻击 = 0;
			武器15阶段添加攻击 = 0;
			衣服8阶段添加防御 = 0;
			衣服9阶段添加防御 = 0;
			衣服10阶段添加防御 = 0;
			衣服11阶段添加防御 = 0;
			衣服12阶段添加防御 = 0;
			衣服13阶段添加防御 = 0;
			衣服14阶段添加防御 = 0;
			衣服15阶段添加防御 = 0;
			护手8阶段添加防御 = 0;
			护手9阶段添加防御 = 0;
			护手10阶段添加防御 = 0;
			护手11阶段添加防御 = 0;
			护手12阶段添加防御 = 0;
			护手13阶段添加防御 = 0;
			护手14阶段添加防御 = 0;
			护手15阶段添加防御 = 0;
			鞋子8阶段添加防御 = 0;
			鞋子9阶段添加防御 = 0;
			鞋子10阶段添加防御 = 0;
			鞋子11阶段添加防御 = 0;
			鞋子12阶段添加防御 = 0;
			鞋子13阶段添加防御 = 0;
			鞋子14阶段添加防御 = 0;
			鞋子15阶段添加防御 = 0;
			内甲8阶段添加防御 = 0;
			内甲9阶段添加防御 = 0;
			内甲10阶段添加防御 = 0;
			内甲11阶段添加防御 = 0;
			内甲12阶段添加防御 = 0;
			内甲13阶段添加防御 = 0;
			内甲14阶段添加防御 = 0;
			内甲15阶段添加防御 = 0;
			try
			{
				Kill = new List<KillClass>();
				帮战Namelist = new Dictionary<int, 帮战Class>();
				allPVPChars = new ThreadSafeDictionary<int, Players>();
				W组队 = new Dictionary<int, 组队Class>();
				公告 = new Dictionary<int, 公告类>();
				等级奖励 = new Dictionary<int, 等级奖励类>();
				气功加成 = new Dictionary<int, 气功加成属性>();
				物品兑换 = new Dictionary<int, 物品兑换类>();
				lever = new Dictionary<int, double>();
				Wxlever = new Dictionary<int, double>();
				Itme = new Dictionary<int, ItmeClass>();
				百宝阁数据 = new Dictionary<int, BbgSellClass>();
				ItmeTeM = new ThreadSafeDictionary<long, 地面物品类>();
				TBL_KONGFU = new Dictionary<int, 武功类>();
				MonSter = new Dictionary<int, MonSterClss>();
				物品检查 = new List<检查物品类>();
				BossDrop = new List<DropClass>();
				Drop = new List<DropClass>();
				Drop_GS = new List<DropClass>();
				Open = new List<OpenClass>();
				套装数据 = new List<ItemSellClass>();
				Shop = new List<ShopClass>();
				Mover = new List<MoveClass>();
				移动 = new List<坐标Class>();
				对练区 = new List<坐标Class>();
				BOSSListTime = new List<int>();
				势力战区域 = new List<坐标Class>();
				帮战区 = new List<坐标Class>();
				开箱Lock = new object();
				Keyk.CpuID = Hasher.GetCpuID();
				Keyk.DriveID = Hasher.GetDriveID("C");
				Keyk.IP = Hasher.GetIP();
				Keyk.Mac = Hasher.GetMac();
				isvip = false;
				地面物品Lock = new object();
			}
			catch (Exception ex)
			{
				Form1.WriteLine(100, "系统错误:World" + ((ex != null) ? ex.ToString() : null));
				Environment.Exit(0);
			}
		}

		private void method_1()
		{
			世界时间 = DateTime.Now.Hour * 3600 + DateTime.Now.Minute * 60 + DateTime.Now.Second;
			if (世界时间 >= 19200)
			{
				世界时间 = 0;
			}
			foreach (Players value in allConnectedChars.Values)
			{
				if (value.神女异常状态.ContainsKey(46))
				{
					if (value.人物_HP <= 0)
					{
						value.人物_HP = 0;
					}
					else if (value.人物_HP != value.人物最大_HP)
					{
						if (value.人物_HP + 160 < value.人物最大_HP)
						{
							value.人物_HP += 160;
						}
						else
						{
							value.人物_HP = value.人物最大_HP;
						}
						value.更新HP_MP_SP();
					}
				}
			}
		}

		private void method_2()
		{
			世界时间 = DateTime.Now.Hour * 3600 + DateTime.Now.Minute * 60 + DateTime.Now.Second;
			if (世界时间 >= 19200)
			{
				世界时间 = 0;
			}
			foreach (Players value in allConnectedChars.Values)
			{
				if (!value.人物移动中)
				{
					if (value.神女异常状态.ContainsKey(48))
					{
						value.人物_HP -= (int)((double)value.人物最大_HP * 0.03);
						if (value.人物_HP <= 0)
						{
							value.人物_HP = 1;
						}
						value.更新HP_MP_SP();
					}
					if (value.神女异常状态.ContainsKey(49))
					{
						value.人物_HP -= (int)((double)value.人物最大_HP * 0.05);
						if (value.人物_HP <= 0)
						{
							value.人物_HP = 1;
						}
						value.更新HP_MP_SP();
					}
				}
			}
			foreach (Players value2 in allConnectedChars.Values)
			{
				value2.称号物品结束();
			}
			if (当前是否是银币线路 == 0 && (DateTime.Now.DayOfWeek.ToString() == "Monday" || DateTime.Now.DayOfWeek.ToString() == "Wednesday" || DateTime.Now.DayOfWeek.ToString() == "Friday") && DateTime.Now.Hour == 21 && DateTime.Now.Minute == 0 && DateTime.Now.Second >= 1 && 攻城 == null)
			{
				foreach (Players value3 in allConnectedChars.Values)
				{
					if (value3.帮派名字 != string.Empty && value3.人物坐标_地图 != 42101)
					{
						value3.发送天魔神宫邀请银币();
					}
				}
			}
			if (当前是否是银币线路 == 1)
			{
				DateTime.Now.DayOfWeek.ToString();
				if ((DateTime.Now.DayOfWeek.ToString() == "Monday" || DateTime.Now.DayOfWeek.ToString() == "Wednesday" || DateTime.Now.DayOfWeek.ToString() == "Friday") && DateTime.Now.Hour == 21 && DateTime.Now.Minute == 3 && DateTime.Now.Second >= 1)
				{
					攻城 = new 攻城Class();
				}
			}
			if (经验提高倍数 > 1.0)
			{
				if (DateTime.Now.Hour == 高倍经验开始时间 && DateTime.Now.Minute == 0 && DateTime.Now.Second == 0)
				{
					经验倍数 = (int)(经验提高倍数 * (double)经验倍数);
					全局提示("系统提示", 6, 经验提高倍数 + "倍经验开启。");
				}
				else if (DateTime.Now.Hour == 高倍经验结束时间 && DateTime.Now.Minute == 0 && (DateTime.Now.Second == 0 || DateTime.Now.Second == 1 || DateTime.Now.Second == 2))
				{
					经验倍数 = ((Config.IniReadValue("GameServer", "经验倍数").Trim().Length == 0) ? 经验倍数 : int.Parse(Config.IniReadValue("GameServer", "经验倍数").Trim()));
					全局提示("系统提示", 6, 经验提高倍数 + "倍经验结束。");
				}
			}
			if (当前是否是银币线路 == 1 && 势力战是否开启 == 1 && DateTime.Now.Hour == 势力战开启小时 && DateTime.Now.Minute == 势力战开启分 && (DateTime.Now.Second == 势力战开启秒 || DateTime.Now.Second == 势力战开启秒 + 1 || DateTime.Now.Second == 势力战开启秒 + 2) && eve == null)
			{
				势力战进程 = 0;
				势力战时间 = 0;
				势力战正分数 = 0;
				势力战邪分数 = 0;
				势力战正人数 = 0;
				势力战邪人数 = 0;
				eve = new EventClass();
				foreach (Players value4 in allConnectedChars.Values)
				{
					if (value4.Player_Job_leve >= 2 && !value4.Client.挂机)
					{
						value4.发送势力战邀请新();
					}
				}
			}
			if (当前是否是银币线路 == 0 && 势力战是否开启 == 1 && DateTime.Now.Hour == 势力战开启小时 && DateTime.Now.Minute == 势力战开启分 && (DateTime.Now.Second == 势力战开启秒 || DateTime.Now.Second == 势力战开启秒 + 1 || DateTime.Now.Second == 势力战开启秒 + 2))
			{
				仙魔战公告 = new 仙魔战循环公告();
				foreach (Players value5 in allConnectedChars.Values)
				{
					if (value5.Player_Job_leve >= 2 && !value5.Client.挂机)
					{
						value5.滚动公告(637);
						value5.发送势力战邀请新();
					}
				}
			}
			if (是否开启对练场赌元宝 == 1 && EVEPVP == null && evePlayers != null && evePlayers.Count >= 2)
			{
				EVEPVP = new EvePVPClass(evePlayers);
			}
			if (DateTime.Now.Hour == 门战系统开启时 && DateTime.Now.Minute == 门战系统开启分 && (DateTime.Now.Second == 门战系统开启秒 || DateTime.Now.Second == 门战系统开启秒 + 1 || DateTime.Now.Second == 门战系统开启秒 + 2) && 帮战 == null)
			{
				是否开启门战系统 = 1;
				胜利帮派ID = 0;
				帮战 = new 帮派战_门战();
			}
			try
			{
				if (BOSSListTime.Count > 1)
				{
					for (int i = 0; i < BOSSListTime.Count; i++)
					{
						if (DateTime.Now.Hour == BOSSListTime[i] && DateTime.Now.Minute == 0 && DateTime.Now.Second == 0)
						{
							随机BOSS系统();
							break;
						}
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "随机BOSS错误  " + ex.Message);
			}
			if (是否开放九泉地图 != 1.0)
			{
				return;
			}
			try
			{
				bool flag = false;
				if (DateTime.Now.Hour == 0 && DateTime.Now.Minute == 0 && DateTime.Now.Second == 0)
				{
					delNpc(王龙地图ID, 15261);
					int int_ = new Random().Next(23002, 24000);
					AddNpc(15261, 0f, 0f, int_);
					王龙地图ID = int_;
					flag = true;
				}
				if (DateTime.Now.Hour == 4 && DateTime.Now.Minute == 0 && DateTime.Now.Second == 0)
				{
					delNpc(王龙地图ID, 15261);
					int int_2 = new Random().Next(23002, 24000);
					AddNpc(15261, 0f, 0f, int_2);
					王龙地图ID = int_2;
					flag = true;
				}
				if (DateTime.Now.Hour == 8 && DateTime.Now.Minute == 0 && DateTime.Now.Second == 0)
				{
					delNpc(王龙地图ID, 15261);
					int int_3 = new Random().Next(23002, 24000);
					AddNpc(15261, 0f, 0f, int_3);
					王龙地图ID = int_3;
					flag = true;
				}
				if (DateTime.Now.Hour == 12 && DateTime.Now.Minute == 0 && DateTime.Now.Second == 0)
				{
					delNpc(王龙地图ID, 15261);
					int int_4 = new Random().Next(23002, 24000);
					AddNpc(15261, 0f, 0f, int_4);
					王龙地图ID = int_4;
					flag = true;
				}
				if (DateTime.Now.Hour == 16 && DateTime.Now.Minute == 0 && DateTime.Now.Second == 0)
				{
					delNpc(王龙地图ID, 15261);
					int int_5 = new Random().Next(23002, 24000);
					AddNpc(15261, 0f, 0f, int_5);
					王龙地图ID = int_5;
					flag = true;
				}
				if (DateTime.Now.Hour == 20 && DateTime.Now.Minute == 0 && DateTime.Now.Second == 0)
				{
					delNpc(王龙地图ID, 15261);
					int int_6 = new Random().Next(23002, 24000);
					AddNpc(15261, 0f, 0f, int_6);
					王龙地图ID = int_6;
					flag = true;
				}
				if (!flag)
				{
					return;
				}
				系统滚动公告("'BOSS王龙'现身九泉某一层,当前九泉累积金币数为" + 王龙的金币 / 10000L + "万");
			}
			catch
			{
				Form1.WriteLine(1, "BOSS王龙错误  ");
			}
			if (修炼之地是否开启 == 1)
			{
				if (DateTime.Now.Hour == 10 && DateTime.Now.Minute == 0)
				{
					if (修炼之地开启ID != 1)
					{
						修炼之地开启ID = 1;
						发送公告("修炼地区开启,进入时间[10:00-10:20],修炼时间为2小时");
					}
				}
				else if (DateTime.Now.Hour == 10 && DateTime.Now.Minute == 20)
				{
					if (修炼之地开启ID != 0)
					{
						修炼之地开启ID = 0;
						foreach (Players value6 in allConnectedChars.Values)
						{
							if (value6.人物坐标_地图 == 30000 || value6.人物坐标_地图 == 30100 || value6.人物坐标_地图 == 30200 || value6.人物坐标_地图 == 30300)
							{
								value6.移动(560f, 1550f, 15f, 101);
							}
						}
					}
				}
				else if (DateTime.Now.Hour == 18 && DateTime.Now.Minute == 0)
				{
					if (修炼之地开启ID != 3)
					{
						修炼之地开启ID = 3;
						发送公告("修炼地区开启,进入时间[18:00-18:20],修炼时间为2小时");
					}
				}
				else if (DateTime.Now.Hour == 18 && DateTime.Now.Minute == 20)
				{
					if (修炼之地开启ID != 0)
					{
						修炼之地开启ID = 0;
						foreach (Players value7 in allConnectedChars.Values)
						{
							if (value7.人物坐标_地图 == 30000 || value7.人物坐标_地图 == 30100 || value7.人物坐标_地图 == 30200 || value7.人物坐标_地图 == 30300)
							{
								value7.移动(560f, 1550f, 15f, 101);
							}
						}
					}
				}
				else if (DateTime.Now.Hour == 22 && DateTime.Now.Minute == 0)
				{
					if (修炼之地开启ID != 4)
					{
						修炼之地开启ID = 4;
						发送公告("修炼地区开启,进入时间[22:00-22:20],修炼时间为2小时");
					}
				}
				else if (DateTime.Now.Hour == 22 && DateTime.Now.Minute == 20 && 修炼之地开启ID != 0)
				{
					修炼之地开启ID = 0;
					foreach (Players value8 in allConnectedChars.Values)
					{
						if (value8.人物坐标_地图 == 30000 || value8.人物坐标_地图 == 30100 || value8.人物坐标_地图 == 30200 || value8.人物坐标_地图 == 30300)
						{
							value8.移动(560f, 1550f, 15f, 101);
						}
					}
				}
			}
			if (挂机双倍时间段.Length <= 0 || Buffer.IsEquals(挂机双倍时间段, "0"))
			{
				return;
			}
			string[] array = 挂机双倍时间段.Split(';');
			if (DateTime.Now.Hour == int.Parse(array[0]) && DateTime.Now.Minute == 0 && !双倍区域BOSS是否开启 && !Buffer.IsEquals(挂机双倍区域BOSS, "0"))
			{
				string[] array2 = 挂机双倍区域BOSS.Split(';');
				if (array2.Length > 1)
				{
					发送公告("指定区域双倍挂机和HAPPY  BOSS时间开始,地点:新手南门码头区域。");
					双倍区域BOSS是否开启 = true;
					string[] array3 = array2;
					for (int j = 0; j < array3.Length; j++)
					{
						AddNpc(int.Parse(array3[j]), RNG.Next(-40, 720), RNG.Next(970, 1360), 101);
					}
				}
			}
			if (DateTime.Now.Hour != int.Parse(array[1]) || DateTime.Now.Minute != 0 || !双倍区域BOSS是否开启 || Buffer.IsEquals(挂机双倍区域BOSS, "0"))
			{
				return;
			}
			string[] array4 = 挂机双倍区域BOSS.Split(';');
			if (array4.Length > 1)
			{
				发送公告("指定区域双倍挂机和HAPPY  BOSS时间结束。");
				双倍区域BOSS是否开启 = false;
				string[] array3 = array4;
				foreach (string s in array3)
				{
					delNpc(101, int.Parse(s));
				}
			}
		}

		public static void 端口更换通知()
		{
			foreach (WGSockClient client in WGServer.clients)
			{
				client.Sendd("更新服务器端口|" + 游戏服务器端口1);
			}
		}

		public static void 端口更换通知(string string_0)
		{
			foreach (WGHandler client in WGServer.clients)
			{
				if (client.ServerId == string_0)
				{
					client.Sendd("更新服务器端口|" + 游戏服务器端口1);
				}
			}
		}

		public World()
		{
			Timer.DelayCall(TimeSpan.FromMilliseconds(1000.0), TimeSpan.FromMilliseconds(1000.0), method_2);
			Timer.DelayCall(TimeSpan.FromMilliseconds(3000.0), TimeSpan.FromMilliseconds(3000.0), method_1);
		}

		public static void 随机BOSS系统()
		{
			try
			{
				string text = string.Empty;
				int num = 0;
				int num2 = 0;
				Dictionary<int, NpcClass> dictionary = new Dictionary<int, NpcClass>();
				int num3 = 1;
				foreach (NpcClass value2 in MapClass.GetnpcTemplate(101).Values)
				{
					if (value2.IsNpc != 1)
					{
						dictionary.Add(num3, value2);
						num3++;
					}
				}
				int key = RNG.Next(1, dictionary.Count - 1);
				NpcClass value;
				if (dictionary.TryGetValue(key, out value))
				{
					int num4 = 0;
					foreach (MonSterClss value3 in MonSter.Values)
					{
						if (value3.FLD_BOSS == 1 && value3.FLD_PID != 15584)
						{
							float float_ = value.Rxjh_X + (float)num4;
							float float_2 = value.Rxjh_Y - (float)num4;
							AddNpc(value3.FLD_PID, float_, float_2, 101);
							num = (int)value.Rxjh_X;
							num2 = (int)value.Rxjh_Y;
							text = value3.Name;
							num4 += 10;
						}
					}
					foreach (Players value4 in allConnectedChars.Values)
					{
						if (!value4.Client.挂机)
						{
							value4.发送传音消息(value4, text.Replace("\r", string.Empty) + "  携带大量宝物出现在泫勃派" + num + "," + num2 + "。", 4);
						}
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "随机BOSS系统加载NPC数据  出错：" + ((ex != null) ? ex.ToString() : null));
			}
		}

		public void SetScript()
		{
			脚本 = new ScriptClass();
		}

		public static void 全局提示(string string_0, int int_0, string string_1)
		{
			foreach (Players value in allConnectedChars.Values)
			{
				if (!value.Client.挂机)
				{
					value.系统提示(string_1, int_0, string_0);
				}
			}
		}

		public void SetConfig()
		{
			string str = "获取配置文件路径";
			try
			{
				Config.Path = Application.StartupPath + "\\config\\config.ini";
				MainServer = ((Config.IniReadValue("GameServer", "主服务器").Trim().Length == 0) ? MainServer : int.Parse(Config.IniReadValue("GameServer", "主服务器").Trim()));
				游戏登陆端口最大连接数 = ((Config.IniReadValue("GameServer", "游戏登陆端口最大连接数").Length == 0) ? 游戏登陆端口最大连接数 : int.Parse(Config.IniReadValue("GameServer", "游戏登陆端口最大连接数")));
				游戏登陆端口最大连接时间数 = ((Config.IniReadValue("GameServer", "游戏登陆端口最大连接时间数").Length == 0) ? 游戏登陆端口最大连接时间数 : int.Parse(Config.IniReadValue("GameServer", "游戏登陆端口最大连接时间数")));
				自动连接时间 = ((Config.IniReadValue("GameServer", "自动连接时间").Length == 0) ? 自动连接时间 : int.Parse(Config.IniReadValue("GameServer", "自动连接时间")));
				封IP = (Config.IniReadValue("GameServer", "封IP").Trim().ToLower() == "true");
				自动开启连接 = (Config.IniReadValue("GameServer", "自动开启连接").Trim().ToLower() == "true");
				允许最大连接数 = ((Config.IniReadValue("GameServer", "允许最大连接数").Length == 0) ? 允许最大连接数 : int.Parse(Config.IniReadValue("GameServer", "允许最大连接数")));
				转发器网关服务端口 = ((Config.IniReadValue("GameServer", "转发器网关服务端口").Trim().Length == 0) ? 转发器网关服务端口 : int.Parse(Config.IniReadValue("GameServer", "转发器网关服务端口").Trim()));
				断开连接 = (Config.IniReadValue("GameServer", "断开连接").Trim().ToLower() == "true");
				加入过滤列表 = (Config.IniReadValue("GameServer", "加入过滤列表").Trim().ToLower() == "true");
				关闭连接 = (Config.IniReadValue("GameServer", "关闭连接").Trim().ToLower() == "true");
				Key = Config.IniReadValue("GameServer", "Key").Trim();
				经验倍数 = ((Config.IniReadValue("GameServer", "经验倍数").Trim().Length == 0) ? 经验倍数 : int.Parse(Config.IniReadValue("GameServer", "经验倍数").Trim()));
				钱倍数 = ((Config.IniReadValue("GameServer", "钱倍数").Trim().Length == 0) ? 钱倍数 : int.Parse(Config.IniReadValue("GameServer", "钱倍数").Trim()));
				吸魂机率 = ((Config.IniReadValue("GameServer", "吸魂几率").Trim().Length == 0) ? 吸魂机率 : int.Parse(Config.IniReadValue("GameServer", "吸魂几率").Trim()));
				历练倍数 = ((Config.IniReadValue("GameServer", "历练倍数").Trim().Length == 0) ? 历练倍数 : int.Parse(Config.IniReadValue("GameServer", "历练倍数").Trim()));
				升天历练倍数 = ((Config.IniReadValue("GameServer", "升天历练倍数").Trim().Length == 0) ? 升天历练倍数 : double.Parse(Config.IniReadValue("GameServer", "升天历练倍数").Trim()));
				暴率 = ((Config.IniReadValue("GameServer", "暴率").Trim().Length == 0) ? 暴率 : int.Parse(Config.IniReadValue("GameServer", "暴率").Trim()));
				最大在线 = ((Config.IniReadValue("GameServer", "最大在线").Trim().Length == 0) ? 最大在线 : int.Parse(Config.IniReadValue("GameServer", "最大在线").Trim()));
				服务器组ID = ((Config.IniReadValue("GameServer", "服务器组ID").Trim().Length == 0) ? 服务器组ID : int.Parse(Config.IniReadValue("GameServer", "服务器组ID").Trim()));
				服务器ID = ((Config.IniReadValue("GameServer", "服务器ID").Trim().Length == 0) ? 服务器ID : int.Parse(Config.IniReadValue("GameServer", "服务器ID").Trim()));
				游戏服务器端口 = ((Config.IniReadValue("GameServer", "游戏服务器端口").Trim().Length == 0) ? 游戏服务器端口 : int.Parse(Config.IniReadValue("GameServer", "游戏服务器端口").Trim()));
				百宝阁服务器端口 = ((Config.IniReadValue("GameServer", "百宝阁服务器端口").Trim().Length == 0) ? 百宝阁服务器端口 : int.Parse(Config.IniReadValue("GameServer", "百宝阁服务器端口").Trim()));
				帐号验证服务器端口 = ((Config.IniReadValue("GameServer", "帐号验证服务器端口").Trim().Length == 0) ? 帐号验证服务器端口 : int.Parse(Config.IniReadValue("GameServer", "帐号验证服务器端口").Trim()));
				帐号验证服务器IP = Config.IniReadValue("GameServer", "帐号验证服务器IP").Trim();
				进入公告 = Config.IniReadValue("GameServer", "进入公告").Trim();
				百宝阁地址 = Config.IniReadValue("GameServer", "百宝阁地址").Trim();
				服务器名 = Config.IniReadValue("GameServer", "服务器名").Trim();
				vip线 = ((Config.IniReadValue("GameServer", "vip线").Trim().Length != 0) ? int.Parse(Config.IniReadValue("GameServer", "vip线").Trim()) : 0);
				势力战是否开启 = int.Parse(Config.IniReadValue("GameServer", "势力战是否开启").Trim());
				势力战开启小时 = int.Parse(Config.IniReadValue("GameServer", "势力战开启小时").Trim());
				势力战开启分 = int.Parse(Config.IniReadValue("GameServer", "势力战开启分").Trim());
				势力战开启秒 = int.Parse(Config.IniReadValue("GameServer", "势力战开启秒").Trim());
				势力战时长 = int.Parse(Config.IniReadValue("GameServer", "势力战时长").Trim());
				势力战预备时间 = int.Parse(Config.IniReadValue("GameServer", "势力战预备时间").Trim());
				AutGC = ((Config.IniReadValue("GameServer", "AutGC").Trim().Length == 0) ? AutGC : int.Parse(Config.IniReadValue("GameServer", "AutGC").Trim()));
				封包封号 = ((Config.IniReadValue("GameServer", "封包封号").Trim().Length != 0) ? int.Parse(Config.IniReadValue("GameServer", "封包封号").Trim()) : 0);
				Script = ((Config.IniReadValue("GameServer", "Script").Trim().Length == 0) ? Script : int.Parse(Config.IniReadValue("GameServer", "Script").Trim()));
				狮子吼最大数 = ((Config.IniReadValue("GameServer", "狮子吼最大数").Length == 0) ? 50 : int.Parse(Config.IniReadValue("GameServer", "狮子吼最大数")));
				合成率 = ((Config.IniReadValue("GameServer", "合成率").Length == 0) ? 合成率 : double.Parse(Config.IniReadValue("GameServer", "合成率")));
				强化率 = ((Config.IniReadValue("GameServer", "强化率").Length == 0) ? 强化率 : double.Parse(Config.IniReadValue("GameServer", "强化率")));
				赋予属性率 = ((Config.IniReadValue("GameServer", "赋予属性率").Length == 0) ? 赋予属性率 : double.Parse(Config.IniReadValue("GameServer", "赋予属性率")));
				附魂率 = ((Config.IniReadValue("GameServer", "附魂率").Length == 0) ? 附魂率 : double.Parse(Config.IniReadValue("GameServer", "附魂率")));
				首饰加工率 = ((Config.IniReadValue("GameServer", "首饰加工率").Length == 0) ? 首饰加工率 : double.Parse(Config.IniReadValue("GameServer", "首饰加工率")));
				披风强化率 = ((Config.IniReadValue("GameServer", "披风强化率").Length == 0) ? 披风强化率 : double.Parse(Config.IniReadValue("GameServer", "披风强化率")));
				装备升级率 = ((Config.IniReadValue("GameServer", "装备升级率").Length == 0) ? 装备升级率 : double.Parse(Config.IniReadValue("GameServer", "装备升级率")));
				首饰升级率 = ((Config.IniReadValue("GameServer", "首饰升级率").Length == 0) ? 首饰升级率 : double.Parse(Config.IniReadValue("GameServer", "首饰升级率")));
				元宝合成 = ((Config.IniReadValue("GameServer", "元宝合成").Trim().Length == 0) ? 元宝合成 : int.Parse(Config.IniReadValue("GameServer", "元宝合成").Trim()));
				是否加密 = ((Config.IniReadValue("GameServer", "是否加密").Trim().Length == 0) ? 是否加密 : int.Parse(Config.IniReadValue("GameServer", "是否加密").Trim()));
				加密密钥 = Config.IniReadValue("GameServer", "加密密钥").Trim();
				版本验证时间 = ((Config.IniReadValue("GameServer", "版本验证时间").Trim().Length == 0) ? 版本验证时间 : int.Parse(Config.IniReadValue("GameServer", "版本验证时间").Trim()));
				Vip上线公告 = ((Config.IniReadValue("GameServer", "Vip上线公告").Trim().Length == 0) ? Vip上线公告 : int.Parse(Config.IniReadValue("GameServer", "Vip上线公告").Trim()));
				Vip上线公告内容 = ((Config.IniReadValue("GameServer", "Vip上线公告内容").Trim().Length == 0) ? Vip上线公告内容 : Config.IniReadValue("GameServer", "Vip上线公告内容").Trim());
				VIP地图 = Config.IniReadValue("GameServer", "VIP地图").Trim();
				普通上线公告 = ((Config.IniReadValue("GameServer", "普通上线公告").Trim().Length == 0) ? 普通上线公告 : int.Parse(Config.IniReadValue("GameServer", "普通上线公告").Trim()));
				普通上线公告内容 = ((Config.IniReadValue("GameServer", "普通上线公告内容").Trim().Length == 0) ? 普通上线公告内容 : Config.IniReadValue("GameServer", "普通上线公告内容").Trim());
				查非法物品 = ((Config.IniReadValue("GameServer", "查非法物品").Trim().Length == 0) ? 查非法物品 : int.Parse(Config.IniReadValue("GameServer", "查非法物品").Trim()));
				查绑定非法物品 = ((Config.IniReadValue("GameServer", "查绑定非法物品").Trim().Length == 0) ? 查绑定非法物品 : (Config.IniReadValue("GameServer", "查绑定非法物品").Trim() == "1"));
				查非法物品操作 = ((Config.IniReadValue("GameServer", "查非法物品操作").Trim().Length == 0) ? 查非法物品操作 : int.Parse(Config.IniReadValue("GameServer", "查非法物品操作").Trim()));
				物品最高攻击值 = ((Config.IniReadValue("GameServer", "物品最高攻击值").Trim().Length == 0) ? 物品最高攻击值 : int.Parse(Config.IniReadValue("GameServer", "物品最高攻击值").Trim()));
				物品最高防御值 = ((Config.IniReadValue("GameServer", "物品最高防御值").Trim().Length == 0) ? 物品最高防御值 : int.Parse(Config.IniReadValue("GameServer", "物品最高防御值").Trim()));
				物品最高生命值 = ((Config.IniReadValue("GameServer", "物品最高生命值").Trim().Length == 0) ? 物品最高生命值 : int.Parse(Config.IniReadValue("GameServer", "物品最高生命值").Trim()));
				物品最高内功值 = ((Config.IniReadValue("GameServer", "物品最高内功值").Trim().Length == 0) ? 物品最高内功值 : int.Parse(Config.IniReadValue("GameServer", "物品最高内功值").Trim()));
				物品最高命中值 = ((Config.IniReadValue("GameServer", "物品最高命中值").Trim().Length == 0) ? 物品最高命中值 : int.Parse(Config.IniReadValue("GameServer", "物品最高命中值").Trim()));
				物品最高回避值 = ((Config.IniReadValue("GameServer", "物品最高回避值").Trim().Length == 0) ? 物品最高回避值 : int.Parse(Config.IniReadValue("GameServer", "物品最高回避值").Trim()));
				物品最高武功值 = ((Config.IniReadValue("GameServer", "物品最高武功值").Trim().Length == 0) ? 物品最高武功值 : int.Parse(Config.IniReadValue("GameServer", "物品最高武功值").Trim()));
				物品最高气功值 = ((Config.IniReadValue("GameServer", "物品最高气功值").Trim().Length == 0) ? 物品最高气功值 : int.Parse(Config.IniReadValue("GameServer", "物品最高气功值").Trim()));
				物品最高合成值 = ((Config.IniReadValue("GameServer", "物品最高合成值").Trim().Length == 0) ? 物品最高合成值 : int.Parse(Config.IniReadValue("GameServer", "物品最高合成值").Trim()));
				物品最高附魂值 = ((Config.IniReadValue("GameServer", "物品最高附魂值").Trim().Length == 0) ? 物品最高附魂值 : int.Parse(Config.IniReadValue("GameServer", "物品最高附魂值").Trim()));
				物品最高武防值 = ((Config.IniReadValue("GameServer", "物品最高武防值").Trim().Length == 0) ? 物品最高武防值 : int.Parse(Config.IniReadValue("GameServer", "物品最高武防值").Trim()));
				势力战奖励类型 = ((Config.IniReadValue("GameServer", "势力战奖励类型").Trim().Length == 0) ? 势力战奖励类型 : int.Parse(Config.IniReadValue("GameServer", "势力战奖励类型").Trim()));
				势力战奖励数量 = ((Config.IniReadValue("GameServer", "势力战奖励数量").Trim().Length == 0) ? 势力战奖励数量 : int.Parse(Config.IniReadValue("GameServer", "势力战奖励数量").Trim()));
				势力战奖励属性 = Config.IniReadValue("GameServer", "势力战奖励属性").Trim();
				势力战奖励套装 = ((Config.IniReadValue("GameServer", "势力战奖励套装").Trim().Length != 0) ? int.Parse(Config.IniReadValue("GameServer", "势力战奖励套装").Trim()) : 0);
				势力战奖励物品 = Config.IniReadValue("GameServer", "势力战奖励物品").Trim();
				势力战随机奖励盒子ID = ((Config.IniReadValue("GameServer", "势力战随机奖励盒子ID").Trim().Length != 0) ? int.Parse(Config.IniReadValue("GameServer", "势力战随机奖励盒子ID").Trim()) : 0);
				SqlJl = ((Config.IniReadValue("GameServer", "SqlJl").Trim().Length == 0) ? SqlJl : Config.IniReadValue("GameServer", "SqlJl").Trim());
				自动存档 = ((Config.IniReadValue("GameServer", "自动存档").Trim().Length == 0) ? 自动存档 : int.Parse(Config.IniReadValue("GameServer", "自动存档").Trim()));
				物品记录 = ((Config.IniReadValue("GameServer", "物品记录").Trim().Length == 0) ? 物品记录 : int.Parse(Config.IniReadValue("GameServer", "物品记录").Trim()));
				登陆记录 = ((Config.IniReadValue("GameServer", "登陆记录").Trim().Length == 0) ? 登陆记录 : int.Parse(Config.IniReadValue("GameServer", "登陆记录").Trim()));
				掉落记录 = ((Config.IniReadValue("GameServer", "掉落记录").Trim().Length == 0) ? 掉落记录 : int.Parse(Config.IniReadValue("GameServer", "掉落记录").Trim()));
				药品记录 = ((Config.IniReadValue("GameServer", "药品记录").Trim().Length == 0) ? 药品记录 : int.Parse(Config.IniReadValue("GameServer", "药品记录").Trim()));
				合成记录 = ((Config.IniReadValue("GameServer", "合成记录").Trim().Length == 0) ? 合成记录 : int.Parse(Config.IniReadValue("GameServer", "合成记录").Trim()));
				商店记录 = ((Config.IniReadValue("GameServer", "商店记录").Trim().Length == 0) ? 商店记录 : int.Parse(Config.IniReadValue("GameServer", "商店记录").Trim()));
				记录保存天数 = ((Config.IniReadValue("GameServer", "记录保存天数").Trim().Length == 0) ? 记录保存天数 : int.Parse(Config.IniReadValue("GameServer", "记录保存天数").Trim()));
				元宝检测 = ((Config.IniReadValue("GameServer", "元宝检测").Trim().Length == 0) ? 元宝检测 : int.Parse(Config.IniReadValue("GameServer", "元宝检测").Trim()));
				外挂打怪时间 = ((Config.IniReadValue("GameServer", "外挂打怪时间").Trim().Length == 0) ? 外挂打怪时间 : int.Parse(Config.IniReadValue("GameServer", "外挂打怪时间").Trim()));
				外挂PK时间 = ((Config.IniReadValue("GameServer", "外挂PK时间").Trim().Length == 0) ? 外挂PK时间 : int.Parse(Config.IniReadValue("GameServer", "外挂PK时间").Trim()));
				升天技能等级加成 = ((Config.IniReadValue("GameServer", "升天技能等级加成").Trim().Length == 0) ? 1 : int.Parse(Config.IniReadValue("GameServer", "升天技能等级加成").Trim()));
				组队级别限制 = ((Config.IniReadValue("GameServer", "组队级别限制").Trim().Length != 0) ? int.Parse(Config.IniReadValue("GameServer", "组队级别限制").Trim()) : 0);
				是否开启新手上线设置 = ((Config.IniReadValue("GameServer", "是否开启新手上线设置").Trim().Length != 0) ? int.Parse(Config.IniReadValue("GameServer", "是否开启新手上线设置").Trim()) : 0);
				上线等级 = ((Config.IniReadValue("GameServer", "上线等级").Trim().Length != 0) ? int.Parse(Config.IniReadValue("GameServer", "上线等级").Trim()) : 0);
				上线送礼包套装 = ((Config.IniReadValue("GameServer", "上线送礼包套装").Trim().Length != 0) ? int.Parse(Config.IniReadValue("GameServer", "上线送礼包套装").Trim()) : 0);
				是否开启银票兑换元宝 = ((Config.IniReadValue("GameServer", "是否开启银票兑换元宝").Trim().Length != 0) ? int.Parse(Config.IniReadValue("GameServer", "是否开启银票兑换元宝").Trim()) : 0);
				银票兑换元宝 = ((Config.IniReadValue("GameServer", "银票兑换元宝").Trim().Length != 0) ? int.Parse(Config.IniReadValue("GameServer", "银票兑换元宝").Trim()) : 0);
				是否开启挂机奖励 = ((Config.IniReadValue("GameServer", "是否开启挂机奖励").Trim().Length != 0) ? int.Parse(Config.IniReadValue("GameServer", "是否开启挂机奖励").Trim()) : 0);
				挂机奖励时间周期 = ((Config.IniReadValue("GameServer", "挂机奖励时间周期").Trim().Length != 0) ? int.Parse(Config.IniReadValue("GameServer", "挂机奖励时间周期").Trim()) : 0);
				挂机奖励要求等级 = ((Config.IniReadValue("GameServer", "挂机奖励要求等级").Trim().Length != 0) ? int.Parse(Config.IniReadValue("GameServer", "挂机奖励要求等级").Trim()) : 0);
				挂机奖励元宝 = ((Config.IniReadValue("GameServer", "挂机奖励元宝").Trim().Length != 0) ? int.Parse(Config.IniReadValue("GameServer", "挂机奖励元宝").Trim()) : 0);
				挂机奖励金钱 = ((Config.IniReadValue("GameServer", "挂机奖励金钱").Trim().Length != 0) ? int.Parse(Config.IniReadValue("GameServer", "挂机奖励金钱").Trim()) : 0);
				挂机奖励武勋 = ((Config.IniReadValue("GameServer", "挂机奖励武勋").Trim().Length != 0) ? int.Parse(Config.IniReadValue("GameServer", "挂机奖励武勋").Trim()) : 0);
				挂机奖励武勋 = ((Config.IniReadValue("GameServer", "挂机奖励武勋").Trim().Length != 0) ? int.Parse(Config.IniReadValue("GameServer", "挂机奖励武勋").Trim()) : 0);
				挂机消除善恶 = ((Config.IniReadValue("GameServer", "挂机消除善恶").Trim().Length != 0) ? int.Parse(Config.IniReadValue("GameServer", "挂机消除善恶").Trim()) : 0);
				挂机双倍时间段 = Config.IniReadValue("GameServer", "挂机双倍时间段").Trim();
				挂机双倍区域BOSS = Config.IniReadValue("GameServer", "挂机双倍区域BOSS").Trim();
				挂机消除宠物忠诚度 = ((Config.IniReadValue("GameServer", "挂机消除宠物忠诚度").Trim().Length != 0) ? int.Parse(Config.IniReadValue("GameServer", "挂机消除宠物忠诚度").Trim()) : 0);
				获得经验等级差 = ((Config.IniReadValue("GameServer", "获得经验等级差").Trim().Length == 0) ? 15 : int.Parse(Config.IniReadValue("GameServer", "获得经验等级差").Trim()));
				是否开启装备加解锁功能 = ((Config.IniReadValue("GameServer", "是否开启装备加解锁功能").Trim().Length != 0) ? int.Parse(Config.IniReadValue("GameServer", "是否开启装备加解锁功能").Trim()) : 0);
				装备加锁消耗元宝 = ((Config.IniReadValue("GameServer", "装备加锁消耗元宝").Trim().Length != 0) ? int.Parse(Config.IniReadValue("GameServer", "装备加锁消耗元宝").Trim()) : 0);
				装备解锁消耗元宝 = ((Config.IniReadValue("GameServer", "装备解锁消耗元宝").Trim().Length != 0) ? int.Parse(Config.IniReadValue("GameServer", "装备解锁消耗元宝").Trim()) : 0);
				单次交易元宝数量上限 = ((Config.IniReadValue("GameServer", "单次交易元宝数量上限").Trim().Length == 0) ? 单次交易元宝数量上限 : int.Parse(Config.IniReadValue("GameServer", "单次交易元宝数量上限").Trim()));
				帐号总元宝上限 = ((Config.IniReadValue("GameServer", "帐号总元宝上限").Trim().Length == 0) ? 帐号总元宝上限 : int.Parse(Config.IniReadValue("GameServer", "帐号总元宝上限").Trim()));
				元宝检测操作 = ((Config.IniReadValue("GameServer", "元宝检测操作").Trim().Length == 0) ? 元宝检测操作 : int.Parse(Config.IniReadValue("GameServer", "元宝检测操作").Trim()));
				是否开启武勋系统 = ((Config.IniReadValue("GameServer", "是否开启武勋系统").Trim().Length == 0) ? 是否开启武勋系统 : int.Parse(Config.IniReadValue("GameServer", "是否开启武勋系统").Trim()));
				PK等级差 = ((Config.IniReadValue("GameServer", "PK等级差").Trim().Length == 0) ? PK等级差 : int.Parse(Config.IniReadValue("GameServer", "PK等级差").Trim()));
				武勋保护等级 = ((Config.IniReadValue("GameServer", "武勋保护等级").Trim().Length != 0) ? int.Parse(Config.IniReadValue("GameServer", "武勋保护等级").Trim()) : 0);
				死亡减少武勋数量 = Config.IniReadValue("GameServer", "死亡减少武勋数量").Trim();
				系统回收数量 = Config.IniReadValue("GameServer", "系统回收数量").Trim();
				再造金刚石攻击 = Config.IniReadValue("GameServer", "再造金刚石攻击").Trim();
				再造金刚石追伤 = Config.IniReadValue("GameServer", "再造金刚石追伤").Trim();
				再造金刚石武功 = Config.IniReadValue("GameServer", "再造金刚石武功").Trim();
				再造金刚石命中 = Config.IniReadValue("GameServer", "再造金刚石命中").Trim();
				再造金刚石生命 = Config.IniReadValue("GameServer", "再造金刚石生命").Trim();
				再造寒玉石防御 = Config.IniReadValue("GameServer", "再造寒玉石防御").Trim();
				再造寒玉石回避 = Config.IniReadValue("GameServer", "再造寒玉石回避").Trim();
				再造寒玉石生命 = Config.IniReadValue("GameServer", "再造寒玉石生命").Trim();
				再造寒玉石内功 = Config.IniReadValue("GameServer", "再造寒玉石内功").Trim();
				再造寒玉石武防 = Config.IniReadValue("GameServer", "再造寒玉石武防").Trim();
				强化一合成率 = ((Config.IniReadValue("GameServer", "强化一合成率") == "") ? 强化一合成率 : double.Parse(Config.IniReadValue("GameServer", "强化一合成率")));
				强化二合成率 = ((Config.IniReadValue("GameServer", "强化二合成率") == "") ? 强化二合成率 : double.Parse(Config.IniReadValue("GameServer", "强化二合成率")));
				强化三合成率 = ((Config.IniReadValue("GameServer", "强化三合成率") == "") ? 强化三合成率 : double.Parse(Config.IniReadValue("GameServer", "强化三合成率")));
				强化四合成率 = ((Config.IniReadValue("GameServer", "强化四合成率") == "") ? 强化四合成率 : double.Parse(Config.IniReadValue("GameServer", "强化四合成率")));
				强化五合成率 = ((Config.IniReadValue("GameServer", "强化五合成率") == "") ? 强化五合成率 : double.Parse(Config.IniReadValue("GameServer", "强化五合成率")));
				强化六合成率 = ((Config.IniReadValue("GameServer", "强化六合成率") == "") ? 强化六合成率 : double.Parse(Config.IniReadValue("GameServer", "强化六合成率")));
				强化七合成率 = ((Config.IniReadValue("GameServer", "强化七合成率") == "") ? 强化七合成率 : double.Parse(Config.IniReadValue("GameServer", "强化七合成率")));
				强化八合成率 = ((Config.IniReadValue("GameServer", "强化八合成率") == "") ? 强化八合成率 : double.Parse(Config.IniReadValue("GameServer", "强化八合成率")));
				强化九合成率 = ((Config.IniReadValue("GameServer", "强化九合成率") == "") ? 强化九合成率 : double.Parse(Config.IniReadValue("GameServer", "强化九合成率")));
				强化十合成率 = ((Config.IniReadValue("GameServer", "强化十合成率") == "") ? 强化十合成率 : double.Parse(Config.IniReadValue("GameServer", "强化十合成率")));
				强化十一合成率 = ((Config.IniReadValue("GameServer", "强化十一合成率") == "") ? 强化十一合成率 : double.Parse(Config.IniReadValue("GameServer", "强化十一合成率")));
				强化十二合成率 = ((Config.IniReadValue("GameServer", "强化十二合成率") == "") ? 强化十二合成率 : double.Parse(Config.IniReadValue("GameServer", "强化十二合成率")));
				强化十三合成率 = ((Config.IniReadValue("GameServer", "强化十三合成率") == "") ? 强化十三合成率 : double.Parse(Config.IniReadValue("GameServer", "强化十三合成率")));
				强化十四合成率 = ((Config.IniReadValue("GameServer", "强化十四合成率") == "") ? 强化十四合成率 : double.Parse(Config.IniReadValue("GameServer", "强化十四合成率")));
				强化十五合成率 = ((Config.IniReadValue("GameServer", "强化十五合成率") == "") ? 强化十五合成率 : double.Parse(Config.IniReadValue("GameServer", "强化十五合成率")));
				至尊强化率 = ((Config.IniReadValue("GameServer", "至尊强化率").Length == 0) ? 至尊强化率 : double.Parse(Config.IniReadValue("GameServer", "至尊强化率")));
				至尊取玉强11 = ((Config.IniReadValue("GameServer", "至尊取玉强11") == "") ? 至尊取玉强11 : double.Parse(Config.IniReadValue("GameServer", "至尊取玉强11")));
				至尊取玉强12 = ((Config.IniReadValue("GameServer", "至尊取玉强12") == "") ? 至尊取玉强12 : double.Parse(Config.IniReadValue("GameServer", "至尊取玉强12")));
				至尊取玉强13 = ((Config.IniReadValue("GameServer", "至尊取玉强13") == "") ? 至尊取玉强13 : double.Parse(Config.IniReadValue("GameServer", "至尊取玉强13")));
				至尊取玉强14 = ((Config.IniReadValue("GameServer", "至尊取玉强14") == "") ? 至尊取玉强14 : double.Parse(Config.IniReadValue("GameServer", "至尊取玉强14")));
				至尊取玉强15 = ((Config.IniReadValue("GameServer", "至尊取玉强15") == "") ? 至尊取玉强15 : double.Parse(Config.IniReadValue("GameServer", "至尊取玉强15")));
				至高无上称号奖励 = Config.IniReadValue("GameServer", "至高无上称号奖励").Trim().Split(';');
				举世无双称号奖励 = Config.IniReadValue("GameServer", "举世无双称号奖励").Trim().Split(';');
				雄霸天下称号奖励 = Config.IniReadValue("GameServer", "雄霸天下称号奖励").Trim().Split(';');
				孤胆英雄称号奖励 = Config.IniReadValue("GameServer", "孤胆英雄称号奖励").Trim().Split(';');
				英雄豪杰称号奖励 = Config.IniReadValue("GameServer", "英雄豪杰称号奖励").Trim().Split(';');
				武器8阶段添加攻击 = ((!(Config.IniReadValue("GameServer", "武器8阶段添加攻击").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "武器8阶段添加攻击").Trim()) : 0);
				武器9阶段添加攻击 = ((!(Config.IniReadValue("GameServer", "武器9阶段添加攻击").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "武器9阶段添加攻击").Trim()) : 0);
				武器10阶段添加攻击 = ((!(Config.IniReadValue("GameServer", "武器10阶段添加攻击").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "武器10阶段添加攻击").Trim()) : 0);
				武器11阶段添加攻击 = ((!(Config.IniReadValue("GameServer", "武器11阶段添加攻击").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "武器11阶段添加攻击").Trim()) : 0);
				武器12阶段添加攻击 = ((!(Config.IniReadValue("GameServer", "武器12阶段添加攻击").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "武器12阶段添加攻击").Trim()) : 0);
				武器13阶段添加攻击 = ((!(Config.IniReadValue("GameServer", "武器13阶段添加攻击").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "武器13阶段添加攻击").Trim()) : 0);
				武器14阶段添加攻击 = ((!(Config.IniReadValue("GameServer", "武器14阶段添加攻击").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "武器14阶段添加攻击").Trim()) : 0);
				武器15阶段添加攻击 = ((!(Config.IniReadValue("GameServer", "武器15阶段添加攻击").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "武器15阶段添加攻击").Trim()) : 0);
				衣服8阶段添加防御 = ((!(Config.IniReadValue("GameServer", "衣服8阶段添加防御").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "衣服8阶段添加防御").Trim()) : 0);
				衣服9阶段添加防御 = ((!(Config.IniReadValue("GameServer", "衣服9阶段添加防御").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "衣服9阶段添加防御").Trim()) : 0);
				衣服10阶段添加防御 = ((!(Config.IniReadValue("GameServer", "衣服10阶段添加防御").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "衣服10阶段添加防御").Trim()) : 0);
				衣服11阶段添加防御 = ((!(Config.IniReadValue("GameServer", "衣服11阶段添加防御").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "衣服11阶段添加防御").Trim()) : 0);
				衣服12阶段添加防御 = ((!(Config.IniReadValue("GameServer", "衣服12阶段添加防御").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "衣服12阶段添加防御").Trim()) : 0);
				衣服13阶段添加防御 = ((!(Config.IniReadValue("GameServer", "衣服13阶段添加防御").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "衣服13阶段添加防御").Trim()) : 0);
				衣服14阶段添加防御 = ((!(Config.IniReadValue("GameServer", "衣服14阶段添加防御").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "衣服14阶段添加防御").Trim()) : 0);
				衣服15阶段添加防御 = ((!(Config.IniReadValue("GameServer", "衣服15阶段添加防御").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "衣服15阶段添加防御").Trim()) : 0);
				鞋子8阶段添加防御 = ((!(Config.IniReadValue("GameServer", "鞋子8阶段添加防御").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "鞋子8阶段添加防御").Trim()) : 0);
				鞋子9阶段添加防御 = ((!(Config.IniReadValue("GameServer", "鞋子9阶段添加防御").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "鞋子9阶段添加防御").Trim()) : 0);
				鞋子10阶段添加防御 = ((!(Config.IniReadValue("GameServer", "鞋子10阶段添加防御").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "鞋子10阶段添加防御").Trim()) : 0);
				鞋子11阶段添加防御 = ((!(Config.IniReadValue("GameServer", "鞋子11阶段添加防御").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "鞋子11阶段添加防御").Trim()) : 0);
				鞋子12阶段添加防御 = ((!(Config.IniReadValue("GameServer", "鞋子12阶段添加防御").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "鞋子12阶段添加防御").Trim()) : 0);
				鞋子13阶段添加防御 = ((!(Config.IniReadValue("GameServer", "鞋子13阶段添加防御").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "鞋子13阶段添加防御").Trim()) : 0);
				鞋子14阶段添加防御 = ((!(Config.IniReadValue("GameServer", "鞋子14阶段添加防御").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "鞋子14阶段添加防御").Trim()) : 0);
				鞋子15阶段添加防御 = ((!(Config.IniReadValue("GameServer", "鞋子15阶段添加防御").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "鞋子15阶段添加防御").Trim()) : 0);
				护手8阶段添加防御 = ((!(Config.IniReadValue("GameServer", "护手8阶段添加防御").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "护手8阶段添加防御").Trim()) : 0);
				护手9阶段添加防御 = ((!(Config.IniReadValue("GameServer", "护手9阶段添加防御").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "护手9阶段添加防御").Trim()) : 0);
				护手10阶段添加防御 = ((!(Config.IniReadValue("GameServer", "护手10阶段添加防御").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "护手10阶段添加防御").Trim()) : 0);
				护手11阶段添加防御 = ((!(Config.IniReadValue("GameServer", "护手11阶段添加防御").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "护手11阶段添加防御").Trim()) : 0);
				护手12阶段添加防御 = ((!(Config.IniReadValue("GameServer", "护手12阶段添加防御").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "护手12阶段添加防御").Trim()) : 0);
				护手13阶段添加防御 = ((!(Config.IniReadValue("GameServer", "护手13阶段添加防御").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "护手13阶段添加防御").Trim()) : 0);
				护手14阶段添加防御 = ((!(Config.IniReadValue("GameServer", "护手14阶段添加防御").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "护手14阶段添加防御").Trim()) : 0);
				护手15阶段添加防御 = ((!(Config.IniReadValue("GameServer", "护手15阶段添加防御").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "护手15阶段添加防御").Trim()) : 0);
				内甲8阶段添加防御 = ((!(Config.IniReadValue("GameServer", "内甲8阶段添加防御").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "内甲8阶段添加防御").Trim()) : 0);
				内甲9阶段添加防御 = ((!(Config.IniReadValue("GameServer", "内甲9阶段添加防御").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "内甲9阶段添加防御").Trim()) : 0);
				内甲10阶段添加防御 = ((!(Config.IniReadValue("GameServer", "内甲10阶段添加防御").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "内甲10阶段添加防御").Trim()) : 0);
				内甲11阶段添加防御 = ((!(Config.IniReadValue("GameServer", "内甲11阶段添加防御").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "内甲11阶段添加防御").Trim()) : 0);
				内甲12阶段添加防御 = ((!(Config.IniReadValue("GameServer", "内甲12阶段添加防御").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "内甲12阶段添加防御").Trim()) : 0);
				内甲13阶段添加防御 = ((!(Config.IniReadValue("GameServer", "内甲13阶段添加防御").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "内甲13阶段添加防御").Trim()) : 0);
				内甲14阶段添加防御 = ((!(Config.IniReadValue("GameServer", "内甲14阶段添加防御").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "内甲14阶段添加防御").Trim()) : 0);
				内甲15阶段添加防御 = ((!(Config.IniReadValue("GameServer", "内甲15阶段添加防御").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "内甲15阶段添加防御").Trim()) : 0);
				武器附魂增加属性数量 = int.Parse(Config.IniReadValue("GameServer", "武器附魂增加属性数量").Trim());
				衣服附魂增加属性数量 = int.Parse(Config.IniReadValue("GameServer", "衣服附魂增加属性数量").Trim());
				耳环加工一阶段增加生命 = int.Parse(Config.IniReadValue("GameServer", "耳环加工一阶段增加生命").Trim());
				项链加工一阶段增加防御 = int.Parse(Config.IniReadValue("GameServer", "项链加工一阶段增加防御").Trim());
				戒指加工一阶段增加攻击 = int.Parse(Config.IniReadValue("GameServer", "戒指加工一阶段增加攻击").Trim());
				灵宠强化总概率 = Config.IniReadValue("GameServer", "灵宠强化总概率").Trim();
				灵宠强化一阶段概率 = ((Config.IniReadValue("GameServer", "灵宠强化一阶段概率") == "") ? 灵宠强化一阶段概率 : double.Parse(Config.IniReadValue("GameServer", "灵宠强化一阶段概率")));
				灵宠强化二阶段概率 = ((Config.IniReadValue("GameServer", "灵宠强化二阶段概率") == "") ? 灵宠强化二阶段概率 : double.Parse(Config.IniReadValue("GameServer", "灵宠强化二阶段概率")));
				灵宠强化三阶段概率 = ((Config.IniReadValue("GameServer", "灵宠强化三阶段概率") == "") ? 灵宠强化三阶段概率 : double.Parse(Config.IniReadValue("GameServer", "灵宠强化三阶段概率")));
				灵宠强化四阶段概率 = ((Config.IniReadValue("GameServer", "灵宠强化四阶段概率") == "") ? 灵宠强化四阶段概率 : double.Parse(Config.IniReadValue("GameServer", "灵宠强化四阶段概率")));
				灵宠强化五阶段概率 = ((Config.IniReadValue("GameServer", "灵宠强化五阶段概率") == "") ? 灵宠强化一阶段概率 : double.Parse(Config.IniReadValue("GameServer", "灵宠强化五阶段概率")));
				灵宠强化六阶段概率 = ((Config.IniReadValue("GameServer", "灵宠强化六阶段概率") == "") ? 灵宠强化一阶段概率 : double.Parse(Config.IniReadValue("GameServer", "灵宠强化六阶段概率")));
				灵宠强化七阶段概率 = ((Config.IniReadValue("GameServer", "灵宠强化一阶段概率") == "") ? 灵宠强化七阶段概率 : double.Parse(Config.IniReadValue("GameServer", "灵宠强化七阶段概率")));
				每次再造消耗设置 = ((Config.IniReadValue("GameServer", "每次再造消耗设置").Trim().Length != 0) ? int.Parse(Config.IniReadValue("GameServer", "每次再造消耗设置").Trim()) : 0);
				每次消耗的数量 = ((Config.IniReadValue("GameServer", "每次消耗的数量").Trim().Length != 0) ? int.Parse(Config.IniReadValue("GameServer", "每次消耗的数量").Trim()) : 0);
				double num = (Config.IniReadValue("GameServer", "武功防降低百分比").Trim().Length == 0) ? 武功防降低百分比 : double.Parse(Config.IniReadValue("GameServer", "武功防降低百分比").Trim());
				武功攻击力百分比 = ((Config.IniReadValue("GameServer", "武功攻击力百分比").Trim().Length == 0) ? 武功攻击力百分比 : double.Parse(Config.IniReadValue("GameServer", "武功攻击力百分比").Trim()));
				攻减防加乘 = ((Config.IniReadValue("GameServer", "攻减防加乘").Trim().Length == 0) ? 攻减防加乘 : double.Parse(Config.IniReadValue("GameServer", "攻减防加乘").Trim()));
				武功减武防加乘 = ((Config.IniReadValue("GameServer", "武功减武防加乘").Trim().Length == 0) ? 武功减武防加乘 : double.Parse(Config.IniReadValue("GameServer", "武功减武防加乘").Trim()));
				if (武功防降低百分比 != num)
				{
					武功防降低百分比 = num;
					foreach (Players value in allConnectedChars.Values)
					{
						value.计算人物装备数据();
					}
				}
				心跳检测开关 = ((Config.IniReadValue("GameServer", "心跳检测开关").Trim().Length != 0) ? int.Parse(Config.IniReadValue("GameServer", "心跳检测开关").Trim()) : 0);
				心跳检测操作 = ((Config.IniReadValue("GameServer", "心跳检测操作").Trim().Length != 0) ? int.Parse(Config.IniReadValue("GameServer", "心跳检测操作").Trim()) : 0);
				心跳检测时间阀值 = ((Config.IniReadValue("GameServer", "心跳检测时间阀值").Trim().Length != 0) ? int.Parse(Config.IniReadValue("GameServer", "心跳检测时间阀值").Trim()) : 0);
				心跳检测时长 = ((Config.IniReadValue("GameServer", "心跳检测时长").Trim().Length != 0) ? int.Parse(Config.IniReadValue("GameServer", "心跳检测时长").Trim()) : 0);
				安全模式消耗元宝 = ((Config.IniReadValue("GameServer", "安全模式消耗元宝").Trim().Length != 0) ? int.Parse(Config.IniReadValue("GameServer", "安全模式消耗元宝").Trim()) : 0);
				每次狮吼功消耗元宝 = ((Config.IniReadValue("GameServer", "每次狮吼功消耗元宝").Trim().Length == 0) ? 每次狮吼功消耗元宝 : int.Parse(Config.IniReadValue("GameServer", "每次狮吼功消耗元宝").Trim()));
				允许多开数量 = ((Config.IniReadValue("GameServer", "允许多开数量").Trim().Length == 0) ? 允许多开数量 : int.Parse(Config.IniReadValue("GameServer", "允许多开数量").Trim()));
				每次分解消耗元宝数 = ((Config.IniReadValue("GameServer", "每次分解消耗元宝数").Trim().Length == 0) ? 每次分解消耗元宝数 : int.Parse(Config.IniReadValue("GameServer", "每次分解消耗元宝数").Trim()));
				str = "是否开启对练场赌元宝";
				是否开启对练场赌元宝 = ((Config.IniReadValue("GameServer", "是否开启对练场赌元宝").Trim().Length == 0) ? 是否开启对练场赌元宝 : int.Parse(Config.IniReadValue("GameServer", "是否开启对练场赌元宝").Trim()));
				str = "进场最低费用";
				进场最低费用 = ((Config.IniReadValue("GameServer", "进场最低费用").Trim().Length == 0) ? 进场最低费用 : int.Parse(Config.IniReadValue("GameServer", "进场最低费用").Trim()));
				str = "场地佣金百分比";
				场地佣金百分比 = ((Config.IniReadValue("GameServer", "场地佣金百分比").Trim().Length == 0) ? 场地佣金百分比 : double.Parse(Config.IniReadValue("GameServer", "场地佣金百分比").Trim()));
				str = "场地有效范围";
				场地有效范围 = ((Config.IniReadValue("GameServer", "场地有效范围").Trim().Length == 0) ? 场地有效范围 : float.Parse(Config.IniReadValue("GameServer", "场地有效范围").Trim()));
				str = "分数扣完扣除元宝";
				分数扣完扣除元宝 = ((Config.IniReadValue("GameServer", "分数扣完扣除元宝").Trim().Length == 0) ? 分数扣完扣除元宝 : int.Parse(Config.IniReadValue("GameServer", "分数扣完扣除元宝").Trim()));
				str = "分数扣完扣除金钱";
				分数扣完扣除金钱 = ((Config.IniReadValue("GameServer", "分数扣完扣除金钱").Trim().Length == 0) ? 分数扣完扣除金钱 : int.Parse(Config.IniReadValue("GameServer", "分数扣完扣除金钱").Trim()));
				str = "允许玩家押注数量";
				允许玩家押注数量 = ((Config.IniReadValue("GameServer", "允许玩家押注数量").Trim().Length == 0) ? 允许玩家押注数量 : int.Parse(Config.IniReadValue("GameServer", "允许玩家押注数量").Trim()));
				str = "地图锁定";
				地图锁定 = Config.IniReadValue("GameServer", "地图锁定").Trim();
				str = "组队等级限制";
				组队等级限制 = ((Config.IniReadValue("GameServer", "组队等级限制").Trim().Length == 0) ? 组队等级限制 : int.Parse(Config.IniReadValue("GameServer", "组队等级限制").Trim()));
				str = "是否开启死亡掉经验";
				是否开启死亡掉经验 = ((Config.IniReadValue("GameServer", "是否开启死亡掉经验").Trim().Length == 0) ? 是否开启死亡掉经验 : int.Parse(Config.IniReadValue("GameServer", "是否开启死亡掉经验").Trim()));
				str = "VIP经验增加百分比";
				VIP经验增加百分比 = ((Config.IniReadValue("GameServer", "VIP经验增加百分比").Trim().Length == 0) ? VIP经验增加百分比 : double.Parse(Config.IniReadValue("GameServer", "VIP经验增加百分比").Trim()));
				str = "VIP历练增加百分比";
				VIP历练增加百分比 = ((Config.IniReadValue("GameServer", "VIP历练增加百分比").Trim().Length == 0) ? VIP历练增加百分比 : double.Parse(Config.IniReadValue("GameServer", "VIP历练增加百分比").Trim()));
				str = "VIP金钱增加百分比";
				VIP金钱增加百分比 = ((Config.IniReadValue("GameServer", "VIP金钱增加百分比").Trim().Length == 0) ? VIP金钱增加百分比 : double.Parse(Config.IniReadValue("GameServer", "VIP金钱增加百分比").Trim()));
				str = "队伍满人经验加成";
				队伍满人经验加成 = ((Config.IniReadValue("GameServer", "队伍满人经验加成").Trim().Length == 0) ? 队伍满人经验加成 : double.Parse(Config.IniReadValue("GameServer", "队伍满人经验加成").Trim()));
				str = "医生PK距离";
				医生PK距离 = ((Config.IniReadValue("GameServer", "医生PK距离").Trim().Length == 0) ? 医生PK距离 : double.Parse(Config.IniReadValue("GameServer", "医生PK距离").Trim()));
				str = "弓箭手PK距离";
				弓箭手PK距离 = ((Config.IniReadValue("GameServer", "弓箭手PK距离").Trim().Length == 0) ? 弓箭手PK距离 : double.Parse(Config.IniReadValue("GameServer", "弓箭手PK距离").Trim()));
				str = "其他职业攻击距离";
				其他职业PK距离 = ((Config.IniReadValue("GameServer", "其他职业PK距离").Trim().Length == 0) ? 其他职业PK距离 : double.Parse(Config.IniReadValue("GameServer", "其他职业PK距离").Trim()));
				str = "医生打怪距离";
				医生打怪距离 = ((Config.IniReadValue("GameServer", "医生打怪距离").Trim().Length == 0) ? 医生打怪距离 : double.Parse(Config.IniReadValue("GameServer", "医生打怪距离").Trim()));
				str = "弓箭手PK距离";
				弓箭手打怪距离 = ((Config.IniReadValue("GameServer", "弓箭手打怪距离").Trim().Length == 0) ? 弓箭手打怪距离 : double.Parse(Config.IniReadValue("GameServer", "弓箭手打怪距离").Trim()));
				str = "其他职业攻击距离";
				其他职业打怪距离 = ((Config.IniReadValue("GameServer", "其他职业打怪距离").Trim().Length == 0) ? 其他职业打怪距离 : double.Parse(Config.IniReadValue("GameServer", "其他职业打怪距离").Trim()));
				str = "经验获得降低百分比";
				经验获得降低百分比 = ((Config.IniReadValue("GameServer", "经验获得降低百分比").Trim().Length == 0) ? 经验获得降低百分比 : double.Parse(Config.IniReadValue("GameServer", "经验获得降低百分比").Trim()));
				str = "历练获得降低百分比";
				历练获得降低百分比 = ((Config.IniReadValue("GameServer", "历练获得降低百分比").Trim().Length == 0) ? 历练获得降低百分比 : double.Parse(Config.IniReadValue("GameServer", "历练获得降低百分比").Trim()));
				str = "金钱获得降低百分比";
				金钱获得降低百分比 = ((Config.IniReadValue("GameServer", "金钱获得降低百分比").Trim().Length == 0) ? 金钱获得降低百分比 : double.Parse(Config.IniReadValue("GameServer", "金钱获得降低百分比").Trim()));
				第一名奖励元宝 = ((Config.IniReadValue("GameServer", "第一名奖励元宝").Trim().Length == 0) ? 500 : int.Parse(Config.IniReadValue("GameServer", "第一名奖励元宝").Trim()));
				str = "高倍经验开始时间";
				高倍经验开始时间 = ((Config.IniReadValue("GameServer", "高倍经验开始时间").Trim().Length == 0) ? 高倍经验开始时间 : int.Parse(Config.IniReadValue("GameServer", "高倍经验开始时间").Trim()));
				str = "高倍经验结束时间";
				高倍经验结束时间 = ((Config.IniReadValue("GameServer", "高倍经验结束时间").Trim().Length == 0) ? 高倍经验结束时间 : int.Parse(Config.IniReadValue("GameServer", "高倍经验结束时间").Trim()));
				str = "经验提高倍数";
				经验提高倍数 = ((Config.IniReadValue("GameServer", "经验提高倍数").Trim().Length == 0) ? 经验提高倍数 : double.Parse(Config.IniReadValue("GameServer", "经验提高倍数").Trim()));
				str = "移动间隔时间";
				移动间隔时间 = ((Config.IniReadValue("GameServer", "移动间隔时间").Trim().Length == 0) ? 移动间隔时间 : int.Parse(Config.IniReadValue("GameServer", "移动间隔时间").Trim()));
				是否开启门战系统 = ((Config.IniReadValue("GameServer", "是否开启门战系统").Trim().Length == 0) ? 是否开启门战系统 : int.Parse(Config.IniReadValue("GameServer", "是否开启门战系统").Trim()));
				门战系统开启时 = ((Config.IniReadValue("GameServer", "门战系统开启时").Trim().Length == 0) ? 门战系统开启时 : int.Parse(Config.IniReadValue("GameServer", "门战系统开启时").Trim()));
				门战系统开启分 = ((Config.IniReadValue("GameServer", "门战系统开启分").Trim().Length == 0) ? 门战系统开启分 : int.Parse(Config.IniReadValue("GameServer", "门战系统开启分").Trim()));
				门战系统开启秒 = ((Config.IniReadValue("GameServer", "门战系统开启秒").Trim().Length == 0) ? 门战系统开启秒 : int.Parse(Config.IniReadValue("GameServer", "门战系统开启秒").Trim()));
				申请门战需要元宝 = ((Config.IniReadValue("GameServer", "申请门战需要元宝").Trim().Length == 0) ? 申请门战需要元宝 : int.Parse(Config.IniReadValue("GameServer", "申请门战需要元宝").Trim()));
				双倍经验等级上限 = ((Config.IniReadValue("GameServer", "双倍经验等级上限").Trim().Length == 0) ? 双倍经验等级上限 : int.Parse(Config.IniReadValue("GameServer", "双倍经验等级上限").Trim()));
				双倍金钱等级上限 = ((Config.IniReadValue("GameServer", "双倍金钱等级上限").Trim().Length == 0) ? 双倍金钱等级上限 : int.Parse(Config.IniReadValue("GameServer", "双倍金钱等级上限").Trim()));
				双倍历练等级上限 = ((Config.IniReadValue("GameServer", "双倍历练等级上限").Trim().Length == 0) ? 双倍历练等级上限 : int.Parse(Config.IniReadValue("GameServer", "双倍历练等级上限").Trim()));
				双倍暴率等级上限 = ((Config.IniReadValue("GameServer", "双倍暴率等级上限").Trim().Length == 0) ? 双倍暴率等级上限 : int.Parse(Config.IniReadValue("GameServer", "双倍暴率等级上限").Trim()));
				双倍等级上限倍数 = ((Config.IniReadValue("GameServer", "双倍等级上限倍数").Trim().Length == 0) ? 双倍等级上限倍数 : double.Parse(Config.IniReadValue("GameServer", "双倍等级上限倍数").Trim()));
				限制最高级别 = ((Config.IniReadValue("GameServer", "限制最高级别").Trim().Length == 0) ? 限制最高级别 : int.Parse(Config.IniReadValue("GameServer", "限制最高级别").Trim()));
				str = "天关经验提高百分比基数";
				天关经验提高百分比基数 = ((Config.IniReadValue("GameServer", "天关经验提高百分比基数").Trim().Length == 0) ? 天关经验提高百分比基数 : double.Parse(Config.IniReadValue("GameServer", "天关经验提高百分比基数").Trim()));
				str = "天关物品爆率提高基数";
				天关物品爆率提高基数 = ((Config.IniReadValue("GameServer", "天关物品爆率提高基数").Trim().Length == 0) ? 天关物品爆率提高基数 : int.Parse(Config.IniReadValue("GameServer", "天关物品爆率提高基数").Trim()));
				str = "天关经验提高百分比递增";
				天关经验提高百分比递增 = ((Config.IniReadValue("GameServer", "天关经验提高百分比递增").Trim().Length == 0) ? 天关经验提高百分比递增 : double.Parse(Config.IniReadValue("GameServer", "天关经验提高百分比递增").Trim()));
				str = "天关物品爆率提高递增";
				天关物品爆率提高递增 = ((Config.IniReadValue("GameServer", "天关物品爆率提高递增").Trim().Length == 0) ? 天关物品爆率提高递增 : int.Parse(Config.IniReadValue("GameServer", "天关物品爆率提高递增").Trim()));
				str = "装备提真消耗";
				装备提真消耗 = ((Config.IniReadValue("GameServer", "装备提真消耗").Trim().Length == 0) ? 装备提真消耗 : int.Parse(Config.IniReadValue("GameServer", "装备提真消耗").Trim()));
				str = "装备提真数量";
				装备提真数量 = ((Config.IniReadValue("GameServer", "装备提真数量").Trim().Length == 0) ? 装备提真数量 : int.Parse(Config.IniReadValue("GameServer", "装备提真数量").Trim()));
				str = "修炼之地是否开启";
				修炼之地是否开启 = ((Config.IniReadValue("GameServer", "修炼之地是否开启").Trim().Length == 0) ? 修炼之地是否开启 : int.Parse(Config.IniReadValue("GameServer", "修炼之地是否开启").Trim()));
				str = "门战奖励物品ID";
				门战奖励物品ID = ((Config.IniReadValue("GameServer", "门战奖励物品ID").Trim().Length == 0) ? 门战奖励物品ID : int.Parse(Config.IniReadValue("GameServer", "门战奖励物品ID").Trim()));
				是否开启锁人攻击检测 = ((Config.IniReadValue("GameServer", "是否开启锁人攻击检测").Trim().Length == 0) ? 是否开启锁人攻击检测 : int.Parse(Config.IniReadValue("GameServer", "是否开启锁人攻击检测").Trim()));
				锁人攻击次数上限 = ((Config.IniReadValue("GameServer", "锁人攻击次数上限").Trim().Length == 0) ? 锁人攻击次数上限 : int.Parse(Config.IniReadValue("GameServer", "锁人攻击次数上限").Trim()));
				锁人攻击检测操作 = ((Config.IniReadValue("GameServer", "锁人攻击检测操作").Trim().Length == 0) ? 锁人攻击检测操作 : int.Parse(Config.IniReadValue("GameServer", "锁人攻击检测操作").Trim()));
				随机BOSS出现时间表 = Config.IniReadValue("GameServer", "随机BOSS出现时间表").Trim();
				门派第一称号奖励 = Config.IniReadValue("GameServer", "门派第一称号奖励").Trim().Split(';');
				门派第二称号奖励 = Config.IniReadValue("GameServer", "门派第二称号奖励").Trim().Split(';');
				门派第三称号奖励 = Config.IniReadValue("GameServer", "门派第三称号奖励").Trim().Split(';');
				当前是否是银币线路 = ((Config.IniReadValue("GameServer", "当前是否是银币线路").Trim().Length == 0) ? 当前是否是银币线路 : int.Parse(Config.IniReadValue("GameServer", "当前是否是银币线路").Trim()));
				是否开启共用银币市场 = ((Config.IniReadValue("GameServer", "是否开启共用银币市场").Trim().Length == 0) ? 是否开启共用银币市场 : int.Parse(Config.IniReadValue("GameServer", "是否开启共用银币市场").Trim()));
				贡献元宝命令 = Config.IniReadValue("GameServer", "贡献元宝命令").Trim();
				贡献元宝数 = int.Parse(Config.IniReadValue("GameServer", "贡献元宝数").Trim());
				贡献元宝荣誉点 = int.Parse(Config.IniReadValue("GameServer", "贡献元宝荣誉点").Trim());
				玫瑰第一名奖励 = Config.IniReadValue("GameServer", "玫瑰第一名奖励").Trim().Split(';');
				玫瑰第二名奖励 = Config.IniReadValue("GameServer", "玫瑰第二名奖励").Trim().Split(';');
				玫瑰第三名奖励 = Config.IniReadValue("GameServer", "玫瑰第三名奖励").Trim().Split(';');
				玫瑰第四名奖励 = Config.IniReadValue("GameServer", "玫瑰第四名奖励").Trim().Split(';');
				玫瑰第五名奖励 = Config.IniReadValue("GameServer", "玫瑰第五名奖励").Trim().Split(';');
				分区编号 = Config.IniReadValue("GameServer", "分区编号").Trim();
				进入传书发送人 = ((Config.IniReadValue("GameServer", "进入传书发送人").Trim() == "") ? 进入传书发送人 : Config.IniReadValue("GameServer", "进入传书发送人").Trim());
				进入传书内容 = ((Config.IniReadValue("GameServer", "进入传书内容").Trim() == "") ? 进入传书内容 : Config.IniReadValue("GameServer", "进入传书内容").Trim());
				AtPort = ((Config.IniReadValue("GameServer", "AtPort").Trim() == "") ? AtPort : int.Parse(Config.IniReadValue("GameServer", "AtPort").Trim()));
				最大速度超出次数操作 = ((Config.IniReadValue("GameServer", "最大速度超出次数操作").Trim().Length == 0) ? 最大速度超出次数操作 : int.Parse(Config.IniReadValue("GameServer", "最大速度超出次数操作").Trim()));
				三十秒内允许超出次数 = ((Config.IniReadValue("GameServer", "三十秒内允许超出次数").Trim().Length == 0) ? 三十秒内允许超出次数 : int.Parse(Config.IniReadValue("GameServer", "三十秒内允许超出次数").Trim()));
				周末武勋量 = ((Config.IniReadValue("GameServer", "周末武勋量").Trim().Length == 0) ? 周末武勋量 : int.Parse(Config.IniReadValue("GameServer", "周末武勋量").Trim()));
				二转每日武勋上限 = ((Config.IniReadValue("GameServer", "二转每日武勋上限").Trim().Length == 0) ? 二转每日武勋上限 : int.Parse(Config.IniReadValue("GameServer", "二转每日武勋上限").Trim()));
				三转每日武勋上限 = ((Config.IniReadValue("GameServer", "三转每日武勋上限").Trim().Length == 0) ? 三转每日武勋上限 : int.Parse(Config.IniReadValue("GameServer", "三转每日武勋上限").Trim()));
				四转每日武勋上限 = ((Config.IniReadValue("GameServer", "四转每日武勋上限").Trim().Length == 0) ? 四转每日武勋上限 : int.Parse(Config.IniReadValue("GameServer", "四转每日武勋上限").Trim()));
				五转每日武勋上限 = ((Config.IniReadValue("GameServer", "五转每日武勋上限").Trim().Length == 0) ? 五转每日武勋上限 : int.Parse(Config.IniReadValue("GameServer", "五转每日武勋上限").Trim()));
				六转每日武勋上限 = ((Config.IniReadValue("GameServer", "六转每日武勋上限").Trim().Length == 0) ? 六转每日武勋上限 : int.Parse(Config.IniReadValue("GameServer", "六转每日武勋上限").Trim()));
				七转每日武勋上限 = ((Config.IniReadValue("GameServer", "七转每日武勋上限").Trim().Length == 0) ? 七转每日武勋上限 : int.Parse(Config.IniReadValue("GameServer", "七转每日武勋上限").Trim()));
				八转每日武勋上限 = ((Config.IniReadValue("GameServer", "八转每日武勋上限").Trim().Length == 0) ? 八转每日武勋上限 : int.Parse(Config.IniReadValue("GameServer", "八转每日武勋上限").Trim()));
				九转每日武勋上限 = ((Config.IniReadValue("GameServer", "九转每日武勋上限").Trim().Length == 0) ? 九转每日武勋上限 : int.Parse(Config.IniReadValue("GameServer", "九转每日武勋上限").Trim()));
				十转每日武勋上限 = ((Config.IniReadValue("GameServer", "十转每日武勋上限").Trim().Length == 0) ? 十转每日武勋上限 : int.Parse(Config.IniReadValue("GameServer", "十转每日武勋上限").Trim()));
				一转经验百分比 = ((Config.IniReadValue("GameServer", "一转经验百分比") == string.Empty) ? 一转经验百分比 : double.Parse(Config.IniReadValue("GameServer", "一转经验百分比")));
				二转经验百分比 = ((Config.IniReadValue("GameServer", "二转经验百分比") == string.Empty) ? 二转经验百分比 : double.Parse(Config.IniReadValue("GameServer", "二转经验百分比")));
				三转经验百分比 = ((Config.IniReadValue("GameServer", "三转经验百分比") == string.Empty) ? 三转经验百分比 : double.Parse(Config.IniReadValue("GameServer", "三转经验百分比")));
				四转经验百分比 = ((Config.IniReadValue("GameServer", "四转经验百分比") == string.Empty) ? 四转经验百分比 : double.Parse(Config.IniReadValue("GameServer", "四转经验百分比")));
				五转经验百分比 = ((Config.IniReadValue("GameServer", "五转经验百分比") == string.Empty) ? 五转经验百分比 : double.Parse(Config.IniReadValue("GameServer", "五转经验百分比")));
				六转经验百分比 = ((Config.IniReadValue("GameServer", "六转经验百分比") == string.Empty) ? 六转经验百分比 : double.Parse(Config.IniReadValue("GameServer", "六转经验百分比")));
				七转经验百分比 = ((Config.IniReadValue("GameServer", "七转经验百分比") == string.Empty) ? 七转经验百分比 : double.Parse(Config.IniReadValue("GameServer", "七转经验百分比")));
				八转经验百分比 = ((Config.IniReadValue("GameServer", "八转经验百分比") == string.Empty) ? 八转经验百分比 : double.Parse(Config.IniReadValue("GameServer", "八转经验百分比")));
				九转经验百分比 = ((Config.IniReadValue("GameServer", "九转经验百分比") == string.Empty) ? 九转经验百分比 : double.Parse(Config.IniReadValue("GameServer", "九转经验百分比")));
				十转经验百分比 = ((Config.IniReadValue("GameServer", "十转经验百分比") == string.Empty) ? 十转经验百分比 : double.Parse(Config.IniReadValue("GameServer", "十转经验百分比")));
				移动速度 = Config.IniReadValue("GameServer", "最大移动速度").Trim().Split(';');
				外挂检测操作 = ((Config.IniReadValue("GameServer", "外挂检测操作").Trim().Length == 0) ? 外挂检测操作 : int.Parse(Config.IniReadValue("GameServer", "外挂检测操作").Trim()));
				是否允许快速攻击 = ((Config.IniReadValue("GameServer", "是否允许快速攻击").Trim().Length == 0) ? 是否允许快速攻击 : int.Parse(Config.IniReadValue("GameServer", "是否允许快速攻击").Trim()));
				是否开启四神系统 = ((Config.IniReadValue("GameServer", "是否开启四神系统").Trim().Length == 0) ? 是否开启四神系统 : int.Parse(Config.IniReadValue("GameServer", "是否开启四神系统").Trim()));
				是否支持扩展物品属性位数 = ((Config.IniReadValue("GameServer", "是否支持扩展物品属性位数").Trim().Length == 0) ? 是否开启四神系统 : int.Parse(Config.IniReadValue("GameServer", "是否支持扩展物品属性位数").Trim()));
				武器PK掉耐久度 = ((Config.IniReadValue("GameServer", "武器PK掉耐久度").Trim().Length == 0) ? 武器PK掉耐久度 : int.Parse(Config.IniReadValue("GameServer", "武器PK掉耐久度").Trim()));
				防具PK掉耐久度 = ((Config.IniReadValue("GameServer", "防具PK掉耐久度").Trim().Length == 0) ? 防具PK掉耐久度 : int.Parse(Config.IniReadValue("GameServer", "防具PK掉耐久度").Trim()));
				安全挂机时间 = ((Config.IniReadValue("GameServer", "安全挂机时间").Trim().Length == 0) ? 安全挂机时间 : int.Parse(Config.IniReadValue("GameServer", "安全挂机时间").Trim()));
				灵宠进化率 = ((Config.IniReadValue("GameServer", "灵宠进化率").Trim().Length == 0) ? 灵宠进化率 : double.Parse(Config.IniReadValue("GameServer", "灵宠进化率").Trim()));
				灵宠强化率 = ((Config.IniReadValue("GameServer", "灵宠强化率").Trim().Length == 0) ? 灵宠强化率 : double.Parse(Config.IniReadValue("GameServer", "灵宠强化率").Trim()));
				灵宠进化率 = ((Config.IniReadValue("GameServer", "灵宠进化率").Trim().Length == 0) ? 灵宠进化率 : double.Parse(Config.IniReadValue("GameServer", "灵宠进化率").Trim()));
				道具强化概率 = ((Config.IniReadValue("GameServer", "道具强化概率").Trim().Length == 0) ? 道具强化概率 : double.Parse(Config.IniReadValue("GameServer", "道具强化概率").Trim()));
				挂机奖励赠品元宝 = ((Config.IniReadValue("GameServer", "挂机奖励赠品元宝").Trim().Length == 0) ? 挂机奖励赠品元宝 : int.Parse(Config.IniReadValue("GameServer", "挂机奖励赠品元宝").Trim()));
				购买武勋装备消耗武勋 = ((Config.IniReadValue("GameServer", "购买武勋装备消耗武勋").Trim().Length == 0) ? 购买武勋装备消耗武勋 : int.Parse(Config.IniReadValue("GameServer", "购买武勋装备消耗武勋").Trim()));
				刀PK伤害参数 = ((Config.IniReadValue("GameServer", "刀PK伤害参数").Trim().Length == 0) ? 刀PK伤害参数 : double.Parse(Config.IniReadValue("GameServer", "刀PK伤害参数").Trim()));
				剑PK伤害参数 = ((Config.IniReadValue("GameServer", "剑PK伤害参数").Trim().Length == 0) ? 剑PK伤害参数 : double.Parse(Config.IniReadValue("GameServer", "剑PK伤害参数").Trim()));
				枪PK伤害参数 = ((Config.IniReadValue("GameServer", "枪PK伤害参数").Trim().Length == 0) ? 枪PK伤害参数 : double.Parse(Config.IniReadValue("GameServer", "枪PK伤害参数").Trim()));
				弓PK伤害参数 = ((Config.IniReadValue("GameServer", "弓PK伤害参数").Trim().Length == 0) ? 弓PK伤害参数 : double.Parse(Config.IniReadValue("GameServer", "弓PK伤害参数").Trim()));
				医PK伤害参数 = ((Config.IniReadValue("GameServer", "医PK伤害参数").Trim().Length == 0) ? 医PK伤害参数 : double.Parse(Config.IniReadValue("GameServer", "医PK伤害参数").Trim()));
				刺PK伤害参数 = ((Config.IniReadValue("GameServer", "刺PK伤害参数").Trim().Length == 0) ? 刺PK伤害参数 : double.Parse(Config.IniReadValue("GameServer", "刺PK伤害参数").Trim()));
				乐PK伤害参数 = ((Config.IniReadValue("GameServer", "乐PK伤害参数").Trim().Length == 0) ? 乐PK伤害参数 : double.Parse(Config.IniReadValue("GameServer", "乐PK伤害参数").Trim()));
				韩PK伤害参数 = ((Config.IniReadValue("GameServer", "韩PK伤害参数").Trim().Length == 0) ? 韩PK伤害参数 : double.Parse(Config.IniReadValue("GameServer", "韩PK伤害参数").Trim()));
				谭PK伤害参数 = ((Config.IniReadValue("GameServer", "谭PK伤害参数").Trim().Length == 0) ? 谭PK伤害参数 : double.Parse(Config.IniReadValue("GameServer", "谭PK伤害参数").Trim()));
				拳PK伤害参数 = ((Config.IniReadValue("GameServer", "拳PK伤害参数").Trim().Length == 0) ? 拳PK伤害参数 : double.Parse(Config.IniReadValue("GameServer", "拳PK伤害参数").Trim()));
				梅PK伤害参数 = ((Config.IniReadValue("GameServer", "梅PK伤害参数").Trim().Length == 0) ? 梅PK伤害参数 : double.Parse(Config.IniReadValue("GameServer", "梅PK伤害参数").Trim()));
				卢PK伤害参数 = ((Config.IniReadValue("GameServer", "卢PK伤害参数").Trim().Length == 0) ? 卢PK伤害参数 : double.Parse(Config.IniReadValue("GameServer", "卢PK伤害参数").Trim()));
				if (随机BOSS出现时间表.Length != 0)
				{
					BOSSListTime.Clear();
					string text = 随机BOSS出现时间表;
					char[] separator = new char[1]
					{
						';'
					};
					string[] array = text.Split(separator);
					for (int i = 0; i < array.Length; i++)
					{
						int item = int.Parse(array[i]);
						BOSSListTime.Add(item);
					}
				}
				else
				{
					BOSSListTime.Clear();
				}
				if (是否加密 == 1)
				{
					for (int j = 0; j < 8; j++)
					{
						g_cur_key[j] = Convert.ToByte(加密密钥.Substring(j * 2, 2), 16);
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(100, "配置文件  config.ini  配置错误:" + ex.Message);
				Form1.WriteLine(100, "在设置项:  " + str);
			}
		}

		private static void smethod_0()
		{
		}

		public static bool 检查数据库配置()
		{
			using (SqlConnection sqlConnection = new SqlConnection(DBA.getstrConnection("rxjhaccount")))
			{
				try
				{
					sqlConnection.Open();
				}
				catch
				{
					Form1.WriteLine(1, "数据库rxjhaccount配置错误，无法连接");
					return false;
				}
				finally
				{
					sqlConnection.Close();
				}
			}
			using (SqlConnection sqlConnection2 = new SqlConnection(DBA.getstrConnection("GameServer")))
			{
				try
				{
					sqlConnection2.Open();
				}
				catch
				{
					Form1.WriteLine(1, "数据库rxjhgame配置错误，无法连接");
					return false;
				}
				finally
				{
					sqlConnection2.Close();
				}
			}
			using (SqlConnection sqlConnection3 = new SqlConnection(DBA.getstrConnection("PublicDb")))
			{
				try
				{
					sqlConnection3.Open();
				}
				catch
				{
					Form1.WriteLine(1, "数据库PublicDb配置错误，无法连接");
					return false;
				}
				finally
				{
					sqlConnection3.Close();
				}
			}
			using (SqlConnection sqlConnection4 = new SqlConnection(DBA.getstrConnection("WebDb")))
			{
				try
				{
					sqlConnection4.Open();
				}
				catch
				{
					Form1.WriteLine(1, "数据库WebDb配置错误，无法连接");
					return false;
				}
				finally
				{
					sqlConnection4.Close();
				}
			}
			using (SqlConnection sqlConnection5 = new SqlConnection(DBA.getstrConnection("BBG")))
			{
				try
				{
					sqlConnection5.Open();
				}
				catch
				{
					Form1.WriteLine(1, "数据库BBG配置错误，无法连接");
					return false;
				}
				finally
				{
					sqlConnection5.Close();
				}
			}
			return true;
		}

		public void SetConfig3()
		{
			//try
			//{
			//	string[] array = new SymmetricMethod().Decrypto(Key).Split('|');
			//	if (array.Length >= 4)
			//	{
			//		if (!(Hasher.GetCpuID() != pWord(array[0], 2)) && !(Hasher.GetDriveID("C") != pWord(array[1], 2)) && !(Hasher.GetIP() != pWord(array[2], 2)) && !(Hasher.GetMac() != pWord(array[3], 2)))
			//		{
			//			if (array.Length >= 5 && double.Parse(pWord(array[4], 2)) < ServerVer)
			//			{
			//				Environment.Exit(0);
			//			}
			//			KeykF.CpuID = pWord(array[0], 2);
			//			KeykF.DriveID = pWord(array[1], 2);
			//			KeykF.IP = pWord(array[2], 2);
			//			KeykF.Mac = pWord(array[3], 2);
			//		}
			//		else
			//		{
			//			Environment.Exit(0);
			//		}
			//	}
			//	else
			//	{
			//		Environment.Exit(0);
			//	}
			//	if (!(Keyk.CpuID != KeykF.CpuID) && !(Keyk.DriveID != KeykF.DriveID) && !(Keyk.IP != KeykF.IP) && !(Keyk.Mac != KeykF.Mac))
			//	{
			//		if (KeykF.IP.Length < 4 || KeykF.Mac.Length < 4 || Keyk.IP.Length < 4 || Keyk.Mac.Length < 4)
			//		{
			//			Environment.Exit(0);
			//		}
			//	}
			//	else
			//	{
			//		Environment.Exit(0);
			//	}
			//}
			//catch (Exception ex)
			//{
			//	Form1.WriteLine(1, "11" + ex.Message);
			//	Environment.Exit(0);
			//}
		}

		public void SetConfig4()
		{
			//try
			//{
			//	string[] array = new Class2().DecryptByPublicKey(Key2).Split('|');
			//	if (array.Length >= 4)
			//	{
			//		if (!(Hasher.GetCpuID() != pWord(array[0], 2)) && !(Hasher.GetIP() != pWord(array[2], 2)) && !(Hasher.GetMac() != pWord(array[3], 2)))
			//		{
			//			if (array.Length >= 5 && double.Parse(pWord(array[4], 2)) < ServerVer)
			//			{
			//				Environment.Exit(0);
			//			}
			//			KeykF.CpuID = pWord(array[0], 2);
			//			KeykF.DriveID = pWord(array[1], 2);
			//			KeykF.IP = pWord(array[2], 2);
			//			KeykF.Mac = pWord(array[3], 2);
			//		}
			//		else
			//		{
			//			Environment.Exit(0);
			//		}
			//	}
			//	else
			//	{
			//		Environment.Exit(0);
			//	}
			//	if (!(Keyk.CpuID != KeykF.CpuID) && !(Keyk.IP != KeykF.IP) && !(Keyk.Mac != KeykF.Mac))
			//	{
			//		if (KeykF.IP.Length < 4 || KeykF.Mac.Length < 4 || Keyk.IP.Length < 4 || Keyk.Mac.Length < 4)
			//		{
			//			Environment.Exit(0);
			//		}
			//	}
			//	else
			//	{
			//		Environment.Exit(0);
			//	}
			//}
			//catch (Exception ex)
			//{
			//	Form1.WriteLine(100, "11" + ex.Message);
			//	Environment.Exit(0);
			//}
		}

		[SecureMethod]
		public void SetConfig2()
		{
			Db.Add("rxjhaccount", new DbClass
			{
				ServerDb = "rxjhaccount",
				SqlConnect = string.Format("Data Source={0};uid={1};pwd={2};database={3};Packet Size=4096;Pooling=true;Max Pool Size=512;Min Pool Size=1", Config.IniReadValue("rxjhaccount", "Server").Trim(), Config.IniReadValue("rxjhaccount", "UserName").Trim(), Config.IniReadValue("rxjhaccount", "PassWord").Trim(), Config.IniReadValue("rxjhaccount", "DataName").Trim())
			});
			Db.Add("GameServer", new DbClass
			{
				ServerDb = "GameServer",
				SqlConnect = string.Format("Data Source={0};uid={1};pwd={2};database={3};Packet Size=4096;Pooling=true;Max Pool Size=512;Min Pool Size=1", Config.IniReadValue("GameServer", "Server").Trim(), Config.IniReadValue("GameServer", "UserName").Trim(), Config.IniReadValue("GameServer", "PassWord").Trim(), Config.IniReadValue("GameServer", "DataName").Trim())
			});
			Db.Add("PublicDb", new DbClass
			{
				ServerDb = "PublicDb",
				SqlConnect = string.Format("Data Source={0};uid={1};pwd={2};database={3};Packet Size=4096;Pooling=true;Max Pool Size=512;Min Pool Size=1", Config.IniReadValue("PublicDb", "Server").Trim(), Config.IniReadValue("PublicDb", "UserName").Trim(), Config.IniReadValue("PublicDb", "PassWord").Trim(), Config.IniReadValue("PublicDb", "DataName").Trim())
			});
			Db.Add("WebDb", new DbClass
			{
				ServerDb = "WebDb",
				SqlConnect = string.Format("Data Source={0};uid={1};pwd={2};database={3};Packet Size=4096;Pooling=true;Max Pool Size=512;Min Pool Size=1", Config.IniReadValue("WebDb", "Server").Trim(), Config.IniReadValue("WebDb", "UserName").Trim(), Config.IniReadValue("WebDb", "PassWord").Trim(), Config.IniReadValue("WebDb", "DataName").Trim())
			});
			Db.Add("BBG", new DbClass
			{
				ServerDb = "BBG",
				SqlConnect = string.Format("Data Source={0};uid={1};pwd={2};database={3};Packet Size=4096;Pooling=true;Max Pool Size=512;Min Pool Size=1", Config.IniReadValue("BBG", "Server").Trim(), Config.IniReadValue("BBG", "UserName").Trim(), Config.IniReadValue("BBG", "PassWord").Trim(), Config.IniReadValue("BBG", "DataName").Trim())
			});
		}

		public void SetWxLever()
		{
			Wxlever.Clear();
			Wxlever.Add(0, 0.0);
			Wxlever.Add(1, 1000.0);
			Wxlever.Add(2, 15000.0);
			Wxlever.Add(3, 50000.0);
			Wxlever.Add(4, 100000.0);
			Wxlever.Add(5, 599999.0);
			Wxlever.Add(6, 1199999.0);
			Wxlever.Add(7, 1200000.0);
			Wxlever.Add(8, 1500000.0);
			Wxlever.Add(9, 5000000.0);
			Form1.WriteLine(2, "加载武勋阶段表完成");
		}

		[SecureMethod]
		public void Set安全区()
		{
			对练区.Add(new 坐标Class
			{
				Rxjh_name = "对练区",
				Rxjh_Map = 2301,
				Rxjh_X = 120f,
				Rxjh_Y = 0f,
				Rxjh_Z = 15f
			});
			对练区.Add(new 坐标Class
			{
				Rxjh_name = "对练区",
				Rxjh_Map = 2341,
				Rxjh_X = 120f,
				Rxjh_Y = 0f,
				Rxjh_Z = 15f
			});
			势力战区域.Add(new 坐标Class
			{
				Rxjh_name = "势力战区域",
				Rxjh_Map = 801,
				Rxjh_X = 0f,
				Rxjh_Y = 0f,
				Rxjh_Z = 15f
			});
			帮战区.Add(new 坐标Class
			{
				Rxjh_name = "帮战区",
				Rxjh_Map = 7301,
				Rxjh_X = 0f,
				Rxjh_Y = 0f,
				Rxjh_Z = 15f
			});
		}

		[SecureMethod]
		public void SetJianc()
		{
			if (查非法物品 != 2)
			{
				return;
			}
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  *  FROM  装备检测"), "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count != 0)
			{
				装备检测list.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					装备检测list.Add((int)dBToDataTable.Rows[i]["物品类型"], new 装备检测类
					{
						物品最高攻击值 = (int)dBToDataTable.Rows[i]["物品最高攻击值"],
						物品最高防御值 = (int)dBToDataTable.Rows[i]["物品最高防御值"],
						物品最高生命值 = (int)dBToDataTable.Rows[i]["物品最高生命值"],
						物品最高内功值 = (int)dBToDataTable.Rows[i]["物品最高内功值"],
						物品最高命中值 = (int)dBToDataTable.Rows[i]["物品最高命中值"],
						物品最高回避值 = (int)dBToDataTable.Rows[i]["物品最高回避值"],
						物品最高武功值 = (int)dBToDataTable.Rows[i]["物品最高武功值"],
						物品最高气功值 = (int)dBToDataTable.Rows[i]["物品最高气功值"],
						物品最高附魂值 = (int)dBToDataTable.Rows[i]["物品最高附魂值"]
					});
				}
				Form1.WriteLine(2, "加载装备检测数据完成" + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		[SecureMethod]
		public void SetQG()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  *  FROM  TBL_XWWL_SKILL"), "PublicDb");
			if (dBToDataTable != null)
			{
				if (dBToDataTable.Rows.Count != 0)
				{
					气功加成.Clear();
					for (int i = 0; i < dBToDataTable.Rows.Count; i++)
					{
						气功加成.Add(i, new 气功加成属性
						{
							FLD_PID = (int)dBToDataTable.Rows[i]["FLD_PID"],
							FLD_INDEX = (int)dBToDataTable.Rows[i]["FLD_INDEX"],
							FLD_JOB = (int)dBToDataTable.Rows[i]["FLD_JOB"],
							FLD_NAME = dBToDataTable.Rows[i]["FLD_NAME"].ToString(),
							FLD_每点加成比率值1 = (double)dBToDataTable.Rows[i]["FLD_每点加成比率值1"],
							FLD_每点加成比率值2 = (double)dBToDataTable.Rows[i]["FLD_每点加成比率值2"]
						});
					}
					Form1.WriteLine(2, "加载气功加成比率数据完成" + dBToDataTable.Rows.Count);
				}
				dBToDataTable.Dispose();
			}
			普通气功ID.Clear();
			for (int j = 0; j < 12; j++)
			{
				for (int k = 1; k < 14; k++)
				{
					普通气功ID.Add(method_0(j, k));
				}
			}
			普通气功ID.Sort();
		}

		[SecureMethod]
		public void SetKill()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  *  FROM  XWWL_kill"), "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(2, "加载过滤出错----没有过滤数据");
			}
			else
			{
				Kill.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					Kill.Add(new KillClass
					{
						Txt = dBToDataTable.Rows[i]["txt"].ToString(),
						Sffh = (int)dBToDataTable.Rows[i]["sffh"]
					});
				}
				Form1.WriteLine(2, "加载过滤数据完成" + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		[SecureMethod]
		public void Set等级奖励()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  *  FROM  等级奖励"), "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(2, "加载等级奖励出错----没有等级奖励数据");
			}
			else
			{
				等级奖励.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					等级奖励.Add(i, new 等级奖励类
					{
						等级 = (int)dBToDataTable.Rows[i]["级别"],
						武勋 = (int)dBToDataTable.Rows[i]["武勋"],
						元宝 = (int)dBToDataTable.Rows[i]["元宝"],
						生命 = (int)dBToDataTable.Rows[i]["生命"],
						攻击 = (int)dBToDataTable.Rows[i]["攻击"],
						防御 = (int)dBToDataTable.Rows[i]["防御"],
						回避 = (int)dBToDataTable.Rows[i]["回避"],
						命中 = (int)dBToDataTable.Rows[i]["命中"],
						内功 = (int)dBToDataTable.Rows[i]["内功"],
						套装 = (int)dBToDataTable.Rows[i]["套装ID"],
						金钱 = dBToDataTable.Rows[i]["金钱"].ToString(),
						单件物品 = dBToDataTable.Rows[i]["单件物品"].ToString()
					});
				}
				Form1.WriteLine(2, "加载等级奖励数据完成" + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		[SecureMethod]
		public void Set石头属性()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  *  FROM  TBL_XWWL_STONE"), "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(2, "加载石头属性出错----没有石头数据");
			}
			else
			{
				clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					SetStone((int)dBToDataTable.Rows[i]["FLD_TYPE"], (int)dBToDataTable.Rows[i]["FLD_VALUE"], (int)dBToDataTable.Rows[i]["FLD_增减"]);
				}
				Form1.WriteLine(2, "加载石头属性效果数据完成" + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		public void SetStone(int int_0, int int_1, int int_2)
		{
			try
			{
				switch (int_0)
				{
				case 2:
					switch (int_1)
					{
					case 10:
						f10 += int_2;
						break;
					case 11:
						f11 += int_2;
						break;
					case 12:
						f12 += int_2;
						break;
					case 13:
						f13 += int_2;
						break;
					case 14:
						f14 += int_2;
						break;
					case 15:
						f15 += int_2;
						break;
					}
					break;
				case 1:
					switch (int_1)
					{
					case 20:
						g20 += int_2;
						break;
					case 21:
						g21 += int_2;
						break;
					case 22:
						g22 += int_2;
						break;
					case 23:
						g23 += int_2;
						break;
					case 24:
						g24 += int_2;
						break;
					case 25:
						g25 += int_2;
						break;
					}
					break;
				case 11:
					switch (int_1)
					{
					case 69:
						break;
					case 71:
						break;
					case 73:
						break;
					case 75:
						break;
					case 77:
						break;
					case 79:
						break;
					case 81:
					case 82:
					case 83:
					case 84:
						break;
					case 86:
					case 87:
					case 88:
					case 89:
						break;
					case 91:
					case 92:
					case 93:
					case 94:
						break;
					case 96:
					case 97:
					case 98:
					case 99:
						break;
					case 68:
						wf68 += int_2;
						break;
					case 70:
						wf70 += int_2;
						break;
					case 72:
						wf72 += int_2;
						break;
					case 74:
						wf74 += int_2;
						break;
					case 76:
						wf76 += int_2;
						break;
					case 78:
						wf78 += int_2;
						break;
					case 80:
						wf80 += int_2;
						break;
					case 85:
						wf85 += int_2;
						break;
					case 90:
						wf90 += int_2;
						break;
					case 95:
						wf95 += int_2;
						break;
					case 100:
						wf100 += int_2;
						break;
					}
					break;
				case 7:
					switch (int_1)
					{
					case 25:
						wg25 += int_2;
						break;
					case 26:
						wg26 += int_2;
						break;
					case 27:
						wg27 += int_2;
						break;
					case 28:
						wg28 += int_2;
						break;
					case 29:
						wg29 += int_2;
						break;
					case 30:
						wg30 += int_2;
						break;
					case 31:
						wg31 += int_2;
						break;
					case 32:
						wg32 += int_2;
						break;
					case 33:
						wg33 += int_2;
						break;
					case 34:
						wg34 += int_2;
						break;
					case 35:
						wg35 += int_2;
						break;
					case 36:
						wg36 += int_2;
						break;
					case 37:
						wg37 += int_2;
						break;
					case 38:
						wg38 += int_2;
						break;
					case 39:
						wg39 += int_2;
						break;
					case 40:
						wg40 += int_2;
						break;
					}
					break;
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(2, "设置石头出错|" + int_0 + "|" + int_1 + "|" + int_2 + "|" + ex.Message);
			}
		}

		[SecureMethod]
		public void Set物品兑换()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  *  FROM  物品兑换"), "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(2, "加载物品兑换出错----没有物品兑换数据");
			}
			else
			{
				物品兑换.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					物品兑换.Add(i, new 物品兑换类
					{
						需要物品 = dBToDataTable.Rows[i]["需要物品"].ToString(),
						武勋 = (int)dBToDataTable.Rows[i]["武勋"],
						元宝 = (int)dBToDataTable.Rows[i]["元宝"],
						生命 = (int)dBToDataTable.Rows[i]["生命"],
						攻击 = (int)dBToDataTable.Rows[i]["攻击"],
						防御 = (int)dBToDataTable.Rows[i]["防御"],
						回避 = (int)dBToDataTable.Rows[i]["回避"],
						命中 = (int)dBToDataTable.Rows[i]["命中"],
						内功 = (int)dBToDataTable.Rows[i]["内功"],
						套装 = (int)dBToDataTable.Rows[i]["套装ID"],
						金钱 = dBToDataTable.Rows[i]["金钱"].ToString(),
						单件物品 = dBToDataTable.Rows[i]["单件物品"].ToString()
					});
				}
				Form1.WriteLine(2, "加载物品兑换数据完成" + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		[SecureMethod]
		public void Set公告()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  *  FROM  TBL_XWWL_Gg"), "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(2, "加载公告出错----没有公告数据");
			}
			else
			{
				公告.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					公告.Add(i, new 公告类
					{
						msg = dBToDataTable.Rows[i]["txt"].ToString(),
						type = (int)dBToDataTable.Rows[i]["type"]
					});
				}
				Form1.WriteLine(2, "加载公告数据完成" + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		[SecureMethod]
		public void Set任务数据新()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT *  FROM  TBL_XWWL_MISSION"), "PublicDb");
			int num = 0;
			try
			{
				if (dBToDataTable != null)
				{
					if (dBToDataTable.Rows.Count == 0)
					{
						Form1.WriteLine(2, "加载任务数据新出错----没有任务传书数据");
					}
					else
					{
						任务list.Clear();
						for (int i = 0; i < dBToDataTable.Rows.Count; i++)
						{
							任务类 任务类 = new 任务类();
							任务类.RwID = (int)dBToDataTable.Rows[i]["FLD_PID"];
							num = 任务类.RwID;
							任务类.任务名 = dBToDataTable.Rows[i]["FLD_NAME"].ToString();
							任务类.任务等级 = (int)dBToDataTable.Rows[i]["FLD_LEVEL"];
							任务类.任务正邪 = (int)dBToDataTable.Rows[i]["FLD_ZX"];
							任务类.职业 = (int)dBToDataTable.Rows[i]["FLD_JOB"];
							任务类.NpcID = (int)dBToDataTable.Rows[i]["FLD_NPCID"];
							任务类.NPCNAME = dBToDataTable.Rows[i]["FLD_NPCNAME"].ToString();
							任务类.Npc坐标.地图ID = (int)dBToDataTable.Rows[i]["FLD_MAP"];
							任务类.Npc坐标.坐标X = (int)dBToDataTable.Rows[i]["FLD_X"];
							任务类.Npc坐标.坐标Y = (int)dBToDataTable.Rows[i]["FLD_Y"];
							任务类.任务传书 = dBToDataTable.Rows[i]["FLD_MSG"].ToString();
							任务类.任务开关 = (int)dBToDataTable.Rows[i]["FLD_ON"];
							任务类.任务类型 = (int)dBToDataTable.Rows[i]["FLD_TYPE"];
							string text = dBToDataTable.Rows[i]["FLD_NEED_ITEM"].ToString();
							if (text.Length > 0)
							{
								string text2 = text;
								char[] separator = new char[1]
								{
									';'
								};
								string[] array = text2.Split(separator);
								foreach (string text3 in array)
								{
									任务需要物品类 任务需要物品类 = new 任务需要物品类();
									char[] separator2 = new char[1]
									{
										'|'
									};
									string[] array2 = text3.Split(separator2);
									任务需要物品类.物品ID = int.Parse(array2[0]);
									任务需要物品类.物品数量 = int.Parse(array2[1]);
									任务类.任务需要物品.Add(任务需要物品类);
								}
							}
							string text4 = dBToDataTable.Rows[i]["FLD_GET_ITEM"].ToString();
							if (text4.Length > 0)
							{
								string text5 = text4;
								char[] separator3 = new char[1]
								{
									';'
								};
								string[] array = text5.Split(separator3);
								foreach (string text6 in array)
								{
									任务获得物品类 任务获得物品类 = new 任务获得物品类();
									char[] separator4 = new char[1]
									{
										'|'
									};
									string[] array3 = text6.Split(separator4);
									任务获得物品类.物品ID = int.Parse(array3[0]);
									任务获得物品类.物品数量 = int.Parse(array3[1]);
									任务类.任务获得物品.Add(任务获得物品类);
								}
							}
							任务类.执行阶段数据 = (byte[])dBToDataTable.Rows[i]["FLD_DATA"];
							if (任务类.执行阶段数据.Length >= 5)
							{
								任务类.NpcID = Buffer.ToInt16(任务类.执行阶段数据, 2);
								任务类.任务阶段数量 = Buffer.ToInt16(任务类.执行阶段数据, 4);
								if (任务类.任务阶段数量 == 0)
								{
									任务阶段类 任务阶段类 = new 任务阶段类();
									byte[] array4 = new byte[530];
									System.Buffer.BlockCopy(任务类.执行阶段数据, 6, array4, 0, 530);
									任务阶段类.阶段ID = Buffer.ToInt16(array4, 0);
									任务阶段类.NpcID = Buffer.ToInt16(array4, 2);
									任务阶段类.难度系数 = Buffer.ToInt16(array4, 4);
									for (int k = 0; k < 10; k++)
									{
										byte[] array5 = new byte[12];
										System.Buffer.BlockCopy(array4, k * 12 + 6, array5, 0, 12);
										if (BitConverter.ToInt64(array5, 0) == 0L)
										{
											break;
										}
										任务阶段类.阶段需要物品_.Add(k, new 阶段需要物品类
										{
											怪物ID = BitConverter.ToInt32(array5, 0),
											物品ID = BitConverter.ToInt32(array5, 4),
											物品总数 = BitConverter.ToInt16(array5, 8),
											实际需要数量 = BitConverter.ToInt16(array5, 10)
										});
									}
									for (int l = 0; l < 10; l++)
									{
										byte[] array6 = new byte[8];
										System.Buffer.BlockCopy(array4, l * 8 + 126, array6, 0, 8);
										if (BitConverter.ToInt32(array6, 0) == 0)
										{
											break;
										}
										任务阶段类.阶段奖励物品_.Add(l, new 阶段奖励物品类
										{
											物品ID = BitConverter.ToInt32(array6, 0),
											物品数量 = BitConverter.ToInt32(array6, 4)
										});
									}
									byte[] array7 = new byte[14];
									System.Buffer.BlockCopy(array4, 206, array7, 0, 14);
									任务阶段类.NPCNAME = Encoding.Default.GetString(array7).Replace("\0", string.Empty).Trim();
									任务阶段类.Npc地图ID = Buffer.ToInt16(array4, 220);
									任务阶段类.Npc坐标X = Buffer.ToInt32(array4, 222);
									任务阶段类.Npc坐标Y = Buffer.ToInt32(array4, 226);
									byte[] array8 = new byte[300];
									System.Buffer.BlockCopy(array4, 230, array8, 0, 300);
									任务阶段类.任务阶段内容 = Encoding.Default.GetString(array8).Replace("\0", string.Empty).Trim();
									任务类.任务阶段.Add(任务阶段类);
								}
								else
								{
									for (int m = 0; m < 任务类.任务阶段数量; m++)
									{
										任务阶段类 任务阶段类2 = new 任务阶段类();
										byte[] array9 = new byte[530];
										System.Buffer.BlockCopy(任务类.执行阶段数据, m * 530 + 6, array9, 0, 530);
										任务阶段类2.阶段ID = Buffer.ToInt16(array9, 0);
										任务阶段类2.NpcID = Buffer.ToInt16(array9, 2);
										任务阶段类2.难度系数 = Buffer.ToInt16(array9, 4);
										for (int n = 0; n < 10; n++)
										{
											byte[] array10 = new byte[12];
											System.Buffer.BlockCopy(array9, n * 12 + 6, array10, 0, 12);
											if (BitConverter.ToInt64(array10, 0) == 0L)
											{
												break;
											}
											任务阶段类2.阶段需要物品_.Add(n, new 阶段需要物品类
											{
												怪物ID = BitConverter.ToInt32(array10, 0),
												物品ID = BitConverter.ToInt32(array10, 4),
												物品总数 = BitConverter.ToInt16(array10, 8),
												实际需要数量 = BitConverter.ToInt16(array10, 10)
											});
										}
										for (int num2 = 0; num2 < 10; num2++)
										{
											byte[] array11 = new byte[8];
											System.Buffer.BlockCopy(array9, num2 * 8 + 126, array11, 0, 8);
											if (BitConverter.ToInt32(array11, 0) == 0)
											{
												break;
											}
											任务阶段类2.阶段奖励物品_.Add(num2, new 阶段奖励物品类
											{
												物品ID = BitConverter.ToInt32(array11, 0),
												物品数量 = BitConverter.ToInt32(array11, 4)
											});
										}
										byte[] array12 = new byte[14];
										System.Buffer.BlockCopy(array9, 206, array12, 0, 14);
										任务阶段类2.NPCNAME = Encoding.Default.GetString(array12).Replace("\0", string.Empty).Trim();
										任务阶段类2.Npc地图ID = Buffer.ToInt16(array9, 220);
										任务阶段类2.Npc坐标X = Buffer.ToInt32(array9, 222);
										任务阶段类2.Npc坐标Y = Buffer.ToInt32(array9, 226);
										byte[] array13 = new byte[300];
										System.Buffer.BlockCopy(array9, 230, array13, 0, 300);
										任务阶段类2.任务阶段内容 = Encoding.Default.GetString(array13).Replace("\0", string.Empty).Trim();
										任务类.任务阶段.Add(任务阶段类2);
									}
								}
								任务list.Add(任务类.RwID, 任务类);
							}
						}
						Form1.WriteLine(2, "加载任务数据新完成" + dBToDataTable.Rows.Count);
					}
					dBToDataTable.Dispose();
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "加载任务数据新出错,任务ID-" + num + "|" + ex.ToString());
			}
		}

		[SecureMethod]
		public void Set检查物品()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  *  FROM  XWWL_JC"), "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(2, "加载检查物品出错----没有检查物品数据");
			}
			else
			{
				物品检查.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					物品检查.Add(new 检查物品类
					{
						物品ID = (int)dBToDataTable.Rows[i]["FLD_PID"],
						物品类型 = (int)dBToDataTable.Rows[i]["FLD_TYPE"],
						FLD_MAGIC1 = (int)dBToDataTable.Rows[i]["FLD_MAGIC1"],
						FLD_MAGIC1_1 = dBToDataTable.Rows[i]["FLD_MAGIC1_1"].ToString(),
						FLD_MAGIC2 = (int)dBToDataTable.Rows[i]["FLD_MAGIC2"],
						FLD_MAGIC2_2 = dBToDataTable.Rows[i]["FLD_MAGIC2_2"].ToString(),
						FLD_MAGIC3 = (int)dBToDataTable.Rows[i]["FLD_MAGIC3"],
						FLD_MAGIC3_3 = dBToDataTable.Rows[i]["FLD_MAGIC3_3"].ToString(),
						FLD_MAGIC4 = (int)dBToDataTable.Rows[i]["FLD_MAGIC4"],
						FLD_MAGIC4_4 = dBToDataTable.Rows[i]["FLD_MAGIC4_4"].ToString(),
						FLD_MAGIC5 = (int)dBToDataTable.Rows[i]["FLD_MAGIC5"],
						FLD_MAGIC5_5 = dBToDataTable.Rows[i]["FLD_MAGIC5_5"].ToString()
					});
				}
				Form1.WriteLine(2, "加载检查物品数据完成" + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		public void Set制药物品()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT * FROM 制药物品列表 ORDER BY 物品ID"), "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(1, "加载制作物品完成----没有制作物品数据");
				return;
			}
			制药物品列表.Clear();
			for (int i = 0; i < dBToDataTable.Rows.Count; i++)
			{
				制药物品类 制药物品类 = new 制药物品类();
				try
				{
					制药物品类.物品ID = (int)dBToDataTable.Rows[i]["物品ID"];
					制药物品类.物品名 = dBToDataTable.Rows[i]["物品名"].ToString();
					制药物品类.物品数量 = (int)dBToDataTable.Rows[i]["物品数量"];
					string value = dBToDataTable.Rows[i]["需要物品"].ToString();
					制药物品类.需要物品 = JsonConvert.DeserializeObject<List<制药需要物品类>>(value);
					if (!制药物品列表.ContainsKey(制药物品类.物品ID))
					{
						制药物品列表.Add(制药物品类.物品ID, 制药物品类);
					}
				}
				catch (Exception ex)
				{
					Form1.WriteLine(1, "加载制药物品 错误" + 制药物品类.物品ID + "  " + ex.Message);
				}
			}
			Form1.WriteLine(2, "加载制药物品 " + dBToDataTable.Rows.Count);
		}

		[SecureMethod]
		public void Set移动()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  *  FROM  TBL_XWWL_MAP  WHERE  (X  IS  NOT  NULL)"), "PublicDb");
			if (dBToDataTable != null)
			{
				if (dBToDataTable.Rows.Count == 0)
				{
					Form1.WriteLine(2, "加载自定义移动出错----没有移动数据");
				}
				else
				{
					移动.Clear();
					for (int i = 0; i < dBToDataTable.Rows.Count; i++)
					{
						移动.Add(new 坐标Class
						{
							Rxjh_name = dBToDataTable.Rows[i]["FLD_NAME"].ToString(),
							Rxjh_Map = (int)dBToDataTable.Rows[i]["FLD_MID"],
							Rxjh_X = float.Parse(dBToDataTable.Rows[i]["X"].ToString()),
							Rxjh_Y = float.Parse(dBToDataTable.Rows[i]["Y"].ToString()),
							Rxjh_Z = 15f
						});
					}
					Form1.WriteLine(2, "加载自定义移动数据完成" + dBToDataTable.Rows.Count);
				}
				dBToDataTable.Dispose();
			}
			DataTable dBToDataTable2 = DBA.GetDBToDataTable(string.Format("SELECT  FLD_MID,FLD_NAME  FROM  TBL_XWWL_MAP"), "PublicDb");
			if (dBToDataTable2 == null)
			{
				return;
			}
			if (dBToDataTable2.Rows.Count == 0)
			{
				Form1.WriteLine(2, "加载自定义移动出错----没有移动数据");
			}
			else
			{
				Maplist.Clear();
				for (int j = 0; j < dBToDataTable2.Rows.Count; j++)
				{
					int key = (int)dBToDataTable2.Rows[j]["FLD_MID"];
					if (!Maplist.ContainsKey(key))
					{
						Maplist.Add(key, dBToDataTable2.Rows[j]["FLD_NAME"].ToString());
					}
				}
			}
			dBToDataTable2.Dispose();
		}

		[SecureMethod]
		public void SetLever()
		{
			lever.Clear();
			for (int i = 0; i < 256; i++)
			{
				if (i == 0)
				{
					lever.Add(0, 100.0);
				}
				else if (i <= 20)
				{
					lever.Add(i, lever[i - 1] * 1.3);
				}
				else if (i > 20 && i <= 40)
				{
					lever.Add(i, lever[i - 1] * 1.2);
				}
				else if (i > 40 && i <= 80)
				{
					lever.Add(i, lever[i - 1] * 1.17);
				}
				else if (i > 80)
				{
					lever.Add(i, lever[i - 1] * 1.1);
				}
			}
			Form1.WriteLine(2, "加载经验表完成");
		}

		[SecureMethod]
		public void SetMover()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  *  FROM  TBL_XWWL_VOME"), "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(2, "加载移动出错----没有移动数据");
			}
			else
			{
				Mover.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					Mover.Add(new MoveClass
					{
						MAP = (int)dBToDataTable.Rows[i]["MAP"],
						X = float.Parse(dBToDataTable.Rows[i]["X"].ToString()),
						Y = float.Parse(dBToDataTable.Rows[i]["Y"].ToString()),
						Z = float.Parse(dBToDataTable.Rows[i]["Z"].ToString()),
						ToMAP = (int)dBToDataTable.Rows[i]["ToMAP"],
						ToX = float.Parse(dBToDataTable.Rows[i]["ToX"].ToString()),
						ToY = float.Parse(dBToDataTable.Rows[i]["ToY"].ToString()),
						ToZ = float.Parse(dBToDataTable.Rows[i]["ToZ"].ToString())
					});
				}
				Form1.WriteLine(2, "加载移动数据完成" + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		[SecureMethod]
		public void SetKONGFU()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  *  FROM  TBL_XWWL_KONGFU"), "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(2, "加载武功出错----没有武功数据");
			}
			else
			{
				TBL_KONGFU.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					武功类 武功类 = new 武功类();
					武功类.FLD_NAME = dBToDataTable.Rows[i]["FLD_NAME"].ToString();
					武功类.FLD_AT = (int)dBToDataTable.Rows[i]["FLD_AT"];
					武功类.FLD_EFFERT = (int)dBToDataTable.Rows[i]["FLD_EFFERT"];
					武功类.FLD_INDEX = (int)dBToDataTable.Rows[i]["FLD_INDEX"];
					武功类.FLD_JOB = (int)dBToDataTable.Rows[i]["FLD_JOB"];
					武功类.FLD_JOBLEVEL = (int)dBToDataTable.Rows[i]["FLD_JOBLEVEL"];
					武功类.FLD_LEVEL = (int)dBToDataTable.Rows[i]["FLD_LEVEL"];
					武功类.FLD_MP = (int)dBToDataTable.Rows[i]["FLD_MP"];
					武功类.FLD_NEEDEXP = (int)dBToDataTable.Rows[i]["FLD_NEEDEXP"];
					武功类.FLD_PID = (int)dBToDataTable.Rows[i]["FLD_PID"];
					武功类.FLD_TYPE = (int)dBToDataTable.Rows[i]["FLD_TYPE"];
					武功类.FLD_ZX = (int)dBToDataTable.Rows[i]["FLD_ZX"];
					武功类.FLD_攻击数量 = (int)dBToDataTable.Rows[i]["FLD_攻击数量"];
					武功类.FLD_武功类型 = (int)dBToDataTable.Rows[i]["FLD_武功类型"];
					武功类.FLD_每级加MP = (int)dBToDataTable.Rows[i]["FLD_每级加MP"];
					武功类.FLD_每级加历练 = (int)dBToDataTable.Rows[i]["FLD_每级加历练"];
					武功类.FLD_每级危害 = dBToDataTable.Rows[i]["FLD_每级危害"].ToString();
					武功类.FLD_每级加危害 = (int)dBToDataTable.Rows[i]["FLD_每级加危害"];
					武功类.FLD_每级武功点数 = (int)dBToDataTable.Rows[i]["FLD_每级武功点数"];
					武功类.FLD_TIME = (int)dBToDataTable.Rows[i]["FLD_TIME"];
					武功类.FLD_DEATHTIME = (int)dBToDataTable.Rows[i]["FLD_DEATHTIME"];
					武功类.FLD_CDTIME = (int)dBToDataTable.Rows[i]["FLD_CDTIME"];
					武功类.FLD_武功最高级别 = (int)dBToDataTable.Rows[i]["FLD_武功最高级别"];
					武功类.FLD_每级加修炼等级 = (int)dBToDataTable.Rows[i]["FLD_每级加修炼等级"];
					TBL_KONGFU.Add(武功类.FLD_PID, 武功类);
				}
				Form1.WriteLine(2, "加载武功数据完成" + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		[SecureMethod]
		public static BbgSellClass 查询百宝物品(int int_0)
		{
			foreach (BbgSellClass value in 百宝阁数据.Values)
			{
				if (value.PID == int_0)
				{
					return value;
				}
			}
			return null;
		}

		[SecureMethod]
		public void SetBbgItem()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT * FROM ITEMSELL"), "BBG");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(1, "加载百宝阁物品----没有百宝阁数据");
			}
			else
			{
				百宝阁属性物品类list.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					百宝阁类 百宝阁类 = new 百宝阁类();
					百宝阁类.PID = (int)dBToDataTable.Rows[i]["FLD_PID"];
					百宝阁类.NAME = dBToDataTable.Rows[i]["FLD_NAME"].ToString();
					百宝阁类.PRICE = long.Parse(dBToDataTable.Rows[i]["FLD_PRICE"].ToString());
					百宝阁类.DESC = dBToDataTable.Rows[i]["FLD_DESC"].ToString();
					百宝阁类.TYPE = (int)dBToDataTable.Rows[i]["FLD_TYPE"];
					百宝阁类.RETURN = (int)dBToDataTable.Rows[i]["FLD_RETURN"];
					百宝阁类.NUMBER = (int)dBToDataTable.Rows[i]["FLD_NUMBER"];
					百宝阁类.MAGIC0 = (int)dBToDataTable.Rows[i]["FLD_MAGIC1"];
					百宝阁类.MAGIC1 = (int)dBToDataTable.Rows[i]["FLD_MAGIC2"];
					百宝阁类.MAGIC2 = (int)dBToDataTable.Rows[i]["FLD_MAGIC3"];
					百宝阁类.MAGIC3 = (int)dBToDataTable.Rows[i]["FLD_MAGIC4"];
					百宝阁类.MAGIC4 = (int)dBToDataTable.Rows[i]["FLD_MAGIC5"];
					百宝阁类.觉醒 = (int)dBToDataTable.Rows[i]["FLD_初级附魂"];
					百宝阁类.中级魂 = (int)dBToDataTable.Rows[i]["FLD_中级附魂"];
					百宝阁类.进化 = (int)dBToDataTable.Rows[i]["FLD_进化"];
					百宝阁类.绑定 = (int)dBToDataTable.Rows[i]["FLD_是否绑定"];
					百宝阁类.使用天数 = (int)dBToDataTable.Rows[i]["FLD_DAYS"];
					百宝阁属性物品类list.Add(百宝阁类.PID, 百宝阁类);
				}
				Form1.WriteLine(2, "加载百宝阁数据完成" + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		[SecureMethod]
		public void SetItme()
		{
			int num = 0;
			try
			{
				DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  *  FROM  TBL_XWWL_ITEM"), "PublicDb");
				if (dBToDataTable != null)
				{
					if (dBToDataTable.Rows.Count == 0)
					{
						Form1.WriteLine(2, "加载物品出错----没有物品数据");
					}
					else
					{
						PVP装备.Clear();
						Itme.Clear();
						for (int i = 0; i < dBToDataTable.Rows.Count; i++)
						{
							try
							{
								ItmeClass itmeClass = new ItmeClass();
								int num2 = (int)dBToDataTable.Rows[i]["FLD_NJ"];
								itmeClass.FLD_AT = (int)dBToDataTable.Rows[i]["FLD_AT1"];
								itmeClass.FLD_AT_Max = (int)dBToDataTable.Rows[i]["FLD_AT2"];
								itmeClass.FLD_DF = (int)dBToDataTable.Rows[i]["FLD_DF"];
								itmeClass.FLD_RESIDE1 = (int)dBToDataTable.Rows[i]["FLD_RESIDE1"];
								itmeClass.FLD_RESIDE2 = (int)dBToDataTable.Rows[i]["FLD_RESIDE2"];
								itmeClass.FLD_JOB_LEVEL = (int)dBToDataTable.Rows[i]["FLD_JOB_LEVEL"];
								itmeClass.FLD_LEVEL = (int)dBToDataTable.Rows[i]["FLD_LEVEL"];
								itmeClass.FLD_RECYCLE_MONEY = (int)dBToDataTable.Rows[i]["FLD_RECYCLE_MONEY"];
								itmeClass.FLD_SALE_MONEY = (int)dBToDataTable.Rows[i]["FLD_SALE_MONEY"];
								itmeClass.FLD_PID = int.Parse(dBToDataTable.Rows[i]["FLD_PID"].ToString());
								itmeClass.FLD_SEX = (int)dBToDataTable.Rows[i]["FLD_SEX"];
								itmeClass.FLD_WEIGHT = (int)dBToDataTable.Rows[i]["FLD_WEIGHT"];
								itmeClass.FLD_ZX = (int)dBToDataTable.Rows[i]["FLD_ZX"];
								itmeClass.FLD_SIDE = (int)dBToDataTable.Rows[i]["FLD_SIDE"];
								itmeClass.FLD_MAGIC0 = (int)dBToDataTable.Rows[i]["FLD_MAGIC1"];
								itmeClass.FLD_MAGIC1 = (int)dBToDataTable.Rows[i]["FLD_MAGIC2"];
								itmeClass.FLD_MAGIC2 = (int)dBToDataTable.Rows[i]["FLD_MAGIC3"];
								itmeClass.FLD_MAGIC3 = (int)dBToDataTable.Rows[i]["FLD_MAGIC4"];
								itmeClass.FLD_MAGIC4 = (int)dBToDataTable.Rows[i]["FLD_MAGIC5"];
								itmeClass.FLD_UP_LEVEL = (int)dBToDataTable.Rows[i]["FLD_UP_LEVEL"];
								itmeClass.FLD_XW = (int)dBToDataTable.Rows[i]["FLD_WX"];
								itmeClass.FLD_XWJD = (int)dBToDataTable.Rows[i]["FLD_WXJD"];
								itmeClass.FLD_TYPE = (int)dBToDataTable.Rows[i]["FLD_TYPE"];
								itmeClass.FLD_QUESTITEM = (int)dBToDataTable.Rows[i]["FLD_QUESTITEM"];
								itmeClass.ItmeNAME = dBToDataTable.Rows[i]["FLD_NAME"].ToString();
								itmeClass.FLD_NJ = num2;
								itmeClass.FLD_LOCK = (int)dBToDataTable.Rows[i]["FLD_LOCK"];
								itmeClass.FLD_NEED_MONEY = (int)dBToDataTable.Rows[i]["FLD_NEED_MONEY"];
								itmeClass.FLD_NEED_FIGHTEXP = (int)dBToDataTable.Rows[i]["FLD_NEED_FIGHTEXP"];
								itmeClass.FLD_INTEGRATION = (int)dBToDataTable.Rows[i]["FLD_INTEGRATION"];
								itmeClass.FLD_SERIES = (int)dBToDataTable.Rows[i]["FLD_SERIES"];
								num = itmeClass.FLD_PID;
								Itme.Add(itmeClass.FLD_PID, itmeClass);
								if (num2 == 1000)
								{
									PVP类 pVP类 = new PVP类();
									pVP类.物品ID = int.Parse(dBToDataTable.Rows[i]["FLD_PID"].ToString());
									pVP类.物品类型 = (int)dBToDataTable.Rows[i]["FLD_RESIDE2"];
									pVP类.物品等级 = (int)dBToDataTable.Rows[i]["FLD_LEVEL"];
									PVP装备.Add(pVP类.物品ID, pVP类);
								}
							}
							catch (Exception ex)
							{
								Form1.WriteLine(1, num + "|" + ex.Message);
							}
						}
						Form1.WriteLine(2, "加载物品数据完成" + dBToDataTable.Rows.Count);
					}
					dBToDataTable.Dispose();
				}
			}
			catch (Exception ex2)
			{
				Form1.WriteLine(1, num + "|" + ex2.Message);
			}
		}

		[SecureMethod]
		public void SetShop()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  *  FROM  TBL_XWWL_SELL  ORDER  BY  FLD_INDEX"), "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(2, "加载物品商店----没有物品数据");
			}
			else
			{
				Shop.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					Shop.Add(new ShopClass
					{
						FLD_NID = int.Parse(dBToDataTable.Rows[i]["FLD_NID"].ToString()),
						FLD_INDEX = (int)dBToDataTable.Rows[i]["FLD_INDEX"],
						FLD_PID = int.Parse(dBToDataTable.Rows[i]["FLD_PID"].ToString()),
						FLD_MONEY = long.Parse(dBToDataTable.Rows[i]["FLD_MONEY"].ToString()),
						FLD_MAGIC0 = (int)dBToDataTable.Rows[i]["FLD_MAGIC0"],
						FLD_MAGIC1 = (int)dBToDataTable.Rows[i]["FLD_MAGIC1"],
						FLD_MAGIC2 = (int)dBToDataTable.Rows[i]["FLD_MAGIC2"],
						FLD_MAGIC3 = (int)dBToDataTable.Rows[i]["FLD_MAGIC3"],
						FLD_MAGIC4 = (int)dBToDataTable.Rows[i]["FLD_MAGIC4"],
						需要武勋 = (int)dBToDataTable.Rows[i]["FLD_需要武勋"]
					});
				}
				Form1.WriteLine(2, "加载物品商店完成" + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		public void Set制作物品()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  *  FROM  制作物品列表  ORDER  BY  物品ID"), "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(2, "加载制作物品完成----没有制作物品数据");
				return;
			}
			制作物品列表.Clear();
			for (int i = 0; i < dBToDataTable.Rows.Count; i++)
			{
				制作物品类 制作物品类 = new 制作物品类();
				try
				{
					制作物品类.物品ID = (int)dBToDataTable.Rows[i]["物品ID"];
					制作物品类.物品名 = dBToDataTable.Rows[i]["物品名"].ToString();
					制作物品类.物品数量 = (int)dBToDataTable.Rows[i]["物品数量"];
					制作物品类.制作类型 = (int)dBToDataTable.Rows[i]["制作类型"];
					制作物品类.制作等级 = (int)dBToDataTable.Rows[i]["制作等级"];
					string[] array = dBToDataTable.Rows[i]["需要物品"].ToString().Split('|');
					制作物品类.需要物品.Clear();
					for (int j = 0; j < array.Length; j++)
					{
						string[] array2 = array[j].Split(',');
						制作物品类.需要物品.Add(new 制作需要物品类
						{
							Id = int.Parse(array2[0]),
							number = int.Parse(array2[1])
						});
					}
					if (!制作物品列表.ContainsKey(制作物品类.物品ID))
					{
						制作物品列表.Add(制作物品类.物品ID, 制作物品类);
					}
				}
				catch (Exception ex)
				{
					Form1.WriteLine(1, "加载制作物品  错误" + 制作物品类.物品ID + "    " + ex.Message);
				}
			}
		}

		[SecureMethod]
		public void SetDrop()
		{
			try
			{
				DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  *  FROM  TBL_XWWL_DROP  ORDER  BY  FLD_LEVEL1,  FLD_LEVEL2"), "PublicDb");
				if (dBToDataTable != null)
				{
					if (dBToDataTable.Rows.Count == 0)
					{
						Form1.WriteLine(2, "加载掉落物品完成----没有物品数据");
					}
					else
					{
						Drop.Clear();
						for (int i = 0; i < dBToDataTable.Rows.Count; i++)
						{
							DropClass dropClass = new DropClass();
							try
							{
								dropClass.FLD_LEVEL1 = (int)dBToDataTable.Rows[i]["FLD_LEVEL1"];
								dropClass.FLD_LEVEL2 = (int)dBToDataTable.Rows[i]["FLD_LEVEL2"];
								dropClass.FLD_PID = (int)dBToDataTable.Rows[i]["FLD_PID"];
								dropClass.FLD_PIDNew = (int)dBToDataTable.Rows[i]["FLD_PID"];
								dropClass.FLD_PP = (int)dBToDataTable.Rows[i]["FLD_PP"];
								dropClass.FLD_NAME = dBToDataTable.Rows[i]["FLD_NAME"].ToString();
								dropClass.FLD_MAGIC0 = (int)dBToDataTable.Rows[i]["FLD_MAGIC0"];
								dropClass.FLD_MAGIC1 = (int)dBToDataTable.Rows[i]["FLD_MAGIC1"];
								dropClass.FLD_MAGIC2 = (int)dBToDataTable.Rows[i]["FLD_MAGIC2"];
								dropClass.FLD_MAGIC3 = (int)dBToDataTable.Rows[i]["FLD_MAGIC3"];
								dropClass.FLD_MAGIC4 = (int)dBToDataTable.Rows[i]["FLD_MAGIC4"];
								dropClass.FLD_初级附魂 = (int)dBToDataTable.Rows[i]["FLD_初级附魂"];
								dropClass.FLD_中级附魂 = (int)dBToDataTable.Rows[i]["FLD_中级附魂"];
								dropClass.FLD_进化 = (int)dBToDataTable.Rows[i]["FLD_进化"];
								dropClass.FLD_绑定 = (int)dBToDataTable.Rows[i]["FLD_绑定"];
								dropClass.FLD_MAGICNew0 = (int)dBToDataTable.Rows[i]["FLD_MAGIC0"];
								dropClass.FLD_MAGICNew1 = (int)dBToDataTable.Rows[i]["FLD_MAGIC1"];
								dropClass.FLD_MAGICNew2 = (int)dBToDataTable.Rows[i]["FLD_MAGIC2"];
								dropClass.FLD_MAGICNew3 = (int)dBToDataTable.Rows[i]["FLD_MAGIC3"];
								dropClass.FLD_MAGICNew4 = (int)dBToDataTable.Rows[i]["FLD_MAGIC4"];
								dropClass.是否开启公告 = (int)dBToDataTable.Rows[i]["是否开启公告"];
								try
								{
									if (dBToDataTable.Rows[0]["FLD_SUNX"] != DBNull.Value && dBToDataTable.Rows[i]["FLD_SUNX"].ToString().Length != 0)
									{
										string value = dBToDataTable.Rows[i]["FLD_SUNX"].ToString();
										dropClass.DropShuX = JsonConvert.DeserializeObject<List<DropShuXClass>>(value);
									}
								}
								catch
								{
								}
								Drop.Add(dropClass);
							}
							catch (Exception ex)
							{
								Form1.WriteLine(1, "加载掉落物品  错误" + dropClass.FLD_NAME + "    " + ex.Message);
							}
						}
						Form1.WriteLine(2, "加载掉落物品  " + dBToDataTable.Rows.Count);
					}
					dBToDataTable.Dispose();
				}
			}
			catch (Exception ex2)
			{
				Form1.WriteLine(1, "加载掉落物品  错误" + ex2.Message);
			}
		}

		[SecureMethod]
		public void Set_GSDrop()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  *  FROM  TBL_XWWL_DROP_GS  ORDER  BY  FLD_LEVEL1,  FLD_LEVEL2"), "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				BossDrop.Clear();
				Form1.WriteLine(2, "加载高手怪掉落物品完成----没有物品数据");
			}
			else
			{
				Drop_GS.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					DropClass dropClass = new DropClass();
					try
					{
						dropClass.FLD_LEVEL1 = (int)dBToDataTable.Rows[i]["FLD_LEVEL1"];
						dropClass.FLD_LEVEL2 = (int)dBToDataTable.Rows[i]["FLD_LEVEL2"];
						dropClass.FLD_PID = (int)dBToDataTable.Rows[i]["FLD_PID"];
						dropClass.FLD_PP = (int)dBToDataTable.Rows[i]["FLD_PP"];
						dropClass.FLD_PIDNew = (int)dBToDataTable.Rows[i]["FLD_PID"];
						dropClass.FLD_NAME = dBToDataTable.Rows[i]["FLD_NAME"].ToString();
						dropClass.FLD_MAGIC0 = (int)dBToDataTable.Rows[i]["FLD_MAGIC0"];
						dropClass.FLD_MAGIC1 = (int)dBToDataTable.Rows[i]["FLD_MAGIC1"];
						dropClass.FLD_MAGIC2 = (int)dBToDataTable.Rows[i]["FLD_MAGIC2"];
						dropClass.FLD_MAGIC3 = (int)dBToDataTable.Rows[i]["FLD_MAGIC3"];
						dropClass.FLD_MAGIC4 = (int)dBToDataTable.Rows[i]["FLD_MAGIC4"];
						dropClass.FLD_初级附魂 = (int)dBToDataTable.Rows[i]["FLD_初级附魂"];
						dropClass.FLD_中级附魂 = (int)dBToDataTable.Rows[i]["FLD_中级附魂"];
						dropClass.FLD_进化 = (int)dBToDataTable.Rows[i]["FLD_进化"];
						dropClass.FLD_绑定 = (int)dBToDataTable.Rows[i]["FLD_绑定"];
						dropClass.FLD_MAGICNew0 = (int)dBToDataTable.Rows[i]["FLD_MAGIC0"];
						dropClass.FLD_MAGICNew1 = (int)dBToDataTable.Rows[i]["FLD_MAGIC1"];
						dropClass.FLD_MAGICNew2 = (int)dBToDataTable.Rows[i]["FLD_MAGIC2"];
						dropClass.FLD_MAGICNew3 = (int)dBToDataTable.Rows[i]["FLD_MAGIC3"];
						dropClass.FLD_MAGICNew4 = (int)dBToDataTable.Rows[i]["FLD_MAGIC4"];
						dropClass.是否开启公告 = (int)dBToDataTable.Rows[i]["是否开启公告"];
						try
						{
							if (dBToDataTable.Rows[0]["FLD_SUNX"] != DBNull.Value && dBToDataTable.Rows[i]["FLD_SUNX"].ToString().Length != 0)
							{
								string value = dBToDataTable.Rows[i]["FLD_SUNX"].ToString();
								dropClass.DropShuX = JsonConvert.DeserializeObject<List<DropShuXClass>>(value);
							}
						}
						catch
						{
						}
						Drop_GS.Add(dropClass);
					}
					catch (Exception ex)
					{
						Form1.WriteLine(1, "加载掉落物品  错误" + dropClass.FLD_NAME + "    " + ex.Message);
					}
				}
				Form1.WriteLine(2, "加载高手怪落物品  " + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		[SecureMethod]
		public void SetBossDrop()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  *  FROM  TBL_XWWL_BossDROP  ORDER  BY  FLD_LEVEL1,  FLD_LEVEL2"), "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				BossDrop.Clear();
				Form1.WriteLine(2, "加载BOSS掉落物品完成----没有物品数据");
			}
			else
			{
				BossDrop.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					DropClass dropClass = new DropClass();
					try
					{
						dropClass.FLD_LEVEL1 = (int)dBToDataTable.Rows[i]["FLD_LEVEL1"];
						dropClass.FLD_LEVEL2 = (int)dBToDataTable.Rows[i]["FLD_LEVEL2"];
						dropClass.FLD_PID = (int)dBToDataTable.Rows[i]["FLD_PID"];
						dropClass.FLD_PIDNew = (int)dBToDataTable.Rows[i]["FLD_PID"];
						dropClass.FLD_PP = (int)dBToDataTable.Rows[i]["FLD_PP"];
						dropClass.FLD_NAME = dBToDataTable.Rows[i]["FLD_NAME"].ToString();
						dropClass.FLD_MAGIC0 = (int)dBToDataTable.Rows[i]["FLD_MAGIC0"];
						dropClass.FLD_MAGIC1 = (int)dBToDataTable.Rows[i]["FLD_MAGIC1"];
						dropClass.FLD_MAGIC2 = (int)dBToDataTable.Rows[i]["FLD_MAGIC2"];
						dropClass.FLD_MAGIC3 = (int)dBToDataTable.Rows[i]["FLD_MAGIC3"];
						dropClass.FLD_MAGIC4 = (int)dBToDataTable.Rows[i]["FLD_MAGIC4"];
						dropClass.FLD_初级附魂 = (int)dBToDataTable.Rows[i]["FLD_初级附魂"];
						dropClass.FLD_中级附魂 = (int)dBToDataTable.Rows[i]["FLD_中级附魂"];
						dropClass.FLD_进化 = (int)dBToDataTable.Rows[i]["FLD_进化"];
						dropClass.FLD_绑定 = (int)dBToDataTable.Rows[i]["FLD_绑定"];
						dropClass.FLD_MAGICNew0 = (int)dBToDataTable.Rows[i]["FLD_MAGIC0"];
						dropClass.FLD_MAGICNew1 = (int)dBToDataTable.Rows[i]["FLD_MAGIC1"];
						dropClass.FLD_MAGICNew2 = (int)dBToDataTable.Rows[i]["FLD_MAGIC2"];
						dropClass.FLD_MAGICNew3 = (int)dBToDataTable.Rows[i]["FLD_MAGIC3"];
						dropClass.FLD_MAGICNew4 = (int)dBToDataTable.Rows[i]["FLD_MAGIC4"];
						dropClass.是否开启公告 = (int)dBToDataTable.Rows[i]["是否开启公告"];
						try
						{
							if (dBToDataTable.Rows[0]["FLD_SUNX"] != DBNull.Value && dBToDataTable.Rows[i]["FLD_SUNX"].ToString().Length != 0)
							{
								string value = dBToDataTable.Rows[i]["FLD_SUNX"].ToString();
								dropClass.DropShuX = JsonConvert.DeserializeObject<List<DropShuXClass>>(value);
							}
						}
						catch
						{
						}
						BossDrop.Add(dropClass);
					}
					catch (Exception ex)
					{
						Form1.WriteLine(1, "加载掉落物品  错误" + dropClass.FLD_NAME + "    " + ex.Message);
					}
				}
				Form1.WriteLine(2, "加载BOSS掉落物品  " + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		[SecureMethod]
		public void SetOpen()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  *  FROM  TBL_XWWL_OPEN"), "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(2, "加载开箱物品完成----没有开箱物品数据");
			}
			else
			{
				Open.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					Open.Add(new OpenClass
					{
						FLD_PID = (int)dBToDataTable.Rows[i]["FLD_PID"],
						FLD_PIDX = (int)dBToDataTable.Rows[i]["FLD_PIDX"],
						FLD_NUMBER = (int)dBToDataTable.Rows[i]["FLD_NUMBER"],
						FLD_MAGIC1 = (int)dBToDataTable.Rows[i]["FLD_MAGIC1"],
						FLD_MAGIC2 = (int)dBToDataTable.Rows[i]["FLD_MAGIC2"],
						FLD_MAGIC3 = (int)dBToDataTable.Rows[i]["FLD_MAGIC3"],
						FLD_MAGIC4 = (int)dBToDataTable.Rows[i]["FLD_MAGIC4"],
						FLD_MAGIC5 = (int)dBToDataTable.Rows[i]["FLD_MAGIC5"],
						FLD_觉醒 = (int)dBToDataTable.Rows[i]["FLD_FJ_觉醒"],
						FLD_进化 = (int)dBToDataTable.Rows[i]["FLD_FJ_进化"],
						FLD_中级附魂 = (int)dBToDataTable.Rows[i]["FLD_FJ_中级附魂"],
						FLD_BD = (int)dBToDataTable.Rows[i]["FLD_BD"],
						FLD_DAYS = (int)dBToDataTable.Rows[i]["FLD_DAYS"],
						FLD_PP = (int)dBToDataTable.Rows[i]["FLD_PP"],
						FLD_NAME = dBToDataTable.Rows[i]["FLD_NAME"].ToString(),
						FLD_NAMEX = dBToDataTable.Rows[i]["FLD_NAMEX"].ToString()
					});
				}
				Form1.WriteLine(2, "加载开箱物品  " + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		public void 荣誉门派排行()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT TOP 10  * FROM 荣誉门派排行 where FLD_FQ='" + 分区编号 + "' Order By FLD_RY Desc"), "GameServer");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				门派排名数据.Clear();
				Form1.WriteLine(1, "加载荣誉武林排行----没有荣誉门派排行数据");
			}
			else
			{
				门派排名数据.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					门派排名 item = new 门派排名
					{
						门派帮派名 = dBToDataTable.Rows[i]["FLD_BP"].ToString(),
						门派人物名 = dBToDataTable.Rows[i]["FLD_NAME"].ToString(),
						门派正邪 = (int)dBToDataTable.Rows[i]["FLD_ZX"],
						门派职业 = (int)dBToDataTable.Rows[i]["FLD_JOB"],
						门派转职 = (int)dBToDataTable.Rows[i]["FLD_JOB_LEVEL"],
						门派人物等级 = (int)dBToDataTable.Rows[i]["FLD_LEVEL"],
						门派荣誉点 = (int)dBToDataTable.Rows[i]["FLD_RY"],
						门派分区ID = dBToDataTable.Rows[i]["FLD_FQ"].ToString()
					};
					门派排名数据.Add(item);
				}
			}
			dBToDataTable.Dispose();
		}

		[SecureMethod]
		public void Set套装()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  *  FROM  ITMECLSS"), "WebDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(2, "加载套装物品完成----没有套装物品数据");
			}
			else
			{
				套装数据.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					套装数据.Add(new ItemSellClass
					{
						ID = (int)dBToDataTable.Rows[i]["ID"],
						Type = (int)dBToDataTable.Rows[i]["FLD_TYPE"],
						Reside = (int)dBToDataTable.Rows[i]["FLD_RESIDE"],
						name = dBToDataTable.Rows[i]["FLD_NAME"].ToString(),
						sql = dBToDataTable.Rows[i]["FLD_SQL"].ToString(),
						Magic0 = (int)dBToDataTable.Rows[i]["FLD_MAGIC0"],
						Magic1 = (int)dBToDataTable.Rows[i]["FLD_MAGIC1"],
						Magic2 = (int)dBToDataTable.Rows[i]["FLD_MAGIC2"],
						Magic3 = (int)dBToDataTable.Rows[i]["FLD_MAGIC3"],
						Magic4 = (int)dBToDataTable.Rows[i]["FLD_MAGIC4"],
						Magic5 = (int)dBToDataTable.Rows[i]["FLD_MAGIC5"],
						NJ = (int)dBToDataTable.Rows[i]["FLD_FJ_NJ"],
						DAYS = (int)dBToDataTable.Rows[i]["FLD_DAYS"],
						进化 = (int)dBToDataTable.Rows[i]["FLD_FJ_进化"],
						觉醒 = (int)dBToDataTable.Rows[i]["FLD_FJ_觉醒"],
						中级附魂 = (int)dBToDataTable.Rows[i]["FLD_FJ_中级附魂"],
						BD = (int)dBToDataTable.Rows[i]["FLD_BD"]
					});
				}
				Form1.WriteLine(2, "加载套装物品  " + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		[SecureMethod]
		public void Set升天气功()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  *  FROM  升天气功  ORDER  BY  气功ID"), "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(2, "加载升天气功完成----没有升天气功数据");
			}
			else
			{
				升天气功List.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					升天气功总类 升天气功总类 = new 升天气功总类();
					升天气功总类.气功ID = (int)dBToDataTable.Rows[i]["气功ID"];
					升天气功总类.气功名 = dBToDataTable.Rows[i]["气功名"].ToString();
					升天气功总类.物品ID = (int)dBToDataTable.Rows[i]["物品ID"];
					升天气功总类.人物职业1 = (int)dBToDataTable.Rows[i]["人物职业1"];
					升天气功总类.人物职业2 = (int)dBToDataTable.Rows[i]["人物职业2"];
					升天气功总类.人物职业3 = (int)dBToDataTable.Rows[i]["人物职业3"];
					升天气功总类.人物职业4 = (int)dBToDataTable.Rows[i]["人物职业4"];
					升天气功总类.人物职业5 = (int)dBToDataTable.Rows[i]["人物职业5"];
					升天气功总类.人物职业6 = (int)dBToDataTable.Rows[i]["人物职业6"];
					升天气功总类.人物职业7 = (int)dBToDataTable.Rows[i]["人物职业7"];
					升天气功总类.人物职业8 = (int)dBToDataTable.Rows[i]["人物职业8"];
					升天气功总类.人物职业9 = (int)dBToDataTable.Rows[i]["人物职业9"];
					升天气功总类.人物职业10 = (int)dBToDataTable.Rows[i]["人物职业10"];
					升天气功总类.人物职业11 = (int)dBToDataTable.Rows[i]["人物职业11"];
					升天气功总类.人物职业12 = (int)dBToDataTable.Rows[i]["人物职业12"];
					升天气功总类.人物职业13 = (int)dBToDataTable.Rows[i]["人物职业13"];
					升天气功总类.FLD_每点加成比率值 = (double)dBToDataTable.Rows[i]["FLD_每点加成比率值"];
					升天气功List.Add(升天气功总类.气功ID, 升天气功总类);
				}
				Form1.WriteLine(2, "加载升天气功  " + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		[SecureMethod]
		public void SetMonSter()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  *  FROM  TBL_XWWL_MONSTER"), "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(2, "加载怪物数据完成----没有怪物数据");
			}
			else
			{
				MonSter.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					try
					{
						MonSterClss monSterClss = new MonSterClss();
						monSterClss.FLD_PID = (int)dBToDataTable.Rows[i]["FLD_PID"];
						monSterClss.FLD_AT = (int)dBToDataTable.Rows[i]["FLD_AT"];
						monSterClss.FLD_AUTO = (int)dBToDataTable.Rows[i]["FLD_AUTO"];
						monSterClss.FLD_BOSS = (int)dBToDataTable.Rows[i]["FLD_BOSS"];
						monSterClss.FLD_DF = (int)dBToDataTable.Rows[i]["FLD_DF"];
						monSterClss.Level = (int)dBToDataTable.Rows[i]["FLD_LEVEL"];
						monSterClss.Name = dBToDataTable.Rows[i]["FLD_NAME"].ToString();
						monSterClss.Rxjh_Exp = (int)dBToDataTable.Rows[i]["FLD_EXP"];
						monSterClss.Rxjh_HP = (int)dBToDataTable.Rows[i]["FLD_HP"];
						monSterClss.FLD_NPC = (int)dBToDataTable.Rows[i]["FLD_NPC"];
						monSterClss.FLD_QUEST = (int)dBToDataTable.Rows[i]["FLD_QUEST"];
						monSterClss.FLD_QUESTID = (int)dBToDataTable.Rows[i]["FLD_QUESTID"];
						monSterClss.FLD_STAGES = (int)dBToDataTable.Rows[i]["FLD_STAGES"];
						monSterClss.FLD_QUESTITEM = (int)dBToDataTable.Rows[i]["FLD_QUESTITEM"];
						monSterClss.FLD_PP = (int)dBToDataTable.Rows[i]["FLD_PP"];
						MonSter.Add(monSterClss.FLD_PID, monSterClss);
						if (Map != null && Map.Count > 0)
						{
							foreach (MapClass value in Map.Values)
							{
								foreach (NpcClass value2 in value.npcTemplate.Values)
								{
									if (value2.FLD_PID == monSterClss.FLD_PID)
									{
										value2.FLD_AT = monSterClss.FLD_AT;
										value2.FLD_DF = monSterClss.FLD_AT;
										value2.Rxjh_Exp = monSterClss.Rxjh_Exp;
										value2.FLD_AUTO = monSterClss.FLD_AUTO;
										value2.FLD_BOSS = monSterClss.FLD_BOSS;
										value2.Level = monSterClss.Level;
										value2.Rxjh_HP = monSterClss.Rxjh_HP;
									}
								}
							}
						}
					}
					catch (Exception ex)
					{
						Form1.WriteLine(1, "加载怪物数据  出错：" + ((ex != null) ? ex.ToString() : null));
					}
				}
				Form1.WriteLine(2, "加载怪物数据完成  " + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		[SecureMethod]
		public void SetNpc()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  *  FROM  TBL_XWWL_NPC"), "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(2, "加载NPC数据出错----没有NPC数据");
			}
			else
			{
				Map.Clear();
				NpcList.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					try
					{
						NpcClass npcClass = new NpcClass();
						npcClass.FLD_PID = (int)dBToDataTable.Rows[i]["FLD_PID"];
						MonSterClss value;
						if (MonSter.TryGetValue(npcClass.FLD_PID, out value) && npcClass.FLD_PID >= 10000)
						{
							npcClass.Name = value.Name;
							npcClass.Level = value.Level;
							npcClass.Rxjh_Exp = value.Rxjh_Exp;
							npcClass.IsNpc = value.FLD_NPC;
							npcClass.Max_Rxjh_HP = value.Rxjh_HP;
							npcClass.Rxjh_HP = value.Rxjh_HP;
							npcClass.FLD_AT = value.FLD_AT;
							npcClass.FLD_DF = value.FLD_DF;
							npcClass.FLD_AUTO = value.FLD_AUTO;
							npcClass.FLD_BOSS = value.FLD_BOSS;
							npcClass.FLD_NEWTIME = (int)dBToDataTable.Rows[i]["FLD_NEWTIME"];
						}
						else
						{
							npcClass.Name = dBToDataTable.Rows[i]["FLD_NAME"].ToString();
							npcClass.Level = 0;
							npcClass.Rxjh_Exp = 0;
							npcClass.IsNpc = 1;
							npcClass.Max_Rxjh_HP = 32000;
							npcClass.Rxjh_HP = 32000;
							npcClass.FLD_AT = 0.0;
							npcClass.FLD_DF = 0.0;
							npcClass.FLD_AUTO = 0;
							npcClass.FLD_BOSS = 0;
							npcClass.FLD_NEWTIME = 0;
						}
						npcClass.Rxjh_Map = (int)dBToDataTable.Rows[i]["FLD_MID"];
						npcClass.FLD_FACE1 = float.Parse(dBToDataTable.Rows[i]["FLD_FACE0"].ToString());
						npcClass.FLD_FACE2 = float.Parse(dBToDataTable.Rows[i]["FLD_FACE"].ToString());
						npcClass.Rxjh_X = float.Parse(dBToDataTable.Rows[i]["FLD_X"].ToString());
						npcClass.Rxjh_Y = float.Parse(dBToDataTable.Rows[i]["FLD_Y"].ToString());
						npcClass.Rxjh_Z = float.Parse(dBToDataTable.Rows[i]["FLD_Z"].ToString());
						npcClass.Rxjh_cs_X = float.Parse(dBToDataTable.Rows[i]["FLD_X"].ToString());
						npcClass.Rxjh_cs_Y = float.Parse(dBToDataTable.Rows[i]["FLD_Y"].ToString());
						npcClass.Rxjh_cs_Z = float.Parse(dBToDataTable.Rows[i]["FLD_Z"].ToString());
						MapClass value2;
						if (Map.TryGetValue(npcClass.Rxjh_Map, out value2))
						{
							value2.add(npcClass);
						}
						else
						{
							value2 = new MapClass();
							value2.MapID = npcClass.Rxjh_Map;
							value2.add(npcClass);
							Map.Add(value2.MapID, value2);
						}
						if (npcClass.FLD_PID >= 10000)
						{
							try
							{
								if (!NpcList.ContainsKey(npcClass.FLD_PID))
								{
									NpcList.Add(npcClass.FLD_PID, npcClass);
								}
							}
							catch
							{
								continue;
							}
						}
						if (npcClass.IsNpc == 1 && npcClass.FLD_PID != 5)
						{
							npcClass.自动移动.Enabled = false;
							npcClass.自动移动.Close();
							npcClass.自动移动.Dispose();
							npcClass.自动移动 = null;
							npcClass.自动攻击.Enabled = false;
							npcClass.自动攻击.Close();
							npcClass.自动攻击.Dispose();
							npcClass.自动攻击 = null;
							if (npcClass.自动复活 != null)
							{
								npcClass.自动复活.Enabled = false;
							}
						}
					}
					catch (Exception ex)
					{
						Form1.WriteLine(1, "加载NPC数据  出错：" + ((ex != null) ? ex.ToString() : null));
					}
				}
				Form1.WriteLine(2, "加载NPC数据完成  " + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		[SecureMethod]
		public static void delNpc(int int_0, int int_1)
		{
			try
			{
				List<NpcClass> list = new List<NpcClass>();
				foreach (NpcClass value in MapClass.GetnpcTemplate(int_0).Values)
				{
					if (value.FLD_PID == int_1)
					{
						list.Add(value);
					}
				}
				if (list != null)
				{
					foreach (NpcClass item in list)
					{
						item.Dispose();
					}
					list.Clear();
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(2, "删除怪  [" + int_1 + "]出错：" + ((ex != null) ? ex.ToString() : null));
			}
		}

		[SecureMethod]
		public static void delBoss(int int_0, int int_1)
		{
			try
			{
				List<NpcClass> list = new List<NpcClass>();
				foreach (NpcClass value in MapClass.GetnpcTemplate(int_0).Values)
				{
					if (value.FLD_PID == int_1)
					{
						list.Add(value);
					}
				}
				if (list != null)
				{
					foreach (NpcClass item in list)
					{
						item.发送怪物一次性死亡数据();
					}
					list.Clear();
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(2, "删除怪  [" + int_1 + "]出错：" + ((ex != null) ? ex.ToString() : null));
			}
		}

		[SecureMethod]
		public static void AddNpc(int int_0, float float_0, float float_1, int int_1)
		{
			try
			{
				MonSterClss value;
				if (MonSter.TryGetValue(int_0, out value))
				{
					NpcClass npcClass = new NpcClass();
					npcClass.FLD_PID = value.FLD_PID;
					npcClass.Name = value.Name;
					npcClass.Level = value.Level;
					npcClass.Rxjh_Exp = value.Rxjh_Exp;
					npcClass.Rxjh_X = float_0;
					npcClass.Rxjh_Y = float_1;
					npcClass.Rxjh_Z = 15f;
					npcClass.Rxjh_cs_X = float_0;
					npcClass.Rxjh_cs_Y = float_1;
					npcClass.Rxjh_cs_Z = 15f;
					npcClass.Rxjh_Map = int_1;
					npcClass.IsNpc = 0;
					npcClass.FLD_FACE1 = 0f;
					npcClass.FLD_FACE2 = 0f;
					npcClass.Max_Rxjh_HP = value.Rxjh_HP;
					npcClass.Rxjh_HP = value.Rxjh_HP;
					npcClass.FLD_AT = value.FLD_AT;
					npcClass.FLD_DF = value.FLD_DF;
					npcClass.FLD_AUTO = value.FLD_AUTO;
					npcClass.FLD_BOSS = ((int_1 == 101 || int_1 == 801) ? 1 : value.FLD_BOSS);
					npcClass.FLD_NEWTIME = 10;
					npcClass.一次性怪 = true;
					MapClass value2;
					if (Map.TryGetValue(npcClass.Rxjh_Map, out value2))
					{
						value2.add(npcClass);
					}
					else
					{
						MapClass mapClass = new MapClass();
						mapClass.MapID = npcClass.Rxjh_Map;
						mapClass.add(npcClass);
						Map.Add(mapClass.MapID, mapClass);
					}
					npcClass.获取范围玩家发送增加数据包();
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(2, "增加怪  [" + int_0 + "]出错：" + ((ex != null) ? ex.ToString() : null));
			}
		}

		public static void 添加天魔怪物(int int_0, float float_0, float float_1, int int_1, int int_2)
		{
			try
			{
				MonSterClss value;
				if (MonSter.TryGetValue(int_0, out value))
				{
					NpcClass npcClass = new NpcClass();
					npcClass.FLD_PID = value.FLD_PID;
					npcClass.Name = value.Name;
					npcClass.Level = value.Level;
					npcClass.Rxjh_Exp = value.Rxjh_Exp;
					npcClass.Rxjh_X = float_0;
					npcClass.Rxjh_Y = float_1;
					npcClass.Rxjh_Z = 15f;
					npcClass.Rxjh_cs_X = float_0;
					npcClass.Rxjh_cs_Y = float_1;
					npcClass.Rxjh_cs_Z = 15f;
					npcClass.Rxjh_Map = int_1;
					npcClass.IsNpc = 0;
					if (int_0 == 16431)
					{
						npcClass.FLD_FACE1 = -1f;
						npcClass.FLD_FACE2 = 0f;
					}
					else
					{
						npcClass.FLD_FACE1 = 0f;
						npcClass.FLD_FACE2 = 0f;
					}
					npcClass.Max_Rxjh_HP = value.Rxjh_HP;
					npcClass.Rxjh_HP = value.Rxjh_HP;
					npcClass.FLD_AT = value.FLD_AT;
					npcClass.FLD_DF = value.FLD_DF;
					npcClass.FLD_AUTO = int_2;
					npcClass.FLD_BOSS = value.FLD_BOSS;
					npcClass.一次性怪 = true;
					MapClass value2;
					if (Map.TryGetValue(npcClass.Rxjh_Map, out value2))
					{
						value2.add(npcClass);
					}
					else
					{
						MapClass mapClass = new MapClass();
						mapClass.MapID = npcClass.Rxjh_Map;
						mapClass.add(npcClass);
						Map.Add(mapClass.MapID, mapClass);
					}
					npcClass.获取范围玩家发送增加数据包();
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(2, "增加怪 [" + int_0 + "]出错：" + ((ex != null) ? ex.ToString() : null));
			}
		}

		public static void 天魔神宫雕像击杀添加怪物()
		{
			天魔神宫大门是否死亡 = 0;
			delNpc(42101, 16431);
			Thread.Sleep(500);
			delNpc(42101, 16430);
			Thread.Sleep(1000);
			添加天魔怪物(16430, -430f, -393f, 42101, 0);
			Thread.Sleep(1000);
			添加天魔怪物(16431, 57f, 470f, 42101, 0);
			Thread.Sleep(1000);
			添加天魔怪物(16435, -435f, 523f, 42101, 0);
		}

		[SecureMethod]
		public static void AddNpc(int int_0, float float_0, float float_1, int int_1, int int_2, int int_3, bool bool_0, int int_4)
		{
			try
			{
				MonSterClss value;
				if (MonSter.TryGetValue(int_0, out value))
				{
					NpcClass npcClass = new NpcClass();
					npcClass.FLD_PID = value.FLD_PID;
					npcClass.Name = value.Name;
					npcClass.Level = value.Level;
					npcClass.Rxjh_Exp = value.Rxjh_Exp;
					npcClass.Rxjh_X = float_0;
					npcClass.Rxjh_Y = float_1;
					npcClass.Rxjh_Z = 15f;
					npcClass.Rxjh_cs_X = float_0;
					npcClass.Rxjh_cs_Y = float_1;
					npcClass.Rxjh_cs_Z = 15f;
					npcClass.Rxjh_Map = int_1;
					npcClass.IsNpc = 0;
					npcClass.FLD_FACE1 = int_2;
					npcClass.FLD_FACE2 = int_3;
					npcClass.Max_Rxjh_HP = value.Rxjh_HP;
					npcClass.Rxjh_HP = value.Rxjh_HP;
					npcClass.FLD_AT = value.FLD_AT;
					npcClass.FLD_DF = value.FLD_DF;
					npcClass.FLD_AUTO = value.FLD_AUTO;
					npcClass.FLD_BOSS = value.FLD_BOSS;
					npcClass.一次性怪 = bool_0;
					npcClass.FLD_NEWTIME = int_4;
					MapClass value2;
					if (Map.TryGetValue(npcClass.Rxjh_Map, out value2))
					{
						value2.add(npcClass);
					}
					else
					{
						MapClass mapClass = new MapClass();
						mapClass.MapID = npcClass.Rxjh_Map;
						mapClass.add(npcClass);
						Map.Add(mapClass.MapID, mapClass);
					}
					npcClass.获取范围玩家发送增加数据包();
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(2, "增加怪  [" + int_0 + "]出错：" + ((ex != null) ? ex.ToString() : null));
			}
		}

		[SecureMethod]
		public static void SerNpc(int int_0, float float_0, float float_1, int int_1)
		{
			try
			{
				MonSterClss value;
				if (MonSter.TryGetValue(int_0, out value))
				{
					NpcClass npcClass = new NpcClass();
					npcClass.FLD_PID = value.FLD_PID;
					npcClass.Name = value.Name;
					npcClass.Level = value.Level;
					npcClass.Rxjh_Exp = value.Rxjh_Exp;
					npcClass.Rxjh_X = float_0;
					npcClass.Rxjh_Y = float_1;
					npcClass.Rxjh_Z = 15f;
					npcClass.Rxjh_cs_X = float_0;
					npcClass.Rxjh_cs_Y = float_1;
					npcClass.Rxjh_cs_Z = 15f;
					npcClass.Rxjh_Map = int_1;
					npcClass.IsNpc = 0;
					npcClass.FLD_FACE1 = 0f;
					npcClass.FLD_FACE2 = 0f;
					npcClass.Max_Rxjh_HP = value.Rxjh_HP;
					npcClass.Rxjh_HP = value.Rxjh_HP;
					npcClass.FLD_AT = value.FLD_AT;
					npcClass.FLD_DF = value.FLD_DF;
					npcClass.FLD_AUTO = value.FLD_AUTO;
					npcClass.FLD_BOSS = value.FLD_BOSS;
					npcClass.FLD_NEWTIME = 10;
					MapClass value2;
					if (Map.TryGetValue(npcClass.Rxjh_Map, out value2))
					{
						value2.add(npcClass);
					}
					else
					{
						MapClass mapClass = new MapClass();
						mapClass.MapID = npcClass.Rxjh_Map;
						mapClass.add(npcClass);
						Map.Add(mapClass.MapID, mapClass);
					}
					npcClass.获取范围玩家发送增加数据包();
					DBA.ExeSqlCommand(string.Format("INSERT  INTO  TBL_XWWL_NPC(FLD_PID,FLD_X,FLD_Y,FLD_Z,FLD_FACE0,FLD_FACE,FLD_MID,FLD_NAME,FLD_HP,FLD_AT,FLD_DF,FLD_NPC,FLD_NEWTIME,FLD_LEVEL,FLD_EXP,FLD_AUTO,FLD_BOSS)VALUES  ({0},{1},{2},{3},{4},{5},{6},'{7}',{8},{9},{10},{11},{12},{13},{14},{15},{16})", npcClass.FLD_PID, float_0, float_1, 15, 0, 0, npcClass.Rxjh_Map, npcClass.Name, npcClass.Max_Rxjh_HP, npcClass.FLD_AT, npcClass.FLD_DF, 0, 10, npcClass.Level, npcClass.Rxjh_Exp, npcClass.FLD_AUTO, npcClass.FLD_BOSS), "PublicDb");
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(2, "增加怪  [" + int_0 + "]出错：" + ((ex != null) ? ex.ToString() : null));
			}
		}

		public static bool InConnectList(int int_0)
		{
			try
			{
				NetState value;
				if (list.TryGetValue(int_0, out value))
				{
					return true;
				}
			}
			catch
			{
			}
			return false;
		}

		public static void ProcessNpcMove()
		{
			try
			{
				foreach (MapClass value in Map.Values)
				{
					foreach (NpcClass value2 in value.npcTemplate.Values)
					{
						if (value2.IsNpc != 1 || value2.FLD_PID == 5)
						{
							if (value2._PlayList.Count == 0)
							{
								if (value2.自动移动.Enabled)
								{
									value2.自动移动.Enabled = false;
								}
								if (value2.自动攻击.Enabled)
								{
									value2.自动攻击.Enabled = false;
								}
							}
							else if (!value2.NPC死亡 && !value2.自动移动.Enabled && !value2.自动攻击.Enabled)
							{
								value2.自动移动.Enabled = true;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "ProcessNpcMove()出错  " + ((ex != null) ? ex.ToString() : null));
			}
		}

		public static void ProcessSqlQueue()
		{
			try
			{
				while (SqlPool.Count > 0)
				{
					DbPoolClass dbPoolClass = (DbPoolClass)SqlPool.Dequeue();
					try
					{
						if (DbPoolClass.DbPoolClassRun(dbPoolClass.Conn, dbPoolClass.Sql, dbPoolClass.Prams, dbPoolClass.Type) == -1)
						{
							SqlPool.Enqueue(dbPoolClass);
							Form1.WriteLine(1, "ProcessSqlQueue()2  数据库连接出错  " + SqlPool.Count);
							Thread.Sleep(500);
						}
					}
					catch (Exception ex)
					{
						Form1.WriteLine(1, "ProcessSqlQueue()1出错  " + ((ex != null) ? ex.ToString() : null));
						Thread.Sleep(1);
					}
				}
			}
			catch (Exception ex2)
			{
				Form1.WriteLine(1, "ProcessSqlQueue()出错  " + ((ex2 != null) ? ex2.ToString() : null));
			}
		}

		public static string pWord(string string_0, int int_0)
		{
			if (string_0 == null)
			{
				return null;
			}
			if (string_0.Equals(string.Empty))
			{
				return string.Empty;
			}
			string text = string.Empty;
			if (int_0 == 2)
			{
				int length = string_0.Length;
				text = string.Empty;
				int num = Convert.ToInt32(string_0.ToCharArray(0, 1)[0]) % 10;
				for (int i = 2; i < length; i += 2)
				{
					int num2 = Convert.ToInt32(string_0.ToCharArray(i, 1)[0]);
					string text2 = (Convert.ToInt32(string_0.ToCharArray(i - 1, 1)[0]) % 2 != 0) ? ((char)(num2 - (i - 1) / 2 - num)).ToString() : ((char)(num2 + (i - 1) / 2 + num)).ToString();
					string str = text2;
					text += str;
				}
			}
			return text;
		}

		public static int GetRandomSeed()
		{
			byte[] array = new byte[4];
			new RNGCryptoServiceProvider().GetBytes(array);
			return BitConverter.ToInt32(array, 0);
		}

		public static int GetValue(int int_0, int int_1)
		{
			int result = 0;
			try
			{
				if (int_0 <= 800000002)
				{
					if (int_0 != 800000001)
					{
						if (int_0 != 800000002)
						{
							return result;
						}
						goto IL_0ba6;
					}
				}
				else
				{
					switch (int_0)
					{
					case 800000062:
					{
						int num8 = RNG.Next(0, 110);
						int num9 = 1;
						string text3 = (int_1 == 2) ? ((num8 < 0 || num8 >= 40) ? "11" : "2") : ((num8 >= 0 && num8 < 40) ? "2" : ((num8 >= 40 && num8 < 50) ? "3" : ((num8 >= 50 && num8 < 60) ? "4" : ((num8 < 60 || num8 >= 70) ? "11" : "6"))));
						switch (int_1)
						{
						case 1:
							switch (text3)
							{
							case "11":
								num9 = RNG.Next(23, 45);
								if (num9 % 2 != 0)
								{
									num9--;
								}
								break;
							case "6":
								num9 = RNG.Next(1, 10);
								break;
							case "4":
								num9 = RNG.Next(17, 36);
								if (num9 % 2 != 0)
								{
									num9--;
								}
								break;
							case "3":
								num9 = RNG.Next(30, 60);
								if (num9 % 2 != 0)
								{
									num9--;
								}
								break;
							case "2":
								num9 = RNG.Next(5, 9);
								break;
							}
							break;
						case 2:
							switch (text3)
							{
							case "11":
								num9 = RNG.Next(80, 100);
								if (num9 >= 80 && num9 < 83)
								{
									num9 = 80;
								}
								else if (num9 >= 83 && num9 < 86)
								{
									num9 = 80;
								}
								else if (num9 >= 86 && num9 < 89)
								{
									num9 = 85;
								}
								else if (num9 >= 89 && num9 < 92)
								{
									num9 = 85;
								}
								else if (num9 >= 92 && num9 < 95)
								{
									num9 = 90;
								}
								else if (num9 >= 95 && num9 < 98)
								{
									num9 = 95;
								}
								else if (num9 >= 98 && num9 <= 100)
								{
									num9 = 100;
								}
								if (num9 != 85 && num9 != 95 && num9 % 2 != 0)
								{
									num9--;
								}
								break;
							case "2":
								num9 = RNG.Next(11, 15);
								break;
							}
							break;
						case 3:
						case 4:
						case 5:
						case 6:
							switch (text3)
							{
							case "11":
								num9 = RNG.Next(76, 100);
								if (num9 > 80 && num9 <= 83)
								{
									num9 = 80;
								}
								else if (num9 > 83 && num9 <= 86)
								{
									num9 = 80;
								}
								else if (num9 > 86 && num9 <= 89)
								{
									num9 = 85;
								}
								else if (num9 > 89 && num9 <= 92)
								{
									num9 = 90;
								}
								else if (num9 > 92 && num9 <= 95)
								{
									num9 = 90;
								}
								else if (num9 > 95 && num9 <= 98)
								{
									num9 = 95;
								}
								else if (num9 > 98 && num9 <= 100)
								{
									num9 = 95;
								}
								if (num9 != 85 && num9 != 95 && num9 % 2 != 0)
								{
									num9--;
								}
								break;
							case "6":
								num9 = RNG.Next(3, 10);
								break;
							case "4":
								num9 = RNG.Next(35, 50);
								if (num9 % 2 != 0)
								{
									num9--;
								}
								break;
							case "3":
								num9 = RNG.Next(50, 80);
								if (num9 % 2 != 0)
								{
									num9--;
								}
								break;
							case "2":
								num9 = RNG.Next(10, 14);
								break;
							}
							break;
						}
						return int.Parse(text3) * 100000 + num9;
					}
					case 800000061:
					{
						int num6 = RNG.Next(0, 120);
						int num7 = 1;
						string text2 = (int_1 == 2) ? ((num6 >= 0 && num6 < 55) ? "1" : ((num6 < 55 || num6 >= 110) ? "8" : "7")) : ((num6 >= 0 && num6 < 30) ? "1" : ((num6 >= 30 && num6 < 40) ? "3" : ((num6 >= 40 && num6 < 45) ? "4" : ((num6 >= 45 && num6 < 50) ? "5" : ((num6 >= 50 && num6 < 110) ? "7" : ((num6 < 110 || num6 >= 115) ? "10" : "8"))))));
						switch (int_1)
						{
						case 1:
							if (text2 != null)
							{
								switch (Class3.smethod_0(text2))
								{
								case 822911587u:
									if (text2 == "4")
									{
										num7 = RNG.Next(20, 25);
										if (num7 % 2 != 0)
										{
											num7--;
										}
									}
									break;
								case 806133968u:
									if (text2 == "5")
									{
										num7 = RNG.Next(1, 10);
									}
									break;
								case 468396612u:
									if (text2 == "10")
									{
										num7 = RNG.Next(10, 25);
									}
									break;
								case 873244444u:
									if (text2 == "1")
									{
										num7 = RNG.Next(10, 20);
									}
									break;
								case 839689206u:
									if (text2 == "7")
									{
										num7 = RNG.Next(15, 25);
									}
									break;
								case 1024243015u:
									if (text2 == "8")
									{
										num7 = 1;
									}
									break;
								case 906799682u:
									if (text2 == "3")
									{
										num7 = RNG.Next(50, 70);
										if (num7 % 2 != 0)
										{
											num7--;
										}
									}
									break;
								}
							}
							break;
						case 2:
							switch (text2)
							{
							case "8":
								num7 = 2;
								break;
							case "7":
								num7 = RNG.Next(30, 35);
								break;
							case "1":
								num7 = RNG.Next(20, 25);
								break;
							}
							break;
						case 3:
						case 4:
						case 5:
						case 6:
							if (text2 != null)
							{
								switch (Class3.smethod_0(text2))
								{
								case 822911587u:
									if (text2 == "4")
									{
										num7 = RNG.Next(25, 50);
										if (num7 % 2 != 0)
										{
											num7--;
										}
									}
									break;
								case 806133968u:
									if (text2 == "5")
									{
										num7 = RNG.Next(5, 10);
									}
									break;
								case 468396612u:
									if (text2 == "10")
									{
										num7 = RNG.Next(15, 25);
									}
									break;
								case 873244444u:
									if (text2 == "1")
									{
										num7 = RNG.Next(15, 24);
									}
									break;
								case 839689206u:
									if (text2 == "7")
									{
										num7 = RNG.Next(15, 34);
									}
									break;
								case 1024243015u:
									if (text2 == "8")
									{
										num7 = RNG.Next(1, 2);
									}
									break;
								case 906799682u:
									if (text2 == "3")
									{
										num7 = RNG.Next(50, 80);
										if (num7 % 2 != 0)
										{
											num7--;
										}
									}
									break;
								}
							}
							break;
						}
						return int.Parse(text2) * 100000 + num7;
					}
					case 800000011:
						break;
					case 800000012:
						goto IL_0ba6;
					case 800000013:
					{
						int num3 = 0;
						string str = "0000";
						int num4 = RNG.Next(0, 125);
						int num5 = (num4 >= 0 && num4 <= 40) ? 8 : ((num4 > 40 && num4 <= 70) ? 9 : ((num4 > 70 && num4 <= 90) ? 12 : ((num4 <= 90 || num4 > 110) ? 15 : 13)));
						switch (num5)
						{
						case 8:
							num3 = 1;
							str = "0000";
							break;
						case 9:
							num3 = 1;
							break;
						case 12:
							num3 = 10;
							break;
						case 13:
							num3 = 5;
							break;
						case 15:
							num3 = 1;
							break;
						}
						return int.Parse((num5 != 12) ? (num5 + str + num3) : (num5 + "000" + num3));
					}
					case 800000023:
					{
						int num10 = RNG.Next(0, 120);
						int num11 = 1;
						string text4 = (int_1 == 2) ? ((num10 < 0 || num10 >= 30) ? "7" : "1") : ((num10 >= 0 && num10 < 20) ? "1" : ((num10 >= 20 && num10 < 30) ? "3" : ((num10 >= 30 && num10 < 35) ? "4" : ((num10 >= 35 && num10 < 40) ? "5" : ((num10 >= 40 && num10 < 110) ? "7" : ((num10 < 110 || num10 >= 115) ? "10" : "8"))))));
						switch (int_1)
						{
						case 1:
							if (text4 != null)
							{
								switch (Class3.smethod_0(text4))
								{
								case 822911587u:
									if (text4 == "4")
									{
										num11 = RNG.Next(15, 25);
										if (num11 % 2 != 0)
										{
											num11--;
										}
									}
									break;
								case 806133968u:
									if (text4 == "5")
									{
										num11 = RNG.Next(1, 10);
									}
									break;
								case 468396612u:
									if (text4 == "10")
									{
										num11 = RNG.Next(10, 25);
									}
									break;
								case 873244444u:
									if (text4 == "1")
									{
										num11 = RNG.Next(8, 15);
									}
									break;
								case 839689206u:
									if (text4 == "7")
									{
										num11 = RNG.Next(15, 24);
									}
									break;
								case 1024243015u:
									if (text4 == "8")
									{
										num11 = 1;
									}
									break;
								case 906799682u:
									if (text4 == "3")
									{
										num11 = RNG.Next(45, 70);
										if (num11 % 2 != 0)
										{
											num11--;
										}
									}
									break;
								}
							}
							break;
						case 2:
							switch (text4)
							{
							case "7":
								num11 = RNG.Next(27, 31);
								break;
							case "1":
								num11 = RNG.Next(21, 24);
								break;
							}
							break;
						case 3:
						case 4:
						case 5:
						case 6:
							if (text4 != null)
							{
								switch (Class3.smethod_0(text4))
								{
								case 822911587u:
									if (text4 == "4")
									{
										num11 = RNG.Next(15, 50);
										if (num11 % 2 != 0)
										{
											num11--;
										}
									}
									break;
								case 806133968u:
									if (text4 == "5")
									{
										num11 = RNG.Next(5, 10);
									}
									break;
								case 468396612u:
									if (text4 == "10")
									{
										num11 = RNG.Next(10, 25);
									}
									break;
								case 873244444u:
									if (text4 == "1")
									{
										num11 = RNG.Next(13, 20);
									}
									break;
								case 839689206u:
									if (text4 == "7")
									{
										num11 = RNG.Next(24, 31);
									}
									break;
								case 1024243015u:
									if (text4 == "8")
									{
										num11 = RNG.Next(1, 2);
									}
									break;
								case 906799682u:
									if (text4 == "3")
									{
										num11 = RNG.Next(25, 80);
										if (num11 % 2 != 0)
										{
											num11--;
										}
									}
									break;
								}
							}
							break;
						}
						return int.Parse(text4) * 100000 + num11;
					}
					case 800000024:
					{
						int num = RNG.Next(0, 100);
						int num2 = 1;
						string text = (int_1 == 2) ? ((num < 0 || num >= 50) ? "11" : "2") : ((num >= 0 && num < 45) ? "2" : ((num >= 45 && num < 50) ? "3" : ((num >= 50 && num < 55) ? "4" : ((num < 55 || num >= 60) ? "11" : "6"))));
						switch (int_1)
						{
						case 1:
							switch (text)
							{
							case "11":
								num2 = RNG.Next(45, 70);
								if (num2 % 2 != 0)
								{
									num2--;
								}
								break;
							case "6":
								num2 = RNG.Next(1, 10);
								break;
							case "4":
								num2 = RNG.Next(20, 36);
								if (num2 % 2 != 0)
								{
									num2--;
								}
								break;
							case "3":
								num2 = RNG.Next(20, 36);
								if (num2 % 2 != 0)
								{
									num2--;
								}
								break;
							case "2":
								num2 = RNG.Next(5, 9);
								break;
							}
							break;
						case 2:
							switch (text)
							{
							case "11":
								num2 = RNG.Next(74, 80);
								if (num2 % 2 != 0)
								{
									num2--;
								}
								break;
							case "2":
								num2 = RNG.Next(8, 11);
								break;
							}
							break;
						case 3:
						case 4:
						case 5:
						case 6:
							switch (text)
							{
							case "11":
								num2 = RNG.Next(64, 80);
								if (num2 % 2 != 0)
								{
									num2--;
								}
								break;
							case "6":
								num2 = RNG.Next(3, 10);
								break;
							case "4":
								num2 = RNG.Next(15, 30);
								if (num2 % 2 != 0)
								{
									num2--;
								}
								break;
							case "3":
								num2 = RNG.Next(30, 50);
								if (num2 % 2 != 0)
								{
									num2--;
								}
								break;
							case "2":
								num2 = RNG.Next(8, 11);
								break;
							}
							break;
						}
						return int.Parse(text) * 100000 + num2;
					}
					case 800000025:
						return 1000000 + RNG.Next(15, 20);
					case 800000026:
						return 700000 + RNG.Next(15, 25);
					case 800000028:
						return int.Parse("200" + RNG.Next(1, 6) + "000");
					case 800000030:
					case 800000034:
						goto IL_154c;
					case 800000031:
					case 800000035:
						goto IL_166c;
					case 800000032:
					case 800000036:
						goto IL_1793;
					case 800000033:
					case 800000037:
						goto IL_17c1;
					default:
						return result;
					case 800000014:
					case 800000015:
					case 800000016:
					case 800000017:
					case 800000018:
					case 800000019:
					case 800000020:
					case 800000021:
					case 800000022:
					case 800000027:
					case 800000029:
						return result;
					}
				}
				int num12 = RNG.Next(0, 120);
				int num13 = 1;
				string text5 = (num12 >= 0 && num12 < 50) ? "1" : ((num12 >= 50 && num12 < 55) ? "3" : ((num12 >= 55 && num12 < 60) ? "4" : ((num12 >= 60 && num12 < 65) ? "5" : ((num12 >= 65 && num12 < 100) ? "7" : ((num12 < 100 || num12 >= 110) ? "10" : "8")))));
				switch (int_1)
				{
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
					if (text5 != null)
					{
						switch (Class3.smethod_0(text5))
						{
						case 822911587u:
							if (text5 == "4")
							{
								num13 = RNG.Next(25, 36);
								if (num13 % 2 != 0)
								{
									num13--;
								}
							}
							break;
						case 806133968u:
							if (text5 == "5")
							{
								num13 = RNG.Next(5, 10);
							}
							break;
						case 468396612u:
							if (text5 == "10")
							{
								num13 = RNG.Next(10, 25);
							}
							break;
						case 873244444u:
							if (text5 == "1")
							{
								num13 = RNG.Next(8, 15);
							}
							break;
						case 839689206u:
							if (text5 == "7")
							{
								num13 = RNG.Next(20, 25);
							}
							break;
						case 1024243015u:
							if (text5 == "8")
							{
								num13 = RNG.Next(1, 2);
							}
							break;
						case 906799682u:
							if (text5 == "3")
							{
								num13 = RNG.Next(20, 40);
								if (num13 % 2 != 0)
								{
									num13--;
								}
							}
							break;
						}
					}
					break;
				case 1:
					if (text5 != null)
					{
						switch (Class3.smethod_0(text5))
						{
						case 822911587u:
							if (text5 == "4")
							{
								num13 = RNG.Next(15, 25);
								if (num13 % 2 != 0)
								{
									num13--;
								}
							}
							break;
						case 806133968u:
							if (text5 == "5")
							{
								num13 = RNG.Next(1, 10);
							}
							break;
						case 468396612u:
							if (text5 == "10")
							{
								num13 = RNG.Next(20, 25);
							}
							break;
						case 873244444u:
							if (text5 == "1")
							{
								num13 = RNG.Next(5, 10);
							}
							break;
						case 839689206u:
							if (text5 == "7")
							{
								num13 = RNG.Next(15, 22);
							}
							break;
						case 1024243015u:
							if (text5 == "8")
							{
								num13 = 1;
							}
							break;
						case 906799682u:
							if (text5 == "3")
							{
								num13 = RNG.Next(25, 30);
								if (num13 % 2 != 0)
								{
									num13--;
								}
							}
							break;
						}
					}
					break;
				}
				return int.Parse(text5) * 100000 + num13;
				IL_17c1:
				switch (int_1)
				{
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
					return RNG.Next(200005, 200025);
				case 1:
					return RNG.Next(200001, 200005);
				default:
					return result;
				}
				IL_0ba6:
				int num14 = RNG.Next(0, 100);
				int num15 = 1;
				string text6 = (num14 >= 0 && num14 < 75) ? "2" : ((num14 >= 75 && num14 < 80) ? "3" : ((num14 >= 80 && num14 < 85) ? "4" : ((num14 < 85 || num14 >= 90) ? "11" : "6")));
				switch (int_1)
				{
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
					switch (text6)
					{
					case "11":
						num15 = RNG.Next(35, 45);
						if (num15 % 2 != 0)
						{
							num15--;
						}
						break;
					case "6":
						num15 = RNG.Next(5, 10);
						break;
					case "4":
						num15 = RNG.Next(25, 50);
						if (num15 % 2 != 0)
						{
							num15--;
						}
						break;
					case "3":
						num15 = RNG.Next(25, 50);
						if (num15 % 2 != 0)
						{
							num15--;
						}
						break;
					case "2":
						num15 = RNG.Next(6, 10);
						break;
					}
					break;
				case 1:
					switch (text6)
					{
					case "11":
						num15 = RNG.Next(2, 35);
						if (num15 % 2 != 0)
						{
							num15--;
						}
						break;
					case "6":
						num15 = RNG.Next(1, 10);
						break;
					case "4":
						num15 = RNG.Next(20, 36);
						if (num15 % 2 != 0)
						{
							num15--;
						}
						break;
					case "3":
						num15 = RNG.Next(20, 40);
						if (num15 % 2 != 0)
						{
							num15--;
						}
						break;
					case "2":
						num15 = RNG.Next(4, 8);
						break;
					}
					break;
				}
				return int.Parse(text6) * 100000 + num15;
				IL_166c:
				switch (int_1)
				{
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
				{
					int num17 = RNG.Next(0, 100);
					return (num17 >= 0 && num17 < 20) ? RNG.Next(100005, 100025) : ((num17 >= 20 && num17 < 40) ? RNG.Next(700008, 700035) : ((num17 >= 40 && num17 < 60) ? RNG.Next(1000008, 1000025) : ((num17 < 60 || num17 >= 80) ? RNG.Next(1500001, 1500002) : RNG.Next(200001, 200020))));
				}
				case 1:
				{
					int num16 = RNG.Next(0, 100);
					return (num16 >= 0 && num16 < 20) ? RNG.Next(100005, 100015) : ((num16 >= 20 && num16 < 40) ? RNG.Next(700008, 700020) : ((num16 >= 40 && num16 < 60) ? RNG.Next(1000008, 1000020) : ((num16 < 60 || num16 >= 80) ? 1500001 : RNG.Next(200001, 200010))));
				}
				default:
					return result;
				}
				IL_1793:
				switch (int_1)
				{
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
					return RNG.Next(200005, 200020);
				case 1:
					return RNG.Next(200001, 200005);
				default:
					return result;
				}
				IL_154c:
				switch (int_1)
				{
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
				{
					int num19 = RNG.Next(0, 100);
					return (num19 >= 0 && num19 < 20) ? RNG.Next(100005, 100015) : ((num19 >= 20 && num19 < 40) ? RNG.Next(700008, 700025) : ((num19 >= 40 && num19 < 60) ? RNG.Next(1000008, 1000025) : ((num19 < 60 || num19 >= 80) ? 1500001 : RNG.Next(200001, 200020))));
				}
				case 1:
				{
					int num18 = RNG.Next(0, 100);
					return (num18 >= 0 && num18 < 20) ? RNG.Next(100005, 100010) : ((num18 >= 20 && num18 < 40) ? RNG.Next(700008, 700020) : ((num18 >= 40 && num18 < 60) ? RNG.Next(1000008, 1000020) : ((num18 < 60 || num18 >= 80) ? 1500001 : RNG.Next(200001, 200010))));
				}
				default:
					return result;
				}
			}
			catch
			{
				return 1;
			}
		}
	}
}
