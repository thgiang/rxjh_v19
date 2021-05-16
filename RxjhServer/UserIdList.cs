using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace RxjhServer
{
	public class UserIdList : Form
	{
		private int _worldid;

		private IContainer components;

		private PropertyGrid propertyGridNPC;

		private ListView listView1;

		private ColumnHeader columnHeader5;

		private ColumnHeader columnHeader1;

		public int worldid
		{
			get
			{
				return _worldid;
			}
			set
			{
				_worldid = value;
			}
		}

		public UserIdList()
		{
			InitializeComponent();
		}

		private void UserIdList_Load(object sender, EventArgs e)
		{
			try
			{
				Players value;
				if (World.allConnectedChars.TryGetValue(worldid, out value))
				{
					additmes("帐号", value.Userid);
					additmes("角色名", value.UserName);
					additmes("元宝", value.FLD_RXPIONT);
					additmes("泡点/赠品元宝", value.FLD_Coin);
					additmes("人物职业", value.Player_Job);
					additmes("人物职业等级", value.Player_Job_leve);
					additmes("人物PK模式", value.人物PK模式);
					additmes("人物武勋", value.Player_WuXun);
					additmes("人物善恶", value.人物善恶);
					additmes("人物等级", value.Player_Level);
					additmes("人物经验", value.人物经验);
					additmes("人物最大经验", value.人物最大经验);
					additmes("人物钱数", value.Player_Money);
					additmes("人物历练", value.Player_ExpErience);
					additmes("升天历练", value.升天历练数);
					additmes("每日获得武勋", value.每日获得武勋);
					additmes("丢失武勋", value.丢失武勋);
					additmes("修炼地图剩余时间", value.修炼地图剩余时间);
					additmes("活动地图剩余时间", value.活动地图剩余时间);
					additmes("PVP_Piont", value.FLD_PVP_Piont);
					additmes("防御--------------------------------", "-------------------");
					additmes("FLD_人物基本_防御", value.FLD_人物基本_防御New);
					additmes("FLD_防御", value.FLD_防御);
					additmes("FLD_装备_追加_防御", value.FLD_装备_追加_防御);
					additmes("FLD_装备_追加_防御New", value.FLD_装备_追加_防御New);
					additmes("FLD_人物_追加_防御", value.FLD_人物_追加_防御);
					additmes("FLD_人物_气功_防御", value.FLD_人物_气功_防御);
					additmes("FLD_追加百分比_防御", value.FLD_追加百分比_防御);
					additmes("FLD_人物_武功防御力增加百分比", value.FLD_人物_武功防御力增加百分比);
					additmes("FLD_装备_武功防御力增加百分比", value.FLD_装备_武功防御力增加百分比);
					additmes("FLD_人物_气功_武功防御力增加百分比", value.FLD_人物_气功_武功防御力增加百分比);
					additmes("FLD_装备_追加_降低百分比防御", value.FLD_装备_追加_降低百分比防御);
					additmes("攻击--------------------------------", "-------------------");
					additmes("FLD_人物基本_攻击", value.FLD_人物基本_攻击);
					additmes("FLD_攻击", value.FLD_攻击);
					additmes("FLD_装备_追加_攻击", value.FLD_装备_追加_攻击);
					additmes("FLD_装备_追加_攻击New", value.FLD_装备_追加_攻击);
					additmes("FLD_人物_追加_攻击", value.FLD_人物_追加_攻击);
					additmes("FLD_人物_气功_攻击", value.FLD_人物_气功_攻击);
					additmes("FLD_追加百分比_攻击", value.FLD_追加百分比_攻击);
					additmes("FLD_人物_武功攻击力增加百分比", value.FLD_人物_武功攻击力增加百分比);
					additmes("FLD_装备_武功攻击力增加百分比", value.FLD_装备_武功攻击力增加百分比);
					additmes("FLD_人物_气功_武功攻击力增加百分比", value.FLD_人物_气功_武功攻击力增加百分比);
					additmes("FLD_装备_追加_降低百分比攻击", value.FLD_装备_追加_降低百分比攻击);
					additmes("其他--------------------------------", "-------------------");
					additmes("FLD_人物_气功_命中", value.FLD_人物_气功_命中);
					additmes("FLD_人物_气功_回避", value.FLD_人物_气功_回避);
					additmes("FLD_人物_追加_命中", value.FLD_人物_追加_命中);
					additmes("FLD_人物_追加_回避", value.FLD_人物_追加_回避);
					additmes("FLD_人物基本_命中", value.FLD_人物基本_命中);
					additmes("FLD_人物基本_回避", value.FLD_人物基本_回避);
					additmes("FLD_体", value.FLD_体);
					additmes("FLD_力", value.FLD_力);
					additmes("FLD_命中", value.FLD_命中);
					additmes("FLD_回避", value.FLD_回避);
					additmes("FLD_心", value.FLD_心);
					additmes("FLD_身", value.FLD_身);
					additmes("FLD_装备_追加_HP", value.FLD_装备_追加_HP);
					additmes("FLD_装备_追加_MP", value.FLD_装备_追加_MP);
					additmes("FLD_装备_追加_命中", value.FLD_装备_追加_命中);
					additmes("FLD_装备_追加_回避", value.FLD_装备_追加_回避);
					additmes("FLD_装备_追加_武器_强化", value.FLD_装备_追加_武器_强化);
					additmes("FLD_装备_追加_气功", value.FLD_装备_追加_气功);
					additmes("FLD_装备_追加_防具_强化", value.FLD_装备_追加_防具_强化);
					additmes("FLD_装备_追加_命中百分比", value.FLD_装备_追加_命中百分比);
					additmes("FLD_装备_追加_回避百分比", value.FLD_装备_追加_回避百分比);
					additmes("FLD_装备_追加_愤怒", value.FLD_装备_追加_愤怒);
					additmes("FLD_装备_追加_觉醒", value.FLD_装备_追加_觉醒);
					additmes("FLD_装备_追加_初始化愤怒概率百分比", value.FLD_装备_追加_初始化愤怒概率百分比);
					additmes("FLD_装备_追加_中毒概率百分比", value.FLD_装备_追加_中毒概率百分比);
					additmes("FLD_装备_降低_伤害值", value.FLD_装备_降低_伤害值);
					additmes("FLD_装备_追加_伤害值", value.FLD_装备_追加_伤害值);
					additmes("FLD_装备_追加_死亡损失经验减少", value.FLD_装备_追加_死亡损失经验减少);
					additmes("FLD_追加百分比_HP上限", value.FLD_追加百分比_HP上限);
					additmes("FLD_追加百分比_MP上限", value.FLD_追加百分比_MP上限);
					additmes("FLD_追加百分比_命中", value.FLD_追加百分比_命中);
					additmes("FLD_追加百分比_回避", value.FLD_人物_追加百分比_回避);
					additmes("人物_HP", value.人物_HP);
					additmes("人物_MP", value.人物_MP);
					additmes("人物_SP", value.人物_SP);
					additmes("人物_气功_追加_HP", value.人物_气功_追加_HP);
					additmes("人物_气功_追加_MP", value.人物_气功_追加_MP);
					additmes("人物_追加_贩卖价格百分比", value.FLD_人物_追加_贩卖价格百分比);
					additmes("人物_追加_武勋获得量百分比", value.FLD_人物_追加_武勋获得量百分比);
					additmes("人物_追加_吸魂几率百分比", value.FLD_人物_追加_吸魂几率百分比);
					additmes("人物_追加_合成成功率百分比", value.FLD_人物_追加_合成成功率百分比);
					additmes("人物_追加_获得游戏币百分比", value.FLD_人物_追加_获得游戏币百分比);
					additmes("人物_追加_经验百分比", value.FLD_人物_追加_经验百分比);
					additmes("宠物_追加_经验百分比", value.FLD_宠物_追加_经验百分比);
					additmes("人物_追加_物品掉落概率百分比", value.FLD_人物_追加_物品掉落概率百分比);
					additmes("人物_追加_历练百分比", value.FLD_人物_追加_历练百分比);
					additmes("所在位置----------------------------", "-------------------");
					additmes("地图ID", value.人物坐标_地图);
					additmes("X坐标", value.人物坐标_X);
					additmes("Y坐标", value.人物坐标_Y);
					additmes("帮派信息----------------------------", "-------------------");
					additmes("帮派名字", value.帮派名字);
					additmes("帮派Id", value.帮派Id);
					additmes("帮派等级", value.帮派等级);
					additmes("帮派人物等级", value.帮派人物等级);
					additmes("情侣信息----------------------------", "-------------------");
					additmes("情侣名字", value.FLD_情侣);
					additmes("爱情度", value.FLD_情侣_爱情度);
					additmes("爱情度等级", value.FLD_爱情度等级);
					additmes("夫妻辅助追加防具属性", value.FLD_夫妻辅助_追加_防具_属性);
					additmes("夫妻辅助追加武器属性", value.FLD_夫妻辅助_追加_武器_属性);
					additmes("夫妻武功攻击力", value.夫妻武功攻击力);
					additmes("夫妻武功攻击力MP", value.夫妻武功攻击力MP);
					additmes("追加状态----------------------------", "-------------------");
					foreach (追加状态类 value4 in value.追加状态列表.Values)
					{
						string text = string.Empty;
						ItmeClass value2;
						if (World.Itme.TryGetValue(value4.FLD_PID, out value2))
						{
							text = value2.ItmeNAME;
						}
						武功类 value3;
						if (text.Length == 0 && World.TBL_KONGFU.TryGetValue(value4.FLD_PID, out value3))
						{
							text = value3.FLD_NAME;
						}
						if (value4.FLD_PID == 700014)
						{
							text = "狂风万破";
						}
						if (text.Length == 0)
						{
							switch (value4.FLD_PID)
							{
							case 350:
								text = "狂意护体";
								break;
							case 310:
								text = "遁出逆境";
								break;
							}
						}
						additmes(value4.FLD_PID + "[" + text + "]", value4.npcyd.Interval / 1000.0);
					}
					additmes("追加状态new-------------------------", "-------------------");
					foreach (追加状态New类 value5 in value.追加状态New列表.Values)
					{
						string str = string.Empty;
						string str2 = string.Empty;
						switch (value5.FLD_PID)
						{
						case 1:
							str = "攻击力增加";
							break;
						case 2:
							str = "防御力增加";
							break;
						case 3:
							str = "生命值上限";
							break;
						case 4:
							str = "内功值上限";
							break;
						case 5:
							str = "命中率增加";
							break;
						case 6:
							str = "回避率增加";
							break;
						case 7:
							str = "武功攻击力增加";
							break;
						case 8:
							str = "武功防御力增加";
							break;
						case 9:
							str = "经验值获得增加";
							break;
						case 10:
							str = "强化合成成功率增加";
							break;
						case 11:
							str = "属性增加";
							break;
						case 12:
							str = "游戏币获得增加";
							break;
						case 13:
							str = "物品掉率增加";
							break;
						case 14:
							str = "所有气功增加";
							break;
						case 15:
							str = "历练值获得增加";
							break;
						}
						if (value5.数量类型 == 2)
						{
							str2 = "%";
						}
						additmes(value5.FLD_PID + "[" + str + "]", value5.数量 + str2 + "|" + value5.npcyd.Interval / 1000.0);
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "人物列表出错" + ((ex != null) ? ex.ToString() : null));
			}
		}

		public void additmes(string a, object b)
		{
			string[] array = new string[2];
			try
			{
				array[0] = a;
				array[1] = b.ToString();
				listView1.Items.Insert(listView1.Items.Count, new ListViewItem(array));
			}
			catch
			{
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			propertyGridNPC = new System.Windows.Forms.PropertyGrid();
			listView1 = new System.Windows.Forms.ListView();
			columnHeader5 = new System.Windows.Forms.ColumnHeader();
			columnHeader1 = new System.Windows.Forms.ColumnHeader();
			SuspendLayout();
			propertyGridNPC.Location = new System.Drawing.Point(313, 127);
			propertyGridNPC.Margin = new System.Windows.Forms.Padding(2);
			propertyGridNPC.Name = "propertyGridNPC";
			propertyGridNPC.PropertySort = System.Windows.Forms.PropertySort.Categorized;
			propertyGridNPC.Size = new System.Drawing.Size(174, 59);
			propertyGridNPC.TabIndex = 7;
			listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[2]
			{
				columnHeader5,
				columnHeader1
			});
			listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			listView1.ForeColor = System.Drawing.SystemColors.WindowText;
			listView1.FullRowSelect = true;
			listView1.GridLines = true;
			listView1.Location = new System.Drawing.Point(0, 0);
			listView1.Name = "listView1";
			listView1.Size = new System.Drawing.Size(378, 627);
			listView1.TabIndex = 8;
			listView1.UseCompatibleStateImageBehavior = false;
			listView1.View = System.Windows.Forms.View.Details;
			columnHeader5.Text = "名称";
			columnHeader5.Width = 228;
			columnHeader1.Text = "数据";
			columnHeader1.Width = 127;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(378, 627);
			base.Controls.Add(listView1);
			base.Controls.Add(propertyGridNPC);
			base.Name = "UserIdList";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "UserIdList";
			base.Load += new System.EventHandler(UserIdList_Load);
			ResumeLayout(false);
		}
	}
}
