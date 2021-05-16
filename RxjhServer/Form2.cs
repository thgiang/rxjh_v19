using RxjhServer.DbClss;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace RxjhServer
{
	public class Form2 : Form
	{
		private IContainer components;

		private ListView listView2;

		private ColumnHeader columnHeader2;

		private ColumnHeader columnHeader3;

		private ColumnHeader columnHeader4;

		private ColumnHeader columnHeader8;

		private ColumnHeader columnHeader10;

		private ColumnHeader columnHeader11;

		private ColumnHeader columnHeader12;

		private ColumnHeader columnHeader14;

		private ColumnHeader columnHeader13;

		private ColumnHeader columnHeader15;

		private ColumnHeader columnHeader16;

		private ColumnHeader columnHeader17;

		public Form2()
		{
			InitializeComponent();
		}

		public static void FlushAll1()
		{
			int num = 0;
			Form1.WriteLine(100, "删除人物数据开始");
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("select * from TBL_XWWL_Char"));
			if (dBToDataTable != null)
			{
				Form1.WriteLine(100, "共有人物数据" + dBToDataTable.Rows.Count);
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					if ((int)DBA.GetDBValue_3(string.Format("select count(*) from TBL_ACCOUNT where FLD_ID='{0}'", dBToDataTable.Rows[i]["FLD_ID"]), "rxjhaccount") >= 1)
					{
						continue;
					}
					num++;
					string[] obj = new string[5]
					{
						"删除人物[",
						dBToDataTable.Rows[i]["FLD_ID"].ToString(),
						"] [",
						null,
						null
					};
					object obj2 = dBToDataTable.Rows[i]["FLD_NAME"];
					obj[3] = ((obj2 != null) ? obj2.ToString() : null);
					obj[4] = "]";
					Form1.WriteLine(100, string.Concat(obj));
					DBA.ExeSqlCommand(string.Format("DELETE FROM TBL_XWWL_Char WHERE FLD_NAME  ='{0}'", dBToDataTable.Rows[i]["FLD_NAME"].ToString()));
					DBA.ExeSqlCommand(string.Format("DELETE FROM TBL_XWWL_warehouse WHERE FLD_NAME  ='{0}'", dBToDataTable.Rows[i]["FLD_NAME"].ToString()));
					DataTable dBToDataTable2 = DBA.GetDBToDataTable(string.Format("select * from TBL_XWWL_GuildMember WHERE FLD_NAME ='{0}'", dBToDataTable.Rows[i]["FLD_NAME"].ToString()));
					if (dBToDataTable2 == null)
					{
						continue;
					}
					if (dBToDataTable2.Rows.Count > 0)
					{
						if (Buffer.IsEquals(dBToDataTable2.Rows[0]["leve"].ToString(), "6"))
						{
							object obj3 = dBToDataTable2.Rows[0]["G_Name"];
							Form1.WriteLine(100, "删除帮派" + ((obj3 != null) ? obj3.ToString() : null));
							DBA.ExeSqlCommand(string.Format("DELETE FROM TBL_XWWL_Guild WHERE G_Name  ='{0}'", dBToDataTable2.Rows[0]["G_Name"].ToString()));
							DBA.ExeSqlCommand(string.Format("DELETE FROM TBL_XWWL_GuildMember WHERE G_Name  ='{0}'", dBToDataTable2.Rows[0]["G_Name"].ToString()));
						}
						else
						{
							DBA.ExeSqlCommand(string.Format("DELETE FROM TBL_XWWL_GuildMember WHERE FLD_NAME  ='{0}'", dBToDataTable.Rows[i]["FLD_NAME"].ToString()));
						}
					}
					dBToDataTable2.Dispose();
				}
				dBToDataTable.Dispose();
			}
			Form1.WriteLine(100, "删除人物数据完成" + num);
		}

		public static void FlushAll2()
		{
			int num = 0;
			Form1.WriteLine(100, "删除人物仓库数据开始");
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("select * from TBL_XWWL_warehouse"));
			if (dBToDataTable != null)
			{
				Form1.WriteLine(100, "共有人物数据" + dBToDataTable.Rows.Count);
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					DataTable dBToDataTable2 = DBA.GetDBToDataTable(string.Format("select * from TBL_XWWL_Char where FLD_NAME='{0}'", dBToDataTable.Rows[i]["FLD_NAME"]));
					if (dBToDataTable2.Rows.Count < 1)
					{
						num++;
						string[] obj = new string[5]
						{
							"删除人物仓库[",
							dBToDataTable.Rows[i]["FLD_ID"].ToString(),
							"] [",
							null,
							null
						};
						object obj2 = dBToDataTable.Rows[i]["FLD_NAME"];
						obj[3] = ((obj2 != null) ? obj2.ToString() : null);
						obj[4] = "]";
						Form1.WriteLine(100, string.Concat(obj));
						DBA.ExeSqlCommand(string.Format("DELETE FROM TBL_XWWL_warehouse WHERE FLD_ID='{0}'and FLD_NAME  ='{1}'", dBToDataTable.Rows[i]["FLD_ID"].ToString(), dBToDataTable.Rows[i]["FLD_NAME"].ToString()));
					}
					else if (dBToDataTable2.Rows[0]["FLD_ID"].ToString() != dBToDataTable.Rows[i]["FLD_ID"].ToString())
					{
						num++;
						string[] obj3 = new string[5]
						{
							"删除人物仓库[",
							dBToDataTable.Rows[i]["FLD_ID"].ToString(),
							"] [",
							null,
							null
						};
						object obj4 = dBToDataTable.Rows[i]["FLD_NAME"];
						obj3[3] = ((obj4 != null) ? obj4.ToString() : null);
						obj3[4] = "]";
						Form1.WriteLine(100, string.Concat(obj3));
						DBA.ExeSqlCommand(string.Format("DELETE FROM TBL_XWWL_warehouse WHERE FLD_ID='{0}'and FLD_NAME  ='{1}'", dBToDataTable.Rows[i]["FLD_ID"].ToString(), dBToDataTable.Rows[i]["FLD_NAME"].ToString()));
					}
					dBToDataTable2.Dispose();
				}
				dBToDataTable.Dispose();
			}
			Form1.WriteLine(100, "删除人物仓库数据完成" + num);
		}

		public static void FlushAll3()
		{
			int num = 0;
			Form1.WriteLine(100, "删除宗合仓库开始");
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("select * from TBL_XWWL_PublicWarehouse"));
			if (dBToDataTable != null)
			{
				Form1.WriteLine(100, "共有宗合仓库数据" + dBToDataTable.Rows.Count);
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					if ((int)DBA.GetDBValue_3(string.Format("select count(*) from TBL_ACCOUNT where FLD_ID='{0}'", dBToDataTable.Rows[i]["FLD_ID"]), "rxjhaccount") < 1)
					{
						num++;
						Form1.WriteLine(100, "删除宗合仓库[" + dBToDataTable.Rows[i]["FLD_ID"].ToString() + "]");
						DBA.ExeSqlCommand(string.Format("DELETE FROM TBL_XWWL_PublicWarehouse WHERE FLD_ID  ='{0}'", dBToDataTable.Rows[i]["FLD_ID"].ToString()));
					}
				}
				dBToDataTable.Dispose();
			}
			Form1.WriteLine(100, "删除宗合仓库完成" + num);
		}

		public static void FlushAll4()
		{
			int num = 0;
			Form1.WriteLine(100, "删除帮派数据开始");
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("select * from TBL_XWWL_Guild"));
			if (dBToDataTable != null)
			{
				Form1.WriteLine(100, "共有人物数据" + dBToDataTable.Rows.Count);
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					DataTable dBToDataTable2 = DBA.GetDBToDataTable(string.Format("select * from TBL_XWWL_Char where FLD_NAME='{0}'", dBToDataTable.Rows[i]["G_Master"]));
					if (dBToDataTable2.Rows.Count < 1)
					{
						num++;
						string[] obj = new string[5]
						{
							"删除帮派[",
							dBToDataTable.Rows[i]["G_Name"].ToString(),
							"] [",
							null,
							null
						};
						object obj2 = dBToDataTable.Rows[i]["G_Master"];
						obj[3] = ((obj2 != null) ? obj2.ToString() : null);
						obj[4] = "]";
						Form1.WriteLine(100, string.Concat(obj));
						DBA.ExeSqlCommand(string.Format("DELETE FROM TBL_XWWL_Guild WHERE G_Name  ='{0}'", dBToDataTable.Rows[i]["G_Name"].ToString()));
						DBA.ExeSqlCommand(string.Format("DELETE FROM TBL_XWWL_GuildMember WHERE G_Name  ='{0}'", dBToDataTable.Rows[i]["G_Name"].ToString()));
					}
					dBToDataTable2.Dispose();
				}
				dBToDataTable.Dispose();
			}
			Form1.WriteLine(100, "删除帮派数据完成" + num);
			FlushAll5();
		}

		public static void FlushAll5()
		{
			int num = 0;
			Form1.WriteLine(100, "删除帮派数据开始");
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("select * from TBL_XWWL_GuildMember"));
			if (dBToDataTable != null)
			{
				Form1.WriteLine(100, "共有帮派数据" + dBToDataTable.Rows.Count);
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					DataTable dBToDataTable2 = DBA.GetDBToDataTable(string.Format("select * from TBL_XWWL_Char where FLD_NAME='{0}'", dBToDataTable.Rows[i]["FLD_NAME"]));
					if (dBToDataTable2.Rows.Count < 1)
					{
						num++;
						if (dBToDataTable.Rows[0]["leve"].ToString() == "6")
						{
							object obj = dBToDataTable.Rows[i]["G_Name"];
							Form1.WriteLine(100, "删除帮派" + ((obj != null) ? obj.ToString() : null));
							DBA.ExeSqlCommand(string.Format("DELETE FROM TBL_XWWL_Guild WHERE G_Name  ='{0}'", dBToDataTable.Rows[0]["G_Name"].ToString()));
							DBA.ExeSqlCommand(string.Format("DELETE FROM TBL_XWWL_GuildMember WHERE G_Name  ='{0}'", dBToDataTable.Rows[0]["G_Name"].ToString()));
						}
						else
						{
							object obj2 = dBToDataTable.Rows[i]["G_Name"];
							Form1.WriteLine(100, "删除帮派" + ((obj2 != null) ? obj2.ToString() : null) + "    " + dBToDataTable.Rows[i]["FLD_NAME"].ToString());
							DBA.ExeSqlCommand(string.Format("DELETE FROM TBL_XWWL_GuildMember WHERE FLD_NAME  ='{0}'", dBToDataTable.Rows[i]["FLD_NAME"].ToString()));
						}
					}
					dBToDataTable2.Dispose();
				}
				dBToDataTable.Dispose();
			}
			Form1.WriteLine(100, "删除帮派数据完成" + num);
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			listView2.ListViewItemSorter = new ListViewColumnSorter();
			listView2.ColumnClick += ListViewHelper.ListView_ColumnClick;
			foreach (地面物品类 value in World.ItmeTeM.Values)
			{
				try
				{
					string[] array = new string[17];
					try
					{
						array[0] = BitConverter.ToInt64(value.物品.物品全局ID, 0).ToString();
						array[1] = Buffer.ToInt32(value.物品.物品ID, 0).ToString();
						array[2] = value.物品.得到物品名称();
						array[3] = value.Rxjh_Map.ToString();
						array[4] = value.Rxjh_X.ToString();
						array[5] = value.Rxjh_Y.ToString();
						array[6] = value.物品.FLD_MAGIC0.ToString();
						array[7] = value.物品.FLD_MAGIC1.ToString();
						array[8] = value.物品.FLD_MAGIC2.ToString();
						array[9] = value.物品.FLD_MAGIC3.ToString();
						array[10] = value.物品.FLD_MAGIC4.ToString();
						array[11] = value.物品优先权.UserName;
					}
					catch
					{
						array[0] = BitConverter.ToInt64(value.物品.物品全局ID, 0).ToString();
						string text = array[1] = Buffer.ToInt32(value.物品.物品ID, 0).ToString();
						array[2] = value.物品.得到物品名称();
						string text2 = array[3] = value.Rxjh_Map.ToString();
						string text3 = array[4] = value.Rxjh_X.ToString();
						string text4 = array[5] = value.Rxjh_Y.ToString();
						string text5 = array[6] = value.物品.FLD_MAGIC0.ToString();
						string text6 = array[7] = value.物品.FLD_MAGIC1.ToString();
						string text7 = array[8] = value.物品.FLD_MAGIC2.ToString();
						string text8 = array[9] = value.物品.FLD_MAGIC3.ToString();
						string text9 = array[10] = value.物品.FLD_MAGIC4.ToString();
					}
					listView2.Items.Insert(listView2.Items.Count, new ListViewItem(array));
				}
				catch
				{
				}
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
			listView2 = new System.Windows.Forms.ListView();
			columnHeader2 = new System.Windows.Forms.ColumnHeader();
			columnHeader3 = new System.Windows.Forms.ColumnHeader();
			columnHeader4 = new System.Windows.Forms.ColumnHeader();
			columnHeader8 = new System.Windows.Forms.ColumnHeader();
			columnHeader10 = new System.Windows.Forms.ColumnHeader();
			columnHeader11 = new System.Windows.Forms.ColumnHeader();
			columnHeader12 = new System.Windows.Forms.ColumnHeader();
			columnHeader14 = new System.Windows.Forms.ColumnHeader();
			columnHeader13 = new System.Windows.Forms.ColumnHeader();
			columnHeader15 = new System.Windows.Forms.ColumnHeader();
			columnHeader16 = new System.Windows.Forms.ColumnHeader();
			columnHeader17 = new System.Windows.Forms.ColumnHeader();
			SuspendLayout();
			listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[12]
			{
				columnHeader2,
				columnHeader3,
				columnHeader4,
				columnHeader8,
				columnHeader10,
				columnHeader11,
				columnHeader12,
				columnHeader14,
				columnHeader13,
				columnHeader15,
				columnHeader16,
				columnHeader17
			});
			listView2.Dock = System.Windows.Forms.DockStyle.Fill;
			listView2.ForeColor = System.Drawing.SystemColors.WindowText;
			listView2.FullRowSelect = true;
			listView2.GridLines = true;
			listView2.Location = new System.Drawing.Point(0, 0);
			listView2.Name = "listView2";
			listView2.Size = new System.Drawing.Size(769, 384);
			listView2.TabIndex = 3;
			listView2.UseCompatibleStateImageBehavior = false;
			listView2.View = System.Windows.Forms.View.Details;
			columnHeader2.Text = "全局ID";
			columnHeader2.Width = 65;
			columnHeader3.Text = "物品ID";
			columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			columnHeader3.Width = 79;
			columnHeader4.Text = "物品名";
			columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			columnHeader4.Width = 98;
			columnHeader8.Text = "地图";
			columnHeader8.Width = 42;
			columnHeader10.Text = "X";
			columnHeader10.Width = 61;
			columnHeader11.Text = "Y";
			columnHeader11.Width = 61;
			columnHeader12.Text = "属性0";
			columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			columnHeader14.Text = "属性1";
			columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			columnHeader13.Text = "属性2";
			columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			columnHeader15.Text = "属性3";
			columnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			columnHeader16.Text = "属性4";
			columnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			columnHeader17.Text = "优先";
			columnHeader17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			columnHeader17.Width = 56;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(769, 384);
			base.Controls.Add(listView2);
			base.Name = "Form2";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "地面物品";
			base.Load += new System.EventHandler(Form2_Load);
			ResumeLayout(false);
		}
	}
}
