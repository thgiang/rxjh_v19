using RxjhServer.DbClss;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace RxjhServer
{
	public class UserList : Form
	{
		private ListView listView1;

		private ColumnHeader columnHeader1;

		private ColumnHeader columnHeader2;

		private ColumnHeader columnHeader3;

		private ColumnHeader columnHeader4;

		private ColumnHeader columnHeader5;

		private ColumnHeader columnHeader6;

		private ColumnHeader columnHeader7;

		private ColumnHeader columnHeader8;

		private ColumnHeader columnHeader9;

		private ColumnHeader columnHeader10;

		private ColumnHeader columnHeader11;

		private ColumnHeader columnHeader12;

		private ColumnHeader columnHeader13;

		private ColumnHeader columnHeader14;

		private ColumnHeader columnHeader15;

		private ColumnHeader columnHeader16;

		private ColumnHeader columnHeader17;

		private ColumnHeader columnHeader18;

		private ContextMenu contextMenu1;

		private MenuItem menuItem1;

		private MenuItem menuItem2;

		private MenuItem menuItem3;

		private MenuItem menuItem4;

		private MenuItem menuItem5;

		private ColumnHeader columnHeader19;

		private MenuItem menuItem6;

		private MenuItem menuItem7;

		private MenuItem menuItem8;

		private MenuItem menuItem9;

		private MenuItem menuItem10;

		private MenuItem menuItem11;

		private Container components;

		public UserList()
		{
			InitializeComponent();
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RxjhServer.UserList));
			listView1 = new System.Windows.Forms.ListView();
			columnHeader5 = new System.Windows.Forms.ColumnHeader();
			columnHeader1 = new System.Windows.Forms.ColumnHeader();
			columnHeader2 = new System.Windows.Forms.ColumnHeader();
			columnHeader3 = new System.Windows.Forms.ColumnHeader();
			columnHeader9 = new System.Windows.Forms.ColumnHeader();
			columnHeader4 = new System.Windows.Forms.ColumnHeader();
			columnHeader18 = new System.Windows.Forms.ColumnHeader();
			columnHeader19 = new System.Windows.Forms.ColumnHeader();
			columnHeader6 = new System.Windows.Forms.ColumnHeader();
			columnHeader7 = new System.Windows.Forms.ColumnHeader();
			columnHeader8 = new System.Windows.Forms.ColumnHeader();
			columnHeader10 = new System.Windows.Forms.ColumnHeader();
			columnHeader14 = new System.Windows.Forms.ColumnHeader();
			columnHeader11 = new System.Windows.Forms.ColumnHeader();
			columnHeader15 = new System.Windows.Forms.ColumnHeader();
			columnHeader13 = new System.Windows.Forms.ColumnHeader();
			columnHeader12 = new System.Windows.Forms.ColumnHeader();
			columnHeader16 = new System.Windows.Forms.ColumnHeader();
			columnHeader17 = new System.Windows.Forms.ColumnHeader();
			contextMenu1 = new System.Windows.Forms.ContextMenu();
			menuItem1 = new System.Windows.Forms.MenuItem();
			menuItem2 = new System.Windows.Forms.MenuItem();
			menuItem3 = new System.Windows.Forms.MenuItem();
			menuItem4 = new System.Windows.Forms.MenuItem();
			menuItem7 = new System.Windows.Forms.MenuItem();
			menuItem8 = new System.Windows.Forms.MenuItem();
			menuItem9 = new System.Windows.Forms.MenuItem();
			menuItem10 = new System.Windows.Forms.MenuItem();
			menuItem11 = new System.Windows.Forms.MenuItem();
			menuItem5 = new System.Windows.Forms.MenuItem();
			menuItem6 = new System.Windows.Forms.MenuItem();
			SuspendLayout();
			listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[19]
			{
				columnHeader5,
				columnHeader1,
				columnHeader2,
				columnHeader3,
				columnHeader9,
				columnHeader4,
				columnHeader18,
				columnHeader19,
				columnHeader6,
				columnHeader7,
				columnHeader8,
				columnHeader10,
				columnHeader14,
				columnHeader11,
				columnHeader15,
				columnHeader13,
				columnHeader12,
				columnHeader16,
				columnHeader17
			});
			listView1.ContextMenu = contextMenu1;
			resources.ApplyResources(listView1, "listView1");
			listView1.ForeColor = System.Drawing.SystemColors.WindowText;
			listView1.FullRowSelect = true;
			listView1.GridLines = true;
			listView1.Name = "listView1";
			listView1.UseCompatibleStateImageBehavior = false;
			listView1.View = System.Windows.Forms.View.Details;
			resources.ApplyResources(columnHeader5, "columnHeader5");
			resources.ApplyResources(columnHeader1, "columnHeader1");
			resources.ApplyResources(columnHeader2, "columnHeader2");
			resources.ApplyResources(columnHeader3, "columnHeader3");
			resources.ApplyResources(columnHeader9, "columnHeader9");
			resources.ApplyResources(columnHeader4, "columnHeader4");
			resources.ApplyResources(columnHeader18, "columnHeader18");
			resources.ApplyResources(columnHeader19, "columnHeader19");
			resources.ApplyResources(columnHeader6, "columnHeader6");
			resources.ApplyResources(columnHeader7, "columnHeader7");
			resources.ApplyResources(columnHeader8, "columnHeader8");
			resources.ApplyResources(columnHeader10, "columnHeader10");
			resources.ApplyResources(columnHeader14, "columnHeader14");
			resources.ApplyResources(columnHeader11, "columnHeader11");
			resources.ApplyResources(columnHeader15, "columnHeader15");
			resources.ApplyResources(columnHeader13, "columnHeader13");
			resources.ApplyResources(columnHeader12, "columnHeader12");
			resources.ApplyResources(columnHeader16, "columnHeader16");
			resources.ApplyResources(columnHeader17, "columnHeader17");
			contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[6]
			{
				menuItem1,
				menuItem2,
				menuItem3,
				menuItem4,
				menuItem5,
				menuItem6
			});
			menuItem1.Index = 0;
			resources.ApplyResources(menuItem1, "menuItem1");
			menuItem1.Click += new System.EventHandler(menuItem1_Click);
			menuItem2.Index = 1;
			resources.ApplyResources(menuItem2, "menuItem2");
			menuItem2.Click += new System.EventHandler(menuItem2_Click);
			menuItem3.Index = 2;
			resources.ApplyResources(menuItem3, "menuItem3");
			menuItem3.Click += new System.EventHandler(menuItem3_Click);
			menuItem4.Index = 3;
			menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[5]
			{
				menuItem7,
				menuItem8,
				menuItem9,
				menuItem10,
				menuItem11
			});
			resources.ApplyResources(menuItem4, "menuItem4");
			menuItem7.Index = 0;
			resources.ApplyResources(menuItem7, "menuItem7");
			menuItem7.Click += new System.EventHandler(menuItem7_Click);
			menuItem8.Index = 1;
			resources.ApplyResources(menuItem8, "menuItem8");
			menuItem8.Click += new System.EventHandler(menuItem8_Click);
			menuItem9.Index = 2;
			resources.ApplyResources(menuItem9, "menuItem9");
			menuItem9.Click += new System.EventHandler(menuItem9_Click);
			menuItem10.Index = 3;
			resources.ApplyResources(menuItem10, "menuItem10");
			menuItem10.Click += new System.EventHandler(menuItem10_Click);
			menuItem11.Index = 4;
			resources.ApplyResources(menuItem11, "menuItem11");
			menuItem11.Click += new System.EventHandler(menuItem11_Click);
			menuItem5.Index = 4;
			resources.ApplyResources(menuItem5, "menuItem5");
			menuItem5.Click += new System.EventHandler(menuItem5_Click);
			menuItem6.Index = 5;
			resources.ApplyResources(menuItem6, "menuItem6");
			menuItem6.Click += new System.EventHandler(menuItem6_Click);
			resources.ApplyResources(this, "$this");
			base.Controls.Add(listView1);
			base.Name = "UserList";
			base.Load += new System.EventHandler(UserList_Load);
			ResumeLayout(false);
		}

		private void UserList_Load(object sender, EventArgs e)
		{
			try
			{
				listView1.ListViewItemSorter = new ListViewColumnSorter();
				listView1.ColumnClick += ListViewHelper.ListView_ColumnClick;
				foreach (Players value in World.allConnectedChars.Values)
				{
					if (value != null)
					{
						string[] array = new string[19];
						try
						{
							string text = array[0] = value.人物全服ID.ToString();
							array[1] = value.Userid;
							array[2] = value.UserName;
							string text2 = array[3] = value.Player_Level.ToString();
							string text3 = array[4] = value.人物_HP.ToString();
							if (value.Client != null)
							{
								array[5] = value.Client.ToString();
							}
							array[6] = value.绑定帐号;
							array[7] = ((!value.Client.挂机) ? "否" : "是");
							string text4 = array[8] = value.人物坐标_地图.ToString();
							string text5 = array[9] = value.人物坐标_X.ToString();
							string text6 = array[10] = value.人物坐标_Y.ToString();
							string text7 = array[11] = value.FLD_人物基本_攻击.ToString();
							array[12] = value.FLD_追加百分比_攻击.ToString();
							string text8 = array[13] = value.FLD_人物基本_防御New.ToString();
							array[14] = value.FLD_追加百分比_防御.ToString();
							string text9 = array[15] = value.FLD_装备_追加_气功.ToString();
							array[16] = value.Client.dwStop.ToString();
							string text10 = array[17] = value.FLD_装备_追加_武器_强化.ToString();
							string text11 = array[18] = value.FLD_装备_追加_防具_强化.ToString();
						}
						catch
						{
							array[0] = value.人物全服ID.ToString();
							array[1] = value.Userid;
							array[2] = value.UserName;
							string text12 = array[3] = value.Player_Level.ToString();
						}
						listView1.Items.Insert(listView1.Items.Count, new ListViewItem(array));
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "人物列表出错" + ex.Message);
			}
		}

		private void menuItem1_Click(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count <= 0)
			{
				return;
			}
			Players players = World.检查玩家name(listView1.SelectedItems[0].SubItems[2].Text);
			if (players == null)
			{
				return;
			}
			if (players.Client.挂机)
			{
				if (players.Client != null)
				{
					players.Client.DisposedOffline();
				}
				World.离线数量--;
				if (World.离线数量 < 0)
				{
					World.离线数量 = 0;
				}
			}
			else if (players.Client != null)
			{
				players.Client.Dispose();
			}
		}

		private void menuItem2_Click(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count <= 0)
			{
				return;
			}
			Players players = World.检查玩家(listView1.SelectedItems[0].SubItems[1].Text);
			if (players == null)
			{
				return;
			}
			if (players.Client.挂机)
			{
				if (players.Client != null)
				{
					players.Client.DisposedOffline();
				}
				World.离线数量--;
				if (World.离线数量 < 0)
				{
					World.离线数量 = 0;
				}
			}
			else if (players.Client != null)
			{
				players.Client.Dispose();
			}
		}

		private void menuItem3_Click(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0)
			{
				DBA.ExeSqlCommand(string.Format(" Insert into TBL_BANED values ( '{0}')", listView1.SelectedItems[0].SubItems[5].Text), "rxjhaccount");
			}
		}

		private void menuItem5_Click(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0)
			{
				string text2 = listView1.SelectedItems[0].SubItems[2].Text;
				int worldid = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
				UserIdList userIdList = new UserIdList();
				userIdList.worldid = worldid;
				userIdList.ShowDialog();
			}
		}

		private void menuItem6_Click(object sender, EventArgs e)
		{
			try
			{
				if (listView1.SelectedItems.Count > 0)
				{
					Players players = World.检查玩家name(listView1.SelectedItems[0].SubItems[2].Text);
					if (players != null)
					{
						string value;
						if (World.禁言列表.TryGetValue(players.UserName, out value))
						{
							World.禁言列表.Remove(players.UserName);
						}
						else
						{
							World.禁言列表.Add(players.UserName, players.Userid);
						}
					}
				}
			}
			catch
			{
			}
		}

		private void menuItem7_Click(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0)
			{
				封号(listView1.SelectedItems[0].SubItems[1].Text, 24);
			}
		}

		private void menuItem8_Click(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0)
			{
				封号(listView1.SelectedItems[0].SubItems[1].Text, 72);
			}
		}

		private void menuItem9_Click(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0)
			{
				封号(listView1.SelectedItems[0].SubItems[1].Text, 168);
			}
		}

		private void menuItem10_Click(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0)
			{
				封号(listView1.SelectedItems[0].SubItems[1].Text, 720);
			}
		}

		private void menuItem11_Click(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0)
			{
				封号(listView1.SelectedItems[0].SubItems[1].Text, 99999);
			}
		}

		private void 封号(string id, int hour)
		{
			DBA.ExeSqlCommand(string.Format("UPDATE TBL_ACCOUNT SET FLD_ZT={1} WHERE FLD_ID='{0}'", id, hour), "rxjhaccount");
			Players players = World.检查玩家(id);
			if (players == null)
			{
				return;
			}
			if (players.Client.挂机)
			{
				if (players.Client != null)
				{
					players.Client.DisposedOffline();
				}
				World.离线数量--;
				if (World.离线数量 < 0)
				{
					World.离线数量 = 0;
				}
			}
			else if (players.Client != null)
			{
				players.Client.Dispose();
			}
		}
	}
}
