using System;
using System.Runtime.InteropServices;
using System.Text;

namespace RxjhServer
{
	public class AtapiDevicea
	{
		private const uint DFP_GET_VERSION = 475264u;

		private const uint DFP_SEND_DRIVE_COMMAND = 508036u;

		private const uint DFP_RECEIVE_DRIVE_DATA = 508040u;

		private const uint GENERIC_READ = 2147483648u;

		private const uint GENERIC_WRITE = 1073741824u;

		private const uint FILE_SHARE_READ = 1u;

		private const uint FILE_SHARE_WRITE = 2u;

		private const uint CREATE_NEW = 1u;

		private const uint OPEN_EXISTING = 3u;

		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern int CloseHandle(IntPtr intptr_0);

		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr CreateFile(string string_0, uint uint_0, uint uint_1, IntPtr intptr_0, uint uint_2, uint uint_3, IntPtr intptr_1);

		[DllImport("kernel32.dll")]
		private static extern int DeviceIoControl(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, uint uint_1, ref GetVersionOutParams getVersionOutParams_0, uint uint_2, ref uint uint_3, [Out] IntPtr intptr_2);

		[DllImport("kernel32.dll")]
		private static extern int DeviceIoControl(IntPtr intptr_0, uint uint_0, ref SendCmdInParams sendCmdInParams_0, uint uint_1, ref SendCmdOutParams sendCmdOutParams_0, uint uint_2, ref uint uint_3, [Out] IntPtr intptr_1);

		public static HardDiskInfo GetHddInfo(byte byte_0)
		{
			switch (Environment.OSVersion.Platform)
			{
			default:
				throw new NotSupportedException("Unknown   Platform.");
			case PlatformID.Win32S:
				throw new NotSupportedException("Win32s   is   not   supported.");
			case PlatformID.Win32Windows:
				return smethod_0(byte_0);
			case PlatformID.WinCE:
				throw new NotSupportedException("WinCE   is   not   supported.");
			case PlatformID.Win32NT:
				return smethod_1(byte_0);
			}
		}

		private static HardDiskInfo smethod_0(byte byte_0)
		{
			GetVersionOutParams getVersionOutParams_ = default(GetVersionOutParams);
			SendCmdInParams sendCmdInParams_ = default(SendCmdInParams);
			SendCmdOutParams sendCmdOutParams_ = default(SendCmdOutParams);
			uint uint_ = 0u;
			IntPtr intPtr = CreateFile("\\\\.\\Smartvsd", 0u, 0u, IntPtr.Zero, 1u, 0u, IntPtr.Zero);
			if (intPtr == IntPtr.Zero)
			{
				throw new Exception("Open   smartvsd.vxd   failed.");
			}
			if (DeviceIoControl(intPtr, 475264u, IntPtr.Zero, 0u, ref getVersionOutParams_, (uint)Marshal.SizeOf(getVersionOutParams_), ref uint_, IntPtr.Zero) == 0)
			{
				CloseHandle(intPtr);
				throw new Exception("DeviceIoControl   failed:DFP_GET_VERSION");
			}
			if ((getVersionOutParams_.uint_0 & 1) == 0)
			{
				CloseHandle(intPtr);
				throw new Exception("Error:   IDE   identify   command   not   supported.");
			}
			sendCmdInParams_.ideRegs_0.byte_5 = (byte)(((byte_0 & 1) == 0) ? 160 : 176);
			if ((getVersionOutParams_.uint_0 & (16 >> (int)byte_0)) != 0L)
			{
				CloseHandle(intPtr);
				throw new Exception(string.Format("Drive   {0}   is   a   ATAPI   device,   we   don't   detect   it", byte_0 + 1));
			}
			sendCmdInParams_.ideRegs_0.byte_6 = 236;
			sendCmdInParams_.byte_0 = byte_0;
			sendCmdInParams_.ideRegs_0.byte_1 = 1;
			sendCmdInParams_.ideRegs_0.byte_2 = 1;
			sendCmdInParams_.uint_0 = 512u;
			if (DeviceIoControl(intPtr, 508040u, ref sendCmdInParams_, (uint)Marshal.SizeOf(sendCmdInParams_), ref sendCmdOutParams_, (uint)Marshal.SizeOf(sendCmdOutParams_), ref uint_, IntPtr.Zero) == 0)
			{
				CloseHandle(intPtr);
				throw new Exception("DeviceIoControl   failed:   DFP_RECEIVE_DRIVE_DATA");
			}
			CloseHandle(intPtr);
			return smethod_2(sendCmdOutParams_.idSector_0);
		}

		private static HardDiskInfo smethod_1(byte byte_0)
		{
			GetVersionOutParams getVersionOutParams_ = default(GetVersionOutParams);
			SendCmdInParams sendCmdInParams_ = default(SendCmdInParams);
			SendCmdOutParams sendCmdOutParams_ = default(SendCmdOutParams);
			uint uint_ = 0u;
			IntPtr intPtr = CreateFile(string.Format("\\\\.\\PhysicalDrive{0}", byte_0), 3221225472u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
			if (intPtr == IntPtr.Zero)
			{
				throw new Exception("CreateFile   faild.");
			}
			if (DeviceIoControl(intPtr, 475264u, IntPtr.Zero, 0u, ref getVersionOutParams_, (uint)Marshal.SizeOf(getVersionOutParams_), ref uint_, IntPtr.Zero) == 0)
			{
				CloseHandle(intPtr);
				throw new Exception(string.Format("Drive   {0}   may   not   exists.", byte_0 + 1));
			}
			if ((getVersionOutParams_.uint_0 & 1) == 0)
			{
				CloseHandle(intPtr);
				throw new Exception("Error:   IDE   identify   command   not   supported.");
			}
			sendCmdInParams_.ideRegs_0.byte_5 = (byte)(((byte_0 & 1) == 0) ? 160 : 176);
			if ((getVersionOutParams_.uint_0 & (16 >> (int)byte_0)) != 0L)
			{
				CloseHandle(intPtr);
				throw new Exception(string.Format("Drive   {0}   is   a   ATAPI   device,   we   don't   detect   it.", byte_0 + 1));
			}
			sendCmdInParams_.ideRegs_0.byte_6 = 236;
			sendCmdInParams_.byte_0 = byte_0;
			sendCmdInParams_.ideRegs_0.byte_1 = 1;
			sendCmdInParams_.ideRegs_0.byte_2 = 1;
			sendCmdInParams_.uint_0 = 512u;
			if (DeviceIoControl(intPtr, 508040u, ref sendCmdInParams_, (uint)Marshal.SizeOf(sendCmdInParams_), ref sendCmdOutParams_, (uint)Marshal.SizeOf(sendCmdOutParams_), ref uint_, IntPtr.Zero) == 0)
			{
				CloseHandle(intPtr);
				throw new Exception("DeviceIoControl   failed:   DFP_RECEIVE_DRIVE_DATA");
			}
			CloseHandle(intPtr);
			return smethod_2(sendCmdOutParams_.idSector_0);
		}

		private static HardDiskInfo smethod_2(IdSector idSector_0)
		{
			HardDiskInfo result = default(HardDiskInfo);
			smethod_3(idSector_0.sModelNumber);
			result.ModuleNumber = Encoding.ASCII.GetString(idSector_0.sModelNumber).Trim();
			smethod_3(idSector_0.sFirmwareRev);
			result.Firmware = Encoding.ASCII.GetString(idSector_0.sFirmwareRev).Trim();
			smethod_3(idSector_0.sSerialNumber);
			result.SerialNumber = Encoding.ASCII.GetString(idSector_0.sSerialNumber).Trim();
			result.Capacity = idSector_0.uint_1 / 2u / 1024u;
			return result;
		}

		private static void smethod_3(byte[] byte_0)
		{
			for (int i = 0; i < byte_0.Length; i += 2)
			{
				byte b = byte_0[i];
				byte_0[i] = byte_0[i + 1];
				byte_0[i + 1] = b;
			}
		}

		public static string getHad()
		{
			try
			{
				return GetHddInfo(0).SerialNumber;
			}
			catch (Exception)
			{
				return "0";
			}
		}
	}
}
