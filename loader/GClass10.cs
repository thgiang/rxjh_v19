using System.Reflection.Emit;

namespace loader
{
	public class GClass10 : GClass1
	{
		private float float_0;

		public float Single
		{
			get
			{
				return float_0;
			}
		}

		internal GClass10(int int_1, OpCode opCode_1, float float_1)
			: base(int_1, opCode_1)
		{
			float_0 = float_1;
		}

		public override void Accept(GClass0 gclass0_0)
		{
			gclass0_0.VisitShortInlineRInstruction(this);
		}
	}
}
