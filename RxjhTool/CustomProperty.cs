using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace RxjhTool
{
	public class CustomProperty
	{
		private string string_0 = string.Empty;

		private object _defaultValue;

		private object _value;

		private object _对象;

		private PropertyInfo[] _propertyInfos;

		[CompilerGenerated]
		private string[] string_1;

		[CompilerGenerated]
		private Type type_0;

		[CompilerGenerated]
		private bool bool_0;

		[CompilerGenerated]
		private string string_2;

		[CompilerGenerated]
		private string string_3;

		[CompilerGenerated]
		private bool bool_1;

		[CompilerGenerated]
		private Type type_1;

		[CompilerGenerated]
		private bool bool_2;

		public string Name
		{
			get
			{
				return string_0;
			}
			set
			{
				string_0 = value;
				if (PropertyNames == null)
				{
					PropertyNames = new string[1]
					{
						string_0
					};
				}
			}
		}

		public string[] PropertyNames
		{
			get;
			set;
		}

		public Type ValueType
		{
			get;
			set;
		}

		public object DefaultValue
		{
			get
			{
				return _defaultValue;
			}
			set
			{
				_defaultValue = value;
				if (_defaultValue != null)
				{
					if (_value == null)
					{
						_value = _defaultValue;
					}
					if (ValueType == null)
					{
						ValueType = _defaultValue.GetType();
					}
				}
			}
		}

		public object Value
		{
			get
			{
				return _value;
			}
			set
			{
				_value = value;
				method_1();
			}
		}

		public bool IsReadOnly
		{
			get;
			set;
		}

		public string Description
		{
			get;
			set;
		}

		public string Category
		{
			get;
			set;
		}

		public bool IsBrowsable
		{
			get;
			set;
		}

		public object ObjectSource
		{
			get
			{
				return _对象;
			}
			set
			{
				_对象 = value;
				method_0();
			}
		}

		public Type EditorType
		{
			get;
			set;
		}

		public bool ConverterType
		{
			get;
			set;
		}

		protected PropertyInfo[] PropertyInfos
		{
			get
			{
				if (_propertyInfos == null)
				{
					Type type = ObjectSource.GetType();
					_propertyInfos = new PropertyInfo[PropertyNames.Length];
					for (int i = 0; i < PropertyNames.Length; i++)
					{
						_propertyInfos[i] = type.GetProperty(PropertyNames[i]);
					}
				}
				return _propertyInfos;
			}
		}

		public CustomProperty()
		{
		}

		public CustomProperty(string string_4, string string_5, bool bool_3, string string_6, string string_7, object object_0)
			: this(string_4, new string[1]
			{
				string_5
			}, null, null, null, (bool_3 ? 1 : 0) != 0, true, string_6, string_7, object_0, null, false)
		{
		}

		public CustomProperty(string string_4, string string_5, bool bool_3, string string_6, string string_7, object object_0, bool bool_4)
			: this(string_4, new string[1]
			{
				string_5
			}, null, null, null, (bool_3 ? 1 : 0) != 0, true, string_6, string_7, object_0, null, (bool_4 ? 1 : 0) != 0)
		{
		}

		public CustomProperty(string string_4, string string_5, bool bool_3, string string_6, string string_7, object object_0, Type type_2)
			: this(string_4, new string[1]
			{
				string_5
			}, null, null, null, (bool_3 ? 1 : 0) != 0, true, string_6, string_7, object_0, type_2, false)
		{
		}

		public CustomProperty(string string_4, string string_5, bool bool_3, string string_6, string string_7, object object_0, Type type_2, bool bool_4)
			: this(string_4, new string[1]
			{
				string_5
			}, null, null, null, (bool_3 ? 1 : 0) != 0, true, string_6, string_7, object_0, type_2, (bool_4 ? 1 : 0) != 0)
		{
		}

		public CustomProperty(string string_4, string[] string_5, Type type_2, object object_0, object object_1, bool bool_3, bool bool_4, string string_6, string string_7, object object_2, Type type_3, bool bool_5)
		{
			Name = string_4;
			PropertyNames = string_5;
			ValueType = type_2;
			_defaultValue = object_0;
			_value = object_1;
			IsReadOnly = bool_3;
			IsBrowsable = bool_4;
			Category = string_6;
			Description = string_7;
			ObjectSource = object_2;
			EditorType = type_3;
			ConverterType = bool_5;
		}

		protected void method_0()
		{
			if (PropertyInfos.Length != 0)
			{
				object value = PropertyInfos[0].GetValue(_对象, null);
				if (_defaultValue == null)
				{
					DefaultValue = value;
				}
				_value = value;
			}
		}

		protected void method_1()
		{
			if (_对象 != null)
			{
				PropertyInfo[] propertyInfos = PropertyInfos;
				for (int i = 0; i < propertyInfos.Length; i++)
				{
					propertyInfos[i].SetValue(_对象, _value, null);
				}
			}
		}

		public void ResetValue()
		{
			Value = DefaultValue;
		}
	}
}
