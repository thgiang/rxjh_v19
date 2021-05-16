using LuaInterface;
using RxjhServer.bbg;
using RxjhServer.DbClss;
using RxjhServer.HelperTools;
using RxjhServer.Network;
using RxjhTool;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace RxjhServer
{
	public class Form1 : Form
	{
		private static List<TxtClass> txt = new List<TxtClass>();

		private static int kjdx = 300;

		private System.Timers.Timer 狮子吼 = new System.Timers.Timer(21000.0);

		private DateTime sj = DateTime.Now;

		private int aaa = 2;

		private System.Timers.Timer 自动连接;

		private int 自动公告ID;

		private static World world;

		private Thread thThreadRead;

		private static Thread timerThread;

		private RxjhServer.Network.Listener l;

		private bool runn;

		private StatusBar statusBar1;

		private StatusBarPanel statusBarPanel1;

		private StatusBarPanel statusBarPanel2;

		private MainMenu mainMenu1;

		private MenuItem menuItem1;

		private MenuItem menuItem2;

		private MenuItem menuItem3;

		private MenuItem menuItem4;

		private MenuItem menuItem5;

		private MenuItem menuItem6;

		private MenuItem menuItem7;

		private ImageList imageList1;

		private MenuItem menuItem8;

		private MenuItem menuItem9;

		private MenuItem menuItem10;

		private MenuItem menuItem11;

		private MenuItem menuItem12;

		private MenuItem menuItem13;

		private MenuItem menuItem14;

		private StatusBarPanel statusBarPanel3;

		private MenuItem menuItem15;

		private MenuItem menuItem16;

		private MenuItem menuItem17;

		private StatusBarPanel statusBarPanel4;

		private MenuItem menuItem18;

		private MenuItem menuItem19;

		private MenuItem menuItem20;

		private FlickerFreePanel GraphPanel;

		private System.Windows.Forms.Timer timer1;

		private MenuItem menuItem21;

		private MenuItem menuItem22;

		private MenuItem menuItem23;

		private ToolStrip toolStrip1;

		private ToolStripTextBox toolStripTextBox1;

		private ToolStripButton toolStripButton1;

		private ToolStripTextBox toolStripTextBox2;

		private ToolStripComboBox toolStripComboBox1;

		private ToolStripButton toolStripButton2;

		private ToolStripSeparator toolStripSeparator1;

		private ToolStripButton toolStripButton3;

		private ToolStripSeparator toolStripSeparator2;

		private ToolStripButton toolStripButton4;

		private MenuItem menuItem25;

		private MenuItem menuItem26;

		private ToolStripComboBox toolStripComboBox2;

		private MenuItem menuItem27;

		private MenuItem menuItem28;

		private MenuItem menuItem29;

		private MenuItem menuItem30;

		private MenuItem menuItem32;

		private MenuItem menuItem33;

		private MenuItem menuItem34;

		private MenuItem menuItem35;

		private MenuItem menuItem36;

		private MenuItem menuItem37;

		private MenuItem menuItem38;

		private MenuItem menuItem39;

		private MenuItem menuItem40;

		private MenuItem menuItem41;

		private MenuItem menuItem42;

		private MenuItem menuItem43;

		private MenuItem menuItem44;

		private MenuItem menuItem45;

		private MenuItem menuItem24;

		private MenuItem menuItem49;

		private MenuItem menuItem50;

		private MenuItem menuItem52;

		private MenuItem menuItem46;

		private MenuItem menuItem48;

		private MenuItem menuItem53;

		private MenuItem menuItem54;

		private MenuItem menuItem55;

		private MenuItem menuItem47;

		private MenuItem menuItem56;

		private MenuItem menuItem57;

		private MenuItem menuItem58;

		private MenuItem menuItem31;

		private MenuItem menuItem51;

		private MenuItem menuItem59;

		private IContainer components;

		public Form1()
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel3 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel4 = new System.Windows.Forms.StatusBarPanel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem32 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem29 = new System.Windows.Forms.MenuItem();
            this.menuItem17 = new System.Windows.Forms.MenuItem();
            this.menuItem31 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem27 = new System.Windows.Forms.MenuItem();
            this.menuItem37 = new System.Windows.Forms.MenuItem();
            this.menuItem20 = new System.Windows.Forms.MenuItem();
            this.menuItem38 = new System.Windows.Forms.MenuItem();
            this.menuItem19 = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.menuItem18 = new System.Windows.Forms.MenuItem();
            this.menuItem21 = new System.Windows.Forms.MenuItem();
            this.menuItem26 = new System.Windows.Forms.MenuItem();
            this.menuItem33 = new System.Windows.Forms.MenuItem();
            this.menuItem34 = new System.Windows.Forms.MenuItem();
            this.menuItem35 = new System.Windows.Forms.MenuItem();
            this.menuItem36 = new System.Windows.Forms.MenuItem();
            this.menuItem48 = new System.Windows.Forms.MenuItem();
            this.menuItem54 = new System.Windows.Forms.MenuItem();
            this.menuItem55 = new System.Windows.Forms.MenuItem();
            this.menuItem47 = new System.Windows.Forms.MenuItem();
            this.menuItem51 = new System.Windows.Forms.MenuItem();
            this.menuItem59 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem30 = new System.Windows.Forms.MenuItem();
            this.menuItem28 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem22 = new System.Windows.Forms.MenuItem();
            this.menuItem23 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem25 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItem50 = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.menuItem16 = new System.Windows.Forms.MenuItem();
            this.menuItem39 = new System.Windows.Forms.MenuItem();
            this.menuItem42 = new System.Windows.Forms.MenuItem();
            this.menuItem43 = new System.Windows.Forms.MenuItem();
            this.menuItem44 = new System.Windows.Forms.MenuItem();
            this.menuItem45 = new System.Windows.Forms.MenuItem();
            this.menuItem24 = new System.Windows.Forms.MenuItem();
            this.menuItem52 = new System.Windows.Forms.MenuItem();
            this.menuItem46 = new System.Windows.Forms.MenuItem();
            this.menuItem53 = new System.Windows.Forms.MenuItem();
            this.menuItem40 = new System.Windows.Forms.MenuItem();
            this.menuItem41 = new System.Windows.Forms.MenuItem();
            this.menuItem49 = new System.Windows.Forms.MenuItem();
            this.menuItem56 = new System.Windows.Forms.MenuItem();
            this.menuItem57 = new System.Windows.Forms.MenuItem();
            this.menuItem58 = new System.Windows.Forms.MenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.GraphPanel = new RxjhServer.FlickerFreePanel();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel4)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 311);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1,
            this.statusBarPanel2,
            this.statusBarPanel3,
            this.statusBarPanel4});
            this.statusBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(684, 22);
            this.statusBar1.TabIndex = 6;
            this.statusBar1.Text = "statusBar1";
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Text = "连接      1000      在线      1000";
            this.statusBarPanel1.Width = 200;
            // 
            // statusBarPanel2
            // 
            this.statusBarPanel2.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.statusBarPanel2.Name = "statusBarPanel2";
            this.statusBarPanel2.Width = 160;
            // 
            // statusBarPanel3
            // 
            this.statusBarPanel3.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.statusBarPanel3.Name = "statusBarPanel3";
            this.statusBarPanel3.Width = 180;
            // 
            // statusBarPanel4
            // 
            this.statusBarPanel4.Name = "statusBarPanel4";
            this.statusBarPanel4.Text = "statusBarPanel4";
            this.statusBarPanel4.Width = 120;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem4,
            this.menuItem6,
            this.menuItem40,
            this.menuItem56});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem32,
            this.menuItem3,
            this.menuItem2,
            this.menuItem29,
            this.menuItem17,
            this.menuItem31});
            this.menuItem1.Text = "服务";
            // 
            // menuItem32
            // 
            this.menuItem32.Index = 0;
            this.menuItem32.Text = "开始登陆服务";
            this.menuItem32.Click += new System.EventHandler(this.menuItem32_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Text = "停止登陆服务";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 2;
            this.menuItem2.Text = "停止主服务";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem29
            // 
            this.menuItem29.Index = 3;
            this.menuItem29.Text = "线程停止";
            this.menuItem29.Click += new System.EventHandler(this.menuItem29_Click);
            // 
            // menuItem17
            // 
            this.menuItem17.Index = 4;
            this.menuItem17.Text = "存档人物";
            this.menuItem17.Click += new System.EventHandler(this.menuItem17_Click);
            // 
            // menuItem31
            // 
            this.menuItem31.Index = 5;
            this.menuItem31.Text = "存档所有";
            this.menuItem31.Click += new System.EventHandler(this.menuItem31_Click_1);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 1;
            this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem5,
            this.menuItem27,
            this.menuItem37,
            this.menuItem20,
            this.menuItem38,
            this.menuItem19,
            this.menuItem15,
            this.menuItem18,
            this.menuItem21,
            this.menuItem26,
            this.menuItem33,
            this.menuItem34,
            this.menuItem35,
            this.menuItem36,
            this.menuItem48,
            this.menuItem54,
            this.menuItem55,
            this.menuItem47,
            this.menuItem51,
            this.menuItem59});
            this.menuItem4.Text = "控制";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 0;
            this.menuItem5.Text = "用户";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItem27
            // 
            this.menuItem27.Index = 1;
            this.menuItem27.Text = "组队";
            this.menuItem27.Click += new System.EventHandler(this.menuItem27_Click);
            // 
            // menuItem37
            // 
            this.menuItem37.Index = 2;
            this.menuItem37.Text = "地面物品";
            this.menuItem37.Click += new System.EventHandler(this.menuItem37_Click);
            // 
            // menuItem20
            // 
            this.menuItem20.Checked = true;
            this.menuItem20.Index = 3;
            this.menuItem20.Text = "显示记录";
            this.menuItem20.Click += new System.EventHandler(this.menuItem20_Click);
            // 
            // menuItem38
            // 
            this.menuItem38.Index = 4;
            this.menuItem38.Text = "显示掉落";
            this.menuItem38.Click += new System.EventHandler(this.menuItem38_Click);
            // 
            // menuItem19
            // 
            this.menuItem19.Index = 5;
            this.menuItem19.Text = "记录日志";
            this.menuItem19.Click += new System.EventHandler(this.menuItem19_Click);
            // 
            // menuItem15
            // 
            this.menuItem15.Index = 6;
            this.menuItem15.Text = "记录封包";
            this.menuItem15.Click += new System.EventHandler(this.menuItem15_Click);
            // 
            // menuItem18
            // 
            this.menuItem18.Index = 7;
            this.menuItem18.Text = "验证服务器";
            this.menuItem18.Click += new System.EventHandler(this.menuItem18_Click);
            // 
            // menuItem21
            // 
            this.menuItem21.Checked = true;
            this.menuItem21.Index = 8;
            this.menuItem21.Text = "查复制";
            this.menuItem21.Click += new System.EventHandler(this.menuItem21_Click);
            // 
            // menuItem26
            // 
            this.menuItem26.Index = 9;
            this.menuItem26.Text = "查SQL";
            this.menuItem26.Click += new System.EventHandler(this.menuItem26_Click);
            // 
            // menuItem33
            // 
            this.menuItem33.Index = 10;
            this.menuItem33.Text = "清理人物数据";
            this.menuItem33.Click += new System.EventHandler(this.menuItem33_Click);
            // 
            // menuItem34
            // 
            this.menuItem34.Index = 11;
            this.menuItem34.Text = "清理个人仓库";
            this.menuItem34.Click += new System.EventHandler(this.menuItem34_Click);
            // 
            // menuItem35
            // 
            this.menuItem35.Index = 12;
            this.menuItem35.Text = "清理宗合仓库";
            this.menuItem35.Click += new System.EventHandler(this.menuItem35_Click);
            // 
            // menuItem36
            // 
            this.menuItem36.Index = 13;
            this.menuItem36.Text = "清理帮派数据";
            this.menuItem36.Click += new System.EventHandler(this.menuItem36_Click);
            // 
            // menuItem48
            // 
            this.menuItem48.Index = 14;
            this.menuItem48.Text = "Npc控制";
            this.menuItem48.Click += new System.EventHandler(this.menuItem48_Click);
            // 
            // menuItem54
            // 
            this.menuItem54.Index = 15;
            this.menuItem54.Text = "开启修炼地图";
            this.menuItem54.Click += new System.EventHandler(this.menuItem54_Click);
            // 
            // menuItem55
            // 
            this.menuItem55.Index = 16;
            this.menuItem55.Text = "石头控制";
            this.menuItem55.Click += new System.EventHandler(this.menuItem55_Click);
            // 
            // menuItem47
            // 
            this.menuItem47.Index = 17;
            this.menuItem47.Text = "气功控制";
            this.menuItem47.Click += new System.EventHandler(this.menuItem47_Click);
            // 
            // menuItem51
            // 
            this.menuItem51.Index = 18;
            this.menuItem51.Text = "开启攻城";
            this.menuItem51.Click += new System.EventHandler(this.menuItem51_Click_1);
            // 
            // menuItem59
            // 
            this.menuItem59.Index = 19;
            this.menuItem59.Text = "开启仙魔大战";
            this.menuItem59.Click += new System.EventHandler(this.menuItem59_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 2;
            this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem7,
            this.menuItem30,
            this.menuItem28,
            this.menuItem8,
            this.menuItem22,
            this.menuItem23,
            this.menuItem9,
            this.menuItem25,
            this.menuItem10,
            this.menuItem11,
            this.menuItem12,
            this.menuItem13,
            this.menuItem50,
            this.menuItem14,
            this.menuItem16,
            this.menuItem39,
            this.menuItem42,
            this.menuItem43,
            this.menuItem44,
            this.menuItem45,
            this.menuItem24,
            this.menuItem52,
            this.menuItem46,
            this.menuItem53});
            this.menuItem6.Text = "重读";
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 0;
            this.menuItem7.Text = "重读全部配置";
            this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
            // 
            // menuItem30
            // 
            this.menuItem30.Index = 1;
            this.menuItem30.Text = "重读武功数据";
            this.menuItem30.Click += new System.EventHandler(this.menuItem30_Click);
            // 
            // menuItem28
            // 
            this.menuItem28.Index = 2;
            this.menuItem28.Text = "重读过滤";
            this.menuItem28.Click += new System.EventHandler(this.menuItem28_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 3;
            this.menuItem8.Text = "重读NPC";
            this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
            // 
            // menuItem22
            // 
            this.menuItem22.Index = 4;
            this.menuItem22.Text = "重读怪物数据";
            this.menuItem22.Click += new System.EventHandler(this.menuItem22_Click);
            // 
            // menuItem23
            // 
            this.menuItem23.Index = 5;
            this.menuItem23.Text = "重读BOSS物品掉落";
            this.menuItem23.Click += new System.EventHandler(this.menuItem23_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 6;
            this.menuItem9.Text = "重读物品掉落";
            this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
            // 
            // menuItem25
            // 
            this.menuItem25.Index = 7;
            this.menuItem25.Text = "重读高手怪物品掉落";
            this.menuItem25.Click += new System.EventHandler(this.menuItem25_Click);
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 8;
            this.menuItem10.Text = "重读开箱";
            this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 9;
            this.menuItem11.Text = "重读物品";
            this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click);
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 10;
            this.menuItem12.Text = "重读NPC商店";
            this.menuItem12.Click += new System.EventHandler(this.menuItem12_Click);
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 11;
            this.menuItem13.Text = "重读传送点";
            this.menuItem13.Click += new System.EventHandler(this.menuItem13_Click);
            // 
            // menuItem50
            // 
            this.menuItem50.Index = 12;
            this.menuItem50.Text = "重读自定义移动数据";
            this.menuItem50.Click += new System.EventHandler(this.menuItem50_Click);
            // 
            // menuItem14
            // 
            this.menuItem14.Index = 13;
            this.menuItem14.Text = "重读自动公告";
            this.menuItem14.Click += new System.EventHandler(this.menuItem14_Click);
            // 
            // menuItem16
            // 
            this.menuItem16.Index = 14;
            this.menuItem16.Text = "重读配置文件";
            this.menuItem16.Click += new System.EventHandler(this.menuItem16_Click);
            // 
            // menuItem39
            // 
            this.menuItem39.Index = 15;
            this.menuItem39.Text = "重读脚本";
            this.menuItem39.Click += new System.EventHandler(this.menuItem39_Click);
            // 
            // menuItem42
            // 
            this.menuItem42.Index = 16;
            this.menuItem42.Text = "重读制作列表";
            this.menuItem42.Click += new System.EventHandler(this.menuItem42_Click);
            // 
            // menuItem43
            // 
            this.menuItem43.Index = 17;
            this.menuItem43.Text = "重读百宝阁数据";
            this.menuItem43.Click += new System.EventHandler(this.menuItem43_Click);
            // 
            // menuItem44
            // 
            this.menuItem44.Index = 18;
            this.menuItem44.Text = "重读套装数据";
            this.menuItem44.Click += new System.EventHandler(this.menuItem44_Click);
            // 
            // menuItem45
            // 
            this.menuItem45.Index = 19;
            this.menuItem45.Text = "重读等级奖励";
            this.menuItem45.Click += new System.EventHandler(this.menuItem45_Click);
            // 
            // menuItem24
            // 
            this.menuItem24.Index = 20;
            this.menuItem24.Text = "重读物品兑换";
            this.menuItem24.Click += new System.EventHandler(this.menuItem24_Click);
            // 
            // menuItem52
            // 
            this.menuItem52.Index = 21;
            this.menuItem52.Text = "重读任务数据";
            this.menuItem52.Click += new System.EventHandler(this.menuItem52_Click);
            // 
            // menuItem46
            // 
            this.menuItem46.Index = 22;
            this.menuItem46.Text = "重读气功加成比率";
            this.menuItem46.Click += new System.EventHandler(this.menuItem46_Click);
            // 
            // menuItem53
            // 
            this.menuItem53.Index = 23;
            this.menuItem53.Text = "重读石头设置";
            this.menuItem53.Click += new System.EventHandler(this.menuItem53_Click);
            // 
            // menuItem40
            // 
            this.menuItem40.Index = 3;
            this.menuItem40.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem41,
            this.menuItem49});
            this.menuItem40.Text = "工具";
            // 
            // menuItem41
            // 
            this.menuItem41.Index = 0;
            this.menuItem41.Text = "YBQ编辑器";
            this.menuItem41.Click += new System.EventHandler(this.menuItem41_Click);
            // 
            // menuItem49
            // 
            this.menuItem49.Index = 1;
            this.menuItem49.Text = "YBI编辑器";
            this.menuItem49.Click += new System.EventHandler(this.menuItem49_Click);
            // 
            // menuItem56
            // 
            this.menuItem56.Index = 4;
            this.menuItem56.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem57,
            this.menuItem58});
            this.menuItem56.Text = "设置";
            // 
            // menuItem57
            // 
            this.menuItem57.Index = 0;
            this.menuItem57.Text = "网络设置";
            this.menuItem57.Click += new System.EventHandler(this.menuItem57_Click);
            // 
            // menuItem58
            // 
            this.menuItem58.Index = 1;
            this.menuItem58.Text = "防CC设置";
            this.menuItem58.Click += new System.EventHandler(this.menuItem58_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripComboBox2,
            this.toolStripButton1,
            this.toolStripTextBox2,
            this.toolStripComboBox1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripButton3,
            this.toolStripSeparator2,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(684, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(199, 25);
            this.toolStripTextBox1.Text = resources.GetString("toolStripTextBox1.Text");
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.DropDownWidth = 75;
            this.toolStripComboBox2.IntegralHeight = false;
            this.toolStripComboBox2.Items.AddRange(new object[] {
            "正常",
            "加密"});
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(76, 25);
            this.toolStripComboBox2.Text = "正常";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 22);
            this.toolStripButton1.Text = "发送";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBox2.Text = "空";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "10",
            "9"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(75, 25);
            this.toolStripComboBox1.Text = "10";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(36, 22);
            this.toolStripButton2.Text = "发送";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(60, 22);
            this.toolStripButton3.Text = "复查用户";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(24, 22);
            this.toolStripButton4.Text = "查";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // GraphPanel
            // 
            this.GraphPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GraphPanel.BackColor = System.Drawing.Color.White;
            this.GraphPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GraphPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GraphPanel.Location = new System.Drawing.Point(0, 28);
            this.GraphPanel.Name = "GraphPanel";
            this.GraphPanel.Size = new System.Drawing.Size(684, 333);
            this.GraphPanel.TabIndex = 0;
            this.GraphPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.GraphPanel_Paint);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(684, 333);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.GraphPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameServer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.Form1_Layout);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel4)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		[STAThread]
		private static void Main()
		{
			try
			{

				Application.Run(new Form1());
               
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main  错误" + ((ex != null) ? ex.ToString() : null));
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			try
			{
				timerThread = new Thread(new Timer.TimerThread().TimerMain);
				timerThread.Name = "Timer  Thread";
				timerThread.Start();
				world = new World();
				world.SetConfig();
                world.SetConfig3();
                world.SetConfig2();
                if (World.检查数据库配置())
				{
					world.SetMonSter();
					world.SetNpc();
					world.SetDrop();
					world.Set_GSDrop();
					world.SetBossDrop();
					world.SetOpen();
					world.Set套装();
					world.SetBbgItem();
					world.SetLever();
					world.SetWxLever();
					world.SetKONGFU();
					world.SetItme();
					world.SetShop();
					world.SetMover();
					world.Set公告();
					world.Set等级奖励();
					world.Set物品兑换();
					world.Set移动();
					world.Set制药物品();
					world.Set安全区();
					world.SetKill();
					world.SetJianc();
					world.Set升天气功();
					world.Set制作物品();
					world.SetScript();
					world.Set任务数据新();
					world.SetQG();
					world.Set石头属性();
					world.荣誉门派排行();
					World.更新所有排行数据();
					world.荣誉门派排行();
					World.conn = new Connect();
					World.conn.Sestup();
					l = new RxjhServer.Network.Listener((ushort)World.游戏服务器端口);
					new AuthServer(World.百宝阁服务器IP, World.百宝阁服务器端口);
					Text = Text + "_" + World.服务器名 + "_" + Assembly.GetExecutingAssembly().GetName().Version.ToString();
					thThreadRead = new Thread(FlushAll);
					thThreadRead.Name = "FlushAll";
					thThreadRead.Priority = ThreadPriority.Lowest;
					thThreadRead.Start();
					World.游戏服务器端口1 = World.游戏服务器端口;
					new WGServer("127.0.0.1", World.转发器网关服务端口).Start();
					World.ycServerConnect = new AtServerConnect();
					World.ycServerConnect.Sestup();
					Timer.DelayCall(TimeSpan.FromMilliseconds(180000.0), TimeSpan.FromMilliseconds(180000.0), 自动公告事件);
					Timer.DelayCall(TimeSpan.FromMilliseconds(360000.0), TimeSpan.FromMilliseconds(360000.0), 自动更新荣誉);
					狮子吼 = new System.Timers.Timer(21000.0);
					狮子吼.Elapsed += 狮子吼事件;
					狮子吼.AutoReset = true;
					狮子吼.Enabled = true;
					自动连接 = new System.Timers.Timer(World.自动连接时间 * 1000);
					自动连接.Elapsed += 自动连接事件;
					自动连接.AutoReset = true;
					自动连接.Enabled = true;
					Thread1();
				}
			}
			catch (Exception ex)
			{
				WriteLine(1, "Form1_Load  错误" + ex.Message);
			}
		}

		public void 自动更新荣誉()
		{
			if (World.jlMsg == 1)
			{
				WriteLine(0, "刷新荣誉事件");
			}
			World.更新所有排行数据();
			world.荣誉门派排行();
			WriteLine(2, "刷新荣誉排行数据完成");
		}

		private void 自动连接事件(object sender, ElapsedEventArgs e)
		{
			自动连接.Interval = World.自动连接时间 * 1000;
			if (!World.主Socket)
			{
				menuItem2.Text = "停止主服务";
				if (l != null)
				{
					l.Stop();
					l = null;
				}
				int num = new Random().Next(10, 200);
				l = new RxjhServer.Network.Listener((ushort)(World.游戏服务器端口 + num));
				World.端口更换通知();
			}
		}

		private void menuItem32_Click(object sender, EventArgs e)
		{
			if (World.conn != null)
			{
				World.conn.Dispose();
				World.conn = null;
			}
			World.conn = new Connect();
			World.conn.Sestup();
		}

		private void menuItem2_Click(object sender, EventArgs e)
		{
			if (l != null)
			{
				menuItem2.Text = "开始主服务";
				l.Stop();
				l = null;
			}
			else
			{
				menuItem2.Text = "停止主服务";
				int num = new Random().Next(10, 200);
				World.游戏服务器端口1 = World.游戏服务器端口 + num;
				l = new RxjhServer.Network.Listener((ushort)World.游戏服务器端口1);
				World.端口更换通知();
			}
		}

		private void menuItem3_Click(object sender, EventArgs e)
		{
			World.conn.Dispose();
			List<Players> list = new List<Players>();
			foreach (Players value in World.allConnectedChars.Values)
			{
				list.Add(value);
			}
			foreach (Players item in list)
			{
				try
				{
					if (item.Client != null)
					{
						item.Client.Dispose();
					}
				}
				catch (Exception ex)
				{
					WriteLine(1, "保存人物的数据  错误" + ex.Message);
				}
			}
			list.Clear();
		}

		private void 狮子吼事件(object sender, ElapsedEventArgs e)
		{
			World.Process狮子吼Queue();
		}

		private static void Thread1()
		{
			try
			{
				LuaFunction function = World.脚本.pLuaVM.GetFunction("OpenItmeTrigGer");
				if (function != null)
				{
					object[] args = new object[4]
					{
						0,
						100,
						0,
						1
					};
					function.Call(args);
				}
			}
			catch (Exception value)
			{
				Console.WriteLine(value);
			}
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				if (World.SqlPool.Count > 0)
				{
					if (MessageBox.Show("数据列队还没有完成  " + World.SqlPool.Count, "数据列队还没有完成", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
					{
						runn = true;
						timerThread.Abort();
						thThreadRead.Abort();
						if (l != null)
						{
							l.Dispose();
							l = null;
						}
					}
					else
					{
						e.Cancel = true;
					}
				}
				else if (World.allConnectedChars.Count > 0)
				{
					if (MessageBox.Show("有人物在线  " + World.allConnectedChars.Count, "还有人物在线", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
					{
						runn = true;
						timerThread.Abort();
						thThreadRead.Abort();
						if (l != null)
						{
							l.Dispose();
							l = null;
						}
					}
					else
					{
						e.Cancel = true;
					}
				}
				else
				{
					runn = true;
					timerThread.Abort();
					thThreadRead.Abort();
					ClassDllImport.FreeLib();
					if (l != null)
					{
						l.Dispose();
						l = null;
					}
				}
			}
			catch
			{
			}
		}

		private void FlushAll()
		{
			try
			{
				while (!runn)
				{
					if (World.自动开启连接 && World.list.Count - World.allConnectedChars.Count > World.允许最大连接数)
					{
						if (l != null)
						{
							l.Stop();
							l = null;
						}
						Random random = new Random();
						World.游戏服务器端口1 = World.游戏服务器端口 + random.Next(10, 200);
						l = new RxjhServer.Network.Listener((ushort)World.游戏服务器端口1);
						World.端口更换通知();
					}
					Timer.Slice();
					Thread.Sleep(1);
					World.ProcessSqlQueue();
				}
			}
			catch (Exception ex)
			{
				WriteLine(1, "FlushAll  错误" + ex.Message);
				if (!runn)
				{
					thThreadRead = new Thread(FlushAll);
					thThreadRead.Name = "FlushAll";
					thThreadRead.Start();
				}
			}
		}

		public void 自动公告事件()
		{
			复查用户登陆();
			if (World.公告.Count > 0)
			{
				公告类 公告类 = World.公告[自动公告ID];
				公告发送(公告类.msg, 公告类.type);
				自动公告ID++;
				if (自动公告ID >= World.公告.Count)
				{
					自动公告ID = 0;
				}
			}
			if (World.自动存档 == 1)
			{
				menuItem17.PerformClick();
			}
			try
			{
				if (World.allConnectedChars.Count > World.list.Count)
				{
					Queue queue = Queue.Synchronized(new Queue());
					foreach (Players value2 in World.allConnectedChars.Values)
					{
						queue.Enqueue(value2);
					}
					while (queue.Count > 0)
					{
						Players players = (Players)queue.Dequeue();
						NetState value;
						if (!World.list.TryGetValue(players.人物全服ID, out value))
						{
							World.allConnectedChars.Remove(players.人物全服ID);
						}
					}
					if (World.allConnectedChars.Count > World.list.Count)
					{
						World.conn.Dispose();
						menuItem3.PerformClick();
						World.自动存档 = 0;
					}
				}
				if (World.是否开放九泉地图 == 1.0)
				{
					foreach (Players value3 in World.allConnectedChars.Values)
					{
						if (value3.人物坐标_地图 >= 23001 && value3.人物坐标_地图 <= 24000)
						{
							byte[] array = Converter.hexStringToByte("AA5516002C01121708000000000000000000000000000000558D55AA");
							System.Buffer.BlockCopy(BitConverter.GetBytes(World.王龙的金币), 0, array, 10, 8);
							if (value3.Client != null)
							{
								value3.Client.Send(array, array.Length);
							}
						}
					}
				}
				if (World.物品记录 == 1)
				{
					DBA.ExeSqlCommand("DELETE  FROM  物品记录  WHERE            DateDiff(dd,时间,getdate())>" + World.记录保存天数);
				}
				if (World.登陆记录 == 1)
				{
					DBA.ExeSqlCommand("DELETE  FROM  登陆记录  WHERE            DateDiff(dd,时间,getdate())>" + World.记录保存天数);
				}
				World.最大在线 = World.allConnectedChars.Count + int.Parse(Config.IniReadValue("GameServer", "最大在线").Trim());
				World.conn.发送("更新服务器配置|" + World.服务器ID + "|" + World.最大在线);
				World.week = (int)DateTime.Now.DayOfWeek;
			}
			catch
			{
			}
		}

		private void 公告发送(string txt, int type)
		{
			try
			{
				foreach (Players value in World.allConnectedChars.Values)
				{
					if (!value.Client.挂机 && value != null)
					{
						if (type == 0)
						{
							value.系统公告(txt);
						}
						else
						{
							value.系统滚动公告(txt);
						}
					}
				}
			}
			catch (Exception ex)
			{
				WriteLine(1, "SetLogs  错误" + ex.Message);
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			GraphPanel.Invalidate();
			statusBarPanel1.Text = "连接:" + World.list.Count + "  在线:" + World.allConnectedChars.Count + "  离线商店:" + World.离线数量;
			StatusBarPanel statusBarPanel = statusBarPanel2;
			string str = World.ItmeTeM.Count.ToString();
			string str2 = MapClass.GetNpcConn().ToString();
			string text2 = statusBarPanel.Text = "地图物品:" + str + "  怪物:" + str2;
			double 接收速度 = World.接收速度;
			double 发送速度 = World.发送速度;
			double 广播发送速度 = World.广播发送速度;
			string text3 = (!(接收速度 >= 1024.0)) ? (Math.Round(接收速度, 0) + "B") : (Math.Round(World.接收速度 / 1024.0, 0) + "K");
			string text4 = text3;
			string text5 = (!(发送速度 >= 1024.0)) ? (Math.Round(发送速度, 0) + "B") : (Math.Round(World.发送速度 / 1024.0, 0) + "K");
			string text6 = text5;
			if (广播发送速度 >= 1024.0)
			{
				string text9 = Math.Round(World.广播发送速度 / 1024.0, 0) + "K";
			}
			else
			{
				string text10 = Math.Round(广播发送速度, 0) + "B";
			}
			statusBarPanel3.Text = "收:" + text4 + "/s  发:" + text6 + "/s  包:" + Converter.Hexstring.Count;
			World.接收速度 = 0.0;
			World.发送速度 = 0.0;
			World.广播发送速度 = 0.0;
			TimeSpan timeSpan = DateTime.Now.Subtract(sj);
			string text8 = statusBarPanel4.Text = timeSpan.Days + "天" + timeSpan.Hours + "时" + timeSpan.Minutes + "分" + timeSpan.Seconds + "秒";
		}

		private void menuItem29_Click(object sender, EventArgs e)
		{
			if (!runn)
			{
				runn = true;
				timerThread.Abort();
				thThreadRead.Abort();
				return;
			}
			thThreadRead = new Thread(FlushAll);
			thThreadRead.Name = "FlushAll";
			thThreadRead.Start();
			timerThread = new Thread(new Timer.TimerThread().TimerMain);
			timerThread.Name = "Timer  Thread";
			timerThread.Start();
		}

		private void menuItem5_Click(object sender, EventArgs e)
		{
			new UserList().ShowDialog();
		}

		private void menuItem27_Click(object sender, EventArgs e)
		{
			new FormUser组队().ShowDialog();
		}

		private void menuItem7_Click(object sender, EventArgs e)
		{
			world.SetDrop();
			world.SetOpen();
			world.Set套装();
			world.SetBbgItem();
			world.SetLever();
			world.SetKONGFU();
			world.SetItme();
			world.SetShop();
			world.SetMover();
			world.Set公告();
			world.Set等级奖励();
			world.Set物品兑换();
			world.Set石头属性();
			world.Set移动();
		}

		private void menuItem8_Click(object sender, EventArgs e)
		{
			Queue queue = Queue.Synchronized(new Queue());
			foreach (MapClass value in World.Map.Values)
			{
				foreach (NpcClass value2 in value.npcTemplate.Values)
				{
					queue.Enqueue(value2);
				}
			}
			while (queue.Count > 0)
			{
				((NpcClass)queue.Dequeue()).Dispose();
			}
			world.SetNpc();
		}

		private void menuItem9_Click(object sender, EventArgs e)
		{
			world.SetDrop();
		}

		private void menuItem10_Click(object sender, EventArgs e)
		{
			world.SetOpen();
		}

		private void menuItem11_Click(object sender, EventArgs e)
		{
			world.SetItme();
		}

		private void menuItem12_Click(object sender, EventArgs e)
		{
			world.SetShop();
		}

		private void menuItem13_Click(object sender, EventArgs e)
		{
			world.SetMover();
		}

		private void menuItem14_Click(object sender, EventArgs e)
		{
			world.Set公告();
		}

		private void menuItem15_Click(object sender, EventArgs e)
		{
			if (menuItem15.Checked)
			{
				menuItem15.Checked = false;
				World.Log = 0;
			}
			else
			{
				menuItem15.Checked = true;
				World.Log = 1;
			}
		}

		private void menuItem26_Click(object sender, EventArgs e)
		{
			if (menuItem26.Checked)
			{
				menuItem26.Checked = false;
				World.jlMsg = 0;
			}
			else
			{
				menuItem26.Checked = true;
				World.jlMsg = 1;
			}
		}

		private void menuItem16_Click(object sender, EventArgs e)
		{
			world.SetConfig();
			World.最大在线 = World.allConnectedChars.Count + int.Parse(Config.IniReadValue("GameServer", "最大在线").Trim());
			World.conn.发送("更新服务器配置|" + World.服务器ID + "|" + World.最大在线);
			WriteLine(2, "重新加载服务器配置文件完成");
		}

		private void menuItem17_Click(object sender, EventArgs e)
		{
			List<Players> list = new List<Players>();
			foreach (Players value in World.allConnectedChars.Values)
			{
				list.Add(value);
			}
			foreach (Players item in list)
			{
				try
				{
					item.保存人物的数据();
				}
				catch (Exception ex)
				{
					WriteLine(1, "保存人物的数据  错误" + ex.Message);
				}
			}
			list.Clear();
			WriteLine(8, "保存人物的数据  完成");
		}

		private void menuItem18_Click(object sender, EventArgs e)
		{
			if (menuItem18.Checked)
			{
				menuItem18.Checked = false;
				World.验证服务器log = 0;
			}
			else
			{
				menuItem18.Checked = true;
				World.验证服务器log = 1;
			}
		}

		private void menuItem19_Click(object sender, EventArgs e)
		{
			if (menuItem19.Checked)
			{
				menuItem19.Checked = false;
				World.jllog = 0;
			}
			else
			{
				menuItem19.Checked = true;
				World.jllog = 1;
			}
		}

		private void menuItem20_Click(object sender, EventArgs e)
		{
			if (menuItem20.Checked)
			{
				menuItem20.Checked = false;
				World.AlWorldlog = false;
			}
			else
			{
				menuItem20.Checked = true;
				World.AlWorldlog = true;
			}
		}

		private void menuItem21_Click(object sender, EventArgs e)
		{
			try
			{
				if (menuItem21.Checked)
				{
					menuItem21.Checked = false;
					World.AllItmelog = 0;
				}
				else
				{
					menuItem21.Checked = true;
					World.AllItmelog = 1;
				}
			}
			catch (Exception ex)
			{
				WriteLine(1, "查物品错误                        错误" + ex.Message);
			}
		}

		private void menuItem22_Click(object sender, EventArgs e)
		{
			world.SetMonSter();
		}

		private void menuItem23_Click(object sender, EventArgs e)
		{
			world.SetBossDrop();
		}

		private void menuItem25_Click(object sender, EventArgs e)
		{
			world.Set_GSDrop();
		}

		private void menuItem28_Click(object sender, EventArgs e)
		{
			world.SetKill();
			world.SetJianc();
		}

		private void menuItem30_Click(object sender, EventArgs e)
		{
			world.SetKONGFU();
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			try
			{
				byte[] array = Converter.hexStringToByte2(toolStripTextBox1.Text);
				foreach (NetState value in World.list.Values)
				{
					if (value != null)
					{
						if (toolStripComboBox2.Text == "正常")
						{
							System.Buffer.BlockCopy(BitConverter.GetBytes(value.WorldId), 0, array, 5, 2);
							value.Send单包(array, array.Length);
						}
						else
						{
							value.Send多包(array, array.Length);
						}
					}
				}
			}
			catch
			{
			}
			aaa++;
		}

		public void Send单包(byte[] toSendBuff, int len)
		{
			byte[] array = new byte[BitConverter.ToInt16(toSendBuff, 9) + 7];
			System.Buffer.BlockCopy(toSendBuff, 5, array, 0, array.Length);
			Send封装发送(array, array.Length);
		}

		private void Send封装发送(byte[] toSendBuff, int length)
		{
			byte[] array = new byte[length + 15];
			array[0] = 170;
			array[1] = 85;
			System.Buffer.BlockCopy(BitConverter.GetBytes(length + 9), 0, array, 2, 2);
			System.Buffer.BlockCopy(toSendBuff, 0, array, 5, length);
			array[array.Length - 2] = 85;
			array[array.Length - 1] = 170;
		}

		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (Players value in World.allConnectedChars.Values)
				{
					if (value != null)
					{
						value.系统提示(toolStripTextBox2.Text, int.Parse(toolStripComboBox1.SelectedItem.ToString()), "系统信息");
					}
				}
			}
			catch
			{
			}
		}

		private void toolStripButton3_Click(object sender, EventArgs e)
		{
			复查用户登陆();
		}

		private void toolStripButton4_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (MapClass value in World.Map.Values)
				{
					foreach (NpcClass value2 in value.npcTemplate.Values)
					{
						value2.getbl();
					}
				}
				foreach (组队Class value3 in World.W组队.Values)
				{
					WriteLine(2, "组队:" + value3.组队id + "  人物：" + value3.队员列表.Count);
					foreach (Players value4 in value3.队员列表.Values)
					{
						WriteLine(2, "组队员:" + value4.Userid + "  人物：" + value4.UserName);
					}
				}
				foreach (Players value5 in World.allConnectedChars.Values)
				{
					Players player = value5;
				}
				foreach (object item in World.locklist3)
				{
					WriteLine(2, item.ToString());
				}
			}
			catch (Exception ex)
			{
				WriteLine(1, ex.ToString());
			}
			GC.Collect();
		}

		public void 复查用户登陆()
		{
			try
			{
				StringBuilder stringBuilder = new StringBuilder();
				foreach (NetState value12 in World.list.Values)
				{
					string value = "NULL";
					int value2 = 0;
					if (value12.挂机)
					{
						value2 = 1;
					}
					int value3 = 0;
					string value4 = string.Empty;
					string value5 = string.Empty;
					int value6 = 0;
					string value7 = string.Empty;
					string value8 = string.Empty;
					int value9 = 0;
					int value10 = 0;
					Players players = World.检查玩家世界ID(value12.WorldId);
					if (players != null)
					{
						value = players.UserName;
						value3 = players.原服务器序号;
						value4 = players.原服务器IP;
						value5 = players.原服务器端口.ToString();
						value6 = players.原服务器ID;
						value7 = players.银币广场服务器IP;
						value8 = players.银币广场服务器端口.ToString();
						value10 = players.Player_Job;
						公有药品类 value11;
						if (players.公有药品.TryGetValue(1008000027, out value11))
						{
							value9 = 1;
						}
					}
					stringBuilder.Append(value12.Player.Userid);
					stringBuilder.Append("-");
					stringBuilder.Append(value12.ToString());
					stringBuilder.Append("-");
					stringBuilder.Append(value12.绑定帐号);
					stringBuilder.Append("-");
					stringBuilder.Append(value2);
					stringBuilder.Append("-");
					stringBuilder.Append(value);
					stringBuilder.Append("-");
					stringBuilder.Append(value3);
					stringBuilder.Append("-");
					stringBuilder.Append(value4);
					stringBuilder.Append("-");
					stringBuilder.Append(value5);
					stringBuilder.Append("-");
					stringBuilder.Append(value6);
					stringBuilder.Append("-");
					stringBuilder.Append(value7);
					stringBuilder.Append("-");
					stringBuilder.Append(value8);
					stringBuilder.Append("-");
					stringBuilder.Append(value12.WorldId);
					stringBuilder.Append("-");
					stringBuilder.Append(value9);
					stringBuilder.Append("-");
					stringBuilder.Append(value10);
					stringBuilder.Append(",");
				}
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Remove(stringBuilder.Length - 1, 1);
				}
				World.conn.发送("复查用户登陆|" + ((stringBuilder != null) ? stringBuilder.ToString() : null));
				if (World.AutGC != 0)
				{
					GC.Collect();
				}
			}
			catch (Exception ex)
			{
				WriteLine(1, "复查用户登陆    错误" + ex.Message);
			}
		}

		private void GraphPanel_Paint(object sender, PaintEventArgs e)
		{
			try
			{
				Graphics graphics = e.Graphics;
				graphics.SmoothingMode = SmoothingMode.AntiAlias;
				graphics.PixelOffsetMode = PixelOffsetMode.None;
				string s = "连接:" + World.list.Count + "/" + World.最大在线 + "  在线:" + World.allConnectedChars.Count + "  主Socket:" + World.主Socket + "  SocketState:" + World.SocketState + "  组队:" + World.W组队.Count + "  离线队列:" + World.m_Disposed.Count + "  数据库队列:" + World.SqlPool.Count + "  狮子列队:" + World.狮子吼List.Count;
				graphics.DrawString(s, Control.DefaultFont, Brushes.Black, new Point(20, 5));
				int num = 0;
				foreach (TxtClass item in txt)
				{
					switch (item.type)
					{
					default:
						graphics.DrawString(item.Txt, Control.DefaultFont, Brushes.Black, new Point(5, num += 17));
						break;
					case 0:
						graphics.DrawString(item.Txt, Control.DefaultFont, Brushes.Black, new Point(5, num += 17));
						break;
					case 1:
						graphics.DrawString(item.Txt, Control.DefaultFont, Brushes.Red, new Point(5, num += 17));
						break;
					case 2:
						graphics.DrawString(item.Txt, Control.DefaultFont, Brushes.Black, new Point(5, num += 17));
						break;
					case 3:
						graphics.DrawString(item.Txt, Control.DefaultFont, Brushes.Green, new Point(5, num += 17));
						break;
					case 4:
						graphics.DrawString(item.Txt, Control.DefaultFont, Brushes.Teal, new Point(5, num += 17));
						break;
					case 5:
						graphics.DrawString(item.Txt, Control.DefaultFont, Brushes.DodgerBlue, new Point(5, num += 17));
						break;
					case 6:
						graphics.DrawString(item.Txt, Control.DefaultFont, Brushes.Blue, new Point(5, num += 17));
						break;
					}
				}
			}
			catch
			{
			}
		}

		public static void WriteLine(int type, string txtt)
		{
			int num = kjdx / 18;
			lock (txt)
			{
				switch (type)
				{
				default:
					if (World.AlWorldlog)
					{
						if (World.jllog == 1)
						{
							switch (type)
							{
							case 1:
								logo.FileTxtLog(txtt);
								break;
							case 2:
								logo.FileCQTxtLog(txtt);
								break;
							case 3:
								logo.FileLoninTxtLog(txtt);
								break;
							case 4:
								logo.FileDropItmeTxtLog(txtt);
								break;
							case 5:
								logo.FileItmeTxtLog(txtt);
								break;
							case 6:
								logo.FileBugTxtLog(txtt);
								break;
							case 7:
								logo.FilePakTxtLog(txtt);
								break;
							case 8:
								logo.SeveTxtLog(txtt);
								break;
							}
						}
						switch (type)
						{
						case 99:
							logo.FileTxtLog(txtt);
							break;
						case 88:
							logo.pzTxtLog(txtt);
							break;
						case 77:
							logo.cfzTxtLog(txtt);
							break;
						}
						txt.Add(new TxtClass(type, DateTime.Now.ToString() + "  " + txtt));
						int count2 = txt.Count;
						if (num <= 0)
						{
							num = 20;
						}
						if (count2 > num)
						{
							for (int j = 0; j < count2 - num; j++)
							{
								txt.RemoveAt(0);
							}
						}
					}
					break;
				case 101:
				{
					logo.WGTxtLog(txtt);
					txt.Add(new TxtClass(type, DateTime.Now.ToString() + "  " + txtt));
					int count3 = txt.Count;
					if (num <= 0)
					{
						num = 20;
					}
					if (count3 > num)
					{
						for (int k = 0; k < count3 - num; k++)
						{
							txt.RemoveAt(0);
						}
					}
					break;
				}
				case 100:
				{
					logo.FileTxtLog(txtt);
					txt.Add(new TxtClass(type, DateTime.Now.ToString() + "  " + txtt));
					int count = txt.Count;
					if (num <= 0)
					{
						num = 20;
					}
					if (count > num)
					{
						for (int i = 0; i < count - num; i++)
						{
							txt.RemoveAt(0);
						}
					}
					break;
				}
				case 9:
					logo.zhtfTxtLog(txtt);
					break;
				}
			}
		}

		private void menuItem31_Click(object sender, EventArgs e)
		{
			new BinIP().ShowDialog();
		}

		private void menuItem33_Click(object sender, EventArgs e)
		{
			Thread thread = new Thread(Form2.FlushAll1);
			thread.Name = "Timer  Thread";
			thread.Start();
		}

		private void menuItem34_Click(object sender, EventArgs e)
		{
			Thread thread = new Thread(Form2.FlushAll2);
			thread.Name = "Timer  Thread";
			thread.Start();
		}

		private void menuItem35_Click(object sender, EventArgs e)
		{
			Thread thread = new Thread(Form2.FlushAll3);
			thread.Name = "Timer  Thread";
			thread.Start();
		}

		private void menuItem36_Click(object sender, EventArgs e)
		{
			Thread thread = new Thread(Form2.FlushAll4);
			thread.Name = "Timer  Thread";
			thread.Start();
		}

		private void Form1_Layout(object sender, LayoutEventArgs e)
		{
			if (GraphPanel.Height != 0)
			{
				kjdx = GraphPanel.Height;
			}
		}

		private void menuItem37_Click(object sender, EventArgs e)
		{
			new Form2().ShowDialog();
		}

		private void menuItem38_Click(object sender, EventArgs e)
		{
			if (menuItem38.Checked)
			{
				menuItem38.Checked = false;
				World.Droplog = false;
			}
			else
			{
				menuItem38.Checked = true;
				World.Droplog = true;
			}
		}

		private void menuItem39_Click(object sender, EventArgs e)
		{
			world.SetScript();
		}

		private void menuItem41_Click(object sender, EventArgs e)
		{
			new YbQForm().ShowDialog();
		}

		private void menuItem42_Click(object sender, EventArgs e)
		{
			world.Set制作物品();
		}

		private void menuItem43_Click(object sender, EventArgs e)
		{
			world.SetBbgItem();
		}

		private void menuItem44_Click(object sender, EventArgs e)
		{
			world.Set套装();
		}

		private void menuItem45_Click(object sender, EventArgs e)
		{
			world.Set等级奖励();
		}

		private void menuItem24_Click(object sender, EventArgs e)
		{
			world.Set物品兑换();
		}

		private void menuItem49_Click(object sender, EventArgs e)
		{
			new YbiForm().ShowDialog();
		}

		private void menuItem50_Click(object sender, EventArgs e)
		{
			world.Set移动();
		}

		private void menuItem52_Click(object sender, EventArgs e)
		{
			world.Set任务数据新();
		}

		private void menuItem46_Click(object sender, EventArgs e)
		{
			world.SetQG();
			world.Set升天气功();
		}

		private void menuItem48_Click(object sender, EventArgs e)
		{
			new NpcList().Show();
		}

		private void menuItem53_Click(object sender, EventArgs e)
		{
			world.Set石头属性();
		}

		private void menuItem54_Click(object sender, EventArgs e)
		{
			if (World.修炼之地开启ID == 0)
			{
				World.修炼之地开启ID = 1;
				World.全局提示("系统提示", 6, "修炼地区开启,修炼时间为2小时。");
				WriteLine(1, "修炼之地开启！");
				menuItem54.Text = "结束修炼之地";
			}
			else
			{
				World.修炼之地开启ID = 0;
				World.全局提示("系统提示", 6, "修炼时间结束。");
				WriteLine(1, "修炼之地结束！");
				menuItem54.Text = "开始修炼之地";
			}
		}

		private void menuItem55_Click(object sender, EventArgs e)
		{
			new StoneConfig().Show();
		}

		private void menuItem47_Click(object sender, EventArgs e)
		{
			new SkillContrl().Show();
		}

		private void menuItem57_Click(object sender, EventArgs e)
		{
			if (l != null)
			{
				new NetSet(l.Server).Show();
			}
		}

		private void menuItem58_Click(object sender, EventArgs e)
		{
			new BinIP().ShowDialog();
		}

		private void menuItem31_Click_1(object sender, EventArgs e)
		{
			try
			{
				foreach (Players value in World.allConnectedChars.Values)
				{
					if (value.Client != null)
					{
						value.保存人物的数据();
						value.保存个人仓库存储过程();
						value.保存综合仓库存储过程();
					}
				}
			}
			catch (Exception ex)
			{
				WriteLine(1, "保存人物的数据出错|" + ex.Message);
			}
			WriteLine(6, "保存人物所有数据完成");
		}

		private void menuItem51_Click(object sender, EventArgs e)
		{
			if (World.攻城 == null)
			{
				WriteLine(2, "自动攻城战开启成功");
				World.攻城 = new 攻城Class();
			}
			else
			{
				World.攻城.Dispose();
				WriteLine(2, "攻城战结束");
			}
		}

		private void menuItem51_Click_1(object sender, EventArgs e)
		{
			if (World.攻城 == null)
			{
				WriteLine(2, "自动攻城战开启成功");
				World.攻城 = new 攻城Class();
			}
			else
			{
				World.攻城.Dispose();
				WriteLine(2, "攻城战结束");
			}
		}

		private void menuItem59_Click(object sender, EventArgs e)
		{
			if (World.eve == null)
			{
				World.仙魔战公告 = new 仙魔战循环公告();
				WriteLine(2, "仙魔大战开始啦再次点击关闭仙魔大战");
			}
			else
			{
				World.仙魔战公告.Dispose();
				WriteLine(2, "仙魔大战结束啦再次点击开启仙魔大战");
			}
		}
	}
}
