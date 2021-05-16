using System;
using System.Diagnostics;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;

namespace RxjhServer
{
	public class Hasher
	{
		public struct CPU_INFO
		{
			public uint dwOemId;

			public uint dwPageSize;

			public uint lpMinimumApplicationAddress;

			public uint lpMaximumApplicationAddress;

			public uint dwActiveProcessorMask;

			public uint dwNumberOfProcessors;

			public uint dwProcessorType;

			public uint dwAllocationGranularity;

			public uint dwProcessorLevel;

			public uint dwProcessorRevision;
		}

		[DllImport("kernel32")]
		public static extern void GetSystemInfo(ref CPU_INFO cpu_INFO_0);

		public static string GetCpuID()
		{
			try
			{
				ManagementObjectCollection instances = new ManagementClass("Win32_Processor").GetInstances();
				string result = null;
				using (ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = instances.GetEnumerator())
				{
					if (managementObjectEnumerator.MoveNext())
					{
						result = ((ManagementObject)managementObjectEnumerator.Current).Properties["ProcessorId"].Value.ToString();
					}
				}
				return result;
			}
			catch (Exception ex)
			{
				return "CpUIDerror" + ex.Message;
			}
		}

		public static string GetIP()
		{
			IPAddress[] addressList = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
			for (int i = 0; i < addressList.Length; i++)
			{
				if (addressList[i].AddressFamily == AddressFamily.InterNetwork)
				{
					return addressList[i].ToString();
				}
			}
			return addressList[0].ToString();
		}

		public static string GetMac()
		{
			string result = string.Empty;
			try
			{
				foreach (ManagementObject instance in new ManagementClass("Win32_NetworkAdapterConfiguration").GetInstances())
				{
					if (instance["IPEnabled"].ToString() == "True")
					{
						result = instance["MacAddress"].ToString();
					}
				}
				return result;
			}
			catch
			{
				return string.Empty;
			}
		}

		[DllImport("kernel32.dll")]
		private static extern int GetVolumeInformation(string string_0, string string_1, int int_0, ref int int_1, int int_2, int int_3, string string_2, int int_4);

		public static string GetDriveID(string string_0)
		{
			try
			{
				return AtapiDevicea.getHad();
			}
			catch (Exception)
			{
				return "0";
			}
		}

		public static string cmd(string string_0)
		{
			string empty = string.Empty;
			try
			{
				Process process = new Process();
				process.StartInfo.FileName = "cmd.exe";
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.RedirectStandardInput = true;
				process.StartInfo.RedirectStandardOutput = true;
				process.StartInfo.CreateNoWindow = true;
				process.Start();
				process.StandardInput.WriteLine(string_0);
				process.StandardInput.WriteLine("exit");
				empty = process.StandardOutput.ReadToEnd();
				process.Close();
				return empty;
			}
			catch (Exception ex)
			{
				return "执行DOS命令错误" + ex.Message.ToString();
			}
		}
	}
}
