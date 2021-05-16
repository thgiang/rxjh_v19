#define DEBUG
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;

namespace loader
{
	internal class Class4
	{
		private struct Struct6
		{
			public Type type_0;

			public Class5 class5_0;
		}

		private class Exception0 : Exception
		{
			public Exception0(string string_0)
				: base(string_0)
			{
			}
		}

		private class Class6 : GClass0
		{
			private DynamicILInfo dynamicILInfo_0;

			private byte[] code;

			private MethodBase methodBase_0;

			private Type type_0;

			public Class6(DynamicILInfo dynamicILInfo_1, byte[] byte_0, MethodBase methodBase_1, Type type_1)
			{
				dynamicILInfo_0 = dynamicILInfo_1;
				code = byte_0;
				methodBase_0 = methodBase_1;
				type_0 = type_1;
			}

			public override void VisitInlineMethodInstruction(GClass12 gclass12_0)
			{
				RuntimeMethodHandle methodHandle = gclass12_0.Method.MethodHandle;
				int int_ = smethod_5(gclass12_0.Token, dynamicILInfo_0, methodBase_0, type_0);
				method_0(int_, gclass12_0.Offset + gclass12_0.OpCode.Size);
			}

			public override void VisitInlineSigInstruction(GClass14 gclass14_0)
			{
				method_0(dynamicILInfo_0.GetTokenFor(gclass14_0.Signature), gclass14_0.Offset + gclass14_0.OpCode.Size);
			}

			public override void VisitInlineFieldInstruction(GClass11 gclass11_0)
			{
				int int_ = smethod_5(gclass11_0.Token, dynamicILInfo_0, methodBase_0, type_0);
				method_0(int_, gclass11_0.Offset + gclass11_0.OpCode.Size);
			}

			public override void VisitInlineStringInstruction(GClass16 gclass16_0)
			{
				method_0(dynamicILInfo_0.GetTokenFor(gclass16_0.String), gclass16_0.Offset + gclass16_0.OpCode.Size);
			}

			public override void VisitInlineTypeInstruction(GClass13 gclass13_0)
			{
				int int_ = smethod_5(gclass13_0.Token, dynamicILInfo_0, methodBase_0, type_0);
				method_0(int_, gclass13_0.Offset + gclass13_0.OpCode.Size);
			}

			public override void VisitInlineTokInstruction(GClass15 gclass15_0)
			{
				MemberInfo member = gclass15_0.Member;
				int num = 0;
				num = smethod_5(gclass15_0.Token, dynamicILInfo_0, methodBase_0, type_0);
				method_0(num, gclass15_0.Offset + gclass15_0.OpCode.Size);
			}

			private void method_0(int int_0, int int_1)
			{
				code[int_1++] = (byte)int_0;
				code[int_1++] = (byte)(int_0 >> 8);
				code[int_1++] = (byte)(int_0 >> 16);
				code[int_1++] = (byte)(int_0 >> 24);
			}
		}

		public struct Struct7
		{
			public Type type_0;

			public int int_0;
		}

		public class Class5
		{
			public DynamicMethod dynamicMethod_0;

			public string string_0 = "";

			private static string string_1 = "";

			public Class5(string string_2, Type type_0, Type[] type_1, Module module_0, bool bool_0)
			{
				dynamicMethod_0 = new DynamicMethod(string_2, type_0, type_1, module_0, bool_0);
			}

			public Class5(string string_2, Type type_0, Type[] type_1, Type type_2, bool bool_0)
			{
				dynamicMethod_0 = new DynamicMethod(string_2, type_0, type_1, type_2, bool_0);
			}

			public object method_0(object object_0, object[] object_1)
			{
				string str = string_1;
				StackTrace stackTrace = new StackTrace();
				StackFrame frame = stackTrace.GetFrame(1);
				MethodBase method = frame.GetMethod();
				string text = method.ToString();
				if (method.ReflectedType != null)
				{
					text += method.ReflectedType.ToString();
				}
				try
				{
					smethod_30(str + text);
					string_1 += "    ";
					object result = dynamicMethod_0.Invoke(object_0, object_1);
					smethod_30(str + "--" + text + "/>");
					string_1 = str;
					return result;
				}
				catch (TargetInvocationException ex)
				{
					try
					{
						string_1 = str;
						string text2 = "---------------------------------------------loader catch inner exception: " + ex.InnerException.Message;
						string text3 = "\t----" + DateTime.Now.ToString() + " method name: " + string_0;
						smethod_30(text2);
						smethod_30(text3);
					}
					catch (Exception)
					{
					}
					throw ex.InnerException;
				}
				catch (Exception ex3)
				{
					string_1 = str;
					string text2 = "---------------------------------------------loader catch system exception: " + ex3.InnerException.Message;
					string text3 = "\t----" + DateTime.Now.ToString() + " method name: " + string_0;
					smethod_30(text2);
					smethod_30(text3);
					throw ex3;
				}
			}
		}

		public enum Enum0
		{
			mdtModule = 0,
			mdtTypeRef = 0x1000000,
			mdtTypeDef = 0x2000000,
			mdtFieldDef = 0x4000000,
			mdtMethodDef = 100663296,
			mdtParamDef = 0x8000000,
			mdtInterfaceImpl = 150994944,
			mdtMemberRef = 167772160,
			mdtCustomAttribute = 201326592,
			mdtPermission = 234881024,
			mdtSignature = 285212672,
			mdtEvent = 335544320,
			mdtProperty = 385875968,
			mdtMethodImpl = 419430400,
			mdtModuleRef = 436207616,
			mdtTypeSpec = 452984832,
			mdtAssembly = 0x20000000,
			mdtAssemblyRef = 587202560,
			mdtFile = 637534208,
			mdtExportedType = 654311424,
			mdtManifestResource = 671088640,
			mdtGenericParam = 704643072,
			mdtMethodSpec = 721420288,
			mdtGenericParamConstraint = 738197504,
			mdtString = 1879048192,
			mdtName = 1895825408,
			mdtBaseType = 1912602624
		}

		public enum Enum1
		{
			ELEMENT_TYPE_END = 0,
			ELEMENT_TYPE_VOID = 1,
			ELEMENT_TYPE_BOOLEAN = 2,
			ELEMENT_TYPE_CHAR = 3,
			ELEMENT_TYPE_I1 = 4,
			ELEMENT_TYPE_U1 = 5,
			ELEMENT_TYPE_I2 = 6,
			ELEMENT_TYPE_U2 = 7,
			ELEMENT_TYPE_I4 = 8,
			ELEMENT_TYPE_U4 = 9,
			ELEMENT_TYPE_I8 = 10,
			ELEMENT_TYPE_U8 = 11,
			ELEMENT_TYPE_R4 = 12,
			ELEMENT_TYPE_R8 = 13,
			ELEMENT_TYPE_STRING = 14,
			ELEMENT_TYPE_PTR = 0xF,
			ELEMENT_TYPE_BYREF = 0x10,
			ELEMENT_TYPE_VALUETYPE = 17,
			ELEMENT_TYPE_CLASS = 18,
			ELEMENT_TYPE_VAR = 19,
			ELEMENT_TYPE_ARRAY = 20,
			ELEMENT_TYPE_GENERICINST = 21,
			ELEMENT_TYPE_TYPEDBYREF = 22,
			ELEMENT_TYPE_I = 24,
			ELEMENT_TYPE_U = 25,
			ELEMENT_TYPE_FNPTR = 27,
			ELEMENT_TYPE_OBJECT = 28,
			ELEMENT_TYPE_SZARRAY = 29,
			ELEMENT_TYPE_MVAR = 30,
			ELEMENT_TYPE_CMOD_REQD = 0x1F,
			ELEMENT_TYPE_CMOD_OPT = 0x20,
			ELEMENT_TYPE_INTERNAL = 33,
			ELEMENT_TYPE_MAX = 34,
			ELEMENT_TYPE_MODIFIER = 0x40,
			ELEMENT_TYPE_SENTINEL = 65,
			ELEMENT_TYPE_PINNED = 69
		}

		public enum Enum2
		{
			IMAGE_CEE_CS_CALLCONV_DEFAULT = 0,
			IMAGE_CEE_CS_CALLCONV_VARARG = 5,
			IMAGE_CEE_CS_CALLCONV_FIELD = 6,
			IMAGE_CEE_CS_CALLCONV_LOCAL_SIG = 7,
			IMAGE_CEE_CS_CALLCONV_PROPERTY = 8,
			IMAGE_CEE_CS_CALLCONV_UNMGD = 9,
			IMAGE_CEE_CS_CALLCONV_GENERICINST = 10,
			IMAGE_CEE_CS_CALLCONV_NATIVEVARARG = 11,
			IMAGE_CEE_CS_CALLCONV_MAX = 12,
			IMAGE_CEE_CS_CALLCONV_MASK = 0xF,
			IMAGE_CEE_CS_CALLCONV_HASTHIS = 0x20,
			IMAGE_CEE_CS_CALLCONV_EXPLICITTHIS = 0x40,
			IMAGE_CEE_CS_CALLCONV_GENERIC = 0x10
		}

		private static Dictionary<Struct7, Struct6> dm_dict = new Dictionary<Struct7, Struct6>();

		private static byte[] rc4_key = new byte[16]
		{
			114,
			99,
			52,
			95,
			107,
			101,
			121,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0
		};

		public static int int_0 = 2;

		public static int int_1 = 3;

		public static int int_2 = 8;

		public static int int_3 = 16;

		private static byte[] g_key = null;

		public static StreamWriter streamWriter_0 = null;

		public static bool bool_0 = true;

		private static StreamWriter streamWriter_1 = null;

		private static string string_0 = "log.txt";

		private static int int_4 = 0;

		public static T smethod_0<T>(ref T gparam_0)
		{
			return gparam_0;
		}

		public static object smethod_1(object object_0)
		{
			return object_0;
		}

		public static object[] smethod_2(object[] object_0, object object_1)
		{
			return new object[2]
			{
				object_0,
				object_1
			};
		}

		public static object[] smethod_3()
		{
			object[] array = new object[2];
			object[] array2 = array;
			array2[1] = new object();
			array2[0] = array2[1];
			return array2;
		}

		private static int smethod_4(int int_5, byte[] byte_0)
		{
			int num = 0;
			return byte_0[int_5] | (byte_0[int_5 + 1] << 8) | (byte_0[int_5 + 2] << 16) | (byte_0[int_5 + 3] << 24);
		}

		private static int smethod_5(int int_5, DynamicILInfo dynamicILInfo_0, MethodBase methodBase_0, Type type_0)
		{
			int num = 0;
			Module module = Assembly.GetExecutingAssembly().GetModules()[0];
			ModuleHandle moduleHandle = module.ModuleHandle;
			Type[] array = null;
			Type[] array2 = null;
			RuntimeTypeHandle[] array3 = null;
			RuntimeTypeHandle[] array4 = null;
			int num2 = 0;
			num = int_5;
			if (type_0 != null && type_0.IsGenericType)
			{
				array = type_0.GetGenericArguments();
			}
			if (methodBase_0.IsGenericMethod)
			{
				array2 = methodBase_0.GetGenericArguments();
			}
			if (array != null)
			{
				array3 = new RuntimeTypeHandle[array.Length];
				for (num2 = 0; num2 < array.Length; num2++)
				{
					array3[num2] = array[num2].TypeHandle;
				}
			}
			if (array2 != null)
			{
				array4 = new RuntimeTypeHandle[array2.Length];
				for (num2 = 0; num2 < array2.Length; num2++)
				{
					array4[num2] = array2[num2].TypeHandle;
				}
			}
			switch (smethod_41(int_5))
			{
			case 100663296u:
				if (methodBase_0.DeclaringType != null && methodBase_0.DeclaringType.IsGenericType && type_0 != null)
				{
					MethodBase methodBase = module.ResolveMethod(int_5, array, array2);
					if (methodBase.DeclaringType != null && methodBase_0.DeclaringType.IsGenericType)
					{
						num = dynamicILInfo_0.GetTokenFor(moduleHandle.ResolveMethodHandle(int_5, array3, array4), type_0.TypeHandle);
						break;
					}
					methodBase = module.ResolveMethod(int_5);
					num = ((methodBase.DeclaringType == null) ? dynamicILInfo_0.GetTokenFor(methodBase.MethodHandle) : dynamicILInfo_0.GetTokenFor(methodBase.MethodHandle, methodBase.DeclaringType.TypeHandle));
				}
				else
				{
					MethodBase methodBase = module.ResolveMethod(int_5);
					num = ((methodBase.DeclaringType == null) ? dynamicILInfo_0.GetTokenFor(methodBase.MethodHandle) : dynamicILInfo_0.GetTokenFor(methodBase.MethodHandle, methodBase.DeclaringType.TypeHandle));
				}
				break;
			case 67108864u:
				num = dynamicILInfo_0.GetTokenFor(moduleHandle.ResolveFieldHandle(int_5, array3, array4));
				break;
			case 16777216u:
			case 33554432u:
			case 452984832u:
				num = dynamicILInfo_0.GetTokenFor(moduleHandle.ResolveTypeHandle(int_5, array3, array4));
				break;
			case 167772160u:
			{
				MemberInfo memberInfo = module.ResolveMember(int_5, array, array2);
				MemberTypes memberType = memberInfo.MemberType;
				if (memberType == MemberTypes.Constructor || memberType == MemberTypes.Method)
				{
					num = ((memberInfo.DeclaringType == null) ? dynamicILInfo_0.GetTokenFor(moduleHandle.ResolveMethodHandle(int_5, array3, array4)) : dynamicILInfo_0.GetTokenFor(moduleHandle.ResolveMethodHandle(int_5, array3, array4), memberInfo.DeclaringType.TypeHandle));
				}
				else if (memberType == MemberTypes.Field)
				{
					num = dynamicILInfo_0.GetTokenFor(moduleHandle.ResolveFieldHandle(int_5, array3, array4));
				}
				break;
			}
			default:
				throw new Exception(string.Format("sense: unkown token type for 0x%{0:X}", int_5));
			case 1879048192u:
			{
				string literal = module.ResolveString(int_5);
				num = dynamicILInfo_0.GetTokenFor(literal);
				break;
			}
			case 721420288u:
			{
				MemberInfo memberInfo = module.ResolveMember(int_5, array, array2);
				num = ((memberInfo.DeclaringType == null) ? dynamicILInfo_0.GetTokenFor(moduleHandle.ResolveMethodHandle(int_5, array3, array4)) : dynamicILInfo_0.GetTokenFor(moduleHandle.ResolveMethodHandle(int_5, array3, array4), memberInfo.DeclaringType.TypeHandle));
				break;
			}
			}
			return num;
		}

		private static int smethod_6(byte[] byte_0)
		{
			return (2 == (byte_0[0] & 3)) ? 1 : 0;
		}

		private static int smethod_7(byte[] byte_0)
		{
			int num = 0;
			if (smethod_6(byte_0) == 1)
			{
				return 1;
			}
			num = byte_0[1];
			num &= 0xF0;
			num >>= 4;
			return num * 4;
		}

		private static int smethod_8(byte[] byte_0)
		{
			int num = 0;
			if (smethod_6(byte_0) == 1)
			{
				num = byte_0[0];
				return num / 4;
			}
			return smethod_40(4, byte_0);
		}

		private static int smethod_9(byte[] byte_0)
		{
			int result = 0;
			if (smethod_6(byte_0) == 1)
			{
				return 0;
			}
			int num = byte_0[0];
			int num2 = byte_0[1];
			num2 &= 0xF;
			num2 <<= 8;
			num = (num2 | num);
			if ((num & 8) == 8)
			{
				result = 1;
			}
			return result;
		}

		private static int smethod_10(byte[] byte_0)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			num2 = smethod_7(byte_0);
			num3 = smethod_8(byte_0);
			int num4 = num2 + num3;
			return (num4 + 3) / 4 * 4;
		}

		private static int smethod_11(byte[] byte_0)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			num2 = smethod_7(byte_0);
			num3 = smethod_8(byte_0);
			int num4 = num2 + num3;
			num4 = (num4 + 3) / 4 * 4;
			if ((byte_0[num4] & 0x40) == 64)
			{
				num = smethod_39(num4 + 1, byte_0);
				int num5 = 24;
				int num6 = (num - 4) % 24;
				if (num6 != 0)
				{
					num += num5 - num6;
				}
				smethod_38(num, num4 + 1, byte_0);
			}
			else
			{
				num = byte_0[num4 + 1];
				int num6 = (num - 4) % 12;
				if (num6 != 0)
				{
					num += 12 - num6;
				}
				byte_0[num4 + 1] = (byte)num;
			}
			return num;
		}

		public static byte[] smethod_12(byte[] byte_0)
		{
			int num = smethod_8(byte_0);
			int sourceIndex = smethod_7(byte_0);
			byte[] array = new byte[num];
			Array.Copy(byte_0, sourceIndex, array, 0, num);
			return array;
		}

		public static byte[] smethod_13(byte[] byte_0)
		{
			int num = 0;
			int sourceIndex = 0;
			if (smethod_9(byte_0) == 1)
			{
				sourceIndex = smethod_10(byte_0);
				num = smethod_11(byte_0);
			}
			byte[] array = new byte[num];
			Array.Copy(byte_0, sourceIndex, array, 0, num);
			return array;
		}

		public static int[] smethod_14(byte[] byte_0)
		{
			int[] array = new int[2];
			if (smethod_6(byte_0) == 1)
			{
				array[0] = 0;
				array[1] = 8;
			}
			else
			{
				short num = byte_0[0];
				short num2 = byte_0[1];
				num2 = (short)(num2 & 0xF);
				num2 = (short)(num2 << 8);
				num = (short)(num2 | num);
				if ((num & int_3) == int_3)
				{
					array[0] = 1;
				}
				array[1] = smethod_37(2, byte_0);
			}
			return array;
		}

		private static void smethod_15(uint uint_0)
		{
			byte[] byte_ = GClass21.smethod_17(uint_0, 16);
			GClass19.smethod_18(byte_);
			g_key = byte_;
		}

		private static void smethod_16(byte[] byte_0)
		{
			for (int i = 0; i < byte_0.Length; i++)
			{
				Console.Write(string.Format("{0:X2} ", byte_0[i]));
				if (i % 16 == 15)
				{
					Console.Write("\n\t");
				}
			}
			Console.Write("\n");
		}

		private static byte[] smethod_17(uint uint_0, int int_5, uint uint_1)
		{
			byte[] byte_ = GClass21.smethod_17(uint_0, int_5);
			if (g_key == null)
			{
				smethod_15(uint_1);
			}
			if (uint_1 != 0)
			{
				Class8.Struct8 struct8_ = default(Class8.Struct8);
				Class8.smethod_0(ref struct8_, g_key, g_key.Length);
				Class8.smethod_1(ref struct8_, byte_, ref byte_, int_5);
			}
			return byte_;
		}

		private static byte[] smethod_18(uint uint_0, uint uint_1, MethodBase methodBase_0)
		{
			byte[] array = null;
			if (uint_1 != 0)
			{
				return GClass21.smethod_17(uint_0, (int)uint_1);
			}
			return new byte[0];
		}

		private static byte[] smethod_19(uint uint_0, MethodBase methodBase_0)
		{
			if (uint_0 != 0)
			{
				try
				{
					byte[] byte_ = GClass21.smethod_17(uint_0, 4);
					int int_ = 0;
					int num = smethod_34(byte_, ref int_);
					return GClass21.smethod_17((uint)((int)uint_0 + int_), num);
				}
				catch (Exception)
				{
					throw new Exception("sense reading local var sig error: " + methodBase_0.Name);
				}
			}
			return new byte[0];
		}

		public static Class5 smethod_20(object object_0, MethodBase methodBase_0, uint uint_0, int int_5, uint uint_1, uint uint_2, uint uint_3, uint uint_4, int int_6)
		{
			try
			{
				Type type = null;
				type = ((methodBase_0.DeclaringType == null) ? object_0.GetType() : methodBase_0.DeclaringType);
				Struct7 key = default(Struct7);
				key.type_0 = type;
				key.int_0 = int_6;
				bool flag = false;
				Struct6 value;
				lock (dm_dict)
				{
					flag = dm_dict.TryGetValue(key, out value);
				}
				if (flag)
				{
					if (value.type_0 != type)
					{
						throw new Exception0("sense: fail to match method owner type");
					}
					return value.class5_0;
				}
				Class5 @class = null;
				byte[] byte_ = smethod_18(uint_1, uint_2, methodBase_0);
				byte[] byte_2 = smethod_19(uint_3, methodBase_0);
				byte[] byte_3 = smethod_17(uint_0, int_5, uint_4);
				byte[] byte_4 = smethod_12(byte_3);
				byte[] byte_5 = smethod_13(byte_3);
				int[] int_7 = smethod_14(byte_3);
				@class = (value.class5_0 = smethod_23(object_0, methodBase_0, byte_4, byte_, byte_2, byte_5, int_7, int_6));
				value.type_0 = type;
				lock (dm_dict)
				{
					dm_dict[key] = value;
				}
				return @class;
			}
			catch (Exception0 exception)
			{
				throw exception;
			}
			catch (Exception ex)
			{
				try
				{
					StackTrace stackTrace = new StackTrace();
					string text = "";
					for (int i = 0; i < stackTrace.FrameCount; i++)
					{
						StackFrame frame = stackTrace.GetFrame(i);
						MethodBase method = frame.GetMethod();
						if (method.ReflectedType != null)
						{
							text = text + method.ReflectedType.ToString() + "\n";
						}
					}
					throw new Exception0("sense: " + ex.Message + "\n" + text);
				}
				catch (Exception)
				{
				}
				throw new Exception("sense: " + ex.Message);
			}
		}

		public static void smethod_21()
		{
			MethodBase.GetCurrentMethod();
			DynamicMethod dynamicMethod = null;
			new object();
			dynamicMethod.Invoke(null, null);
		}

		private static string smethod_22(Type type_0)
		{
			return (type_0 == null) ? "null_type" : type_0.ToString();
		}

		public static Class5 smethod_23(object object_0, MethodBase methodBase_0, byte[] byte_0, byte[] byte_1, byte[] byte_2, byte[] byte_3, int[] int_5, int int_6)
		{
			Type type = null;
			Type type2 = null;
			int metadataToken = methodBase_0.MetadataToken;
			MethodBase methodBase = null;
			int num = 0;
			DynamicILInfo dynamicILInfo = null;
			type = ((methodBase_0.DeclaringType == null) ? object_0.GetType() : methodBase_0.DeclaringType);
			methodBase = ((type != null) ? MethodBase.GetMethodFromHandle(methodBase_0.MethodHandle, type.TypeHandle) : MethodBase.GetMethodFromHandle(methodBase_0.MethodHandle));
			type2 = ((!methodBase_0.IsConstructor && !(methodBase_0.Name == ".cctor")) ? ((MethodInfo)methodBase).ReturnType : typeof(void));
			ParameterInfo[] parameters = methodBase.GetParameters();
			Type[] array;
			if ((methodBase_0.Attributes & MethodAttributes.Static) != MethodAttributes.Static)
			{
				array = new Type[parameters.Length + 1];
				array[0] = type;
			}
			else
			{
				array = new Type[parameters.Length];
			}
			for (num = 0; num < parameters.Length; num++)
			{
				array[num + array.Length - parameters.Length] = parameters[num].ParameterType;
			}
			Class5 @class = null;
			@class = ((type != null) ? new Class5(methodBase_0.Name + "_", type2, array, type, true) : new Class5(methodBase_0.Name + "_", type2, array, methodBase_0.Module, true));
			dynamicILInfo = @class.dynamicMethod_0.GetDynamicILInfo();
			if (int_5[0] == 1)
			{
				@class.dynamicMethod_0.InitLocals = true;
			}
			smethod_24(byte_0, methodBase_0, type, dynamicILInfo, int_5);
			SignatureHelper signatureHelper_ = SignatureHelper.GetLocalVarSigHelper();
			Type[] type_ = null;
			Type[] type_2 = null;
			if (type != null && type.IsGenericType)
			{
				type_ = type.GetGenericArguments();
			}
			if (methodBase_0.IsGenericMethod)
			{
				type_2 = methodBase_0.GetGenericArguments();
			}
			if (byte_1.Length != 0)
			{
				if (smethod_25(byte_1, methodBase_0, dynamicILInfo, ref signatureHelper_, type_, type_2))
				{
					dynamicILInfo.SetLocalSignature(signatureHelper_.GetSignature());
				}
				else
				{
					dynamicILInfo.SetLocalSignature(byte_2);
				}
			}
			else
			{
				dynamicILInfo.SetLocalSignature(new byte[2]
				{
					7,
					0
				});
			}
			if (byte_3.Length != 0)
			{
				smethod_35(byte_3, methodBase_0, dynamicILInfo, type);
			}
			if (@class == null)
			{
				throw new Exception("sense: Internal error: dynamic method is null");
			}
			return @class;
		}

		public static void smethod_24(byte[] byte_0, MethodBase methodBase_0, Type type_0, DynamicILInfo dynamicILInfo_0, int[] int_5)
		{
			byte[] array = new byte[byte_0.Length];
			Array.Copy(byte_0, array, byte_0.Length);
			ILReader iLReader = new ILReader(methodBase_0, byte_0);
			Class6 visitor = new Class6(dynamicILInfo_0, array, methodBase_0, type_0);
			iLReader.Accept(visitor);
			dynamicILInfo_0.SetCode(array, int_5[1]);
		}

		public static bool smethod_25(byte[] byte_0, MethodBase methodBase_0, DynamicILInfo dynamicILInfo_0, ref SignatureHelper signatureHelper_0, Type[] type_0, Type[] type_1)
		{
			int int_ = 0;
			bool result = true;
			int num = smethod_34(byte_0, ref int_);
			if (num == 7)
			{
				int num2 = smethod_34(byte_0, ref int_);
				for (int i = 0; i < num2; i++)
				{
					Type type = smethod_31(dynamicILInfo_0, byte_0, ref int_, type_0, type_1);
					if (type != null)
					{
						signatureHelper_0.AddArgument(type);
						continue;
					}
					throw new Exception("fail to get_local_type");
				}
			}
			return result;
		}

		private static void smethod_26(string string_1)
		{
			Debug.Write(string_1);
		}

		private static void smethod_27(string string_1)
		{
			Debug.WriteLine(string_1);
		}

		private static void smethod_28()
		{
			string name = Assembly.GetExecutingAssembly().GetModules()[0].Name;
			string text = DateTime.Now.ToLocalTime().ToString("yyyy.MM.dd_hh.mm.ss");
			string str = "log_" + name + "_dynamic_" + text + ".txt";
			if (!Directory.Exists("d:"))
			{
				string_0 = str;
			}
			else
			{
				if (!Directory.Exists("d:\\log"))
				{
					Directory.CreateDirectory("d:\\log");
				}
				if (Directory.Exists("d:\\log"))
				{
					string_0 = "d:\\log\\" + str;
				}
			}
			smethod_26("log file: " + string_0);
			streamWriter_1 = new StreamWriter(string_0, false);
			if (streamWriter_1 != null)
			{
				streamWriter_1.WriteLine(DateTime.Now.ToLocalTime().ToString());
				streamWriter_1.Close();
				streamWriter_1 = new StreamWriter(string_0, true);
			}
		}

		private static void smethod_29(string string_1)
		{
			try
			{
				int_4++;
				if (int_4 >= 100)
				{
					int_4 = 0;
					streamWriter_1.Close();
					streamWriter_1 = new StreamWriter(string_0, true);
				}
				if (streamWriter_1 == null)
				{
					smethod_28();
				}
				if (streamWriter_1 != null)
				{
					streamWriter_1.Write(string_1);
					streamWriter_1.Flush();
				}
				else
				{
					smethod_26("fail to output: " + string_1);
				}
			}
			catch (Exception ex)
			{
				smethod_26("fail to output: " + string_1 + "as " + ex.Message);
			}
		}

		private static void smethod_30(string string_1)
		{
			try
			{
				int_4++;
				if (int_4 >= 100)
				{
					int_4 = 0;
					streamWriter_1.Close();
					streamWriter_1 = new StreamWriter(string_0, true);
				}
				if (streamWriter_1 == null)
				{
					smethod_28();
				}
				if (streamWriter_1 != null)
				{
					streamWriter_1.WriteLine(string_1);
					streamWriter_1.Flush();
				}
				else
				{
					smethod_26("fail to outputline: " + string_1);
				}
			}
			catch (Exception ex)
			{
				smethod_26("fail to outputline: " + string_1 + "as " + ex.Message);
			}
		}

		public static Type smethod_31(DynamicILInfo dynamicILInfo_0, byte[] byte_0, ref int int_5, Type[] type_0, Type[] type_1)
		{
			Type result = null;
			Module module = Assembly.GetExecutingAssembly().GetModules()[0];
			int num = byte_0[int_5];
			int_5++;
			int num2 = 0;
			switch (num)
			{
			case 0:
				result = null;
				break;
			case 1:
				result = Type.GetType("System.Void");
				break;
			case 2:
				result = Type.GetType("System.Boolean");
				break;
			case 3:
				result = Type.GetType("System.Char");
				break;
			case 4:
				result = Type.GetType("System.SByte");
				break;
			case 5:
				result = Type.GetType("System.Byte");
				break;
			case 6:
				result = Type.GetType("System.Int16");
				break;
			case 7:
				result = Type.GetType("System.UInt16");
				break;
			case 8:
				result = Type.GetType("System.Int32");
				break;
			case 9:
				result = Type.GetType("System.UInt32");
				break;
			case 10:
				result = Type.GetType("System.Int64");
				break;
			case 11:
				result = Type.GetType("System.UInt64");
				break;
			case 12:
				result = Type.GetType("System.Single");
				break;
			case 13:
				result = Type.GetType("System.Double");
				break;
			case 14:
				result = Type.GetType("System.String");
				break;
			case 16:
			{
				smethod_30("ref is commited");
				Type type2 = smethod_31(dynamicILInfo_0, byte_0, ref int_5, type_0, type_1);
				result = type2.MakeByRefType();
				break;
			}
			case 17:
			case 18:
			{
				int metadataToken2 = smethod_32(byte_0, ref int_5);
				result = module.ResolveType(metadataToken2);
				break;
			}
			case 19:
			{
				int num8 = smethod_34(byte_0, ref int_5);
				if (type_0 != null)
				{
					result = type_0[num8];
				}
				break;
			}
			case 20:
			{
				Type type = smethod_31(dynamicILInfo_0, byte_0, ref int_5, type_0, type_1);
				if (type != null)
				{
					int num5 = smethod_34(byte_0, ref int_5);
					int num6 = smethod_34(byte_0, ref int_5);
					int[] array3 = new int[num5];
					for (num2 = 0; num2 < num6; num2++)
					{
						array3[num2] = smethod_34(byte_0, ref int_5);
					}
					int num7 = smethod_34(byte_0, ref int_5);
					int[] array4 = new int[num7];
					for (num2 = 0; num2 < num7; num2++)
					{
						array4[num2] = smethod_34(byte_0, ref int_5);
					}
					Array array5 = Array.CreateInstance(type, array3, array4);
					result = array5.GetType();
				}
				break;
			}
			case 21:
			{
				Type type = null;
				Enum1 @enum = (Enum1)smethod_34(byte_0, ref int_5);
				if (@enum == Enum1.ELEMENT_TYPE_VALUETYPE || @enum == Enum1.ELEMENT_TYPE_CLASS)
				{
					int metadataToken = smethod_32(byte_0, ref int_5);
					int num4 = smethod_34(byte_0, ref int_5);
					Type[] array2 = new Type[num4];
					for (num2 = 0; num2 < num4; num2++)
					{
						array2[num2] = smethod_31(dynamicILInfo_0, byte_0, ref int_5, type_0, type_1);
					}
					type = module.ResolveType(metadataToken);
					result = type.MakeGenericType(array2);
				}
				break;
			}
			case 24:
				result = Type.GetType("System.IntPtr");
				break;
			case 25:
				result = Type.GetType("System.UIntPtr");
				break;
			default:
				throw new Exception("sense: unkown local type in sig");
			case 28:
				result = Type.GetType("System.Object");
				break;
			case 29:
			{
				Type type = smethod_31(dynamicILInfo_0, byte_0, ref int_5, type_0, type_1);
				if (type != null)
				{
					Array array = Array.CreateInstance(type, 0);
					result = array.GetType();
				}
				break;
			}
			case 30:
			{
				int num3 = smethod_34(byte_0, ref int_5);
				if (type_1 != null)
				{
					result = type_1[num3];
				}
				break;
			}
			case 15:
			case 22:
			case 27:
			case 31:
			case 32:
			case 33:
				break;
			}
			return result;
		}

		public static int smethod_32(byte[] byte_0, ref int int_5)
		{
			int num = 0;
			num = byte_0[int_5] + (byte_0[int_5 + 1] << 8) + (byte_0[int_5 + 2] << 16) + (byte_0[int_5 + 3] << 24);
			int_5 += 4;
			return num;
		}

		public static int smethod_33(byte[] byte_0, ref int int_5)
		{
			int num = smethod_34(byte_0, ref int_5);
			switch (num & 3)
			{
			case 0:
				num = (0x2000000 | (num >> 2));
				break;
			case 1:
				num = (0x1000000 | (num >> 2));
				break;
			case 2:
				num = (0x1B000000 | (num >> 2));
				break;
			case 3:
				num = (0x72000000 | (num >> 2));
				break;
			}
			return num;
		}

		public static int smethod_34(byte[] byte_0, ref int int_5)
		{
			int result = 0;
			if ((byte_0[int_5] & 0x80) == 0)
			{
				result = byte_0[int_5];
				int_5++;
			}
			else if ((byte_0[int_5] & 0xC0) == 128)
			{
				result = (((byte_0[int_5] & 0x3F) << 8) | byte_0[int_5 + 1]);
				int_5 += 2;
			}
			else if ((byte_0[int_5] & 0xE0) == 192)
			{
				result = (((byte_0[int_5] & 0x1F) << 24) | (byte_0[int_5 + 1] << 16) | (byte_0[int_5 + 2] << 8) | byte_0[int_5 + 3]);
				int_5 += 4;
			}
			return result;
		}

		public static void smethod_35(byte[] byte_0, MethodBase methodBase_0, DynamicILInfo dynamicILInfo_0, Type type_0)
		{
			if (byte_0 == null)
			{
				return;
			}
			bool flag = false;
			int num = 0;
			int num2 = 0;
			byte[] array = new byte[byte_0.Length];
			Array.Copy(byte_0, array, byte_0.Length);
			if (byte_0.Length > 0 && (byte_0[0] & 0x3F) == 1)
			{
				if ((byte_0[0] & 0x40) == 64)
				{
					flag = true;
				}
				num = (flag ? smethod_39(1, array) : array[1]);
				for (num2 = 4; num2 < num; num2 += (flag ? 24 : 12))
				{
					int num3 = flag ? smethod_40(num2, array) : smethod_37(num2, array);
					if ((num3 & 1) == 1)
					{
						continue;
					}
					int num4 = smethod_40(num2 + (flag ? 20 : 8), array);
					if ((num4 & 0xFFFFFF) != 0)
					{
						num4 = smethod_5(num4, dynamicILInfo_0, methodBase_0, type_0);
						if ((num4 & 0xFFFFFF) != 0)
						{
							smethod_36(num4, num2 + (flag ? 20 : 8), array);
						}
					}
					else
					{
						smethod_36(0, num2 + (flag ? 20 : 8), array);
					}
				}
			}
			dynamicILInfo_0.SetExceptions(array);
		}

		private static void smethod_36(int int_5, int int_6, byte[] byte_0)
		{
			byte_0[int_6++] = (byte)int_5;
			byte_0[int_6++] = (byte)(int_5 >> 8);
			byte_0[int_6++] = (byte)(int_5 >> 16);
			byte_0[int_6++] = (byte)(int_5 >> 24);
		}

		public static int smethod_37(int int_5, byte[] byte_0)
		{
			return byte_0[int_5] | (byte_0[int_5 + 1] << 8);
		}

		public static void smethod_38(int int_5, int int_6, byte[] byte_0)
		{
			byte_0[int_6++] = (byte)int_5;
			byte_0[int_6++] = (byte)(int_5 >> 8);
			byte_0[int_6++] = (byte)(int_5 >> 16);
		}

		public static int smethod_39(int int_5, byte[] byte_0)
		{
			return byte_0[int_5] | (byte_0[int_5 + 1] << 8) | (byte_0[int_5 + 2] << 16);
		}

		public static int smethod_40(int int_5, byte[] byte_0)
		{
			return byte_0[int_5] | (byte_0[int_5 + 1] << 8) | (byte_0[int_5 + 2] << 16) | (byte_0[int_5 + 3] << 24);
		}

		private static uint smethod_41(int int_5)
		{
			return (uint)(int_5 & -16777216);
		}
	}
}
