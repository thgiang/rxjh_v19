using System;
using System.Reflection.Emit;

namespace loader
{
	public class GClass13 : GClass1
	{
		private GInterface2 ginterface2_0;

		private int int_1;

		private Type type_0;

		public Type Type
		{
			get
			{
				if (type_0 == null)
				{
					type_0 = ginterface2_0.AsType(int_1);
				}
				return type_0;
			}
		}

		public int Token
		{
			get
			{
				return int_1;
			}
		}

		internal GClass13(int int_2, OpCode opCode_1, int int_3, GInterface2 ginterface2_1)
			: base(int_2, opCode_1)
		{
			ginterface2_0 = ginterface2_1;
			int_1 = int_3;
		}

		public override void Accept(GClass0 gclass0_0)
		{
			gclass0_0.VisitInlineTypeInstruction(this);
		}
	}
}
