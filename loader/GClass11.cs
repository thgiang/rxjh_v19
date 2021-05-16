using System.Reflection;
using System.Reflection.Emit;

namespace loader
{
	public class GClass11 : GClass1
	{
		private GInterface2 ginterface2_0;

		private int int_1;

		private FieldInfo fieldInfo_0;

		public FieldInfo Field
		{
			get
			{
				if (fieldInfo_0 == null)
				{
					fieldInfo_0 = ginterface2_0.AsField(int_1);
				}
				return fieldInfo_0;
			}
		}

		public int Token
		{
			get
			{
				return int_1;
			}
		}

		internal GClass11(GInterface2 ginterface2_1, int int_2, OpCode opCode_1, int int_3)
			: base(int_2, opCode_1)
		{
			ginterface2_0 = ginterface2_1;
			int_1 = int_3;
		}

		public override void Accept(GClass0 gclass0_0)
		{
			gclass0_0.VisitInlineFieldInstruction(this);
		}
	}
}
