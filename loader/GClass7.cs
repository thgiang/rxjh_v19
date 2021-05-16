using System.Reflection.Emit;

namespace loader
{
	public class GClass7 : GClass1
	{
		private long long_0;

		public long Int64
		{
			get
			{
				return long_0;
			}
		}

		internal GClass7(int int_1, OpCode opCode_1, long long_1)
			: base(int_1, opCode_1)
		{
			long_0 = long_1;
		}

		public override void Accept(GClass0 gclass0_0)
		{
			gclass0_0.VisitInlineI8Instruction(this);
		}
	}
}
