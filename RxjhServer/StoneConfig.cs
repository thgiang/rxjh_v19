using RxjhServer.DbClss;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace RxjhServer
{
	public class StoneConfig : Form
	{
		private IContainer components;

		private Label label22;

		private Label label21;

		private Label label20;

		private Label label19;

		private Label label18;

		private Label label17;

		private Label label16;

		private Label label15;

		private TextBox textBox12;

		private Button button1;

		private TextBox textBox13;

		private TextBox textBox14;

		private TextBox textBox15;

		private TextBox textBox16;

		private TextBox textBox17;

		private TextBox textBox18;

		private TextBox textBox19;

		private GroupBox groupBox2;

		private Label label1;

		private TextBox textBox2;

		private TextBox textBox1;

		private Label label2;

		private TextBox textBox3;

		private Label label3;

		private TextBox textBox44;

		private Label label44;

		private TextBox textBox33;

		private TextBox textBox34;

		private Label label32;

		private Label label33;

		private TextBox textBox10;

		private TextBox textBox11;

		private Label label10;

		private Label label11;

		private TextBox textBox8;

		private TextBox textBox9;

		private Label label8;

		private Label label9;

		private TextBox textBox6;

		private TextBox textBox7;

		private Label label6;

		private Label label7;

		private TextBox textBox4;

		private TextBox textBox5;

		private Label label4;

		private Label label5;

		private TextBox textBox26;

		private TextBox textBox27;

		private Label label26;

		private Label label27;

		private TextBox textBox28;

		private TextBox textBox29;

		private Label label28;

		private Label label29;

		private TextBox textBox30;

		private TextBox textBox31;

		private Label label30;

		private Label label31;

		private TextBox textBox20;

		private TextBox textBox21;

		private Label label12;

		private Label label13;

		private TextBox textBox22;

		private TextBox textBox23;

		private Label label14;

		private Label label23;

		private TextBox textBox24;

		private TextBox textBox25;

		private Label label24;

		private Label label25;

		public StoneConfig()
		{
			InitializeComponent();
		}

		private void 设置()
		{
			World.wf100 = int.Parse(textBox1.Text);
			World.wf95 = int.Parse(textBox3.Text);
			World.wf90 = int.Parse(textBox2.Text);
			World.wf85 = int.Parse(textBox12.Text);
			World.wf80 = int.Parse(textBox13.Text);
			World.wf78 = int.Parse(textBox14.Text);
			World.wf76 = int.Parse(textBox15.Text);
			World.wf74 = int.Parse(textBox16.Text);
			World.wf72 = int.Parse(textBox17.Text);
			World.wf70 = int.Parse(textBox18.Text);
			World.wf68 = int.Parse(textBox19.Text);
			World.wg35 = int.Parse(textBox5.Text);
			World.wg34 = int.Parse(textBox4.Text);
			World.wg33 = int.Parse(textBox7.Text);
			World.wg32 = int.Parse(textBox6.Text);
			World.wg31 = int.Parse(textBox9.Text);
			World.wg30 = int.Parse(textBox8.Text);
			World.wg29 = int.Parse(textBox11.Text);
			World.wg28 = int.Parse(textBox10.Text);
			World.wg27 = int.Parse(textBox44.Text);
			World.wg26 = int.Parse(textBox34.Text);
			World.wg25 = int.Parse(textBox33.Text);
			World.g25 = int.Parse(textBox25.Text);
			World.g24 = int.Parse(textBox24.Text);
			World.g23 = int.Parse(textBox23.Text);
			World.g22 = int.Parse(textBox22.Text);
			World.g21 = int.Parse(textBox21.Text);
			World.g20 = int.Parse(textBox20.Text);
			World.f15 = int.Parse(textBox31.Text);
			World.f14 = int.Parse(textBox30.Text);
			World.f13 = int.Parse(textBox29.Text);
			World.f12 = int.Parse(textBox28.Text);
			World.f11 = int.Parse(textBox27.Text);
			World.f10 = int.Parse(textBox26.Text);
		}

		private int 写数据(int type, int value, int 增减)
		{
			string string_ = string.Format("UPDATE TBL_XWWL_STONE SET FLD_增减={0} WHERE FLD_TYPE={1} and FLD_VALUE={2}", 增减, type, value);
			try
			{
				if (DBA.ExeSqlCommand(string_, "PublicDb") == -1)
				{
					MessageBox.Show("写入表错误0,请检查|" + type + "|" + value + "|" + 增减);
					return -1;
				}
			}
			catch
			{
				MessageBox.Show("写入表错误1,请检查|" + type + "|" + value + "|" + 增减);
			}
			return -1;
		}

		private void 写入()
		{
			写数据(11, 100, int.Parse(textBox1.Text));
			Thread.Sleep(2);
			写数据(11, 95, int.Parse(textBox3.Text));
			Thread.Sleep(2);
			写数据(11, 90, int.Parse(textBox2.Text));
			Thread.Sleep(2);
			写数据(11, 85, int.Parse(textBox12.Text));
			Thread.Sleep(2);
			写数据(11, 80, int.Parse(textBox13.Text));
			Thread.Sleep(2);
			写数据(11, 78, int.Parse(textBox14.Text));
			Thread.Sleep(2);
			写数据(11, 76, int.Parse(textBox15.Text));
			Thread.Sleep(2);
			写数据(11, 74, int.Parse(textBox16.Text));
			Thread.Sleep(2);
			写数据(11, 72, int.Parse(textBox17.Text));
			Thread.Sleep(2);
			写数据(11, 70, int.Parse(textBox18.Text));
			Thread.Sleep(2);
			写数据(11, 68, int.Parse(textBox19.Text));
			Thread.Sleep(2);
			写数据(7, 35, int.Parse(textBox5.Text));
			Thread.Sleep(2);
			写数据(7, 34, int.Parse(textBox4.Text));
			Thread.Sleep(2);
			写数据(7, 33, int.Parse(textBox7.Text));
			Thread.Sleep(2);
			写数据(7, 32, int.Parse(textBox6.Text));
			Thread.Sleep(2);
			写数据(7, 31, int.Parse(textBox9.Text));
			Thread.Sleep(2);
			写数据(7, 30, int.Parse(textBox8.Text));
			Thread.Sleep(2);
			写数据(7, 29, int.Parse(textBox11.Text));
			Thread.Sleep(2);
			写数据(7, 28, int.Parse(textBox10.Text));
			Thread.Sleep(2);
			写数据(7, 27, int.Parse(textBox44.Text));
			Thread.Sleep(2);
			写数据(7, 26, int.Parse(textBox34.Text));
			Thread.Sleep(2);
			写数据(7, 25, int.Parse(textBox33.Text));
			Thread.Sleep(2);
			写数据(1, 25, int.Parse(textBox25.Text));
			Thread.Sleep(2);
			写数据(1, 24, int.Parse(textBox24.Text));
			Thread.Sleep(2);
			写数据(1, 23, int.Parse(textBox23.Text));
			Thread.Sleep(2);
			写数据(1, 22, int.Parse(textBox22.Text));
			Thread.Sleep(2);
			写数据(1, 21, int.Parse(textBox21.Text));
			Thread.Sleep(2);
			写数据(1, 20, int.Parse(textBox20.Text));
			Thread.Sleep(2);
			写数据(2, 15, int.Parse(textBox31.Text));
			Thread.Sleep(2);
			写数据(2, 14, int.Parse(textBox30.Text));
			Thread.Sleep(2);
			写数据(2, 13, int.Parse(textBox29.Text));
			Thread.Sleep(2);
			写数据(2, 12, int.Parse(textBox28.Text));
			Thread.Sleep(2);
			写数据(2, 11, int.Parse(textBox27.Text));
			Thread.Sleep(2);
			写数据(2, 10, int.Parse(textBox26.Text));
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				设置();
				写入();
				Close();
			}
			catch
			{
				MessageBox.Show("输入错误,请检查!");
			}
		}

		private void 读取()
		{
			textBox1.Text = World.wf100.ToString();
			textBox3.Text = World.wf95.ToString();
			textBox2.Text = World.wf90.ToString();
			textBox12.Text = World.wf85.ToString();
			textBox13.Text = World.wf80.ToString();
			textBox14.Text = World.wf78.ToString();
			textBox15.Text = World.wf76.ToString();
			textBox16.Text = World.wf74.ToString();
			textBox17.Text = World.wf72.ToString();
			textBox18.Text = World.wf70.ToString();
			textBox19.Text = World.wf68.ToString();
			textBox5.Text = World.wg35.ToString();
			textBox4.Text = World.wg34.ToString();
			textBox7.Text = World.wg33.ToString();
			textBox6.Text = World.wg32.ToString();
			textBox9.Text = World.wg31.ToString();
			textBox8.Text = World.wg30.ToString();
			textBox11.Text = World.wg29.ToString();
			textBox10.Text = World.wg28.ToString();
			textBox44.Text = World.wg27.ToString();
			textBox34.Text = World.wg26.ToString();
			textBox33.Text = World.wg25.ToString();
			textBox25.Text = World.g25.ToString();
			textBox24.Text = World.g24.ToString();
			textBox23.Text = World.g23.ToString();
			textBox22.Text = World.g22.ToString();
			textBox21.Text = World.g21.ToString();
			textBox20.Text = World.g20.ToString();
			textBox31.Text = World.f15.ToString();
			textBox30.Text = World.f14.ToString();
			textBox29.Text = World.f13.ToString();
			textBox28.Text = World.f12.ToString();
			textBox27.Text = World.f11.ToString();
			textBox26.Text = World.f10.ToString();
		}

		private void StoneConfig_Load(object sender, EventArgs e)
		{
			读取();
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
			label22 = new System.Windows.Forms.Label();
			label21 = new System.Windows.Forms.Label();
			label20 = new System.Windows.Forms.Label();
			label19 = new System.Windows.Forms.Label();
			label18 = new System.Windows.Forms.Label();
			label17 = new System.Windows.Forms.Label();
			label16 = new System.Windows.Forms.Label();
			label15 = new System.Windows.Forms.Label();
			textBox12 = new System.Windows.Forms.TextBox();
			button1 = new System.Windows.Forms.Button();
			textBox13 = new System.Windows.Forms.TextBox();
			textBox14 = new System.Windows.Forms.TextBox();
			textBox15 = new System.Windows.Forms.TextBox();
			textBox16 = new System.Windows.Forms.TextBox();
			textBox17 = new System.Windows.Forms.TextBox();
			textBox18 = new System.Windows.Forms.TextBox();
			textBox19 = new System.Windows.Forms.TextBox();
			groupBox2 = new System.Windows.Forms.GroupBox();
			textBox26 = new System.Windows.Forms.TextBox();
			textBox27 = new System.Windows.Forms.TextBox();
			label26 = new System.Windows.Forms.Label();
			label27 = new System.Windows.Forms.Label();
			textBox28 = new System.Windows.Forms.TextBox();
			textBox29 = new System.Windows.Forms.TextBox();
			label28 = new System.Windows.Forms.Label();
			label29 = new System.Windows.Forms.Label();
			textBox30 = new System.Windows.Forms.TextBox();
			textBox31 = new System.Windows.Forms.TextBox();
			label30 = new System.Windows.Forms.Label();
			label31 = new System.Windows.Forms.Label();
			textBox20 = new System.Windows.Forms.TextBox();
			textBox21 = new System.Windows.Forms.TextBox();
			label12 = new System.Windows.Forms.Label();
			label13 = new System.Windows.Forms.Label();
			textBox22 = new System.Windows.Forms.TextBox();
			textBox23 = new System.Windows.Forms.TextBox();
			label14 = new System.Windows.Forms.Label();
			label23 = new System.Windows.Forms.Label();
			textBox24 = new System.Windows.Forms.TextBox();
			textBox25 = new System.Windows.Forms.TextBox();
			label24 = new System.Windows.Forms.Label();
			label25 = new System.Windows.Forms.Label();
			textBox44 = new System.Windows.Forms.TextBox();
			label44 = new System.Windows.Forms.Label();
			textBox33 = new System.Windows.Forms.TextBox();
			textBox34 = new System.Windows.Forms.TextBox();
			label32 = new System.Windows.Forms.Label();
			label33 = new System.Windows.Forms.Label();
			textBox10 = new System.Windows.Forms.TextBox();
			textBox11 = new System.Windows.Forms.TextBox();
			label10 = new System.Windows.Forms.Label();
			label11 = new System.Windows.Forms.Label();
			textBox8 = new System.Windows.Forms.TextBox();
			textBox9 = new System.Windows.Forms.TextBox();
			label8 = new System.Windows.Forms.Label();
			label9 = new System.Windows.Forms.Label();
			textBox6 = new System.Windows.Forms.TextBox();
			textBox7 = new System.Windows.Forms.TextBox();
			label6 = new System.Windows.Forms.Label();
			label7 = new System.Windows.Forms.Label();
			textBox4 = new System.Windows.Forms.TextBox();
			textBox5 = new System.Windows.Forms.TextBox();
			label4 = new System.Windows.Forms.Label();
			label5 = new System.Windows.Forms.Label();
			textBox3 = new System.Windows.Forms.TextBox();
			label3 = new System.Windows.Forms.Label();
			textBox2 = new System.Windows.Forms.TextBox();
			textBox1 = new System.Windows.Forms.TextBox();
			label2 = new System.Windows.Forms.Label();
			label1 = new System.Windows.Forms.Label();
			groupBox2.SuspendLayout();
			SuspendLayout();
			label22.AutoSize = true;
			label22.Location = new System.Drawing.Point(23, 103);
			label22.Name = "label22";
			label22.Size = new System.Drawing.Size(29, 12);
			label22.TabIndex = 11;
			label22.Text = "WF85";
			label21.AutoSize = true;
			label21.Location = new System.Drawing.Point(23, 128);
			label21.Name = "label21";
			label21.Size = new System.Drawing.Size(29, 12);
			label21.TabIndex = 12;
			label21.Text = "WF80";
			label20.AutoSize = true;
			label20.Location = new System.Drawing.Point(23, 153);
			label20.Name = "label20";
			label20.Size = new System.Drawing.Size(29, 12);
			label20.TabIndex = 13;
			label20.Text = "WF78";
			label19.AutoSize = true;
			label19.Location = new System.Drawing.Point(23, 178);
			label19.Name = "label19";
			label19.Size = new System.Drawing.Size(29, 12);
			label19.TabIndex = 14;
			label19.Text = "WF76";
			label18.AutoSize = true;
			label18.Location = new System.Drawing.Point(23, 203);
			label18.Name = "label18";
			label18.Size = new System.Drawing.Size(29, 12);
			label18.TabIndex = 15;
			label18.Text = "WF74";
			label17.AutoSize = true;
			label17.Location = new System.Drawing.Point(23, 228);
			label17.Name = "label17";
			label17.Size = new System.Drawing.Size(29, 12);
			label17.TabIndex = 16;
			label17.Text = "WF72";
			label16.AutoSize = true;
			label16.Location = new System.Drawing.Point(23, 253);
			label16.Name = "label16";
			label16.Size = new System.Drawing.Size(29, 12);
			label16.TabIndex = 17;
			label16.Text = "WF70";
			label15.AutoSize = true;
			label15.Location = new System.Drawing.Point(23, 278);
			label15.Name = "label15";
			label15.Size = new System.Drawing.Size(29, 12);
			label15.TabIndex = 18;
			label15.Text = "WF68";
			textBox12.Location = new System.Drawing.Point(58, 100);
			textBox12.MaxLength = 3;
			textBox12.Name = "textBox12";
			textBox12.Size = new System.Drawing.Size(50, 21);
			textBox12.TabIndex = 19;
			textBox12.Text = "0";
			button1.Location = new System.Drawing.Point(90, 315);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(63, 29);
			button1.TabIndex = 53;
			button1.Text = "保存";
			button1.UseVisualStyleBackColor = true;
			button1.Click += new System.EventHandler(button1_Click);
			textBox13.Location = new System.Drawing.Point(58, 125);
			textBox13.MaxLength = 3;
			textBox13.Name = "textBox13";
			textBox13.Size = new System.Drawing.Size(50, 21);
			textBox13.TabIndex = 54;
			textBox13.Text = "0";
			textBox14.Location = new System.Drawing.Point(58, 150);
			textBox14.MaxLength = 3;
			textBox14.Name = "textBox14";
			textBox14.Size = new System.Drawing.Size(50, 21);
			textBox14.TabIndex = 55;
			textBox14.Text = "0";
			textBox15.Location = new System.Drawing.Point(58, 175);
			textBox15.MaxLength = 3;
			textBox15.Name = "textBox15";
			textBox15.Size = new System.Drawing.Size(50, 21);
			textBox15.TabIndex = 56;
			textBox15.Text = "0";
			textBox16.Location = new System.Drawing.Point(58, 200);
			textBox16.MaxLength = 3;
			textBox16.Name = "textBox16";
			textBox16.Size = new System.Drawing.Size(50, 21);
			textBox16.TabIndex = 57;
			textBox16.Text = "0";
			textBox17.Location = new System.Drawing.Point(58, 225);
			textBox17.MaxLength = 3;
			textBox17.Name = "textBox17";
			textBox17.Size = new System.Drawing.Size(50, 21);
			textBox17.TabIndex = 58;
			textBox17.Text = "0";
			textBox18.Location = new System.Drawing.Point(58, 250);
			textBox18.MaxLength = 3;
			textBox18.Name = "textBox18";
			textBox18.Size = new System.Drawing.Size(50, 21);
			textBox18.TabIndex = 59;
			textBox18.Text = "0";
			textBox19.Location = new System.Drawing.Point(58, 275);
			textBox19.MaxLength = 3;
			textBox19.Name = "textBox19";
			textBox19.Size = new System.Drawing.Size(50, 21);
			textBox19.TabIndex = 60;
			textBox19.Text = "0";
			groupBox2.Controls.Add(textBox26);
			groupBox2.Controls.Add(textBox27);
			groupBox2.Controls.Add(label26);
			groupBox2.Controls.Add(label27);
			groupBox2.Controls.Add(textBox28);
			groupBox2.Controls.Add(textBox29);
			groupBox2.Controls.Add(label28);
			groupBox2.Controls.Add(label29);
			groupBox2.Controls.Add(textBox30);
			groupBox2.Controls.Add(textBox31);
			groupBox2.Controls.Add(label30);
			groupBox2.Controls.Add(label31);
			groupBox2.Controls.Add(textBox20);
			groupBox2.Controls.Add(textBox21);
			groupBox2.Controls.Add(label12);
			groupBox2.Controls.Add(label13);
			groupBox2.Controls.Add(textBox22);
			groupBox2.Controls.Add(textBox23);
			groupBox2.Controls.Add(label14);
			groupBox2.Controls.Add(label23);
			groupBox2.Controls.Add(textBox24);
			groupBox2.Controls.Add(textBox25);
			groupBox2.Controls.Add(label24);
			groupBox2.Controls.Add(label25);
			groupBox2.Controls.Add(textBox44);
			groupBox2.Controls.Add(label44);
			groupBox2.Controls.Add(textBox33);
			groupBox2.Controls.Add(textBox34);
			groupBox2.Controls.Add(label32);
			groupBox2.Controls.Add(label33);
			groupBox2.Controls.Add(textBox10);
			groupBox2.Controls.Add(textBox11);
			groupBox2.Controls.Add(label10);
			groupBox2.Controls.Add(label11);
			groupBox2.Controls.Add(textBox8);
			groupBox2.Controls.Add(textBox9);
			groupBox2.Controls.Add(label8);
			groupBox2.Controls.Add(label9);
			groupBox2.Controls.Add(textBox6);
			groupBox2.Controls.Add(textBox7);
			groupBox2.Controls.Add(label6);
			groupBox2.Controls.Add(label7);
			groupBox2.Controls.Add(textBox4);
			groupBox2.Controls.Add(textBox5);
			groupBox2.Controls.Add(label4);
			groupBox2.Controls.Add(label5);
			groupBox2.Controls.Add(textBox3);
			groupBox2.Controls.Add(label3);
			groupBox2.Controls.Add(textBox2);
			groupBox2.Controls.Add(textBox1);
			groupBox2.Controls.Add(label2);
			groupBox2.Controls.Add(label1);
			groupBox2.Controls.Add(textBox19);
			groupBox2.Controls.Add(textBox18);
			groupBox2.Controls.Add(textBox17);
			groupBox2.Controls.Add(textBox16);
			groupBox2.Controls.Add(textBox15);
			groupBox2.Controls.Add(textBox14);
			groupBox2.Controls.Add(textBox13);
			groupBox2.Controls.Add(button1);
			groupBox2.Controls.Add(textBox12);
			groupBox2.Controls.Add(label15);
			groupBox2.Controls.Add(label16);
			groupBox2.Controls.Add(label17);
			groupBox2.Controls.Add(label18);
			groupBox2.Controls.Add(label19);
			groupBox2.Controls.Add(label20);
			groupBox2.Controls.Add(label21);
			groupBox2.Controls.Add(label22);
			groupBox2.Location = new System.Drawing.Point(12, 12);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new System.Drawing.Size(350, 362);
			groupBox2.TabIndex = 1;
			groupBox2.TabStop = false;
			textBox26.Location = new System.Drawing.Point(279, 300);
			textBox26.MaxLength = 3;
			textBox26.Name = "textBox26";
			textBox26.Size = new System.Drawing.Size(50, 21);
			textBox26.TabIndex = 142;
			textBox26.Text = "0";
			textBox27.Location = new System.Drawing.Point(279, 275);
			textBox27.MaxLength = 3;
			textBox27.Name = "textBox27";
			textBox27.Size = new System.Drawing.Size(50, 21);
			textBox27.TabIndex = 141;
			textBox27.Text = "0";
			label26.AutoSize = true;
			label26.Location = new System.Drawing.Point(244, 303);
			label26.Name = "label26";
			label26.Size = new System.Drawing.Size(23, 12);
			label26.TabIndex = 140;
			label26.Text = "F10";
			label27.AutoSize = true;
			label27.Location = new System.Drawing.Point(244, 278);
			label27.Name = "label27";
			label27.Size = new System.Drawing.Size(23, 12);
			label27.TabIndex = 139;
			label27.Text = "F11";
			textBox28.Location = new System.Drawing.Point(279, 250);
			textBox28.MaxLength = 3;
			textBox28.Name = "textBox28";
			textBox28.Size = new System.Drawing.Size(50, 21);
			textBox28.TabIndex = 138;
			textBox28.Text = "0";
			textBox29.Location = new System.Drawing.Point(279, 225);
			textBox29.MaxLength = 3;
			textBox29.Name = "textBox29";
			textBox29.Size = new System.Drawing.Size(50, 21);
			textBox29.TabIndex = 137;
			textBox29.Text = "0";
			label28.AutoSize = true;
			label28.Location = new System.Drawing.Point(244, 253);
			label28.Name = "label28";
			label28.Size = new System.Drawing.Size(23, 12);
			label28.TabIndex = 136;
			label28.Text = "F12";
			label29.AutoSize = true;
			label29.Location = new System.Drawing.Point(244, 228);
			label29.Name = "label29";
			label29.Size = new System.Drawing.Size(23, 12);
			label29.TabIndex = 135;
			label29.Text = "F13";
			textBox30.Location = new System.Drawing.Point(279, 200);
			textBox30.MaxLength = 3;
			textBox30.Name = "textBox30";
			textBox30.Size = new System.Drawing.Size(50, 21);
			textBox30.TabIndex = 134;
			textBox30.Text = "0";
			textBox31.Location = new System.Drawing.Point(279, 175);
			textBox31.MaxLength = 3;
			textBox31.Name = "textBox31";
			textBox31.Size = new System.Drawing.Size(50, 21);
			textBox31.TabIndex = 133;
			textBox31.Text = "0";
			label30.AutoSize = true;
			label30.Location = new System.Drawing.Point(244, 203);
			label30.Name = "label30";
			label30.Size = new System.Drawing.Size(23, 12);
			label30.TabIndex = 132;
			label30.Text = "F14";
			label31.AutoSize = true;
			label31.Location = new System.Drawing.Point(244, 178);
			label31.Name = "label31";
			label31.Size = new System.Drawing.Size(23, 12);
			label31.TabIndex = 131;
			label31.Text = "F15";
			textBox20.Location = new System.Drawing.Point(279, 150);
			textBox20.MaxLength = 3;
			textBox20.Name = "textBox20";
			textBox20.Size = new System.Drawing.Size(50, 21);
			textBox20.TabIndex = 130;
			textBox20.Text = "0";
			textBox21.Location = new System.Drawing.Point(279, 125);
			textBox21.MaxLength = 3;
			textBox21.Name = "textBox21";
			textBox21.Size = new System.Drawing.Size(50, 21);
			textBox21.TabIndex = 129;
			textBox21.Text = "0";
			label12.AutoSize = true;
			label12.Location = new System.Drawing.Point(244, 153);
			label12.Name = "label12";
			label12.Size = new System.Drawing.Size(23, 12);
			label12.TabIndex = 128;
			label12.Text = "G20";
			label13.AutoSize = true;
			label13.Location = new System.Drawing.Point(244, 128);
			label13.Name = "label13";
			label13.Size = new System.Drawing.Size(23, 12);
			label13.TabIndex = 127;
			label13.Text = "G21";
			textBox22.Location = new System.Drawing.Point(279, 100);
			textBox22.MaxLength = 3;
			textBox22.Name = "textBox22";
			textBox22.Size = new System.Drawing.Size(50, 21);
			textBox22.TabIndex = 126;
			textBox22.Text = "0";
			textBox23.Location = new System.Drawing.Point(279, 75);
			textBox23.MaxLength = 3;
			textBox23.Name = "textBox23";
			textBox23.Size = new System.Drawing.Size(50, 21);
			textBox23.TabIndex = 125;
			textBox23.Text = "0";
			label14.AutoSize = true;
			label14.Location = new System.Drawing.Point(244, 103);
			label14.Name = "label14";
			label14.Size = new System.Drawing.Size(23, 12);
			label14.TabIndex = 124;
			label14.Text = "G22";
			label23.AutoSize = true;
			label23.Location = new System.Drawing.Point(244, 78);
			label23.Name = "label23";
			label23.Size = new System.Drawing.Size(23, 12);
			label23.TabIndex = 123;
			label23.Text = "G23";
			textBox24.Location = new System.Drawing.Point(279, 50);
			textBox24.MaxLength = 3;
			textBox24.Name = "textBox24";
			textBox24.Size = new System.Drawing.Size(50, 21);
			textBox24.TabIndex = 122;
			textBox24.Text = "0";
			textBox25.Location = new System.Drawing.Point(279, 25);
			textBox25.MaxLength = 3;
			textBox25.Name = "textBox25";
			textBox25.Size = new System.Drawing.Size(50, 21);
			textBox25.TabIndex = 121;
			textBox25.Text = "0";
			label24.AutoSize = true;
			label24.Location = new System.Drawing.Point(244, 53);
			label24.Name = "label24";
			label24.Size = new System.Drawing.Size(23, 12);
			label24.TabIndex = 120;
			label24.Text = "G24";
			label25.AutoSize = true;
			label25.Location = new System.Drawing.Point(244, 28);
			label25.Name = "label25";
			label25.Size = new System.Drawing.Size(23, 12);
			label25.TabIndex = 119;
			label25.Text = "G25";
			textBox44.Location = new System.Drawing.Point(168, 225);
			textBox44.MaxLength = 3;
			textBox44.Name = "textBox44";
			textBox44.Size = new System.Drawing.Size(50, 21);
			textBox44.TabIndex = 118;
			textBox44.Text = "0";
			label44.AutoSize = true;
			label44.Location = new System.Drawing.Point(133, 228);
			label44.Name = "label44";
			label44.Size = new System.Drawing.Size(29, 12);
			label44.TabIndex = 116;
			label44.Text = "WG27";
			textBox33.Location = new System.Drawing.Point(168, 275);
			textBox33.MaxLength = 3;
			textBox33.Name = "textBox33";
			textBox33.Size = new System.Drawing.Size(50, 21);
			textBox33.TabIndex = 99;
			textBox33.Text = "0";
			textBox34.Location = new System.Drawing.Point(168, 250);
			textBox34.MaxLength = 3;
			textBox34.Name = "textBox34";
			textBox34.Size = new System.Drawing.Size(50, 21);
			textBox34.TabIndex = 98;
			textBox34.Text = "0";
			label32.AutoSize = true;
			label32.Location = new System.Drawing.Point(133, 278);
			label32.Name = "label32";
			label32.Size = new System.Drawing.Size(29, 12);
			label32.TabIndex = 97;
			label32.Text = "WG25";
			label33.AutoSize = true;
			label33.Location = new System.Drawing.Point(133, 253);
			label33.Name = "label33";
			label33.Size = new System.Drawing.Size(29, 12);
			label33.TabIndex = 96;
			label33.Text = "WG26";
			textBox10.Location = new System.Drawing.Point(168, 200);
			textBox10.MaxLength = 3;
			textBox10.Name = "textBox10";
			textBox10.Size = new System.Drawing.Size(50, 21);
			textBox10.TabIndex = 95;
			textBox10.Text = "0";
			textBox11.Location = new System.Drawing.Point(168, 175);
			textBox11.MaxLength = 3;
			textBox11.Name = "textBox11";
			textBox11.Size = new System.Drawing.Size(50, 21);
			textBox11.TabIndex = 94;
			textBox11.Text = "0";
			label10.AutoSize = true;
			label10.Location = new System.Drawing.Point(133, 203);
			label10.Name = "label10";
			label10.Size = new System.Drawing.Size(29, 12);
			label10.TabIndex = 93;
			label10.Text = "WG28";
			label11.AutoSize = true;
			label11.Location = new System.Drawing.Point(133, 178);
			label11.Name = "label11";
			label11.Size = new System.Drawing.Size(29, 12);
			label11.TabIndex = 92;
			label11.Text = "WG29";
			textBox8.Location = new System.Drawing.Point(168, 150);
			textBox8.MaxLength = 3;
			textBox8.Name = "textBox8";
			textBox8.Size = new System.Drawing.Size(50, 21);
			textBox8.TabIndex = 91;
			textBox8.Text = "0";
			textBox9.Location = new System.Drawing.Point(168, 125);
			textBox9.MaxLength = 3;
			textBox9.Name = "textBox9";
			textBox9.Size = new System.Drawing.Size(50, 21);
			textBox9.TabIndex = 90;
			textBox9.Text = "0";
			label8.AutoSize = true;
			label8.Location = new System.Drawing.Point(133, 153);
			label8.Name = "label8";
			label8.Size = new System.Drawing.Size(29, 12);
			label8.TabIndex = 89;
			label8.Text = "WG30";
			label9.AutoSize = true;
			label9.Location = new System.Drawing.Point(133, 128);
			label9.Name = "label9";
			label9.Size = new System.Drawing.Size(29, 12);
			label9.TabIndex = 88;
			label9.Text = "WG31";
			textBox6.Location = new System.Drawing.Point(168, 100);
			textBox6.MaxLength = 3;
			textBox6.Name = "textBox6";
			textBox6.Size = new System.Drawing.Size(50, 21);
			textBox6.TabIndex = 87;
			textBox6.Text = "0";
			textBox7.Location = new System.Drawing.Point(168, 75);
			textBox7.MaxLength = 3;
			textBox7.Name = "textBox7";
			textBox7.Size = new System.Drawing.Size(50, 21);
			textBox7.TabIndex = 86;
			textBox7.Text = "0";
			label6.AutoSize = true;
			label6.Location = new System.Drawing.Point(133, 103);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(29, 12);
			label6.TabIndex = 85;
			label6.Text = "WG32";
			label7.AutoSize = true;
			label7.Location = new System.Drawing.Point(133, 78);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(29, 12);
			label7.TabIndex = 84;
			label7.Text = "WG33";
			textBox4.Location = new System.Drawing.Point(168, 50);
			textBox4.MaxLength = 3;
			textBox4.Name = "textBox4";
			textBox4.Size = new System.Drawing.Size(50, 21);
			textBox4.TabIndex = 83;
			textBox4.Text = "0";
			textBox5.Location = new System.Drawing.Point(168, 25);
			textBox5.MaxLength = 3;
			textBox5.Name = "textBox5";
			textBox5.Size = new System.Drawing.Size(50, 21);
			textBox5.TabIndex = 82;
			textBox5.Text = "0";
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(133, 53);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(29, 12);
			label4.TabIndex = 81;
			label4.Text = "WG34";
			label5.AutoSize = true;
			label5.Location = new System.Drawing.Point(133, 28);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(29, 12);
			label5.TabIndex = 80;
			label5.Text = "WG35";
			textBox3.Location = new System.Drawing.Point(58, 50);
			textBox3.MaxLength = 3;
			textBox3.Name = "textBox3";
			textBox3.Size = new System.Drawing.Size(50, 21);
			textBox3.TabIndex = 79;
			textBox3.Text = "0";
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(23, 53);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(29, 12);
			label3.TabIndex = 78;
			label3.Text = "WF95";
			textBox2.Location = new System.Drawing.Point(58, 75);
			textBox2.MaxLength = 3;
			textBox2.Name = "textBox2";
			textBox2.Size = new System.Drawing.Size(50, 21);
			textBox2.TabIndex = 77;
			textBox2.Text = "0";
			textBox1.Location = new System.Drawing.Point(58, 25);
			textBox1.MaxLength = 3;
			textBox1.Name = "textBox1";
			textBox1.Size = new System.Drawing.Size(50, 21);
			textBox1.TabIndex = 76;
			textBox1.Text = "0";
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(23, 78);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(29, 12);
			label2.TabIndex = 75;
			label2.Text = "WF90";
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(17, 28);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(35, 12);
			label1.TabIndex = 74;
			label1.Text = "WF100";
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(376, 386);
			base.Controls.Add(groupBox2);
			base.Name = "StoneConfig";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "石头设置";
			base.Load += new System.EventHandler(StoneConfig_Load);
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			ResumeLayout(false);
		}
	}
}
