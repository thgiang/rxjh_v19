using System;

namespace DNGuard
{
	public sealed class ObfuscationAttribute : Attribute
	{
		private bool bool_0 = true;

		private bool bool_1 = true;

		private string string_0 = "all";

		private bool bool_2 = true;

		public bool ApplyToMembers
		{
			get
			{
				return bool_0;
			}
			set
			{
				bool_0 = value;
			}
		}

		public bool Exclude
		{
			get
			{
				return bool_1;
			}
			set
			{
				bool_1 = value;
			}
		}

		public string Feature
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

		public bool StripAfterObfuscation
		{
			get
			{
				return bool_2;
			}
			set
			{
				bool_2 = value;
			}
		}
	}
}
