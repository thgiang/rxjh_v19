using RxjhServer.Network;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace RxjhServer
{
	public class NetSet : Form
	{
		private TcpServer tcpServer_0;

		private IContainer icontainer_0;

		private CheckBox checkBox1;

		private TextBox textBox8;

		private TextBox textBox7;

		private TextBox textBox6;

		private TextBox textBox5;

		private TextBox textBox4;

		private TextBox textBox3;

		private TextBox textBox2;

		private TextBox textBox1;

		private Label label8;

		private Label label7;

		private Label label6;

		private Label label5;

		private Label label4;

		private Label label3;

		private Label label2;

		private Label label1;

		private GroupBox groupBox1;

		private RadioButton radioButton3;

		private RadioButton radioButton2;

		private RadioButton radioButton1;

		private Button button1;

		private TextBox textBox9;

		private Label label9;

		private GroupBox groupBox2;

		public NetSet(TcpServer tcpServer_1)
		{
			InitializeComponent();
			tcpServer_0 = tcpServer_1;
		}

		private void NetSet_Load(object sender, EventArgs e)
		{
			if (tcpServer_0.SendPolicy == SendPolicy.Pack)
			{
				radioButton1.Checked = true;
			}
			else if (tcpServer_0.SendPolicy == SendPolicy.Safe)
			{
				radioButton2.Checked = true;
			}
			else
			{
				radioButton3.Checked = true;
			}
			checkBox1.Checked = tcpServer_0.MarkSilence;
			textBox1.Text = tcpServer_0.WorkerThreadCount.ToString();
			textBox2.Text = tcpServer_0.AcceptSocketCount.ToString();
			textBox3.Text = tcpServer_0.SocketBufferSize.ToString();
			textBox4.Text = tcpServer_0.SocketListenQueue.ToString();
			textBox5.Text = tcpServer_0.FreeSocketObjLockTime.ToString();
			textBox6.Text = tcpServer_0.FreeSocketObjPool.ToString();
			textBox9.Text = tcpServer_0.FreeSocketObjHold.ToString();
			textBox8.Text = tcpServer_0.FreeBufferObjPool.ToString();
			textBox7.Text = tcpServer_0.FreeBufferObjHold.ToString();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				tcpServer_0.MarkSilence = true;
			}
			else
			{
				tcpServer_0.MarkSilence = false;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				tcpServer_0.WorkerThreadCount = uint.Parse(textBox1.Text);
				tcpServer_0.AcceptSocketCount = uint.Parse(textBox2.Text);
				tcpServer_0.SocketBufferSize = uint.Parse(textBox3.Text);
				tcpServer_0.SocketListenQueue = uint.Parse(textBox4.Text);
				tcpServer_0.FreeSocketObjLockTime = uint.Parse(textBox5.Text);
				tcpServer_0.FreeSocketObjPool = uint.Parse(textBox6.Text);
				tcpServer_0.FreeSocketObjHold = uint.Parse(textBox9.Text);
				tcpServer_0.FreeBufferObjPool = uint.Parse(textBox8.Text);
				tcpServer_0.FreeBufferObjHold = uint.Parse(textBox7.Text);
				MessageBox.Show("设置成功。");
			}
			catch
			{
			}
		}

		private void radioButton1_MouseClick(object sender, MouseEventArgs e)
		{
			tcpServer_0.SendPolicy = SendPolicy.Pack;
		}

		private void radioButton2_MouseClick(object sender, MouseEventArgs e)
		{
			tcpServer_0.SendPolicy = SendPolicy.Safe;
		}

		private void radioButton3_MouseClick(object sender, MouseEventArgs e)
		{
			tcpServer_0.SendPolicy = SendPolicy.Direct;
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			checkBox1 = new System.Windows.Forms.CheckBox();
			textBox8 = new System.Windows.Forms.TextBox();
			textBox7 = new System.Windows.Forms.TextBox();
			textBox6 = new System.Windows.Forms.TextBox();
			textBox5 = new System.Windows.Forms.TextBox();
			textBox4 = new System.Windows.Forms.TextBox();
			textBox3 = new System.Windows.Forms.TextBox();
			textBox2 = new System.Windows.Forms.TextBox();
			textBox1 = new System.Windows.Forms.TextBox();
			label8 = new System.Windows.Forms.Label();
			label7 = new System.Windows.Forms.Label();
			label6 = new System.Windows.Forms.Label();
			label5 = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			label1 = new System.Windows.Forms.Label();
			groupBox1 = new System.Windows.Forms.GroupBox();
			radioButton3 = new System.Windows.Forms.RadioButton();
			radioButton2 = new System.Windows.Forms.RadioButton();
			radioButton1 = new System.Windows.Forms.RadioButton();
			button1 = new System.Windows.Forms.Button();
			textBox9 = new System.Windows.Forms.TextBox();
			label9 = new System.Windows.Forms.Label();
			groupBox2 = new System.Windows.Forms.GroupBox();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			checkBox1.AutoSize = true;
			checkBox1.Location = new System.Drawing.Point(472, 16);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new System.Drawing.Size(96, 16);
			checkBox1.TabIndex = 37;
			checkBox1.Text = "标记静默时间";
			checkBox1.UseVisualStyleBackColor = true;
			checkBox1.CheckedChanged += new System.EventHandler(checkBox1_CheckedChanged);
			textBox8.Location = new System.Drawing.Point(398, 96);
			textBox8.Name = "textBox8";
			textBox8.Size = new System.Drawing.Size(58, 21);
			textBox8.TabIndex = 36;
			textBox7.Location = new System.Drawing.Point(398, 137);
			textBox7.Name = "textBox7";
			textBox7.Size = new System.Drawing.Size(58, 21);
			textBox7.TabIndex = 35;
			textBox6.Location = new System.Drawing.Point(398, 14);
			textBox6.Name = "textBox6";
			textBox6.Size = new System.Drawing.Size(58, 21);
			textBox6.TabIndex = 34;
			textBox5.Location = new System.Drawing.Point(158, 142);
			textBox5.Name = "textBox5";
			textBox5.Size = new System.Drawing.Size(58, 21);
			textBox5.TabIndex = 33;
			textBox4.Location = new System.Drawing.Point(158, 110);
			textBox4.Name = "textBox4";
			textBox4.Size = new System.Drawing.Size(58, 21);
			textBox4.TabIndex = 32;
			textBox3.Location = new System.Drawing.Point(158, 78);
			textBox3.Name = "textBox3";
			textBox3.Size = new System.Drawing.Size(58, 21);
			textBox3.TabIndex = 31;
			textBox2.Location = new System.Drawing.Point(158, 46);
			textBox2.Name = "textBox2";
			textBox2.Size = new System.Drawing.Size(58, 21);
			textBox2.TabIndex = 30;
			textBox1.Location = new System.Drawing.Point(158, 14);
			textBox1.Name = "textBox1";
			textBox1.Size = new System.Drawing.Size(58, 21);
			textBox1.TabIndex = 29;
			label8.AutoSize = true;
			label8.Location = new System.Drawing.Point(234, 140);
			label8.Name = "label8";
			label8.Size = new System.Drawing.Size(155, 12);
			label8.TabIndex = 28;
			label8.Text = "Buff内存块缓存池回收阀值:";
			label7.AutoSize = true;
			label7.Location = new System.Drawing.Point(261, 99);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(131, 12);
			label7.TabIndex = 27;
			label7.Text = "Buff内存块缓存池大小:";
			label6.AutoSize = true;
			label6.Location = new System.Drawing.Point(282, 17);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(107, 12);
			label6.TabIndex = 26;
			label6.Text = "Socket缓存池大小:";
			label5.AutoSize = true;
			label5.Location = new System.Drawing.Point(9, 145);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(143, 12);
			label5.TabIndex = 25;
			label5.Text = "Socket缓存对象锁定时间:";
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(33, 113);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(119, 12);
			label4.TabIndex = 24;
			label4.Text = "Socket等候队列大小:";
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(57, 81);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(95, 12);
			label3.TabIndex = 23;
			label3.Text = "通信数据缓冲区:";
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(45, 49);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(107, 12);
			label2.TabIndex = 22;
			label2.Text = "Accept预投递数量:";
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(93, 17);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(59, 12);
			label1.TabIndex = 21;
			label1.Text = "工作线程:";
			groupBox1.Controls.Add(radioButton3);
			groupBox1.Controls.Add(radioButton2);
			groupBox1.Controls.Add(radioButton1);
			groupBox1.Location = new System.Drawing.Point(12, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new System.Drawing.Size(103, 175);
			groupBox1.TabIndex = 20;
			groupBox1.TabStop = false;
			groupBox1.Text = "发包策略";
			radioButton3.AutoSize = true;
			radioButton3.Location = new System.Drawing.Point(16, 127);
			radioButton3.Name = "radioButton3";
			radioButton3.Size = new System.Drawing.Size(71, 16);
			radioButton3.TabIndex = 2;
			radioButton3.TabStop = true;
			radioButton3.Text = "直接策略";
			radioButton3.UseVisualStyleBackColor = true;
			radioButton3.MouseClick += new System.Windows.Forms.MouseEventHandler(radioButton3_MouseClick);
			radioButton2.AutoSize = true;
			radioButton2.Location = new System.Drawing.Point(16, 85);
			radioButton2.Name = "radioButton2";
			radioButton2.Size = new System.Drawing.Size(71, 16);
			radioButton2.TabIndex = 1;
			radioButton2.TabStop = true;
			radioButton2.Text = "安全策略";
			radioButton2.UseVisualStyleBackColor = true;
			radioButton2.MouseClick += new System.Windows.Forms.MouseEventHandler(radioButton2_MouseClick);
			radioButton1.AutoSize = true;
			radioButton1.Location = new System.Drawing.Point(16, 43);
			radioButton1.Name = "radioButton1";
			radioButton1.Size = new System.Drawing.Size(71, 16);
			radioButton1.TabIndex = 0;
			radioButton1.TabStop = true;
			radioButton1.Text = "打包策略";
			radioButton1.UseVisualStyleBackColor = true;
			radioButton1.MouseClick += new System.Windows.Forms.MouseEventHandler(radioButton1_MouseClick);
			button1.Location = new System.Drawing.Point(493, 140);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(75, 23);
			button1.TabIndex = 38;
			button1.Text = "应用";
			button1.UseVisualStyleBackColor = true;
			button1.Click += new System.EventHandler(button1_Click);
			textBox9.Location = new System.Drawing.Point(398, 55);
			textBox9.Name = "textBox9";
			textBox9.Size = new System.Drawing.Size(58, 21);
			textBox9.TabIndex = 40;
			label9.AutoSize = true;
			label9.Location = new System.Drawing.Point(225, 58);
			label9.Name = "label9";
			label9.Size = new System.Drawing.Size(167, 12);
			label9.TabIndex = 39;
			label9.Text = "Socket内存块缓存池回收阀值:";
			groupBox2.Controls.Add(label1);
			groupBox2.Controls.Add(button1);
			groupBox2.Controls.Add(textBox9);
			groupBox2.Controls.Add(label2);
			groupBox2.Controls.Add(label9);
			groupBox2.Controls.Add(label3);
			groupBox2.Controls.Add(label4);
			groupBox2.Controls.Add(checkBox1);
			groupBox2.Controls.Add(label5);
			groupBox2.Controls.Add(textBox8);
			groupBox2.Controls.Add(textBox1);
			groupBox2.Controls.Add(textBox7);
			groupBox2.Controls.Add(textBox2);
			groupBox2.Controls.Add(textBox6);
			groupBox2.Controls.Add(textBox3);
			groupBox2.Controls.Add(label8);
			groupBox2.Controls.Add(textBox5);
			groupBox2.Controls.Add(label7);
			groupBox2.Controls.Add(textBox4);
			groupBox2.Controls.Add(label6);
			groupBox2.Location = new System.Drawing.Point(149, 12);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new System.Drawing.Size(585, 175);
			groupBox2.TabIndex = 41;
			groupBox2.TabStop = false;
			groupBox2.Text = "其他设置";
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(749, 212);
			base.Controls.Add(groupBox2);
			base.Controls.Add(groupBox1);
			base.Name = "NetSet";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "网络设置";
			base.Load += new System.EventHandler(NetSet_Load);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			ResumeLayout(false);
		}
	}
}
