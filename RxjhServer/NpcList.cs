using RxjhServer.DbClss;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace RxjhServer
{
	public class NpcList : Form
	{
		private static Dictionary<int, NpcClass> List = new Dictionary<int, NpcClass>();

		private static List<int> mapLis = new List<int>();

		private IContainer icontainer_0;

		private ComboBox comboBox1;

		private Label label1;

		private Button button1;

		private GroupBox groupBox1;

		private TextBox textBox18;

		private Label label19;

		private TextBox textBox17;

		private Label label18;

		private TextBox textBox16;

		private Label label17;

		private TextBox textBox15;

		private Label label16;

		private TextBox textBox14;

		private Label label15;

		private TextBox textBox13;

		private Label label14;

		private TextBox textBox12;

		private Label label13;

		private TextBox textBox11;

		private Label label12;

		private TextBox textBox10;

		private Label label11;

		private TextBox textBox9;

		private Label label10;

		private TextBox textBox8;

		private Label label9;

		private TextBox textBox7;

		private Label label8;

		private TextBox textBox6;

		private Label label7;

		private TextBox textBox5;

		private Label label6;

		private TextBox textBox4;

		private Label label5;

		private TextBox textBox3;

		private Label label4;

		private TextBox textBox2;

		private Label label3;

		private TextBox textBox1;

		private Label label2;

		private Label label20;

		private ComboBox comboBox2;

		public NpcList()
		{
			InitializeComponent();
		}

		private void NpcList_Load(object sender, EventArgs e)
		{
			try
			{
				mapLis = new List<int>();
				List = new Dictionary<int, NpcClass>();
				comboBox1.Items.Clear();
				comboBox2.Items.Clear();
				comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
				comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
				foreach (string value in World.Maplist.Values)
				{
					comboBox2.Items.Add(value);
				}
				foreach (NpcClass value2 in World.NpcList.Values)
				{
					try
					{
						List.Add(value2.FLD_PID, value2);
						comboBox1.Items.Add(value2.Name);
					}
					catch
					{
						MessageBox.Show(value2.FLD_INDEX + "|" + value2.Name);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private NpcClass method_0(string string_0)
		{
			foreach (NpcClass value in List.Values)
			{
				if (value.Name == string_0)
				{
					return value;
				}
			}
			return null;
		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (comboBox2.SelectedItem.ToString().Contains("九泉之下"))
				{
					comboBox1.Items.Clear();
					foreach (NpcClass value in World.NpcList.Values)
					{
						try
						{
							if (value.Rxjh_Map >= 23001 && value.Rxjh_Map <= 24000)
							{
								comboBox1.Items.Add(value.Name);
							}
						}
						catch
						{
							MessageBox.Show(value.FLD_INDEX + "|" + value.Name);
						}
					}
					if (comboBox1.Items.Count <= 0)
					{
						comboBox1.Text = string.Empty;
						comboBox1.Items.Clear();
						MessageBox.Show("此地图没有怪物");
					}
					else
					{
						comboBox1.SelectedItem = comboBox1.Items[0];
					}
				}
				else
				{
					int num = 0;
					foreach (KeyValuePair<int, string> item in World.Maplist)
					{
						if (item.Value == comboBox2.SelectedItem.ToString())
						{
							num = item.Key;
						}
					}
					if (num != 0)
					{
						comboBox1.Items.Clear();
						foreach (NpcClass value2 in World.NpcList.Values)
						{
							try
							{
								if (value2.Rxjh_Map == num)
								{
									comboBox1.Items.Add(value2.Name);
								}
							}
							catch
							{
								MessageBox.Show(value2.FLD_INDEX + "|" + value2.Name);
							}
						}
						if (comboBox1.Items.Count <= 0)
						{
							comboBox1.Text = string.Empty;
							comboBox1.Items.Clear();
							MessageBox.Show("此地图没有怪物");
						}
						else
						{
							comboBox1.SelectedItem = comboBox1.Items[0];
						}
					}
					else
					{
						MessageBox.Show("无此地图");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("错误:" + ex.Message);
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				NpcClass npcClass = method_0(comboBox1.SelectedItem.ToString());
				if (npcClass != null)
				{
					textBox1.Text = npcClass.FLD_INDEX.ToString();
					textBox2.Text = npcClass.FLD_PID.ToString();
					textBox3.Text = npcClass.Rxjh_X.ToString();
					textBox4.Text = npcClass.Rxjh_Z.ToString();
					textBox5.Text = npcClass.Rxjh_Y.ToString();
					textBox6.Text = npcClass.Name;
					textBox7.Text = npcClass.FLD_FACE1.ToString();
					textBox8.Text = npcClass.FLD_FACE2.ToString();
					textBox9.Text = npcClass.Rxjh_Map.ToString();
					textBox10.Text = npcClass.Level.ToString();
					MonSterClss value;
					string text2 = textBox11.Text = ((!World.MonSter.TryGetValue(npcClass.FLD_PID, out value)) ? npcClass.Rxjh_HP.ToString() : value.Rxjh_HP.ToString());
					string text4 = textBox12.Text = npcClass.FLD_AT.ToString();
					string text6 = textBox13.Text = npcClass.FLD_DF.ToString();
					string text8 = textBox14.Text = npcClass.IsNpc.ToString();
					string text10 = textBox15.Text = npcClass.FLD_NEWTIME.ToString();
					string text12 = textBox16.Text = npcClass.Rxjh_Exp.ToString();
					string text14 = textBox17.Text = npcClass.FLD_AUTO.ToString();
					string text16 = textBox18.Text = npcClass.FLD_BOSS.ToString();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				if (comboBox1.Text.Length != 0 && textBox1.Text.Length != 0 && textBox9.Text.Length != 0 && textBox2.Text.Length != 0 && textBox10.Text.Length != 0 && textBox11.Text.Length != 0 && textBox12.Text.Length != 0 && textBox13.Text.Length != 0 && textBox16.Text.Length != 0 && textBox17.Text.Length != 0 && textBox18.Text.Length != 0)
				{
					method_1(int.Parse(textBox9.Text), int.Parse(textBox2.Text), int.Parse(textBox10.Text), int.Parse(textBox11.Text), int.Parse(textBox12.Text), int.Parse(textBox13.Text), int.Parse(textBox16.Text), int.Parse(textBox17.Text), int.Parse(textBox18.Text));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void method_1(int int_0, int int_1, int int_2, int int_3, int int_4, int int_5, int int_6, int int_7, int int_8)
		{
			try
			{
				bool flag = false;
				MapClass value2;
				if (int_0 >= 23000 && int_0 <= 24000)
				{
					for (int i = 23000; i < 24001; i++)
					{
						MapClass value;
						if (World.Map.TryGetValue(i, out value))
						{
							foreach (NpcClass value3 in value.npcTemplate.Values)
							{
								if (value3.FLD_PID == int_1)
								{
									value3.Level = int_2;
									value3.Max_Rxjh_HP = int_3;
									value3.Rxjh_HP = int_3;
									value3.FLD_AT = int_4;
									value3.FLD_DF = int_5;
									value3.Rxjh_Exp = int_6;
									value3.FLD_AUTO = int_7;
									value3.FLD_BOSS = int_8;
									flag = true;
								}
							}
						}
					}
				}
				else if (World.Map.TryGetValue(int_0, out value2))
				{
					foreach (NpcClass value4 in value2.npcTemplate.Values)
					{
						if (value4.FLD_PID == int_1)
						{
							value4.Level = int_2;
							value4.Max_Rxjh_HP = int_3;
							value4.Rxjh_HP = int_3;
							value4.FLD_AT = int_4;
							value4.FLD_DF = int_5;
							value4.Rxjh_Exp = int_6;
							value4.FLD_AUTO = int_7;
							value4.FLD_BOSS = int_8;
							flag = true;
						}
					}
				}
				if (flag)
				{
					if (DBA.ExeSqlCommand(string.Format("UPDATE TBL_XWWL_MONSTER SET FLD_LEVEL={1},FLD_HP={2},FLD_AT={3},FLD_DF={4},FLD_EXP={5},FLD_AUTO={6},FLD_BOSS={7} WHERE FLD_PID={0}", int_1, int_2, int_3, int_4, int_5, int_6, int_7, int_8), "PublicDb") != -1)
					{
						MessageBox.Show("更新成功");
					}
				}
				else
				{
					MessageBox.Show("更新失败,请检查怪物是否存在");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void NpcList_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (mapLis != null)
			{
				mapLis.Clear();
				mapLis = null;
			}
			if (List != null)
			{
				List.Clear();
				List = null;
			}
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
			comboBox1 = new System.Windows.Forms.ComboBox();
			label1 = new System.Windows.Forms.Label();
			button1 = new System.Windows.Forms.Button();
			groupBox1 = new System.Windows.Forms.GroupBox();
			textBox18 = new System.Windows.Forms.TextBox();
			label19 = new System.Windows.Forms.Label();
			textBox17 = new System.Windows.Forms.TextBox();
			label18 = new System.Windows.Forms.Label();
			textBox16 = new System.Windows.Forms.TextBox();
			label17 = new System.Windows.Forms.Label();
			textBox15 = new System.Windows.Forms.TextBox();
			label16 = new System.Windows.Forms.Label();
			textBox14 = new System.Windows.Forms.TextBox();
			label15 = new System.Windows.Forms.Label();
			textBox13 = new System.Windows.Forms.TextBox();
			label14 = new System.Windows.Forms.Label();
			textBox12 = new System.Windows.Forms.TextBox();
			label13 = new System.Windows.Forms.Label();
			textBox11 = new System.Windows.Forms.TextBox();
			label12 = new System.Windows.Forms.Label();
			textBox10 = new System.Windows.Forms.TextBox();
			label11 = new System.Windows.Forms.Label();
			textBox9 = new System.Windows.Forms.TextBox();
			label10 = new System.Windows.Forms.Label();
			textBox8 = new System.Windows.Forms.TextBox();
			label9 = new System.Windows.Forms.Label();
			textBox7 = new System.Windows.Forms.TextBox();
			label8 = new System.Windows.Forms.Label();
			textBox6 = new System.Windows.Forms.TextBox();
			label7 = new System.Windows.Forms.Label();
			textBox5 = new System.Windows.Forms.TextBox();
			label6 = new System.Windows.Forms.Label();
			textBox4 = new System.Windows.Forms.TextBox();
			label5 = new System.Windows.Forms.Label();
			textBox3 = new System.Windows.Forms.TextBox();
			label4 = new System.Windows.Forms.Label();
			textBox2 = new System.Windows.Forms.TextBox();
			label3 = new System.Windows.Forms.Label();
			textBox1 = new System.Windows.Forms.TextBox();
			label2 = new System.Windows.Forms.Label();
			label20 = new System.Windows.Forms.Label();
			comboBox2 = new System.Windows.Forms.ComboBox();
			groupBox1.SuspendLayout();
			SuspendLayout();
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new System.Drawing.Point(172, 11);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new System.Drawing.Size(114, 20);
			comboBox1.TabIndex = 0;
			comboBox1.SelectedIndexChanged += new System.EventHandler(comboBox1_SelectedIndexChanged);
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(135, 14);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(35, 12);
			label1.TabIndex = 1;
			label1.Text = "名称:";
			button1.Location = new System.Drawing.Point(292, 9);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(43, 23);
			button1.TabIndex = 2;
			button1.Text = "更新";
			button1.UseVisualStyleBackColor = true;
			button1.Click += new System.EventHandler(button1_Click);
			groupBox1.Controls.Add(textBox18);
			groupBox1.Controls.Add(label19);
			groupBox1.Controls.Add(textBox17);
			groupBox1.Controls.Add(label18);
			groupBox1.Controls.Add(textBox16);
			groupBox1.Controls.Add(label17);
			groupBox1.Controls.Add(textBox15);
			groupBox1.Controls.Add(label16);
			groupBox1.Controls.Add(textBox14);
			groupBox1.Controls.Add(label15);
			groupBox1.Controls.Add(textBox13);
			groupBox1.Controls.Add(label14);
			groupBox1.Controls.Add(textBox12);
			groupBox1.Controls.Add(label13);
			groupBox1.Controls.Add(textBox11);
			groupBox1.Controls.Add(label12);
			groupBox1.Controls.Add(textBox10);
			groupBox1.Controls.Add(label11);
			groupBox1.Controls.Add(textBox9);
			groupBox1.Controls.Add(label10);
			groupBox1.Controls.Add(textBox8);
			groupBox1.Controls.Add(label9);
			groupBox1.Controls.Add(textBox7);
			groupBox1.Controls.Add(label8);
			groupBox1.Controls.Add(textBox6);
			groupBox1.Controls.Add(label7);
			groupBox1.Controls.Add(textBox5);
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(textBox4);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(textBox3);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(textBox2);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(textBox1);
			groupBox1.Controls.Add(label2);
			groupBox1.Location = new System.Drawing.Point(7, 40);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new System.Drawing.Size(328, 289);
			groupBox1.TabIndex = 4;
			groupBox1.TabStop = false;
			groupBox1.Text = "详细";
			textBox18.Location = new System.Drawing.Point(213, 245);
			textBox18.Name = "textBox18";
			textBox18.Size = new System.Drawing.Size(90, 21);
			textBox18.TabIndex = 35;
			label19.AutoSize = true;
			label19.Location = new System.Drawing.Point(178, 248);
			label19.Name = "label19";
			label19.Size = new System.Drawing.Size(35, 12);
			label19.TabIndex = 34;
			label19.Text = "BOSS:";
			textBox17.Location = new System.Drawing.Point(213, 218);
			textBox17.Name = "textBox17";
			textBox17.Size = new System.Drawing.Size(90, 21);
			textBox17.TabIndex = 33;
			label18.AutoSize = true;
			label18.Location = new System.Drawing.Point(178, 221);
			label18.Name = "label18";
			label18.Size = new System.Drawing.Size(35, 12);
			label18.TabIndex = 32;
			label18.Text = "AUTO:";
			textBox16.Location = new System.Drawing.Point(213, 191);
			textBox16.Name = "textBox16";
			textBox16.Size = new System.Drawing.Size(90, 21);
			textBox16.TabIndex = 31;
			label17.AutoSize = true;
			label17.Location = new System.Drawing.Point(184, 194);
			label17.Name = "label17";
			label17.Size = new System.Drawing.Size(29, 12);
			label17.TabIndex = 30;
			label17.Text = "EXP:";
			textBox15.Location = new System.Drawing.Point(213, 164);
			textBox15.Name = "textBox15";
			textBox15.Size = new System.Drawing.Size(90, 21);
			textBox15.TabIndex = 29;
			label16.AutoSize = true;
			label16.Location = new System.Drawing.Point(178, 167);
			label16.Name = "label16";
			label16.Size = new System.Drawing.Size(35, 12);
			label16.TabIndex = 28;
			label16.Text = "TIME:";
			textBox14.Location = new System.Drawing.Point(213, 137);
			textBox14.Name = "textBox14";
			textBox14.Size = new System.Drawing.Size(90, 21);
			textBox14.TabIndex = 27;
			label15.AutoSize = true;
			label15.Location = new System.Drawing.Point(184, 140);
			label15.Name = "label15";
			label15.Size = new System.Drawing.Size(29, 12);
			label15.TabIndex = 26;
			label15.Text = "NPC:";
			textBox13.Location = new System.Drawing.Point(213, 110);
			textBox13.Name = "textBox13";
			textBox13.Size = new System.Drawing.Size(90, 21);
			textBox13.TabIndex = 25;
			label14.AutoSize = true;
			label14.Location = new System.Drawing.Point(190, 113);
			label14.Name = "label14";
			label14.Size = new System.Drawing.Size(23, 12);
			label14.TabIndex = 24;
			label14.Text = "DF:";
			textBox12.Location = new System.Drawing.Point(213, 83);
			textBox12.Name = "textBox12";
			textBox12.Size = new System.Drawing.Size(90, 21);
			textBox12.TabIndex = 23;
			label13.AutoSize = true;
			label13.Location = new System.Drawing.Point(190, 86);
			label13.Name = "label13";
			label13.Size = new System.Drawing.Size(23, 12);
			label13.TabIndex = 22;
			label13.Text = "AT:";
			textBox11.Location = new System.Drawing.Point(213, 56);
			textBox11.Name = "textBox11";
			textBox11.Size = new System.Drawing.Size(90, 21);
			textBox11.TabIndex = 21;
			label12.AutoSize = true;
			label12.Location = new System.Drawing.Point(190, 59);
			label12.Name = "label12";
			label12.Size = new System.Drawing.Size(23, 12);
			label12.TabIndex = 20;
			label12.Text = "HP:";
			textBox10.Location = new System.Drawing.Point(213, 29);
			textBox10.Name = "textBox10";
			textBox10.Size = new System.Drawing.Size(90, 21);
			textBox10.TabIndex = 19;
			label11.AutoSize = true;
			label11.Location = new System.Drawing.Point(172, 32);
			label11.Name = "label11";
			label11.Size = new System.Drawing.Size(41, 12);
			label11.TabIndex = 18;
			label11.Text = "LEVEL:";
			textBox9.Location = new System.Drawing.Point(57, 245);
			textBox9.Name = "textBox9";
			textBox9.Size = new System.Drawing.Size(90, 21);
			textBox9.TabIndex = 17;
			label10.AutoSize = true;
			label10.Location = new System.Drawing.Point(22, 248);
			label10.Name = "label10";
			label10.Size = new System.Drawing.Size(29, 12);
			label10.TabIndex = 16;
			label10.Text = "MID:";
			textBox8.Location = new System.Drawing.Point(57, 218);
			textBox8.Name = "textBox8";
			textBox8.Size = new System.Drawing.Size(90, 21);
			textBox8.TabIndex = 15;
			label9.AutoSize = true;
			label9.Location = new System.Drawing.Point(10, 221);
			label9.Name = "label9";
			label9.Size = new System.Drawing.Size(41, 12);
			label9.TabIndex = 14;
			label9.Text = "FACE2:";
			textBox7.Location = new System.Drawing.Point(57, 191);
			textBox7.Name = "textBox7";
			textBox7.Size = new System.Drawing.Size(90, 21);
			textBox7.TabIndex = 13;
			label8.AutoSize = true;
			label8.Location = new System.Drawing.Point(10, 194);
			label8.Name = "label8";
			label8.Size = new System.Drawing.Size(41, 12);
			label8.TabIndex = 12;
			label8.Text = "FACE1:";
			textBox6.Location = new System.Drawing.Point(57, 164);
			textBox6.Name = "textBox6";
			textBox6.Size = new System.Drawing.Size(90, 21);
			textBox6.TabIndex = 11;
			label7.AutoSize = true;
			label7.Location = new System.Drawing.Point(16, 167);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(35, 12);
			label7.TabIndex = 10;
			label7.Text = "NAME:";
			textBox5.Location = new System.Drawing.Point(57, 137);
			textBox5.Name = "textBox5";
			textBox5.Size = new System.Drawing.Size(90, 21);
			textBox5.TabIndex = 9;
			label6.AutoSize = true;
			label6.Location = new System.Drawing.Point(34, 140);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(17, 12);
			label6.TabIndex = 8;
			label6.Text = "Y:";
			textBox4.Location = new System.Drawing.Point(57, 110);
			textBox4.Name = "textBox4";
			textBox4.Size = new System.Drawing.Size(90, 21);
			textBox4.TabIndex = 7;
			label5.AutoSize = true;
			label5.Location = new System.Drawing.Point(34, 113);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(17, 12);
			label5.TabIndex = 6;
			label5.Text = "Z:";
			textBox3.Location = new System.Drawing.Point(57, 83);
			textBox3.Name = "textBox3";
			textBox3.Size = new System.Drawing.Size(90, 21);
			textBox3.TabIndex = 5;
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(34, 83);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(17, 12);
			label4.TabIndex = 4;
			label4.Text = "X:";
			textBox2.Location = new System.Drawing.Point(57, 56);
			textBox2.Name = "textBox2";
			textBox2.Size = new System.Drawing.Size(90, 21);
			textBox2.TabIndex = 3;
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(22, 59);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(29, 12);
			label3.TabIndex = 2;
			label3.Text = "PID:";
			textBox1.Location = new System.Drawing.Point(57, 29);
			textBox1.Name = "textBox1";
			textBox1.Size = new System.Drawing.Size(90, 21);
			textBox1.TabIndex = 1;
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(10, 32);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(41, 12);
			label2.TabIndex = 0;
			label2.Text = "INDEX:";
			label20.AutoSize = true;
			label20.Location = new System.Drawing.Point(5, 14);
			label20.Name = "label20";
			label20.Size = new System.Drawing.Size(35, 12);
			label20.TabIndex = 36;
			label20.Text = "地图:";
			comboBox2.FormattingEnabled = true;
			comboBox2.Location = new System.Drawing.Point(35, 11);
			comboBox2.Name = "comboBox2";
			comboBox2.Size = new System.Drawing.Size(101, 20);
			comboBox2.TabIndex = 36;
			comboBox2.SelectedIndexChanged += new System.EventHandler(comboBox2_SelectedIndexChanged);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(363, 341);
			base.Controls.Add(comboBox2);
			base.Controls.Add(label20);
			base.Controls.Add(groupBox1);
			base.Controls.Add(button1);
			base.Controls.Add(label1);
			base.Controls.Add(comboBox1);
			base.Name = "NpcList";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "NpcList";
			base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(NpcList_FormClosing);
			base.Load += new System.EventHandler(NpcList_Load);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}
	}
}
