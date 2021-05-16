using System.Reflection.Emit;

namespace loader
{
	public class GClass14 : GClass1
	{
		private GInterface2 ginterface2_0;

		private int int_1;

		private byte[] m_signature;

		public byte[] Signature
		{
			get
			{
				if (m_signature == null)
				{
					m_signature = ginterface2_0.AsSignature(int_1);
				}
				return m_signature;
			}
		}

		public int Token
		{
			get
			{
				return int_1;
			}
		}

		internal GClass14(int int_2, OpCode opCode_1, int int_3, GInterface2 ginterface2_1)
			: base(int_2, opCode_1)
		{
			ginterface2_0 = ginterface2_1;
			int_1 = int_3;
		}

		public override void Accept(GClass0 gclass0_0)
		{
			gclass0_0.VisitInlineSigInstruction(this);
		}
	}
}
