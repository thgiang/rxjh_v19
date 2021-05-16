using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace RxjhServer
{
	public class Timer
	{
		public class TimerThread
		{
			private class TimerChangeEntry
			{
				public Timer m_Timer;

				public int m_NewIndex;

				public bool m_IsAdd;

				private static Queue<TimerChangeEntry> m_InstancePool = new Queue<TimerChangeEntry>();

				private TimerChangeEntry(Timer timer_0, int int_0, bool bool_0)
				{
					m_Timer = timer_0;
					m_NewIndex = int_0;
					m_IsAdd = bool_0;
				}

				public void Free()
				{
				}

				public static TimerChangeEntry GetInstance(Timer timer_0, int int_0, bool bool_0)
				{
					TimerChangeEntry timerChangeEntry;
					if (m_InstancePool.Count > 0)
					{
						timerChangeEntry = m_InstancePool.Dequeue();
						if (timerChangeEntry == null)
						{
							timerChangeEntry = new TimerChangeEntry(timer_0, int_0, bool_0);
						}
						else
						{
							timerChangeEntry.m_Timer = timer_0;
							timerChangeEntry.m_NewIndex = int_0;
							timerChangeEntry.m_IsAdd = bool_0;
						}
					}
					else
					{
						timerChangeEntry = new TimerChangeEntry(timer_0, int_0, bool_0);
					}
					return timerChangeEntry;
				}
			}

			private static Queue queue_0 = Queue.Synchronized(new Queue());

			private static DateTime[] m_NextPriorities = new DateTime[8];

			private static TimeSpan[] m_PriorityDelays = new TimeSpan[8]
			{
				TimeSpan.Zero,
				TimeSpan.FromMilliseconds(10.0),
				TimeSpan.FromMilliseconds(25.0),
				TimeSpan.FromMilliseconds(50.0),
				TimeSpan.FromMilliseconds(250.0),
				TimeSpan.FromSeconds(1.0),
				TimeSpan.FromSeconds(5.0),
				TimeSpan.FromMinutes(1.0)
			};

			private static List<Timer>[] m_Timers = new List<Timer>[8]
			{
				new List<Timer>(),
				new List<Timer>(),
				new List<Timer>(),
				new List<Timer>(),
				new List<Timer>(),
				new List<Timer>(),
				new List<Timer>(),
				new List<Timer>()
			};

			public static void DumpInfo(TextWriter textWriter_0)
			{
				for (int i = 0; i < 8; i++)
				{
					textWriter_0.WriteLine("Priority: {0}", (TimerPriority)i);
					textWriter_0.WriteLine();
					Dictionary<string, List<Timer>> dictionary = new Dictionary<string, List<Timer>>();
					for (int j = 0; j < m_Timers[i].Count; j++)
					{
						Timer timer = m_Timers[i][j];
						string key = timer.ToString();
						List<Timer> value;
						dictionary.TryGetValue(key, out value);
						if (value == null)
						{
							value = (dictionary[key] = new List<Timer>());
						}
						value.Add(timer);
					}
					foreach (KeyValuePair<string, List<Timer>> item in dictionary)
					{
						string key2 = item.Key;
						List<Timer> value2 = item.Value;
						textWriter_0.WriteLine("Type: {0}; Count: {1}; Percent: {2}%", key2, value2.Count, (int)(100.0 * ((double)value2.Count / (double)m_Timers[i].Count)));
					}
					textWriter_0.WriteLine();
					textWriter_0.WriteLine();
				}
			}

			public static void Change(Timer timer_0, int int_0, bool bool_0)
			{
				queue_0.Enqueue(TimerChangeEntry.GetInstance(timer_0, int_0, bool_0));
			}

			public static void AddTimer(Timer timer_0)
			{
				Change(timer_0, (int)timer_0.Priority, true);
			}

			public static void PriorityChange(Timer timer_0, int int_0)
			{
				Change(timer_0, int_0, false);
			}

			public static void RemoveTimer(Timer timer_0)
			{
				Change(timer_0, -1, false);
			}

			private static void smethod_0()
			{
				while (queue_0.Count > 0)
				{
					TimerChangeEntry obj = (TimerChangeEntry)queue_0.Dequeue();
					Timer timer = obj.m_Timer;
					int newIndex = obj.m_NewIndex;
					if (timer.m_List != null)
					{
						timer.m_List.Remove(timer);
					}
					if (obj.m_IsAdd)
					{
						timer.dateTime_0 = DateTime.Now + timer.timeSpan_0;
						timer.int_0 = 0;
					}
					if (newIndex >= 0)
					{
						timer.m_List = m_Timers[newIndex];
						timer.m_List.Add(timer);
					}
					else
					{
						timer.m_List = null;
					}
					obj.Free();
				}
			}

			public void TimerMain()
			{
				while (true)
				{
					Thread.Sleep(10);
					smethod_0();
					for (int i = 0; i < m_Timers.Length; i++)
					{
						DateTime now = DateTime.Now;
						if (now < m_NextPriorities[i])
						{
							break;
						}
						m_NextPriorities[i] = now + m_PriorityDelays[i];
						for (int j = 0; j < m_Timers[i].Count; j++)
						{
							Timer timer = m_Timers[i][j];
							if (!timer.bool_1 && now > timer.dateTime_0)
							{
								timer.bool_1 = true;
								lock (m_Queue)
								{
									m_Queue.Enqueue(timer);
								}
								if (timer.int_1 != 0 && ++timer.int_0 >= timer.int_1)
								{
									timer.Stop();
								}
								else
								{
									timer.dateTime_0 = now + timer.timeSpan_1;
								}
							}
						}
					}
				}
			}
		}

		private class DelayCallTimer : Timer
		{
			private TimerCallback timerCallback_0;

			public TimerCallback Callback
			{
				get
				{
					return timerCallback_0;
				}
			}

			public override bool DefRegCreation
			{
				get
				{
					return false;
				}
			}

			public DelayCallTimer(TimeSpan timeSpan_2, TimeSpan timeSpan_3, int int_4, TimerCallback timerCallback_1)
				: base(timeSpan_2, timeSpan_3, int_4)
			{
				timerCallback_0 = timerCallback_1;
				RegCreation();
			}

			protected override void OnTick()
			{
				if (timerCallback_0 != null)
				{
					timerCallback_0();
				}
			}

			public override string ToString()
			{
				return string.Format("DelayCallTimer[{0}]", smethod_0(timerCallback_0));
			}
		}

		private class DelayStateCallTimer : Timer
		{
			private TimerStateCallback timerStateCallback_0;

			private object m_State;

			public TimerStateCallback Callback
			{
				get
				{
					return timerStateCallback_0;
				}
			}

			public override bool DefRegCreation
			{
				get
				{
					return false;
				}
			}

			public DelayStateCallTimer(TimeSpan timeSpan_2, TimeSpan timeSpan_3, int int_4, TimerStateCallback timerStateCallback_1, object object_0)
				: base(timeSpan_2, timeSpan_3, int_4)
			{
				timerStateCallback_0 = timerStateCallback_1;
				m_State = object_0;
				RegCreation();
			}

			protected override void OnTick()
			{
				if (timerStateCallback_0 != null)
				{
					timerStateCallback_0(m_State);
				}
			}

			public override string ToString()
			{
				return string.Format("DelayStateCall[{0}]", smethod_0(timerStateCallback_0));
			}
		}

		private DateTime dateTime_0;

		private TimeSpan timeSpan_0;

		private TimeSpan timeSpan_1;

		private bool bool_0;

		private int int_0;

		private int int_1;

		private TimerPriority timerPriority_0;

		private List<Timer> m_List;

		private static Dictionary<string, TimerProfile> m_Profiles = new Dictionary<string, TimerProfile>();

		private static Queue<Timer> m_Queue = new Queue<Timer>();

		private static int int_2 = 20000;

		private static int int_3;

		private bool bool_1;

		public TimerPriority Priority
		{
			get
			{
				return timerPriority_0;
			}
			set
			{
				if (timerPriority_0 != value)
				{
					timerPriority_0 = value;
					if (bool_0)
					{
						TimerThread.PriorityChange(this, (int)timerPriority_0);
					}
				}
			}
		}

		public DateTime Next
		{
			get
			{
				return dateTime_0;
			}
		}

		public TimeSpan Delay
		{
			get
			{
				return timeSpan_0;
			}
			set
			{
				timeSpan_0 = value;
			}
		}

		public TimeSpan Interval
		{
			get
			{
				return timeSpan_1;
			}
			set
			{
				timeSpan_1 = value;
			}
		}

		public bool Running
		{
			get
			{
				return bool_0;
			}
			set
			{
				if (value)
				{
					Start();
				}
				else
				{
					Stop();
				}
			}
		}

		public static Dictionary<string, TimerProfile> Profiles
		{
			get
			{
				return m_Profiles;
			}
		}

		public static int BreakCount
		{
			get
			{
				return int_2;
			}
			set
			{
				int_2 = value;
			}
		}

		public virtual bool DefRegCreation
		{
			get
			{
				return true;
			}
		}

		private static string smethod_0(Delegate delegate_0)
		{
			if ((object)delegate_0 == null)
			{
				return "null";
			}
			return string.Format("{0}.{1}", delegate_0.Method.DeclaringType.FullName, delegate_0.Method.Name);
		}

		public static void DumpInfo(TextWriter textWriter_0)
		{
			TimerThread.DumpInfo(textWriter_0);
		}

		public TimerProfile GetProfile()
		{
			string text = ToString();
			if (text == null)
			{
				text = "null";
			}
			TimerProfile value = null;
			m_Profiles.TryGetValue(text, out value);
			if (value == null)
			{
				value = (m_Profiles[text] = new TimerProfile());
			}
			return value;
		}

		public static void Slice()
		{
			lock (m_Queue)
			{
				int_3 = m_Queue.Count;
				int num = 0;
				Stopwatch stopwatch = null;
				while (num < int_2 && m_Queue.Count != 0)
				{
					Timer timer = m_Queue.Dequeue();
					TimerProfile profile = timer.GetProfile();
					if (profile != null)
					{
						if (stopwatch == null)
						{
							stopwatch = Stopwatch.StartNew();
						}
						else
						{
							stopwatch.Start();
						}
					}
					timer.OnTick();
					timer.bool_1 = false;
					num++;
					if (profile != null)
					{
						profile.RegTicked(stopwatch.Elapsed);
						stopwatch.Reset();
					}
				}
			}
		}

		public Timer(TimeSpan timeSpan_2)
			: this(timeSpan_2, TimeSpan.Zero, 1)
		{
		}

		public Timer(TimeSpan timeSpan_2, TimeSpan timeSpan_3)
			: this(timeSpan_2, timeSpan_3, 0)
		{
		}

		public virtual void RegCreation()
		{
			TimerProfile profile = GetProfile();
			if (profile != null)
			{
				profile.RegCreation();
			}
		}

		public Timer(TimeSpan timeSpan_2, TimeSpan timeSpan_3, int int_4)
		{
			timeSpan_0 = timeSpan_2;
			timeSpan_1 = timeSpan_3;
			int_1 = int_4;
			if (DefRegCreation)
			{
				RegCreation();
			}
		}

		public override string ToString()
		{
			return GetType().FullName;
		}

		public static TimerPriority ComputePriority(TimeSpan timeSpan_2)
		{
			if (timeSpan_2 >= TimeSpan.FromMinutes(1.0))
			{
				return TimerPriority.FiveSeconds;
			}
			if (timeSpan_2 >= TimeSpan.FromSeconds(10.0))
			{
				return TimerPriority.OneSecond;
			}
			if (timeSpan_2 >= TimeSpan.FromSeconds(5.0))
			{
				return TimerPriority.TwoFiftyMS;
			}
			if (timeSpan_2 >= TimeSpan.FromSeconds(2.5))
			{
				return TimerPriority.FiftyMS;
			}
			if (timeSpan_2 >= TimeSpan.FromSeconds(1.0))
			{
				return TimerPriority.TwentyFiveMS;
			}
			if (timeSpan_2 >= TimeSpan.FromSeconds(0.5))
			{
				return TimerPriority.TenMS;
			}
			return TimerPriority.EveryTick;
		}

		public static Timer DelayCall(TimeSpan timeSpan_2, TimerCallback timerCallback_0)
		{
			return DelayCall(timeSpan_2, TimeSpan.Zero, 1, timerCallback_0);
		}

		public static Timer DelayCall(TimeSpan timeSpan_2, TimeSpan timeSpan_3, TimerCallback timerCallback_0)
		{
			return DelayCall(timeSpan_2, timeSpan_3, 0, timerCallback_0);
		}

		public static Timer DelayCall(TimeSpan timeSpan_2, TimeSpan timeSpan_3, int int_4, TimerCallback timerCallback_0)
		{
			Timer timer = new DelayCallTimer(timeSpan_2, timeSpan_3, int_4, timerCallback_0);
			if (int_4 == 1)
			{
				timer.Priority = ComputePriority(timeSpan_2);
			}
			else
			{
				timer.Priority = ComputePriority(timeSpan_3);
			}
			timer.Start();
			return timer;
		}

		public static Timer DelayCall(TimeSpan timeSpan_2, TimerStateCallback timerStateCallback_0, object object_0)
		{
			return DelayCall(timeSpan_2, TimeSpan.Zero, 1, timerStateCallback_0, object_0);
		}

		public static Timer DelayCall(TimeSpan timeSpan_2, TimeSpan timeSpan_3, TimerStateCallback timerStateCallback_0, object object_0)
		{
			return DelayCall(timeSpan_2, timeSpan_3, 0, timerStateCallback_0, object_0);
		}

		public static Timer DelayCall(TimeSpan timeSpan_2, TimeSpan timeSpan_3, int int_4, TimerStateCallback timerStateCallback_0, object object_0)
		{
			Timer timer = new DelayStateCallTimer(timeSpan_2, timeSpan_3, int_4, timerStateCallback_0, object_0);
			if (int_4 == 1)
			{
				timer.Priority = ComputePriority(timeSpan_2);
			}
			else
			{
				timer.Priority = ComputePriority(timeSpan_3);
			}
			timer.Start();
			return timer;
		}

		public void Start()
		{
			if (!bool_0)
			{
				bool_0 = true;
				TimerThread.AddTimer(this);
				TimerProfile profile = GetProfile();
				if (profile != null)
				{
					profile.RegStart();
				}
			}
		}

		public void Stop()
		{
			if (bool_0)
			{
				bool_0 = false;
				TimerThread.RemoveTimer(this);
				TimerProfile profile = GetProfile();
				if (profile != null)
				{
					profile.RegStopped();
				}
			}
		}

		protected virtual void OnTick()
		{
		}
	}
}
