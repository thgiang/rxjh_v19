using System.Reflection.Emit;

namespace loader
{
	public class GClass4 : GClass1
	{
		private sbyte sbyte_0;

		public sbyte Delta
		{
			get
			{
				return sbyte_0;
			}
		}

		public int TargetOffset
		{
			get
			{
				return int_0 + sbyte_0 + 1 + 1;
			}
		}

		internal GClass4(int int_1, OpCode opCode_1, sbyte sbyte_1)
			: base(int_1, opCode_1)
		{
			sbyte_0 = sbyte_1;
		}

		public override void Accept(GClass0 gclass0_0)
		{
			gclass0_0.VisitShortInlineBrTargetInstruction(this);
		}
	}
}
