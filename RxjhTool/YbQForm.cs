using RxjhServer;
using RxjhServer.DbClss;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace RxjhTool
{
	public class YbQForm : Form
	{
		private byte[] byte_1A24628 = new byte[256];

		private Dictionary<int, 任务类> 任务 = new Dictionary<int, 任务类>();

		private string 文件地区 = string.Empty;

		private string 文件时间 = string.Empty;

		private string 增加内容 = "\r\n\r\n购买最新5.0服务端支持LUA游戏脚本\r\n自定义任务系统,功能齐全。\r\n请联系QQ：1146341013";

		private IContainer components;

		private MenuStrip menuStrip1;

		private ToolStripMenuItem 文件ToolStripMenuItem;

		private ToolStripMenuItem 打开YbqcfgToolStripMenuItem;

		private ToolStripMenuItem 保存YbqcfgToolStripMenuItem;

		private StatusStrip statusStrip1;

		private SplitContainer splitContainer1;

		private ListView listView;

		private ColumnHeader columnHeader1;

		private ColumnHeader columnHeader2;

		private PropertyGrid propertyGrid1;

		private ToolStripStatusLabel toolStripStatusLabel1;

		private ContextMenuStrip contextMenuStrip1;

		private ToolStripMenuItem 生成任务脚本ToolStripMenuItem;

		private ToolStripMenuItem 入库ToolStripMenuItem;

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
			menuStrip1 = new System.Windows.Forms.MenuStrip();
			文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			打开YbqcfgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			保存YbqcfgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			入库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			statusStrip1 = new System.Windows.Forms.StatusStrip();
			toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			splitContainer1 = new System.Windows.Forms.SplitContainer();
			listView = new System.Windows.Forms.ListView();
			columnHeader1 = new System.Windows.Forms.ColumnHeader();
			columnHeader2 = new System.Windows.Forms.ColumnHeader();
			contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
			生成任务脚本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			propertyGrid1 = new System.Windows.Forms.PropertyGrid();
			menuStrip1.SuspendLayout();
			statusStrip1.SuspendLayout();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			contextMenuStrip1.SuspendLayout();
			SuspendLayout();
			menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[1]
			{
				文件ToolStripMenuItem
			});
			menuStrip1.Location = new System.Drawing.Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new System.Drawing.Size(940, 30);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[3]
			{
				打开YbqcfgToolStripMenuItem,
				保存YbqcfgToolStripMenuItem,
				入库ToolStripMenuItem
			});
			文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
			文件ToolStripMenuItem.Size = new System.Drawing.Size(53, 26);
			文件ToolStripMenuItem.Text = "文件";
			打开YbqcfgToolStripMenuItem.Name = "打开YbqcfgToolStripMenuItem";
			打开YbqcfgToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
			打开YbqcfgToolStripMenuItem.Text = "打开";
			打开YbqcfgToolStripMenuItem.Click += new System.EventHandler(打开YbqcfgToolStripMenuItem_Click);
			保存YbqcfgToolStripMenuItem.Name = "保存YbqcfgToolStripMenuItem";
			保存YbqcfgToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
			保存YbqcfgToolStripMenuItem.Text = "保存";
			保存YbqcfgToolStripMenuItem.Click += new System.EventHandler(保存YbqcfgToolStripMenuItem_Click);
			入库ToolStripMenuItem.Name = "入库ToolStripMenuItem";
			入库ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
			入库ToolStripMenuItem.Text = "入库";
			入库ToolStripMenuItem.Click += new System.EventHandler(入库ToolStripMenuItem_Click);
			statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[1]
			{
				toolStripStatusLabel1
			});
			statusStrip1.Location = new System.Drawing.Point(0, 592);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
			statusStrip1.Size = new System.Drawing.Size(940, 26);
			statusStrip1.TabIndex = 1;
			statusStrip1.Text = "statusStrip1";
			toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			toolStripStatusLabel1.Size = new System.Drawing.Size(167, 20);
			toolStripStatusLabel1.Text = "toolStripStatusLabel1";
			splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			splitContainer1.Location = new System.Drawing.Point(0, 30);
			splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			splitContainer1.Name = "splitContainer1";
			splitContainer1.Panel1.Controls.Add(listView);
			splitContainer1.Panel2.Controls.Add(propertyGrid1);
			splitContainer1.Size = new System.Drawing.Size(940, 562);
			splitContainer1.SplitterDistance = 374;
			splitContainer1.SplitterWidth = 5;
			splitContainer1.TabIndex = 2;
			listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[2]
			{
				columnHeader1,
				columnHeader2
			});
			listView.ContextMenuStrip = contextMenuStrip1;
			listView.Dock = System.Windows.Forms.DockStyle.Fill;
			listView.FullRowSelect = true;
			listView.GridLines = true;
			listView.HideSelection = false;
			listView.Location = new System.Drawing.Point(0, 0);
			listView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			listView.Name = "listView";
			listView.Size = new System.Drawing.Size(374, 562);
			listView.TabIndex = 5;
			listView.UseCompatibleStateImageBehavior = false;
			listView.View = System.Windows.Forms.View.Details;
			listView.SelectedIndexChanged += new System.EventHandler(listView_SelectedIndexChanged);
			listView.DoubleClick += new System.EventHandler(listView_DoubleClick);
			columnHeader1.Text = "任务ID";
			columnHeader1.Width = 48;
			columnHeader2.Text = "任务名";
			columnHeader2.Width = 140;
			contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[1]
			{
				生成任务脚本ToolStripMenuItem
			});
			contextMenuStrip1.Name = "contextMenuStrip1";
			contextMenuStrip1.Size = new System.Drawing.Size(139, 28);
			生成任务脚本ToolStripMenuItem.Name = "生成任务脚本ToolStripMenuItem";
			生成任务脚本ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
			生成任务脚本ToolStripMenuItem.Text = "编辑任务";
			生成任务脚本ToolStripMenuItem.Click += new System.EventHandler(编辑任务ToolStripMenuItem_Click);
			propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
			propertyGrid1.Location = new System.Drawing.Point(0, 0);
			propertyGrid1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			propertyGrid1.Name = "propertyGrid1";
			propertyGrid1.Size = new System.Drawing.Size(561, 562);
			propertyGrid1.TabIndex = 0;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 15f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(940, 618);
			base.Controls.Add(splitContainer1);
			base.Controls.Add(statusStrip1);
			base.Controls.Add(menuStrip1);
			base.MainMenuStrip = menuStrip1;
			base.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			base.Name = "YbQForm";
			Text = "YBQ编辑器";
			base.Load += new System.EventHandler(Form1_Load);
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			statusStrip1.ResumeLayout(false);
			statusStrip1.PerformLayout();
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			splitContainer1.ResumeLayout(false);
			contextMenuStrip1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		public YbQForm()
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

		private void Form1_Load(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "任务总数:" + 任务.Count;
		}

		private int getlen(byte[] var, ref int 处理长度)
		{
			try
			{
				int num = 处理长度++;
				for (int i = num; i < var.Length; i++)
				{
					if (var[i] == 32 || var[i] == 10)
					{
						byte[] array = new byte[i - num];
						System.Buffer.BlockCopy(var, num, array, 0, array.Length);
						string @string = Encoding.Default.GetString(array);
						处理长度 += array.Length;
						return int.Parse(@string);
					}
				}
			}
			catch
			{
			}
			return 0;
		}

		private string getString(byte[] var, ref int 处理长度)
		{
			int num = 处理长度++;
			int num2 = num;
			while (true)
			{
				if (num2 < var.Length)
				{
					if (var[num2] == 32 || var[num2] == 10)
					{
						break;
					}
					num2++;
					continue;
				}
				return string.Empty;
			}
			byte[] array = new byte[num2 - num];
			System.Buffer.BlockCopy(var, num, array, 0, array.Length);
			string @string = Encoding.Default.GetString(array);
			处理长度 += array.Length;
			byte[] array2 = new byte[int.Parse(@string)];
			System.Buffer.BlockCopy(var, 处理长度, array2, 0, array2.Length);
			string string2 = Encoding.Default.GetString(array2);
			处理长度 += array2.Length + 1;
			return string2;
		}

		private string getStringtou(byte[] var, ref int 处理长度)
		{
			int num = 处理长度;
			int num2 = num;
			while (true)
			{
				if (num2 < var.Length)
				{
					if (var[num2] == 32 || var[num2] == 10)
					{
						break;
					}
					num2++;
					continue;
				}
				return string.Empty;
			}
			byte[] array = new byte[num2 - num];
			System.Buffer.BlockCopy(var, 处理长度, array, 0, array.Length);
			string @string = Encoding.Default.GetString(array);
			处理长度 += array.Length + 1;
			return @string;
		}

		private byte[] Write(byte[] 数据)
		{
			for (int i = 0; (long)i < (long)数据.Length; i++)
			{
				for (int j = 0; j < byte_1A24628.Length; j++)
				{
					if (数据[i] == byte_1A24628[j])
					{
						数据[i] = (byte)j;
						break;
					}
				}
			}
			return 数据;
		}

		private byte WriteByte(byte 数据)
		{
			for (int i = 0; i < byte_1A24628.Length; i++)
			{
				if (数据 == byte_1A24628[i])
				{
					数据 = (byte)i;
					break;
				}
			}
			return 数据;
		}

		private void WriteInt(FileStream tdbtt, int 数据)
		{
			byte[] array = Write(Encoding.Default.GetBytes(数据.ToString()));
			tdbtt.Write(array, 0, array.Length);
			tdbtt.WriteByte(WriteByte(32));
		}

		private void WriteString(FileStream tdbtt, string 数据)
		{
			byte[] array = Write(Encoding.Default.GetBytes(数据));
			WriteInt(tdbtt, array.Length);
			tdbtt.Write(array, 0, array.Length);
			tdbtt.WriteByte(WriteByte(32));
		}

		private void 打开YbqcfgToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Filter = "Ybq.cfg file|Ybq.cfg";
				openFileDialog.FilterIndex = 1;
				openFileDialog.RestoreDirectory = true;
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					任务.Clear();
					listView.Items.Clear();
					using (FileStream input = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read, FileShare.Read))
					{
						using (BinaryReader binaryReader = new BinaryReader(input))
						{
							MemoryStream memoryStream = new MemoryStream();
							byte[] array = new byte[binaryReader.BaseStream.Length];
							while (binaryReader.Read(array, 0, array.Length) > 0)
							{
								int 处理长度 = 0;
								文件地区 = getStringtou(array, ref 处理长度);
								文件时间 = getStringtou(array, ref 处理长度);
								getlen(array, ref 处理长度);
								for (int i = 处理长度; (long)i < (long)array.Length; i++)
								{
									if ((long)(i + 1) >= (long)array.Length)
									{
										byte value = byte_1A24628[array[i]];
										memoryStream.WriteByte(value);
									}
									else if (array[i] == 13 && array[i + 1] == 10)
									{
										Console.WriteLine(i);
									}
									else
									{
										byte value2 = byte_1A24628[array[i]];
										memoryStream.WriteByte(value2);
									}
								}
							}
							byte[] array2 = memoryStream.ToArray();
							int 处理长度2 = 0;
							while (处理长度2 < array2.Length)
							{
								try
								{
									任务类 任务类 = new 任务类();
									任务类.任务ID = getlen(array2, ref 处理长度2);
									任务类.任务名 = getString(array2, ref 处理长度2);
									任务类.任务等级 = getlen(array2, ref 处理长度2);
									RxjhServer.任务类 value3;
									if (World.任务list.TryGetValue(任务类.任务ID, out value3))
									{
										任务类.任务名 = value3.任务名;
										任务类.任务等级 = value3.任务等级;
									}
									任务类.任务未知1 = getlen(array2, ref 处理长度2);
									任务类.任务未知2 = getlen(array2, ref 处理长度2);
									任务类.任务未知3 = getlen(array2, ref 处理长度2);
									任务类.任务未知4 = getlen(array2, ref 处理长度2);
									任务类.任务未知5 = getlen(array2, ref 处理长度2);
									任务类.任务未知6 = getlen(array2, ref 处理长度2);
									任务类.任务未知7 = getlen(array2, ref 处理长度2);
									任务类.任务接受提示1 = getString(array2, ref 处理长度2);
									任务类.任务拒绝提示1 = getString(array2, ref 处理长度2);
									任务类.任务接受提示2 = getString(array2, ref 处理长度2);
									任务类.任务拒绝提示2 = getString(array2, ref 处理长度2);
									int num = getlen(array2, ref 处理长度2);
									for (int j = 0; j < num; j++)
									{
										任务类.奖励物品.Add(new 任务奖励物品类
										{
											物品ID = getlen(array2, ref 处理长度2),
											物品数量 = getlen(array2, ref 处理长度2)
										});
									}
									任务类.任务阶段数量 = getlen(array2, ref 处理长度2);
									if (任务类.任务阶段数量 > 0)
									{
										任务类.NpcID = getlen(array2, ref 处理长度2);
										任务类.Npc未知1 = getlen(array2, ref 处理长度2);
										任务类.Npc坐标.MapId = getlen(array2, ref 处理长度2);
										任务类.Npc坐标.CoordinateX = getlen(array2, ref 处理长度2);
										任务类.Npc坐标.CoordinateY = getlen(array2, ref 处理长度2);
										int num2 = getlen(array2, ref 处理长度2);
										for (int k = 0; k < num2; k++)
										{
											任务类.需要物品.Add(new 任务需要物品类
											{
												物品ID = getlen(array2, ref 处理长度2),
												物品数量 = getlen(array2, ref 处理长度2),
												地图ID = getlen(array2, ref 处理长度2),
												坐标X = getlen(array2, ref 处理长度2),
												坐标Y = getlen(array2, ref 处理长度2)
											});
										}
										任务类.任务欢迎接受提示1 = getString(array2, ref 处理长度2);
										任务类.任务欢迎接受提示1 = 任务类.任务欢迎接受提示1.Replace(增加内容, string.Empty);
										任务类.任务欢迎接受提示2 = getString(array2, ref 处理长度2);
										任务类.任务欢迎接受提示3 = getString(array2, ref 处理长度2);
										任务类.任务欢迎接受提示4 = getString(array2, ref 处理长度2);
										任务类.任务欢迎接受提示5 = getString(array2, ref 处理长度2);
										任务类.任务欢迎拒绝提示1 = getString(array2, ref 处理长度2);
										任务类.任务欢迎拒绝提示1 = 任务类.任务欢迎拒绝提示1.Replace(增加内容, string.Empty);
										任务类.任务欢迎拒绝提示2 = getString(array2, ref 处理长度2);
										任务类.任务欢迎拒绝提示3 = getString(array2, ref 处理长度2);
										任务类.任务欢迎拒绝提示4 = getString(array2, ref 处理长度2);
										任务类.任务欢迎拒绝提示5 = getString(array2, ref 处理长度2);
										for (int l = 0; l < 任务类.任务阶段数量 - 1; l++)
										{
											任务阶段类 任务阶段类 = new 任务阶段类();
											任务阶段类.任务阶段内容 = getString(array2, ref 处理长度2);
											任务阶段类.NpcID = getlen(array2, ref 处理长度2);
											任务阶段类.Npc未知1 = getlen(array2, ref 处理长度2);
											任务阶段类.Npc地图ID = getlen(array2, ref 处理长度2);
											任务阶段类.Npc坐标X = getlen(array2, ref 处理长度2);
											任务阶段类.Npc坐标Y = getlen(array2, ref 处理长度2);
											int num3 = getlen(array2, ref 处理长度2);
											for (int m = 0; m < num3; m++)
											{
												任务阶段类.需要物品.Add(new 任务需要物品类
												{
													物品ID = getlen(array2, ref 处理长度2),
													物品数量 = getlen(array2, ref 处理长度2),
													地图ID = getlen(array2, ref 处理长度2),
													坐标X = getlen(array2, ref 处理长度2),
													坐标Y = getlen(array2, ref 处理长度2)
												});
											}
											任务阶段类.任务条件符合提示1 = getString(array2, ref 处理长度2);
											任务阶段类.任务条件符合提示2 = getString(array2, ref 处理长度2);
											任务阶段类.任务条件符合提示3 = getString(array2, ref 处理长度2);
											任务阶段类.任务条件符合提示4 = getString(array2, ref 处理长度2);
											任务阶段类.任务条件符合提示5 = getString(array2, ref 处理长度2);
											任务阶段类.任务条件不符合提示1 = getString(array2, ref 处理长度2);
											任务阶段类.任务条件不符合提示2 = getString(array2, ref 处理长度2);
											任务阶段类.任务条件不符合提示3 = getString(array2, ref 处理长度2);
											任务阶段类.任务条件不符合提示4 = getString(array2, ref 处理长度2);
											任务阶段类.任务条件不符合提示5 = getString(array2, ref 处理长度2);
											任务类.任务阶段.Add(任务阶段类);
										}
										for (int num4 = 任务类.任务阶段.Count - 1; num4 >= 0; num4--)
										{
											if (num4 == 0)
											{
												任务类.任务阶段[num4].需要物品 = 任务类.需要物品;
												break;
											}
											任务类.任务阶段[num4].需要物品 = 任务类.任务阶段[num4 - 1].需要物品;
										}
										int num5 = getlen(array2, ref 处理长度2);
										if (num5 > 0)
										{
											Console.WriteLine(num5);
										}
										处理长度2++;
									}
									任务.Add(任务类.任务ID, 任务类);
								}
								catch
								{
								}
							}
							foreach (任务类 value4 in 任务.Values)
							{
								listView.Items.Insert(listView.Items.Count, new ListViewItem(new string[2]
								{
									value4.任务ID.ToString(),
									value4.任务名
								}));
							}
							toolStripStatusLabel1.Text = "任务总数:" + 任务.Count;
						}
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(2, "打开Ybq.cfg出错-" + ex.Message);
			}
		}

		private void 保存YbqcfgToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.Filter = "cfg files (*.cfg)|*.cfg|All files (*.*)|*.*";
				saveFileDialog.FilterIndex = 1;
				saveFileDialog.RestoreDirectory = true;
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					using (FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write, FileShare.Read))
					{
						byte[] bytes = Encoding.Default.GetBytes(文件地区);
						byte[] bytes2 = Encoding.Default.GetBytes(文件时间);
						Encoding @default = Encoding.Default;
						string s = 任务.Count.ToString();
						byte[] bytes3 = @default.GetBytes(s);
						fileStream.Write(bytes, 0, bytes.Length);
						fileStream.WriteByte(32);
						fileStream.Write(bytes2, 0, bytes2.Length);
						fileStream.WriteByte(10);
						fileStream.Write(bytes3, 0, bytes3.Length);
						fileStream.WriteByte(32);
						foreach (任务类 value in 任务.Values)
						{
							WriteInt(fileStream, value.任务ID);
							WriteString(fileStream, value.任务名);
							WriteInt(fileStream, value.任务等级);
							WriteInt(fileStream, value.任务未知1);
							WriteInt(fileStream, value.任务未知2);
							WriteInt(fileStream, value.任务未知3);
							WriteInt(fileStream, value.任务未知4);
							WriteInt(fileStream, value.任务未知5);
							WriteInt(fileStream, value.任务未知6);
							WriteInt(fileStream, value.任务未知7);
							WriteString(fileStream, value.任务接受提示1);
							WriteString(fileStream, value.任务拒绝提示1);
							WriteString(fileStream, value.任务接受提示2);
							WriteString(fileStream, value.任务拒绝提示2);
							WriteInt(fileStream, value.奖励物品.Count);
							if (value.奖励物品.Count > 0)
							{
								foreach (任务奖励物品类 item in value.奖励物品)
								{
									WriteInt(fileStream, item.物品ID);
									WriteInt(fileStream, item.物品数量);
								}
							}
							if (value.任务阶段数量 > 0)
							{
								WriteInt(fileStream, value.任务阶段.Count + 1);
								WriteInt(fileStream, value.NpcID);
								WriteInt(fileStream, value.Npc未知1);
								WriteInt(fileStream, value.Npc坐标.MapId);
								WriteInt(fileStream, value.Npc坐标.CoordinateX);
								WriteInt(fileStream, value.Npc坐标.CoordinateY);
								WriteInt(fileStream, value.需要物品.Count);
								if (value.需要物品.Count > 0)
								{
									foreach (任务需要物品类 item2 in value.需要物品)
									{
										WriteInt(fileStream, item2.物品ID);
										WriteInt(fileStream, item2.物品数量);
										WriteInt(fileStream, item2.地图ID);
										WriteInt(fileStream, item2.坐标X);
										WriteInt(fileStream, item2.坐标Y);
									}
								}
								try
								{
									if (value.任务欢迎接受提示1.Length > 10)
									{
										while (value.任务欢迎接受提示1.LastIndexOf("\r\n") >= value.任务欢迎接受提示1.Length - 2)
										{
											value.任务欢迎接受提示1 = value.任务欢迎接受提示1.Remove(value.任务欢迎接受提示1.Length - 2, 2);
										}
									}
									if (value.任务欢迎拒绝提示1.Length > 10)
									{
										while (value.任务欢迎拒绝提示1.LastIndexOf("\r\n") >= value.任务欢迎拒绝提示1.Length - 2)
										{
											value.任务欢迎拒绝提示1 = value.任务欢迎拒绝提示1.Remove(value.任务欢迎拒绝提示1.Length - 2, 2);
										}
									}
								}
								catch (Exception ex)
								{
									Form1.WriteLine(2, "保存Ybq.cfg出错-" + ex.Message);
								}
								WriteString(fileStream, value.任务欢迎接受提示1 + 增加内容);
								WriteString(fileStream, value.任务欢迎接受提示2);
								WriteString(fileStream, value.任务欢迎接受提示3);
								WriteString(fileStream, value.任务欢迎接受提示4);
								WriteString(fileStream, value.任务欢迎接受提示5);
								WriteString(fileStream, value.任务欢迎拒绝提示1 + 增加内容);
								WriteString(fileStream, value.任务欢迎拒绝提示2);
								WriteString(fileStream, value.任务欢迎拒绝提示3);
								WriteString(fileStream, value.任务欢迎拒绝提示4);
								WriteString(fileStream, value.任务欢迎拒绝提示5);
								foreach (任务阶段类 item3 in value.任务阶段)
								{
									WriteString(fileStream, item3.任务阶段内容);
									WriteInt(fileStream, item3.NpcID);
									WriteInt(fileStream, item3.Npc未知1);
									WriteInt(fileStream, item3.Npc地图ID);
									WriteInt(fileStream, item3.Npc坐标X);
									WriteInt(fileStream, item3.Npc坐标Y);
									WriteInt(fileStream, item3.需要物品.Count);
									if (item3.需要物品.Count > 0)
									{
										foreach (任务需要物品类 item4 in item3.需要物品)
										{
											WriteInt(fileStream, item4.物品ID);
											WriteInt(fileStream, item4.物品数量);
											WriteInt(fileStream, item4.地图ID);
											WriteInt(fileStream, item4.坐标X);
											WriteInt(fileStream, item4.坐标Y);
										}
									}
									WriteString(fileStream, item3.任务条件符合提示1);
									WriteString(fileStream, item3.任务条件符合提示2);
									WriteString(fileStream, item3.任务条件符合提示3);
									WriteString(fileStream, item3.任务条件符合提示4);
									WriteString(fileStream, item3.任务条件符合提示5);
									WriteString(fileStream, item3.任务条件不符合提示1);
									WriteString(fileStream, item3.任务条件不符合提示2);
									WriteString(fileStream, item3.任务条件不符合提示3);
									WriteString(fileStream, item3.任务条件不符合提示4);
									WriteString(fileStream, item3.任务条件不符合提示5);
								}
								WriteInt(fileStream, 0);
								fileStream.WriteByte(WriteByte(10));
							}
							else
							{
								Encoding default2 = Encoding.Default;
								string s2 = value.任务阶段.Count.ToString();
								byte[] array = Write(default2.GetBytes(s2));
								fileStream.Write(array, 0, array.Length);
								fileStream.WriteByte(WriteByte(10));
							}
						}
					}
				}
			}
			catch (Exception ex2)
			{
				Form1.WriteLine(2, "保存Ybq.cfg出错-" + ex2.Message);
			}
		}

		private void listView_SelectedIndexChanged(object sender, EventArgs e)
		{
			任务类 value;
			if (listView.SelectedItems.Count > 0 && 任务.TryGetValue(int.Parse(listView.SelectedItems[0].SubItems[0].Text), out value))
			{
				CustomPropertyCollection customPropertyCollection = new CustomPropertyCollection();
				customPropertyCollection.Add(new CustomProperty("任务ID", "任务ID", true, "基本", "任务ID", value));
				customPropertyCollection.Add(new CustomProperty("任务名", "任务名", false, "基本", "任务名", value));
				customPropertyCollection.Add(new CustomProperty("任务等级", "任务等级", false, "基本", "任务等级", value));
				customPropertyCollection.Add(new CustomProperty("任务拒绝提示1", "任务拒绝提示1", false, "基本", "拒绝接受任务后的提示", value, typeof(MultilineStringEditor)));
				customPropertyCollection.Add(new CustomProperty("任务拒绝提示2", "任务拒绝提示2", false, "基本", "拒绝接受任务后的提示", value, typeof(MultilineStringEditor)));
				customPropertyCollection.Add(new CustomProperty("任务接受提示1", "任务接受提示1", false, "基本", "接受任务后的提示", value, typeof(MultilineStringEditor)));
				customPropertyCollection.Add(new CustomProperty("任务接受提示2", "任务接受提示2", false, "基本", "接受任务后的提示", value, typeof(MultilineStringEditor)));
				customPropertyCollection.Add(new CustomProperty("NpcID", "NpcID", false, "Npc", "NpcID", value));
				customPropertyCollection.Add(new CustomProperty("Npc坐标", "Npc坐标", false, "Npc", "Npc坐标", value, true));
				customPropertyCollection.Add(new CustomProperty("奖励物品列表", "奖励物品", false, "奖励物品", "奖励物品", value, typeof(My奖励物品CollectionEditor)));
				customPropertyCollection.Add(new CustomProperty("需要物品列表", "需要物品", false, "需要物品", "需要物品", value, typeof(My需要物品CollectionEditor)));
				customPropertyCollection.Add(new CustomProperty("不符合内容", "任务欢迎拒绝提示1", false, "任务内容", "打开任务后条件不符合的提示内容", value, typeof(MultilineStringEditor)));
				customPropertyCollection.Add(new CustomProperty("符合内容", "任务欢迎接受提示1", false, "任务内容", "打开任务后条件符合的提示内容", value, typeof(MultilineStringEditor)));
				customPropertyCollection.Add(new CustomProperty("阶段数量", "任务阶段数量", false, "任务阶段", "任务阶段总数量=阶段列表的数量+1", value));
				customPropertyCollection.Add(new CustomProperty("阶段列表", "任务阶段", false, "任务阶段", "任务阶段列表", value, typeof(My任务阶段CollectionEditor)));
				propertyGrid1.SelectedObject = customPropertyCollection;
			}
		}

		private string getnpcname(int NpcWordId)
		{
			string empty = string.Empty;
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("select FLD_PID, FLD_NAME from [TBL_XWWL_NPC] where FLD_PID={0}", NpcWordId), "PublicDb");
			if (dBToDataTable.Rows.Count > 0 && int.Parse(dBToDataTable.Rows[0]["FLD_PID"].ToString()) == NpcWordId)
			{
				return (string)dBToDataTable.Rows[0]["FLD_NAME"];
			}
			dBToDataTable.Dispose();
			return empty;
		}

		private void 编辑任务ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (listView.SelectedItems.Count != 0)
			{
				int key = int.Parse(listView.FocusedItem.SubItems[0].Text);
				RxjhServer.任务类 value;
				if (!World.任务list.TryGetValue(key, out value))
				{
					MessageBox.Show("数据库中不存在此任务数据,请先入库!");
				}
			}
		}

		private void listView_DoubleClick(object sender, EventArgs e)
		{
			if (listView.SelectedItems.Count != 0)
			{
				int key = int.Parse(listView.FocusedItem.SubItems[0].Text);
				RxjhServer.任务类 value;
				if (!World.任务list.TryGetValue(key, out value))
				{
					MessageBox.Show("数据库中不存在此任务数据,请先入库!");
				}
			}
		}

		private void 入库ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			foreach (任务类 value in 任务.Values)
			{
				if (value.任务ID != 9751)
				{
					byte[] array = new byte[6];
					byte[] array2 = new byte[value.任务阶段.Count * 530];
					System.Buffer.BlockCopy(BitConverter.GetBytes(value.任务ID), 0, array, 0, 2);
					System.Buffer.BlockCopy(BitConverter.GetBytes(value.NpcID), 0, array, 2, 2);
					System.Buffer.BlockCopy(BitConverter.GetBytes(value.任务阶段.Count), 0, array, 4, 2);
					string text = getnpcname(value.NpcID);
					if (text == string.Empty)
					{
						text = "热血江湖";
					}
					string[] array3 = new string[13];
					for (int i = 0; i < 13; i++)
					{
						array3[i] = "NULL";
					}
					string text2 = "NULL";
					string text3 = "NULL";
					if (value.奖励物品.Count > 0)
					{
						text2 = string.Empty;
						foreach (任务奖励物品类 item in value.奖励物品)
						{
							text2 = text2 + item.物品ID + ";" + item.物品数量 + ";0|";
						}
					}
					if (text2 != "NULL")
					{
						text2.Remove(text2.LastIndexOf("|"), 1);
					}
					if (value.需要物品.Count > 0)
					{
						text3 = string.Empty;
						foreach (任务需要物品类 item2 in value.需要物品)
						{
							text3 = text3 + item2.物品ID + "," + item2.物品数量 + ",0;";
						}
					}
					if (text3 != "NULL")
					{
						text3.Remove(text3.LastIndexOf(";"), 1);
					}
					if (value.任务ID != 311)
					{
						int 任务ID = value.任务ID;
					}
					if (value.任务阶段.Count > 1)
					{
						for (int j = 1; j < value.任务阶段.Count + 1; j++)
						{
							System.Buffer.BlockCopy(BitConverter.GetBytes(j), 0, array2, (j - 1) * 530, 2);
							System.Buffer.BlockCopy(BitConverter.GetBytes(value.任务阶段[j - 1].NpcID), 0, array2, (j - 1) * 530 + 2, 2);
							System.Buffer.BlockCopy(BitConverter.GetBytes(20), 0, array2, (j - 1) * 530 + 4, 2);
							if (j == 1)
							{
								if (value.需要物品.Count > 0)
								{
									int num = 0;
									foreach (任务需要物品类 item3 in value.需要物品)
									{
										System.Buffer.BlockCopy(BitConverter.GetBytes(item3.物品ID), 0, array2, 10 + num * 12, 4);
										System.Buffer.BlockCopy(BitConverter.GetBytes(item3.物品数量), 0, array2, 14 + num * 12, 2);
										System.Buffer.BlockCopy(BitConverter.GetBytes(item3.物品数量), 0, array2, 16 + num * 12, 2);
										num++;
									}
								}
								else if (value.任务阶段[j - 1].需要物品.Count > 0)
								{
									int num2 = 0;
									foreach (任务需要物品类 item4 in value.任务阶段[j - 1].需要物品)
									{
										System.Buffer.BlockCopy(BitConverter.GetBytes(item4.物品ID), 0, array2, 10 + num2 * 12, 4);
										System.Buffer.BlockCopy(BitConverter.GetBytes(item4.物品数量), 0, array2, 14 + num2 * 12, 2);
										System.Buffer.BlockCopy(BitConverter.GetBytes(item4.物品数量), 0, array2, 16 + num2 * 12, 2);
										num2++;
									}
								}
							}
							else if (value.任务阶段[j - 1].需要物品.Count > 0)
							{
								int num3 = 0;
								foreach (任务需要物品类 item5 in value.任务阶段[j - 1].需要物品)
								{
									System.Buffer.BlockCopy(BitConverter.GetBytes(item5.物品ID), 0, array2, (j - 1) * 530 + 6 + 4 + num3 * 12, 4);
									System.Buffer.BlockCopy(BitConverter.GetBytes(item5.物品数量), 0, array2, (j - 1) * 530 + 6 + 4 + 4 + num3 * 12, 2);
									System.Buffer.BlockCopy(BitConverter.GetBytes(item5.物品数量), 0, array2, (j - 1) * 530 + 6 + 4 + 4 + 2 + num3 * 12, 2);
									num3++;
								}
							}
							if (j == value.任务阶段.Count && value.奖励物品.Count > 0)
							{
								int num4 = 0;
								foreach (任务奖励物品类 item6 in value.奖励物品)
								{
									System.Buffer.BlockCopy(BitConverter.GetBytes(item6.物品ID), 0, array2, 126 + num4 * 8 + (j - 1) * 530, 4);
									System.Buffer.BlockCopy(BitConverter.GetBytes(item6.物品数量), 0, array2, 126 + (num4 * 8 + 4) + (j - 1) * 530, 4);
									num4++;
								}
							}
							byte[] bytes = Encoding.Default.GetBytes(getnpcname(value.任务阶段[j - 1].NpcID));
							System.Buffer.BlockCopy(bytes, 0, array2, (j - 1) * 530 + 206, bytes.Length);
							System.Buffer.BlockCopy(BitConverter.GetBytes(value.任务阶段[j - 1].Npc地图ID), 0, array2, (j - 1) * 530 + 220, 2);
							System.Buffer.BlockCopy(BitConverter.GetBytes(value.任务阶段[j - 1].Npc坐标X), 0, array2, (j - 1) * 530 + 222, 4);
							System.Buffer.BlockCopy(BitConverter.GetBytes(value.任务阶段[j - 1].Npc坐标Y), 0, array2, (j - 1) * 530 + 226, 4);
							byte[] bytes2 = Encoding.Default.GetBytes(value.任务阶段[j - 1].任务阶段内容);
							System.Buffer.BlockCopy(bytes2, 0, array2, (j - 1) * 530 + 230, bytes2.Length);
						}
					}
					else if (value.任务阶段.Count == 0)
					{
						array2 = new byte[530];
						array = new byte[6];
						System.Buffer.BlockCopy(BitConverter.GetBytes(value.任务ID), 0, array, 0, 2);
						System.Buffer.BlockCopy(BitConverter.GetBytes(value.NpcID), 0, array, 2, 2);
						System.Buffer.BlockCopy(BitConverter.GetBytes(0), 0, array, 4, 2);
						System.Buffer.BlockCopy(BitConverter.GetBytes(0), 0, array2, 0, 2);
						System.Buffer.BlockCopy(BitConverter.GetBytes(value.NpcID), 0, array2, 2, 2);
						System.Buffer.BlockCopy(BitConverter.GetBytes(0), 0, array2, 4, 2);
						byte[] bytes3 = Encoding.Default.GetBytes(text);
						System.Buffer.BlockCopy(bytes3, 0, array2, 206, bytes3.Length);
						System.Buffer.BlockCopy(BitConverter.GetBytes(value.Npc坐标.MapId), 0, array2, 220, 2);
						System.Buffer.BlockCopy(BitConverter.GetBytes(value.Npc坐标.CoordinateX), 0, array2, 222, 4);
						System.Buffer.BlockCopy(BitConverter.GetBytes(value.Npc坐标.CoordinateY), 0, array2, 226, 4);
						byte[] bytes4 = Encoding.Default.GetBytes(value.任务名);
						System.Buffer.BlockCopy(bytes4, 0, array2, 230, bytes4.Length);
					}
					else
					{
						System.Buffer.BlockCopy(BitConverter.GetBytes(1), 0, array2, 0, 2);
						System.Buffer.BlockCopy(BitConverter.GetBytes(value.任务阶段[0].NpcID), 0, array2, 2, 2);
						System.Buffer.BlockCopy(BitConverter.GetBytes(20), 0, array2, 4, 2);
						if (value.需要物品.Count > 0)
						{
							int num5 = 0;
							foreach (任务需要物品类 item7 in value.需要物品)
							{
								System.Buffer.BlockCopy(BitConverter.GetBytes(item7.物品ID), 0, array2, 10 + num5 * 12, 4);
								System.Buffer.BlockCopy(BitConverter.GetBytes(item7.物品数量), 0, array2, 14 + num5 * 12, 2);
								System.Buffer.BlockCopy(BitConverter.GetBytes(item7.物品数量), 0, array2, 16 + num5 * 12, 2);
								num5++;
							}
						}
						if (value.奖励物品.Count > 0)
						{
							int num6 = 0;
							foreach (任务奖励物品类 item8 in value.奖励物品)
							{
								System.Buffer.BlockCopy(BitConverter.GetBytes(item8.物品ID), 0, array2, 126 + num6 * 8, 4);
								System.Buffer.BlockCopy(BitConverter.GetBytes(item8.物品数量), 0, array2, 126 + (num6 * 8 + 4), 4);
								num6++;
							}
						}
						getnpcname(value.任务阶段[0].NpcID);
						byte[] bytes5 = Encoding.Default.GetBytes(getnpcname(value.任务阶段[0].NpcID));
						System.Buffer.BlockCopy(bytes5, 0, array2, 206, bytes5.Length);
						System.Buffer.BlockCopy(BitConverter.GetBytes(value.任务阶段[0].Npc地图ID), 0, array2, 220, 2);
						System.Buffer.BlockCopy(BitConverter.GetBytes(value.任务阶段[0].Npc坐标X), 0, array2, 222, 4);
						System.Buffer.BlockCopy(BitConverter.GetBytes(value.任务阶段[0].Npc坐标Y), 0, array2, 226, 4);
						byte[] bytes6 = Encoding.Default.GetBytes(value.任务阶段[0].任务阶段内容);
						if (bytes6.Length > 200)
						{
							System.Buffer.BlockCopy(bytes6, 0, array2, 230, 200);
						}
						else
						{
							System.Buffer.BlockCopy(bytes6, 0, array2, 230, bytes6.Length);
						}
					}
					byte[] dst = new byte[array.Length + array2.Length];
					System.Buffer.BlockCopy(array, 0, dst, 0, array.Length);
					System.Buffer.BlockCopy(array2, 0, dst, 6, array2.Length);
				}
			}
		}
	}
}
