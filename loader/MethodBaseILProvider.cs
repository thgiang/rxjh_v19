using System.Reflection;

namespace loader
{
	public class MethodBaseILProvider : GInterface1
	{
		private MethodBase m_method;

		private byte[] m_byteArray;

		public MethodBaseILProvider(MethodBase method)
		{
			m_method = method;
		}

		public byte[] GetByteArray()
		{
			if (m_byteArray == null)
			{
				MethodBody methodBody = m_method.GetMethodBody();
				m_byteArray = ((methodBody == null) ? new byte[0] : methodBody.GetILAsByteArray());
			}
			return m_byteArray;
		}
	}
}
