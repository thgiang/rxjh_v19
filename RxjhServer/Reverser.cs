using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace RxjhServer
{
	public class Reverser<T> : IComparer<T>
	{
		private Type type;

		private ReverserInfo info;

		public Reverser(Type type, string name, ReverserInfo.Direction direction)
		{
			this.type = type;
			info.name = name;
			if (direction != 0)
			{
				info.direction = direction;
			}
		}

		public Reverser(string className, string name, ReverserInfo.Direction direction)
		{
			try
			{
				type = Type.GetType(className, true);
				info.name = name;
				info.direction = direction;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public Reverser(T t, string name, ReverserInfo.Direction direction)
		{
			type = t.GetType();
			info.name = name;
			info.direction = direction;
		}

		int IComparer<T>.Compare(T t1, T t2)
		{
			object x = type.InvokeMember(info.name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty, null, t1, null);
			object y = type.InvokeMember(info.name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty, null, t2, null);
			if (info.direction != 0)
			{
				Swap(ref x, ref y);
			}
			return new CaseInsensitiveComparer().Compare(x, y);
		}

		private void Swap(ref object x, ref object y)
		{
			object obj = x;
			x = y;
			y = obj;
		}
	}
}
