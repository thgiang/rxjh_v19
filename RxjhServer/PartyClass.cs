using RxjhServer.HelperTools;
using System;
using System.Collections.Generic;
using System.Timers;

namespace RxjhServer
{
	public class 组队Class : IDisposable
	{
		public List<Players> tem = new List<Players>();

		public ThreadSafeDictionary<int, Players> 队员列表;

		private ThreadSafeDictionary<string, 离线队员> 已退出队员列表;

		public string 队长Name;

		public int 组队id;

		public Players 邀请人;

		public Players 队长;

		public int 队伍级别;

		public bool 红包;

		public int 红包时间;

		public int 道具分配规则;

		public int 当前分配;

		public System.Timers.Timer 自动显示;

		private int 发送邀请组队计数;

		public 组队Class(Players 队长_)
		{
			自动显示 = new System.Timers.Timer(3000.0);
			自动显示.Elapsed += 自动显示事件;
			自动显示.AutoReset = true;
			队长Name = 队长_.UserName;
			队长 = 队长_;
			队员列表 = new ThreadSafeDictionary<int, Players>();
			队员列表.Add(队长_.人物全服ID, 队长_);
			当前分配 = 0;
			道具分配规则 = 2;
			红包 = false;
			红包时间 = 0;
			队伍级别 = 队长_.Player_Level;
			已退出队员列表 = new ThreadSafeDictionary<string, 离线队员>();
		}

		~组队Class()
		{
		}

		public Players 得到对应队员(int key)
		{
			try
			{
				int num = 0;
				foreach (Players value in 队员列表.Values)
				{
					if (key == num)
					{
						return value;
					}
					num++;
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "获取对应队员   出错!" + ex.Message);
			}
			return null;
		}

		public void Dispose()
		{
			try
			{
				if (已退出队员列表 != null)
				{
					已退出队员列表.Clear();
				}
				组队Class value;
				if (World.W组队.TryGetValue(组队id, out value))
				{
					World.W组队.Remove(组队id);
				}
				if (队员列表 != null)
				{
					foreach (Players value2 in 队员列表.Values)
					{
						value2.解散组队提示();
						value2.组队id = 0;
						value2.组队阶段 = 0;
						value2.夫妻组队中 = false;
					}
				}
				if (队员列表 != null)
				{
					队员列表.Clear();
				}
				if (自动显示 != null)
				{
					自动显示.Enabled = false;
					自动显示.Close();
					自动显示.Dispose();
					自动显示 = null;
				}
				邀请人 = null;
				tem = null;
				队伍级别 = 0;
				红包 = false;
				红包时间 = 0;
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "组队类   Dispose   出错!" + ex.Message);
			}
			finally
			{
				if (tem != null)
				{
					tem.Clear();
					tem = null;
				}
				if (队员列表 != null)
				{
					队员列表.Dispose();
					队员列表 = null;
				}
				if (已退出队员列表 != null)
				{
					已退出队员列表.Dispose();
					已退出队员列表 = null;
				}
				if (World.W组队.ContainsKey(组队id))
				{
					World.W组队.Remove(组队id);
				}
				if (自动显示 != null)
				{
					自动显示.Enabled = false;
					自动显示.Close();
					自动显示.Dispose();
					自动显示 = null;
				}
				邀请人 = null;
				队伍级别 = 0;
				红包 = false;
				红包时间 = 0;
			}
		}

		private void 自动显示事件(object sender, ElapsedEventArgs e)
		{
			try
			{
				if (队员列表 != null && 队员列表.Count <= 1)
				{
					Dispose();
				}
				else
				{
					发送邀请组队计数++;
					if (发送邀请组队计数 >= 15)
					{
						发送邀请组队计数 = 0;
						if (已退出队员列表 != null && 已退出队员列表.Count > 0)
						{
							List<string> list = new List<string>();
							foreach (离线队员 value3 in 已退出队员列表.Values)
							{
								Players players = World.检查玩家name(value3.UserName);
								if (players != null)
								{
									if (value3.组队id == 组队id)
									{
										if (队长.查找范围玩家(1000, players))
										{
											if (players.组队阶段 == 0 && 队员列表.Count < 8 && players.组队id == 0)
											{
												byte[] array = Converter.hexStringToByte("AA5528002C0130000600010001002D010000000000000000000000000000000000000000000000000000000055AA");
												System.Buffer.BlockCopy(Buffer.GetBytes(队长.人物全服ID), 0, array, 4, 2);
												System.Buffer.BlockCopy(Buffer.GetBytes(players.人物全服ID), 0, array, 14, 2);
												队长.发送组队(array, array.Length);
											}
											else if (players.组队阶段 == 1)
											{
												byte[] array2 = Converter.hexStringToByte("AA5512002C013200040001002C01000000000000000055AA");
												System.Buffer.BlockCopy(Buffer.GetBytes(队长.人物全服ID), 0, array2, 4, 2);
												System.Buffer.BlockCopy(Buffer.GetBytes(队长.人物全服ID), 0, array2, 12, 2);
												队长.本人取消组队(array2, array2.Length);
											}
											else if (players.组队阶段 == 2 && !list.Contains(players.Userid))
											{
												list.Add(players.Userid);
											}
										}
									}
									else if (!list.Contains(players.Userid))
									{
										list.Add(players.Userid);
									}
								}
							}
							if (list.Count > 0)
							{
								foreach (string item in list)
								{
									离线队员 value;
									if (已退出队员列表.TryGetValue(item, out value))
									{
										已退出队员列表.Remove(item);
									}
								}
							}
							list.Clear();
						}
					}
					if (红包)
					{
						红包时间 -= 3000;
						if (红包时间 <= 0)
						{
							红包 = false;
							红包时间 = 0;
						}
					}
					else
					{
						红包 = false;
						红包时间 = 0;
					}
					Players value2;
					if (队员列表 != null)
					{
						foreach (Players value4 in 队员列表.Values)
						{
							if (World.allConnectedChars.TryGetValue(value4.人物全服ID, out value2))
							{
								value4.显示队员();
								if (红包 && 红包时间 > 0)
								{
									if (value4.追加状态列表 != null && !value4.GetAddState(1000000050))
									{
										追加状态类 追加状态类 = new 追加状态类(value4, 红包时间, 1000000050, 0);
										value4.追加状态列表.Add(追加状态类.FLD_PID, 追加状态类);
										value4.状态效果(Buffer.GetBytes(1000000050), 1, 红包时间);
									}
								}
								else if (value4.追加状态列表 != null && value4.GetAddState(1000000050))
								{
									value4.追加状态列表[1000000050].时间结束事件();
								}
							}
							else if (tem != null && !tem.Contains(value4))
							{
								tem.Add(value4);
							}
						}
					}
					if (tem != null)
					{
						foreach (Players item2 in tem)
						{
							if (队员列表 != null && 队员列表.TryGetValue(item2.人物全服ID, out value2))
							{
								队员列表.Remove(item2.人物全服ID);
								item2.组队id = 0;
								item2.组队阶段 = 0;
							}
						}
					}
					if (tem.Count > 0)
					{
						tem.Clear();
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "组队类   自动显示事件   出错!" + ex.Message);
			}
		}

		public void 委任队长(Players 本人, Players 新队长)
		{
			try
			{
				队长Name = 新队长.UserName;
				队长 = 新队长;
				foreach (Players value in 队员列表.Values)
				{
					value.委任队长提示(本人, 新队长);
					value.显示队员();
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "组队类   委任队长   出错!" + ex.Message);
			}
		}

		public void 加入队员提示(Players 队员)
		{
			try
			{
				if (队员.FLD_情侣.Length != 0)
				{
					foreach (Players value2 in 队员列表.Values)
					{
						if (value2.UserName == 队员.FLD_情侣)
						{
							队员.夫妻组队中 = true;
							value2.夫妻组队中 = true;
							break;
						}
					}
				}
				foreach (Players value3 in 队员列表.Values)
				{
					if (队员 != value3)
					{
						value3.加入组队提示(队员);
						队员.加入组队提示(value3);
					}
					value3.显示队员();
				}
				if (队员列表.Count >= 2)
				{
					自动显示.Enabled = true;
				}
				离线队员 value;
				if (已退出队员列表.TryGetValue(队员.Userid, out value))
				{
					已退出队员列表.Remove(队员.Userid);
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "组队类   加入队员提示   出错!" + ex.Message);
			}
		}

		public void 退出(Players 队员, int 退出ID)
		{
			int num = 0;
			try
			{
				Players value;
				if (队员列表 != null && 队员列表.TryGetValue(队员.人物全服ID, out value))
				{
					队员列表.Remove(队员.人物全服ID);
					离线队员 value2;
					if (退出ID == 1 && 队员列表.Count >= 2 && !已退出队员列表.TryGetValue(队员.Userid, out value2))
					{
						已退出队员列表.Add(队员.Userid, new 离线队员
						{
							组队id = 队员.组队id,
							UserName = 队员.UserName
						});
					}
				}
				if (队员.GetAddState(1000000050))
				{
					队员.追加状态列表[1000000050].时间结束事件();
				}
				num = 1;
				if (队员.FLD_情侣.Length != 0)
				{
					队员.夫妻组队中 = false;
					num = 3;
					if (队员列表 != null)
					{
						foreach (Players value3 in 队员列表.Values)
						{
							num = 4;
							if (value3.UserName == 队员.FLD_情侣)
							{
								num = 5;
								value3.夫妻组队中 = false;
								num = 6;
								break;
							}
						}
					}
				}
				num = 7;
				if (队员列表 != null && 队员列表.Count >= 2)
				{
					num = 8;
					if (!Buffer.IsEquals(队长Name, 队员.UserName))
					{
						foreach (Players value4 in 队员列表.Values)
						{
							num = 9;
							value4.退出组队提示(队员);
							num = 10;
							value4.显示队员();
							num = 11;
						}
					}
					else
					{
						bool flag = true;
						foreach (Players value5 in 队员列表.Values)
						{
							if (flag)
							{
								num = 12;
								委任队长(队员, value5);
								flag = false;
							}
							num = 15;
							value5.退出组队提示(队员);
							num = 16;
						}
					}
				}
				else
				{
					num = 17;
					Dispose();
				}
				num = 18;
				队员.本人退出组队提示();
				num = 19;
				队员.组队id = 0;
				num = 20;
				队员.组队阶段 = 0;
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "组队类   退出   出错!" + num + "|" + ex.Message);
				logo.FileBugTxtLog("组队类   退出   出错!" + num + "|" + ex.Message);
			}
			finally
			{
				队员.组队id = 0;
				队员.组队阶段 = 0;
			}
		}
	}
}
