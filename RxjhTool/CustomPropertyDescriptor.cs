using System;
using System.ComponentModel;

namespace RxjhTool
{
	public class CustomPropertyDescriptor : PropertyDescriptor
	{
		private CustomProperty customProperty_0;

		public override Type ComponentType
		{
			get
			{
				return customProperty_0.GetType();
			}
		}

		public override bool IsReadOnly
		{
			get
			{
				return customProperty_0.IsReadOnly;
			}
		}

		public override Type PropertyType
		{
			get
			{
				return customProperty_0.ValueType;
			}
		}

		public override string Description
		{
			get
			{
				return customProperty_0.Description;
			}
		}

		public override string Category
		{
			get
			{
				return customProperty_0.Category;
			}
		}

		public override string DisplayName
		{
			get
			{
				return customProperty_0.Name;
			}
		}

		public override bool IsBrowsable
		{
			get
			{
				return customProperty_0.IsBrowsable;
			}
		}

		public object CustomProperty
		{
			get
			{
				return customProperty_0;
			}
		}

		public CustomPropertyDescriptor(CustomProperty customProperty_1, Attribute[] attribute_0)
			: base(customProperty_1.Name, attribute_0)
		{
			customProperty_0 = customProperty_1;
		}

		public override bool CanResetValue(object component)
		{
			return customProperty_0.DefaultValue != null;
		}

		public override object GetValue(object component)
		{
			return customProperty_0.Value;
		}

		public override void ResetValue(object component)
		{
			customProperty_0.ResetValue();
		}

		public override void SetValue(object component, object value)
		{
			customProperty_0.Value = value;
		}

		public override bool ShouldSerializeValue(object component)
		{
			return true;
		}
	}
}
