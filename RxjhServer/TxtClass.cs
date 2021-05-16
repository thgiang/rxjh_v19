using System;

namespace RxjhServer
{
	public class TxtClass : IDisposable
	{
		private int m_type;

		private string m_txt;

		public int type
		{
			get
			{
				return m_type;
			}
			set
			{
				m_type = value;
			}
		}

		public string Txt
		{
			get
			{
				return m_txt;
			}
			set
			{
				m_txt = value;
			}
		}

		public void Dispose()
		{
			m_txt = null;
		}

		public TxtClass(int type, string txtt)
		{
			m_type = type;
			m_txt = txtt;
		}
	}
}
