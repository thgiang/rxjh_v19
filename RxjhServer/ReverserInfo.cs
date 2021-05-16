namespace RxjhServer
{
	public struct ReverserInfo
	{
		public enum Direction
		{
			ASC,
			DESC
		}

		public enum Target
		{
			CUSTOMER,
			FORM,
			FIELD,
			SERVER
		}

		public string name;

		public Direction direction;

		public Target target;
	}
}
