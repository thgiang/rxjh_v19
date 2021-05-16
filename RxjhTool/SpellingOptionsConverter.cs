using System;
using System.ComponentModel;
using System.Globalization;

namespace RxjhTool
{
	public class SpellingOptionsConverter : ExpandableObjectConverter
	{
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			if (destinationType != typeof(Coordinate))
			{
				return base.CanConvertTo(context, destinationType);
			}
			return true;
		}

		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == typeof(string) && value is Coordinate)
			{
				Coordinate x = (Coordinate)value;
				return "地图ID:" + x.MapId + "，坐标X: " + x.CoordinateX + "，坐标Y: " + x.CoordinateY;
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}

		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			if (sourceType != typeof(string))
			{
				return base.CanConvertFrom(context, sourceType);
			}
			return true;
		}

		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			if (value is string)
			{
				try
				{
					string text = (string)value;
					int num = text.IndexOf(':');
					int num2 = text.IndexOf(',');
					if (num != -1 && num2 != -1)
					{
						text.Substring(num + 1, num2 - num - 1);
						int num3 = text.IndexOf(':', num2 + 1);
						int num4 = text.IndexOf(',', num2 + 1);
						text.Substring(num3 + 1, num4 - num3 - 1);
						int num5 = text.IndexOf(':', num4 + 1);
						text.Substring(num5 + 1);
						return new Coordinate();
					}
				}
				catch
				{
					throw new ArgumentException("无法将“" + (string)value + "”转换为 SpellingOptions 类型");
				}
			}
			return base.ConvertFrom(context, culture, value);
		}
	}
}
