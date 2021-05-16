namespace RxjhServer
{
	public class AtapiDevice
	{
		private string string_0;

		private string string_1;

		private string string_2;

		private string string_3;

		public string IP
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

		public string CpuID
		{
			get
			{
				return string_1;
			}
			set
			{
				string_1 = value;
			}
		}

		public string DriveID
		{
			get
			{
				return string_2;
			}
			set
			{
				string_2 = value;
			}
		}

		public string Mac
		{
			get
			{
				return string_3;
			}
			set
			{
				string_3 = value;
			}
		}
	}
}
