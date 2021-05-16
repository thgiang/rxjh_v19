using System;
using System.ComponentModel;

namespace RxjhTool
{
	[DefaultProperty("Name")]
	public class Customer
	{
		private string string_0;

		private int int_0;

		private DateTime dateTime_0;

		private string string_1;

		private string string_2;

		private string string_3;

		private bool bool_0;

		[Description("Name of the customer")]
		[Category("ID Settings")]
		public string Name
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

		[Category("ID Settings")]
		[Description("Social Security Number of the customer")]
		public string SSN
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

		[Description("Address of the customer")]
		[Category("ID Settings")]
		public string Address
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

		[Description("Date of Birth of the Customer (optional)")]
		[Category("ID Settings")]
		public DateTime DateOfBirth
		{
			get
			{
				return dateTime_0;
			}
			set
			{
				dateTime_0 = value;
			}
		}

		[Category("ID Settings")]
		[Description("Age of the customer")]
		public int Age
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

		[Description("If the customer has bought more than 10 times, this is set to true")]
		[Category("Marketting Settings")]
		public bool FrequentBuyer
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

		[Description("Most current e-mail of the customer")]
		[Category("Marketting Settings")]
		public string Email
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
