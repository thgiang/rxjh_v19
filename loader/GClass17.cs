using System.Reflection.Emit;

namespace loader
{
	public class GClass17 : GClass1
	{
		private ushort ushort_0;

		public ushort Ordinal
		{
			get
			{
				return ushort_0;
			}
		}

		internal GClass17(int int_1, OpCode opCode_1, ushort ushort_1)
			: base(int_1, opCode_1)
		{
			ushort_0 = ushort_1;
		}

		public override void Accept(GClass0 gclass0_0)
		{
			gclass0_0.VisitInlineVarInstruction(this);
		}
	}
}
