using System;
using System.Runtime.InteropServices;

namespace RxjhServer
{
	internal class UserClass
	{
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct USER_INFO_1
		{
			public string usri1_name;

			public string usri1_password;

			public int usri1_password_age;

			public int usri1_priv;

			public string usri1_home_dir;

			public string comment;

			public int usri1_flags;

			public string usri1_script_path;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct USER_INFO_0
		{
			public string Username;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct LOCALGROUP_USERS_INFO_0
		{
			public string groupname;
		}

		[DllImport("Netapi32.dll")]
		public static extern int NetUserAdd([MarshalAs(UnmanagedType.LPWStr)] string string_0, int int_0, ref USER_INFO_1 user_INFO_1_0, int int_1);

		[DllImport("Netapi32.dll")]
		public static extern int NetUserDel([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.LPWStr)] string string_1);

		[DllImport("Netapi32.dll")]
		public static extern int NetUserGetInfo([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.LPWStr)] string string_1, int int_0, out IntPtr intptr_0);

		[DllImport("Netapi32.dll")]
		public static extern int NetUserSetInfo([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.LPWStr)] string string_1, int int_0, ref USER_INFO_1 user_INFO_1_0, int int_1);

		[DllImport("Netapi32.dll")]
		public static extern int NetUserChangePassword([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.LPWStr)] string string_1, [MarshalAs(UnmanagedType.LPWStr)] string string_2, [MarshalAs(UnmanagedType.LPWStr)] string string_3);

		[DllImport("Netapi32.dll")]
		private static extern int NetUserEnum([MarshalAs(UnmanagedType.LPWStr)] string string_0, int int_0, int int_1, out IntPtr intptr_0, int int_2, out int int_3, out int int_4, out int int_5);

		[DllImport("Netapi32.dll")]
		private static extern int NetApiBufferFree(IntPtr intptr_0);

		[DllImport("Netapi32.dll")]
		public static extern int NetUserGetLocalGroups([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.LPWStr)] string string_1, int int_0, int int_1, out IntPtr intptr_0, int int_2, out int int_3, out int int_4);
	}
}
