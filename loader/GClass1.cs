using System.Reflection.Emit;

namespace loader
{
	public abstract class GClass1
	{
		protected int int_0;

		protected OpCode opCode_0;

		public int Offset
		{
			get
			{
				return int_0;
			}
		}

		public OpCode OpCode
		{
			get
			{
				return opCode_0;
			}
		}

		internal GClass1(int int_1, OpCode opCode_1)
		{
			int_0 = int_1;
			opCode_0 = opCode_1;
		}

		public abstract void Accept(GClass0 gclass0_0);
	}
}
