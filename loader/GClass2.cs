using System.Reflection.Emit;

namespace loader
{
	public class GClass2 : GClass1
	{
		internal GClass2(int int_1, OpCode opCode_1)
			: base(int_1, opCode_1)
		{
		}

		public override void Accept(GClass0 gclass0_0)
		{
			gclass0_0.VisitInlineNoneInstruction(this);
		}
	}
}
