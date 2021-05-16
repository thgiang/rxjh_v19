using RxjhServer.DbClss;
using RxjhServer.Network;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace RxjhServer
{
	public class BinIP : Form
	{
		private IContainer components;

		private Button button1;

		private ContextMenuStrip contextMenuStrip1;

		private ToolStripMenuItem 删除ToolStripMenuItem;

		private GroupBox groupBox1;

		private ListView listView2;

		private ColumnHeader columnHeader1;

		private GroupBox groupBox2;

		private ListView listView1;

		private ColumnHeader columnHeader2;

		private GroupBox groupBox3;

		private Label label2;

		private NumericUpDown numericUpDown1;

		private Label label1;

		private GroupBox groupBox4;

		private CheckBox checkBox1;

		private CheckBox checkBox3;

		private CheckBox checkBox2;

		private CheckBox checkBox4;

		private GroupBox groupBox5;

		private Label label4;

		private Label label3;

		private NumericUpDown numericUpDown2;

		private CheckBox checkBox5;

		private ContextMenuStrip contextMenuStrip2;

		private ToolStripMenuItem toolStripMenuItem1;

		private ColumnHeader columnHeader3;

		private Label label5;

		private NumericUpDown numericUpDown3;

		private Label label6;

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
			components = new System.ComponentModel.Container();
			contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
			删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			button1 = new System.Windows.Forms.Button();
			groupBox1 = new System.Windows.Forms.GroupBox();
			listView2 = new System.Windows.Forms.ListView();
			columnHeader3 = new System.Windows.Forms.ColumnHeader();
			columnHeader1 = new System.Windows.Forms.ColumnHeader();
			contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(components);
			toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			groupBox2 = new System.Windows.Forms.GroupBox();
			listView1 = new System.Windows.Forms.ListView();
			columnHeader2 = new System.Windows.Forms.ColumnHeader();
			groupBox3 = new System.Windows.Forms.GroupBox();
			label5 = new System.Windows.Forms.Label();
			numericUpDown3 = new System.Windows.Forms.NumericUpDown();
			label6 = new System.Windows.Forms.Label();
			groupBox5 = new System.Windows.Forms.GroupBox();
			label4 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			checkBox5 = new System.Windows.Forms.CheckBox();
			groupBox4 = new System.Windows.Forms.GroupBox();
			checkBox4 = new System.Windows.Forms.CheckBox();
			checkBox3 = new System.Windows.Forms.CheckBox();
			checkBox2 = new System.Windows.Forms.CheckBox();
			checkBox1 = new System.Windows.Forms.CheckBox();
			label2 = new System.Windows.Forms.Label();
			numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			label1 = new System.Windows.Forms.Label();
			contextMenuStrip1.SuspendLayout();
			groupBox1.SuspendLayout();
			contextMenuStrip2.SuspendLayout();
			groupBox2.SuspendLayout();
			groupBox3.SuspendLayout();
			numericUpDown3.BeginInit();
			groupBox5.SuspendLayout();
			numericUpDown2.BeginInit();
			groupBox4.SuspendLayout();
			numericUpDown1.BeginInit();
			SuspendLayout();
			contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[1]
			{
				删除ToolStripMenuItem
			});
			contextMenuStrip1.Name = "contextMenuStrip1";
			contextMenuStrip1.Size = new System.Drawing.Size(95, 26);
			删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
			删除ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
			删除ToolStripMenuItem.Text = "删除";
			删除ToolStripMenuItem.Click += new System.EventHandler(删除ToolStripMenuItem_Click);
			button1.Location = new System.Drawing.Point(79, 248);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(75, 23);
			button1.TabIndex = 4;
			button1.Text = "确定";
			button1.UseVisualStyleBackColor = true;
			button1.Click += new System.EventHandler(button1_Click);
			groupBox1.Controls.Add(listView2);
			groupBox1.Location = new System.Drawing.Point(8, 9);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new System.Drawing.Size(151, 280);
			groupBox1.TabIndex = 6;
			groupBox1.TabStop = false;
			groupBox1.Text = "当前连接";
			listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[2]
			{
				columnHeader3,
				columnHeader1
			});
			listView2.ContextMenuStrip = contextMenuStrip2;
			listView2.Dock = System.Windows.Forms.DockStyle.Fill;
			listView2.FullRowSelect = true;
			listView2.GridLines = true;
			listView2.Location = new System.Drawing.Point(3, 17);
			listView2.Name = "listView2";
			listView2.Size = new System.Drawing.Size(145, 260);
			listView2.TabIndex = 4;
			listView2.UseCompatibleStateImageBehavior = false;
			listView2.View = System.Windows.Forms.View.Details;
			columnHeader3.Text = "ID";
			columnHeader3.Width = 30;
			columnHeader1.Text = "IP";
			columnHeader1.Width = 150;
			contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[1]
			{
				toolStripMenuItem1
			});
			contextMenuStrip2.Name = "contextMenuStrip1";
			contextMenuStrip2.Size = new System.Drawing.Size(119, 26);
			toolStripMenuItem1.Name = "toolStripMenuItem1";
			toolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
			toolStripMenuItem1.Text = "断开连接";
			toolStripMenuItem1.Click += new System.EventHandler(toolStripMenuItem1_Click);
			groupBox2.Controls.Add(listView1);
			groupBox2.Location = new System.Drawing.Point(165, 9);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new System.Drawing.Size(156, 280);
			groupBox2.TabIndex = 7;
			groupBox2.TabStop = false;
			groupBox2.Text = "过滤列表";
			listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[1]
			{
				columnHeader2
			});
			listView1.ContextMenuStrip = contextMenuStrip1;
			listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			listView1.FullRowSelect = true;
			listView1.GridLines = true;
			listView1.Location = new System.Drawing.Point(3, 17);
			listView1.Name = "listView1";
			listView1.Size = new System.Drawing.Size(150, 260);
			listView1.TabIndex = 5;
			listView1.UseCompatibleStateImageBehavior = false;
			listView1.View = System.Windows.Forms.View.Details;
			columnHeader2.Text = "IP";
			columnHeader2.Width = 150;
			groupBox3.Controls.Add(label5);
			groupBox3.Controls.Add(numericUpDown3);
			groupBox3.Controls.Add(label6);
			groupBox3.Controls.Add(groupBox5);
			groupBox3.Controls.Add(groupBox4);
			groupBox3.Controls.Add(checkBox1);
			groupBox3.Controls.Add(button1);
			groupBox3.Controls.Add(label2);
			groupBox3.Controls.Add(numericUpDown1);
			groupBox3.Controls.Add(label1);
			groupBox3.Location = new System.Drawing.Point(327, 9);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new System.Drawing.Size(162, 280);
			groupBox3.TabIndex = 8;
			groupBox3.TabStop = false;
			groupBox3.Text = "攻击保护";
			label5.AutoSize = true;
			label5.Location = new System.Drawing.Point(137, 65);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(17, 12);
			label5.TabIndex = 18;
			label5.Text = "秒";
			numericUpDown3.Location = new System.Drawing.Point(65, 61);
			numericUpDown3.Maximum = new decimal(new int[4]
			{
				60000,
				0,
				0,
				0
			});
			numericUpDown3.Name = "numericUpDown3";
			numericUpDown3.Size = new System.Drawing.Size(60, 21);
			numericUpDown3.TabIndex = 17;
			numericUpDown3.Value = new decimal(new int[4]
			{
				10000,
				0,
				0,
				0
			});
			label6.AutoSize = true;
			label6.Location = new System.Drawing.Point(6, 65);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(53, 12);
			label6.TabIndex = 16;
			label6.Text = "连接时间";
			groupBox5.Controls.Add(label4);
			groupBox5.Controls.Add(label3);
			groupBox5.Controls.Add(numericUpDown2);
			groupBox5.Controls.Add(checkBox5);
			groupBox5.Location = new System.Drawing.Point(6, 174);
			groupBox5.Name = "groupBox5";
			groupBox5.Size = new System.Drawing.Size(150, 68);
			groupBox5.TabIndex = 15;
			groupBox5.TabStop = false;
			groupBox5.Text = "关闭连接";
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(108, 41);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(17, 12);
			label4.TabIndex = 17;
			label4.Text = "秒";
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(12, 41);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(53, 12);
			label3.TabIndex = 16;
			label3.Text = "间隔时间";
			numericUpDown2.Location = new System.Drawing.Point(67, 37);
			numericUpDown2.Name = "numericUpDown2";
			numericUpDown2.Size = new System.Drawing.Size(38, 21);
			numericUpDown2.TabIndex = 15;
			numericUpDown2.Value = new decimal(new int[4]
			{
				10,
				0,
				0,
				0
			});
			checkBox5.AutoSize = true;
			checkBox5.Location = new System.Drawing.Point(12, 17);
			checkBox5.Name = "checkBox5";
			checkBox5.Size = new System.Drawing.Size(96, 16);
			checkBox5.TabIndex = 14;
			checkBox5.Text = "自动开启连接";
			checkBox5.UseVisualStyleBackColor = true;
			groupBox4.Controls.Add(checkBox4);
			groupBox4.Controls.Add(checkBox3);
			groupBox4.Controls.Add(checkBox2);
			groupBox4.Location = new System.Drawing.Point(6, 85);
			groupBox4.Name = "groupBox4";
			groupBox4.Size = new System.Drawing.Size(150, 79);
			groupBox4.TabIndex = 7;
			groupBox4.TabStop = false;
			groupBox4.Text = "攻击操作";
			checkBox4.AutoSize = true;
			checkBox4.Location = new System.Drawing.Point(12, 54);
			checkBox4.Name = "checkBox4";
			checkBox4.Size = new System.Drawing.Size(72, 16);
			checkBox4.TabIndex = 14;
			checkBox4.Text = "关闭连接";
			checkBox4.UseVisualStyleBackColor = true;
			checkBox3.AutoSize = true;
			checkBox3.Location = new System.Drawing.Point(13, 33);
			checkBox3.Name = "checkBox3";
			checkBox3.Size = new System.Drawing.Size(96, 16);
			checkBox3.TabIndex = 13;
			checkBox3.Text = "加入过滤列表";
			checkBox3.UseVisualStyleBackColor = true;
			checkBox2.AutoSize = true;
			checkBox2.Location = new System.Drawing.Point(14, 14);
			checkBox2.Name = "checkBox2";
			checkBox2.Size = new System.Drawing.Size(72, 16);
			checkBox2.TabIndex = 12;
			checkBox2.Text = "断开连接";
			checkBox2.UseVisualStyleBackColor = true;
			checkBox1.AutoSize = true;
			checkBox1.Location = new System.Drawing.Point(11, 17);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new System.Drawing.Size(96, 16);
			checkBox1.TabIndex = 6;
			checkBox1.Text = "开启攻击保护";
			checkBox1.UseVisualStyleBackColor = true;
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(109, 41);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(47, 12);
			label2.TabIndex = 2;
			label2.Text = "连接/IP";
			numericUpDown1.Location = new System.Drawing.Point(65, 37);
			numericUpDown1.Minimum = new decimal(new int[4]
			{
				2,
				0,
				0,
				0
			});
			numericUpDown1.Name = "numericUpDown1";
			numericUpDown1.Size = new System.Drawing.Size(38, 21);
			numericUpDown1.TabIndex = 1;
			numericUpDown1.Value = new decimal(new int[4]
			{
				5,
				0,
				0,
				0
			});
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(6, 41);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(53, 12);
			label1.TabIndex = 0;
			label1.Text = "连接限制";
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(493, 293);
			base.Controls.Add(groupBox3);
			base.Controls.Add(groupBox2);
			base.Controls.Add(groupBox1);
			base.MaximizeBox = false;
			base.Name = "BinIP";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "防CC设置";
			base.Load += new System.EventHandler(BinIP_Load);
			contextMenuStrip1.ResumeLayout(false);
			groupBox1.ResumeLayout(false);
			contextMenuStrip2.ResumeLayout(false);
			groupBox2.ResumeLayout(false);
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			numericUpDown3.EndInit();
			groupBox5.ResumeLayout(false);
			groupBox5.PerformLayout();
			numericUpDown2.EndInit();
			groupBox4.ResumeLayout(false);
			groupBox4.PerformLayout();
			numericUpDown1.EndInit();
			ResumeLayout(false);
		}

		public BinIP()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			World.封IP = checkBox1.Checked;
			World.游戏登陆端口最大连接数 = (int)numericUpDown1.Value;
			World.自动连接时间 = (int)numericUpDown2.Value;
			World.游戏登陆端口最大连接时间数 = (int)numericUpDown3.Value;
			World.自动开启连接 = checkBox5.Checked;
			World.断开连接 = checkBox2.Checked;
			World.加入过滤列表 = checkBox3.Checked;
			World.关闭连接 = checkBox4.Checked;
			Config.IniWriteValue("GameServer", "封IP", checkBox1.Checked.ToString());
			Config.IniWriteValue("GameServer", "自动开启连接", checkBox5.Checked.ToString());
			Config.IniWriteValue("GameServer", "断开连接", checkBox2.Checked.ToString());
			Config.IniWriteValue("GameServer", "加入过滤列表", checkBox3.Checked.ToString());
			Config.IniWriteValue("GameServer", "关闭连接", checkBox4.Checked.ToString());
			Config.IniWriteValue("GameServer", "游戏登陆端口最大连接数", numericUpDown1.Value.ToString());
			Config.IniWriteValue("GameServer", "自动连接时间", numericUpDown2.Value.ToString());
			Config.IniWriteValue("GameServer", "游戏登陆端口最大连接时间数", numericUpDown3.Value.ToString());
			Close();
		}

		private void BinIP_Load(object sender, EventArgs e)
		{
			bind();
			bind2();
			bind3();
		}

		public void bind3()
		{
			checkBox1.Checked = World.封IP;
			numericUpDown1.Value = World.游戏登陆端口最大连接数;
			numericUpDown2.Value = World.自动连接时间;
			numericUpDown3.Value = World.游戏登陆端口最大连接时间数;
			checkBox5.Checked = World.自动开启连接;
			checkBox2.Checked = World.断开连接;
			checkBox3.Checked = World.加入过滤列表;
			checkBox4.Checked = World.关闭连接;
		}

		public void bind()
		{
			listView1.Items.Clear();
			foreach (IPAddress bip in World.BipList)
			{
				listView1.Items.Insert(listView1.Items.Count, new ListViewItem(new string[1]
				{
					bip.ToString()
				}));
			}
		}

		public void bind2()
		{
			listView2.Items.Clear();
			foreach (NetState value in World.list.Values)
			{
				listView2.Items.Insert(listView2.Items.Count, new ListViewItem(new string[2]
				{
					value.WorldId.ToString(),
					value.ToString()
				}));
			}
		}

		private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0)
			{
				for (int i = 0; i < listView1.SelectedItems.Count; i++)
				{
					string text = listView1.SelectedItems[i].SubItems[0].Text;
					World.BipList.Remove(IPAddress.Parse(text));
					bind();
				}
			}
		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if (listView2.SelectedItems.Count <= 0)
			{
				return;
			}
			for (int i = 0; i < listView2.SelectedItems.Count; i++)
			{
				string text = listView2.SelectedItems[i].SubItems[0].Text;
				NetState value;
				if (World.list.TryGetValue(int.Parse(text), out value))
				{
					value.Dispose();
				}
				bind2();
			}
		}
	}
}
