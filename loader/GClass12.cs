using System.Reflection;
using System.Reflection.Emit;

namespace loader
{
	public class GClass12 : GClass1
	{
		private GInterface2 ginterface2_0;

		private int int_1;

		private MethodBase methodBase_0;

		public MethodBase Method
		{
			get
			{
				if (methodBase_0 == null)
				{
					methodBase_0 = ginterface2_0.AsMethod(int_1);
				}
				return methodBase_0;
			}
		}

		public int Token
		{
			get
			{
				return int_1;
			}
		}

		internal GClass12(int int_2, OpCode opCode_1, int int_3, GInterface2 ginterface2_1)
			: base(int_2, opCode_1)
		{
			ginterface2_0 = ginterface2_1;
			int_1 = int_3;
		}

		public override void Accept(GClass0 gclass0_0)
		{
			gclass0_0.VisitInlineMethodInstruction(this);
		}
	}
}
