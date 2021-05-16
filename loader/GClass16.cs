using System.Reflection.Emit;

namespace loader
{
	public class GClass16 : GClass1
	{
		private GInterface2 ginterface2_0;

		private int int_1;

		private string string_0;

		public string String
		{
			get
			{
				if (string_0 == null)
				{
					string_0 = ginterface2_0.AsString(Token);
				}
				return string_0;
			}
		}

		public int Token
		{
			get
			{
				return int_1;
			}
		}

		internal GClass16(int int_2, OpCode opCode_1, int int_3, GInterface2 ginterface2_1)
			: base(int_2, opCode_1)
		{
			ginterface2_0 = ginterface2_1;
			int_1 = int_3;
		}

		public override void Accept(GClass0 gclass0_0)
		{
			gclass0_0.VisitInlineStringInstruction(this);
		}
	}
}
