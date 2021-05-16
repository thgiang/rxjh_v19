using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace RxjhServer
{
	public class FormUser组队 : Form
	{
		private IContainer components;

		private ListView listView1;

		private ColumnHeader columnHeader5;

		private ColumnHeader columnHeader1;

		private SplitContainer splitContainer1;

		private ListView listView2;

		private ColumnHeader columnHeader2;

		private ColumnHeader columnHeader3;

		private ColumnHeader columnHeader4;

		private ColumnHeader columnHeader6;

		private ColumnHeader columnHeader9;

		private ColumnHeader columnHeader7;

		private ColumnHeader columnHeader8;

		private ColumnHeader columnHeader10;

		private ColumnHeader columnHeader11;

		private ColumnHeader columnHeader12;

		private ColumnHeader columnHeader14;

		private ColumnHeader columnHeader13;

		private ColumnHeader columnHeader15;

		private ColumnHeader columnHeader16;

		private ColumnHeader columnHeader17;

		private ColumnHeader columnHeader18;

		private ColumnHeader columnHeader19;

		public FormUser组队()
		{
			InitializeComponent();
		}

		private void FormUser组队_Load(object sender, EventArgs e)
		{
			foreach (组队Class value in World.W组队.Values)
			{
				string[] array = new string[2];
				try
				{
					array[0] = value.组队id.ToString();
					array[1] = value.队员列表.Count.ToString();
					listView1.Items.Insert(listView1.Items.Count, new ListViewItem(array));
				}
				catch
				{
				}
			}
		}

		private void listView1_Click(object sender, EventArgs e)
		{
			组队Class value;
			if (listView1.SelectedItems.Count > 0 && World.W组队.TryGetValue(int.Parse(listView1.SelectedItems[0].SubItems[0].Text), out value))
			{
				listView2.Items.Clear();
				foreach (Players value2 in value.队员列表.Values)
				{
					string[] array = new string[17];
					try
					{
						string text = array[0] = value2.人物全服ID.ToString();
						array[1] = value2.Userid;
						array[2] = value2.UserName;
						string text2 = array[3] = value2.Player_Level.ToString();
						string text3 = array[4] = value2.人物_HP.ToString();
						if (value2.Client != null)
						{
							array[5] = value2.Client.ToString();
						}
						string text4 = array[6] = value2.人物坐标_地图.ToString();
						array[7] = value2.人物坐标_X.ToString();
						array[8] = value2.人物坐标_Y.ToString();
						string text5 = array[9] = value2.FLD_人物基本_攻击.ToString();
						array[10] = value2.FLD_追加百分比_攻击.ToString();
						string text6 = array[11] = value2.FLD_人物基本_防御New.ToString();
						array[12] = value2.FLD_追加百分比_防御.ToString();
						string text7 = array[13] = value2.FLD_装备_追加_气功.ToString();
						array[14] = value2.Client.dwStop.ToString();
						string text8 = array[15] = value2.FLD_装备_追加_武器_强化.ToString();
						string text9 = array[16] = value2.FLD_装备_追加_防具_强化.ToString();
					}
					catch
					{
						array[0] = value2.人物全服ID.ToString();
						array[1] = value2.Userid;
						array[2] = value2.UserName;
						string text10 = array[3] = value2.Player_Level.ToString();
					}
					listView2.Items.Insert(listView2.Items.Count, new ListViewItem(array));
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
			listView1 = new System.Windows.Forms.ListView();
			columnHeader5 = new System.Windows.Forms.ColumnHeader();
			columnHeader1 = new System.Windows.Forms.ColumnHeader();
			splitContainer1 = new System.Windows.Forms.SplitContainer();
			listView2 = new System.Windows.Forms.ListView();
			columnHeader2 = new System.Windows.Forms.ColumnHeader();
			columnHeader3 = new System.Windows.Forms.ColumnHeader();
			columnHeader4 = new System.Windows.Forms.ColumnHeader();
			columnHeader6 = new System.Windows.Forms.ColumnHeader();
			columnHeader9 = new System.Windows.Forms.ColumnHeader();
			columnHeader7 = new System.Windows.Forms.ColumnHeader();
			columnHeader8 = new System.Windows.Forms.ColumnHeader();
			columnHeader10 = new System.Windows.Forms.ColumnHeader();
			columnHeader11 = new System.Windows.Forms.ColumnHeader();
			columnHeader12 = new System.Windows.Forms.ColumnHeader();
			columnHeader14 = new System.Windows.Forms.ColumnHeader();
			columnHeader13 = new System.Windows.Forms.ColumnHeader();
			columnHeader15 = new System.Windows.Forms.ColumnHeader();
			columnHeader16 = new System.Windows.Forms.ColumnHeader();
			columnHeader17 = new System.Windows.Forms.ColumnHeader();
			columnHeader18 = new System.Windows.Forms.ColumnHeader();
			columnHeader19 = new System.Windows.Forms.ColumnHeader();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			SuspendLayout();
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
			listView1.Size = new System.Drawing.Size(550, 168);
			listView1.TabIndex = 9;
			listView1.UseCompatibleStateImageBehavior = false;
			listView1.View = System.Windows.Forms.View.Details;
			listView1.Click += new System.EventHandler(listView1_Click);
			columnHeader5.Text = "名称";
			columnHeader5.Width = 71;
			columnHeader1.Text = "数据";
			columnHeader1.Width = 90;
			splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			splitContainer1.Location = new System.Drawing.Point(0, 0);
			splitContainer1.Name = "splitContainer1";
			splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			splitContainer1.Panel1.Controls.Add(listView1);
			splitContainer1.Panel2.Controls.Add(listView2);
			splitContainer1.Size = new System.Drawing.Size(550, 372);
			splitContainer1.SplitterDistance = 168;
			splitContainer1.TabIndex = 10;
			listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[17]
			{
				columnHeader2,
				columnHeader3,
				columnHeader4,
				columnHeader6,
				columnHeader9,
				columnHeader7,
				columnHeader8,
				columnHeader10,
				columnHeader11,
				columnHeader12,
				columnHeader14,
				columnHeader13,
				columnHeader15,
				columnHeader16,
				columnHeader17,
				columnHeader18,
				columnHeader19
			});
			listView2.Dock = System.Windows.Forms.DockStyle.Fill;
			listView2.ForeColor = System.Drawing.SystemColors.WindowText;
			listView2.FullRowSelect = true;
			listView2.GridLines = true;
			listView2.Location = new System.Drawing.Point(0, 0);
			listView2.Name = "listView2";
			listView2.Size = new System.Drawing.Size(550, 200);
			listView2.TabIndex = 2;
			listView2.UseCompatibleStateImageBehavior = false;
			listView2.View = System.Windows.Forms.View.Details;
			columnHeader2.Text = "序号";
			columnHeader2.Width = 36;
			columnHeader3.Text = "ID";
			columnHeader3.Width = 66;
			columnHeader4.Text = "名字";
			columnHeader4.Width = 98;
			columnHeader6.Text = "等级";
			columnHeader6.Width = 38;
			columnHeader9.Text = "HP";
			columnHeader9.Width = 47;
			columnHeader7.Text = "IP";
			columnHeader7.Width = 113;
			columnHeader8.Text = "地图";
			columnHeader8.Width = 42;
			columnHeader10.Text = "X";
			columnHeader10.Width = 61;
			columnHeader11.Text = "Y";
			columnHeader11.Width = 61;
			columnHeader12.Text = "攻";
			columnHeader12.Width = 36;
			columnHeader14.Text = "攻加";
			columnHeader14.Width = 41;
			columnHeader13.Text = "防";
			columnHeader13.Width = 37;
			columnHeader15.Text = "防加";
			columnHeader15.Width = 39;
			columnHeader16.Text = "气";
			columnHeader16.Width = 39;
			columnHeader17.Text = "ping";
			columnHeader17.Width = 39;
			columnHeader18.Text = "攻强";
			columnHeader18.Width = 39;
			columnHeader19.Text = "防强";
			columnHeader19.Width = 37;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(550, 372);
			base.Controls.Add(splitContainer1);
			base.Name = "FormUser组队";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "FormUser组队";
			base.Load += new System.EventHandler(FormUser组队_Load);
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			splitContainer1.ResumeLayout(false);
			ResumeLayout(false);
		}
	}
}
