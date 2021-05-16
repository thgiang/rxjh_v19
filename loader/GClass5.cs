using System.Reflection.Emit;

namespace loader
{
	public class GClass5 : GClass1
	{
		private int[] m_deltas;

		private int[] m_targetOffsets;

		public int[] Deltas
		{
			get
			{
				return (int[])m_deltas.Clone();
			}
		}

		public int[] TargetOffsets
		{
			get
			{
				if (m_targetOffsets == null)
				{
					int num = m_deltas.Length;
					int num2 = 5 + 4 * num;
					m_targetOffsets = new int[num];
					for (int i = 0; i < num; i++)
					{
						m_targetOffsets[i] = int_0 + m_deltas[i] + num2;
					}
				}
				return m_targetOffsets;
			}
		}

		internal GClass5(int int_1, OpCode opCode_1, int[] int_2)
			: base(int_1, opCode_1)
		{
			m_deltas = int_2;
		}

		public override void Accept(GClass0 gclass0_0)
		{
			gclass0_0.VisitInlineSwitchInstruction(this);
		}
	}
}
