using System;

namespace RxjhServer
{
	public class MoveVector
	{
		private float float_0;

		private float float_1;

		private float float_2;

		private float float_3;

		private float float_4;

		private float float_5;

		private float float_6;

		private float float_7;

		private DateTime dateTime_0;

		public MoveVector(Players players_0, float float_8, float float_9, float float_10)
		{
			dateTime_0 = DateTime.Now;
			float_0 = float_8;
			float_1 = float_9;
			float_2 = float_10;
			float_3 = players_0.人物坐标_X;
			float_4 = players_0.人物坐标_Y;
			float_5 = players_0.人物坐标_Z;
			float_7 = players_0.Speed;
			float num = float_8 - players_0.人物坐标_X;
			float num2 = float_9 - players_0.人物坐标_Y;
			float_6 = (float)Math.Sqrt((double)num * (double)num + (double)num2 * (double)num2) / (players_0.Speed / 1000f);
		}

		public MoveVector(Players players_0, float float_8, float float_9, float float_10, float float_11, float float_12, float float_13)
		{
			dateTime_0 = DateTime.Now;
			float_0 = float_8;
			float_1 = float_9;
			float_2 = float_10;
			float_3 = float_11;
			float_4 = float_12;
			float_5 = float_13;
			float_7 = players_0.Speed;
			float num = float_8 - players_0.人物坐标_X;
			float num2 = float_9 - players_0.人物坐标_Y;
			float_6 = (float)Math.Sqrt((double)num * (double)num + (double)num2 * (double)num2) / (players_0.Speed / 1000f);
		}

		public void Get(out float float_8, out float float_9, out float float_10)
		{
			float num = (float)DateTime.Now.Subtract(dateTime_0).TotalMilliseconds / float_6;
			if ((double)float_6 != 15.0 && (double)num <= 31.0)
			{
				float num2 = float_0 - float_3;
				float num3 = float_1 - float_4;
				double num4 = (double)float_2 - (double)float_5;
				float num5 = num2 * num;
				float num6 = num3 * num;
				double num7 = num;
				float num8 = (float)(num4 * num7);
				float_8 = float_3 + num5;
				float_9 = float_4 + num6;
				float_10 = float_5 + num8;
			}
			else
			{
				float_8 = float_0;
				float_9 = float_1;
				float_10 = float_2;
			}
		}

		public bool NearDestination()
		{
			return DateTime.Now.Subtract(dateTime_0).TotalMilliseconds - (double)float_6 < 1000.0;
		}

		public bool ReachDestination()
		{
			if (!(DateTime.Now.Subtract(dateTime_0).TotalMilliseconds / (double)float_6 > 1.0))
			{
				return (double)float_6 == 0.0;
			}
			return true;
		}

		public void Update(float float_8, float float_9, float float_10, float float_11)
		{
			Get(out float_3, out float_4, out float_5);
			dateTime_0 = DateTime.Now;
			float num = float_8 - float_3;
			float num2 = float_9 - float_4;
			float_0 = float_8;
			float_1 = float_9;
			float_2 = float_10;
			float_6 = (float)Math.Sqrt((double)num * (double)num + (double)num2 * (double)num2) / (float_11 / 1000f);
		}
	}
}
