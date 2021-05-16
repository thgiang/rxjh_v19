using System.Reflection.Emit;

namespace loader
{
	public class GClass3 : GClass1
	{
		private int int_1;

		public int Delta
		{
			get
			{
				return int_1;
			}
		}

		public int TargetOffset
		{
			get
			{
				return int_0 + int_1 + 1 + 4;
			}
		}

		internal GClass3(int int_2, OpCode opCode_1, int int_3)
			: base(int_2, opCode_1)
		{
			int_1 = int_3;
		}

		public override void Accept(GClass0 gclass0_0)
		{
			gclass0_0.VisitInlineBrTargetInstruction(this);
		}
	}
}
