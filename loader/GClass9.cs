using System.Reflection.Emit;

namespace loader
{
	public class GClass9 : GClass1
	{
		private double double_0;

		public double Double
		{
			get
			{
				return double_0;
			}
		}

		internal GClass9(int int_1, OpCode opCode_1, double double_1)
			: base(int_1, opCode_1)
		{
			double_0 = double_1;
		}

		public override void Accept(GClass0 gclass0_0)
		{
			gclass0_0.VisitInlineRInstruction(this);
		}
	}
}
