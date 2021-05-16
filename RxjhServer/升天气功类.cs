using System;

namespace RxjhServer
{
	public class 升天气功类
	{
		private byte[] _气功_byte;

		public byte[] 气功_byte
		{
			get
			{
				return _气功_byte;
			}
			set
			{
				_气功_byte = value;
			}
		}

		public int 气功ID
		{
			get
			{
				return Buffer.ToInt16(气功_byte, 0);
			}
			set
			{
				System.Buffer.BlockCopy(Buffer.GetBytes(value), 0, 气功_byte, 0, 2);
			}
		}

		public int 气功量
		{
			get
			{
				return Buffer.ToInt16(气功_byte, 2);
			}
			set
			{
				System.Buffer.BlockCopy(Buffer.GetBytes(value), 0, 气功_byte, 2, 2);
			}
		}

		public 升天气功类()
		{
			气功_byte = new byte[4];
		}

		public 升天气功类(byte[] byte_0)
		{
			气功_byte = byte_0;
		}
	}
}
