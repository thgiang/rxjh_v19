using System.Reflection.Emit;

namespace loader
{
	public class GClass18 : GClass1
	{
		private byte byte_0;

		public byte Ordinal
		{
			get
			{
				return byte_0;
			}
		}

		internal GClass18(int int_1, OpCode opCode_1, byte byte_1)
			: base(int_1, opCode_1)
		{
			byte_0 = byte_1;
		}

		public override void Accept(GClass0 gclass0_0)
		{
			gclass0_0.VisitShortInlineVarInstruction(this);
		}
	}
}
