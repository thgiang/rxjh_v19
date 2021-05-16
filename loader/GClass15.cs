using System.Reflection;
using System.Reflection.Emit;

namespace loader
{
	public class GClass15 : GClass1
	{
		private GInterface2 ginterface2_0;

		private int int_1;

		private MemberInfo memberInfo_0;

		public MemberInfo Member
		{
			get
			{
				if (memberInfo_0 == null)
				{
					memberInfo_0 = ginterface2_0.AsMember(Token);
				}
				return memberInfo_0;
			}
		}

		public int Token
		{
			get
			{
				return int_1;
			}
		}

		internal GClass15(int int_2, OpCode opCode_1, int int_3, GInterface2 ginterface2_1)
			: base(int_2, opCode_1)
		{
			ginterface2_0 = ginterface2_1;
			int_1 = int_3;
		}

		public override void Accept(GClass0 gclass0_0)
		{
			gclass0_0.VisitInlineTokInstruction(this);
		}
	}
}
