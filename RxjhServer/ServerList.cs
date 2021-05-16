namespace RxjhServer
{
	public class ServerList
	{
		private string string_0;

		private int int_0;

		private int int_1;

		public string 服务器IP
		{
			get
			{
				return string_0;
			}
			set
			{
				string_0 = value;
			}
		}

		public int 服务器端口
		{
			get
			{
				return int_0;
			}
			set
			{
				int_0 = value;
			}
		}

		public int 服务器ID
		{
			get
			{
				return int_1;
			}
			set
			{
				int_1 = value;
			}
		}
	}
}
