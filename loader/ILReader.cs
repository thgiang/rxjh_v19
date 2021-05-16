using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

namespace loader
{
	public sealed class ILReader : IEnumerable<GClass1>, IEnumerable
	{
		private static Type s_runtimeMethodInfoType;

		private static Type s_runtimeConstructorInfoType;

		private static OpCode[] s_OneByteOpCodes;

		private static OpCode[] s_TwoByteOpCodes;

		private int m_position;

		private GInterface2 m_resolver;

		private GInterface1 m_ilProvider;

		private byte[] m_byteArray;

		static ILReader()
		{
			s_runtimeMethodInfoType = Type.GetType("System.Reflection.RuntimeMethodInfo");
			s_runtimeConstructorInfoType = Type.GetType("System.Reflection.RuntimeConstructorInfo");
			s_OneByteOpCodes = new OpCode[256];
			s_TwoByteOpCodes = new OpCode[256];
			FieldInfo[] fields = typeof(OpCodes).GetFields(BindingFlags.Static | BindingFlags.Public);
			foreach (FieldInfo fieldInfo in fields)
			{
				OpCode opCode = (OpCode)fieldInfo.GetValue(null);
				ushort num = (ushort)opCode.Value;
				if (num < 256)
				{
					s_OneByteOpCodes[num] = opCode;
				}
				else if ((num & 0xFF00) == 65024)
				{
					s_TwoByteOpCodes[num & 0xFF] = opCode;
				}
			}
		}

		public ILReader(MethodBase method, byte[] code)
		{
			if (method == null)
			{
				throw new ArgumentNullException("method");
			}
			Type type = method.GetType();
			if (type != s_runtimeMethodInfoType && type != s_runtimeConstructorInfoType)
			{
				throw new ArgumentException("method must be RuntimeMethodInfo or RuntimeConstructorInfo for this constructor.");
			}
			m_ilProvider = new MethodBaseILProvider(method);
			m_resolver = new ModuleScopeTokenResolver(method);
			m_byteArray = new byte[code.Length];
			Array.Copy(code, m_byteArray, code.Length);
			m_position = 0;
		}

		public ILReader(GInterface1 ilProvider, GInterface2 tokenResolver)
		{
			if (ilProvider == null)
			{
				throw new ArgumentNullException("ilProvider");
			}
			m_resolver = tokenResolver;
			m_ilProvider = ilProvider;
			m_position = 0;
		}

		public IEnumerator<GClass1> GetEnumerator()
		{
			while (m_position < m_byteArray.Length)
			{
				yield return Next();
			}
			m_position = 0;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		private GClass1 Next()
		{
			int position = m_position;
			OpCode nop = OpCodes.Nop;
			int num = 0;
			byte b = ReadByte();
			if (b != 254)
			{
				nop = s_OneByteOpCodes[b];
			}
			else
			{
				b = ReadByte();
				nop = s_TwoByteOpCodes[b];
			}
			switch (nop.OperandType)
			{
			case OperandType.InlineBrTarget:
			{
				int int_ = ReadInt32();
				return new GClass3(position, nop, int_);
			}
			case OperandType.InlineField:
				num = ReadInt32();
				return new GClass11(m_resolver, position, nop, num);
			case OperandType.InlineI:
			{
				int int_2 = ReadInt32();
				return new GClass6(position, nop, int_2);
			}
			case OperandType.InlineI8:
			{
				long long_ = ReadInt64();
				return new GClass7(position, nop, long_);
			}
			case OperandType.InlineMethod:
				num = ReadInt32();
				return new GClass12(position, nop, num, m_resolver);
			case OperandType.InlineNone:
				return new GClass2(position, nop);
			case OperandType.InlineR:
			{
				double double_ = ReadDouble();
				return new GClass9(position, nop, double_);
			}
			default:
				throw new BadImageFormatException("unexpected OperandType " + nop.OperandType);
			case OperandType.InlineSig:
				num = ReadInt32();
				return new GClass14(position, nop, num, m_resolver);
			case OperandType.InlineString:
				num = ReadInt32();
				return new GClass16(position, nop, num, m_resolver);
			case OperandType.InlineSwitch:
			{
				int num2 = ReadInt32();
				int[] array = new int[num2];
				for (int i = 0; i < num2; i++)
				{
					array[i] = ReadInt32();
				}
				return new GClass5(position, nop, array);
			}
			case OperandType.InlineTok:
				num = ReadInt32();
				return new GClass15(position, nop, num, m_resolver);
			case OperandType.InlineType:
				num = ReadInt32();
				return new GClass13(position, nop, num, m_resolver);
			case OperandType.InlineVar:
			{
				ushort ushort_ = ReadUInt16();
				return new GClass17(position, nop, ushort_);
			}
			case OperandType.ShortInlineBrTarget:
			{
				sbyte sbyte_ = ReadSByte();
				return new GClass4(position, nop, sbyte_);
			}
			case OperandType.ShortInlineI:
			{
				byte byte_2 = ReadByte();
				return new GClass8(position, nop, byte_2);
			}
			case OperandType.ShortInlineR:
			{
				float float_ = ReadSingle();
				return new GClass10(position, nop, float_);
			}
			case OperandType.ShortInlineVar:
			{
				byte byte_ = ReadByte();
				return new GClass18(position, nop, byte_);
			}
			}
		}

		public void Accept(GClass0 visitor)
		{
			if (visitor == null)
			{
				throw new ArgumentNullException("argument 'visitor' can not be null");
			}
			using (IEnumerator<GClass1> enumerator = GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					GClass1 current = enumerator.Current;
					current.Accept(visitor);
				}
			}
		}

		private byte ReadByte()
		{
			return m_byteArray[m_position++];
		}

		private sbyte ReadSByte()
		{
			return (sbyte)ReadByte();
		}

		private ushort ReadUInt16()
		{
			int position = m_position;
			m_position += 2;
			return BitConverter.ToUInt16(m_byteArray, position);
		}

		private uint ReadUInt32()
		{
			int position = m_position;
			m_position += 4;
			return BitConverter.ToUInt32(m_byteArray, position);
		}

		private ulong ReadUInt64()
		{
			int position = m_position;
			m_position += 8;
			return BitConverter.ToUInt64(m_byteArray, position);
		}

		private int ReadInt32()
		{
			int position = m_position;
			m_position += 4;
			return BitConverter.ToInt32(m_byteArray, position);
		}

		private long ReadInt64()
		{
			int position = m_position;
			m_position += 8;
			return BitConverter.ToInt64(m_byteArray, position);
		}

		private float ReadSingle()
		{
			int position = m_position;
			m_position += 4;
			return BitConverter.ToSingle(m_byteArray, position);
		}

		private double ReadDouble()
		{
			int position = m_position;
			m_position += 8;
			return BitConverter.ToDouble(m_byteArray, position);
		}
	}
}
