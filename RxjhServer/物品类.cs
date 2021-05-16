using RxjhServer.HelperTools;
using RxjhServer.Network;
using System;
using System.Collections.Generic;

namespace RxjhServer
{
	public class 物品类 : IDisposable
	{
		public bool 锁定;

		private bool _物品绑定;

		private string _物品string;

		private int _物品位置;

		private byte[] _物品_byte;

		private Itimesx _属性1;

		private Itimesx _属性2;

		private Itimesx _属性3;

		private Itimesx _属性4;

		private int _物品防御力;

		private int _物品对怪防御力;

		private int _物品对怪攻击力;

		private int _物品_中级附魂_追加_觉醒;

		private int _物品攻击力;

		private int _物品攻击力MAX;

		private int _物品属性_障力增加;

		private int _物品属性强类型;

		private int _物品属性强;

		private int _物品属性阶段类型;

		private int _物品属性阶段数;

		private int _物品属性_攻击力增加;

		private int _物品攻击力New;

		private int _物品攻击力MaxNew;

		private int _物品属性_防御力增加;

		private int _物品防御力New;

		private int _物品属性_生命力增加;

		private int _物品属性_障力恢复量增加;

		private int _物品属性_内功力增加;

		private int _物品属性_命中率增加;

		private int _物品属性_回避率增加;

		private int _物品属性_武功攻击力;

		private int _物品属性_武功攻击力New;

		private double _物品属性_降低百分比攻击;

		private double _物品属性_降低百分比防御;

		private double _物品属性_增加百分比命中;

		private double _物品属性_增加百分比回避;

		private double _物品属性_初始化愤怒概率百分比;

		private int _物品属性_愤怒值增加;

		private int _物品属性_全部气功等级增加;

		private int _物品属性_追加刀力劈华山;

		private int _物品属性_追加刀摄魂一击;

		private int _物品属性_追加刀连环飞舞;

		private int _物品属性_追加升天三火龙之火;

		private int _物品属性_追加刀狂风万破;

		private int _物品属性_追加刀四两千斤;

		private int _物品属性_追加刀霸气破甲;

		private int _物品属性_追加刀真武绝击;

		private int _物品属性_追加刀暗影绝杀;

		private int _物品属性_追加刀稳如泰山;

		private int _物品属性_追加刀流光乱舞;

		private int _物品属性_追加刀梵音破镜;

		private int _物品属性_追加剑长虹贯日;

		private int _物品属性_追加剑百变神行;

		private int _物品属性_追加剑连环飞舞;

		private int _物品属性_追加剑破天一剑;

		private int _物品属性_追加剑狂风万破;

		private int _物品属性_追加升天一护身罡气;

		private int _物品属性_追加剑移花接木;

		private int _物品属性_追加剑回柳身法;

		private int _物品属性_追加剑怒海狂澜;

		private int _物品属性_追加剑冲冠一怒;

		private int _物品属性_追加剑无坚不摧;

		private int _物品属性_追加剑乘胜追击;

		private int _物品属性_追加枪金钟罩气;

		private int _物品属性_追加枪运气疗伤;

		private int _物品属性_追加枪连环飞舞;

		private int _物品属性_追加升天三怒意之火;

		private int _物品属性_追加枪狂风万破;

		private int _物品属性_追加枪横练太保;

		private int _物品属性_追加枪乾坤挪移;

		private int _物品属性_追加枪灵甲护身;

		private int _物品属性_追加枪狂神降世;

		private int _物品属性_追加枪转守为攻;

		private int _物品属性_追加枪末日狂舞;

		private int _物品属性_追加枪怒意之吼;

		private int _物品属性_追加弓百步穿杨;

		private int _物品属性_追加弓猎鹰之眼;

		private int _物品属性_追加弓凝神聚气;

		private int _物品属性_追加弓回流真气;

		private int _物品属性_追加弓狂风万破;

		private int _物品属性_追加弓正本培元;

		private int _物品属性_追加弓心神凝聚;

		private int _物品属性_追加弓流星三矢;

		private int _物品属性_追加弓锐利之箭;

		private int _物品属性_追加弓无明暗矢;

		private int _物品属性_追加弓致命绝杀;

		private int _物品属性_追加医运气行心;

		private int _物品属性_追加医太极心法;

		private int _物品属性_追加医体血倍增;

		private int _物品属性_追加医洗髓易经;

		private int _物品属性_追加医妙手回春;

		private int _物品属性_追加医长功攻击;

		private int _物品属性_追加医吸星大法;

		private int _物品属性_追加医真武绝击;

		private int _物品属性_追加升天一护身气甲;

		private int _物品属性_追加医九天真气;

		private int _物品属性_追加医狂意护体;

		private int _物品属性_追加医无中生有;

		private int _物品属性_追加刺荆轲之怒;

		private int _物品属性_追加刺三花聚顶;

		private int _物品属性_追加刺连环飞舞;

		private int _物品属性_追加刺一招残杀;

		private int _物品属性_追加刺心神凝聚;

		private int _物品属性_追加刺致手绝命;

		private int _物品属性_追加刺先发制人;

		private int _物品属性_追加刺千株万手;

		private int _物品属性_追加刺连消带打;

		private int _物品属性_追加刺剑刃乱舞;

		private int _物品属性_追加刺以怒还怒;

		private int _物品属性_追加琴战马奔腾;

		private int _物品属性_追加琴秋江夜泊;

		private int _物品属性_追加琴清心普善;

		private int _物品属性_追加琴阳关三叠;

		private int _物品属性_追加琴汉宫秋月;

		private int _物品属性_追加琴高山流水;

		private int _物品属性_追加琴岳阳三醉;

		private int _物品属性_追加琴梅花三弄;

		private int _物品属性_追加琴鸾凤和鸣;

		private int _物品属性_追加琴阳明春晓;

		private int _物品属性_追加琴潇湘雨夜;

		private int _物品属性_追加韩力劈华山;

		private int _物品属性_追加韩摄魂一击;

		private int _物品属性_追加韩天魔狂血;

		private int _物品属性_追加韩百变神行;

		private int _物品属性_追加韩狂风万破;

		private int _物品属性_追加韩追骨吸元;

		private int _物品属性_追加韩霸气破甲;

		private int _物品属性_追加韩真武绝击;

		private int _物品属性_追加韩暗影绝杀;

		private int _物品属性_追加韩火龙问鼎;

		private int _物品属性_追加韩流光乱舞;

		private int _物品属性_追加谭长虹贯日;

		private int _物品属性_追加谭百变神行;

		private int _物品属性_追加谭新_连环飞舞;

		private int _物品属性_追加谭招式新法;

		private int _物品属性_追加谭狂风万破;

		private int _物品属性_追加谭护身罡气;

		private int _物品属性_追加谭移花接木;

		private int _物品属性_追加谭纵横无双;

		private int _物品属性_追加谭回柳身法;

		private int _物品属性_追加谭怒海狂澜;

		private int _物品属性_追加谭冲冠一怒;

		private int _物品属性_追加升天一遁出逆境;

		private int _物品属性_追加升天二穷途末路;

		private int _物品属性_追加升天四红月狂风;

		private int _物品属性_追加升天四毒蛇出洞;

		private int _物品属性_追加升天四满月狂风;

		private int _物品属性_追加升天四烈日炎炎;

		private int _物品属性_追加升天四长虹贯天;

		private int _物品属性_追加升天四哀鸿遍野;

		private int _物品属性_追加升天夺命连环;

		private int _物品属性_追加升天电光石火;

		private int _物品属性_追加升天精益求精;

		private int _物品属性_追加升天二天地同寿;

		private int _物品属性_追加升天三火凤临朝;

		private int _物品属性_追加升天一破甲刺魂;

		private int _物品属性_追加升天二以退为进;

		private int _物品属性_追加升天一绝影射魂;

		private int _物品属性_追加升天二千钧压驼;

		private int _物品属性_追加升天二万物回春;

		private int _物品属性_追加升天三天外三矢;

		private int _物品属性_追加升天三明镜止水;

		private int _物品属性_追加升天四望梅添花;

		private int _物品属性_追加升天一夜魔缠身;

		private int _物品属性_追加升天二顺水推舟;

		private int _物品属性_追加升天三无情打击;

		private int _物品属性_追加升天三以柔克刚;

		private int _物品属性_追加升天三内息行心;

		private int _物品属性_追加升天二天魔护体;

		private int _物品属性_追加升天一行风弄舞;

		private int _物品属性_追加升天四悬丝诊脉;

		private int _物品属性_追加升天三子夜秋歌;

		private int _物品属性_追加升天二三潭映月;

		private int _物品属性_追加升天一力劈华山;

		private int _物品属性_追加升天一长虹贯日;

		private int _物品属性_追加升天一金钟罡气;

		private int _物品属性_追加升天一运气行心;

		private int _物品属性_追加升天一正本培源;

		private int _物品属性_追加升天一运气疗伤;

		private int _物品属性_追加升天一百变神行;

		private int _物品属性_追加升天一狂风天意;

		private int _物品属性_追加升天一飞花点翠;

		private int _物品属性_升级成功率;

		private int _物品属性_追加伤害值;

		private int _物品属性_降低伤害值;

		private double _物品属性_追加中毒几率百分比;

		private double _物品属性_追加强化;

		private int _物品属性_武功防御力增加;

		private int _物品属性_武功防御力增加New;

		private int _物品属性_获得金钱增加;

		private int _物品属性_死亡损失经验减少;

		private int _物品属性_经验获得增加;

		private int _FLD_RESIDE2;

		public int _FLD_LEVEL;

		public bool 物品绑定
		{
			get
			{
				try
				{
					byte[] array = new byte[2];
					System.Buffer.BlockCopy(物品_byte, 76, array, 0, 1);
					return Buffer.ToInt16(array, 0) != 0;
				}
				catch (Exception)
				{
					return false;
				}
			}
			set
			{
				_物品绑定 = value;
			}
		}

		public long Get物品全局ID
		{
			get
			{
				return BitConverter.ToInt64(物品_byte, 0);
			}
		}

		public long Get物品ID
		{
			get
			{
				return Buffer.ToInt32(物品_byte, 8);
			}
		}

		public int FLD_Intrgration
		{
			get
			{
				try
				{
					if (Get物品ID != 0L)
					{
						return World.Itme[(int)Get物品ID].FLD_INTEGRATION;
					}
				}
				catch
				{
				}
				return 0;
			}
		}

		public int FLD_SERIES
		{
			get
			{
				try
				{
					if (Get物品ID != 0L)
					{
						return World.Itme[(int)Get物品ID].FLD_SERIES;
					}
				}
				catch
				{
				}
				return 0;
			}
		}

		public int Get物品数量
		{
			get
			{
				return Buffer.ToInt32(物品_byte, 12);
			}
		}

		public string 物品string
		{
			get
			{
				return 得到物品string();
			}
			set
			{
				_物品string = value;
			}
		}

		public int 物品位置
		{
			get
			{
				return _物品位置;
			}
			set
			{
				_物品位置 = value;
			}
		}

		public int 物品类型
		{
			get
			{
				return 得到物品类型();
			}
		}

		public int 物品单个重量
		{
			get
			{
				return 得到物品单个重量();
			}
		}

		public int 物品总重量
		{
			get
			{
				return 得到物品重量();
			}
		}

		public byte[] 物品_byte
		{
			get
			{
				return _物品_byte;
			}
			set
			{
				锁定 = false;
				_物品_byte = value;
			}
		}

		public byte[] 物品数量
		{
			get
			{
				return 得到物品数量();
			}
			set
			{
				设置物品数量(value);
			}
		}

		public byte[] 物品ID
		{
			get
			{
				return 得到物品ID();
			}
		}

		public byte[] 物品全局ID
		{
			get
			{
				return 得到全局ID();
			}
		}

		public byte[] 物品属性
		{
			get
			{
				return 得到物品属性();
			}
		}

		public Itimesx 属性1
		{
			get
			{
				byte[] array = new byte[4];
				System.Buffer.BlockCopy(物品_byte, 20, array, 0, 4);
				属性1 = new Itimesx(array);
				return _属性1;
			}
			set
			{
				_属性1 = value;
			}
		}

		public Itimesx 属性2
		{
			get
			{
				byte[] array = new byte[4];
				System.Buffer.BlockCopy(物品_byte, 24, array, 0, 4);
				属性2 = new Itimesx(array);
				return _属性2;
			}
			set
			{
				_属性2 = value;
			}
		}

		public Itimesx 属性3
		{
			get
			{
				byte[] array = new byte[4];
				System.Buffer.BlockCopy(物品_byte, 28, array, 0, 4);
				属性3 = new Itimesx(array);
				return _属性3;
			}
			set
			{
				_属性3 = value;
			}
		}

		public Itimesx 属性4
		{
			get
			{
				byte[] array = new byte[4];
				System.Buffer.BlockCopy(物品_byte, 32, array, 0, 4);
				属性4 = new Itimesx(array);
				return _属性4;
			}
			set
			{
				_属性4 = value;
			}
		}

		public int 物品防御力
		{
			get
			{
				return _物品防御力;
			}
			set
			{
				_物品防御力 = value;
			}
		}

		public int 物品对怪防御力
		{
			get
			{
				return _物品对怪防御力;
			}
			set
			{
				_物品对怪防御力 = value;
			}
		}

		public int 物品对怪攻击力
		{
			get
			{
				return _物品对怪攻击力;
			}
			set
			{
				_物品对怪攻击力 = value;
			}
		}

		public int 物品_中级附魂_追加_觉醒
		{
			get
			{
				return _物品_中级附魂_追加_觉醒;
			}
			set
			{
				_物品_中级附魂_追加_觉醒 = value;
			}
		}

		public int 物品攻击力
		{
			get
			{
				return _物品攻击力;
			}
			set
			{
				_物品攻击力 = value;
			}
		}

		public int 物品攻击力MAX
		{
			get
			{
				return _物品攻击力MAX;
			}
			set
			{
				_物品攻击力MAX = value;
			}
		}

		public int 物品属性_障力增加
		{
			get
			{
				return _物品属性_障力增加;
			}
			set
			{
				_物品属性_障力增加 = value;
			}
		}

		public int 物品属性强类型
		{
			get
			{
				return _物品属性强类型;
			}
			set
			{
				_物品属性强类型 = value;
			}
		}

		public int 物品属性强
		{
			get
			{
				return _物品属性强;
			}
			set
			{
				_物品属性强 = value;
			}
		}

		public int 物品属性阶段类型
		{
			get
			{
				return _物品属性阶段类型;
			}
			set
			{
				_物品属性阶段类型 = value;
			}
		}

		public int 物品属性阶段数
		{
			get
			{
				return _物品属性阶段数;
			}
			set
			{
				_物品属性阶段数 = value;
			}
		}

		public int 物品属性_攻击力增加
		{
			get
			{
				return _物品属性_攻击力增加;
			}
			set
			{
				_物品属性_攻击力增加 = value;
			}
		}

		public int 物品攻击力New
		{
			get
			{
				return _物品攻击力New;
			}
			set
			{
				_物品攻击力New = value;
			}
		}

		public int 物品攻击力MaxNew
		{
			get
			{
				return _物品攻击力MaxNew;
			}
			set
			{
				_物品攻击力MaxNew = value;
			}
		}

		public int 物品属性_防御力增加
		{
			get
			{
				return _物品属性_防御力增加;
			}
			set
			{
				_物品属性_防御力增加 = value;
			}
		}

		public int 物品防御力New
		{
			get
			{
				return _物品防御力New;
			}
			set
			{
				_物品防御力New = value;
			}
		}

		public int 物品属性_生命力增加
		{
			get
			{
				return _物品属性_生命力增加;
			}
			set
			{
				_物品属性_生命力增加 = value;
			}
		}

		public int 物品属性_障力恢复量增加
		{
			get
			{
				return _物品属性_障力恢复量增加;
			}
			set
			{
				_物品属性_障力恢复量增加 = value;
			}
		}

		public int 物品属性_内功力增加
		{
			get
			{
				return _物品属性_内功力增加;
			}
			set
			{
				_物品属性_内功力增加 = value;
			}
		}

		public int 物品属性_命中率增加
		{
			get
			{
				return _物品属性_命中率增加;
			}
			set
			{
				_物品属性_命中率增加 = value;
			}
		}

		public int 物品属性_回避率增加
		{
			get
			{
				return _物品属性_回避率增加;
			}
			set
			{
				_物品属性_回避率增加 = value;
			}
		}

		public int 物品属性_武功攻击力
		{
			get
			{
				return _物品属性_武功攻击力;
			}
			set
			{
				_物品属性_武功攻击力 = value;
			}
		}

		public int 物品属性_武功攻击力New
		{
			get
			{
				return _物品属性_武功攻击力New;
			}
			set
			{
				_物品属性_武功攻击力New = value;
			}
		}

		public double 物品属性_降低百分比攻击
		{
			get
			{
				return _物品属性_降低百分比攻击;
			}
			set
			{
				_物品属性_降低百分比攻击 = value;
			}
		}

		public double 物品属性_降低百分比防御
		{
			get
			{
				return _物品属性_降低百分比防御;
			}
			set
			{
				_物品属性_降低百分比防御 = value;
			}
		}

		public double 物品属性_增加百分比命中
		{
			get
			{
				return _物品属性_增加百分比命中;
			}
			set
			{
				_物品属性_增加百分比命中 = value;
			}
		}

		public double 物品属性_增加百分比回避
		{
			get
			{
				return _物品属性_增加百分比回避;
			}
			set
			{
				_物品属性_增加百分比回避 = value;
			}
		}

		public double 物品属性_初始化愤怒概率百分比
		{
			get
			{
				return _物品属性_初始化愤怒概率百分比;
			}
			set
			{
				_物品属性_初始化愤怒概率百分比 = value;
			}
		}

		public int 物品属性_愤怒值增加
		{
			get
			{
				return _物品属性_愤怒值增加;
			}
			set
			{
				_物品属性_愤怒值增加 = value;
			}
		}

		public int 物品属性_全部气功等级增加
		{
			get
			{
				return _物品属性_全部气功等级增加;
			}
			set
			{
				_物品属性_全部气功等级增加 = value;
			}
		}

		public int 物品属性_追加刀力劈华山
		{
			get
			{
				return _物品属性_追加刀力劈华山;
			}
			set
			{
				_物品属性_追加刀力劈华山 = value;
			}
		}

		public int 物品属性_追加刀摄魂一击
		{
			get
			{
				return _物品属性_追加刀摄魂一击;
			}
			set
			{
				_物品属性_追加刀摄魂一击 = value;
			}
		}

		public int 物品属性_追加刀连环飞舞
		{
			get
			{
				return _物品属性_追加刀连环飞舞;
			}
			set
			{
				_物品属性_追加刀连环飞舞 = value;
			}
		}

		public int 物品属性_追加升天三火龙之火
		{
			get
			{
				return _物品属性_追加升天三火龙之火;
			}
			set
			{
				_物品属性_追加升天三火龙之火 = value;
			}
		}

		public int 物品属性_追加刀狂风万破
		{
			get
			{
				return _物品属性_追加刀狂风万破;
			}
			set
			{
				_物品属性_追加刀狂风万破 = value;
			}
		}

		public int 物品属性_追加刀四两千斤
		{
			get
			{
				return _物品属性_追加刀四两千斤;
			}
			set
			{
				_物品属性_追加刀四两千斤 = value;
			}
		}

		public int 物品属性_追加刀霸气破甲
		{
			get
			{
				return _物品属性_追加刀霸气破甲;
			}
			set
			{
				_物品属性_追加刀霸气破甲 = value;
			}
		}

		public int 物品属性_追加刀真武绝击
		{
			get
			{
				return _物品属性_追加刀真武绝击;
			}
			set
			{
				_物品属性_追加刀真武绝击 = value;
			}
		}

		public int 物品属性_追加刀暗影绝杀
		{
			get
			{
				return _物品属性_追加刀暗影绝杀;
			}
			set
			{
				_物品属性_追加刀暗影绝杀 = value;
			}
		}

		public int 物品属性_追加刀稳如泰山
		{
			get
			{
				return _物品属性_追加刀稳如泰山;
			}
			set
			{
				_物品属性_追加刀稳如泰山 = value;
			}
		}

		public int 物品属性_追加刀流光乱舞
		{
			get
			{
				return _物品属性_追加刀流光乱舞;
			}
			set
			{
				_物品属性_追加刀流光乱舞 = value;
			}
		}

		public int 物品属性_追加刀梵音破镜
		{
			get
			{
				return _物品属性_追加刀梵音破镜;
			}
			set
			{
				_物品属性_追加刀梵音破镜 = value;
			}
		}

		public int 物品属性_追加剑长虹贯日
		{
			get
			{
				return _物品属性_追加剑长虹贯日;
			}
			set
			{
				_物品属性_追加剑长虹贯日 = value;
			}
		}

		public int 物品属性_追加剑百变神行
		{
			get
			{
				return _物品属性_追加剑百变神行;
			}
			set
			{
				_物品属性_追加剑百变神行 = value;
			}
		}

		public int 物品属性_追加剑连环飞舞
		{
			get
			{
				return _物品属性_追加剑连环飞舞;
			}
			set
			{
				_物品属性_追加剑连环飞舞 = value;
			}
		}

		public int 物品属性_追加剑破天一剑
		{
			get
			{
				return _物品属性_追加剑破天一剑;
			}
			set
			{
				_物品属性_追加剑破天一剑 = value;
			}
		}

		public int 物品属性_追加剑狂风万破
		{
			get
			{
				return _物品属性_追加剑狂风万破;
			}
			set
			{
				_物品属性_追加剑狂风万破 = value;
			}
		}

		public int 物品属性_追加升天一护身罡气
		{
			get
			{
				return _物品属性_追加升天一护身罡气;
			}
			set
			{
				_物品属性_追加升天一护身罡气 = value;
			}
		}

		public int 物品属性_追加剑移花接木
		{
			get
			{
				return _物品属性_追加剑移花接木;
			}
			set
			{
				_物品属性_追加剑移花接木 = value;
			}
		}

		public int 物品属性_追加剑回柳身法
		{
			get
			{
				return _物品属性_追加剑回柳身法;
			}
			set
			{
				_物品属性_追加剑回柳身法 = value;
			}
		}

		public int 物品属性_追加剑怒海狂澜
		{
			get
			{
				return _物品属性_追加剑怒海狂澜;
			}
			set
			{
				_物品属性_追加剑怒海狂澜 = value;
			}
		}

		public int 物品属性_追加剑冲冠一怒
		{
			get
			{
				return _物品属性_追加剑冲冠一怒;
			}
			set
			{
				_物品属性_追加剑冲冠一怒 = value;
			}
		}

		public int 物品属性_追加剑无坚不摧
		{
			get
			{
				return _物品属性_追加剑无坚不摧;
			}
			set
			{
				_物品属性_追加剑无坚不摧 = value;
			}
		}

		public int 物品属性_追加剑乘胜追击
		{
			get
			{
				return _物品属性_追加剑乘胜追击;
			}
			set
			{
				_物品属性_追加剑乘胜追击 = value;
			}
		}

		public int 物品属性_追加枪金钟罩气
		{
			get
			{
				return _物品属性_追加枪金钟罩气;
			}
			set
			{
				_物品属性_追加枪金钟罩气 = value;
			}
		}

		public int 物品属性_追加枪运气疗伤
		{
			get
			{
				return _物品属性_追加枪运气疗伤;
			}
			set
			{
				_物品属性_追加枪运气疗伤 = value;
			}
		}

		public int 物品属性_追加枪连环飞舞
		{
			get
			{
				return _物品属性_追加枪连环飞舞;
			}
			set
			{
				_物品属性_追加枪连环飞舞 = value;
			}
		}

		public int 物品属性_追加升天三怒意之火
		{
			get
			{
				return _物品属性_追加升天三怒意之火;
			}
			set
			{
				_物品属性_追加升天三怒意之火 = value;
			}
		}

		public int 物品属性_追加枪狂风万破
		{
			get
			{
				return _物品属性_追加枪狂风万破;
			}
			set
			{
				_物品属性_追加枪狂风万破 = value;
			}
		}

		public int 物品属性_追加枪横练太保
		{
			get
			{
				return _物品属性_追加枪横练太保;
			}
			set
			{
				_物品属性_追加枪横练太保 = value;
			}
		}

		public int 物品属性_追加枪乾坤挪移
		{
			get
			{
				return _物品属性_追加枪乾坤挪移;
			}
			set
			{
				_物品属性_追加枪乾坤挪移 = value;
			}
		}

		public int 物品属性_追加枪灵甲护身
		{
			get
			{
				return _物品属性_追加枪灵甲护身;
			}
			set
			{
				_物品属性_追加枪灵甲护身 = value;
			}
		}

		public int 物品属性_追加枪狂神降世
		{
			get
			{
				return _物品属性_追加枪狂神降世;
			}
			set
			{
				_物品属性_追加枪狂神降世 = value;
			}
		}

		public int 物品属性_追加枪转守为攻
		{
			get
			{
				return _物品属性_追加枪转守为攻;
			}
			set
			{
				_物品属性_追加枪转守为攻 = value;
			}
		}

		public int 物品属性_追加枪末日狂舞
		{
			get
			{
				return _物品属性_追加枪末日狂舞;
			}
			set
			{
				_物品属性_追加枪末日狂舞 = value;
			}
		}

		public int 物品属性_追加枪怒意之吼
		{
			get
			{
				return _物品属性_追加枪怒意之吼;
			}
			set
			{
				_物品属性_追加枪怒意之吼 = value;
			}
		}

		public int 物品属性_追加弓百步穿杨
		{
			get
			{
				return _物品属性_追加弓百步穿杨;
			}
			set
			{
				_物品属性_追加弓百步穿杨 = value;
			}
		}

		public int 物品属性_追加弓猎鹰之眼
		{
			get
			{
				return _物品属性_追加弓猎鹰之眼;
			}
			set
			{
				_物品属性_追加弓猎鹰之眼 = value;
			}
		}

		public int 物品属性_追加弓凝神聚气
		{
			get
			{
				return _物品属性_追加弓凝神聚气;
			}
			set
			{
				_物品属性_追加弓凝神聚气 = value;
			}
		}

		public int 物品属性_追加弓回流真气
		{
			get
			{
				return _物品属性_追加弓回流真气;
			}
			set
			{
				_物品属性_追加弓回流真气 = value;
			}
		}

		public int 物品属性_追加弓狂风万破
		{
			get
			{
				return _物品属性_追加弓狂风万破;
			}
			set
			{
				_物品属性_追加弓狂风万破 = value;
			}
		}

		public int 物品属性_追加弓正本培元
		{
			get
			{
				return _物品属性_追加弓正本培元;
			}
			set
			{
				_物品属性_追加弓正本培元 = value;
			}
		}

		public int 物品属性_追加弓心神凝聚
		{
			get
			{
				return _物品属性_追加弓心神凝聚;
			}
			set
			{
				_物品属性_追加弓心神凝聚 = value;
			}
		}

		public int 物品属性_追加弓流星三矢
		{
			get
			{
				return _物品属性_追加弓流星三矢;
			}
			set
			{
				_物品属性_追加弓流星三矢 = value;
			}
		}

		public int 物品属性_追加弓锐利之箭
		{
			get
			{
				return _物品属性_追加弓锐利之箭;
			}
			set
			{
				_物品属性_追加弓锐利之箭 = value;
			}
		}

		public int 物品属性_追加弓无明暗矢
		{
			get
			{
				return _物品属性_追加弓无明暗矢;
			}
			set
			{
				_物品属性_追加弓无明暗矢 = value;
			}
		}

		public int 物品属性_追加弓致命绝杀
		{
			get
			{
				return _物品属性_追加弓致命绝杀;
			}
			set
			{
				_物品属性_追加弓致命绝杀 = value;
			}
		}

		public int 物品属性_追加医运气行心
		{
			get
			{
				return _物品属性_追加医运气行心;
			}
			set
			{
				_物品属性_追加医运气行心 = value;
			}
		}

		public int 物品属性_追加医太极心法
		{
			get
			{
				return _物品属性_追加医太极心法;
			}
			set
			{
				_物品属性_追加医太极心法 = value;
			}
		}

		public int 物品属性_追加医体血倍增
		{
			get
			{
				return _物品属性_追加医体血倍增;
			}
			set
			{
				_物品属性_追加医体血倍增 = value;
			}
		}

		public int 物品属性_追加医洗髓易经
		{
			get
			{
				return _物品属性_追加医洗髓易经;
			}
			set
			{
				_物品属性_追加医洗髓易经 = value;
			}
		}

		public int 物品属性_追加医妙手回春
		{
			get
			{
				return _物品属性_追加医妙手回春;
			}
			set
			{
				_物品属性_追加医妙手回春 = value;
			}
		}

		public int 物品属性_追加医长功攻击
		{
			get
			{
				return _物品属性_追加医长功攻击;
			}
			set
			{
				_物品属性_追加医长功攻击 = value;
			}
		}

		public int 物品属性_追加医吸星大法
		{
			get
			{
				return _物品属性_追加医吸星大法;
			}
			set
			{
				_物品属性_追加医吸星大法 = value;
			}
		}

		public int 物品属性_追加医真武绝击
		{
			get
			{
				return _物品属性_追加医真武绝击;
			}
			set
			{
				_物品属性_追加医真武绝击 = value;
			}
		}

		public int 物品属性_追加升天一护身气甲
		{
			get
			{
				return _物品属性_追加升天一护身气甲;
			}
			set
			{
				_物品属性_追加升天一护身气甲 = value;
			}
		}

		public int 物品属性_追加医九天真气
		{
			get
			{
				return _物品属性_追加医九天真气;
			}
			set
			{
				_物品属性_追加医九天真气 = value;
			}
		}

		public int 物品属性_追加医狂意护体
		{
			get
			{
				return _物品属性_追加医狂意护体;
			}
			set
			{
				_物品属性_追加医狂意护体 = value;
			}
		}

		public int 物品属性_追加医无中生有
		{
			get
			{
				return _物品属性_追加医无中生有;
			}
			set
			{
				_物品属性_追加医无中生有 = value;
			}
		}

		public int 物品属性_追加刺荆轲之怒
		{
			get
			{
				return _物品属性_追加刺荆轲之怒;
			}
			set
			{
				_物品属性_追加刺荆轲之怒 = value;
			}
		}

		public int 物品属性_追加刺三花聚顶
		{
			get
			{
				return _物品属性_追加刺三花聚顶;
			}
			set
			{
				_物品属性_追加刺三花聚顶 = value;
			}
		}

		public int 物品属性_追加刺连环飞舞
		{
			get
			{
				return _物品属性_追加刺连环飞舞;
			}
			set
			{
				_物品属性_追加刺连环飞舞 = value;
			}
		}

		public int 物品属性_追加刺一招残杀
		{
			get
			{
				return _物品属性_追加刺一招残杀;
			}
			set
			{
				_物品属性_追加刺一招残杀 = value;
			}
		}

		public int 物品属性_追加刺心神凝聚
		{
			get
			{
				return _物品属性_追加刺心神凝聚;
			}
			set
			{
				_物品属性_追加刺心神凝聚 = value;
			}
		}

		public int 物品属性_追加刺致手绝命
		{
			get
			{
				return _物品属性_追加刺致手绝命;
			}
			set
			{
				_物品属性_追加刺致手绝命 = value;
			}
		}

		public int 物品属性_追加刺先发制人
		{
			get
			{
				return _物品属性_追加刺先发制人;
			}
			set
			{
				_物品属性_追加刺先发制人 = value;
			}
		}

		public int 物品属性_追加刺千株万手
		{
			get
			{
				return _物品属性_追加刺千株万手;
			}
			set
			{
				_物品属性_追加刺千株万手 = value;
			}
		}

		public int 物品属性_追加刺连消带打
		{
			get
			{
				return _物品属性_追加刺连消带打;
			}
			set
			{
				_物品属性_追加刺连消带打 = value;
			}
		}

		public int 物品属性_追加刺剑刃乱舞
		{
			get
			{
				return _物品属性_追加刺剑刃乱舞;
			}
			set
			{
				_物品属性_追加刺剑刃乱舞 = value;
			}
		}

		public int 物品属性_追加刺以怒还怒
		{
			get
			{
				return _物品属性_追加刺以怒还怒;
			}
			set
			{
				_物品属性_追加刺以怒还怒 = value;
			}
		}

		public int 物品属性_追加琴战马奔腾
		{
			get
			{
				return _物品属性_追加琴战马奔腾;
			}
			set
			{
				_物品属性_追加琴战马奔腾 = value;
			}
		}

		public int 物品属性_追加琴秋江夜泊
		{
			get
			{
				return _物品属性_追加琴秋江夜泊;
			}
			set
			{
				_物品属性_追加琴秋江夜泊 = value;
			}
		}

		public int 物品属性_追加琴清心普善
		{
			get
			{
				return _物品属性_追加琴清心普善;
			}
			set
			{
				_物品属性_追加琴清心普善 = value;
			}
		}

		public int 物品属性_追加琴阳关三叠
		{
			get
			{
				return _物品属性_追加琴阳关三叠;
			}
			set
			{
				_物品属性_追加琴阳关三叠 = value;
			}
		}

		public int 物品属性_追加琴汉宫秋月
		{
			get
			{
				return _物品属性_追加琴汉宫秋月;
			}
			set
			{
				_物品属性_追加琴汉宫秋月 = value;
			}
		}

		public int 物品属性_追加琴高山流水
		{
			get
			{
				return _物品属性_追加琴高山流水;
			}
			set
			{
				_物品属性_追加琴高山流水 = value;
			}
		}

		public int 物品属性_追加琴岳阳三醉
		{
			get
			{
				return _物品属性_追加琴岳阳三醉;
			}
			set
			{
				_物品属性_追加琴岳阳三醉 = value;
			}
		}

		public int 物品属性_追加琴梅花三弄
		{
			get
			{
				return _物品属性_追加琴梅花三弄;
			}
			set
			{
				_物品属性_追加琴梅花三弄 = value;
			}
		}

		public int 物品属性_追加琴鸾凤和鸣
		{
			get
			{
				return _物品属性_追加琴鸾凤和鸣;
			}
			set
			{
				_物品属性_追加琴鸾凤和鸣 = value;
			}
		}

		public int 物品属性_追加琴阳明春晓
		{
			get
			{
				return _物品属性_追加琴阳明春晓;
			}
			set
			{
				_物品属性_追加琴阳明春晓 = value;
			}
		}

		public int 物品属性_追加琴潇湘雨夜
		{
			get
			{
				return _物品属性_追加琴潇湘雨夜;
			}
			set
			{
				_物品属性_追加琴潇湘雨夜 = value;
			}
		}

		public int 物品属性_追加韩力劈华山
		{
			get
			{
				return _物品属性_追加韩力劈华山;
			}
			set
			{
				_物品属性_追加韩力劈华山 = value;
			}
		}

		public int 物品属性_追加韩摄魂一击
		{
			get
			{
				return _物品属性_追加韩摄魂一击;
			}
			set
			{
				_物品属性_追加韩摄魂一击 = value;
			}
		}

		public int 物品属性_追加韩天魔狂血
		{
			get
			{
				return _物品属性_追加韩天魔狂血;
			}
			set
			{
				_物品属性_追加韩天魔狂血 = value;
			}
		}

		public int 物品属性_追加韩百变神行
		{
			get
			{
				return _物品属性_追加韩百变神行;
			}
			set
			{
				_物品属性_追加韩百变神行 = value;
			}
		}

		public int 物品属性_追加韩狂风万破
		{
			get
			{
				return _物品属性_追加韩狂风万破;
			}
			set
			{
				_物品属性_追加韩狂风万破 = value;
			}
		}

		public int 物品属性_追加韩追骨吸元
		{
			get
			{
				return _物品属性_追加韩追骨吸元;
			}
			set
			{
				_物品属性_追加韩追骨吸元 = value;
			}
		}

		public int 物品属性_追加韩霸气破甲
		{
			get
			{
				return _物品属性_追加韩霸气破甲;
			}
			set
			{
				_物品属性_追加韩霸气破甲 = value;
			}
		}

		public int 物品属性_追加韩真武绝击
		{
			get
			{
				return _物品属性_追加韩真武绝击;
			}
			set
			{
				_物品属性_追加韩真武绝击 = value;
			}
		}

		public int 物品属性_追加韩暗影绝杀
		{
			get
			{
				return _物品属性_追加韩暗影绝杀;
			}
			set
			{
				_物品属性_追加韩暗影绝杀 = value;
			}
		}

		public int 物品属性_追加韩火龙问鼎
		{
			get
			{
				return _物品属性_追加韩火龙问鼎;
			}
			set
			{
				_物品属性_追加韩火龙问鼎 = value;
			}
		}

		public int 物品属性_追加韩流光乱舞
		{
			get
			{
				return _物品属性_追加韩流光乱舞;
			}
			set
			{
				_物品属性_追加韩流光乱舞 = value;
			}
		}

		public int 物品属性_追加谭长虹贯日
		{
			get
			{
				return _物品属性_追加谭长虹贯日;
			}
			set
			{
				_物品属性_追加谭长虹贯日 = value;
			}
		}

		public int 物品属性_追加谭百变神行
		{
			get
			{
				return _物品属性_追加谭百变神行;
			}
			set
			{
				_物品属性_追加谭百变神行 = value;
			}
		}

		public int 物品属性_追加谭新_连环飞舞
		{
			get
			{
				return _物品属性_追加谭新_连环飞舞;
			}
			set
			{
				_物品属性_追加谭新_连环飞舞 = value;
			}
		}

		public int 物品属性_追加谭招式新法
		{
			get
			{
				return _物品属性_追加谭招式新法;
			}
			set
			{
				_物品属性_追加谭招式新法 = value;
			}
		}

		public int 物品属性_追加谭狂风万破
		{
			get
			{
				return _物品属性_追加谭狂风万破;
			}
			set
			{
				_物品属性_追加谭狂风万破 = value;
			}
		}

		public int 物品属性_追加谭护身罡气
		{
			get
			{
				return _物品属性_追加谭护身罡气;
			}
			set
			{
				_物品属性_追加谭护身罡气 = value;
			}
		}

		public int 物品属性_追加谭移花接木
		{
			get
			{
				return _物品属性_追加谭移花接木;
			}
			set
			{
				_物品属性_追加谭移花接木 = value;
			}
		}

		public int 物品属性_追加谭纵横无双
		{
			get
			{
				return _物品属性_追加谭纵横无双;
			}
			set
			{
				_物品属性_追加谭纵横无双 = value;
			}
		}

		public int 物品属性_追加谭回柳身法
		{
			get
			{
				return _物品属性_追加谭回柳身法;
			}
			set
			{
				_物品属性_追加谭回柳身法 = value;
			}
		}

		public int 物品属性_追加谭怒海狂澜
		{
			get
			{
				return _物品属性_追加谭怒海狂澜;
			}
			set
			{
				_物品属性_追加谭怒海狂澜 = value;
			}
		}

		public int 物品属性_追加谭冲冠一怒
		{
			get
			{
				return _物品属性_追加谭冲冠一怒;
			}
			set
			{
				_物品属性_追加谭冲冠一怒 = value;
			}
		}

		public int 物品属性_追加升天一遁出逆境
		{
			get
			{
				return _物品属性_追加升天一遁出逆境;
			}
			set
			{
				_物品属性_追加升天一遁出逆境 = value;
			}
		}

		public int 物品属性_追加升天二穷途末路
		{
			get
			{
				return _物品属性_追加升天二穷途末路;
			}
			set
			{
				_物品属性_追加升天二穷途末路 = value;
			}
		}

		public int 物品属性_追加升天四红月狂风
		{
			get
			{
				return _物品属性_追加升天四红月狂风;
			}
			set
			{
				_物品属性_追加升天四红月狂风 = value;
			}
		}

		public int 物品属性_追加升天四毒蛇出洞
		{
			get
			{
				return _物品属性_追加升天四毒蛇出洞;
			}
			set
			{
				_物品属性_追加升天四毒蛇出洞 = value;
			}
		}

		public int 物品属性_追加升天四满月狂风
		{
			get
			{
				return _物品属性_追加升天四满月狂风;
			}
			set
			{
				_物品属性_追加升天四满月狂风 = value;
			}
		}

		public int 物品属性_追加升天四烈日炎炎
		{
			get
			{
				return _物品属性_追加升天四烈日炎炎;
			}
			set
			{
				_物品属性_追加升天四烈日炎炎 = value;
			}
		}

		public int 物品属性_追加升天四长虹贯天
		{
			get
			{
				return _物品属性_追加升天四长虹贯天;
			}
			set
			{
				_物品属性_追加升天四长虹贯天 = value;
			}
		}

		public int 物品属性_追加升天四哀鸿遍野
		{
			get
			{
				return _物品属性_追加升天四哀鸿遍野;
			}
			set
			{
				_物品属性_追加升天四哀鸿遍野 = value;
			}
		}

		public int 物品属性_追加升天夺命连环
		{
			get
			{
				return _物品属性_追加升天夺命连环;
			}
			set
			{
				_物品属性_追加升天夺命连环 = value;
			}
		}

		public int 物品属性_追加升天电光石火
		{
			get
			{
				return _物品属性_追加升天电光石火;
			}
			set
			{
				_物品属性_追加升天电光石火 = value;
			}
		}

		public int 物品属性_追加升天精益求精
		{
			get
			{
				return _物品属性_追加升天精益求精;
			}
			set
			{
				_物品属性_追加升天精益求精 = value;
			}
		}

		public int 物品属性_追加升天二天地同寿
		{
			get
			{
				return _物品属性_追加升天二天地同寿;
			}
			set
			{
				_物品属性_追加升天二天地同寿 = value;
			}
		}

		public int 物品属性_追加升天三火凤临朝
		{
			get
			{
				return _物品属性_追加升天三火凤临朝;
			}
			set
			{
				_物品属性_追加升天三火凤临朝 = value;
			}
		}

		public int 物品属性_追加升天一破甲刺魂
		{
			get
			{
				return _物品属性_追加升天一破甲刺魂;
			}
			set
			{
				_物品属性_追加升天一破甲刺魂 = value;
			}
		}

		public int 物品属性_追加升天二以退为进
		{
			get
			{
				return _物品属性_追加升天二以退为进;
			}
			set
			{
				_物品属性_追加升天二以退为进 = value;
			}
		}

		public int 物品属性_追加升天一绝影射魂
		{
			get
			{
				return _物品属性_追加升天一绝影射魂;
			}
			set
			{
				_物品属性_追加升天一绝影射魂 = value;
			}
		}

		public int 物品属性_追加升天二千钧压驼
		{
			get
			{
				return _物品属性_追加升天二千钧压驼;
			}
			set
			{
				_物品属性_追加升天二千钧压驼 = value;
			}
		}

		public int 物品属性_追加升天二万物回春
		{
			get
			{
				return _物品属性_追加升天二万物回春;
			}
			set
			{
				_物品属性_追加升天二万物回春 = value;
			}
		}

		public int 物品属性_追加升天三天外三矢
		{
			get
			{
				return _物品属性_追加升天三天外三矢;
			}
			set
			{
				_物品属性_追加升天三天外三矢 = value;
			}
		}

		public int 物品属性_追加升天三明镜止水
		{
			get
			{
				return _物品属性_追加升天三明镜止水;
			}
			set
			{
				_物品属性_追加升天三明镜止水 = value;
			}
		}

		public int 物品属性_追加升天四望梅添花
		{
			get
			{
				return _物品属性_追加升天四望梅添花;
			}
			set
			{
				_物品属性_追加升天四望梅添花 = value;
			}
		}

		public int 物品属性_追加升天一夜魔缠身
		{
			get
			{
				return _物品属性_追加升天一夜魔缠身;
			}
			set
			{
				_物品属性_追加升天一夜魔缠身 = value;
			}
		}

		public int 物品属性_追加升天二顺水推舟
		{
			get
			{
				return _物品属性_追加升天二顺水推舟;
			}
			set
			{
				_物品属性_追加升天二顺水推舟 = value;
			}
		}

		public int 物品属性_追加升天三无情打击
		{
			get
			{
				return _物品属性_追加升天三无情打击;
			}
			set
			{
				_物品属性_追加升天三无情打击 = value;
			}
		}

		public int 物品属性_追加升天三以柔克刚
		{
			get
			{
				return _物品属性_追加升天三以柔克刚;
			}
			set
			{
				_物品属性_追加升天三以柔克刚 = value;
			}
		}

		public int 物品属性_追加升天三内息行心
		{
			get
			{
				return _物品属性_追加升天三内息行心;
			}
			set
			{
				_物品属性_追加升天三内息行心 = value;
			}
		}

		public int 物品属性_追加升天二天魔护体
		{
			get
			{
				return _物品属性_追加升天二天魔护体;
			}
			set
			{
				_物品属性_追加升天二天魔护体 = value;
			}
		}

		public int 物品属性_追加升天一行风弄舞
		{
			get
			{
				return _物品属性_追加升天一行风弄舞;
			}
			set
			{
				_物品属性_追加升天一行风弄舞 = value;
			}
		}

		public int 物品属性_追加升天四悬丝诊脉
		{
			get
			{
				return _物品属性_追加升天四悬丝诊脉;
			}
			set
			{
				_物品属性_追加升天四悬丝诊脉 = value;
			}
		}

		public int 物品属性_追加升天三子夜秋歌
		{
			get
			{
				return _物品属性_追加升天三子夜秋歌;
			}
			set
			{
				_物品属性_追加升天三子夜秋歌 = value;
			}
		}

		public int 物品属性_追加升天二三潭映月
		{
			get
			{
				return _物品属性_追加升天二三潭映月;
			}
			set
			{
				_物品属性_追加升天二三潭映月 = value;
			}
		}

		public int 物品属性_追加升天一力劈华山
		{
			get
			{
				return _物品属性_追加升天一力劈华山;
			}
			set
			{
				_物品属性_追加升天一力劈华山 = value;
			}
		}

		public int 物品属性_追加升天一长虹贯日
		{
			get
			{
				return _物品属性_追加升天一长虹贯日;
			}
			set
			{
				_物品属性_追加升天一长虹贯日 = value;
			}
		}

		public int 物品属性_追加升天一金钟罡气
		{
			get
			{
				return _物品属性_追加升天一金钟罡气;
			}
			set
			{
				_物品属性_追加升天一金钟罡气 = value;
			}
		}

		public int 物品属性_追加升天一运气行心
		{
			get
			{
				return _物品属性_追加升天一运气行心;
			}
			set
			{
				_物品属性_追加升天一运气行心 = value;
			}
		}

		public int 物品属性_追加升天一正本培源
		{
			get
			{
				return _物品属性_追加升天一正本培源;
			}
			set
			{
				_物品属性_追加升天一正本培源 = value;
			}
		}

		public int 物品属性_追加升天一运气疗伤
		{
			get
			{
				return _物品属性_追加升天一运气疗伤;
			}
			set
			{
				_物品属性_追加升天一运气疗伤 = value;
			}
		}

		public int 物品属性_追加升天一百变神行
		{
			get
			{
				return _物品属性_追加升天一百变神行;
			}
			set
			{
				_物品属性_追加升天一百变神行 = value;
			}
		}

		public int 物品属性_追加升天一狂风天意
		{
			get
			{
				return _物品属性_追加升天一狂风天意;
			}
			set
			{
				_物品属性_追加升天一狂风天意 = value;
			}
		}

		public int 物品属性_追加升天一飞花点翠
		{
			get
			{
				return _物品属性_追加升天一飞花点翠;
			}
			set
			{
				_物品属性_追加升天一飞花点翠 = value;
			}
		}

		public int 物品属性_升级成功率
		{
			get
			{
				return _物品属性_升级成功率;
			}
			set
			{
				_物品属性_升级成功率 = value;
			}
		}

		public int 物品属性_追加伤害值
		{
			get
			{
				return _物品属性_追加伤害值;
			}
			set
			{
				_物品属性_追加伤害值 = value;
			}
		}

		public int 物品属性_降低伤害值
		{
			get
			{
				return _物品属性_降低伤害值;
			}
			set
			{
				_物品属性_降低伤害值 = value;
			}
		}

		public double 物品属性_追加中毒几率百分比
		{
			get
			{
				return _物品属性_追加中毒几率百分比;
			}
			set
			{
				_物品属性_追加中毒几率百分比 = value;
			}
		}

		public double 物品属性_追加强化
		{
			get
			{
				return _物品属性_追加强化;
			}
			set
			{
				_物品属性_追加强化 = value;
			}
		}

		public int 物品属性_武功防御力增加
		{
			get
			{
				return _物品属性_武功防御力增加;
			}
			set
			{
				_物品属性_武功防御力增加 = value;
			}
		}

		public int 物品属性_武功防御力增加New
		{
			get
			{
				return _物品属性_武功防御力增加New;
			}
			set
			{
				_物品属性_武功防御力增加New = value;
			}
		}

		public int 物品属性_获得金钱增加
		{
			get
			{
				return _物品属性_获得金钱增加;
			}
			set
			{
				_物品属性_获得金钱增加 = value;
			}
		}

		public int 物品属性_死亡损失经验减少
		{
			get
			{
				return _物品属性_死亡损失经验减少;
			}
			set
			{
				_物品属性_死亡损失经验减少 = value;
			}
		}

		public int 物品属性_经验获得增加
		{
			get
			{
				return _物品属性_经验获得增加;
			}
			set
			{
				_物品属性_经验获得增加 = value;
			}
		}

		public int FLD_LEVEL
		{
			get
			{
				return _FLD_LEVEL;
			}
			set
			{
				_FLD_LEVEL = value;
			}
		}

		public int FLD_RESIDE2
		{
			get
			{
				return _FLD_RESIDE2;
			}
			set
			{
				_FLD_RESIDE2 = value;
			}
		}

		public int FLD_MAGIC0
		{
			get
			{
				byte[] array = new byte[4];
				System.Buffer.BlockCopy(物品_byte, 16, array, 0, 4);
				return Buffer.ToInt32(array, 0);
			}
			set
			{
				System.Buffer.BlockCopy(Buffer.GetBytes(value), 0, 物品_byte, 16, 2);
			}
		}

		public int FLD_强化类型
		{
			get
			{
				int fLD_MAGIC = FLD_MAGIC0;
				if (fLD_MAGIC <= 0)
				{
					return 0;
				}
				string text = fLD_MAGIC.ToString();
				return int.Parse(text.Substring(text.Length - 8, 1));
			}
		}

		public int FLD_强化数量
		{
			get
			{
				int fLD_MAGIC = FLD_MAGIC0;
				if (fLD_MAGIC <= 0)
				{
					return 0;
				}
				string text = fLD_MAGIC.ToString();
				return int.Parse(text.Substring(text.Length - 2, 2));
			}
		}

		public int FLD_属性类型
		{
			get
			{
				int fLD_MAGIC = FLD_MAGIC0;
				if (fLD_MAGIC > 0 && fLD_MAGIC > 1000000000)
				{
					string text = fLD_MAGIC.ToString();
					return int.Parse(text.Substring(text.Length - 4, 1));
				}
				return 0;
			}
		}

		public int FLD_属性数量
		{
			get
			{
				int fLD_MAGIC = FLD_MAGIC0;
				if (fLD_MAGIC > 0 && fLD_MAGIC > 1000000000)
				{
					string text = fLD_MAGIC.ToString();
					return int.Parse(text.Substring(text.Length - 3, 1));
				}
				return 0;
			}
		}

		public int FLD_MAGIC1
		{
			get
			{
				byte[] array = new byte[4];
				System.Buffer.BlockCopy(物品_byte, 20, array, 0, 4);
				return Buffer.ToInt32(array, 0);
			}
			set
			{
				System.Buffer.BlockCopy(Buffer.GetBytes(value), 0, 物品_byte, 20, 2);
			}
		}

		public int FLD_MAGIC2
		{
			get
			{
				byte[] array = new byte[4];
				System.Buffer.BlockCopy(物品_byte, 24, array, 0, 4);
				return Buffer.ToInt32(array, 0);
			}
			set
			{
				System.Buffer.BlockCopy(Buffer.GetBytes(value), 0, 物品_byte, 24, 2);
			}
		}

		public int FLD_MAGIC3
		{
			get
			{
				byte[] array = new byte[4];
				System.Buffer.BlockCopy(物品_byte, 28, array, 0, 4);
				return Buffer.ToInt32(array, 0);
			}
			set
			{
				System.Buffer.BlockCopy(Buffer.GetBytes(value), 0, 物品_byte, 28, 2);
			}
		}

		public int FLD_MAGIC4
		{
			get
			{
				byte[] array = new byte[4];
				System.Buffer.BlockCopy(物品_byte, 32, array, 0, 4);
				return Buffer.ToInt32(array, 0);
			}
			set
			{
				System.Buffer.BlockCopy(Buffer.GetBytes(value), 0, 物品_byte, 32, 2);
			}
		}

		public int FLD_FJ_MAGIC0
		{
			get
			{
				byte[] array = new byte[2];
				System.Buffer.BlockCopy(物品_byte, 36, array, 0, 2);
				return Buffer.ToInt16(array, 0);
			}
			set
			{
				System.Buffer.BlockCopy(Buffer.GetBytes(value), 0, 物品_byte, 36, 2);
			}
		}

		public int FLD_FJ_MAGIC1
		{
			get
			{
				byte[] array = new byte[2];
				System.Buffer.BlockCopy(物品_byte, 38, array, 0, 2);
				return Buffer.ToInt16(array, 0);
			}
			set
			{
				System.Buffer.BlockCopy(Buffer.GetBytes(value), 0, 物品_byte, 38, 2);
			}
		}

		public int FLD_FJ_中级附魂
		{
			get
			{
				try
				{
					byte[] array = new byte[2];
					System.Buffer.BlockCopy(物品_byte, 40, array, 0, 2);
					return Buffer.ToInt16(array, 0);
				}
				catch (Exception ex)
				{
					Form1.WriteLine(1, "FLD_FJ_中级附魂   Get出错：   [" + 得到物品string() + "]" + ((ex != null) ? ex.ToString() : null));
					return 0;
				}
			}
			set
			{
				try
				{
					if (value > 0)
					{
						System.Buffer.BlockCopy(Buffer.GetBytes(1), 0, 物品_byte, 38, 2);
					}
					else if (value == 0)
					{
						System.Buffer.BlockCopy(Buffer.GetBytes(0), 0, 物品_byte, 38, 2);
					}
					System.Buffer.BlockCopy(Buffer.GetBytes(value), 0, 物品_byte, 40, 2);
				}
				catch (Exception ex)
				{
					Form1.WriteLine(1, "FLD_FJ_中级附魂   Set出错：   [" + 得到物品string() + "]" + ((ex != null) ? ex.ToString() : null));
				}
			}
		}

		public int FLD_FJ_MAGIC2
		{
			get
			{
				byte[] array = new byte[2];
				System.Buffer.BlockCopy(物品_byte, 42, array, 0, 2);
				return Buffer.ToInt16(array, 0);
			}
			set
			{
				System.Buffer.BlockCopy(Buffer.GetBytes(value), 0, 物品_byte, 42, 2);
			}
		}

		public int FLD_FJ_MAGIC3
		{
			get
			{
				byte[] array = new byte[2];
				System.Buffer.BlockCopy(物品_byte, 44, array, 0, 2);
				return Buffer.ToInt16(array, 0);
			}
			set
			{
				System.Buffer.BlockCopy(Buffer.GetBytes(value), 0, 物品_byte, 44, 2);
			}
		}

		public int FLD_FJ_MAGIC4
		{
			get
			{
				byte[] array = new byte[2];
				System.Buffer.BlockCopy(物品_byte, 46, array, 0, 2);
				return Buffer.ToInt16(array, 0);
			}
			set
			{
				System.Buffer.BlockCopy(Buffer.GetBytes(value), 0, 物品_byte, 46, 2);
			}
		}

		public int FLD_FJ_MAGIC5
		{
			get
			{
				byte[] array = new byte[2];
				System.Buffer.BlockCopy(物品_byte, 48, array, 0, 2);
				return Buffer.ToInt16(array, 0);
			}
			set
			{
				System.Buffer.BlockCopy(Buffer.GetBytes(value), 0, 物品_byte, 48, 2);
			}
		}

		public int FLD_JSSJ
		{
			get
			{
				byte[] array = new byte[4];
				System.Buffer.BlockCopy(物品_byte, 56, array, 0, 4);
				DateTime dateTime = new DateTime(1970, 1, 1, 8, 0, 0).AddSeconds(BitConverter.ToInt32(array, 0));
				return BitConverter.ToInt32(array, 0);
			}
			set
			{
				System.Buffer.BlockCopy(BitConverter.GetBytes(value), 0, 物品_byte, 56, 4);
			}
		}

		public int FLD_KSSJ
		{
			get
			{
				byte[] array = new byte[4];
				System.Buffer.BlockCopy(物品_byte, 52, array, 0, 4);
				return BitConverter.ToInt32(array, 0);
			}
			set
			{
				System.Buffer.BlockCopy(BitConverter.GetBytes(value), 0, 物品_byte, 52, 4);
			}
		}

		public int FLD_FJ_觉醒
		{
			get
			{
				byte[] array = new byte[4];
				System.Buffer.BlockCopy(物品_byte, 62, array, 0, 4);
				return Buffer.ToInt32(array, 0);
			}
			set
			{
				System.Buffer.BlockCopy(Buffer.GetBytes(value), 0, 物品_byte, 62, 4);
			}
		}

		public int FLD_FJ_NJ
		{
			get
			{
				byte[] array = new byte[2];
				System.Buffer.BlockCopy(物品_byte, 60, array, 0, 2);
				return Buffer.ToInt16(array, 0);
			}
			set
			{
				System.Buffer.BlockCopy(Buffer.GetBytes(value), 0, 物品_byte, 60, 2);
			}
		}

		public int FLD_FJ_进化
		{
			get
			{
				byte[] array = new byte[4];
				System.Buffer.BlockCopy(物品_byte, 68, array, 0, 2);
				return Buffer.ToInt32(array, 0);
			}
			set
			{
				System.Buffer.BlockCopy(Buffer.GetBytes(value), 0, 物品_byte, 68, 2);
			}
		}

		public int FLD_FJ_四神之力
		{
			get
			{
				byte[] array = new byte[2];
				System.Buffer.BlockCopy(物品_byte, 72, array, 0, 1);
				return Buffer.ToInt16(array, 0);
			}
			set
			{
				System.Buffer.BlockCopy(Buffer.GetBytes(value), 0, 物品_byte, 72, 1);
			}
		}

		public byte[] GetByte()
		{
			发包类 发包类 = new 发包类();
			发包类.Write(Get物品全局ID);
			if (物品绑定)
			{
				发包类.Write(Get物品ID + 20000L);
			}
			else
			{
				发包类.Write(Get物品ID);
			}
			发包类.Write4(Get物品数量);
			发包类.Write4(FLD_MAGIC0);
			发包类.Write4(FLD_MAGIC1);
			发包类.Write4(FLD_MAGIC2);
			发包类.Write4(FLD_MAGIC3);
			发包类.Write4(FLD_MAGIC4);
			发包类.Write2(FLD_FJ_MAGIC0);
			发包类.Write2(FLD_FJ_MAGIC1);
			发包类.Write2(FLD_FJ_中级附魂);
			发包类.Write2(FLD_FJ_MAGIC2);
			发包类.Write2(FLD_FJ_MAGIC3);
			发包类.Write2(FLD_FJ_MAGIC4);
			发包类.Write2(FLD_FJ_MAGIC5);
			发包类.Write2(0);
			发包类.Write4(FLD_KSSJ);
			发包类.Write4(FLD_JSSJ);
			发包类.Write2(FLD_FJ_NJ);
			发包类.Write4(FLD_FJ_觉醒 + 物品_中级附魂_追加_觉醒);
			发包类.Write2(0);
			发包类.Write2(FLD_FJ_进化);
			发包类.Write2(0);
			发包类.Write4(FLD_FJ_四神之力);
			发包类.Write4(0);
			发包类.Write4(0);
			发包类.Write4(0);
			发包类.Write4(0);
			return 发包类.ToArray3();
		}

		public 物品类()
		{
		}

		public 物品类(byte[] 物品_byte_)
		{
			物品_byte = 物品_byte_;
		}

		public 物品类(byte[] 物品_byte_, int 位置)
		{
			物品_byte = 物品_byte_;
			物品位置 = 位置;
		}

		public void Dispose()
		{
		}

		public string 得到物品string()
		{
			try
			{
				return Converter.ToString(物品_byte);
			}
			catch
			{
				return string.Empty;
			}
		}

		public int 得到物品单个重量()
		{
			try
			{
				ItmeClass value;
				return World.Itme.TryGetValue(Buffer.ToInt32(物品ID, 0), out value) ? value.FLD_WEIGHT : 0;
			}
			catch
			{
				return 0;
			}
		}

		public int 得到物品重量()
		{
			try
			{
				ItmeClass value;
				return World.Itme.TryGetValue(Buffer.ToInt32(物品ID, 0), out value) ? (value.FLD_WEIGHT * Buffer.ToInt32(物品数量, 0)) : 0;
			}
			catch
			{
				return 0;
			}
		}

		public byte[] 得到物品属性()
		{
			byte[] array = new byte[56];
			System.Buffer.BlockCopy(物品_byte, 16, array, 0, 56);
			return array;
		}

		public byte[] 得到全局ID()
		{
			byte[] array = new byte[8];
			System.Buffer.BlockCopy(物品_byte, 0, array, 0, 8);
			return array;
		}

		public byte[] 得到物品ID()
		{
			byte[] array = new byte[4];
			System.Buffer.BlockCopy(物品_byte, 8, array, 0, 4);
			return array;
		}

		public byte[] 得到物品数量()
		{
			byte[] array = new byte[4];
			System.Buffer.BlockCopy(物品_byte, 12, array, 0, 4);
			return array;
		}

		public void 设置物品数量(byte[] 数量)
		{
			System.Buffer.BlockCopy(数量, 0, 物品_byte, 12, 4);
		}

		public int 得到物品类型()
		{
			int key = Buffer.ToInt32(得到物品ID(), 0);
			return World.Itme[key].FLD_SIDE;
		}

		public int 得到物品位置类型()
		{
			byte[] byte_ = 得到物品ID();
			ItmeClass value;
			if (!World.Itme.TryGetValue(Buffer.ToInt32(byte_, 0), out value))
			{
				return 0;
			}
			return value.FLD_RESIDE2;
		}

		public string 得到物品名称()
		{
			ItmeClass value;
			if (!World.Itme.TryGetValue(Buffer.ToInt32(物品ID, 0), out value))
			{
				return string.Empty;
			}
			return value.ItmeNAME;
		}

		private void 清空物品属性方法()
		{
			物品攻击力 = 0;
			物品攻击力New = 0;
			物品攻击力MAX = 0;
			物品攻击力MaxNew = 0;
			物品属性_攻击力增加 = 0;
			物品属性_障力增加 = 0;
			物品防御力 = 0;
			物品属性_防御力增加 = 0;
			物品防御力New = 0;
			物品属性_生命力增加 = 0;
			物品属性_障力恢复量增加 = 0;
			物品属性_内功力增加 = 0;
			物品属性_命中率增加 = 0;
			物品属性_回避率增加 = 0;
			物品属性_武功攻击力 = 0;
			物品属性_武功攻击力New = 0;
			物品属性_降低百分比防御 = 0.0;
			物品属性_降低百分比攻击 = 0.0;
			物品属性_增加百分比命中 = 0.0;
			物品属性_增加百分比回避 = 0.0;
			物品属性_初始化愤怒概率百分比 = 0.0;
			物品属性_愤怒值增加 = 0;
			物品属性_追加中毒几率百分比 = 0.0;
			物品属性_降低伤害值 = 0;
			物品属性_全部气功等级增加 = 0;
			物品属性_升级成功率 = 0;
			物品属性_追加伤害值 = 0;
			物品属性_武功防御力增加 = 0;
			物品属性_武功防御力增加New = 0;
			物品属性_获得金钱增加 = 0;
			物品属性_死亡损失经验减少 = 0;
			物品属性_经验获得增加 = 0;
			物品_中级附魂_追加_觉醒 = 0;
			FLD_RESIDE2 = 0;
			FLD_LEVEL = 0;
			物品属性_追加医长功攻击 = 0;
			物品属性_追加医运气行心 = 0;
			物品属性_追加医洗髓易经 = 0;
			物品属性_追加医吸星大法 = 0;
			物品属性_追加升天一护身气甲 = 0;
			物品属性_追加医体血倍增 = 0;
			物品属性_追加医太极心法 = 0;
			物品属性_追加医真武绝击 = 0;
			物品属性_追加医妙手回春 = 0;
			物品属性_追加医九天真气 = 0;
			物品属性_追加医狂意护体 = 0;
			物品属性_追加医无中生有 = 0;
			物品属性_追加琴战马奔腾 = 0;
			物品属性_追加琴岳阳三醉 = 0;
			物品属性_追加琴阳明春晓 = 0;
			物品属性_追加琴阳关三叠 = 0;
			物品属性_追加琴秋江夜泊 = 0;
			物品属性_追加琴清心普善 = 0;
			物品属性_追加琴梅花三弄 = 0;
			物品属性_追加琴鸾凤和鸣 = 0;
			物品属性_追加琴汉宫秋月 = 0;
			物品属性_追加琴高山流水 = 0;
			物品属性_追加琴潇湘雨夜 = 0;
			物品属性_追加枪转守为攻 = 0;
			物品属性_追加枪运气疗伤 = 0;
			物品属性_追加枪乾坤挪移 = 0;
			物品属性_追加枪灵甲护身 = 0;
			物品属性_追加枪连环飞舞 = 0;
			物品属性_追加枪狂神降世 = 0;
			物品属性_追加枪狂风万破 = 0;
			物品属性_追加枪金钟罩气 = 0;
			物品属性_追加枪横练太保 = 0;
			物品属性_追加升天三怒意之火 = 0;
			物品属性_追加枪末日狂舞 = 0;
			物品属性_追加枪怒意之吼 = 0;
			物品属性_追加剑长虹贯日 = 0;
			物品属性_追加剑移花接木 = 0;
			物品属性_追加剑怒海狂澜 = 0;
			物品属性_追加剑连环飞舞 = 0;
			物品属性_追加剑狂风万破 = 0;
			物品属性_追加剑回柳身法 = 0;
			物品属性_追加升天一护身罡气 = 0;
			物品属性_追加剑冲冠一怒 = 0;
			物品属性_追加剑破天一剑 = 0;
			物品属性_追加剑百变神行 = 0;
			物品属性_追加剑无坚不摧 = 0;
			物品属性_追加剑乘胜追击 = 0;
			物品属性_追加弓正本培元 = 0;
			物品属性_追加弓心神凝聚 = 0;
			物品属性_追加弓无明暗矢 = 0;
			物品属性_追加弓锐利之箭 = 0;
			物品属性_追加弓凝神聚气 = 0;
			物品属性_追加弓流星三矢 = 0;
			物品属性_追加弓猎鹰之眼 = 0;
			物品属性_追加弓狂风万破 = 0;
			物品属性_追加弓回流真气 = 0;
			物品属性_追加弓百步穿杨 = 0;
			物品属性_追加弓致命绝杀 = 0;
			物品属性_追加刀真武绝击 = 0;
			物品属性_追加刀稳如泰山 = 0;
			物品属性_追加刀四两千斤 = 0;
			物品属性_追加刀摄魂一击 = 0;
			物品属性_追加刀连环飞舞 = 0;
			物品属性_追加刀力劈华山 = 0;
			物品属性_追加刀狂风万破 = 0;
			物品属性_追加升天三火龙之火 = 0;
			物品属性_追加刀霸气破甲 = 0;
			物品属性_追加刀暗影绝杀 = 0;
			物品属性_追加刀流光乱舞 = 0;
			物品属性_追加刀梵音破镜 = 0;
			物品属性_追加刺以怒还怒 = 0;
			物品属性_追加刺致手绝命 = 0;
			物品属性_追加刺心神凝聚 = 0;
			物品属性_追加刺先发制人 = 0;
			物品属性_追加刺三花聚顶 = 0;
			物品属性_追加刺千株万手 = 0;
			物品属性_追加刺连消带打 = 0;
			物品属性_追加刺连环飞舞 = 0;
			物品属性_追加刺荆轲之怒 = 0;
			物品属性_追加刺剑刃乱舞 = 0;
			物品属性_追加刺一招残杀 = 0;
			物品属性_追加韩暗影绝杀 = 0;
			物品属性_追加韩霸气破甲 = 0;
			物品属性_追加韩百变神行 = 0;
			物品属性_追加韩火龙问鼎 = 0;
			物品属性_追加韩狂风万破 = 0;
			物品属性_追加韩力劈华山 = 0;
			物品属性_追加韩流光乱舞 = 0;
			物品属性_追加韩摄魂一击 = 0;
			物品属性_追加韩天魔狂血 = 0;
			物品属性_追加韩真武绝击 = 0;
			物品属性_追加韩追骨吸元 = 0;
			物品属性_追加谭百变神行 = 0;
			物品属性_追加谭冲冠一怒 = 0;
			物品属性_追加谭护身罡气 = 0;
			物品属性_追加谭回柳身法 = 0;
			物品属性_追加谭狂风万破 = 0;
			物品属性_追加谭怒海狂澜 = 0;
			物品属性_追加谭新_连环飞舞 = 0;
			物品属性_追加谭移花接木 = 0;
			物品属性_追加谭长虹贯日 = 0;
			物品属性_追加谭招式新法 = 0;
			物品属性_追加谭纵横无双 = 0;
			物品属性_追加升天夺命连环 = 0;
			物品属性_追加升天电光石火 = 0;
			物品属性_追加升天精益求精 = 0;
			物品属性_追加升天四长虹贯天 = 0;
			物品属性_追加升天四悬丝诊脉 = 0;
			物品属性_追加升天四望梅添花 = 0;
			物品属性_追加升天四哀鸿遍野 = 0;
			物品属性_追加升天四毒蛇出洞 = 0;
			物品属性_追加升天四红月狂风 = 0;
			物品属性_追加升天四烈日炎炎 = 0;
			物品属性_追加升天四满月狂风 = 0;
			物品属性_追加升天三天外三矢 = 0;
			物品属性_追加升天三以柔克刚 = 0;
			物品属性_追加升天三子夜秋歌 = 0;
			物品属性_追加升天三火凤临朝 = 0;
			物品属性_追加升天三明镜止水 = 0;
			物品属性_追加升天三内息行心 = 0;
			物品属性_追加升天三无情打击 = 0;
			物品属性_追加升天二天魔护体 = 0;
			物品属性_追加升天二天地同寿 = 0;
			物品属性_追加升天二顺水推舟 = 0;
			物品属性_追加升天二以退为进 = 0;
			物品属性_追加升天二千钧压驼 = 0;
			物品属性_追加升天二穷途末路 = 0;
			物品属性_追加升天二三潭映月 = 0;
			物品属性_追加升天二万物回春 = 0;
			物品属性_追加升天一夜魔缠身 = 0;
			物品属性_追加升天一正本培源 = 0;
			物品属性_追加升天一长虹贯日 = 0;
			物品属性_追加升天一运气疗伤 = 0;
			物品属性_追加升天一运气行心 = 0;
			物品属性_追加升天一力劈华山 = 0;
			物品属性_追加升天一狂风天意 = 0;
			物品属性_追加升天一金钟罡气 = 0;
			物品属性_追加升天一飞花点翠 = 0;
			物品属性_追加升天一百变神行 = 0;
			物品属性_追加升天一遁出逆境 = 0;
			物品属性_追加升天一行风弄舞 = 0;
			物品属性_追加升天一绝影射魂 = 0;
			物品属性_追加升天一破甲刺魂 = 0;
			物品属性_追加强化 = 0.0;
			物品对怪防御力 = 0;
			物品对怪攻击力 = 0;
		}

		public void 得到物品属性方法()
		{
			try
			{
				清空物品属性方法();
				if (BitConverter.ToInt32(物品ID, 0) != 0)
				{
					得到物品基本攻击力();
					byte[] array = new byte[4];
					System.Buffer.BlockCopy(物品_byte, 16, array, 0, 4);
					得到强化(BitConverter.ToInt32(array, 0).ToString());
					for (int i = 0; i < 4; i++)
					{
						byte[] array2 = new byte[4];
						System.Buffer.BlockCopy(物品_byte, 20 + i * 4, array2, 0, 4);
						得到基本属性(BitConverter.ToInt32(array2, 0).ToString());
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "得到物品属性方法 出错：" + ((ex != null) ? ex.ToString() : null));
			}
		}

		private void 得到强化(string 强化数)
		{
			try
			{
				if (强化数.Length == 9)
				{
					byte[] array = new byte[4];
					System.Buffer.BlockCopy(物品_byte, 20, array, 0, 4);
					string text = BitConverter.ToInt32(array, 0).ToString();
					int num = 0;
					if (text != "0")
					{
						num = int.Parse(text.Substring(text.Length - 2, 2));
					}
					物品属性强类型 = int.Parse(强化数.Substring(强化数.Length - 9, 2));
					物品属性强 = int.Parse(强化数.Substring(强化数.Length - 2, 2));
					ItmeClass value;
					if (物品属性强类型 == 19 && FLD_RESIDE2 == 16 && World.Itme.TryGetValue(BitConverter.ToInt32(物品ID, 0), out value))
					{
						int num2 = 0;
						int num3 = 0;
						if (物品属性强 >= 0 && 物品属性强 <= 99)
						{
							switch (num)
							{
							default:
								if (物品属性强 % 2 == 0)
								{
									num3 = (int)((double)物品属性强 * 0.5) + 4;
									num2 = (int)((double)物品属性强 * 0.5) + 4;
								}
								else
								{
									num2 = (int)((double)物品属性强 * 0.5) + 8;
									num3 = (int)((double)物品属性强 * 0.5) + 8;
								}
								break;
							case 1:
								if (物品属性强 % 2 == 0)
								{
									num2 = (int)((double)物品属性强 * 0.6) + 5;
									num3 = 物品属性强 * 2 + 16;
								}
								else
								{
									num2 = (int)((double)物品属性强 * 0.6) + 6;
									num3 = 物品属性强 * 2 + 18;
								}
								break;
							case 2:
								if (物品属性强 % 2 == 0)
								{
									num2 = (int)((double)物品属性强 * 0.7) + 8;
									num3 = 物品属性强 * 4 + 32;
								}
								else
								{
									num2 = (int)((double)物品属性强 * 0.7) + 9;
									num3 = 物品属性强 * 4 + 32 + 4;
								}
								break;
							case 3:
								if (物品属性强 % 2 == 0)
								{
									num2 = 物品属性强 + 8;
									num3 = 物品属性强 * 8 + 64;
								}
								else
								{
									num2 = 物品属性强 + 9;
									num3 = 物品属性强 * 8 + 64 + 8;
								}
								break;
							}
						}
						物品攻击力 += num2;
						物品攻击力MAX += num2;
						物品防御力 += num2;
						物品对怪攻击力 += num3;
						物品对怪防御力 += num3;
						if (物品属性强 >= 2)
						{
							if (物品属性强 % 2 == 0)
							{
								物品属性_生命力增加 += 物品属性强 * 10 - ((物品属性强 - 1) * 5 - 5);
							}
							else
							{
								物品属性_生命力增加 += 物品属性强 * 10 - (物品属性强 - 1) * 5;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "得到强化 出错：" + ((ex != null) ? ex.ToString() : null));
			}
		}

		public void 得到物品属性方法(int 追加强化, int 触发属性提升)
		{
			try
			{
				清空物品属性方法();
				if (Buffer.ToInt32(物品ID, 0) != 0)
				{
					得到物品基本攻击力();
					物品属性_追加强化 = 追加强化;
					byte[] array = new byte[4];
					System.Buffer.BlockCopy(物品_byte, 16, array, 0, 4);
					得到强化(Buffer.ToInt32(array, 0).ToString(), 触发属性提升);
					for (int i = 0; i < 4; i++)
					{
						byte[] array2 = new byte[4];
						System.Buffer.BlockCopy(物品_byte, 20 + i * 4, array2, 0, 4);
						得到基本属性(Buffer.ToInt32(array2, 0).ToString());
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "得到物品属性方法   出错：" + ((ex != null) ? ex.ToString() : null));
			}
		}

		public void 得到物品基本攻击力()
		{
			try
			{
				if (Buffer.ToInt32(物品ID, 0) != 0)
				{
					ItmeClass itmeClass = World.Itme[Buffer.ToInt32(物品ID, 0)];
					FLD_RESIDE2 = itmeClass.FLD_RESIDE2;
					FLD_LEVEL = itmeClass.FLD_LEVEL;
					if (FLD_RESIDE2 == 4)
					{
						if (FLD_FJ_进化 == 0)
						{
							物品攻击力 = itmeClass.FLD_AT;
							物品攻击力MAX = itmeClass.FLD_AT_Max;
							物品攻击力New = itmeClass.FLD_AT;
							物品攻击力MaxNew = itmeClass.FLD_AT_Max;
						}
						else if (FLD_FJ_进化 == 1)
						{
							物品攻击力 = (int)((double)itmeClass.FLD_AT + (double)itmeClass.FLD_AT * 0.05);
							物品攻击力MAX = (int)((double)itmeClass.FLD_AT_Max + (double)itmeClass.FLD_AT_Max * 0.05);
							物品攻击力New = (int)((double)itmeClass.FLD_AT + (double)itmeClass.FLD_AT * 0.05);
							物品攻击力MaxNew = (int)((double)itmeClass.FLD_AT_Max + (double)itmeClass.FLD_AT_Max * 0.05);
						}
						else if (FLD_FJ_进化 == 2)
						{
							物品攻击力 = (int)((double)itmeClass.FLD_AT + (double)itmeClass.FLD_AT * 0.08);
							物品攻击力MAX = (int)((double)itmeClass.FLD_AT_Max + (double)itmeClass.FLD_AT_Max * 0.08);
							物品攻击力New = (int)((double)itmeClass.FLD_AT + (double)itmeClass.FLD_AT * 0.08);
							物品攻击力MaxNew = (int)((double)itmeClass.FLD_AT_Max + (double)itmeClass.FLD_AT_Max * 0.08);
						}
					}
					else if (FLD_RESIDE2 == 13)
					{
						物品攻击力 = itmeClass.FLD_AT;
						物品攻击力MAX = itmeClass.FLD_AT_Max;
						物品攻击力New = itmeClass.FLD_AT;
						物品攻击力MaxNew = itmeClass.FLD_AT_Max;
					}
					else
					{
						物品属性_障力增加 = itmeClass.FLD_LEVEL;
						if (FLD_FJ_进化 == 0)
						{
							物品防御力 = itmeClass.FLD_DF;
							物品防御力New = itmeClass.FLD_DF;
						}
						else if (FLD_FJ_进化 == 1)
						{
							物品防御力 = (int)((double)itmeClass.FLD_DF + (double)itmeClass.FLD_DF * 0.1);
							物品防御力New = (int)((double)itmeClass.FLD_DF + (double)itmeClass.FLD_DF * 0.1);
						}
						else if (FLD_FJ_进化 == 2)
						{
							物品防御力 = (int)((double)itmeClass.FLD_DF + (double)itmeClass.FLD_DF * 0.153);
							物品防御力New = (int)((double)itmeClass.FLD_DF + (double)itmeClass.FLD_DF * 0.153);
						}
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "得到物品基本攻击力   出错：" + ((ex != null) ? ex.ToString() : null));
			}
		}

		private void 得到基本属性(string ysqh)
		{
			try
			{
				string text;
				switch (ysqh.Length)
				{
				default:
					return;
				case 9:
					text = ysqh.Substring(0, 2);
					break;
				case 8:
					text = ysqh.Substring(0, 1);
					break;
				}
				int num = (World.是否支持扩展物品属性位数 == 0) ? ((!Buffer.IsEquals(text, "8")) ? int.Parse(ysqh.Substring(ysqh.Length - 3, 3)) : int.Parse(ysqh.Substring(ysqh.Length - 2, 2))) : ((!Buffer.IsEquals(text, "8")) ? (int.Parse(ysqh) - int.Parse(text) * 10000000) : int.Parse(ysqh.Substring(ysqh.Length - 2, 2)));
				switch (int.Parse(text))
				{
				case 14:
					break;
				case 1:
					物品属性_攻击力增加 += num;
					物品攻击力 += num;
					物品攻击力MAX += num;
					switch (num)
					{
					case 20:
						num += World.g20;
						break;
					case 21:
						num += World.g21;
						break;
					case 22:
						num += World.g22;
						break;
					case 23:
						num += World.g23;
						break;
					case 24:
						num += World.g24;
						break;
					case 25:
						num += World.g25;
						break;
					}
					物品攻击力New += num;
					物品攻击力MaxNew += num;
					break;
				case 2:
					物品属性_防御力增加 += num;
					物品防御力 += num;
					switch (num)
					{
					case 10:
						num += World.f10;
						break;
					case 11:
						num += World.f11;
						break;
					case 12:
						num += World.f12;
						break;
					case 13:
						num += World.f13;
						break;
					case 14:
						num += World.f14;
						break;
					case 15:
						num += World.f15;
						break;
					}
					物品防御力New += num;
					break;
				case 3:
					物品属性_生命力增加 += num;
					break;
				case 4:
					物品属性_内功力增加 += num;
					break;
				case 5:
					物品属性_命中率增加 += num;
					break;
				case 6:
					物品属性_回避率增加 += num;
					break;
				case 7:
					物品属性_武功攻击力 += num;
					switch (num)
					{
					case 25:
						num += World.wg25;
						break;
					case 26:
						num += World.wg26;
						break;
					case 27:
						num += World.wg27;
						break;
					case 28:
						num += World.wg28;
						break;
					case 29:
						num += World.wg29;
						break;
					case 30:
						num += World.wg30;
						break;
					case 31:
						num += World.wg31;
						break;
					case 32:
						num += World.wg32;
						break;
					case 33:
						num += World.wg33;
						break;
					case 34:
						num += World.wg34;
						break;
					case 35:
						num += World.wg35;
						break;
					case 36:
						num += World.wg36;
						break;
					case 37:
						num += World.wg37;
						break;
					case 38:
						num += World.wg38;
						break;
					case 39:
						num += World.wg39;
						break;
					case 40:
						num += World.wg40;
						break;
					}
					物品属性_武功攻击力New += num;
					break;
				case 8:
				{
					string text2 = ysqh.Substring(3, 3);
					if (text2 == null || text2 == null)
					{
						break;
					}
					uint num2 = Class3.smethod_0(text2);
					if (num2 > 1815485202)
					{
						if (num2 <= 3411215035u)
						{
							if (num2 <= 2275136958u)
							{
								switch (num2)
								{
								default:
									return;
								case 1832262821u:
									if (text2 == "110")
									{
										物品属性_追加刀流光乱舞 += num;
										物品属性_追加韩流光乱舞 += num;
									}
									return;
								case 1815632297u:
									if (text2 == "129")
									{
									}
									return;
								case 1865670964u:
									if (text2 == "108")
									{
									}
									return;
								case 1864979416u:
									if (text2 == "140")
									{
										物品属性_追加弓致命绝杀 += num;
									}
									return;
								case 1882448583u:
									if (!(text2 == "109"))
									{
									}
									return;
								case 1881757035u:
									if (text2 == "141")
									{
									}
									return;
								case 1898534654u:
									if (text2 == "142")
									{
									}
									return;
								case 1882889868u:
									if (text2 == "139")
									{
									}
									return;
								case 1899667487u:
									if (text2 == "138")
									{
									}
									return;
								case 1899520392u:
									if (text2 == "122")
									{
									}
									return;
								case 1916298011u:
									if (text2 == "123")
									{
									}
									return;
								case 1915312273u:
									if (text2 == "143")
									{
									}
									return;
								case 1933075630u:
									if (text2 == "120")
									{
										物品属性_追加剑无坚不摧 += num;
									}
									return;
								case 1932089892u:
									if (text2 == "144")
									{
									}
									return;
								case 1949853249u:
									if (text2 == "121")
									{
									}
									return;
								case 1949706154u:
									if (text2 == "119")
									{
									}
									return;
								case 1948867511u:
									if (text2 == "145")
									{
									}
									return;
								case 1965645130u:
									if (text2 == "146")
									{
									}
									return;
								case 1950000344u:
									if (text2 == "135")
									{
									}
									return;
								case 1966630868u:
									if (text2 == "126")
									{
									}
									return;
								case 1966483773u:
									if (!(text2 == "118"))
									{
									}
									return;
								case 1982422749u:
									if (!(text2 == "147"))
									{
									}
									return;
								case 1966777963u:
									if (text2 == "134")
									{
									}
									return;
								case 2000186106u:
									if (text2 == "124")
									{
									}
									return;
								case 1983555582u:
									if (text2 == "137")
									{
									}
									return;
								case 2016963725u:
									if (text2 == "125")
									{
									}
									return;
								case 2000333201u:
									if (text2 == "136")
									{
									}
									return;
								case 2033888439u:
									if (text2 == "130")
									{
										物品属性_追加枪末日狂舞 += num;
									}
									return;
								case 2017110820u:
									if (text2 == "131")
									{
									}
									return;
								case 2067443677u:
									if (text2 == "132")
									{
									}
									return;
								case 2050666058u:
									if (!(text2 == "133"))
									{
									}
									return;
								case 2275136958u:
									if (text2 == "601")
									{
										物品属性_追加升天二天魔护体 += num;
									}
									return;
								case 2258359339u:
									if (text2 == "602")
									{
										物品属性_追加升天三内息行心 += num;
									}
									return;
								case 2241581720u:
									break;
								}
								if (!(text2 == "603"))
								{
									break;
								}
								goto IL_241f;
							}
							if (num2 <= 3118500826u)
							{
								if (num2 > 2934094112u)
								{
									switch (num2)
									{
									case 2950871731u:
										if (text2 == "268")
										{
										}
										break;
									case 2950724636u:
										if (text2 == "272")
										{
											物品属性_追加谭新_连环飞舞 += num;
										}
										break;
									case 2984279874u:
										if (text2 == "270")
										{
											物品属性_追加剑长虹贯日 += num;
											物品属性_追加谭长虹贯日 += num;
										}
										break;
									case 2967502255u:
										if (text2 == "273")
										{
											物品属性_追加谭招式新法 += num;
										}
										break;
									case 3068315064u:
										if (text2 == "261")
										{
										}
										break;
									case 3001057493u:
										if (text2 == "271")
										{
											物品属性_追加剑百变神行 += num;
											物品属性_追加谭百变神行 += num;
											物品属性_追加韩百变神行 += num;
										}
										break;
									case 3118500826u:
										if (text2 == "278")
										{
											物品属性_追加剑回柳身法 += num;
											物品属性_追加谭回柳身法 += num;
										}
										break;
									case 3101870302u:
										if (text2 == "263")
										{
										}
										break;
									case 3085092683u:
										if (text2 == "260")
										{
											物品属性_追加刀流光乱舞 += num;
											物品属性_追加韩流光乱舞 += num;
										}
										break;
									}
									break;
								}
								if (num2 > 2883614160u)
								{
									switch (num2)
									{
									case 2917169398u:
										if (text2 == "274")
										{
											物品属性_追加刀狂风万破 += num;
											物品属性_追加剑狂风万破 += num;
											物品属性_追加枪狂风万破 += num;
											物品属性_追加弓狂风万破 += num;
											物品属性_追加韩狂风万破 += num;
											物品属性_追加谭狂风万破 += num;
										}
										break;
									case 2900391779u:
										if (text2 == "277")
										{
											物品属性_追加谭纵横无双 += num;
										}
										break;
									case 2934094112u:
										if (text2 == "269")
										{
										}
										break;
									case 2933947017u:
										if (text2 == "275")
										{
											物品属性_追加升天一护身罡气 += num;
											物品属性_追加谭护身罡气 += num;
										}
										break;
									}
									break;
								}
								if (num2 > 2359025053u)
								{
									switch (num2)
									{
									case 2883614160u:
										if (text2 == "276")
										{
											物品属性_追加剑移花接木 += num;
											物品属性_追加谭移花接木 += num;
										}
										break;
									case 2782040787u:
										if (!(text2 == "(int)sbyte.MaxValue"))
										{
										}
										break;
									}
									break;
								}
								if (num2 == 2291914577u)
								{
									if (text2 == "600")
									{
										物品属性_追加升天一行风弄舞 += num;
									}
									break;
								}
								if (num2 != 2359025053u || !(text2 == "604"))
								{
									break;
								}
								goto IL_2486;
							}
							switch (num2)
							{
							default:
								return;
							case 3127275440u:
								if (text2 == "391")
								{
									物品属性_追加升天二三潭映月 += num;
								}
								return;
							case 3118647921u:
								if (text2 == "262")
								{
								}
								return;
							case 3135425540u:
								if (text2 == "265")
								{
								}
								return;
							case 3135278445u:
								if (text2 == "279")
								{
									物品属性_追加剑怒海狂澜 += num;
									物品属性_追加谭怒海狂澜 += num;
								}
								return;
							case 3152203159u:
								if (text2 == "264")
								{
								}
								return;
							case 3144053059u:
								if (text2 == "390")
								{
									物品属性_追加升天一飞花点翠 += num;
								}
								return;
							case 3168980778u:
								if (text2 == "267")
								{
								}
								return;
							case 3160830678u:
								break;
							case 3185758397u:
								if (!(text2 == "266"))
								{
								}
								return;
							case 3177608297u:
								if (text2 == "392")
								{
									物品属性_追加升天三子夜秋歌 += num;
								}
								return;
							case 3260216464u:
								if (text2 == "319")
								{
								}
								return;
							case 3211163535u:
								if (text2 == "394")
								{
									物品属性_追加升天四悬丝诊脉 += num;
								}
								return;
							case 3377806892u:
								if (text2 == "368")
								{
								}
								return;
							case 3276994083u:
								if (text2 == "318")
								{
								}
								return;
							case 3411215035u:
								if (text2 == "310")
								{
									物品属性_追加升天一遁出逆境 += num;
								}
								return;
							case 3394584511u:
								if (text2 == "369")
								{
								}
								return;
							case 3394437416u:
								if (text2 == "311")
								{
									物品属性_追加升天二穷途末路 += num;
								}
								return;
							}
							if (!(text2 == "393"))
							{
								break;
							}
						}
						else
						{
							if (num2 > 3596063034u)
							{
								switch (num2)
								{
								case 3612840653u:
									if (text2 == "370")
									{
										物品属性_追加升天一夜魔缠身 += num;
									}
									break;
								case 3596901677u:
									if (text2 == "381")
									{
										物品属性_追加升天一长虹贯日 += num;
									}
									break;
								case 3652984153u:
									if (text2 == "068")
									{
									}
									break;
								case 3636206534u:
									if (text2 == "069")
									{
									}
									break;
								case 3703169915u:
									if (text2 == "071")
									{
										物品属性_追加刺三花聚顶 += num;
									}
									break;
								case 3686392296u:
									if (text2 == "070")
									{
										物品属性_追加刺荆轲之怒 += num;
									}
									break;
								case 3736725153u:
									if (text2 == "073")
									{
										物品属性_追加刺一招残杀 += num;
									}
									break;
								case 3719947534u:
									if (text2 == "072")
									{
										物品属性_追加刀连环飞舞 += num;
										物品属性_追加剑连环飞舞 += num;
										物品属性_追加枪连环飞舞 += num;
										物品属性_追加刺连环飞舞 += num;
									}
									break;
								case 3753502772u:
									if (text2 == "074")
									{
										物品属性_追加刺心神凝聚 += num;
										物品属性_追加弓心神凝聚 += num;
									}
									break;
								case 3736872248u:
									if (text2 == "063")
									{
									}
									break;
								case 3753796962u:
									if (text2 == "058")
									{
										物品属性_追加升天一护身气甲 += num;
									}
									break;
								case 3753649867u:
									if (text2 == "062")
									{
									}
									break;
								case 3770427486u:
									if (text2 == "061")
									{
									}
									break;
								case 3770280391u:
									if (text2 == "075")
									{
										物品属性_追加刺致手绝命 += num;
									}
									break;
								case 3787058010u:
									if (text2 == "076")
									{
										物品属性_追加刺先发制人 += num;
									}
									break;
								case 3778069267u:
									if (text2 == "170")
									{
										物品属性_追加升天三无情打击 += num;
									}
									break;
								case 3770574581u:
									if (text2 == "059")
									{
										物品属性_追加医九天真气 += num;
									}
									break;
								case 3787352200u:
									if (text2 == "056")
									{
										物品属性_追加医吸星大法 += num;
									}
									break;
								case 3787205105u:
									if (!(text2 == "060"))
									{
									}
									break;
								case 3803982724u:
									if (text2 == "067")
									{
									}
									break;
								case 3803835629u:
									if (text2 == "077")
									{
										物品属性_追加刺千株万手 += num;
									}
									break;
								case 3820760343u:
									if (text2 == "066")
									{
									}
									break;
								case 3804129819u:
									if (text2 == "057")
									{
										物品属性_追加刀真武绝击 += num;
										物品属性_追加韩真武绝击 += num;
										物品属性_追加医真武绝击 += num;
									}
									break;
								case 3837537962u:
									if (text2 == "065")
									{
									}
									break;
								case 3820907438u:
									if (text2 == "054")
									{
										物品属性_追加医妙手回春 += num;
									}
									break;
								case 3854315581u:
									if (text2 == "064")
									{
										物品属性_追加刀狂风万破 += num;
										物品属性_追加剑狂风万破 += num;
										物品属性_追加枪狂风万破 += num;
										物品属性_追加弓狂风万破 += num;
										物品属性_追加韩狂风万破 += num;
										物品属性_追加谭狂风万破 += num;
									}
									break;
								case 3837685057u:
									if (text2 == "055")
									{
										物品属性_追加医长功攻击 += num;
									}
									break;
								case 3855301319u:
									if (text2 == "000")
									{
										物品属性_全部气功等级增加 += num;
									}
									break;
								case 3854462676u:
									if (text2 == "052")
									{
										物品属性_追加医体血倍增 += num;
									}
									break;
								case 3888017914u:
									if (text2 == "050")
									{
										物品属性_追加医运气行心 += num;
									}
									break;
								case 3871240295u:
									if (text2 == "053")
									{
										物品属性_追加医洗髓易经 += num;
									}
									break;
								case 4146044052u:
									if (text2 == "180")
									{
										物品属性_追加琴潇湘雨夜 += num;
									}
									break;
								case 4113327457u:
									if (text2 == "150")
									{
										物品属性_追加升天二万物回春 += num;
									}
									break;
								case 3904795533u:
									if (text2 == "051")
									{
										物品属性_追加医太极心法 += num;
									}
									break;
								}
								break;
							}
							if (num2 > 3511880749u)
							{
								if (num2 <= 3545730177u)
								{
									if (num2 <= 3528805463u)
									{
										switch (num2)
										{
										case 3512174939u:
											if (text2 == "376")
											{
											}
											break;
										case 3512027844u:
											if (text2 == "360")
											{
											}
											break;
										case 3528805463u:
											if (text2 == "361")
											{
											}
											break;
										case 3513013582u:
											if (text2 == "384")
											{
												物品属性_追加升天一正本培源 += num;
											}
											break;
										}
										break;
									}
									if (num2 <= 3529791201u)
									{
										switch (num2)
										{
										case 3529791201u:
											if (text2 == "385")
											{
												物品属性_追加升天一运气疗伤 += num;
											}
											break;
										case 3528952558u:
											if (text2 == "375")
											{
											}
											break;
										}
										break;
									}
									if (num2 == 3545583082u)
									{
										if (text2 == "362")
										{
										}
										break;
									}
									if (num2 != 3545730177u || !(text2 == "374"))
									{
										break;
									}
									goto IL_2ed3;
								}
								if (num2 > 3562507796u)
								{
									switch (num2)
									{
									case 3568948963u:
										if (text2 == "079")
										{
											物品属性_追加刺剑刃乱舞 += num;
										}
										break;
									case 3563346439u:
										if (text2 == "383")
										{
											物品属性_追加升天一运气行心 += num;
										}
										break;
									case 3596063034u:
										if (text2 == "371")
										{
											物品属性_追加升天二顺水推舟 += num;
										}
										break;
									case 3580124058u:
										if (text2 == "380")
										{
											物品属性_追加升天一力劈华山 += num;
										}
										break;
									case 3579285415u:
										if (text2 == "372")
										{
											物品属性_追加刺以怒还怒 += num;
										}
										break;
									}
									break;
								}
								if (num2 <= 3552171344u)
								{
									switch (num2)
									{
									case 3552171344u:
										if (text2 == "078")
										{
											物品属性_追加刺连消带打 += num;
										}
										break;
									case 3546568820u:
										if (text2 == "382")
										{
											物品属性_追加升天一金钟罡气 += num;
										}
										break;
									}
									break;
								}
								if (num2 == 3562360701u)
								{
									if (!(text2 == "363"))
									{
									}
									break;
								}
								if (num2 != 3562507796u || !(text2 == "373"))
								{
									break;
								}
								goto IL_2f94;
							}
							if (num2 > 3462680725u)
							{
								if (num2 > 3479458344u)
								{
									switch (num2)
									{
									case 3495250225u:
										if (text2 == "367")
										{
										}
										break;
									case 3495103130u:
										if (text2 == "317")
										{
										}
										break;
									case 3511880749u:
										if (!(text2 == "316"))
										{
										}
										break;
									case 3496235963u:
										if (text2 == "387")
										{
											物品属性_追加升天一狂风天意 += num;
										}
										break;
									case 3495397320u:
										if (text2 == "377")
										{
										}
										break;
									}
									break;
								}
								if (num2 > 3478472606u)
								{
									switch (num2)
									{
									case 3479458344u:
										if (text2 == "386")
										{
											物品属性_追加升天一百变神行 += num;
										}
										break;
									case 3478619701u:
										if (text2 == "378")
										{
										}
										break;
									}
									break;
								}
								switch (num2)
								{
								default:
									return;
								case 3478472606u:
									if (text2 == "366")
									{
									}
									return;
								case 3478325511u:
									break;
								}
								if (!(text2 == "314"))
								{
									break;
								}
								goto IL_2c8d;
							}
							if (num2 > 3445903106u)
							{
								switch (num2)
								{
								case 3461694987u:
									if (text2 == "365")
									{
									}
									break;
								case 3461547892u:
									if (text2 == "315")
									{
									}
									break;
								case 3462680725u:
									if (text2 == "389")
									{
									}
									break;
								case 3461842082u:
									if (text2 == "379")
									{
									}
									break;
								}
								break;
							}
							if (num2 > 3444770273u)
							{
								switch (num2)
								{
								case 3445903106u:
									if (text2 == "388")
									{
									}
									break;
								case 3444917368u:
									if (text2 == "364")
									{
									}
									break;
								}
								break;
							}
							switch (num2)
							{
							default:
								return;
							case 3444770273u:
								if (text2 == "312")
								{
									物品属性_追加刀梵音破镜 += num;
								}
								return;
							case 3427992654u:
								break;
							}
							if (!(text2 == "313"))
							{
								break;
							}
						}
						goto IL_2b5d;
					}
					if (num2 > 1354156160)
					{
						switch (num2)
						{
						case 1354994803u:
							if (text2 == "035")
							{
								物品属性_追加枪横练太保 += num;
							}
							break;
						case 1354847708u:
							if (text2 == "045")
							{
								物品属性_追加弓正本培元 += num;
							}
							break;
						case 1370933779u:
							if (text2 == "084")
							{
								物品属性_追加琴汉宫秋月 += num;
							}
							break;
						case 1370786684u:
							if (text2 == "096")
							{
							}
							break;
						case 1371772422u:
							if (text2 == "036")
							{
								物品属性_追加枪乾坤挪移 += num;
							}
							break;
						case 1371625327u:
							if (text2 == "044")
							{
								物品属性_追加刀狂风万破 += num;
								物品属性_追加剑狂风万破 += num;
								物品属性_追加枪狂风万破 += num;
								物品属性_追加弓狂风万破 += num;
								物品属性_追加韩狂风万破 += num;
								物品属性_追加谭狂风万破 += num;
							}
							break;
						case 1387711398u:
							if (text2 == "087")
							{
								物品属性_追加琴梅花三弄 += num;
							}
							break;
						case 1387564303u:
							if (text2 == "097")
							{
							}
							break;
						case 1388550041u:
							if (text2 == "037")
							{
								物品属性_追加枪灵甲护身 += num;
							}
							break;
						case 1388402946u:
							if (text2 == "047")
							{
								物品属性_追加弓流星三矢 += num;
							}
							break;
						case 1404341922u:
							if (text2 == "094")
							{
							}
							break;
						case 1388697136u:
							if (text2 == "027")
							{
								物品属性_追加剑回柳身法 += num;
								物品属性_追加谭回柳身法 += num;
							}
							break;
						case 1405180565u:
							if (text2 == "046")
							{
								物品属性_追加刺心神凝聚 += num;
								物品属性_追加弓心神凝聚 += num;
							}
							break;
						case 1404489017u:
							if (text2 == "086")
							{
								物品属性_追加琴岳阳三醉 += num;
							}
							break;
						case 1421119541u:
							if (text2 == "095")
							{
							}
							break;
						case 1405474755u:
							if (text2 == "026")
							{
								物品属性_追加剑移花接木 += num;
								物品属性_追加谭移花接木 += num;
							}
							break;
						case 1405327660u:
							if (text2 == "030")
							{
								物品属性_追加枪金钟罩气 += num;
							}
							break;
						case 1421958184u:
							if (text2 == "049")
							{
								物品属性_追加弓无明暗矢 += num;
							}
							break;
						case 1421266636u:
							if (text2 == "081")
							{
								物品属性_追加琴秋江夜泊 += num;
							}
							break;
						case 1422252374u:
							if (text2 == "025")
							{
								物品属性_追加升天一护身罡气 += num;
								物品属性_追加谭护身罡气 += num;
							}
							break;
						case 1422105279u:
							if (text2 == "031")
							{
								物品属性_追加枪运气疗伤 += num;
							}
							break;
						case 1438735803u:
							if (text2 == "048")
							{
								物品属性_追加弓锐利之箭 += num;
							}
							break;
						case 1438044255u:
							if (text2 == "080")
							{
								物品属性_追加琴战马奔腾 += num;
							}
							break;
						case 1439029993u:
							if (text2 == "024")
							{
								物品属性_追加刀狂风万破 += num;
								物品属性_追加剑狂风万破 += num;
								物品属性_追加枪狂风万破 += num;
								物品属性_追加弓狂风万破 += num;
								物品属性_追加韩狂风万破 += num;
								物品属性_追加谭狂风万破 += num;
							}
							break;
						case 1438882898u:
							if (text2 == "032")
							{
								物品属性_追加刀连环飞舞 += num;
								物品属性_追加剑连环飞舞 += num;
								物品属性_追加枪连环飞舞 += num;
								物品属性_追加刺连环飞舞 += num;
							}
							break;
						case 1455660517u:
							if (text2 == "033")
							{
								物品属性_追加升天三怒意之火 += num;
							}
							break;
						case 1454821874u:
							if (text2 == "083")
							{
								物品属性_追加琴阳关三叠 += num;
							}
							break;
						case 1471452398u:
							if (text2 == "098")
							{
							}
							break;
						case 1455807612u:
							if (text2 == "023")
							{
								物品属性_追加剑破天一剑 += num;
							}
							break;
						case 1472585231u:
							if (text2 == "022")
							{
								物品属性_追加刀连环飞舞 += num;
								物品属性_追加剑连环飞舞 += num;
								物品属性_追加枪连环飞舞 += num;
								物品属性_追加刺连环飞舞 += num;
							}
							break;
						case 1471599493u:
							if (text2 == "082")
							{
								物品属性_追加琴清心普善 += num;
							}
							break;
						case 1489362850u:
							if (text2 == "021")
							{
								物品属性_追加剑百变神行 += num;
								物品属性_追加谭百变神行 += num;
								物品属性_追加韩百变神行 += num;
							}
							break;
						case 1488230017u:
							if (text2 == "099")
							{
							}
							break;
						case 1472732326u:
							if (text2 == "018")
							{
								物品属性_追加刀暗影绝杀 += num;
								物品属性_追加韩暗影绝杀 += num;
							}
							break;
						case 1506140469u:
							if (text2 == "020")
							{
								物品属性_追加剑长虹贯日 += num;
								物品属性_追加谭长虹贯日 += num;
							}
							break;
						case 1489509945u:
							if (text2 == "019")
							{
								物品属性_追加刀稳如泰山 += num;
							}
							break;
						case 1555487588u:
							if (text2 == "089")
							{
								物品属性_追加琴阳明春晓 += num;
							}
							break;
						case 1539548612u:
							if (text2 == "038")
							{
								物品属性_追加枪狂神降世 += num;
							}
							break;
						case 1572265207u:
							if (text2 == "088")
							{
								物品属性_追加琴鸾凤和鸣 += num;
							}
							break;
						case 1556326231u:
							if (text2 == "039")
							{
								物品属性_追加枪转守为攻 += num;
							}
							break;
						case 1590175659u:
							if (text2 == "013")
							{
								物品属性_追加升天三火龙之火 += num;
							}
							break;
						case 1573398040u:
							if (text2 == "012")
							{
								物品属性_追加刀连环飞舞 += num;
								物品属性_追加剑连环飞舞 += num;
								物品属性_追加枪连环飞舞 += num;
								物品属性_追加刺连环飞舞 += num;
							}
							break;
						case 1623583802u:
							if (text2 == "029")
							{
								物品属性_追加剑冲冠一怒 += num;
								物品属性_追加谭冲冠一怒 += num;
							}
							break;
						case 1606953278u:
							if (text2 == "010")
							{
								物品属性_追加刀力劈华山 += num;
								物品属性_追加韩力劈华山 += num;
							}
							break;
						case 1640361421u:
							if (text2 == "028")
							{
								物品属性_追加剑怒海狂澜 += num;
								物品属性_追加谭怒海狂澜 += num;
							}
							break;
						case 1623730897u:
							if (text2 == "011")
							{
								物品属性_追加刀摄魂一击 += num;
								物品属性_追加韩摄魂一击 += num;
							}
							break;
						case 1657286135u:
							if (text2 == "017")
							{
								物品属性_追加刀真武绝击 += num;
								物品属性_追加韩真武绝击 += num;
								物品属性_追加医真武绝击 += num;
							}
							break;
						case 1640508516u:
							if (text2 == "016")
							{
								物品属性_追加刀霸气破甲 += num;
								物品属性_追加韩霸气破甲 += num;
							}
							break;
						case 1681117155u:
							if (text2 == "105")
							{
							}
							break;
						case 1674063754u:
							if (text2 == "014")
							{
								物品属性_追加刀狂风万破 += num;
								物品属性_追加剑狂风万破 += num;
								物品属性_追加枪狂风万破 += num;
								物品属性_追加弓狂风万破 += num;
								物品属性_追加韩狂风万破 += num;
								物品属性_追加谭狂风万破 += num;
							}
							break;
						case 1664339536u:
							if (text2 == "104")
							{
							}
							break;
						case 1697894774u:
							if (text2 == "106")
							{
							}
							break;
						case 1690841373u:
							if (text2 == "015")
							{
								物品属性_追加刀四两千斤 += num;
							}
							break;
						case 1714819488u:
							if (text2 == "117")
							{
							}
							break;
						case 1714672393u:
							if (text2 == "107")
							{
							}
							break;
						case 1731450012u:
							if (text2 == "100")
							{
							}
							break;
						case 1730758464u:
							if (text2 == "148")
							{
							}
							break;
						case 1747536083u:
							if (text2 == "149")
							{
							}
							break;
						case 1731597107u:
							if (text2 == "116")
							{
							}
							break;
						case 1748374726u:
							if (text2 == "115")
							{
							}
							break;
						case 1748227631u:
							if (text2 == "101")
							{
							}
							break;
						case 1765152345u:
							if (text2 == "114")
							{
							}
							break;
						case 1765005250u:
							if (text2 == "102")
							{
							}
							break;
						case 1781929964u:
							if (text2 == "113")
							{
							}
							break;
						case 1781782869u:
							if (text2 == "103")
							{
							}
							break;
						case 1815485202u:
							if (text2 == "111")
							{
							}
							break;
						case 1798854678u:
							if (text2 == "128")
							{
							}
							break;
						case 1798707583u:
							if (text2 == "112")
							{
							}
							break;
						}
						break;
					}
					if (num2 <= 1062054185)
					{
						if (num2 <= 816297241)
						{
							if (num2 > 702229500)
							{
								switch (num2)
								{
								case 735784738u:
									if (text2 == "256")
									{
										物品属性_追加刀霸气破甲 += num;
										物品属性_追加韩霸气破甲 += num;
									}
									break;
								case 719007119u:
									if (text2 == "255")
									{
										物品属性_追加韩追骨吸元 += num;
									}
									break;
								case 765964384u:
									if (text2 == "562")
									{
										物品属性_追加升天电光石火 += num;
									}
									break;
								case 752562357u:
									if (text2 == "257")
									{
										物品属性_追加刀真武绝击 += num;
										物品属性_追加韩真武绝击 += num;
										物品属性_追加医真武绝击 += num;
									}
									break;
								case 782742003u:
									if (text2 == "563")
									{
										物品属性_追加升天精益求精 += num;
									}
									break;
								case 769339976u:
									if (text2 == "258")
									{
										物品属性_追加刀暗影绝杀 += num;
										物品属性_追加韩暗影绝杀 += num;
									}
									break;
								case 816297241u:
									if (text2 == "561")
									{
										物品属性_追加升天夺命连环 += num;
									}
									break;
								case 786117595u:
									if (text2 == "259")
									{
										物品属性_追加韩火龙问鼎 += num;
									}
									break;
								}
								break;
							}
							if (num2 > 635119024)
							{
								switch (num2)
								{
								case 668674262u:
									if (text2 == "252")
									{
										物品属性_追加韩天魔狂血 += num;
									}
									break;
								case 651896643u:
									if (text2 == "251")
									{
										物品属性_追加刀摄魂一击 += num;
										物品属性_追加韩摄魂一击 += num;
									}
									break;
								case 702229500u:
									if (text2 == "254")
									{
										物品属性_追加刀狂风万破 += num;
										物品属性_追加剑狂风万破 += num;
										物品属性_追加枪狂风万破 += num;
										物品属性_追加弓狂风万破 += num;
										物品属性_追加韩狂风万破 += num;
										物品属性_追加谭狂风万破 += num;
									}
									break;
								case 685451881u:
									if (text2 == "253")
									{
										物品属性_追加剑百变神行 += num;
										物品属性_追加谭百变神行 += num;
										物品属性_追加韩百变神行 += num;
									}
									break;
								}
								break;
							}
							if (num2 > 147274918)
							{
								switch (num2)
								{
								default:
									return;
								case 635119024u:
									if (text2 == "250")
									{
										物品属性_追加刀力劈华山 += num;
										物品属性_追加韩力劈华山 += num;
									}
									return;
								case 164052537u:
									break;
								}
								if (!(text2 == "701"))
								{
									break;
								}
								goto IL_241f;
							}
							switch (num2)
							{
							default:
								return;
							case 147274918u:
								if (text2 == "700")
								{
									物品属性_追加升天三以柔克刚 += num;
								}
								return;
							case 113719680u:
								break;
							}
							if (!(text2 == "702"))
							{
								break;
							}
							goto IL_2486;
						}
						if (num2 <= 1012559971)
						{
							if (num2 <= 994796614)
							{
								switch (num2)
								{
								case 961241376u:
									if (text2 == "320")
									{
										物品属性_追加剑乘胜追击 += num;
									}
									break;
								case 872124261u:
									if (text2 == "280")
									{
										物品属性_追加剑冲冠一怒 += num;
										物品属性_追加谭冲冠一怒 += num;
									}
									break;
								case 994796614u:
									if (text2 == "322")
									{
										物品属性_追加升天三火凤临朝 += num;
									}
									break;
								case 978018995u:
									if (text2 == "321")
									{
										物品属性_追加升天二天地同寿 += num;
									}
									break;
								}
								break;
							}
							if (num2 <= 1011574233)
							{
								switch (num2)
								{
								default:
									return;
								case 1011574233u:
									break;
								case 995782352u:
									if (text2 == "342")
									{
										物品属性_追加升天三天外三矢 += num;
									}
									return;
								}
								if (!(text2 == "323"))
								{
									break;
								}
							}
							else
							{
								if (num2 != 1011721328)
								{
									if (num2 != 1012559971 || !(text2 == "343"))
									{
										break;
									}
									goto IL_2f94;
								}
								if (!(text2 == "333"))
								{
									break;
								}
							}
							goto IL_2b5d;
						}
						switch (num2)
						{
						default:
							return;
						case 1028498947u:
							if (text2 == "332")
							{
								物品属性_追加枪怒意之吼 += num;
							}
							return;
						case 1028351852u:
							break;
						case 1045129471u:
							if (text2 == "325")
							{
							}
							return;
						case 1029337590u:
							if (text2 == "340")
							{
								物品属性_追加升天一绝影射魂 += num;
							}
							return;
						case 1046115209u:
							if (text2 == "341")
							{
								物品属性_追加升天二千钧压驼 += num;
							}
							return;
						case 1045276566u:
							if (text2 == "331")
							{
								物品属性_追加升天二以退为进 += num;
							}
							return;
						case 1062054185u:
							if (text2 == "330")
							{
								物品属性_追加升天一破甲刺魂 += num;
							}
							return;
						case 1061907090u:
							if (text2 == "326")
							{
							}
							return;
						case 1046262304u:
							if (text2 == "355")
							{
							}
							return;
						}
						if (!(text2 == "324"))
						{
							break;
						}
					}
					else
					{
						if (num2 > 1146928018)
						{
							switch (num2)
							{
							case 1163705637u:
								if (text2 == "352")
								{
									物品属性_追加升天三明镜止水 += num;
								}
								break;
							case 1163558542u:
								if (text2 == "348")
								{
								}
								break;
							case 1180336161u:
								if (text2 == "349")
								{
								}
								break;
							case 1179497518u:
								if (text2 == "339")
								{
								}
								break;
							case 1247593732u:
								if (text2 == "359")
								{
								}
								break;
							case 1196275137u:
								if (!(text2 == "338"))
								{
								}
								break;
							case 1287737232u:
								if (text2 == "041")
								{
									物品属性_追加弓猎鹰之眼 += num;
								}
								break;
							case 1264371351u:
								if (text2 == "358")
								{
								}
								break;
							case 1304514851u:
								if (text2 == "040")
								{
									物品属性_追加弓百步穿杨 += num;
								}
								break;
							case 1303676208u:
								if (text2 == "092")
								{
								}
								break;
							case 1321292470u:
								if (text2 == "043")
								{
									物品属性_追加弓回流真气 += num;
								}
								break;
							case 1320453827u:
								if (text2 == "093")
								{
								}
								break;
							case 1338070089u:
								if (text2 == "042")
								{
									物品属性_追加弓凝神聚气 += num;
								}
								break;
							case 1337231446u:
								if (text2 == "090")
								{
								}
								break;
							case 1354156160u:
								if (text2 == "085")
								{
									物品属性_追加琴高山流水 += num;
								}
								break;
							case 1354009065u:
								if (text2 == "091")
								{
								}
								break;
							case 1338217184u:
								if (text2 == "034")
								{
									物品属性_追加刀狂风万破 += num;
									物品属性_追加剑狂风万破 += num;
									物品属性_追加枪狂风万破 += num;
									物品属性_追加弓狂风万破 += num;
									物品属性_追加韩狂风万破 += num;
									物品属性_追加谭狂风万破 += num;
								}
								break;
							}
							break;
						}
						if (num2 <= 1095609423)
						{
							switch (num2)
							{
							case 1063039923u:
								if (text2 == "354")
								{
									物品属性_追加升天四望梅添花 += num;
								}
								break;
							case 1062892828u:
								if (text2 == "346")
								{
								}
								break;
							case 1078831804u:
								if (text2 == "337")
								{
								}
								break;
							case 1078684709u:
								if (text2 == "327")
								{
								}
								break;
							case 1079817542u:
								if (text2 == "357")
								{
								}
								break;
							case 1079670447u:
								if (text2 == "347")
								{
								}
								break;
							case 1095609423u:
								if (text2 == "336")
								{
								}
								break;
							case 1095462328u:
								if (text2 == "328")
								{
								}
								break;
							}
							break;
						}
						if (num2 <= 1112387042)
						{
							switch (num2)
							{
							default:
								return;
							case 1096595161u:
								if (text2 == "356")
								{
								}
								return;
							case 1096448066u:
								break;
							case 1112387042u:
								if (text2 == "335")
								{
								}
								return;
							case 1112239947u:
								if (!(text2 == "329"))
								{
								}
								return;
							}
							if (!(text2 == "344"))
							{
								break;
							}
							goto IL_2ed3;
						}
						if (num2 <= 1113372780)
						{
							switch (num2)
							{
							case 1113372780u:
								if (text2 == "351")
								{
									物品属性_追加医无中生有 += num;
								}
								break;
							case 1113225685u:
								if (text2 == "345")
								{
								}
								break;
							}
							break;
						}
						if (num2 != 1129164661)
						{
							switch (num2)
							{
							default:
								return;
							case 1146928018u:
								break;
							case 1130150399u:
								if (text2 == "350")
								{
									物品属性_追加医狂意护体 += num;
								}
								return;
							}
							if (!(text2 == "353"))
							{
								break;
							}
							goto IL_2f94;
						}
						if (!(text2 == "334"))
						{
							break;
						}
					}
					goto IL_2c8d;
				}
				case 9:
					物品属性_升级成功率 += num;
					break;
				case 10:
					物品属性_追加伤害值 += num;
					break;
				case 11:
					物品属性_武功防御力增加 += num;
					try
					{
						switch (num)
						{
						case 85:
							num += World.wf85;
							break;
						case 68:
							num += World.wf68;
							break;
						case 70:
							num += World.wf70;
							break;
						case 72:
							num += World.wf72;
							break;
						case 74:
							num += World.wf74;
							break;
						case 76:
							num += World.wf76;
							break;
						case 78:
							num += World.wf78;
							break;
						case 80:
							num += World.wf80;
							break;
						case 100:
							num += World.wf100;
							break;
						case 95:
							num += World.wf95;
							break;
						case 90:
							num += World.wf90;
							break;
						}
						物品属性_武功防御力增加New += num;
					}
					catch
					{
					}
					break;
				case 12:
					物品属性_获得金钱增加 += num;
					break;
				case 13:
					物品属性_死亡损失经验减少 += num;
					break;
				case 15:
					{
						物品属性_经验获得增加 += num;
						break;
					}
					IL_2ed3:
					物品属性_追加升天四烈日炎炎 += num;
					break;
					IL_2b5d:
					物品属性_追加升天四红月狂风 += num;
					break;
					IL_2486:
					物品属性_追加升天四哀鸿遍野 += num;
					break;
					IL_2f94:
					物品属性_追加升天四满月狂风 += num;
					break;
					IL_2c8d:
					物品属性_追加升天四毒蛇出洞 += num;
					break;
					IL_241f:
					物品属性_追加升天四长虹贯天 += num;
					break;
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "得到基本属性   出错：" + ((ex != null) ? ex.ToString() : null));
			}
		}

		private int 得到首饰强化增加障力恢复量(int level, int 强化阶段)
		{
			switch (level)
			{
			case 100:
				switch (强化阶段)
				{
				case 1:
					return 18;
				case 2:
					return 24;
				case 3:
					return 31;
				case 4:
					return 38;
				case 5:
					return 45;
				case 6:
					return 53;
				case 7:
					return 61;
				case 8:
					return 76;
				case 9:
					return 80;
				case 10:
					return 95;
				}
				break;
			case 80:
				switch (强化阶段)
				{
				case 1:
					return 16;
				case 2:
					return 21;
				case 3:
					return 27;
				case 4:
					return 33;
				case 5:
					return 40;
				case 6:
					return 47;
				case 7:
					return 55;
				case 8:
					return 67;
				case 9:
					return 71;
				case 10:
					return 84;
				}
				break;
			case 60:
				switch (强化阶段)
				{
				case 1:
					return 14;
				case 2:
					return 19;
				case 3:
					return 25;
				case 4:
					return 30;
				case 5:
					return 36;
				case 6:
					return 43;
				case 7:
					return 49;
				case 8:
					return 61;
				case 9:
					return 64;
				case 10:
					return 76;
				}
				break;
			case 120:
				switch (强化阶段)
				{
				case 1:
					return 20;
				case 2:
					return 27;
				case 3:
					return 35;
				case 4:
					return 43;
				case 5:
					return 52;
				case 6:
					return 61;
				case 7:
					return 70;
				case 8:
					return 87;
				case 9:
					return 91;
				case 10:
					return 108;
				}
				break;
			case 115:
				switch (强化阶段)
				{
				case 1:
					return 19;
				case 2:
					return 26;
				case 3:
					return 33;
				case 4:
					return 40;
				case 5:
					return 48;
				case 6:
					return 57;
				case 7:
					return 66;
				case 8:
					return 81;
				case 9:
					return 85;
				case 10:
					return 101;
				}
				break;
			case 140:
				switch (强化阶段)
				{
				case 1:
					return 29;
				case 2:
					return 39;
				case 3:
					return 50;
				case 4:
					return 61;
				case 5:
					return 73;
				case 6:
					return 86;
				case 7:
					return 99;
				case 8:
					return 122;
				case 9:
					return 128;
				case 10:
					return 152;
				}
				break;
			case 130:
				switch (强化阶段)
				{
				case 1:
					return 24;
				case 2:
					return 32;
				case 3:
					return 41;
				case 4:
					return 50;
				case 5:
					return 60;
				case 6:
					return 71;
				case 7:
					return 82;
				case 8:
					return 101;
				case 9:
					return 106;
				case 10:
					return 126;
				}
				break;
			}
			return 0;
		}

		private int 得到物品障力(ItmeClass Itme, int 强化阶段)
		{
			switch (FLD_RESIDE2)
			{
			case 1:
			{
				int num4 = 0;
				int num5 = 物品属性强 + (int)物品属性_追加强化;
				if (Itme.FLD_LEVEL <= 80)
				{
					num4 = 5;
				}
				else if (Itme.FLD_LEVEL == 90)
				{
					num4 = 10;
				}
				else if (Itme.FLD_LEVEL == 100)
				{
					num4 = 20;
				}
				else if (Itme.FLD_LEVEL == 110)
				{
					num4 = 30;
				}
				else if (Itme.FLD_LEVEL == 120)
				{
					num4 = 40;
				}
				else if (Itme.FLD_LEVEL == 130)
				{
					num4 = 50;
				}
				else if (Itme.FLD_LEVEL == 140)
				{
					num4 = 60;
				}
				物品属性_障力增加 += num5 * num4;
				switch (num5)
				{
				case 6:
					物品属性_障力增加 += 155;
					break;
				case 7:
					物品属性_障力增加 += 195;
					break;
				case 8:
					物品属性_障力增加 += 260;
					break;
				case 9:
					物品属性_障力增加 += 375;
					break;
				case 10:
					物品属性_障力增加 += 615;
					break;
				case 11:
					物品属性_障力增加 += 905;
					break;
				case 12:
					物品属性_障力增加 += 1295;
					break;
				case 13:
					物品属性_障力增加 += 1685;
					break;
				case 14:
					物品属性_障力增加 += 2125;
					break;
				case 15:
					物品属性_障力增加 += 2565;
					break;
				case 16:
					物品属性_障力增加 += 3115;
					break;
				}
				break;
			}
			case 2:
			case 5:
			{
				int num2 = 0;
				int num3 = 物品属性强 + (int)物品属性_追加强化;
				if (Itme.FLD_LEVEL <= 80)
				{
					num2 = 5;
				}
				else if (Itme.FLD_LEVEL == 90)
				{
					num2 = 7;
				}
				else if (Itme.FLD_LEVEL == 100)
				{
					num2 = 9;
				}
				else if (Itme.FLD_LEVEL == 110)
				{
					num2 = 11;
				}
				else if (Itme.FLD_LEVEL == 120)
				{
					num2 = 13;
				}
				else if (Itme.FLD_LEVEL == 130)
				{
					num2 = 15;
				}
				else if (Itme.FLD_LEVEL == 140)
				{
					num2 = 17;
				}
				else if (Itme.FLD_LEVEL == 150)
				{
					num2 = 22;
				}
				物品属性_障力增加 += num3 * num2;
				switch (num3)
				{
				case 6:
					物品属性_障力增加 += 5;
					break;
				case 7:
					物品属性_障力增加 += 15;
					break;
				case 8:
					物品属性_障力增加 += 33;
					break;
				case 9:
					物品属性_障力增加 += 55;
					break;
				case 10:
					物品属性_障力增加 += 124;
					break;
				case 11:
					物品属性_障力增加 += 207;
					break;
				case 12:
					物品属性_障力增加 += 305;
					break;
				case 13:
					物品属性_障力增加 += 443;
					break;
				case 14:
					物品属性_障力增加 += 611;
					break;
				case 15:
					物品属性_障力增加 += 814;
					break;
				case 16:
					物品属性_障力增加 += 1057;
					break;
				}
				break;
			}
			case 6:
			{
				int num = 0;
				if (Itme.FLD_LEVEL <= 55)
				{
					num = 1;
				}
				else if (Itme.FLD_LEVEL <= 65)
				{
					num = 2;
				}
				else if (Itme.FLD_LEVEL <= 75)
				{
					num = 3;
				}
				else if (Itme.FLD_LEVEL <= 85)
				{
					num = 5;
				}
				else if (Itme.FLD_LEVEL == 95)
				{
					num = 7;
				}
				else if (Itme.FLD_LEVEL == 105)
				{
					num = 9;
				}
				else if (Itme.FLD_LEVEL == 115)
				{
					num = 11;
				}
				else if (Itme.FLD_LEVEL == 125)
				{
					num = 13;
				}
				else if (Itme.FLD_LEVEL == 135)
				{
					num = 15;
				}
				else if (Itme.FLD_LEVEL == 145)
				{
					num = 17;
				}
				else if (Itme.FLD_LEVEL == 155)
				{
					num = 22;
				}
				物品属性_障力增加 += 物品属性强 * num;
				if (物品属性强 > 5)
				{
					switch (物品属性强)
					{
					case 6:
						物品属性_障力增加 += 5;
						break;
					case 7:
						物品属性_障力增加 += 15;
						break;
					case 8:
						物品属性_障力增加 += 33;
						break;
					case 9:
						物品属性_障力增加 += 55;
						break;
					case 10:
						物品属性_障力增加 += 124;
						break;
					case 11:
						物品属性_障力增加 += 207;
						break;
					case 12:
						物品属性_障力增加 += 305;
						break;
					case 13:
						物品属性_障力增加 += 443;
						break;
					case 14:
						物品属性_障力增加 += 611;
						break;
					case 15:
						物品属性_障力增加 += 814;
						break;
					}
				}
				break;
			}
			}
			return 0;
		}

		private void 计算武器属性(ItmeClass Itme)
		{
			try
			{
				物品攻击力 += 物品属性强 * 6;
				物品攻击力MAX += 物品属性强 * 6;
				物品攻击力New += 物品属性强 * 6;
				物品攻击力MaxNew += 物品属性强 * 6;
				if (物品属性强 > 5)
				{
					if (Itme.FLD_JOB_LEVEL >= 3 && 物品属性强 >= 7)
					{
						switch (物品属性强)
						{
						case 7:
							物品攻击力 += 10;
							物品攻击力MAX += 10;
							物品攻击力New += 10;
							物品攻击力MaxNew += 10;
							if (Itme.FLD_LEVEL >= 130)
							{
								物品攻击力 += 12;
								物品攻击力MAX += 12;
								物品攻击力New += 12;
								物品攻击力MaxNew += 12;
							}
							break;
						case 8:
							物品攻击力 += 24;
							物品攻击力MAX += 24;
							物品攻击力New += 24;
							物品攻击力MaxNew += 24;
							if (Itme.FLD_LEVEL >= 130)
							{
								物品攻击力 += 17;
								物品攻击力MAX += 17;
								物品攻击力New += 17;
								物品攻击力MaxNew += 17;
							}
							break;
						case 9:
							物品攻击力 += 48;
							物品攻击力MAX += 48;
							物品攻击力New += 48;
							物品攻击力MaxNew += 48;
							if (Itme.FLD_LEVEL >= 130)
							{
								物品攻击力 += 22;
								物品攻击力MAX += 22;
								物品攻击力New += 22;
								物品攻击力MaxNew += 22;
							}
							break;
						case 10:
							物品攻击力 += 102;
							物品攻击力MAX += 102;
							物品攻击力New += 102;
							物品攻击力MaxNew += 102;
							if (Itme.FLD_LEVEL >= 130)
							{
								物品攻击力 += 32;
								物品攻击力MAX += 32;
								物品攻击力New += 32;
								物品攻击力MaxNew += 32;
							}
							break;
						case 11:
							物品攻击力 += 111;
							物品攻击力MAX += 111;
							物品攻击力New += 111;
							物品攻击力MaxNew += 111;
							if (Itme.FLD_LEVEL >= 130)
							{
								物品攻击力 += 35;
								物品攻击力MAX += 35;
								物品攻击力New += 35;
								物品攻击力MaxNew += 35;
							}
							break;
						case 12:
							物品攻击力 += 125;
							物品攻击力MAX += 125;
							物品攻击力New += 125;
							物品攻击力MaxNew += 125;
							if (Itme.FLD_LEVEL >= 130)
							{
								物品攻击力 += 45;
								物品攻击力MAX += 45;
								物品攻击力New += 45;
								物品攻击力MaxNew += 45;
							}
							break;
						case 13:
							物品攻击力 += 144;
							物品攻击力MAX += 144;
							物品攻击力New += 144;
							物品攻击力MaxNew += 144;
							if (Itme.FLD_LEVEL >= 130)
							{
								物品攻击力 += 55;
								物品攻击力MAX += 55;
								物品攻击力New += 55;
								物品攻击力MaxNew += 55;
							}
							break;
						case 14:
							物品攻击力 += 168;
							物品攻击力MAX += 168;
							物品攻击力New += 168;
							物品攻击力MaxNew += 168;
							if (Itme.FLD_LEVEL >= 130)
							{
								物品攻击力 += 60;
								物品攻击力MAX += 60;
								物品攻击力New += 60;
								物品攻击力MaxNew += 60;
							}
							break;
						case 15:
							物品攻击力 += 197;
							物品攻击力MAX += 197;
							物品攻击力New += 197;
							物品攻击力MaxNew += 197;
							if (Itme.FLD_LEVEL >= 130)
							{
								物品攻击力 += 60;
								物品攻击力MAX += 60;
								物品攻击力New += 60;
								物品攻击力MaxNew += 60;
							}
							break;
						}
					}
					else
					{
						物品攻击力 += (物品属性强 - 5) * 2;
						物品攻击力MAX += (物品属性强 - 5) * 2;
						物品攻击力New += (物品属性强 - 5) * 2;
						物品攻击力MaxNew += (物品属性强 - 5) * 2;
						if (Itme.FLD_LEVEL >= 130)
						{
							物品攻击力 += 8;
							物品攻击力MAX += 8;
							物品攻击力New += 8;
							物品攻击力MaxNew += 8;
						}
					}
					if (物品属性强 >= 10 && FLD_RESIDE2 == 4)
					{
						switch (物品属性强)
						{
						case 10:
						{
							int num = ++物品属性_全部气功等级增加;
							break;
						}
						case 11:
							物品属性_全部气功等级增加 += 2;
							break;
						case 12:
							物品属性_全部气功等级增加 += 3;
							break;
						case 13:
							if (Itme.FLD_LEVEL >= 130)
							{
								物品属性_全部气功等级增加 += 4;
							}
							else
							{
								物品属性_全部气功等级增加 += 3;
							}
							break;
						case 14:
							if (Itme.FLD_LEVEL >= 130)
							{
								物品属性_全部气功等级增加 += 4;
							}
							else
							{
								物品属性_全部气功等级增加 += 3;
							}
							break;
						case 15:
							if (Itme.FLD_LEVEL >= 130)
							{
								物品属性_全部气功等级增加 += 4;
							}
							else
							{
								物品属性_全部气功等级增加 += 3;
							}
							break;
						}
					}
					if (物品属性强 >= 7)
					{
						Dictionary<int, Itimesx> dictionary = new Dictionary<int, Itimesx>();
						dictionary.Add(0, 属性1);
						dictionary.Add(1, 属性2);
						dictionary.Add(2, 属性3);
						dictionary.Add(3, 属性4);
						for (int i = 0; i < 4; i++)
						{
							if (dictionary[i].属性类型 != 0)
							{
								int 属性数量 = dictionary[i].属性数量;
								switch (dictionary[i].属性类型)
								{
								case 7:
									if (物品属性强 == 7)
									{
										if (i < 2)
										{
											int num = ++物品属性_武功攻击力;
											num = ++物品属性_武功攻击力New;
										}
									}
									else if (物品属性强 <= 12)
									{
										物品属性_武功攻击力 += 物品属性强 - 7;
										物品属性_武功攻击力New += 物品属性强 - 7;
									}
									else if (物品属性强 <= 14)
									{
										double num4 = Math.Round((double)属性数量 / 4.0);
										物品属性_武功攻击力 += 物品属性强 - 7 + (int)num4;
										物品属性_武功攻击力New += 物品属性强 - 7 + (int)num4;
									}
									else
									{
										double num5 = Math.Round((double)属性数量 / 4.0);
										物品属性_武功攻击力 += 物品属性强 - 8 + (int)num5;
										物品属性_武功攻击力New += 物品属性强 - 8 + (int)num5;
									}
									break;
								case 8:
									if (物品属性强 >= 13)
									{
										int num = ++物品属性_全部气功等级增加;
									}
									break;
								case 10:
									if (物品属性强 == 7)
									{
										if (i < 2)
										{
											int num = ++物品属性_追加伤害值;
										}
									}
									else if (物品属性强 <= 12)
									{
										物品属性_追加伤害值 += 物品属性强 - 7;
									}
									else if (物品属性强 <= 14)
									{
										物品属性_追加伤害值 += 物品属性强 - 7 + (int)Math.Round((double)属性数量 / 4.0);
									}
									else
									{
										物品属性_追加伤害值 += 物品属性强 - 8 + (int)Math.Round((double)属性数量 / 4.0);
									}
									break;
								case 3:
									if (物品属性强 == 7)
									{
										if (i < 2)
										{
											int num = ++物品属性_生命力增加;
										}
									}
									else if (物品属性强 <= 12)
									{
										物品属性_生命力增加 += 物品属性强 - 7;
									}
									else if (物品属性强 <= 14)
									{
										物品属性_生命力增加 += 物品属性强 - 7 + (int)Math.Round((double)属性数量 / 4.0);
									}
									else
									{
										物品属性_生命力增加 += 物品属性强 - 8 + (int)Math.Round((double)属性数量 / 4.0);
									}
									break;
								case 1:
									if (物品属性强 == 7)
									{
										if (i < 2)
										{
											int num = ++物品攻击力;
											num = ++物品攻击力MAX;
											num = ++物品攻击力New;
											num = ++物品攻击力MaxNew;
										}
									}
									else if (物品属性强 <= 12)
									{
										物品攻击力 += 物品属性强 - 7;
										物品攻击力MAX += 物品属性强 - 7;
										物品攻击力New += 物品属性强 - 7;
										物品攻击力MaxNew += 物品属性强 - 7;
									}
									else if (物品属性强 <= 14)
									{
										double num2 = Math.Round((double)属性数量 / 4.0);
										物品攻击力 += 物品属性强 - 7 + (int)num2;
										物品攻击力MAX += 物品属性强 - 7 + (int)num2;
										物品攻击力New += 物品属性强 - 7 + (int)num2;
										物品攻击力MaxNew += 物品属性强 - 7 + (int)num2;
									}
									else
									{
										double num3 = Math.Round((double)属性数量 / 4.0);
										物品攻击力 += 物品属性强 - 8 + (int)num3;
										物品攻击力MAX += 物品属性强 - 8 + (int)num3;
										物品攻击力New += 物品属性强 - 8 + (int)num3;
										物品攻击力MaxNew += 物品属性强 - 8 + (int)num3;
									}
									break;
								}
							}
						}
						dictionary.Clear();
					}
				}
				if (Itme.FLD_LEVEL >= 130 && 物品属性强 == 5)
				{
					物品攻击力 += 2;
					物品攻击力MAX += 2;
					物品攻击力New += 2;
					物品攻击力MaxNew += 2;
				}
				int num6 = 8;
				if (FLD_FJ_觉醒 > 0)
				{
					int num7 = FLD_FJ_觉醒 * num6;
					物品攻击力 += num7;
					物品攻击力MAX += num7;
					物品攻击力New += num7;
					物品攻击力MaxNew += num7;
				}
			}
			catch
			{
			}
		}

		private void 计算衣服属性(ItmeClass Itme)
		{
			try
			{
				switch (物品属性强)
				{
				case 1:
					if (Itme.FLD_LEVEL < 60)
					{
						物品防御力 += 3;
						物品防御力New += 3;
					}
					else
					{
						物品防御力 += 4;
						物品防御力New += 4;
						if (Itme.FLD_LEVEL >= 130)
						{
							物品防御力 += 2;
							物品防御力New += 2;
						}
					}
					break;
				case 2:
					if (Itme.FLD_LEVEL < 60)
					{
						物品防御力 += 9;
						物品防御力New += 9;
					}
					else
					{
						物品防御力 += 12;
						物品防御力New += 12;
						if (Itme.FLD_LEVEL >= 130)
						{
							物品防御力 += 4;
							物品防御力New += 4;
						}
					}
					break;
				case 3:
					if (Itme.FLD_LEVEL < 60)
					{
						物品防御力 += 18;
						物品防御力New += 18;
					}
					else
					{
						物品防御力 += 24;
						物品防御力New += 24;
						if (Itme.FLD_LEVEL >= 130)
						{
							物品防御力 += 6;
							物品防御力New += 6;
						}
					}
					break;
				case 4:
					if (Itme.FLD_LEVEL < 60)
					{
						物品防御力 += 30;
						物品防御力New += 30;
					}
					else
					{
						物品防御力 += 40;
						物品防御力New += 40;
						if (Itme.FLD_LEVEL >= 130)
						{
							物品防御力 += 8;
							物品防御力New += 8;
						}
					}
					break;
				case 5:
					if (Itme.FLD_LEVEL < 60)
					{
						物品防御力 += 45;
						物品防御力New += 45;
					}
					else
					{
						物品防御力 += 60;
						物品防御力New += 60;
						if (Itme.FLD_LEVEL >= 130)
						{
							物品防御力 += 10;
							物品防御力New += 10;
						}
					}
					break;
				case 6:
					if (Itme.FLD_LEVEL < 60)
					{
						物品防御力 += 63;
						物品防御力New += 63;
						物品属性_生命力增加 += (物品属性强 - 5) * 5;
					}
					else
					{
						物品防御力 += 84;
						物品防御力New += 84;
						if (Itme.FLD_LEVEL >= 130)
						{
							物品防御力 += 14;
							物品防御力New += 14;
						}
						物品属性_降低伤害值 += (物品属性强 - 5) * 5;
					}
					break;
				case 7:
					if (Itme.FLD_LEVEL < 60)
					{
						物品防御力 += 84;
						物品防御力New += 84;
						物品属性_生命力增加 += (物品属性强 - 5) * 5;
					}
					else
					{
						物品防御力 += 112;
						物品防御力New += 112;
						if (Itme.FLD_LEVEL >= 130)
						{
							物品防御力 += 18;
							物品防御力New += 18;
						}
						物品属性_降低伤害值 += (物品属性强 - 5) * 5;
					}
					break;
				case 8:
					if (Itme.FLD_LEVEL < 60)
					{
						物品防御力 += 108;
						物品防御力New += 108;
						物品属性_生命力增加 += (物品属性强 - 5) * 5;
					}
					else
					{
						物品防御力 += 144;
						物品防御力New += 144;
						if (Itme.FLD_LEVEL >= 130)
						{
							物品防御力 += 22;
							物品防御力New += 22;
						}
						物品属性_降低伤害值 += (物品属性强 - 5) * 5;
					}
					break;
				case 9:
					if (Itme.FLD_LEVEL < 60)
					{
						物品防御力 += 135;
						物品防御力New += 135;
						物品属性_生命力增加 += (物品属性强 - 5) * 5;
					}
					else
					{
						物品防御力 += 180;
						物品防御力New += 180;
						if (Itme.FLD_LEVEL >= 130)
						{
							物品防御力 += 26;
							物品防御力New += 26;
						}
						物品属性_降低伤害值 += 5 + (物品属性强 - 5) * 5;
					}
					break;
				case 10:
					if (Itme.FLD_LEVEL < 60)
					{
						物品防御力 += 165;
						物品防御力New += 165;
						物品属性_生命力增加 += 5 + (物品属性强 - 5) * 5;
					}
					else
					{
						物品防御力 += 230;
						物品防御力New += 230;
						if (Itme.FLD_LEVEL >= 130)
						{
							物品防御力 += 31;
							物品防御力New += 31;
						}
						物品属性_降低伤害值 += 5 + (物品属性强 - 5) * 5;
					}
					break;
				case 11:
					物品防御力 += 265;
					物品防御力New += 265;
					if (Itme.FLD_LEVEL >= 130)
					{
						物品防御力 += 34;
						物品防御力New += 34;
					}
					物品属性_降低伤害值 += 10 + (物品属性强 - 5) * 5;
					break;
				case 12:
					物品防御力 += 315;
					物品防御力New += 315;
					if (Itme.FLD_LEVEL >= 130)
					{
						物品防御力 += 36;
						物品防御力New += 36;
					}
					物品属性_降低伤害值 += 15 + (物品属性强 - 5) * 5;
					break;
				case 13:
					物品防御力 += 365;
					物品防御力New += 365;
					if (Itme.FLD_LEVEL >= 130)
					{
						物品防御力 += 44;
						物品防御力New += 44;
					}
					物品属性_降低伤害值 += 20 + (物品属性强 - 5) * 5;
					物品属性_生命力增加 += 260;
					break;
				case 14:
					物品防御力 += 415;
					物品防御力New += 415;
					if (Itme.FLD_LEVEL >= 130)
					{
						物品防御力 += 52;
						物品防御力New += 52;
					}
					物品属性_降低伤害值 += 25 + (物品属性强 - 5) * 5;
					物品属性_生命力增加 += 260;
					break;
				case 15:
					物品防御力 += 465;
					物品防御力New += 465;
					if (Itme.FLD_LEVEL >= 130)
					{
						物品防御力 += 60;
						物品防御力New += 60;
					}
					物品属性_降低伤害值 += 30 + (物品属性强 - 5) * 5;
					物品属性_生命力增加 += 260;
					break;
				}
				int num = 5;
				if (FLD_FJ_觉醒 > 0)
				{
					int num2 = FLD_FJ_觉醒 * num;
					物品防御力 += num2;
					物品防御力New += num2;
				}
			}
			catch
			{
			}
		}

		private void 得到强化(string ysqh, int 触发属性提升)
		{
			try
			{
				ItmeClass value;
				if (World.Itme.TryGetValue(Buffer.ToInt32(物品ID, 0), out value))
				{
					switch (ysqh.Length)
					{
					case 8:
						物品属性阶段类型 = 0;
						物品属性阶段数 = 0;
						物品属性强类型 = int.Parse(ysqh.Substring(ysqh.Length - 8, 1));
						物品属性强 = int.Parse(ysqh.Substring(ysqh.Length - 2, 2));
						switch (物品属性强类型)
						{
						case 1:
							if (FLD_RESIDE2 == 10)
							{
								if (value.FLD_LEVEL >= 140)
								{
									if (物品属性强 < 4)
									{
										物品攻击力 += 物品属性强 * 9;
										物品攻击力MAX += 物品属性强 * 9;
										物品攻击力New += 物品属性强 * 9;
										物品攻击力MaxNew += 物品属性强 * 9;
									}
									else
									{
										物品攻击力 += 27 + (物品属性强 - 3) * 16;
										物品攻击力MAX += 27 + (物品属性强 - 3) * 16;
										物品攻击力New += 27 + (物品属性强 - 3) * 16;
										物品攻击力MaxNew += 27 + (物品属性强 - 3) * 16;
									}
									物品属性_障力恢复量增加 += 得到首饰强化增加障力恢复量(140, 物品属性强);
								}
								else if (value.FLD_LEVEL >= 130)
								{
									if (物品属性强 < 4)
									{
										物品攻击力 += 物品属性强 * 7;
										物品攻击力MAX += 物品属性强 * 7;
										物品攻击力New += 物品属性强 * 7;
										物品攻击力MaxNew += 物品属性强 * 7;
									}
									else
									{
										物品攻击力 += 21 + (物品属性强 - 3) * 13;
										物品攻击力MAX += 21 + (物品属性强 - 3) * 13;
										物品攻击力New += 21 + (物品属性强 - 3) * 13;
										物品攻击力MaxNew += 21 + (物品属性强 - 3) * 13;
									}
									物品属性_障力恢复量增加 += 得到首饰强化增加障力恢复量(130, 物品属性强);
								}
								else if (value.FLD_LEVEL >= 120)
								{
									if (物品属性强 < 4)
									{
										物品攻击力 += 物品属性强 * 6;
										物品攻击力MAX += 物品属性强 * 6;
										物品攻击力New += 物品属性强 * 6;
										物品攻击力MaxNew += 物品属性强 * 6;
									}
									else
									{
										物品攻击力 += 19 + (物品属性强 - 3) * 11;
										物品攻击力MAX += 19 + (物品属性强 - 3) * 11;
										物品攻击力New += 19 + (物品属性强 - 3) * 11;
										物品攻击力MaxNew += 19 + (物品属性强 - 3) * 11;
									}
									物品属性_障力恢复量增加 += 得到首饰强化增加障力恢复量(120, 物品属性强);
								}
								else if (value.FLD_LEVEL >= 115)
								{
									if (物品属性强 < 4)
									{
										物品攻击力 += 物品属性强 * 5;
										物品攻击力MAX += 物品属性强 * 5;
										物品攻击力New += 物品属性强 * 5;
										物品攻击力MaxNew += 物品属性强 * 5;
									}
									else
									{
										物品攻击力 += 15 + (物品属性强 - 3) * 9;
										物品攻击力MAX += 15 + (物品属性强 - 3) * 9;
										物品攻击力New += 15 + (物品属性强 - 3) * 9;
										物品攻击力MaxNew += 15 + (物品属性强 - 3) * 9;
									}
									物品属性_障力恢复量增加 += 得到首饰强化增加障力恢复量(115, 物品属性强);
								}
								else if (value.FLD_LEVEL >= 100)
								{
									if (物品属性强 < 4)
									{
										物品攻击力 += 物品属性强 * 4;
										物品攻击力MAX += 物品属性强 * 4;
										物品攻击力New += 物品属性强 * 4;
										物品攻击力MaxNew += 物品属性强 * 4;
									}
									else
									{
										物品攻击力 += 11 + (物品属性强 - 3) * 7;
										物品攻击力MAX += 11 + (物品属性强 - 3) * 7;
										物品攻击力New += 11 + (物品属性强 - 3) * 7;
										物品攻击力MaxNew += 11 + (物品属性强 - 3) * 7;
									}
									物品属性_障力恢复量增加 += 得到首饰强化增加障力恢复量(100, 物品属性强);
								}
								else if (value.FLD_LEVEL >= 80)
								{
									if (物品属性强 < 4)
									{
										物品攻击力 += 物品属性强 * 3;
										物品攻击力MAX += 物品属性强 * 3;
										物品攻击力New += 物品属性强 * 3;
										物品攻击力MaxNew += 物品属性强 * 3;
									}
									else
									{
										物品攻击力 += 9 + (物品属性强 - 3) * 5;
										物品攻击力MAX += 9 + (物品属性强 - 3) * 5;
										物品攻击力New += 9 + (物品属性强 - 3) * 5;
										物品攻击力MaxNew += 9 + (物品属性强 - 3) * 5;
									}
									物品属性_障力恢复量增加 += 得到首饰强化增加障力恢复量(80, 物品属性强);
								}
								else if (value.FLD_LEVEL >= 60)
								{
									if (物品属性强 < 4)
									{
										物品攻击力 += 物品属性强 * 2;
										物品攻击力MAX += 物品属性强 * 2;
										物品攻击力New += 物品属性强 * 2;
										物品攻击力MaxNew += 物品属性强 * 2;
									}
									else
									{
										物品攻击力 += 6 + (物品属性强 - 3) * 3;
										物品攻击力MAX += 6 + (物品属性强 - 3) * 3;
										物品攻击力New += 6 + (物品属性强 - 3) * 3;
										物品攻击力MaxNew += 6 + (物品属性强 - 3) * 3;
									}
									物品属性_障力恢复量增加 += 得到首饰强化增加障力恢复量(60, 物品属性强);
								}
							}
							else
							{
								计算武器属性(value);
							}
							break;
						case 2:
							switch (FLD_RESIDE2)
							{
							case 3:
							case 4:
								break;
							case 8:
							case 9:
							case 10:
							case 11:
							case 12:
							case 13:
								break;
							case 1:
								计算衣服属性(value);
								得到物品障力(value, 物品属性强);
								break;
							case 2:
							case 5:
								switch (物品属性强)
								{
								case 1:
									物品防御力 += 3;
									物品防御力New += 3;
									break;
								case 2:
									物品防御力 += 6;
									物品防御力New += 6;
									break;
								case 3:
									物品防御力 += 9;
									物品防御力New += 9;
									break;
								case 4:
									物品防御力 += 12;
									物品防御力New += 12;
									break;
								case 5:
									物品防御力 += 15;
									物品防御力New += 15;
									break;
								case 6:
									if (value.FLD_LEVEL < 60)
									{
										物品防御力 += 18;
										物品防御力New += 18;
										物品属性_生命力增加 += (物品属性强 - 5) * 5;
									}
									else
									{
										物品防御力 += 19;
										物品防御力New += 19;
										物品属性_降低伤害值 += (物品属性强 - 5) * 5;
									}
									break;
								case 7:
									if (value.FLD_LEVEL < 60)
									{
										物品防御力 += 21;
										物品防御力New += 21;
										物品属性_生命力增加 += (物品属性强 - 5) * 5;
									}
									else
									{
										物品防御力 += 23;
										物品防御力New += 23;
										if (value.FLD_LEVEL >= 130)
										{
											物品防御力 += 2;
											物品防御力New += 2;
										}
										物品属性_降低伤害值 += (物品属性强 - 5) * 5;
									}
									break;
								case 8:
									if (value.FLD_LEVEL < 60)
									{
										物品防御力 += 27;
										物品防御力New += 27;
										物品属性_生命力增加 += (物品属性强 - 5) * 5;
									}
									else
									{
										物品防御力 += 29;
										物品防御力New += 29;
										if (value.FLD_LEVEL >= 130)
										{
											物品防御力 += 5;
											物品防御力New += 5;
										}
										物品属性_降低伤害值 += (物品属性强 - 5) * 5;
									}
									break;
								case 9:
									if (value.FLD_LEVEL < 60)
									{
										物品防御力 += 31;
										物品防御力New += 31;
										物品属性_生命力增加 += (物品属性强 - 5) * 5;
									}
									else
									{
										物品防御力 += 38;
										物品防御力New += 38;
										if (value.FLD_LEVEL >= 130)
										{
											物品防御力 += 8;
											物品防御力New += 8;
										}
										物品属性_降低伤害值 += (物品属性强 - 5) * 5;
									}
									break;
								case 10:
									if (value.FLD_LEVEL < 60)
									{
										物品防御力 += 37;
										物品防御力New += 37;
										物品属性_生命力增加 += 5 + (物品属性强 - 5) * 5;
									}
									else
									{
										物品防御力 += 53;
										物品防御力New += 53;
										if (value.FLD_LEVEL >= 130)
										{
											物品防御力 += 11;
											物品防御力New += 11;
										}
										物品属性_降低伤害值 += 5 + (物品属性强 - 5) * 5;
									}
									break;
								case 11:
									物品防御力 += 59;
									物品防御力New += 59;
									if (value.FLD_LEVEL >= 130)
									{
										物品防御力 += 20;
										物品防御力New += 20;
									}
									物品属性_降低伤害值 += 10 + (物品属性强 - 5) * 5;
									break;
								case 12:
									物品防御力 += 65;
									物品防御力New += 65;
									if (value.FLD_LEVEL >= 130)
									{
										物品防御力 += 29;
										物品防御力New += 29;
									}
									物品属性_降低伤害值 += 15 + (物品属性强 - 5) * 5;
									break;
								case 13:
									物品防御力 += 51;
									物品防御力New += 51;
									if (value.FLD_LEVEL >= 130)
									{
										物品防御力 += 58;
										物品防御力New += 58;
									}
									物品属性_降低伤害值 += 20 + (物品属性强 - 5) * 5;
									break;
								case 14:
									物品防御力 += 57;
									物品防御力New += 57;
									if (value.FLD_LEVEL >= 130)
									{
										物品防御力 += 72;
										物品防御力New += 72;
									}
									物品属性_降低伤害值 += 25 + (物品属性强 - 5) * 5;
									break;
								case 15:
									物品防御力 += 63;
									物品防御力New += 63;
									if (value.FLD_LEVEL >= 130)
									{
										物品防御力 += 86;
										物品防御力New += 86;
									}
									物品属性_降低伤害值 += 30 + (物品属性强 - 5) * 5;
									break;
								}
								得到物品障力(value, 物品属性强);
								break;
							case 6:
								物品防御力 += 物品属性强 * 3;
								物品防御力New += 物品属性强 * 3;
								switch (物品属性强)
								{
								case 6:
									物品防御力 += 2;
									物品防御力New += 2;
									if (value.FLD_LEVEL >= 65)
									{
										物品属性_生命力增加 += 40;
									}
									else
									{
										物品属性_生命力增加 += 45;
									}
									break;
								case 7:
									物品防御力 += 4;
									物品防御力New += 4;
									if (value.FLD_LEVEL >= 65)
									{
										物品属性_生命力增加 += 80;
									}
									else
									{
										物品属性_生命力增加 += 90;
									}
									break;
								case 8:
									物品防御力 += 10;
									物品防御力New += 10;
									if (value.FLD_LEVEL >= 65)
									{
										物品属性_生命力增加 += 140;
									}
									else
									{
										物品属性_生命力增加 += 155;
									}
									break;
								case 9:
									物品防御力 += 22;
									物品防御力New += 22;
									if (value.FLD_LEVEL >= 65)
									{
										物品属性_生命力增加 += 200;
									}
									else
									{
										物品属性_生命力增加 += 220;
									}
									break;
								case 10:
								{
									物品防御力 += 46;
									物品防御力New += 46;
									int fLD_LEVEL = value.FLD_LEVEL;
									物品属性_生命力增加 += 300;
									break;
								}
								case 11:
									物品防御力 += 61;
									物品防御力New += 61;
									物品属性_生命力增加 += 300;
									break;
								case 12:
									物品防御力 += 76;
									物品防御力New += 76;
									物品属性_生命力增加 += 300;
									break;
								case 13:
									物品防御力 += 71;
									物品防御力New += 71;
									物品属性_生命力增加 += 610;
									break;
								case 14:
									物品防御力 += 91;
									物品防御力New += 91;
									物品属性_生命力增加 += 610;
									break;
								case 15:
									物品防御力 += 111;
									物品防御力New += 111;
									物品属性_生命力增加 += 610;
									break;
								}
								得到物品障力(value, 物品属性强);
								break;
							case 7:
								if (value.FLD_LEVEL >= 140)
								{
									if (物品属性强 < 4)
									{
										物品防御力 += 物品属性强 * 9;
										物品防御力New += 物品属性强 * 9;
									}
									else
									{
										物品防御力 += 27 + (物品属性强 - 3) * 16;
										物品防御力New += 27 + (物品属性强 - 3) * 16;
									}
									物品属性_障力恢复量增加 += 得到首饰强化增加障力恢复量(140, 物品属性强);
								}
								else if (value.FLD_LEVEL >= 130)
								{
									if (物品属性强 < 4)
									{
										物品防御力 += 物品属性强 * 7;
										物品防御力New += 物品属性强 * 7;
									}
									else
									{
										物品防御力 += 21 + (物品属性强 - 3) * 13;
										物品防御力New += 21 + (物品属性强 - 3) * 13;
									}
									物品属性_障力恢复量增加 += 得到首饰强化增加障力恢复量(130, 物品属性强);
								}
								else if (value.FLD_LEVEL >= 120)
								{
									if (物品属性强 < 4)
									{
										物品防御力 += 物品属性强 * 6;
										物品防御力New += 物品属性强 * 6;
									}
									else
									{
										物品防御力 += 19 + (物品属性强 - 3) * 11;
										物品防御力New += 19 + (物品属性强 - 3) * 11;
									}
									物品属性_障力恢复量增加 += 得到首饰强化增加障力恢复量(120, 物品属性强);
								}
								else if (value.FLD_LEVEL >= 115)
								{
									if (物品属性强 < 4)
									{
										物品防御力 += 物品属性强 * 5;
										物品防御力New += 物品属性强 * 6;
									}
									else
									{
										物品防御力 += 15 + (物品属性强 - 3) * 9;
										物品防御力New += 15 + (物品属性强 - 3) * 9;
									}
									物品属性_障力恢复量增加 += 得到首饰强化增加障力恢复量(115, 物品属性强);
								}
								else if (value.FLD_LEVEL >= 100)
								{
									if (物品属性强 < 5)
									{
										物品防御力 += 物品属性强 * 4;
										物品防御力New += 物品属性强 * 4;
									}
									else
									{
										物品防御力 += 11 + (物品属性强 - 4) * 7;
										物品防御力New += 11 + (物品属性强 - 4) * 7;
									}
									物品属性_障力恢复量增加 += 得到首饰强化增加障力恢复量(100, 物品属性强);
								}
								else if (value.FLD_LEVEL >= 80)
								{
									if (物品属性强 < 4)
									{
										物品防御力 += 物品属性强 * 3;
										物品防御力New += 物品属性强 * 3;
									}
									else
									{
										物品防御力 += 9 + (物品属性强 - 3) * 5;
										物品防御力New += 9 + (物品属性强 - 3) * 5;
									}
									物品属性_障力恢复量增加 += 得到首饰强化增加障力恢复量(80, 物品属性强);
								}
								else if (value.FLD_LEVEL >= 60)
								{
									if (物品属性强 < 4)
									{
										物品防御力 += 物品属性强 * 2;
										物品防御力New += 物品属性强 * 2;
									}
									else
									{
										物品防御力 += 6 + (物品属性强 - 3) * 3;
										物品防御力New += 6 + (物品属性强 - 3) * 3;
									}
									物品属性_障力恢复量增加 += 得到首饰强化增加障力恢复量(60, 物品属性强);
								}
								break;
							case 14:
								switch (物品属性强)
								{
								case 1:
								case 2:
								case 3:
								case 4:
								case 5:
									物品防御力 += 物品属性强 * 3;
									物品防御力New += 物品属性强 * 3;
									break;
								case 6:
								case 7:
								case 8:
								case 9:
									物品防御力 += 15 + (物品属性强 - 5) * 4;
									物品防御力New += 15 + (物品属性强 - 5) * 4;
									物品属性_生命力增加 += 物品属性强 - 25;
									break;
								case 10:
									物品防御力 += 37;
									物品防御力New += 37;
									物品属性_生命力增加 += 30;
									break;
								}
								break;
							}
							break;
						case 3:
							if (FLD_RESIDE2 == 8)
							{
								if (value.FLD_LEVEL >= 140)
								{
									物品属性_生命力增加 += 物品属性强 * 80;
									物品属性_障力恢复量增加 += 得到首饰强化增加障力恢复量(140, 物品属性强);
								}
								else if (value.FLD_LEVEL >= 130)
								{
									物品属性_生命力增加 += 物品属性强 * 70;
									物品属性_障力恢复量增加 += 得到首饰强化增加障力恢复量(130, 物品属性强);
								}
								else if (value.FLD_LEVEL >= 120)
								{
									物品属性_生命力增加 += 物品属性强 * 60;
									物品属性_障力恢复量增加 += 得到首饰强化增加障力恢复量(120, 物品属性强);
								}
								else if (value.FLD_LEVEL >= 115)
								{
									物品属性_生命力增加 += 物品属性强 * 50;
									物品属性_障力恢复量增加 += 得到首饰强化增加障力恢复量(115, 物品属性强);
								}
								else if (value.FLD_LEVEL >= 100)
								{
									物品属性_生命力增加 += 物品属性强 * 40;
									物品属性_障力恢复量增加 += 得到首饰强化增加障力恢复量(100, 物品属性强);
								}
								else if (value.FLD_LEVEL >= 80)
								{
									物品属性_生命力增加 += 物品属性强 * 15;
									物品属性_障力恢复量增加 += 得到首饰强化增加障力恢复量(80, 物品属性强);
								}
								else if (value.FLD_LEVEL >= 60)
								{
									物品属性_生命力增加 += 物品属性强 * 5;
									物品属性_障力恢复量增加 += 得到首饰强化增加障力恢复量(60, 物品属性强);
								}
							}
							break;
						case 4:
							if (物品属性强 >= 100)
							{
								物品属性强 = 100;
							}
							if (物品属性强 > 1)
							{
								if ((物品属性强 & 1) == 1)
								{
									物品防御力 += (物品属性强 - 1) / 2 + 5;
									物品防御力New += (物品属性强 - 1) / 2 + 5;
									物品攻击力 += (物品属性强 - 1) / 2 + 5;
									物品攻击力MAX += (物品属性强 - 1) / 2 + 5;
									物品攻击力New += (物品属性强 - 1) / 2 + 5;
									物品攻击力MaxNew += (物品属性强 - 1) / 2 + 5;
									物品属性_生命力增加 += (物品属性强 - 1) / 2 * 10;
									物品属性_获得金钱增加 += (物品属性强 - 1) * 2;
								}
								else
								{
									物品防御力 += 物品属性强 / 2 + 5;
									物品防御力New += 物品属性强 / 2 + 5;
									物品攻击力 += 物品属性强 / 2 + 5;
									物品攻击力MAX += 物品属性强 / 2 + 5;
									物品攻击力New += 物品属性强 / 2 + 5;
									物品攻击力MaxNew += 物品属性强 / 2 + 5;
									物品属性_生命力增加 += 物品属性强 / 2 * 10;
									物品属性_获得金钱增加 += 物品属性强 * 2;
								}
							}
							else
							{
								物品防御力 += 5;
								物品防御力New += 5;
							}
							break;
						case 5:
						{
							int fLD_MAGIC = FLD_MAGIC2;
							if (物品属性强类型 == 5)
							{
								if (物品属性强 >= 100)
								{
									物品属性强 = 100;
								}
								if (物品属性强 > 1)
								{
									if (value.FLD_PID == 1000001170)
									{
										物品对怪防御力 += (int)(Math.Ceiling((double)物品属性强 / 2.0) - 1.0) * 2 + 10;
										物品对怪攻击力 += (int)(Math.Ceiling((double)物品属性强 / 2.0) - 1.0) * 2 + 10;
										物品属性_生命力增加 = (int)Math.Floor((double)物品属性强 / 2.0) * 10 + 10;
									}
									else if (value.FLD_PID == 1000001171)
									{
										物品对怪防御力 += (int)((Math.Ceiling((double)物品属性强 / 2.0) - 1.0) * 1.785) + 9;
										物品对怪攻击力 += (int)((Math.Ceiling((double)物品属性强 / 2.0) - 1.0) * 1.785) + 9;
										物品属性_生命力增加 = (int)Math.Floor((double)物品属性强 / 2.0) * 10 + 8;
									}
									else if (value.FLD_PID == 1000001172)
									{
										物品对怪防御力 += (int)((Math.Ceiling((double)物品属性强 / 2.0) - 1.0) * 1.089 + 5.5);
										物品对怪攻击力 += (int)((Math.Ceiling((double)物品属性强 / 2.0) - 1.0) * 1.089 + 5.5);
										物品属性_生命力增加 = (int)Math.Floor((double)物品属性强 / 2.0) * 10 + 1;
									}
									else if (value.FLD_PID == 1000001173)
									{
										物品对怪防御力 += (int)((Math.Ceiling((double)物品属性强 / 2.0) - 1.0) * 1.196) + 6;
										物品对怪攻击力 += (int)((Math.Ceiling((double)物品属性强 / 2.0) - 1.0) * 1.196) + 6;
										物品属性_生命力增加 = (int)Math.Floor((double)物品属性强 / 2.0) * 10 + 2;
									}
									else if (value.FLD_PID == 1000001174)
									{
										物品对怪防御力 += (int)((Math.Ceiling((double)物品属性强 / 2.0) - 1.0) * 1.785) + 9;
										物品对怪攻击力 += (int)((Math.Ceiling((double)物品属性强 / 2.0) - 1.0) * 1.785) + 9;
										物品属性_生命力增加 = (int)Math.Floor((double)物品属性强 / 2.0) * 10;
									}
									else if (value.FLD_PID == 1000001175)
									{
										物品对怪防御力 += (int)((Math.Ceiling((double)物品属性强 / 2.0) - 1.0) * 1.0) + 5;
										物品对怪攻击力 += (int)((Math.Ceiling((double)物品属性强 / 2.0) - 1.0) * 1.0) + 5;
										物品属性_生命力增加 = (int)Math.Floor((double)物品属性强 / 2.0) * 10 + 6;
									}
									switch (fLD_MAGIC)
									{
									case 0:
										物品防御力 += (int)Math.Ceiling((double)物品属性强 / 2.0) + 4;
										物品防御力New += (int)Math.Ceiling((double)物品属性强 / 2.0) + 4;
										物品攻击力 += (int)Math.Ceiling((double)物品属性强 / 2.0) + 4;
										物品攻击力New += (int)Math.Ceiling((double)物品属性强 / 2.0) + 4;
										break;
									case 1:
										物品防御力 += (int)(Math.Ceiling((double)物品属性强 / 2.0) * 1.1875) + 5;
										物品防御力New += (int)(Math.Ceiling((double)物品属性强 / 2.0) * 1.1875) + 5;
										物品攻击力 += (int)(Math.Ceiling((double)物品属性强 / 2.0) * 1.1875) + 5;
										物品攻击力New += (int)(Math.Ceiling((double)物品属性强 / 2.0) * 1.1875) + 5;
										物品对怪防御力 *= 2;
										物品对怪攻击力 *= 2;
										break;
									case 2:
										物品防御力 += (int)(Math.Ceiling((double)物品属性强 / 2.0) * 1.5 + 5.5);
										物品防御力New += (int)(Math.Ceiling((double)物品属性强 / 2.0) * 1.5 + 5.5);
										物品攻击力 += (int)(Math.Ceiling((double)物品属性强 / 2.0) * 1.5 + 5.5);
										物品攻击力New += (int)(Math.Ceiling((double)物品属性强 / 2.0) * 1.5 + 5.5);
										物品对怪防御力 *= 4;
										物品对怪攻击力 *= 4;
										break;
									case 3:
										物品防御力 += (int)(Math.Ceiling((double)物品属性强 / 2.0) * 2.0) + 8;
										物品防御力New += (int)(Math.Ceiling((double)物品属性强 / 2.0) * 2.0) + 8;
										物品攻击力 += (int)(Math.Ceiling((double)物品属性强 / 2.0) * 2.0) + 8;
										物品攻击力New += (int)(Math.Ceiling((double)物品属性强 / 2.0) * 2.0) + 8;
										物品对怪防御力 *= 8;
										物品对怪攻击力 *= 8;
										break;
									}
								}
								else if (物品属性强 == 1)
								{
									int num3 = 5;
									int num4 = 10;
									switch (fLD_MAGIC)
									{
									case 1:
										num3 += 6;
										num4 += 20;
										break;
									case 2:
										num3 += 7;
										num4 += 40;
										break;
									case 3:
										num3 += 10;
										num4 += 80;
										break;
									}
									物品防御力 += num3;
									物品防御力New += num3;
									物品攻击力 += num3;
									物品攻击力New += num3;
									物品对怪防御力 += num4;
									物品对怪攻击力 += num4;
								}
							}
							break;
						}
						}
						break;
					case 9:
						物品属性阶段类型 = 0;
						物品属性阶段数 = 0;
						物品属性强类型 = int.Parse(ysqh.Substring(ysqh.Length - 9, 1));
						物品属性强 = int.Parse(ysqh.Substring(ysqh.Length - 3, 3));
						if (物品属性强类型 == 4)
						{
							if (物品属性强 >= 100)
							{
								物品属性强 = 100;
							}
							if (物品属性强 > 1)
							{
								if ((物品属性强 & 1) == 1)
								{
									物品防御力 += (物品属性强 - 1) / 2 + 5;
									物品防御力New += (物品属性强 - 1) / 2 + 5;
									物品攻击力 += (物品属性强 - 1) / 2 + 5;
									物品攻击力MAX += (物品属性强 - 1) / 2 + 5;
									物品攻击力New += (物品属性强 - 1) / 2 + 5;
									物品攻击力MaxNew += (物品属性强 - 1) / 2 + 5;
									物品属性_生命力增加 += (物品属性强 - 1) / 2 * 10;
									物品属性_获得金钱增加 += (物品属性强 - 1) * 2;
								}
								else
								{
									物品防御力 += 物品属性强 / 2 + 5;
									物品防御力New += 物品属性强 / 2 + 5;
									物品攻击力 += 物品属性强 / 2 + 5;
									物品攻击力MAX += 物品属性强 / 2 + 5;
									物品攻击力New += 物品属性强 / 2 + 5;
									物品攻击力MaxNew += 物品属性强 / 2 + 5;
									物品属性_生命力增加 += 物品属性强 / 2 * 10;
									物品属性_获得金钱增加 += 物品属性强 * 2;
								}
							}
							else
							{
								物品防御力 += 5;
								物品防御力New += 5;
							}
						}
						break;
					case 10:
						物品属性阶段类型 = int.Parse(ysqh.Substring(ysqh.Length - 4, 1));
						物品属性阶段数 = int.Parse(ysqh.Substring(ysqh.Length - 3, 1)) + 1;
						物品属性强类型 = int.Parse(ysqh.Substring(ysqh.Length - 8, 1));
						物品属性强 = int.Parse(ysqh.Substring(ysqh.Length - 2, 2));
						if (物品属性强类型 == 1)
						{
							if (value.FLD_RESIDE2 == 4)
							{
								计算武器属性(value);
								if (物品属性强 > 5 && 物品属性阶段类型 != 0)
								{
									物品属性阶段数 += 物品属性强 - 5;
								}
								int num = 1;
								if (触发属性提升 == 2)
								{
									num = 2;
								}
								if (物品属性阶段类型 != 0 && 物品属性阶段数 > 0)
								{
									switch (物品属性阶段类型)
									{
									case 1:
										物品属性_降低百分比防御 = (double)物品属性阶段数 * 0.005 * (double)num;
										break;
									case 2:
										物品属性_初始化愤怒概率百分比 = 物品属性阶段数 * num;
										break;
									case 3:
										物品属性_增加百分比命中 += (double)物品属性阶段数 * 0.01 * (double)num;
										break;
									case 4:
										物品属性_武功攻击力 += (int)((double)物品属性阶段数 * 0.5) * num;
										物品属性_武功攻击力New += (int)((double)物品属性阶段数 * 0.5) * num;
										break;
									case 5:
										物品属性_追加伤害值 += 物品属性阶段数 * 3 * num;
										break;
									case 6:
										物品属性_追加中毒几率百分比 += (double)物品属性阶段数 * 0.01 * (double)num;
										物品攻击力 += 物品属性阶段数 * 3 * num;
										物品攻击力MAX += 物品属性阶段数 * 3 * num;
										物品攻击力New += 物品属性阶段数 * 3 * num;
										物品攻击力MaxNew += 物品属性阶段数 * 3 * num;
										break;
									}
								}
							}
						}
						else if (物品属性强类型 == 2 && value.FLD_RESIDE2 == 1)
						{
							计算衣服属性(value);
							得到物品障力(value, 物品属性强);
							int num2 = 1;
							if (触发属性提升 == 1)
							{
								num2 = 2;
							}
							if (物品属性阶段类型 != 0 && 物品属性阶段数 > 0)
							{
								switch (物品属性阶段类型)
								{
								case 1:
									物品属性_降低百分比攻击 = (double)物品属性阶段数 * 0.01 * (double)num2;
									break;
								case 2:
									物品属性_愤怒值增加 = 物品属性阶段数 * num2;
									break;
								case 3:
									物品属性_增加百分比回避 += (double)物品属性阶段数 * 0.01 * (double)num2;
									break;
								case 4:
									物品属性_武功防御力增加 += 物品属性阶段数 * 8 * num2;
									物品属性_武功防御力增加New += 物品属性阶段数 * 4 * num2;
									break;
								case 5:
									物品防御力 += 物品属性阶段数 * 3 * num2;
									物品防御力New += 物品属性阶段数 * 3 * num2;
									break;
								case 6:
									物品属性_追加中毒几率百分比 += (double)物品属性阶段数 * 0.01 * (double)num2;
									break;
								}
							}
						}
						break;
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "得到强化   出错：" + ((ex != null) ? ex.ToString() : null));
			}
		}
	}
}
