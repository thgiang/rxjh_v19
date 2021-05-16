using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;

namespace RxjhTool
{
	public class CustomPropertyCollection : List<CustomProperty>, ICustomTypeDescriptor
	{
		public AttributeCollection GetAttributes()
		{
			return TypeDescriptor.GetAttributes(this, true);
		}

		public string GetClassName()
		{
			return TypeDescriptor.GetClassName(this, true);
		}

		public string GetComponentName()
		{
			return TypeDescriptor.GetComponentName(this, true);
		}

		public TypeConverter GetConverter()
		{
			return TypeDescriptor.GetConverter(this, true);
		}

		public EventDescriptor GetDefaultEvent()
		{
			return TypeDescriptor.GetDefaultEvent(this, true);
		}

		public PropertyDescriptor GetDefaultProperty()
		{
			return TypeDescriptor.GetDefaultProperty(this, true);
		}

		public object GetEditor(Type editorBaseType)
		{
			return TypeDescriptor.GetEditor(this, editorBaseType, true);
		}

		public EventDescriptorCollection GetEvents(Attribute[] attributes)
		{
			return TypeDescriptor.GetEvents(this, attributes, true);
		}

		public EventDescriptorCollection GetEvents()
		{
			return TypeDescriptor.GetEvents(this, true);
		}

		public PropertyDescriptorCollection GetProperties(Attribute[] attributes)
		{
			PropertyDescriptorCollection propertyDescriptorCollection = new PropertyDescriptorCollection(null);
			using (Enumerator enumerator = GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					CustomProperty current = enumerator.Current;
					List<Attribute> list = new List<Attribute>();
					list.Add(new CategoryAttribute(current.Category));
					if (!current.IsBrowsable)
					{
						list.Add(new BrowsableAttribute(current.IsBrowsable));
					}
					if (current.IsReadOnly)
					{
						list.Add(new ReadOnlyAttribute(current.IsReadOnly));
					}
					if (current.EditorType != null)
					{
						list.Add(new EditorAttribute(current.EditorType, typeof(UITypeEditor)));
					}
					if (current.ConverterType)
					{
						list.Add(new TypeConverterAttribute(typeof(SpellingOptionsConverter)));
					}
					propertyDescriptorCollection.Add(new CustomPropertyDescriptor(current, list.ToArray()));
				}
				return propertyDescriptorCollection;
			}
		}

		public PropertyDescriptorCollection GetProperties()
		{
			return TypeDescriptor.GetProperties(this, true);
		}

		public object GetPropertyOwner(PropertyDescriptor pd)
		{
			return this;
		}
	}
}
