using RxjhServer.DbClss;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace RxjhTool
{
	public class YbiForm : Form
	{
		public static Dictionary<int, YbiClass> ybidate = new Dictionary<int, YbiClass>();

		private static byte[] key = new byte[64]
		{
			18,
			29,
			7,
			25,
			15,
			31,
			22,
			27,
			9,
			26,
			3,
			13,
			19,
			14,
			20,
			11,
			5,
			2,
			23,
			16,
			10,
			24,
			28,
			17,
			6,
			30,
			0,
			21,
			12,
			8,
			4,
			1,
			26,
			31,
			17,
			10,
			30,
			16,
			24,
			2,
			29,
			8,
			20,
			15,
			28,
			11,
			13,
			4,
			19,
			23,
			0,
			12,
			14,
			27,
			6,
			18,
			21,
			3,
			9,
			7,
			22,
			1,
			25,
			5
		};

		private byte[] byte_1A24628 = new byte[256];

		private byte[] byte_8B42F4 = new byte[150]
		{
			45,
			151,
			132,
			242,
			40,
			209,
			41,
			84,
			241,
			18,
			2,
			40,
			107,
			32,
			97,
			66,
			245,
			236,
			31,
			82,
			34,
			68,
			59,
			35,
			87,
			63,
			98,
			111,
			242,
			163,
			36,
			210,
			167,
			22,
			86,
			193,
			242,
			2,
			72,
			98,
			39,
			66,
			33,
			172,
			35,
			173,
			67,
			242,
			50,
			24,
			4,
			80,
			69,
			113,
			191,
			110,
			120,
			97,
			114,
			88,
			34,
			146,
			22,
			2,
			120,
			98,
			215,
			40,
			82,
			223,
			232,
			179,
			66,
			20,
			177,
			166,
			110,
			49,
			175,
			38,
			33,
			179,
			215,
			84,
			233,
			47,
			114,
			44,
			63,
			81,
			244,
			17,
			2,
			242,
			183,
			64,
			37,
			195,
			37,
			130,
			67,
			50,
			36,
			241,
			238,
			255,
			66,
			18,
			4,
			158,
			47,
			249,
			100,
			33,
			246,
			49,
			114,
			8,
			116,
			130,
			35,
			25,
			222,
			207,
			35,
			39,
			56,
			54,
			237,
			242,
			73,
			98,
			113,
			40,
			232,
			34,
			59,
			183,
			53,
			66,
			119,
			66,
			47,
			164,
			66,
			39,
			148,
			2,
			98,
			167
		};

		private byte[] 物品 = new byte[8520000];

		private byte[] KEY = new byte[64];

		private byte[] 武功 = new byte[6897664];

		private byte[] 气功 = new byte[1421312];

		private byte[] 称号 = new byte[9216];

		private byte[] 屏蔽1 = new byte[131072];

		private byte[] 屏蔽2 = new byte[262144];

		private byte[] NPC = new byte[16097280];

		private byte[] 未知1 = new byte[96];

		private byte[] 地图名 = new byte[102400];

		private byte[] 未知2 = new byte[98304];

		private IContainer components;

		private MenuStrip menuStrip1;

		private ToolStripMenuItem 文件ToolStripMenuItem;

		private ToolStripMenuItem 打开YBIToolStripMenuItem;

		private ToolStripMenuItem 保存YBIToolStripMenuItem;

		private ListBox listBox1;

		private GroupBox groupBox1;

		private GroupBox groupBox2;

		private Label label1;

		private Label label11;

		private Label label10;

		private Label label9;

		private Label label8;

		private Label label7;

		private Label label6;

		private Label label5;

		private Label label4;

		private Label label3;

		private Label label2;

		private Label label19;

		private Label label18;

		private Label label17;

		private Label label16;

		private Label label15;

		private Label label14;

		private Label label13;

		private Label label12;

		private Label label25;

		private TextBox textBox13;

		private TextBox textBox12;

		private TextBox textBox11;

		private TextBox textBox10;

		private TextBox textBox9;

		private TextBox textBox8;

		private TextBox textBox7;

		private TextBox textBox6;

		private TextBox textBox5;

		private TextBox textBox4;

		private TextBox textBox3;

		private TextBox textBox2;

		private TextBox textBox1;

		private TextBox textBox14;

		private TextBox textBox21;

		private TextBox textBox22;

		private TextBox textBox23;

		private TextBox textBox24;

		private TextBox textBox25;

		private TextBox textBox26;

		private Label label27;

		private Label label28;

		private Button button1;

		private ToolStripMenuItem 功能ToolStripMenuItem;

		private ToolStripMenuItem 物品入库ToolStripMenuItem;

		private TextBox textBox15;

		private RadioButton radioButton1;

		private RadioButton radioButton2;

		private Button button2;

		private GroupBox groupBox3;

		private Label label20;

		private ComboBox comboBox1;

		private TextBox textBox16;

		private Label label22;

		private Label label21;

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
			menuStrip1 = new System.Windows.Forms.MenuStrip();
			文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			打开YBIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			保存YBIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			功能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			物品入库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			listBox1 = new System.Windows.Forms.ListBox();
			groupBox1 = new System.Windows.Forms.GroupBox();
			groupBox2 = new System.Windows.Forms.GroupBox();
			label20 = new System.Windows.Forms.Label();
			button1 = new System.Windows.Forms.Button();
			textBox14 = new System.Windows.Forms.TextBox();
			textBox21 = new System.Windows.Forms.TextBox();
			textBox22 = new System.Windows.Forms.TextBox();
			textBox23 = new System.Windows.Forms.TextBox();
			textBox24 = new System.Windows.Forms.TextBox();
			textBox25 = new System.Windows.Forms.TextBox();
			textBox26 = new System.Windows.Forms.TextBox();
			textBox13 = new System.Windows.Forms.TextBox();
			textBox12 = new System.Windows.Forms.TextBox();
			textBox11 = new System.Windows.Forms.TextBox();
			textBox10 = new System.Windows.Forms.TextBox();
			textBox9 = new System.Windows.Forms.TextBox();
			textBox8 = new System.Windows.Forms.TextBox();
			textBox7 = new System.Windows.Forms.TextBox();
			textBox6 = new System.Windows.Forms.TextBox();
			textBox5 = new System.Windows.Forms.TextBox();
			textBox4 = new System.Windows.Forms.TextBox();
			textBox3 = new System.Windows.Forms.TextBox();
			textBox2 = new System.Windows.Forms.TextBox();
			textBox1 = new System.Windows.Forms.TextBox();
			label25 = new System.Windows.Forms.Label();
			label19 = new System.Windows.Forms.Label();
			label18 = new System.Windows.Forms.Label();
			label17 = new System.Windows.Forms.Label();
			label16 = new System.Windows.Forms.Label();
			label15 = new System.Windows.Forms.Label();
			label14 = new System.Windows.Forms.Label();
			label13 = new System.Windows.Forms.Label();
			label12 = new System.Windows.Forms.Label();
			label11 = new System.Windows.Forms.Label();
			label10 = new System.Windows.Forms.Label();
			label9 = new System.Windows.Forms.Label();
			label8 = new System.Windows.Forms.Label();
			label7 = new System.Windows.Forms.Label();
			label6 = new System.Windows.Forms.Label();
			label5 = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			label1 = new System.Windows.Forms.Label();
			label27 = new System.Windows.Forms.Label();
			label28 = new System.Windows.Forms.Label();
			textBox15 = new System.Windows.Forms.TextBox();
			radioButton1 = new System.Windows.Forms.RadioButton();
			radioButton2 = new System.Windows.Forms.RadioButton();
			button2 = new System.Windows.Forms.Button();
			groupBox3 = new System.Windows.Forms.GroupBox();
			comboBox1 = new System.Windows.Forms.ComboBox();
			label21 = new System.Windows.Forms.Label();
			label22 = new System.Windows.Forms.Label();
			textBox16 = new System.Windows.Forms.TextBox();
			menuStrip1.SuspendLayout();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			groupBox3.SuspendLayout();
			SuspendLayout();
			menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[2]
			{
				文件ToolStripMenuItem,
				功能ToolStripMenuItem
			});
			menuStrip1.Location = new System.Drawing.Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new System.Drawing.Size(1065, 28);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2]
			{
				打开YBIToolStripMenuItem,
				保存YBIToolStripMenuItem
			});
			文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
			文件ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
			文件ToolStripMenuItem.Text = "文件";
			打开YBIToolStripMenuItem.Name = "打开YBIToolStripMenuItem";
			打开YBIToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
			打开YBIToolStripMenuItem.Text = "打开YBi.cfg";
			打开YBIToolStripMenuItem.Click += new System.EventHandler(打开YBIToolStripMenuItem_Click);
			保存YBIToolStripMenuItem.Name = "保存YBIToolStripMenuItem";
			保存YBIToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
			保存YBIToolStripMenuItem.Text = "保存YBi.cfg";
			保存YBIToolStripMenuItem.Click += new System.EventHandler(保存YBIToolStripMenuItem_Click);
			功能ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[1]
			{
				物品入库ToolStripMenuItem
			});
			功能ToolStripMenuItem.Name = "功能ToolStripMenuItem";
			功能ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
			功能ToolStripMenuItem.Text = "功能";
			物品入库ToolStripMenuItem.Name = "物品入库ToolStripMenuItem";
			物品入库ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			物品入库ToolStripMenuItem.Text = "物品入库";
			物品入库ToolStripMenuItem.Click += new System.EventHandler(物品入库ToolStripMenuItem_Click);
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 15;
			listBox1.Location = new System.Drawing.Point(23, 32);
			listBox1.Margin = new System.Windows.Forms.Padding(4);
			listBox1.Name = "listBox1";
			listBox1.Size = new System.Drawing.Size(255, 439);
			listBox1.TabIndex = 1;
			listBox1.SelectedValueChanged += new System.EventHandler(listBox1_SelectedValueChanged);
			groupBox1.Controls.Add(listBox1);
			groupBox1.Location = new System.Drawing.Point(16, 121);
			groupBox1.Margin = new System.Windows.Forms.Padding(4);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new System.Windows.Forms.Padding(4);
			groupBox1.Size = new System.Drawing.Size(300, 499);
			groupBox1.TabIndex = 2;
			groupBox1.TabStop = false;
			groupBox1.Text = "物品列表";
			groupBox2.Controls.Add(textBox16);
			groupBox2.Controls.Add(label22);
			groupBox2.Controls.Add(label20);
			groupBox2.Controls.Add(button1);
			groupBox2.Controls.Add(textBox14);
			groupBox2.Controls.Add(textBox21);
			groupBox2.Controls.Add(textBox22);
			groupBox2.Controls.Add(textBox23);
			groupBox2.Controls.Add(textBox24);
			groupBox2.Controls.Add(textBox25);
			groupBox2.Controls.Add(textBox26);
			groupBox2.Controls.Add(textBox13);
			groupBox2.Controls.Add(textBox12);
			groupBox2.Controls.Add(textBox11);
			groupBox2.Controls.Add(textBox10);
			groupBox2.Controls.Add(textBox9);
			groupBox2.Controls.Add(textBox8);
			groupBox2.Controls.Add(textBox7);
			groupBox2.Controls.Add(textBox6);
			groupBox2.Controls.Add(textBox5);
			groupBox2.Controls.Add(textBox4);
			groupBox2.Controls.Add(textBox3);
			groupBox2.Controls.Add(textBox2);
			groupBox2.Controls.Add(textBox1);
			groupBox2.Controls.Add(label25);
			groupBox2.Controls.Add(label19);
			groupBox2.Controls.Add(label18);
			groupBox2.Controls.Add(label17);
			groupBox2.Controls.Add(label16);
			groupBox2.Controls.Add(label15);
			groupBox2.Controls.Add(label14);
			groupBox2.Controls.Add(label13);
			groupBox2.Controls.Add(label12);
			groupBox2.Controls.Add(label11);
			groupBox2.Controls.Add(label10);
			groupBox2.Controls.Add(label9);
			groupBox2.Controls.Add(label8);
			groupBox2.Controls.Add(label7);
			groupBox2.Controls.Add(label6);
			groupBox2.Controls.Add(label5);
			groupBox2.Controls.Add(label4);
			groupBox2.Controls.Add(label3);
			groupBox2.Controls.Add(label2);
			groupBox2.Controls.Add(label1);
			groupBox2.Location = new System.Drawing.Point(353, 121);
			groupBox2.Margin = new System.Windows.Forms.Padding(4);
			groupBox2.Name = "groupBox2";
			groupBox2.Padding = new System.Windows.Forms.Padding(4);
			groupBox2.Size = new System.Drawing.Size(691, 499);
			groupBox2.TabIndex = 3;
			groupBox2.TabStop = false;
			groupBox2.Text = "物品属性";
			label20.AutoSize = true;
			label20.Location = new System.Drawing.Point(365, 336);
			label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label20.Name = "label20";
			label20.Size = new System.Drawing.Size(99, 15);
			label20.TabIndex = 53;
			label20.Text = "注:120字以内";
			button1.Location = new System.Drawing.Point(556, 460);
			button1.Margin = new System.Windows.Forms.Padding(4);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(100, 29);
			button1.TabIndex = 52;
			button1.Text = "修改";
			button1.UseVisualStyleBackColor = true;
			button1.Click += new System.EventHandler(button1_Click);
			textBox14.Location = new System.Drawing.Point(475, 360);
			textBox14.Margin = new System.Windows.Forms.Padding(4);
			textBox14.Multiline = true;
			textBox14.Name = "textBox14";
			textBox14.Size = new System.Drawing.Size(180, 88);
			textBox14.TabIndex = 51;
			textBox14.TextChanged += new System.EventHandler(textBox14_TextChanged);
			textBox21.Location = new System.Drawing.Point(475, 204);
			textBox21.Margin = new System.Windows.Forms.Padding(4);
			textBox21.Name = "textBox21";
			textBox21.Size = new System.Drawing.Size(180, 25);
			textBox21.TabIndex = 44;
			textBox22.Location = new System.Drawing.Point(475, 169);
			textBox22.Margin = new System.Windows.Forms.Padding(4);
			textBox22.Name = "textBox22";
			textBox22.Size = new System.Drawing.Size(180, 25);
			textBox22.TabIndex = 43;
			textBox23.Location = new System.Drawing.Point(475, 134);
			textBox23.Margin = new System.Windows.Forms.Padding(4);
			textBox23.Name = "textBox23";
			textBox23.Size = new System.Drawing.Size(180, 25);
			textBox23.TabIndex = 42;
			textBox24.Location = new System.Drawing.Point(475, 99);
			textBox24.Margin = new System.Windows.Forms.Padding(4);
			textBox24.Name = "textBox24";
			textBox24.Size = new System.Drawing.Size(180, 25);
			textBox24.TabIndex = 41;
			textBox25.Location = new System.Drawing.Point(475, 64);
			textBox25.Margin = new System.Windows.Forms.Padding(4);
			textBox25.Name = "textBox25";
			textBox25.Size = new System.Drawing.Size(180, 25);
			textBox25.TabIndex = 40;
			textBox26.Location = new System.Drawing.Point(475, 29);
			textBox26.Margin = new System.Windows.Forms.Padding(4);
			textBox26.Name = "textBox26";
			textBox26.Size = new System.Drawing.Size(180, 25);
			textBox26.TabIndex = 39;
			textBox13.Location = new System.Drawing.Point(144, 438);
			textBox13.Margin = new System.Windows.Forms.Padding(4);
			textBox13.Name = "textBox13";
			textBox13.Size = new System.Drawing.Size(180, 25);
			textBox13.TabIndex = 38;
			textBox12.Location = new System.Drawing.Point(144, 404);
			textBox12.Margin = new System.Windows.Forms.Padding(4);
			textBox12.Name = "textBox12";
			textBox12.Size = new System.Drawing.Size(180, 25);
			textBox12.TabIndex = 37;
			textBox11.Location = new System.Drawing.Point(144, 370);
			textBox11.Margin = new System.Windows.Forms.Padding(4);
			textBox11.Name = "textBox11";
			textBox11.Size = new System.Drawing.Size(180, 25);
			textBox11.TabIndex = 36;
			textBox10.Location = new System.Drawing.Point(144, 336);
			textBox10.Margin = new System.Windows.Forms.Padding(4);
			textBox10.Name = "textBox10";
			textBox10.Size = new System.Drawing.Size(180, 25);
			textBox10.TabIndex = 35;
			textBox9.Location = new System.Drawing.Point(144, 302);
			textBox9.Margin = new System.Windows.Forms.Padding(4);
			textBox9.Name = "textBox9";
			textBox9.Size = new System.Drawing.Size(180, 25);
			textBox9.TabIndex = 34;
			textBox8.Location = new System.Drawing.Point(144, 269);
			textBox8.Margin = new System.Windows.Forms.Padding(4);
			textBox8.Name = "textBox8";
			textBox8.Size = new System.Drawing.Size(180, 25);
			textBox8.TabIndex = 33;
			textBox7.Location = new System.Drawing.Point(144, 235);
			textBox7.Margin = new System.Windows.Forms.Padding(4);
			textBox7.Name = "textBox7";
			textBox7.Size = new System.Drawing.Size(180, 25);
			textBox7.TabIndex = 32;
			textBox6.Location = new System.Drawing.Point(144, 201);
			textBox6.Margin = new System.Windows.Forms.Padding(4);
			textBox6.Name = "textBox6";
			textBox6.Size = new System.Drawing.Size(180, 25);
			textBox6.TabIndex = 31;
			textBox5.Location = new System.Drawing.Point(144, 168);
			textBox5.Margin = new System.Windows.Forms.Padding(4);
			textBox5.Name = "textBox5";
			textBox5.Size = new System.Drawing.Size(180, 25);
			textBox5.TabIndex = 30;
			textBox4.Location = new System.Drawing.Point(144, 134);
			textBox4.Margin = new System.Windows.Forms.Padding(4);
			textBox4.Name = "textBox4";
			textBox4.Size = new System.Drawing.Size(180, 25);
			textBox4.TabIndex = 29;
			textBox3.Location = new System.Drawing.Point(144, 100);
			textBox3.Margin = new System.Windows.Forms.Padding(4);
			textBox3.Name = "textBox3";
			textBox3.Size = new System.Drawing.Size(180, 25);
			textBox3.TabIndex = 28;
			textBox2.Location = new System.Drawing.Point(144, 66);
			textBox2.Margin = new System.Windows.Forms.Padding(4);
			textBox2.Name = "textBox2";
			textBox2.Size = new System.Drawing.Size(180, 25);
			textBox2.TabIndex = 27;
			textBox1.Enabled = false;
			textBox1.Location = new System.Drawing.Point(144, 32);
			textBox1.Margin = new System.Windows.Forms.Padding(4);
			textBox1.Name = "textBox1";
			textBox1.Size = new System.Drawing.Size(180, 25);
			textBox1.TabIndex = 26;
			label25.AutoSize = true;
			label25.Location = new System.Drawing.Point(376, 370);
			label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label25.Name = "label25";
			label25.Size = new System.Drawing.Size(71, 15);
			label25.TabIndex = 24;
			label25.Text = "FLD_DES:";
			label19.AutoSize = true;
			label19.Location = new System.Drawing.Point(365, 201);
			label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label19.Name = "label19";
			label19.Size = new System.Drawing.Size(79, 15);
			label19.TabIndex = 18;
			label19.Text = "FLD_TYPE:";
			label18.AutoSize = true;
			label18.Location = new System.Drawing.Point(16, 70);
			label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label18.Name = "label18";
			label18.Size = new System.Drawing.Size(119, 15);
			label18.TabIndex = 17;
			label18.Text = "FLD_QUESTITEM:";
			label17.AutoSize = true;
			label17.Location = new System.Drawing.Point(365, 66);
			label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label17.Name = "label17";
			label17.Size = new System.Drawing.Size(79, 15);
			label17.TabIndex = 16;
			label17.Text = "FLD_WXJD:";
			label16.AutoSize = true;
			label16.Location = new System.Drawing.Point(365, 32);
			label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label16.Name = "label16";
			label16.Size = new System.Drawing.Size(63, 15);
			label16.TabIndex = 15;
			label16.Text = "FLD_WX:";
			label15.AutoSize = true;
			label15.Location = new System.Drawing.Point(365, 100);
			label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label15.Name = "label15";
			label15.Size = new System.Drawing.Size(63, 15);
			label15.TabIndex = 14;
			label15.Text = "FLD_EL:";
			label14.AutoSize = true;
			label14.Location = new System.Drawing.Point(365, 134);
			label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label14.Name = "label14";
			label14.Size = new System.Drawing.Size(87, 15);
			label14.TabIndex = 13;
			label14.Text = "FLD_MONEY:";
			label13.AutoSize = true;
			label13.Location = new System.Drawing.Point(16, 138);
			label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label13.Name = "label13";
			label13.Size = new System.Drawing.Size(63, 15);
			label13.TabIndex = 12;
			label13.Text = "FLD_NJ:";
			label12.AutoSize = true;
			label12.Location = new System.Drawing.Point(16, 272);
			label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label12.Name = "label12";
			label12.Size = new System.Drawing.Size(63, 15);
			label12.TabIndex = 11;
			label12.Text = "FLD_DF:";
			label11.AutoSize = true;
			label11.Location = new System.Drawing.Point(16, 340);
			label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label11.Name = "label11";
			label11.Size = new System.Drawing.Size(71, 15);
			label11.TabIndex = 10;
			label11.Text = "FLD_AT2:";
			label10.AutoSize = true;
			label10.Location = new System.Drawing.Point(16, 306);
			label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label10.Name = "label10";
			label10.Size = new System.Drawing.Size(71, 15);
			label10.TabIndex = 9;
			label10.Text = "FLD_AT1:";
			label9.AutoSize = true;
			label9.Location = new System.Drawing.Point(365, 168);
			label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label9.Name = "label9";
			label9.Size = new System.Drawing.Size(95, 15);
			label9.TabIndex = 8;
			label9.Text = "FLD_WEIGHT:";
			label8.AutoSize = true;
			label8.Location = new System.Drawing.Point(16, 205);
			label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label8.Name = "label8";
			label8.Size = new System.Drawing.Size(103, 15);
			label8.TabIndex = 7;
			label8.Text = "FLD_RESIDE2:";
			label7.AutoSize = true;
			label7.Location = new System.Drawing.Point(16, 239);
			label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(71, 15);
			label7.TabIndex = 6;
			label7.Text = "FLD_SEX:";
			label6.AutoSize = true;
			label6.Location = new System.Drawing.Point(16, 408);
			label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(119, 15);
			label6.TabIndex = 5;
			label6.Text = "FLD_JOB_LEVEL:";
			label5.AutoSize = true;
			label5.Location = new System.Drawing.Point(16, 374);
			label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(87, 15);
			label5.TabIndex = 4;
			label5.Text = "FLD_LEVEL:";
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(16, 171);
			label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(103, 15);
			label4.TabIndex = 3;
			label4.Text = "FLD_RESIDE1:";
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(16, 441);
			label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(63, 15);
			label3.TabIndex = 2;
			label3.Text = "FLD_ZX:";
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(16, 104);
			label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(79, 15);
			label2.TabIndex = 1;
			label2.Text = "FLD_NAME:";
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(16, 36);
			label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(71, 15);
			label1.TabIndex = 0;
			label1.Text = "FLD_PID:";
			label27.AutoSize = true;
			label27.Location = new System.Drawing.Point(36, 628);
			label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label27.Name = "label27";
			label27.Size = new System.Drawing.Size(75, 15);
			label27.TabIndex = 4;
			label27.Text = "物品总数:";
			label28.AutoSize = true;
			label28.Location = new System.Drawing.Point(123, 628);
			label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label28.Name = "label28";
			label28.Size = new System.Drawing.Size(63, 15);
			label28.TabIndex = 5;
			label28.Text = "label28";
			textBox15.Location = new System.Drawing.Point(356, 21);
			textBox15.Margin = new System.Windows.Forms.Padding(4);
			textBox15.Name = "textBox15";
			textBox15.Size = new System.Drawing.Size(175, 25);
			textBox15.TabIndex = 6;
			radioButton1.AutoSize = true;
			radioButton1.Location = new System.Drawing.Point(560, 22);
			radioButton1.Margin = new System.Windows.Forms.Padding(4);
			radioButton1.Name = "radioButton1";
			radioButton1.Size = new System.Drawing.Size(52, 19);
			radioButton1.TabIndex = 7;
			radioButton1.TabStop = true;
			radioButton1.Text = "PID";
			radioButton1.UseVisualStyleBackColor = true;
			radioButton2.AutoSize = true;
			radioButton2.Location = new System.Drawing.Point(623, 22);
			radioButton2.Margin = new System.Windows.Forms.Padding(4);
			radioButton2.Name = "radioButton2";
			radioButton2.Size = new System.Drawing.Size(73, 19);
			radioButton2.TabIndex = 8;
			radioButton2.TabStop = true;
			radioButton2.Text = "物品名";
			radioButton2.UseVisualStyleBackColor = true;
			button2.Location = new System.Drawing.Point(716, 19);
			button2.Margin = new System.Windows.Forms.Padding(4);
			button2.Name = "button2";
			button2.Size = new System.Drawing.Size(89, 29);
			button2.TabIndex = 9;
			button2.Text = "确定";
			button2.UseVisualStyleBackColor = true;
			button2.Click += new System.EventHandler(button2_Click);
			groupBox3.Controls.Add(comboBox1);
			groupBox3.Controls.Add(label21);
			groupBox3.Controls.Add(button2);
			groupBox3.Controls.Add(textBox15);
			groupBox3.Controls.Add(radioButton2);
			groupBox3.Controls.Add(radioButton1);
			groupBox3.Location = new System.Drawing.Point(16, 42);
			groupBox3.Margin = new System.Windows.Forms.Padding(4);
			groupBox3.Name = "groupBox3";
			groupBox3.Padding = new System.Windows.Forms.Padding(4);
			groupBox3.Size = new System.Drawing.Size(1028, 60);
			groupBox3.TabIndex = 10;
			groupBox3.TabStop = false;
			groupBox3.Text = "查找";
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[17]
			{
				"全部",
				"衣服",
				"护手",
				"武器",
				"靴子",
				"内甲",
				"项链",
				"耳环",
				"戒指",
				"披风",
				"灵兽",
				"石头",
				"盒子",
				"符文",
				"任务物品",
				"百宝",
				"其他"
			});
			comboBox1.Location = new System.Drawing.Point(117, 19);
			comboBox1.Margin = new System.Windows.Forms.Padding(4);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new System.Drawing.Size(160, 23);
			comboBox1.TabIndex = 11;
			comboBox1.SelectedValueChanged += new System.EventHandler(comboBox1_SelectedValueChanged);
			label21.AutoSize = true;
			label21.Location = new System.Drawing.Point(20, 25);
			label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label21.Name = "label21";
			label21.Size = new System.Drawing.Size(75, 15);
			label21.TabIndex = 10;
			label21.Text = "物品类型:";
			label22.AutoSize = true;
			label22.Location = new System.Drawing.Point(365, 245);
			label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label22.Name = "label22";
			label22.Size = new System.Drawing.Size(60, 15);
			label22.TabIndex = 54;
			label22.Text = "持久力:";
			textBox16.Location = new System.Drawing.Point(475, 242);
			textBox16.Margin = new System.Windows.Forms.Padding(4);
			textBox16.Name = "textBox16";
			textBox16.Size = new System.Drawing.Size(180, 25);
			textBox16.TabIndex = 55;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 15f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(1065, 654);
			base.Controls.Add(groupBox3);
			base.Controls.Add(label28);
			base.Controls.Add(label27);
			base.Controls.Add(groupBox2);
			base.Controls.Add(groupBox1);
			base.Controls.Add(menuStrip1);
			base.MainMenuStrip = menuStrip1;
			base.Margin = new System.Windows.Forms.Padding(4);
			base.Name = "YbiForm";
			Text = "YBI编辑器";
			base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(YbiForm_FormClosing);
			base.Load += new System.EventHandler(YbiForm_Load);
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		public YbiForm()
		{
			InitializeComponent();
			int num = 0;
			do
			{
				byte_1A24628[num] = (byte)(((num >> 4) & 1) | ((num >> 2) & 0x18) | ((num >> 1) & 0x40) | (2 * ((num & 3) | (4 * ((num & 4) | (2 * (num & 0xF8)))))));
				num++;
			}
			while (num < 256);
		}

		private void 打开YBIToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "cfg   files   (*.cfg)|*.cfg|All   files   (*.*)|*.*";
			openFileDialog.FilterIndex = 1;
			openFileDialog.RestoreDirectory = true;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				Stream stream;
				if ((stream = openFileDialog.OpenFile()) != null)
				{
					BinaryReader binaryReader = new BinaryReader(stream);
					using (FileStream fileStream = new FileStream("YBi.cfg.bak", FileMode.Create, FileAccess.Write, FileShare.Read))
					{
						int value = binaryReader.ReadInt32();
						int value2 = binaryReader.ReadInt32();
						fileStream.Write(BitConverter.GetBytes(value), 0, 4);
						fileStream.Write(BitConverter.GetBytes(value2), 0, 4);
						byte[] array = new byte[4];
						while (binaryReader.Read(array, 0, 4) > 0)
						{
							fileStream.Write(BitConverter.GetBytes(YbiDecrypt(BitConverter.ToUInt32(array, 0), 0)), 0, 4);
						}
					}
					stream.Close();
				}
				读物品全();
			}
		}

		private void 读物品全()
		{
			using (FileStream input = new FileStream("YBi.cfg.bak", FileMode.Open, FileAccess.Read, FileShare.Read))
			{
				BinaryReader binaryReader = new BinaryReader(input);
				binaryReader.ReadInt32();
				binaryReader.ReadInt32();
				读取数据(binaryReader, 852, 10000, ref 物品);
				读取数据(binaryReader, 64, 1, ref KEY);
				读取数据(binaryReader, 6736, 1024, ref 武功);
				读取数据(binaryReader, 1388, 1024, ref 气功);
				读取数据(binaryReader, 72, 128, ref 称号);
				读取数据(binaryReader, 64, 2048, ref 屏蔽1);
				读取数据(binaryReader, 128, 2048, ref 屏蔽2);
				读取数据(binaryReader, 7860, 2048, ref NPC);
				读取数据(binaryReader, 16, 6, ref 未知1);
				读取数据(binaryReader, 100, 1024, ref 地图名);
				读取数据(binaryReader, 96, 1024, ref 未知2);
			}
			显示物品名();
		}

		private void 显示物品名()
		{
			ybidate.Clear();
			for (int i = 0; i < 10000; i++)
			{
				int num = 0;
				int fLD_TYPE = 0;
				YbiClass ybiClass = new YbiClass();
				byte[] array = new byte[852];
				Buffer.BlockCopy(物品, i * array.Length, array, 0, array.Length);
				if (BitConverter.ToInt32(array, 0) == 0)
				{
					break;
				}
				string text = Encoding.Default.GetString(array, 8, 64).Replace("\0", string.Empty).Replace('\'', ' ');
				if (text.Length == 0)
				{
					text = "未知物品(待命名)";
				}
				string text2 = Encoding.Default.GetString(array, 156, 256).Replace("\0", string.Empty).Replace('\'', ' ');
				if (text2.Length == 0 || text2 == " ")
				{
					text2 = text;
				}
				int num2 = array[80];
				listBox1.Items.Add(text);
				int num3 = BitConverter.ToInt32(array, 0);
				int num4 = BitConverter.ToInt16(array, 96);
				ybiClass.FLD_PID = num3;
				ybiClass.FLD_Name = text;
				ybiClass.FLD_说明 = text2;
				ybiClass.FLD_ZX = array[73];
				ybiClass.FLD_RESIDE1 = array[74];
				ybiClass.FLD_LEVEL = BitConverter.ToInt16(array, 76);
				ybiClass.FLD_JOB_LEVEL = array[78];
				ybiClass.FLD_SEX = array[79];
				ybiClass.FLD_WEIGHT = BitConverter.ToInt16(array, 82);
				ybiClass.FLD_AT1 = BitConverter.ToInt16(array, 84);
				ybiClass.FLD_AT2 = BitConverter.ToInt16(array, 86);
				ybiClass.FLD_DF = BitConverter.ToInt16(array, 88);
				ybiClass.FLD_NJ = num4;
				ybiClass.FLD_MONEY = BitConverter.ToInt32(array, 100);
				ybiClass.FLD_EL = BitConverter.ToInt16(array, 113);
				ybiClass.FLD_MM1 = BitConverter.ToInt32(array, 108);
				ybiClass.FLD_MM2 = BitConverter.ToInt32(array, 100);
				switch (ybiClass.FLD_RESIDE1)
				{
				case 11:
					ybiClass.FLD_RESIDE1 = 6;
					break;
				case 12:
					ybiClass.FLD_RESIDE1 = 7;
					break;
				case 13:
					ybiClass.FLD_RESIDE1 = 8;
					break;
				case 14:
					ybiClass.FLD_RESIDE1 = 9;
					break;
				case 15:
					ybiClass.FLD_RESIDE1 = 10;
					break;
				case 16:
					ybiClass.FLD_RESIDE1 = 10;
					break;
				case 17:
					ybiClass.FLD_RESIDE1 = 11;
					break;
				case 18:
					ybiClass.FLD_RESIDE1 = 12;
					break;
				case 19:
					ybiClass.FLD_RESIDE1 = 13;
					break;
				}
				switch (num2)
				{
				case 1:
					ybiClass.FLD_RESIDE2 = 1;
					break;
				case 2:
					ybiClass.FLD_RESIDE2 = 2;
					break;
				case 3:
					ybiClass.FLD_RESIDE2 = 4;
					break;
				case 4:
					ybiClass.FLD_RESIDE2 = 5;
					break;
				case 5:
					ybiClass.FLD_RESIDE2 = 6;
					break;
				case 6:
					ybiClass.FLD_RESIDE2 = 7;
					break;
				case 7:
					ybiClass.FLD_RESIDE2 = 8;
					break;
				case 8:
					ybiClass.FLD_RESIDE2 = 10;
					break;
				case 9:
					ybiClass.FLD_RESIDE2 = 12;
					break;
				case 10:
					ybiClass.FLD_RESIDE2 = 16;
					break;
				case 11:
					ybiClass.FLD_RESIDE2 = 18;
					break;
				case 12:
					ybiClass.FLD_RESIDE2 = 16;
					break;
				case 19:
					ybiClass.FLD_RESIDE2 = 19;
					break;
				case 21:
					ybiClass.FLD_RESIDE2 = 14;
					break;
				case 22:
					ybiClass.FLD_RESIDE2 = 15;
					break;
				}
				ybiClass.FLD_WX = BitConverter.ToInt32(array, 412);
				ybiClass.FLD_WXJD = BitConverter.ToInt32(array, 416);
				if (num3 > 900000001 && num3 < 1000000000)
				{
					num = 1;
				}
				ybiClass.FLD_QUESTITEM = num;
				if (num3.ToString().Contains("1008000") || num3.ToString().Contains("16900") || num3.ToString().Contains("26900") || num3.ToString().Contains("1007000"))
				{
					fLD_TYPE = 1;
				}
				ybiClass.FLD_TYPE = fLD_TYPE;
				ybiClass.FLD_QGSLL = BitConverter.ToInt32(array, 412);
				if (num4 != 0)
				{
					string str = "2000000";
					switch (num4.ToString().Length)
					{
					case 1:
						str = "200000000";
						break;
					case 2:
						str = "20000000";
						break;
					case 4:
						str = "200000";
						break;
					}
					int.Parse(str + num4);
				}
				if (ybiClass.FLD_Name.Contains("升天一式 ") || ybiClass.FLD_Name.Contains("升天二式 ") || ybiClass.FLD_Name.Contains("升天三式 ") || ybiClass.FLD_Name.Contains("升天四式 "))
				{
					ybiClass.FLD_RESIDE2 = 19;
				}
				if (ybiClass.FLD_Name.Contains("气功"))
				{
					ybiClass.FLD_RESIDE2 = 19;
					ybiClass.FLD_MAGIC1 = 0;
					ybiClass.FLD_WXJD = 0;
				}
				if (ybiClass.FLD_Name.Contains("灵宠 "))
				{
					ybiClass.FLD_RESIDE2 = 16;
				}
				if (ybiClass.FLD_Name.Contains("灵宠月兔") || ybiClass.FLD_Name.Contains(" 灵宠龙猫"))
				{
					ybiClass.FLD_RESIDE2 = 16;
				}
				if (ybiClass.FLD_Name.Contains("灵宠小白熊") || ybiClass.FLD_Name.Contains("灵宠龙猫") || ybiClass.FLD_Name.Contains("灵宠小白熊"))
				{
					ybiClass.FLD_RESIDE2 = 16;
				}
				if (ybiClass.FLD_Name.Contains("箱"))
				{
					ybiClass.FLD_RESIDE2 = 17;
				}
				if (ybiClass.FLD_Name.Contains("真-"))
				{
					ybiClass.FLD_TZ = 1;
				}
				if (ybiClass.FLD_Name.Contains("天元") || ybiClass.FLD_Name.Contains("轩舞") || ybiClass.FLD_Name.Contains("浩天"))
				{
					ybiClass.FLD_TZ = 1;
				}
				if (ybiClass.FLD_Name.Contains("邪元") || ybiClass.FLD_Name.Contains("赤夜") || ybiClass.FLD_Name.Contains("魔渊"))
				{
					ybiClass.FLD_TZ = 1;
				}
				if (ybiClass.FLD_Name.Contains("真武圣"))
				{
					ybiClass.FLD_TZ = 1;
				}
				if (ybiClass.FLD_Name.Contains("月光圣"))
				{
					ybiClass.FLD_TZ = 1;
				}
				if (ybiClass.FLD_Name.Contains("真武血"))
				{
					ybiClass.FLD_TZ = 1;
				}
				if (ybiClass.FLD_Name.Contains("月光血"))
				{
					ybiClass.FLD_TZ = 1;
				}
				if (ybiClass.FLD_Name.Contains("未完成"))
				{
					ybiClass.FLD_TZ = 1;
				}
				if (ybiClass.FLD_Name.Contains("神龙"))
				{
					ybiClass.FLD_TZ = 1;
					ybiClass.FLD_NJ = 1000;
				}
				if (ybiClass.FLD_Name.Contains("飞流"))
				{
					ybiClass.FLD_TZ = 1;
					ybiClass.FLD_NJ = 1000;
				}
				if (ybiClass.FLD_Name.Contains("强化石") || ybiClass.FLD_Name.Contains("高级强化石"))
				{
					ybiClass.FLD_SIDE = 1;
				}
				if (ybiClass.FLD_Name.Contains("纹龙") || ybiClass.FLD_Name.Contains("绣龙") || ybiClass.FLD_Name.Contains("金龙"))
				{
					ybiClass.FLD_NJ = 1000;
				}
				if (ybiClass.FLD_Name == "玄武" || ybiClass.FLD_Name == "北天玄武刀" || ybiClass.FLD_Name.Contains("玄武龙啸"))
				{
					ybiClass.FLD_NJ = 1000;
				}
				if (ybiClass.FLD_Name == "青龙" || ybiClass.FLD_Name == "青天青龙剑" || ybiClass.FLD_Name.Contains("青龙缠天"))
				{
					ybiClass.FLD_NJ = 1000;
				}
				if (ybiClass.FLD_Name == "朱雀" || ybiClass.FLD_Name == "南天朱雀弓" || ybiClass.FLD_Name.Contains("朱雀覆火"))
				{
					ybiClass.FLD_NJ = 1000;
				}
				if (ybiClass.FLD_Name == "麒麟" || ybiClass.FLD_Name == "中天麒麟枪" || ybiClass.FLD_Name.Contains("麒麟踏宇"))
				{
					ybiClass.FLD_NJ = 1000;
				}
				if (ybiClass.FLD_Name == "白虎" || ybiClass.FLD_Name == "西天白虎扇" || ybiClass.FLD_Name.Contains("虎扇吞日"))
				{
					ybiClass.FLD_NJ = 1000;
				}
				if (ybiClass.FLD_Name == "鬼牙" || ybiClass.FLD_Name == "玄天鬼牙刃" || ybiClass.FLD_Name.Contains("天兆鬼牙"))
				{
					ybiClass.FLD_NJ = 1000;
				}
				if (ybiClass.FLD_Name == "鳳凰" || ybiClass.FLD_Name == "齐天凤凰琴" || ybiClass.FLD_Name.Contains("凤凰栾鸣"))
				{
					ybiClass.FLD_NJ = 1000;
				}
				ybiClass.FLD_MAGIC1 = 0;
				ybiClass.FLD_SIDE = ((num == 1) ? 1 : 0);
				ybiClass.FLD_MAGIC2 = 0;
				ybiClass.FLD_MAGIC3 = 0;
				ybiClass.FLD_MAGIC4 = 0;
				ybiClass.FLD_MAGIC5 = 0;
				ybiClass.FLD_byte = array;
				if (!ybidate.ContainsKey(num3))
				{
					ybidate.Add(num3, ybiClass);
				}
			}
			label28.Text = listBox1.Items.Count.ToString();
		}

		private void 保存YBIToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (listBox1.Items.Count == 0)
				{
					MessageBox.Show("请先打开Ybi.cfg文件!", "提示");
				}
				else
				{
					using (FileStream fileStream = new FileStream("YBi.cfg.bak", FileMode.Open, FileAccess.Read, FileShare.Read))
					{
						using (FileStream fileStream2 = new FileStream("YBi.cfg1.bak", FileMode.Create, FileAccess.Write, FileShare.Read))
						{
							using (BinaryReader binaryReader = new BinaryReader(fileStream))
							{
								fileStream2.Write(BitConverter.GetBytes(binaryReader.ReadInt32()), 0, 4);
								fileStream2.Write(BitConverter.GetBytes(binaryReader.ReadInt32()), 0, 4);
								int num = 8;
								fileStream2.Seek(8L, SeekOrigin.Begin);
								foreach (YbiClass value in ybidate.Values)
								{
									byte[] fLD_byte = value.FLD_byte;
									byte[] bytes = Encoding.Default.GetBytes(value.FLD_Name + "\0");
									byte[] bytes2 = Encoding.Default.GetBytes(value.FLD_说明 + "\0");
									Buffer.BlockCopy(BitConverter.GetBytes(value.FLD_PID), 0, fLD_byte, 0, 4);
									Buffer.BlockCopy(BitConverter.GetBytes(value.FLD_JOB_LEVEL), 0, fLD_byte, 78, 1);
									Buffer.BlockCopy(BitConverter.GetBytes(value.FLD_ZX), 0, fLD_byte, 73, 1);
									Buffer.BlockCopy(BitConverter.GetBytes(value.FLD_RESIDE1), 0, fLD_byte, 74, 1);
									Buffer.BlockCopy(BitConverter.GetBytes(value.FLD_LEVEL), 0, fLD_byte, 76, 2);
									Buffer.BlockCopy(BitConverter.GetBytes(value.FLD_SEX), 0, fLD_byte, 79, 1);
									Buffer.BlockCopy(BitConverter.GetBytes(value.FLD_RESIDE2), 0, fLD_byte, 80, 2);
									Buffer.BlockCopy(BitConverter.GetBytes(value.FLD_WEIGHT), 0, fLD_byte, 82, 2);
									Buffer.BlockCopy(BitConverter.GetBytes(value.FLD_AT1), 0, fLD_byte, 84, 2);
									Buffer.BlockCopy(BitConverter.GetBytes(value.FLD_AT2), 0, fLD_byte, 86, 2);
									Buffer.BlockCopy(BitConverter.GetBytes(value.FLD_DF), 0, fLD_byte, 88, 2);
									Buffer.BlockCopy(BitConverter.GetBytes(value.FLD_NJ), 0, fLD_byte, 96, 2);
									Buffer.BlockCopy(BitConverter.GetBytes(value.FLD_MONEY), 0, fLD_byte, 100, 4);
									Buffer.BlockCopy(BitConverter.GetBytes(value.FLD_EL), 0, fLD_byte, 113, 2);
									Buffer.BlockCopy(BitConverter.GetBytes(value.FLD_WX), 0, fLD_byte, 372, 4);
									Buffer.BlockCopy(BitConverter.GetBytes(value.FLD_WXJD), 0, fLD_byte, 376, 4);
									Buffer.BlockCopy(bytes, 0, fLD_byte, 8, bytes.Length);
									Buffer.BlockCopy(bytes2, 0, fLD_byte, 156, bytes2.Length);
									fileStream2.Write(fLD_byte, 0, fLD_byte.Length);
									num += 852;
								}
								fileStream.Seek(num, SeekOrigin.Begin);
								byte[] array = new byte[4];
								while (binaryReader.Read(array, 0, 4) > 0)
								{
									fileStream2.Write(array, 0, array.Length);
								}
							}
						}
					}
					生成新的文件ybi();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "错误");
			}
		}

		private void 生成新的文件ybi()
		{
			try
			{
				using (FileStream input = new FileStream("YBi.cfg1.bak", FileMode.Open, FileAccess.Read, FileShare.Read))
				{
					using (FileStream fileStream = new FileStream("YBiNew.cfg", FileMode.Create, FileAccess.Write, FileShare.Read))
					{
						BinaryReader binaryReader = new BinaryReader(input);
						fileStream.Write(BitConverter.GetBytes(binaryReader.ReadInt32()), 0, 4);
						fileStream.Write(BitConverter.GetBytes(binaryReader.ReadInt32()), 0, 4);
						byte[] array = new byte[4];
						while (binaryReader.Read(array, 0, 4) > 0)
						{
							fileStream.Write(BitConverter.GetBytes(YbiDecrypt(BitConverter.ToUInt32(array, 0), 1)), 0, 4);
						}
					}
				}
				MessageBox.Show("完成,新的文件为'YBiNew.cfg'", "提示");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "错误");
			}
		}

		private YbiClass getitem(string name)
		{
			foreach (YbiClass value in ybidate.Values)
			{
				if (value.FLD_Name == name)
				{
					return value;
				}
			}
			return null;
		}

		private YbiClass getitem(int pid)
		{
			foreach (YbiClass value in ybidate.Values)
			{
				if (value.FLD_PID == pid)
				{
					return value;
				}
			}
			return null;
		}

		public static int YbiDecrypt(uint pValue, int inlen)
		{
			int num = 0;
			int num2 = 0;
			while (pValue != 0)
			{
				int num3 = (int)pValue & -2;
				int num4 = (int)(pValue - num3);
				pValue >>= 1;
				if (num4 > 0)
				{
					int num5 = (inlen != 0) ? key[num2 + 32] : key[num2];
					num += num4 << num5;
				}
				num2++;
			}
			return num;
		}

		public void 读取数据(BinaryReader tdbReader, int Size, int Count, ref byte[] 数据)
		{
			for (int i = 0; i < Count; i++)
			{
				byte[] array = new byte[Size];
				tdbReader.Read(array, 0, array.Length);
				Buffer.BlockCopy(array, 0, 数据, i * array.Length, array.Length);
			}
		}

		private void YbiForm_Load(object sender, EventArgs e)
		{
			label28.Text = "0";
			radioButton1.Checked = true;
			comboBox1.SelectedText = "全部";
		}

		private void listBox1_SelectedValueChanged(object sender, EventArgs e)
		{
			YbiClass ybiClass = getitem(listBox1.SelectedItem.ToString());
			if (ybiClass != null)
			{
				textBox1.Text = ybiClass.FLD_PID.ToString();
				textBox2.Text = ybiClass.FLD_QUESTITEM.ToString();
				textBox3.Text = ybiClass.FLD_Name;
				textBox4.Text = ybiClass.FLD_NJ.ToString();
				textBox5.Text = ybiClass.FLD_RESIDE1.ToString();
				textBox6.Text = ybiClass.FLD_RESIDE2.ToString();
				textBox7.Text = ybiClass.FLD_SEX.ToString();
				textBox8.Text = ybiClass.FLD_DF.ToString();
				textBox9.Text = ybiClass.FLD_AT1.ToString();
				textBox10.Text = ybiClass.FLD_AT2.ToString();
				textBox11.Text = ybiClass.FLD_LEVEL.ToString();
				textBox12.Text = ybiClass.FLD_JOB_LEVEL.ToString();
				textBox13.Text = ybiClass.FLD_ZX.ToString();
				textBox14.Text = ybiClass.FLD_说明;
				textBox21.Text = ybiClass.FLD_TYPE.ToString();
				textBox22.Text = ybiClass.FLD_WEIGHT.ToString();
				textBox23.Text = ybiClass.FLD_MONEY.ToString();
				textBox24.Text = ybiClass.FLD_EL.ToString();
				textBox25.Text = ybiClass.FLD_WXJD.ToString();
				textBox26.Text = ybiClass.FLD_WX.ToString();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (listBox1.Items.Count == 0)
			{
				MessageBox.Show("请先打开Ybi.cfg文件!", "提示");
				return;
			}
			if (textBox1.Text.Length == 0)
			{
				MessageBox.Show("请先选择要修改的物品!", "提示");
				return;
			}
			if (textBox14.Text.Length > 120)
			{
				MessageBox.Show("装备说明不能超过120个文字!");
				return;
			}
			if (textBox3.Text.Length > 15)
			{
				MessageBox.Show("装备名称不能超过15个文字!");
				return;
			}
			YbiClass ybiClass = getitem(int.Parse(textBox1.Text));
			if (ybiClass != null)
			{
				ybiClass.FLD_QUESTITEM = int.Parse(textBox2.Text);
				ybiClass.FLD_Name = textBox3.Text;
				ybiClass.FLD_NJ = int.Parse(textBox4.Text);
				ybiClass.FLD_RESIDE1 = int.Parse(textBox5.Text);
				ybiClass.FLD_RESIDE2 = int.Parse(textBox6.Text);
				ybiClass.FLD_SEX = int.Parse(textBox7.Text);
				ybiClass.FLD_DF = int.Parse(textBox8.Text);
				ybiClass.FLD_AT1 = int.Parse(textBox9.Text);
				ybiClass.FLD_AT2 = int.Parse(textBox10.Text);
				ybiClass.FLD_LEVEL = int.Parse(textBox11.Text);
				ybiClass.FLD_JOB_LEVEL = int.Parse(textBox12.Text);
				ybiClass.FLD_ZX = int.Parse(textBox13.Text);
				ybiClass.FLD_说明 = textBox14.Text;
				ybiClass.FLD_TYPE = int.Parse(textBox21.Text);
				ybiClass.FLD_WEIGHT = int.Parse(textBox22.Text);
				ybiClass.FLD_MONEY = int.Parse(textBox23.Text);
				ybiClass.FLD_EL = int.Parse(textBox24.Text);
				ybiClass.FLD_WXJD = int.Parse(textBox25.Text);
				ybiClass.FLD_WX = int.Parse(textBox26.Text);
				MessageBox.Show("修改成功!");
			}
			else
			{
				MessageBox.Show("查找物品出错!");
			}
		}

		private void 物品入库ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (listBox1.Items.Count == 0)
				{
					MessageBox.Show("请先打开Ybi.cfg文件!", "提示");
				}
				else
				{
					int fLD_MAGIC = 0;
					int num = 0;
					foreach (YbiClass value in ybidate.Values)
					{
						if (value.FLD_PID > 900000001 && value.FLD_PID < 1000000000)
						{
							if (value.FLD_LEVEL > 1)
							{
								value.FLD_QUESTITEM = 0;
								value.FLD_SIDE = 0;
							}
							else
							{
								value.FLD_QUESTITEM = 1;
								value.FLD_SIDE = 1;
							}
						}
						else
						{
							value.FLD_SIDE = 0;
							value.FLD_QUESTITEM = 0;
						}
						if (value.FLD_PID > 1000000166 && value.FLD_PID < 1000000178)
						{
							value.FLD_SIDE = 1;
						}
						if (value.FLD_Name.Contains("肉"))
						{
							value.FLD_SIDE = 1;
						}
						if (value.FLD_Name.Contains("灵兽宝珠"))
						{
							value.FLD_RESIDE2 = 17;
							value.FLD_TYPE = 0;
						}
						if (value.FLD_Name.Contains("强化"))
						{
							value.FLD_SIDE = 1;
							value.FLD_MAGIC1 = 0;
							value.FLD_WXJD = 0;
						}
						if ((value.FLD_Name.Contains("箭") || value.FLD_Name.Contains("回城") || value.FLD_说明.Contains("材料")) && !value.FLD_Name.Contains("箭破残阳") && !value.FLD_Name.Contains("石"))
						{
							value.FLD_SIDE = 1;
						}
						if (value.FLD_Name.Contains("箭"))
						{
							value.FLD_RESIDE2 = 13;
						}
						if (value.FLD_Name.Contains("鞍"))
						{
							value.FLD_RESIDE2 = 5;
						}
						if (value.FLD_Name.Contains("璀璨耀石"))
						{
							value.FLD_SIDE = 1;
						}
						if (value.FLD_Name.Contains("石") || value.FLD_Name.Contains("魂结晶"))
						{
							value.FLD_SIDE = 1;
						}
						if (value.FLD_Name.Contains("晶石碎片"))
						{
							value.FLD_SIDE = 1;
						}
						if (value.FLD_PID > 1000000713 && value.FLD_PID < 1000000996)
						{
							value.FLD_SIDE = 1;
						}
						if (value.FLD_PID > 1000000122 && value.FLD_PID < 1000000188)
						{
							value.FLD_SIDE = 1;
						}
						if (value.FLD_PID > 1000000312 && value.FLD_PID < 1000000321)
						{
							value.FLD_RESIDE2 = 1792;
						}
						if (value.FLD_Name.Contains("药") || value.FLD_Name.Contains("玫瑰") || value.FLD_Name.Contains("参") || value.FLD_Name.Contains("丹"))
						{
							value.FLD_SIDE = 1;
						}
						if (value.FLD_Name.Contains("盒") || value.FLD_Name.Contains("箱"))
						{
							value.FLD_RESIDE2 = 17;
						}
						if (value.FLD_Name.Contains("武功秘传"))
						{
							value.FLD_RESIDE2 = 1792;
							value.FLD_MAGIC1 = 0;
							value.FLD_WXJD = 0;
							value.FLD_WX = 0;
						}
						if (value.FLD_Name.Contains("武功秘籍"))
						{
							value.FLD_RESIDE2 = 1792;
							value.FLD_MAGIC1 = 0;
							value.FLD_WXJD = 0;
							value.FLD_WX = 0;
						}
						if (value.FLD_Name.Contains("武功秘传"))
						{
							value.FLD_RESIDE2 = 1792;
							value.FLD_MAGIC1 = 0;
							value.FLD_WXJD = 0;
							value.FLD_WX = 0;
						}
						if (value.FLD_Name.Contains("失传的秘籍（"))
						{
							value.FLD_RESIDE2 = 1792;
							value.FLD_MAGIC1 = 0;
							value.FLD_WXJD = 0;
							value.FLD_WX = 0;
						}
						if (value.FLD_Name.Contains("武功秘笈"))
						{
							value.FLD_RESIDE2 = 1792;
							value.FLD_MAGIC1 = 0;
							value.FLD_WXJD = 0;
							value.FLD_WX = 0;
						}
						if (value.FLD_LEVEL >= 130 && value.FLD_RESIDE2 == 4)
						{
							value.FLD_TZ = 1;
						}
						if (value.FLD_LEVEL >= 130 && value.FLD_RESIDE2 == 1)
						{
							value.FLD_TZ = 1;
						}
						if (value.FLD_LEVEL >= 130 && value.FLD_RESIDE2 == 5)
						{
							value.FLD_TZ = 1;
						}
						if (value.FLD_LEVEL >= 130 && value.FLD_RESIDE2 == 2)
						{
							value.FLD_TZ = 1;
						}
						if (value.FLD_LEVEL >= 130 && value.FLD_RESIDE2 == 6)
						{
							value.FLD_TZ = 1;
						}
						value.FLD_TYPE = ((value.FLD_PID.ToString().Contains("1008000") || value.FLD_PID.ToString().Contains("16900") || value.FLD_PID.ToString().Contains("26900") || value.FLD_PID.ToString().Contains("1007000")) ? 6 : 0);
						value.FLD_MAGIC1 = fLD_MAGIC;
						int num2 = 0;
						int num3 = 0;
						int num4 = 0;
						int num5 = 0;
						DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  *  FROM  TBL_XWWL_ITEM  WHERE  FLD_PID  =  {0}", value.FLD_PID.ToString()), "PublicDb");
						if (dBToDataTable != null)
						{
							if (dBToDataTable.Rows.Count == 0)
							{
								DBA.ExeSqlCommand(string.Format("INSERT INTO TBL_XWWL_ITEM (FLD_PID,  FLD_NAME,  FLD_RESIDE1,  FLD_RESIDE2,  FLD_SEX,  FLD_DF,  FLD_AT1,  FLD_AT2,  FLD_LEVEL,  FLD_JOB_LEVEL,  FLD_ZX,  FLD_MONEY,  FLD_WEIGHT, FLD_DES, FLD_WX, FLD_WXJD, FLD_EL, FLD_QUESTITEM, FLD_NJ, FLD_TYPE, FLD_MAGIC1, FLD_MAGIC2, FLD_MAGIC3 , FLD_MAGIC4, FLD_MAGIC5, FLD_SIDE, FLD_NEED_FIGHTEXP, FLD_RECYCLE_MONEY, FLD_SALE_MONEY, FLD_UP_LEVEL,FLD_SERIES,FLD_LOCK,FLD_INTEGRATION,FLD_NEED_MONEY)  VALUES  ({0},  '{1}',  {2},  {3},{4},  {5},  {6},  {7},  {8},  {9},  {10},  {11},  {12},'{13}',{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24},{25},{26},{27},{28},{29},{30},{31},{32},{33})", value.FLD_PID, value.FLD_Name, value.FLD_RESIDE1, value.FLD_RESIDE2, value.FLD_SEX, value.FLD_DF, value.FLD_AT1, value.FLD_AT2, value.FLD_LEVEL, value.FLD_JOB_LEVEL, value.FLD_ZX, value.FLD_MONEY, value.FLD_WEIGHT, value.FLD_说明, value.FLD_WX, value.FLD_WXJD, value.FLD_EL, value.FLD_QUESTITEM, value.FLD_NJ, value.FLD_TYPE, value.FLD_MAGIC1, 0, 0, 0, 0, value.FLD_SIDE, value.FLD_QGSLL, value.FLD_MM1, value.FLD_MM2, value.FLD_TZ, num2, num3, num4, num5), "PublicDb");
								num++;
							}
							dBToDataTable.Clear();
							dBToDataTable.Dispose();
						}
					}
					MessageBox.Show("完成,共增加新物品" + num, "提示");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "错误");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (listBox1.Items.Count == 0)
			{
				MessageBox.Show("请先打开Ybi.cfg文件!", "提示");
			}
			else if (textBox15.Text.Length == 0)
			{
				MessageBox.Show("请先输入要查询的内容!", "提示");
			}
			else if (radioButton1.Checked)
			{
				try
				{
					YbiClass ybiClass = getitem(Convert.ToInt32(textBox15.Text));
					if (ybiClass != null)
					{
						textBox1.Text = ybiClass.FLD_PID.ToString();
						textBox2.Text = ybiClass.FLD_QUESTITEM.ToString();
						textBox3.Text = ybiClass.FLD_Name;
						textBox4.Text = ybiClass.FLD_NJ.ToString();
						textBox5.Text = ybiClass.FLD_RESIDE1.ToString();
						textBox6.Text = ybiClass.FLD_RESIDE2.ToString();
						textBox7.Text = ybiClass.FLD_SEX.ToString();
						textBox8.Text = ybiClass.FLD_DF.ToString();
						textBox9.Text = ybiClass.FLD_AT1.ToString();
						textBox10.Text = ybiClass.FLD_AT2.ToString();
						textBox11.Text = ybiClass.FLD_LEVEL.ToString();
						textBox12.Text = ybiClass.FLD_JOB_LEVEL.ToString();
						textBox13.Text = ybiClass.FLD_ZX.ToString();
						textBox14.Text = ybiClass.FLD_说明;
						textBox21.Text = ybiClass.FLD_TYPE.ToString();
						textBox22.Text = ybiClass.FLD_WEIGHT.ToString();
						textBox23.Text = ybiClass.FLD_MONEY.ToString();
						textBox24.Text = ybiClass.FLD_EL.ToString();
						textBox25.Text = ybiClass.FLD_WXJD.ToString();
						textBox26.Text = ybiClass.FLD_WX.ToString();
						int num = 0;
						while (true)
						{
							if (num >= listBox1.Items.Count)
							{
								return;
							}
							if (listBox1.Items[num].Equals(textBox3.Text))
							{
								break;
							}
							num++;
						}
						listBox1.SetSelected(num, true);
					}
					else
					{
						MessageBox.Show("无此物品,请检查PID是否正确！", "提示");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString(), "错误");
				}
			}
			else if (radioButton2.Checked)
			{
				try
				{
					YbiClass ybiClass2 = getitem(textBox15.Text);
					if (ybiClass2 != null)
					{
						textBox1.Text = ybiClass2.FLD_PID.ToString();
						textBox2.Text = ybiClass2.FLD_QUESTITEM.ToString();
						textBox3.Text = ybiClass2.FLD_Name;
						textBox4.Text = ybiClass2.FLD_NJ.ToString();
						textBox5.Text = ybiClass2.FLD_RESIDE1.ToString();
						textBox6.Text = ybiClass2.FLD_RESIDE2.ToString();
						textBox7.Text = ybiClass2.FLD_SEX.ToString();
						textBox8.Text = ybiClass2.FLD_DF.ToString();
						textBox9.Text = ybiClass2.FLD_AT1.ToString();
						textBox10.Text = ybiClass2.FLD_AT2.ToString();
						textBox11.Text = ybiClass2.FLD_LEVEL.ToString();
						textBox12.Text = ybiClass2.FLD_JOB_LEVEL.ToString();
						textBox13.Text = ybiClass2.FLD_ZX.ToString();
						textBox14.Text = ybiClass2.FLD_说明;
						textBox21.Text = ybiClass2.FLD_TYPE.ToString();
						textBox22.Text = ybiClass2.FLD_WEIGHT.ToString();
						textBox23.Text = ybiClass2.FLD_MONEY.ToString();
						textBox24.Text = ybiClass2.FLD_EL.ToString();
						textBox25.Text = ybiClass2.FLD_WXJD.ToString();
						textBox26.Text = ybiClass2.FLD_WX.ToString();
					}
					else
					{
						MessageBox.Show("无此物品,请检查物品名是否正确！", "提示");
					}
				}
				catch (Exception ex2)
				{
					MessageBox.Show(ex2.ToString(), "错误");
				}
			}
			else
			{
				MessageBox.Show("请选择查询的类型", "提示");
			}
		}

		private YbiClass getitem_reside2(int reside2)
		{
			foreach (YbiClass value in ybidate.Values)
			{
				if (value.FLD_RESIDE2 == reside2)
				{
					return value;
				}
			}
			return null;
		}

		private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
		{
			string text = comboBox1.SelectedItem.ToString();
			if (text == null)
			{
				goto IL_0288;
			}
			uint num = Class3.smethod_0(text);
			int num2;
			if (num <= 1583700141)
			{
				if (num <= 806828493)
				{
					if (num <= 386101911)
					{
						if (num != 351508891)
						{
							if (num != 386101911 || !(text == "灵兽"))
							{
								goto IL_0288;
							}
							num2 = 15;
						}
						else
						{
							if (!(text == "任务物品"))
							{
								goto IL_0288;
							}
							num2 = 1000;
						}
					}
					else if (num != 762145023)
					{
						if (num != 806828493 || !(text == "其他"))
						{
							goto IL_0288;
						}
						num2 = 2000;
					}
					else
					{
						if (!(text == "盒子"))
						{
							goto IL_0288;
						}
						num2 = 17;
					}
				}
				else if (num <= 963180387)
				{
					if (num != 867671693)
					{
						if (num != 963180387 || !(text == "武器"))
						{
							goto IL_0288;
						}
						num2 = 4;
					}
					else
					{
						if (!(text == "衣服"))
						{
							goto IL_0288;
						}
						num2 = 1;
					}
				}
				else if (num != 1502406078)
				{
					if (num != 1583700141 || !(text == "全部"))
					{
						goto IL_0288;
					}
					num2 = 3000;
				}
				else
				{
					if (!(text == "项链"))
					{
						goto IL_0288;
					}
					num2 = 7;
				}
			}
			else if (num <= 3322318871u)
			{
				if (num <= 2913798006u)
				{
					if (num != 1895148392)
					{
						if (num != 2913798006u || !(text == "戒指"))
						{
							goto IL_0288;
						}
						num2 = 10;
					}
					else
					{
						if (!(text == "护手"))
						{
							goto IL_0288;
						}
						num2 = 2;
					}
				}
				else if (num != 3205149562u)
				{
					if (num != 3322318871u || !(text == "耳环"))
					{
						goto IL_0288;
					}
					num2 = 8;
				}
				else
				{
					if (!(text == "符文"))
					{
						goto IL_0288;
					}
					num2 = 18;
				}
			}
			else if (num <= 3558870252u)
			{
				if (num != 3376198402u)
				{
					if (num != 3558870252u || !(text == "披风"))
					{
						goto IL_0288;
					}
					num2 = 12;
				}
				else
				{
					if (!(text == "石头"))
					{
						goto IL_0288;
					}
					num2 = 16;
				}
			}
			else if (num != 4059967668u)
			{
				if (num != 4183737334u)
				{
					if (num != 4237204361u || !(text == "靴子"))
					{
						goto IL_0288;
					}
					num2 = 5;
				}
				else
				{
					if (!(text == "内甲"))
					{
						goto IL_0288;
					}
					num2 = 6;
				}
			}
			else
			{
				if (!(text == "百宝"))
				{
					goto IL_0288;
				}
				num2 = 4000;
			}
			goto IL_028e;
			IL_028e:
			listBox1.Items.Clear();
			switch (num2)
			{
			case 1000:
				foreach (YbiClass value in ybidate.Values)
				{
					if (value.FLD_PID > 900000001 && value.FLD_PID < 1000000000)
					{
						listBox1.Items.Add(value.FLD_Name);
					}
				}
				break;
			case 1:
				foreach (YbiClass value2 in ybidate.Values)
				{
					if (value2.FLD_RESIDE2 == num2)
					{
						listBox1.Items.Add(value2.FLD_Name);
					}
				}
				break;
			case 2:
				foreach (YbiClass value3 in ybidate.Values)
				{
					if (value3.FLD_RESIDE2 == num2)
					{
						listBox1.Items.Add(value3.FLD_Name);
					}
				}
				break;
			case 4:
				foreach (YbiClass value4 in ybidate.Values)
				{
					if (value4.FLD_RESIDE2 == num2)
					{
						listBox1.Items.Add(value4.FLD_Name);
					}
				}
				break;
			case 5:
				foreach (YbiClass value5 in ybidate.Values)
				{
					if (value5.FLD_RESIDE2 == num2)
					{
						listBox1.Items.Add(value5.FLD_Name);
					}
				}
				break;
			case 6:
				foreach (YbiClass value6 in ybidate.Values)
				{
					if (value6.FLD_RESIDE2 == num2)
					{
						listBox1.Items.Add(value6.FLD_Name);
					}
				}
				break;
			case 7:
				foreach (YbiClass value7 in ybidate.Values)
				{
					if (value7.FLD_RESIDE2 == num2)
					{
						listBox1.Items.Add(value7.FLD_Name);
					}
				}
				break;
			case 8:
				foreach (YbiClass value8 in ybidate.Values)
				{
					if (value8.FLD_RESIDE2 == num2)
					{
						listBox1.Items.Add(value8.FLD_Name);
					}
				}
				break;
			case 10:
				foreach (YbiClass value9 in ybidate.Values)
				{
					if (value9.FLD_RESIDE2 == num2)
					{
						listBox1.Items.Add(value9.FLD_Name);
					}
				}
				break;
			case 12:
				foreach (YbiClass value10 in ybidate.Values)
				{
					if (value10.FLD_RESIDE2 == num2)
					{
						listBox1.Items.Add(value10.FLD_Name);
					}
				}
				break;
			case 15:
				foreach (YbiClass value11 in ybidate.Values)
				{
					if (value11.FLD_RESIDE2 == num2)
					{
						listBox1.Items.Add(value11.FLD_Name);
					}
				}
				break;
			case 16:
				foreach (YbiClass value12 in ybidate.Values)
				{
					if (value12.FLD_RESIDE2 == num2)
					{
						listBox1.Items.Add(value12.FLD_Name);
					}
				}
				break;
			case 17:
				foreach (YbiClass value13 in ybidate.Values)
				{
					if (value13.FLD_PID == 1000000001 || value13.FLD_PID == 1000000251 || value13.FLD_PID == 1000000250 || value13.FLD_PID == 1000000071 || value13.FLD_PID == 1000000006 || value13.FLD_PID == 1000000005 || value13.FLD_PID == 1000000026 || value13.FLD_PID == 1000000023 || value13.FLD_PID == 1000000008 || value13.FLD_PID == 1000000003 || value13.FLD_PID == 1000000002)
					{
						listBox1.Items.Add(value13.FLD_Name);
					}
				}
				break;
			case 18:
				foreach (YbiClass value14 in ybidate.Values)
				{
					if (value14.FLD_RESIDE2 == num2)
					{
						listBox1.Items.Add(value14.FLD_Name);
					}
				}
				break;
			default:
				foreach (YbiClass value15 in ybidate.Values)
				{
					if (value15.FLD_RESIDE2 != 1 && value15.FLD_RESIDE2 != 2 && value15.FLD_RESIDE2 != 4 && value15.FLD_RESIDE2 != 5 && value15.FLD_RESIDE2 != 6 && value15.FLD_RESIDE2 != 7 && value15.FLD_RESIDE2 != 8 && value15.FLD_RESIDE2 != 10 && value15.FLD_RESIDE2 != 12 && value15.FLD_RESIDE2 != 15 && value15.FLD_RESIDE2 != 16 && value15.FLD_RESIDE2 != 17 && value15.FLD_RESIDE2 != 18 && value15.FLD_PID != 1000000001 && value15.FLD_PID != 1000000251 && value15.FLD_PID != 1000000250 && value15.FLD_PID != 1000000071 && value15.FLD_PID != 1000000006 && value15.FLD_PID != 1000000005 && value15.FLD_PID != 1000000026 && value15.FLD_PID != 1000000023 && value15.FLD_PID != 1000000008 && value15.FLD_PID != 1000000003 && value15.FLD_PID != 1000000002 && (value15.FLD_PID <= 900000001 || value15.FLD_PID >= 1000000000) && value15.FLD_TYPE != 6)
					{
						listBox1.Items.Add(value15.FLD_Name);
					}
				}
				break;
			case 4000:
				foreach (YbiClass value16 in ybidate.Values)
				{
					if (value16.FLD_TYPE == 6)
					{
						listBox1.Items.Add(value16.FLD_Name);
					}
				}
				break;
			case 3000:
			{
				using (Dictionary<int, YbiClass>.ValueCollection.Enumerator enumerator = ybidate.Values.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						listBox1.Items.Add(enumerator.Current.FLD_Name);
					}
				}
				break;
			}
			}
			label28.Text = listBox1.Items.Count.ToString();
			return;
			IL_0288:
			num2 = 3000;
			goto IL_028e;
		}

		private void YbiForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				if (ybidate != null)
				{
					ybidate.Clear();
				}
				物品 = null;
				KEY = null;
				武功 = null;
				气功 = null;
				称号 = null;
				屏蔽1 = null;
				屏蔽2 = null;
				NPC = null;
				未知1 = null;
				地图名 = null;
				未知2 = null;
			}
			catch (Exception)
			{
			}
		}

		private void textBox14_TextChanged(object sender, EventArgs e)
		{
		}
	}
}
