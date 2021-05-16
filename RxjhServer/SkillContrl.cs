using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace RxjhServer
{
	public class SkillContrl : Form
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class Class1
		{
			public static readonly Class1 class1_0 = new Class1();

			public static Func<KeyValuePair<int, 属性>, int> func_0;

			internal int method_0(KeyValuePair<int, 属性> i)
			{
				return i.Key;
			}
		}

		private Dictionary<int, 属性> qglist = new Dictionary<int, 属性>();

		private Dictionary<int, 属性> stqglist = new Dictionary<int, 属性>();

		private IContainer components;

		private ComboBox comboBox1;

		private GroupBox groupBox1;

		private TextBox textBox21;

		private TextBox textBox22;

		private TextBox textBox19;

		private TextBox textBox20;

		private TextBox textBox17;

		private TextBox textBox18;

		private TextBox textBox15;

		private TextBox textBox16;

		private TextBox textBox13;

		private TextBox textBox14;

		private TextBox textBox11;

		private TextBox textBox12;

		private TextBox textBox9;

		private TextBox textBox10;

		private TextBox textBox7;

		private TextBox textBox8;

		private TextBox textBox5;

		private TextBox textBox6;

		private TextBox textBox3;

		private TextBox textBox4;

		private TextBox textBox2;

		private TextBox textBox1;

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

		private Label label1;

		private GroupBox groupBox2;

		private Button button1;

		private TextBox textBox37;

		private TextBox textBox36;

		private TextBox textBox35;

		private TextBox textBox34;

		private TextBox textBox33;

		private TextBox textBox32;

		private TextBox textBox31;

		private TextBox textBox30;

		private TextBox textBox29;

		private TextBox textBox28;

		private TextBox textBox27;

		private TextBox textBox26;

		private TextBox textBox25;

		private TextBox textBox24;

		private TextBox textBox23;

		private Label label26;

		private Label label19;

		private Label label20;

		private Label label21;

		private Label label22;

		private Label label23;

		private Label label24;

		private Label label25;

		private Label label18;

		private Label label17;

		private Label label16;

		private Label label15;

		private Label label14;

		private Label label13;

		private Label label12;

		private Label label28;

		private Label label27;

		private Label label29;

		public SkillContrl()
		{
			InitializeComponent();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			select(comboBox1.SelectedIndex);
		}

		private void SkillContrl_Load(object sender, EventArgs e)
		{
			comboBox1.SelectedIndex = 0;
		}

		private void 初始化()
		{
			label12.Text = string.Empty;
			label13.Text = string.Empty;
			label14.Text = string.Empty;
			label15.Text = string.Empty;
			label16.Text = string.Empty;
			label17.Text = string.Empty;
			label18.Text = string.Empty;
			label19.Text = string.Empty;
			label20.Text = string.Empty;
			label21.Text = string.Empty;
			label22.Text = string.Empty;
			label23.Text = string.Empty;
			label24.Text = string.Empty;
			label25.Text = string.Empty;
			label26.Text = string.Empty;
			label12.Show();
			label13.Show();
			label14.Show();
			label15.Show();
			label16.Show();
			label17.Show();
			label18.Show();
			label19.Show();
			label20.Show();
			label21.Show();
			label22.Show();
			label23.Show();
			label24.Show();
			label25.Show();
			label26.Show();
			textBox23.Show();
			textBox24.Show();
			textBox25.Show();
			textBox26.Show();
			textBox27.Show();
			textBox28.Show();
			textBox29.Show();
			textBox30.Show();
			textBox31.Show();
			textBox32.Show();
			textBox33.Show();
			textBox34.Show();
			textBox35.Show();
			textBox36.Show();
			textBox37.Show();
		}

		private void select(int index)
		{
			try
			{
				index++;
				int num = index;
				qglist.Clear();
				stqglist.Clear();
				初始化();
				foreach (气功加成属性 value3 in World.气功加成.Values)
				{
					if (value3.FLD_JOB == num)
					{
						string fLD_NAME = value3.FLD_NAME;
						string text = value3.FLD_每点加成比率值1.ToString();
						string text2 = value3.FLD_每点加成比率值2.ToString();
						属性 value = new 属性(double.Parse(text), double.Parse(text2));
						qglist.Add(value3.FLD_INDEX, value);
						switch (value3.FLD_INDEX)
						{
						case 0:
							label1.Text = fLD_NAME;
							textBox1.Text = text;
							textBox2.Text = text2;
							break;
						case 1:
							label2.Text = fLD_NAME;
							textBox4.Text = text;
							textBox3.Text = text2;
							break;
						case 2:
							label3.Text = fLD_NAME;
							textBox6.Text = text;
							textBox5.Text = text2;
							break;
						case 3:
							label4.Text = fLD_NAME;
							textBox8.Text = text;
							textBox7.Text = text2;
							break;
						case 4:
							label5.Text = fLD_NAME;
							textBox10.Text = text;
							textBox9.Text = text2;
							break;
						case 5:
							label6.Text = fLD_NAME;
							textBox12.Text = text;
							textBox11.Text = text2;
							break;
						case 6:
							label7.Text = fLD_NAME;
							textBox14.Text = text;
							textBox13.Text = text2;
							break;
						case 7:
							label8.Text = fLD_NAME;
							textBox16.Text = text;
							textBox15.Text = text2;
							break;
						case 8:
							label9.Text = fLD_NAME;
							textBox18.Text = text;
							textBox17.Text = text2;
							break;
						case 9:
							label10.Text = fLD_NAME;
							textBox20.Text = text;
							textBox19.Text = text2;
							break;
						case 10:
							label11.Text = fLD_NAME;
							textBox22.Text = text;
							textBox21.Text = text2;
							break;
						}
					}
				}
				foreach (升天气功总类 value4 in World.升天气功List.Values)
				{
					switch (num)
					{
					case 1:
						if (value4.人物职业1 == 1)
						{
							属性 value2 = new 属性(value4.FLD_每点加成比率值, 0.0);
							stqglist.Add(value4.气功ID, value2);
							label22.Show();
							textBox33.Show();
							if (label12.Text.Length <= 7)
							{
								label12.Text = value4.气功名;
								textBox23.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label13.Text.Length <= 7)
							{
								label13.Text = value4.气功名;
								textBox24.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label14.Text.Length <= 7)
							{
								label14.Text = value4.气功名;
								textBox25.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label15.Text.Length <= 7)
							{
								label15.Text = value4.气功名;
								textBox26.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label16.Text.Length <= 7)
							{
								label16.Text = value4.气功名;
								textBox27.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label17.Text.Length <= 7)
							{
								label17.Text = value4.气功名;
								textBox28.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label18.Text.Length <= 7)
							{
								label18.Text = value4.气功名;
								textBox29.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label19.Text.Length <= 7)
							{
								label19.Text = value4.气功名;
								textBox30.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label20.Text.Length <= 7)
							{
								label20.Text = value4.气功名;
								textBox31.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label21.Text.Length <= 7)
							{
								label21.Text = value4.气功名;
								textBox32.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label22.Text.Length <= 7)
							{
								label22.Text = value4.气功名;
								textBox33.Text = value4.FLD_每点加成比率值.ToString();
								label23.Hide();
								label24.Hide();
								label25.Hide();
								label26.Hide();
								textBox34.Hide();
								textBox35.Hide();
								textBox36.Hide();
								textBox37.Hide();
							}
							else if (label23.Text.Length <= 7)
							{
								label23.Text = value4.气功名;
								textBox34.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label24.Text.Length <= 7)
							{
								label24.Text = value4.气功名;
								textBox35.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label25.Text.Length <= 7)
							{
								label25.Text = value4.气功名;
								textBox36.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label26.Text.Length <= 7)
							{
								label26.Text = value4.气功名;
								textBox37.Text = value4.FLD_每点加成比率值.ToString();
							}
						}
						break;
					case 2:
						if (value4.人物职业2 == 1)
						{
							if (label12.Text.Length <= 7)
							{
								label12.Text = value4.气功名;
								textBox23.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label13.Text.Length <= 7)
							{
								label13.Text = value4.气功名;
								textBox24.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label14.Text.Length <= 7)
							{
								label14.Text = value4.气功名;
								textBox25.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label15.Text.Length <= 7)
							{
								label15.Text = value4.气功名;
								textBox26.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label16.Text.Length <= 7)
							{
								label16.Text = value4.气功名;
								textBox27.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label17.Text.Length <= 7)
							{
								label17.Text = value4.气功名;
								textBox28.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label18.Text.Length <= 7)
							{
								label18.Text = value4.气功名;
								textBox29.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label19.Text.Length <= 7)
							{
								label19.Text = value4.气功名;
								textBox30.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label20.Text.Length <= 7)
							{
								label20.Text = value4.气功名;
								textBox31.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label21.Text.Length <= 7)
							{
								label21.Text = value4.气功名;
								textBox32.Text = value4.FLD_每点加成比率值.ToString();
								label22.Hide();
								label23.Hide();
								label24.Hide();
								label25.Hide();
								label26.Hide();
								textBox33.Hide();
								textBox34.Hide();
								textBox35.Hide();
								textBox36.Hide();
								textBox37.Hide();
							}
							else if (label22.Text.Length <= 7)
							{
								label22.Text = value4.气功名;
								textBox33.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label23.Text.Length <= 7)
							{
								label23.Text = value4.气功名;
								textBox34.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label24.Text.Length <= 7)
							{
								label24.Text = value4.气功名;
								textBox35.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label25.Text.Length <= 7)
							{
								label25.Text = value4.气功名;
								textBox36.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label26.Text.Length <= 7)
							{
								label26.Text = value4.气功名;
								textBox37.Text = value4.FLD_每点加成比率值.ToString();
							}
						}
						break;
					case 3:
						if (value4.人物职业3 == 1)
						{
							if (label12.Text.Length <= 7)
							{
								label12.Text = value4.气功名;
								textBox23.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label13.Text.Length <= 7)
							{
								label13.Text = value4.气功名;
								textBox24.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label14.Text.Length <= 7)
							{
								label14.Text = value4.气功名;
								textBox25.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label15.Text.Length <= 7)
							{
								label15.Text = value4.气功名;
								textBox26.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label16.Text.Length <= 7)
							{
								label16.Text = value4.气功名;
								textBox27.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label17.Text.Length <= 7)
							{
								label17.Text = value4.气功名;
								textBox28.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label18.Text.Length <= 7)
							{
								label18.Text = value4.气功名;
								textBox29.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label19.Text.Length <= 7)
							{
								label19.Text = value4.气功名;
								textBox30.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label20.Text.Length <= 7)
							{
								label20.Text = value4.气功名;
								textBox31.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label21.Text.Length <= 7)
							{
								label21.Text = value4.气功名;
								textBox32.Text = value4.FLD_每点加成比率值.ToString();
								label22.Hide();
								label23.Hide();
								label24.Hide();
								label25.Hide();
								label26.Hide();
								textBox33.Hide();
								textBox34.Hide();
								textBox35.Hide();
								textBox36.Hide();
								textBox37.Hide();
							}
							else if (label22.Text.Length <= 7)
							{
								label22.Text = value4.气功名;
								textBox33.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label23.Text.Length <= 7)
							{
								label23.Text = value4.气功名;
								textBox34.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label24.Text.Length <= 7)
							{
								label24.Text = value4.气功名;
								textBox35.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label25.Text.Length <= 7)
							{
								label25.Text = value4.气功名;
								textBox36.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label26.Text.Length <= 7)
							{
								label26.Text = value4.气功名;
								textBox37.Text = value4.FLD_每点加成比率值.ToString();
							}
						}
						break;
					case 4:
						if (value4.人物职业4 == 1)
						{
							if (label12.Text.Length <= 7)
							{
								label12.Text = value4.气功名;
								textBox23.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label13.Text.Length <= 7)
							{
								label13.Text = value4.气功名;
								textBox24.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label14.Text.Length <= 7)
							{
								label14.Text = value4.气功名;
								textBox25.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label15.Text.Length <= 7)
							{
								label15.Text = value4.气功名;
								textBox26.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label16.Text.Length <= 7)
							{
								label16.Text = value4.气功名;
								textBox27.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label17.Text.Length <= 7)
							{
								label17.Text = value4.气功名;
								textBox28.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label18.Text.Length <= 7)
							{
								label18.Text = value4.气功名;
								textBox29.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label19.Text.Length <= 7)
							{
								label19.Text = value4.气功名;
								textBox30.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label20.Text.Length <= 7)
							{
								label20.Text = value4.气功名;
								textBox31.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label21.Text.Length <= 7)
							{
								label21.Text = value4.气功名;
								textBox32.Text = value4.FLD_每点加成比率值.ToString();
								label22.Hide();
								label23.Hide();
								label24.Hide();
								label25.Hide();
								label26.Hide();
								textBox33.Hide();
								textBox34.Hide();
								textBox35.Hide();
								textBox36.Hide();
								textBox37.Hide();
							}
							else if (label22.Text.Length <= 7)
							{
								label22.Text = value4.气功名;
								textBox33.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label23.Text.Length <= 7)
							{
								label23.Text = value4.气功名;
								textBox34.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label24.Text.Length <= 7)
							{
								label24.Text = value4.气功名;
								textBox35.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label25.Text.Length <= 7)
							{
								label25.Text = value4.气功名;
								textBox36.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label26.Text.Length <= 7)
							{
								label26.Text = value4.气功名;
								textBox37.Text = value4.FLD_每点加成比率值.ToString();
							}
						}
						break;
					case 5:
						if (value4.人物职业5 == 1)
						{
							if (label12.Text.Length <= 7)
							{
								label12.Text = value4.气功名;
								textBox23.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label13.Text.Length <= 7)
							{
								label13.Text = value4.气功名;
								textBox24.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label14.Text.Length <= 7)
							{
								label14.Text = value4.气功名;
								textBox25.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label15.Text.Length <= 7)
							{
								label15.Text = value4.气功名;
								textBox26.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label16.Text.Length <= 7)
							{
								label16.Text = value4.气功名;
								textBox27.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label17.Text.Length <= 7)
							{
								label17.Text = value4.气功名;
								textBox28.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label18.Text.Length <= 7)
							{
								label18.Text = value4.气功名;
								textBox29.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label19.Text.Length <= 7)
							{
								label19.Text = value4.气功名;
								textBox30.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label20.Text.Length <= 7)
							{
								label20.Text = value4.气功名;
								textBox31.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label21.Text.Length <= 7)
							{
								label21.Text = value4.气功名;
								textBox32.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label22.Text.Length <= 7)
							{
								label22.Text = value4.气功名;
								textBox33.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label23.Text.Length <= 7)
							{
								label23.Text = value4.气功名;
								textBox34.Text = value4.FLD_每点加成比率值.ToString();
								label24.Hide();
								label25.Hide();
								label26.Hide();
								textBox35.Hide();
								textBox36.Hide();
								textBox37.Hide();
							}
							else if (label24.Text.Length <= 7)
							{
								label24.Text = value4.气功名;
								textBox35.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label25.Text.Length <= 7)
							{
								label25.Text = value4.气功名;
								textBox36.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label26.Text.Length <= 7)
							{
								label26.Text = value4.气功名;
								textBox37.Text = value4.FLD_每点加成比率值.ToString();
							}
						}
						break;
					case 6:
						if (value4.人物职业6 == 1)
						{
							if (label12.Text.Length <= 7)
							{
								label12.Text = value4.气功名;
								textBox23.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label13.Text.Length <= 7)
							{
								label13.Text = value4.气功名;
								textBox24.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label14.Text.Length <= 7)
							{
								label14.Text = value4.气功名;
								textBox25.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label15.Text.Length <= 7)
							{
								label15.Text = value4.气功名;
								textBox26.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label16.Text.Length <= 7)
							{
								label16.Text = value4.气功名;
								textBox27.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label17.Text.Length <= 7)
							{
								label17.Text = value4.气功名;
								textBox28.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label18.Text.Length <= 7)
							{
								label18.Text = value4.气功名;
								textBox29.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label19.Text.Length <= 7)
							{
								label19.Text = value4.气功名;
								textBox30.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label20.Text.Length <= 7)
							{
								label20.Text = value4.气功名;
								textBox31.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label21.Text.Length <= 7)
							{
								label21.Text = value4.气功名;
								textBox32.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label22.Text.Length <= 7)
							{
								label22.Text = value4.气功名;
								textBox33.Text = value4.FLD_每点加成比率值.ToString();
								label23.Hide();
								label24.Hide();
								label25.Hide();
								label26.Hide();
								textBox34.Hide();
								textBox35.Hide();
								textBox36.Hide();
								textBox37.Hide();
							}
							else if (label23.Text.Length <= 7)
							{
								label23.Text = value4.气功名;
								textBox34.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label24.Text.Length <= 7)
							{
								label24.Text = value4.气功名;
								textBox35.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label25.Text.Length <= 7)
							{
								label25.Text = value4.气功名;
								textBox36.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label26.Text.Length <= 7)
							{
								label26.Text = value4.气功名;
								textBox37.Text = value4.FLD_每点加成比率值.ToString();
							}
						}
						break;
					case 7:
						if (value4.人物职业7 == 1)
						{
							if (label12.Text.Length <= 7)
							{
								label12.Text = value4.气功名;
								textBox23.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label13.Text.Length <= 7)
							{
								label13.Text = value4.气功名;
								textBox24.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label14.Text.Length <= 7)
							{
								label14.Text = value4.气功名;
								textBox25.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label15.Text.Length <= 7)
							{
								label15.Text = value4.气功名;
								textBox26.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label16.Text.Length <= 7)
							{
								label16.Text = value4.气功名;
								textBox27.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label17.Text.Length <= 7)
							{
								label17.Text = value4.气功名;
								textBox28.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label18.Text.Length <= 7)
							{
								label18.Text = value4.气功名;
								textBox29.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label19.Text.Length <= 7)
							{
								label19.Text = value4.气功名;
								textBox30.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label20.Text.Length <= 7)
							{
								label20.Text = value4.气功名;
								textBox31.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label21.Text.Length <= 7)
							{
								label21.Text = value4.气功名;
								textBox32.Text = value4.FLD_每点加成比率值.ToString();
								label22.Hide();
								label23.Hide();
								label24.Hide();
								label25.Hide();
								label26.Hide();
								textBox33.Hide();
								textBox34.Hide();
								textBox35.Hide();
								textBox36.Hide();
								textBox37.Hide();
							}
							else if (label22.Text.Length <= 7)
							{
								label22.Text = value4.气功名;
								textBox33.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label23.Text.Length <= 7)
							{
								label23.Text = value4.气功名;
								textBox34.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label24.Text.Length <= 7)
							{
								label24.Text = value4.气功名;
								textBox35.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label25.Text.Length <= 7)
							{
								label25.Text = value4.气功名;
								textBox36.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label26.Text.Length <= 7)
							{
								label26.Text = value4.气功名;
								textBox37.Text = value4.FLD_每点加成比率值.ToString();
							}
						}
						break;
					case 8:
						if (value4.人物职业8 == 1)
						{
							if (label12.Text.Length <= 7)
							{
								label12.Text = value4.气功名;
								textBox23.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label13.Text.Length <= 7)
							{
								label13.Text = value4.气功名;
								textBox24.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label14.Text.Length <= 7)
							{
								label14.Text = value4.气功名;
								textBox25.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label15.Text.Length <= 7)
							{
								label15.Text = value4.气功名;
								textBox26.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label16.Text.Length <= 7)
							{
								label16.Text = value4.气功名;
								textBox27.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label17.Text.Length <= 7)
							{
								label17.Text = value4.气功名;
								textBox28.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label18.Text.Length <= 7)
							{
								label18.Text = value4.气功名;
								textBox29.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label19.Text.Length <= 7)
							{
								label19.Text = value4.气功名;
								textBox30.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label20.Text.Length <= 7)
							{
								label20.Text = value4.气功名;
								textBox31.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label21.Text.Length <= 7)
							{
								label21.Text = value4.气功名;
								textBox32.Text = value4.FLD_每点加成比率值.ToString();
								label22.Hide();
								label23.Hide();
								label24.Hide();
								label25.Hide();
								label26.Hide();
								textBox33.Hide();
								textBox34.Hide();
								textBox35.Hide();
								textBox36.Hide();
								textBox37.Hide();
							}
							else if (label22.Text.Length <= 7)
							{
								label22.Text = value4.气功名;
								textBox33.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label23.Text.Length <= 7)
							{
								label23.Text = value4.气功名;
								textBox34.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label24.Text.Length <= 7)
							{
								label24.Text = value4.气功名;
								textBox35.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label25.Text.Length <= 7)
							{
								label25.Text = value4.气功名;
								textBox36.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label26.Text.Length <= 7)
							{
								label26.Text = value4.气功名;
								textBox37.Text = value4.FLD_每点加成比率值.ToString();
							}
						}
						break;
					case 9:
						if (value4.人物职业9 == 1)
						{
							if (label12.Text.Length <= 7)
							{
								label12.Text = value4.气功名;
								textBox23.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label13.Text.Length <= 7)
							{
								label13.Text = value4.气功名;
								textBox24.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label14.Text.Length <= 7)
							{
								label14.Text = value4.气功名;
								textBox25.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label15.Text.Length <= 7)
							{
								label15.Text = value4.气功名;
								textBox26.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label16.Text.Length <= 7)
							{
								label16.Text = value4.气功名;
								textBox27.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label17.Text.Length <= 7)
							{
								label17.Text = value4.气功名;
								textBox28.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label18.Text.Length <= 7)
							{
								label18.Text = value4.气功名;
								textBox29.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label19.Text.Length <= 7)
							{
								label19.Text = value4.气功名;
								textBox30.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label20.Text.Length <= 7)
							{
								label20.Text = value4.气功名;
								textBox31.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label21.Text.Length <= 7)
							{
								label21.Text = value4.气功名;
								textBox32.Text = value4.FLD_每点加成比率值.ToString();
								label22.Hide();
								label23.Hide();
								label24.Hide();
								label25.Hide();
								label26.Hide();
								textBox33.Hide();
								textBox34.Hide();
								textBox35.Hide();
								textBox36.Hide();
								textBox37.Hide();
							}
							else if (label22.Text.Length <= 7)
							{
								label22.Text = value4.气功名;
								textBox33.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label23.Text.Length <= 7)
							{
								label23.Text = value4.气功名;
								textBox34.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label24.Text.Length <= 7)
							{
								label24.Text = value4.气功名;
								textBox35.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label25.Text.Length <= 7)
							{
								label25.Text = value4.气功名;
								textBox36.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label26.Text.Length <= 7)
							{
								label26.Text = value4.气功名;
								textBox37.Text = value4.FLD_每点加成比率值.ToString();
							}
						}
						break;
					case 10:
						if (value4.人物职业10 == 1)
						{
							if (label12.Text.Length <= 7)
							{
								label12.Text = value4.气功名;
								textBox23.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label13.Text.Length <= 7)
							{
								label13.Text = value4.气功名;
								textBox24.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label14.Text.Length <= 7)
							{
								label14.Text = value4.气功名;
								textBox25.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label15.Text.Length <= 7)
							{
								label15.Text = value4.气功名;
								textBox26.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label16.Text.Length <= 7)
							{
								label16.Text = value4.气功名;
								textBox27.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label17.Text.Length <= 7)
							{
								label17.Text = value4.气功名;
								textBox28.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label18.Text.Length <= 7)
							{
								label18.Text = value4.气功名;
								textBox29.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label19.Text.Length <= 7)
							{
								label19.Text = value4.气功名;
								textBox30.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label20.Text.Length <= 7)
							{
								label20.Text = value4.气功名;
								textBox31.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label21.Text.Length <= 7)
							{
								label21.Text = value4.气功名;
								textBox32.Text = value4.FLD_每点加成比率值.ToString();
								label22.Hide();
								label23.Hide();
								label24.Hide();
								label25.Hide();
								label26.Hide();
								textBox33.Hide();
								textBox34.Hide();
								textBox35.Hide();
								textBox36.Hide();
								textBox37.Hide();
							}
							else if (label22.Text.Length <= 7)
							{
								label22.Text = value4.气功名;
								textBox33.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label23.Text.Length <= 7)
							{
								label23.Text = value4.气功名;
								textBox34.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label24.Text.Length <= 7)
							{
								label24.Text = value4.气功名;
								textBox35.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label25.Text.Length <= 7)
							{
								label25.Text = value4.气功名;
								textBox36.Text = value4.FLD_每点加成比率值.ToString();
							}
							else if (label26.Text.Length <= 7)
							{
								label26.Text = value4.气功名;
								textBox37.Text = value4.FLD_每点加成比率值.ToString();
							}
						}
						break;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("加载气功数据出错 " + ex.Message);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int num = comboBox1.SelectedIndex + 1;
			qglist.OrderByDescending((KeyValuePair<int, 属性> i) => i.Key);
			foreach (气功加成属性 value2 in World.气功加成.Values)
			{
				属性 value;
				if (value2.FLD_JOB == num && qglist.TryGetValue(value2.FLD_INDEX, out value))
				{
					if (value2.FLD_每点加成比率值1 != qglist[value2.FLD_INDEX].FLD_加成1)
					{
						value2.FLD_每点加成比率值1 = qglist[value2.FLD_INDEX].FLD_加成1;
					}
					if (value2.FLD_每点加成比率值2 != qglist[value2.FLD_INDEX].FLD_加成2)
					{
						value2.FLD_每点加成比率值2 = qglist[value2.FLD_INDEX].FLD_加成2;
					}
				}
			}
		}

		private 属性 getshuxing(int index, int job)
		{
			return null;
		}

		private 属性 getstshuxing()
		{
			return null;
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
			comboBox1 = new System.Windows.Forms.ComboBox();
			groupBox1 = new System.Windows.Forms.GroupBox();
			label28 = new System.Windows.Forms.Label();
			label27 = new System.Windows.Forms.Label();
			textBox21 = new System.Windows.Forms.TextBox();
			textBox22 = new System.Windows.Forms.TextBox();
			textBox19 = new System.Windows.Forms.TextBox();
			textBox20 = new System.Windows.Forms.TextBox();
			textBox17 = new System.Windows.Forms.TextBox();
			textBox18 = new System.Windows.Forms.TextBox();
			textBox15 = new System.Windows.Forms.TextBox();
			textBox16 = new System.Windows.Forms.TextBox();
			textBox13 = new System.Windows.Forms.TextBox();
			textBox14 = new System.Windows.Forms.TextBox();
			textBox11 = new System.Windows.Forms.TextBox();
			textBox12 = new System.Windows.Forms.TextBox();
			textBox9 = new System.Windows.Forms.TextBox();
			textBox10 = new System.Windows.Forms.TextBox();
			textBox7 = new System.Windows.Forms.TextBox();
			textBox8 = new System.Windows.Forms.TextBox();
			textBox5 = new System.Windows.Forms.TextBox();
			textBox6 = new System.Windows.Forms.TextBox();
			textBox3 = new System.Windows.Forms.TextBox();
			textBox4 = new System.Windows.Forms.TextBox();
			textBox2 = new System.Windows.Forms.TextBox();
			textBox1 = new System.Windows.Forms.TextBox();
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
			groupBox2 = new System.Windows.Forms.GroupBox();
			label29 = new System.Windows.Forms.Label();
			textBox37 = new System.Windows.Forms.TextBox();
			textBox36 = new System.Windows.Forms.TextBox();
			textBox35 = new System.Windows.Forms.TextBox();
			textBox34 = new System.Windows.Forms.TextBox();
			textBox33 = new System.Windows.Forms.TextBox();
			textBox32 = new System.Windows.Forms.TextBox();
			textBox31 = new System.Windows.Forms.TextBox();
			textBox30 = new System.Windows.Forms.TextBox();
			textBox29 = new System.Windows.Forms.TextBox();
			textBox28 = new System.Windows.Forms.TextBox();
			textBox27 = new System.Windows.Forms.TextBox();
			textBox26 = new System.Windows.Forms.TextBox();
			textBox25 = new System.Windows.Forms.TextBox();
			textBox24 = new System.Windows.Forms.TextBox();
			textBox23 = new System.Windows.Forms.TextBox();
			label26 = new System.Windows.Forms.Label();
			label19 = new System.Windows.Forms.Label();
			label20 = new System.Windows.Forms.Label();
			label21 = new System.Windows.Forms.Label();
			label22 = new System.Windows.Forms.Label();
			label23 = new System.Windows.Forms.Label();
			label24 = new System.Windows.Forms.Label();
			label25 = new System.Windows.Forms.Label();
			label18 = new System.Windows.Forms.Label();
			label17 = new System.Windows.Forms.Label();
			label16 = new System.Windows.Forms.Label();
			label15 = new System.Windows.Forms.Label();
			label14 = new System.Windows.Forms.Label();
			label13 = new System.Windows.Forms.Label();
			label12 = new System.Windows.Forms.Label();
			button1 = new System.Windows.Forms.Button();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[10]
			{
				"刀客",
				"剑客",
				"枪客",
				"弓箭手",
				"医生",
				"刺客",
				"乐师",
				"韩飞官",
				"谭花玲",
				"格斗家"
			});
			comboBox1.Location = new System.Drawing.Point(14, 12);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new System.Drawing.Size(121, 20);
			comboBox1.TabIndex = 1;
			comboBox1.SelectedIndexChanged += new System.EventHandler(comboBox1_SelectedIndexChanged);
			groupBox1.Controls.Add(label28);
			groupBox1.Controls.Add(label27);
			groupBox1.Controls.Add(textBox21);
			groupBox1.Controls.Add(textBox22);
			groupBox1.Controls.Add(textBox19);
			groupBox1.Controls.Add(textBox20);
			groupBox1.Controls.Add(textBox17);
			groupBox1.Controls.Add(textBox18);
			groupBox1.Controls.Add(textBox15);
			groupBox1.Controls.Add(textBox16);
			groupBox1.Controls.Add(textBox13);
			groupBox1.Controls.Add(textBox14);
			groupBox1.Controls.Add(textBox11);
			groupBox1.Controls.Add(textBox12);
			groupBox1.Controls.Add(textBox9);
			groupBox1.Controls.Add(textBox10);
			groupBox1.Controls.Add(textBox7);
			groupBox1.Controls.Add(textBox8);
			groupBox1.Controls.Add(textBox5);
			groupBox1.Controls.Add(textBox6);
			groupBox1.Controls.Add(textBox3);
			groupBox1.Controls.Add(textBox4);
			groupBox1.Controls.Add(textBox2);
			groupBox1.Controls.Add(textBox1);
			groupBox1.Controls.Add(label11);
			groupBox1.Controls.Add(label10);
			groupBox1.Controls.Add(label9);
			groupBox1.Controls.Add(label8);
			groupBox1.Controls.Add(label7);
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label1);
			groupBox1.Location = new System.Drawing.Point(14, 38);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new System.Drawing.Size(287, 455);
			groupBox1.TabIndex = 3;
			groupBox1.TabStop = false;
			groupBox1.Text = "职业气功";
			label28.AutoSize = true;
			label28.Location = new System.Drawing.Point(195, 29);
			label28.Name = "label28";
			label28.Size = new System.Drawing.Size(35, 12);
			label28.TabIndex = 34;
			label28.Text = "加成2";
			label27.AutoSize = true;
			label27.Location = new System.Drawing.Point(92, 29);
			label27.Name = "label27";
			label27.Size = new System.Drawing.Size(35, 12);
			label27.TabIndex = 33;
			label27.Text = "加成1";
			textBox21.Location = new System.Drawing.Point(197, 385);
			textBox21.Name = "textBox21";
			textBox21.Size = new System.Drawing.Size(71, 21);
			textBox21.TabIndex = 32;
			textBox22.Location = new System.Drawing.Point(94, 382);
			textBox22.Name = "textBox22";
			textBox22.Size = new System.Drawing.Size(68, 21);
			textBox22.TabIndex = 31;
			textBox19.Location = new System.Drawing.Point(197, 352);
			textBox19.Name = "textBox19";
			textBox19.Size = new System.Drawing.Size(71, 21);
			textBox19.TabIndex = 30;
			textBox20.Location = new System.Drawing.Point(94, 349);
			textBox20.Name = "textBox20";
			textBox20.Size = new System.Drawing.Size(68, 21);
			textBox20.TabIndex = 29;
			textBox17.Location = new System.Drawing.Point(197, 319);
			textBox17.Name = "textBox17";
			textBox17.Size = new System.Drawing.Size(71, 21);
			textBox17.TabIndex = 28;
			textBox18.Location = new System.Drawing.Point(94, 316);
			textBox18.Name = "textBox18";
			textBox18.Size = new System.Drawing.Size(68, 21);
			textBox18.TabIndex = 27;
			textBox15.Location = new System.Drawing.Point(197, 286);
			textBox15.Name = "textBox15";
			textBox15.Size = new System.Drawing.Size(71, 21);
			textBox15.TabIndex = 26;
			textBox16.Location = new System.Drawing.Point(94, 283);
			textBox16.Name = "textBox16";
			textBox16.Size = new System.Drawing.Size(68, 21);
			textBox16.TabIndex = 25;
			textBox13.Location = new System.Drawing.Point(197, 253);
			textBox13.Name = "textBox13";
			textBox13.Size = new System.Drawing.Size(71, 21);
			textBox13.TabIndex = 24;
			textBox14.Location = new System.Drawing.Point(94, 250);
			textBox14.Name = "textBox14";
			textBox14.Size = new System.Drawing.Size(68, 21);
			textBox14.TabIndex = 23;
			textBox11.Location = new System.Drawing.Point(197, 220);
			textBox11.Name = "textBox11";
			textBox11.Size = new System.Drawing.Size(71, 21);
			textBox11.TabIndex = 22;
			textBox12.Location = new System.Drawing.Point(94, 217);
			textBox12.Name = "textBox12";
			textBox12.Size = new System.Drawing.Size(68, 21);
			textBox12.TabIndex = 21;
			textBox9.Location = new System.Drawing.Point(197, 187);
			textBox9.Name = "textBox9";
			textBox9.Size = new System.Drawing.Size(71, 21);
			textBox9.TabIndex = 20;
			textBox10.Location = new System.Drawing.Point(94, 184);
			textBox10.Name = "textBox10";
			textBox10.Size = new System.Drawing.Size(68, 21);
			textBox10.TabIndex = 19;
			textBox7.Location = new System.Drawing.Point(197, 154);
			textBox7.Name = "textBox7";
			textBox7.Size = new System.Drawing.Size(71, 21);
			textBox7.TabIndex = 18;
			textBox8.Location = new System.Drawing.Point(94, 151);
			textBox8.Name = "textBox8";
			textBox8.Size = new System.Drawing.Size(68, 21);
			textBox8.TabIndex = 17;
			textBox5.Location = new System.Drawing.Point(197, 121);
			textBox5.Name = "textBox5";
			textBox5.Size = new System.Drawing.Size(71, 21);
			textBox5.TabIndex = 16;
			textBox6.Location = new System.Drawing.Point(94, 118);
			textBox6.Name = "textBox6";
			textBox6.Size = new System.Drawing.Size(68, 21);
			textBox6.TabIndex = 15;
			textBox3.Location = new System.Drawing.Point(197, 85);
			textBox3.Name = "textBox3";
			textBox3.Size = new System.Drawing.Size(71, 21);
			textBox3.TabIndex = 14;
			textBox4.Location = new System.Drawing.Point(94, 85);
			textBox4.Name = "textBox4";
			textBox4.Size = new System.Drawing.Size(68, 21);
			textBox4.TabIndex = 13;
			textBox2.Location = new System.Drawing.Point(197, 52);
			textBox2.Name = "textBox2";
			textBox2.Size = new System.Drawing.Size(71, 21);
			textBox2.TabIndex = 12;
			textBox1.Location = new System.Drawing.Point(94, 52);
			textBox1.Name = "textBox1";
			textBox1.Size = new System.Drawing.Size(68, 21);
			textBox1.TabIndex = 11;
			label11.AutoSize = true;
			label11.Location = new System.Drawing.Point(34, 385);
			label11.Name = "label11";
			label11.Size = new System.Drawing.Size(47, 12);
			label11.TabIndex = 10;
			label11.Text = "label11";
			label10.AutoSize = true;
			label10.Location = new System.Drawing.Point(34, 352);
			label10.Name = "label10";
			label10.Size = new System.Drawing.Size(47, 12);
			label10.TabIndex = 9;
			label10.Text = "label10";
			label9.AutoSize = true;
			label9.Location = new System.Drawing.Point(34, 319);
			label9.Name = "label9";
			label9.Size = new System.Drawing.Size(41, 12);
			label9.TabIndex = 8;
			label9.Text = "label9";
			label8.AutoSize = true;
			label8.Location = new System.Drawing.Point(34, 286);
			label8.Name = "label8";
			label8.Size = new System.Drawing.Size(41, 12);
			label8.TabIndex = 7;
			label8.Text = "label8";
			label7.AutoSize = true;
			label7.Location = new System.Drawing.Point(34, 253);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(41, 12);
			label7.TabIndex = 6;
			label7.Text = "label7";
			label6.AutoSize = true;
			label6.Location = new System.Drawing.Point(34, 220);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(41, 12);
			label6.TabIndex = 5;
			label6.Text = "label6";
			label5.AutoSize = true;
			label5.Location = new System.Drawing.Point(34, 187);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(41, 12);
			label5.TabIndex = 4;
			label5.Text = "label5";
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(34, 154);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(41, 12);
			label4.TabIndex = 3;
			label4.Text = "label4";
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(34, 121);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(41, 12);
			label3.TabIndex = 2;
			label3.Text = "label3";
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(34, 88);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(41, 12);
			label2.TabIndex = 1;
			label2.Text = "label2";
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(34, 55);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(41, 12);
			label1.TabIndex = 0;
			label1.Text = "label1";
			groupBox2.Controls.Add(label29);
			groupBox2.Controls.Add(textBox37);
			groupBox2.Controls.Add(textBox36);
			groupBox2.Controls.Add(textBox35);
			groupBox2.Controls.Add(textBox34);
			groupBox2.Controls.Add(textBox33);
			groupBox2.Controls.Add(textBox32);
			groupBox2.Controls.Add(textBox31);
			groupBox2.Controls.Add(textBox30);
			groupBox2.Controls.Add(textBox29);
			groupBox2.Controls.Add(textBox28);
			groupBox2.Controls.Add(textBox27);
			groupBox2.Controls.Add(textBox26);
			groupBox2.Controls.Add(textBox25);
			groupBox2.Controls.Add(textBox24);
			groupBox2.Controls.Add(textBox23);
			groupBox2.Controls.Add(label26);
			groupBox2.Controls.Add(label19);
			groupBox2.Controls.Add(label20);
			groupBox2.Controls.Add(label21);
			groupBox2.Controls.Add(label22);
			groupBox2.Controls.Add(label23);
			groupBox2.Controls.Add(label24);
			groupBox2.Controls.Add(label25);
			groupBox2.Controls.Add(label18);
			groupBox2.Controls.Add(label17);
			groupBox2.Controls.Add(label16);
			groupBox2.Controls.Add(label15);
			groupBox2.Controls.Add(label14);
			groupBox2.Controls.Add(label13);
			groupBox2.Controls.Add(label12);
			groupBox2.Location = new System.Drawing.Point(307, 38);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new System.Drawing.Size(306, 455);
			groupBox2.TabIndex = 4;
			groupBox2.TabStop = false;
			groupBox2.Text = "升天气功";
			label29.AutoSize = true;
			label29.Location = new System.Drawing.Point(158, 29);
			label29.Name = "label29";
			label29.Size = new System.Drawing.Size(29, 12);
			label29.TabIndex = 30;
			label29.Text = "加成";
			textBox37.Location = new System.Drawing.Point(160, 416);
			textBox37.Name = "textBox37";
			textBox37.Size = new System.Drawing.Size(100, 21);
			textBox37.TabIndex = 29;
			textBox36.Location = new System.Drawing.Point(160, 390);
			textBox36.Name = "textBox36";
			textBox36.Size = new System.Drawing.Size(100, 21);
			textBox36.TabIndex = 28;
			textBox35.Location = new System.Drawing.Point(160, 364);
			textBox35.Name = "textBox35";
			textBox35.Size = new System.Drawing.Size(100, 21);
			textBox35.TabIndex = 27;
			textBox34.Location = new System.Drawing.Point(160, 338);
			textBox34.Name = "textBox34";
			textBox34.Size = new System.Drawing.Size(100, 21);
			textBox34.TabIndex = 26;
			textBox33.Location = new System.Drawing.Point(160, 312);
			textBox33.Name = "textBox33";
			textBox33.Size = new System.Drawing.Size(100, 21);
			textBox33.TabIndex = 25;
			textBox32.Location = new System.Drawing.Point(160, 286);
			textBox32.Name = "textBox32";
			textBox32.Size = new System.Drawing.Size(100, 21);
			textBox32.TabIndex = 24;
			textBox31.Location = new System.Drawing.Point(160, 260);
			textBox31.Name = "textBox31";
			textBox31.Size = new System.Drawing.Size(100, 21);
			textBox31.TabIndex = 23;
			textBox30.Location = new System.Drawing.Point(160, 234);
			textBox30.Name = "textBox30";
			textBox30.Size = new System.Drawing.Size(100, 21);
			textBox30.TabIndex = 22;
			textBox29.Location = new System.Drawing.Point(160, 208);
			textBox29.Name = "textBox29";
			textBox29.Size = new System.Drawing.Size(100, 21);
			textBox29.TabIndex = 21;
			textBox28.Location = new System.Drawing.Point(160, 182);
			textBox28.Name = "textBox28";
			textBox28.Size = new System.Drawing.Size(100, 21);
			textBox28.TabIndex = 20;
			textBox27.Location = new System.Drawing.Point(160, 156);
			textBox27.Name = "textBox27";
			textBox27.Size = new System.Drawing.Size(100, 21);
			textBox27.TabIndex = 19;
			textBox26.Location = new System.Drawing.Point(160, 130);
			textBox26.Name = "textBox26";
			textBox26.Size = new System.Drawing.Size(100, 21);
			textBox26.TabIndex = 18;
			textBox25.Location = new System.Drawing.Point(160, 104);
			textBox25.Name = "textBox25";
			textBox25.Size = new System.Drawing.Size(100, 21);
			textBox25.TabIndex = 17;
			textBox24.Location = new System.Drawing.Point(160, 78);
			textBox24.Name = "textBox24";
			textBox24.Size = new System.Drawing.Size(100, 21);
			textBox24.TabIndex = 16;
			textBox23.Location = new System.Drawing.Point(160, 52);
			textBox23.Name = "textBox23";
			textBox23.Size = new System.Drawing.Size(100, 21);
			textBox23.TabIndex = 15;
			label26.AutoSize = true;
			label26.Location = new System.Drawing.Point(45, 419);
			label26.Name = "label26";
			label26.Size = new System.Drawing.Size(47, 12);
			label26.TabIndex = 14;
			label26.Text = "label26";
			label19.AutoSize = true;
			label19.Location = new System.Drawing.Point(45, 237);
			label19.Name = "label19";
			label19.Size = new System.Drawing.Size(47, 12);
			label19.TabIndex = 13;
			label19.Text = "label19";
			label20.AutoSize = true;
			label20.Location = new System.Drawing.Point(45, 263);
			label20.Name = "label20";
			label20.Size = new System.Drawing.Size(47, 12);
			label20.TabIndex = 12;
			label20.Text = "label20";
			label21.AutoSize = true;
			label21.Location = new System.Drawing.Point(45, 289);
			label21.Name = "label21";
			label21.Size = new System.Drawing.Size(47, 12);
			label21.TabIndex = 11;
			label21.Text = "label21";
			label22.AutoSize = true;
			label22.Location = new System.Drawing.Point(45, 315);
			label22.Name = "label22";
			label22.Size = new System.Drawing.Size(47, 12);
			label22.TabIndex = 10;
			label22.Text = "label22";
			label23.AutoSize = true;
			label23.Location = new System.Drawing.Point(45, 341);
			label23.Name = "label23";
			label23.Size = new System.Drawing.Size(47, 12);
			label23.TabIndex = 9;
			label23.Text = "label23";
			label24.AutoSize = true;
			label24.Location = new System.Drawing.Point(45, 367);
			label24.Name = "label24";
			label24.Size = new System.Drawing.Size(47, 12);
			label24.TabIndex = 8;
			label24.Text = "label24";
			label25.AutoSize = true;
			label25.Location = new System.Drawing.Point(45, 393);
			label25.Name = "label25";
			label25.Size = new System.Drawing.Size(47, 12);
			label25.TabIndex = 7;
			label25.Text = "label25";
			label18.AutoSize = true;
			label18.Location = new System.Drawing.Point(45, 211);
			label18.Name = "label18";
			label18.Size = new System.Drawing.Size(47, 12);
			label18.TabIndex = 6;
			label18.Text = "label18";
			label17.AutoSize = true;
			label17.Location = new System.Drawing.Point(45, 185);
			label17.Name = "label17";
			label17.Size = new System.Drawing.Size(47, 12);
			label17.TabIndex = 5;
			label17.Text = "label17";
			label16.AutoSize = true;
			label16.Location = new System.Drawing.Point(45, 159);
			label16.Name = "label16";
			label16.Size = new System.Drawing.Size(47, 12);
			label16.TabIndex = 4;
			label16.Text = "label16";
			label15.AutoSize = true;
			label15.Location = new System.Drawing.Point(45, 133);
			label15.Name = "label15";
			label15.Size = new System.Drawing.Size(47, 12);
			label15.TabIndex = 3;
			label15.Text = "label15";
			label14.AutoSize = true;
			label14.Location = new System.Drawing.Point(45, 107);
			label14.Name = "label14";
			label14.Size = new System.Drawing.Size(47, 12);
			label14.TabIndex = 2;
			label14.Text = "label14";
			label13.AutoSize = true;
			label13.Location = new System.Drawing.Point(45, 81);
			label13.Name = "label13";
			label13.Size = new System.Drawing.Size(47, 12);
			label13.TabIndex = 1;
			label13.Text = "label13";
			label12.AutoSize = true;
			label12.Location = new System.Drawing.Point(45, 55);
			label12.Name = "label12";
			label12.Size = new System.Drawing.Size(47, 12);
			label12.TabIndex = 0;
			label12.Text = "label12";
			button1.Location = new System.Drawing.Point(159, 10);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(142, 23);
			button1.TabIndex = 5;
			button1.Text = "保存";
			button1.UseVisualStyleBackColor = true;
			button1.Click += new System.EventHandler(button1_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(631, 515);
			base.Controls.Add(button1);
			base.Controls.Add(groupBox2);
			base.Controls.Add(groupBox1);
			base.Controls.Add(comboBox1);
			base.Name = "SkillContrl";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "气功设置";
			base.Load += new System.EventHandler(SkillContrl_Load);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			ResumeLayout(false);
		}
	}
}
