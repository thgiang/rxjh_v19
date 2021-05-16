using System.Reflection.Emit;

namespace loader
{
	public class GClass6 : GClass1
	{
		private int int_1;

		public int Int32
		{
			get
			{
				return int_1;
			}
		}

		internal GClass6(int int_2, OpCode opCode_1, int int_3)
			: base(int_2, opCode_1)
		{
			int_1 = int_3;
		}

		public override void Accept(GClass0 gclass0_0)
		{
			gclass0_0.VisitInlineIInstruction(this);
		}
	}
}
