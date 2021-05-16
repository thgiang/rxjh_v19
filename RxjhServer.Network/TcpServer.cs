using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;

namespace RxjhServer.Network
{
	public class TcpServer
	{
		protected IntPtr _pServer = IntPtr.Zero;

		protected IntPtr pListener = IntPtr.Zero;

		protected bool IsCreate;

		private Sdk.OnPrepareListen onPrepareListen_0;

		private Sdk.OnAccept onAccept_0;

		private Sdk.OnReceive onReceive_0;

		private Sdk.OnSend onSend_0;

		private Sdk.OnClose onClose_0;

		private Sdk.OnShutdown onShutdown_0;

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private ushort ushort_0;

		[CompilerGenerated]
		private TcpServerEvent.OnAcceptEventHandler onAcceptEventHandler_0;

		[CompilerGenerated]
		private TcpServerEvent.OnSendEventHandler onSendEventHandler_0;

		[CompilerGenerated]
		private TcpServerEvent.OnPrepareListenEventHandler onPrepareListenEventHandler_0;

		[CompilerGenerated]
		private TcpServerEvent.OnReceiveEventHandler onReceiveEventHandler_0;

		[CompilerGenerated]
		private TcpServerEvent.OnCloseEventHandler onCloseEventHandler_0;

		[CompilerGenerated]
		private TcpServerEvent.OnShutdownEventHandler onShutdownEventHandler_0;

		protected IntPtr pServer
		{
			get
			{
				return _pServer;
			}
			set
			{
				_pServer = value;
			}
		}

		public string IpAddress
		{
			get;
			set;
		}

		public ushort Port
		{
			get;
			set;
		}

		public bool IsStarted
		{
			get
			{
				if (!(pServer == IntPtr.Zero))
				{
					return Sdk.HP_Server_HasStarted(pServer);
				}
				return false;
			}
		}

		public ServiceState State
		{
			get
			{
				return Sdk.HP_Server_GetState(pServer);
			}
		}

		public uint ConnectionCount
		{
			get
			{
				return Sdk.HP_Server_GetConnectionCount(pServer);
			}
		}

		public uint WorkerThreadCount
		{
			get
			{
				return Sdk.HP_Server_GetWorkerThreadCount(pServer);
			}
			set
			{
				Sdk.HP_Server_SetWorkerThreadCount(pServer, value);
			}
		}

		public uint AcceptSocketCount
		{
			get
			{
				return Sdk.HP_TcpServer_GetAcceptSocketCount(pServer);
			}
			set
			{
				Sdk.HP_TcpServer_SetAcceptSocketCount(pServer, value);
			}
		}

		public uint SocketBufferSize
		{
			get
			{
				return Sdk.HP_TcpServer_GetSocketBufferSize(pServer);
			}
			set
			{
				Sdk.HP_TcpServer_SetSocketBufferSize(pServer, value);
			}
		}

		public uint SocketListenQueue
		{
			get
			{
				return Sdk.HP_TcpServer_GetSocketListenQueue(pServer);
			}
			set
			{
				Sdk.HP_TcpServer_SetSocketListenQueue(pServer, value);
			}
		}

		public uint FreeSocketObjLockTime
		{
			get
			{
				return Sdk.HP_Server_GetFreeSocketObjLockTime(pServer);
			}
			set
			{
				Sdk.HP_Server_SetFreeSocketObjLockTime(pServer, value);
			}
		}

		public uint FreeSocketObjPool
		{
			get
			{
				return Sdk.HP_Server_GetFreeSocketObjPool(pServer);
			}
			set
			{
				Sdk.HP_Server_SetFreeSocketObjPool(pServer, value);
			}
		}

		public uint FreeSocketObjHold
		{
			get
			{
				return Sdk.HP_Server_GetFreeSocketObjHold(pServer);
			}
			set
			{
				Sdk.HP_Server_SetFreeSocketObjHold(pServer, value);
			}
		}

		public uint FreeBufferObjPool
		{
			get
			{
				return Sdk.HP_Server_GetFreeBufferObjPool(pServer);
			}
			set
			{
				Sdk.HP_Server_SetFreeBufferObjPool(pServer, value);
			}
		}

		public uint FreeBufferObjHold
		{
			get
			{
				return Sdk.HP_Server_GetFreeBufferObjHold(pServer);
			}
			set
			{
				Sdk.HP_Server_SetFreeBufferObjHold(pServer, value);
			}
		}

		public uint KeepAliveTime
		{
			get
			{
				return Sdk.HP_TcpServer_GetKeepAliveTime(pServer);
			}
			set
			{
				Sdk.HP_TcpServer_SetKeepAliveTime(pServer, value);
			}
		}

		public uint KeepAliveInterval
		{
			get
			{
				return Sdk.HP_TcpServer_GetKeepAliveInterval(pServer);
			}
			set
			{
				Sdk.HP_TcpServer_SetKeepAliveInterval(pServer, value);
			}
		}

		public bool MarkSilence
		{
			get
			{
				return Sdk.HP_Server_IsMarkSilence(pServer);
			}
			set
			{
				Sdk.HP_Server_SetMarkSilence(pServer, value);
			}
		}

		public SendPolicy SendPolicy
		{
			get
			{
				return Sdk.HP_Server_GetSendPolicy(pServer);
			}
			set
			{
				Sdk.HP_Server_SetSendPolicy(pServer, value);
			}
		}

		public SocketError ErrorCode
		{
			get
			{
				return Sdk.HP_Server_GetLastError(pServer);
			}
		}

		public string ErrorMessage
		{
			get
			{
				return Marshal.PtrToStringUni(Sdk.HP_Server_GetLastErrorDesc(pServer));
			}
		}

		public event TcpServerEvent.OnAcceptEventHandler Event_0
		{
			[CompilerGenerated]
			add
			{
				TcpServerEvent.OnAcceptEventHandler onAcceptEventHandler = onAcceptEventHandler_0;
				TcpServerEvent.OnAcceptEventHandler onAcceptEventHandler2;
				do
				{
					onAcceptEventHandler2 = onAcceptEventHandler;
					TcpServerEvent.OnAcceptEventHandler value2 = (TcpServerEvent.OnAcceptEventHandler)Delegate.Combine(onAcceptEventHandler2, value);
					onAcceptEventHandler = Interlocked.CompareExchange(ref onAcceptEventHandler_0, value2, onAcceptEventHandler2);
				}
				while ((object)onAcceptEventHandler != onAcceptEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				TcpServerEvent.OnAcceptEventHandler onAcceptEventHandler = onAcceptEventHandler_0;
				TcpServerEvent.OnAcceptEventHandler onAcceptEventHandler2;
				do
				{
					onAcceptEventHandler2 = onAcceptEventHandler;
					TcpServerEvent.OnAcceptEventHandler value2 = (TcpServerEvent.OnAcceptEventHandler)Delegate.Remove(onAcceptEventHandler2, value);
					onAcceptEventHandler = Interlocked.CompareExchange(ref onAcceptEventHandler_0, value2, onAcceptEventHandler2);
				}
				while ((object)onAcceptEventHandler != onAcceptEventHandler2);
			}
		}

		public event TcpServerEvent.OnSendEventHandler Event_1
		{
			[CompilerGenerated]
			add
			{
				TcpServerEvent.OnSendEventHandler onSendEventHandler = onSendEventHandler_0;
				TcpServerEvent.OnSendEventHandler onSendEventHandler2;
				do
				{
					onSendEventHandler2 = onSendEventHandler;
					TcpServerEvent.OnSendEventHandler value2 = (TcpServerEvent.OnSendEventHandler)Delegate.Combine(onSendEventHandler2, value);
					onSendEventHandler = Interlocked.CompareExchange(ref onSendEventHandler_0, value2, onSendEventHandler2);
				}
				while ((object)onSendEventHandler != onSendEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				TcpServerEvent.OnSendEventHandler onSendEventHandler = onSendEventHandler_0;
				TcpServerEvent.OnSendEventHandler onSendEventHandler2;
				do
				{
					onSendEventHandler2 = onSendEventHandler;
					TcpServerEvent.OnSendEventHandler value2 = (TcpServerEvent.OnSendEventHandler)Delegate.Remove(onSendEventHandler2, value);
					onSendEventHandler = Interlocked.CompareExchange(ref onSendEventHandler_0, value2, onSendEventHandler2);
				}
				while ((object)onSendEventHandler != onSendEventHandler2);
			}
		}

		public event TcpServerEvent.OnPrepareListenEventHandler Event_2
		{
			[CompilerGenerated]
			add
			{
				TcpServerEvent.OnPrepareListenEventHandler onPrepareListenEventHandler = onPrepareListenEventHandler_0;
				TcpServerEvent.OnPrepareListenEventHandler onPrepareListenEventHandler2;
				do
				{
					onPrepareListenEventHandler2 = onPrepareListenEventHandler;
					TcpServerEvent.OnPrepareListenEventHandler value2 = (TcpServerEvent.OnPrepareListenEventHandler)Delegate.Combine(onPrepareListenEventHandler2, value);
					onPrepareListenEventHandler = Interlocked.CompareExchange(ref onPrepareListenEventHandler_0, value2, onPrepareListenEventHandler2);
				}
				while ((object)onPrepareListenEventHandler != onPrepareListenEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				TcpServerEvent.OnPrepareListenEventHandler onPrepareListenEventHandler = onPrepareListenEventHandler_0;
				TcpServerEvent.OnPrepareListenEventHandler onPrepareListenEventHandler2;
				do
				{
					onPrepareListenEventHandler2 = onPrepareListenEventHandler;
					TcpServerEvent.OnPrepareListenEventHandler value2 = (TcpServerEvent.OnPrepareListenEventHandler)Delegate.Remove(onPrepareListenEventHandler2, value);
					onPrepareListenEventHandler = Interlocked.CompareExchange(ref onPrepareListenEventHandler_0, value2, onPrepareListenEventHandler2);
				}
				while ((object)onPrepareListenEventHandler != onPrepareListenEventHandler2);
			}
		}

		public event TcpServerEvent.OnReceiveEventHandler Event_3
		{
			[CompilerGenerated]
			add
			{
				TcpServerEvent.OnReceiveEventHandler onReceiveEventHandler = onReceiveEventHandler_0;
				TcpServerEvent.OnReceiveEventHandler onReceiveEventHandler2;
				do
				{
					onReceiveEventHandler2 = onReceiveEventHandler;
					TcpServerEvent.OnReceiveEventHandler value2 = (TcpServerEvent.OnReceiveEventHandler)Delegate.Combine(onReceiveEventHandler2, value);
					onReceiveEventHandler = Interlocked.CompareExchange(ref onReceiveEventHandler_0, value2, onReceiveEventHandler2);
				}
				while ((object)onReceiveEventHandler != onReceiveEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				TcpServerEvent.OnReceiveEventHandler onReceiveEventHandler = onReceiveEventHandler_0;
				TcpServerEvent.OnReceiveEventHandler onReceiveEventHandler2;
				do
				{
					onReceiveEventHandler2 = onReceiveEventHandler;
					TcpServerEvent.OnReceiveEventHandler value2 = (TcpServerEvent.OnReceiveEventHandler)Delegate.Remove(onReceiveEventHandler2, value);
					onReceiveEventHandler = Interlocked.CompareExchange(ref onReceiveEventHandler_0, value2, onReceiveEventHandler2);
				}
				while ((object)onReceiveEventHandler != onReceiveEventHandler2);
			}
		}

		public event TcpServerEvent.OnCloseEventHandler Event_4
		{
			[CompilerGenerated]
			add
			{
				TcpServerEvent.OnCloseEventHandler onCloseEventHandler = onCloseEventHandler_0;
				TcpServerEvent.OnCloseEventHandler onCloseEventHandler2;
				do
				{
					onCloseEventHandler2 = onCloseEventHandler;
					TcpServerEvent.OnCloseEventHandler value2 = (TcpServerEvent.OnCloseEventHandler)Delegate.Combine(onCloseEventHandler2, value);
					onCloseEventHandler = Interlocked.CompareExchange(ref onCloseEventHandler_0, value2, onCloseEventHandler2);
				}
				while ((object)onCloseEventHandler != onCloseEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				TcpServerEvent.OnCloseEventHandler onCloseEventHandler = onCloseEventHandler_0;
				TcpServerEvent.OnCloseEventHandler onCloseEventHandler2;
				do
				{
					onCloseEventHandler2 = onCloseEventHandler;
					TcpServerEvent.OnCloseEventHandler value2 = (TcpServerEvent.OnCloseEventHandler)Delegate.Remove(onCloseEventHandler2, value);
					onCloseEventHandler = Interlocked.CompareExchange(ref onCloseEventHandler_0, value2, onCloseEventHandler2);
				}
				while ((object)onCloseEventHandler != onCloseEventHandler2);
			}
		}

		public event TcpServerEvent.OnShutdownEventHandler Event_5
		{
			[CompilerGenerated]
			add
			{
				TcpServerEvent.OnShutdownEventHandler onShutdownEventHandler = onShutdownEventHandler_0;
				TcpServerEvent.OnShutdownEventHandler onShutdownEventHandler2;
				do
				{
					onShutdownEventHandler2 = onShutdownEventHandler;
					TcpServerEvent.OnShutdownEventHandler value2 = (TcpServerEvent.OnShutdownEventHandler)Delegate.Combine(onShutdownEventHandler2, value);
					onShutdownEventHandler = Interlocked.CompareExchange(ref onShutdownEventHandler_0, value2, onShutdownEventHandler2);
				}
				while ((object)onShutdownEventHandler != onShutdownEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				TcpServerEvent.OnShutdownEventHandler onShutdownEventHandler = onShutdownEventHandler_0;
				TcpServerEvent.OnShutdownEventHandler onShutdownEventHandler2;
				do
				{
					onShutdownEventHandler2 = onShutdownEventHandler;
					TcpServerEvent.OnShutdownEventHandler value2 = (TcpServerEvent.OnShutdownEventHandler)Delegate.Remove(onShutdownEventHandler2, value);
					onShutdownEventHandler = Interlocked.CompareExchange(ref onShutdownEventHandler_0, value2, onShutdownEventHandler2);
				}
				while ((object)onShutdownEventHandler != onShutdownEventHandler2);
			}
		}

		public TcpServer()
		{
			CreateListener();
		}

		~TcpServer()
		{
			Destroy();
		}

		protected virtual bool CreateListener()
		{
			if (!IsCreate && !(pListener != IntPtr.Zero) && !(pServer != IntPtr.Zero))
			{
				pListener = Sdk.Create_HP_TcpServerListener();
				if (pListener == IntPtr.Zero)
				{
					return false;
				}
				pServer = Sdk.Create_HP_TcpServer(pListener);
				if (pServer == IntPtr.Zero)
				{
					return false;
				}
				IsCreate = true;
				return true;
			}
			return false;
		}

		public virtual void Destroy()
		{
			Destroying();
			if (pServer != IntPtr.Zero)
			{
				Sdk.Destroy_HP_TcpServer(pServer);
				pServer = IntPtr.Zero;
			}
			if (pListener != IntPtr.Zero)
			{
				Sdk.Destroy_HP_TcpServerListener(pListener);
				pListener = IntPtr.Zero;
			}
			IsCreate = false;
		}

		public bool Start(int int_0)
		{
			if (IsCreate && !IsStarted)
			{
				ushort ushort_ = (ushort)int_0;
				SetCallback();
				World.ServerIDStart++;
				return Sdk.HP_Server_Start(pServer, IpAddress, Port, ushort_);
			}
			return false;
		}

		public bool Destroying()
		{
			if (IsStarted)
			{
				return Sdk.HP_Server_Destroying(pServer);
			}
			return false;
		}

		public bool Stop()
		{
			if (IsStarted)
			{
				return Sdk.HP_Server_Stop(pServer);
			}
			return false;
		}

		public bool Send(IntPtr intptr_0, byte[] byte_0, int int_0)
		{
			return Sdk.HP_Server_Send(pServer, intptr_0, byte_0, int_0);
		}

		public bool Send(IntPtr intptr_0, IntPtr intptr_1, int int_0)
		{
			return Sdk.HP_Server_Send(pServer, intptr_0, intptr_1, int_0);
		}

		public bool Send(IntPtr intptr_0, byte[] byte_0, int int_0, int int_1)
		{
			return Sdk.HP_Server_SendPart(pServer, intptr_0, byte_0, int_1, int_0);
		}

		public bool Send(IntPtr intptr_0, IntPtr intptr_1, int int_0, int int_1)
		{
			return Sdk.HP_Server_SendPart(pServer, intptr_0, intptr_1, int_1, int_0);
		}

		public bool Send<T>(IntPtr intptr_0, T gparam_0)
		{
			byte[] array = StructureToByte(gparam_0);
			return Send(intptr_0, array, array.Length);
		}

		public bool SendBySerializable(IntPtr intptr_0, object object_0)
		{
			byte[] array = ObjectToBytes(object_0);
			return Send(intptr_0, array, array.Length);
		}

		public bool SendPackets(IntPtr intptr_0, WSABUF[] wsabuf_0, int int_0)
		{
			return Sdk.HP_Server_SendPackets(pServer, intptr_0, wsabuf_0, int_0);
		}

		public bool SendPackets<T>(IntPtr intptr_0, T[] gparam_0)
		{
			WSABUF[] array = new WSABUF[gparam_0.Length];
			IntPtr[] array2 = new IntPtr[array.Length];
			try
			{
				for (int i = 0; i < gparam_0.Length; i++)
				{
					array[i].Length = Marshal.SizeOf(typeof(T));
					array2[i] = Marshal.AllocHGlobal(array[i].Length);
					Marshal.StructureToPtr(gparam_0[i], array2[i], true);
					array[i].Buffer = array2[i];
				}
				return SendPackets(intptr_0, array, array.Length);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				for (int j = 0; j < array2.Length; j++)
				{
					if (array2[j] != IntPtr.Zero)
					{
						Marshal.FreeHGlobal(array2[j]);
					}
				}
			}
		}

		public bool SendSmallFile(IntPtr intptr_0, string string_1, ref WSABUF wsabuf_0, ref WSABUF wsabuf_1)
		{
			return Sdk.HP_TcpServer_SendSmallFile(pServer, intptr_0, string_1, ref wsabuf_0, ref wsabuf_1);
		}

		public bool SendSmallFile(IntPtr intptr_0, string string_1, byte[] byte_0, byte[] byte_1)
		{
			IntPtr zero = IntPtr.Zero;
			IntPtr zero2 = IntPtr.Zero;
			WSABUF wSABUF = default(WSABUF);
			wSABUF.Length = 0;
			wSABUF.Buffer = zero;
			WSABUF wsabuf_ = wSABUF;
			wSABUF = default(WSABUF);
			wSABUF.Length = 0;
			wSABUF.Buffer = zero2;
			WSABUF wsabuf_2 = wSABUF;
			if (byte_0 != null)
			{
				wsabuf_.Length = byte_0.Length;
				wsabuf_.Buffer = Marshal.UnsafeAddrOfPinnedArrayElement(byte_0, 0);
			}
			if (byte_1 != null)
			{
				wsabuf_.Length = byte_1.Length;
				wsabuf_.Buffer = Marshal.UnsafeAddrOfPinnedArrayElement(byte_1, 0);
			}
			return SendSmallFile(intptr_0, string_1, ref wsabuf_, ref wsabuf_2);
		}

		public bool SendSmallFile<T1, T2>(IntPtr intptr_0, string string_1, T1 gparam_0, T2 gparam_1)
		{
			byte[] byte_ = null;
			if (gparam_0 != null)
			{
				byte_ = StructureToByte(gparam_0);
			}
			byte[] byte_2 = null;
			if (gparam_1 != null)
			{
				byte_2 = StructureToByte(gparam_1);
			}
			return SendSmallFile(intptr_0, string_1, byte_, byte_2);
		}

		public bool Disconnect(IntPtr intptr_0, bool bool_0 = true)
		{
			return Sdk.HP_Server_Disconnect(pServer, intptr_0, bool_0);
		}

		public bool DisconnectLongConnections(uint uint_0, bool bool_0 = true)
		{
			return Sdk.HP_Server_DisconnectLongConnections(pServer, uint_0, bool_0);
		}

		public bool DisconnectSilenceConnections(uint uint_0, bool bool_0 = true)
		{
			return Sdk.HP_Server_DisconnectSilenceConnections(pServer, uint_0, bool_0);
		}

		public bool GetLocalAddress(IntPtr intptr_0, ref string string_1, ref ushort ushort_1)
		{
			int int_ = 40;
			StringBuilder stringBuilder = new StringBuilder(40);
			int num = Sdk.HP_Server_GetLocalAddress(pServer, intptr_0, stringBuilder, ref int_, ref ushort_1) ? ((int_ > 0) ? 1 : 0) : 0;
			if (num == 0)
			{
				return num != 0;
			}
			string_1 = stringBuilder.ToString();
			return num != 0;
		}

		public bool GetRemoteAddress(IntPtr intptr_0, ref string string_1, ref ushort ushort_1)
		{
			int int_ = 40;
			StringBuilder stringBuilder = new StringBuilder(40);
			int num = Sdk.HP_Server_GetRemoteAddress(pServer, intptr_0, stringBuilder, ref int_, ref ushort_1) ? ((int_ > 0) ? 1 : 0) : 0;
			if (num == 0)
			{
				return num != 0;
			}
			string_1 = stringBuilder.ToString();
			return num != 0;
		}

		public bool GetPendingDataLength(IntPtr intptr_0, ref int int_0)
		{
			return Sdk.HP_Server_GetPendingDataLength(pServer, intptr_0, ref int_0);
		}

		public bool SetConnectionExtra(IntPtr intptr_0, object object_0)
		{
			IntPtr intptr_ = IntPtr.Zero;
			if (Sdk.HP_Server_GetConnectionExtra(pServer, intptr_0, ref intptr_) && intptr_ != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intptr_);
				intptr_ = IntPtr.Zero;
			}
			if (object_0 != null)
			{
				intptr_ = Marshal.AllocHGlobal(Marshal.SizeOf(object_0));
				Marshal.StructureToPtr(object_0, intptr_, false);
			}
			return Sdk.HP_Server_SetConnectionExtra(pServer, intptr_0, intptr_);
		}

		public bool GetConnectionExtra(IntPtr intptr_0, ref IntPtr intptr_1)
		{
			if (Sdk.HP_Server_GetConnectionExtra(pServer, intptr_0, ref intptr_1))
			{
				return intptr_1 != IntPtr.Zero;
			}
			return false;
		}

		public bool GetListenAddress(ref string string_1, ref ushort ushort_1)
		{
			int int_ = 40;
			StringBuilder stringBuilder = new StringBuilder(40);
			int num = Sdk.HP_Server_GetListenAddress(pServer, stringBuilder, ref int_, ref ushort_1) ? 1 : 0;
			if (num == 0)
			{
				return num != 0;
			}
			string_1 = stringBuilder.ToString();
			return num != 0;
		}

		public bool GetConnectPeriod(IntPtr intptr_0, ref uint uint_0)
		{
			return Sdk.HP_Server_GetConnectPeriod(pServer, intptr_0, ref uint_0);
		}

		public bool GetSilencePeriod(IntPtr intptr_0, ref uint uint_0)
		{
			return Sdk.HP_Server_GetSilencePeriod(pServer, intptr_0, ref uint_0);
		}

		public int SYSGetLastError()
		{
			return Sdk.SYS_GetLastError();
		}

		public int SYSWSAGetLastError()
		{
			return Sdk.SYS_WSAGetLastError();
		}

		protected virtual void SetCallback()
		{
			onPrepareListen_0 = method_0;
			onAccept_0 = method_1;
			onSend_0 = method_2;
			onReceive_0 = method_3;
			onClose_0 = method_4;
			onShutdown_0 = method_5;
			Sdk.HP_Set_FN_Server_OnPrepareListen(pListener, onPrepareListen_0);
			Sdk.HP_Set_FN_Server_OnAccept(pListener, onAccept_0);
			Sdk.HP_Set_FN_Server_OnSend(pListener, onSend_0);
			Sdk.HP_Set_FN_Server_OnReceive(pListener, onReceive_0);
			Sdk.HP_Set_FN_Server_OnClose(pListener, onClose_0);
			Sdk.HP_Set_FN_Server_OnShutdown(pListener, onShutdown_0);
		}

		protected HandleResult method_0(IntPtr intptr_0)
		{
			if (onPrepareListenEventHandler_0 != null)
			{
				return onPrepareListenEventHandler_0(intptr_0);
			}
			return HandleResult.Ignore;
		}

		protected HandleResult method_1(IntPtr intptr_0, IntPtr intptr_1)
		{
			if (onAcceptEventHandler_0 != null)
			{
				return onAcceptEventHandler_0(intptr_0, intptr_1);
			}
			return HandleResult.Ignore;
		}

		protected HandleResult method_2(IntPtr intptr_0, IntPtr intptr_1, int int_0)
		{
			if (onSendEventHandler_0 == null)
			{
				return HandleResult.Ignore;
			}
			byte[] array = new byte[int_0];
			Marshal.Copy(intptr_1, array, 0, int_0);
			return onSendEventHandler_0(intptr_0, array);
		}

		protected HandleResult method_3(IntPtr intptr_0, IntPtr intptr_1, int int_0)
		{
			if (onReceiveEventHandler_0 == null)
			{
				return HandleResult.Ignore;
			}
			byte[] array = new byte[int_0];
			Marshal.Copy(intptr_1, array, 0, int_0);
			return onReceiveEventHandler_0(intptr_0, array);
		}

		protected HandleResult method_4(IntPtr intptr_0, SocketOperation socketOperation_0, int int_0)
		{
			if (onCloseEventHandler_0 != null)
			{
				return onCloseEventHandler_0(intptr_0, socketOperation_0, int_0);
			}
			return HandleResult.Ignore;
		}

		protected HandleResult method_5()
		{
			if (onShutdownEventHandler_0 != null)
			{
				return onShutdownEventHandler_0();
			}
			return HandleResult.Ignore;
		}

		public string GetSocketErrorDesc(SocketError socketError_0)
		{
			return Marshal.PtrToStringUni(Sdk.HP_GetSocketErrorDesc(socketError_0));
		}

		public int SYS_SetSocketOption(IntPtr intptr_0, int int_0, int int_1, IntPtr intptr_1, int int_2)
		{
			return Sdk.SYS_SetSocketOption(intptr_0, int_0, int_1, intptr_1, int_2);
		}

		public int SYSGetSocketOption(IntPtr intptr_0, int int_0, int int_1, IntPtr intptr_1, ref int int_2)
		{
			return Sdk.SYS_GetSocketOption(intptr_0, int_0, int_1, intptr_1, ref int_2);
		}

		public int SYSIoctlSocket(IntPtr intptr_0, long long_0, IntPtr intptr_1)
		{
			return Sdk.SYS_IoctlSocket(intptr_0, long_0, intptr_1);
		}

		public int SYS_WSAIoctl(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, uint uint_1, IntPtr intptr_2, uint uint_2, uint uint_3)
		{
			return Sdk.SYS_WSAIoctl(intptr_0, uint_0, intptr_1, uint_1, intptr_2, uint_2, uint_3);
		}

		public byte[] StructureToByte<T>(T gparam_0)
		{
			int num = Marshal.SizeOf(typeof(T));
			byte[] array = new byte[num];
			IntPtr intPtr = Marshal.AllocHGlobal(num);
			try
			{
				Marshal.StructureToPtr(gparam_0, intPtr, true);
				Marshal.Copy(intPtr, array, 0, num);
				return array;
			}
			finally
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}

		public T ByteToStructure<T>(byte[] byte_0)
		{
			object obj = null;
			int num = Marshal.SizeOf(typeof(T));
			IntPtr intPtr = Marshal.AllocHGlobal(num);
			try
			{
				Marshal.Copy(byte_0, 0, intPtr, num);
				obj = Marshal.PtrToStructure(intPtr, typeof(T));
			}
			finally
			{
				Marshal.FreeHGlobal(intPtr);
			}
			return (T)obj;
		}

		public byte[] ObjectToBytes(object object_0)
		{
			using (MemoryStream memoryStream = new MemoryStream())
			{
				new BinaryFormatter().Serialize(memoryStream, object_0);
				return memoryStream.GetBuffer();
			}
		}

		public object BytesToObject(byte[] byte_0)
		{
			using (MemoryStream serializationStream = new MemoryStream(byte_0))
			{
				return new BinaryFormatter().Deserialize(serializationStream);
			}
		}

		public T BytesToStruct<T>(byte[] byte_0)
		{
			Type typeFromHandle = typeof(T);
			int num = Marshal.SizeOf(typeFromHandle);
			IntPtr intPtr = Marshal.AllocHGlobal(num);
			try
			{
				Marshal.Copy(byte_0, 0, intPtr, num);
				return (T)Marshal.PtrToStructure(intPtr, typeFromHandle);
			}
			finally
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
	}
}
