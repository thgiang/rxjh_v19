using System;

namespace RxjhServer
{
	public class TimerProfile
	{
		private int int_0;

		private int int_1;

		private int int_2;

		private int int_3;

		private TimeSpan timeSpan_0;

		private TimeSpan timeSpan_1;

		public void RegCreation()
		{
			int_0++;
		}

		public void RegStart()
		{
			int_1++;
		}

		public void RegStopped()
		{
			int_2++;
		}

		public void RegTicked(TimeSpan timeSpan_2)
		{
			int_3++;
			timeSpan_0 += timeSpan_2;
			if (timeSpan_2 > timeSpan_1)
			{
				timeSpan_1 = timeSpan_2;
			}
		}
	}
}
