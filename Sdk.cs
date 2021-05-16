using RxjhServer.Network;
using System;
using System.Runtime.InteropServices;
using System.Text;

public class Sdk
{
	public delegate HandleResult OnSend(IntPtr intptr_0, IntPtr intptr_1, int int_0);

	public delegate HandleResult OnReceive(IntPtr intptr_0, IntPtr intptr_1, int int_0);

	public delegate HandleResult OnPullReceive(IntPtr intptr_0, int int_0);

	public delegate HandleResult OnClose(IntPtr intptr_0, SocketOperation socketOperation_0, int int_0);

	public delegate HandleResult OnShutdown();

	public delegate HandleResult OnPrepareConnect(IntPtr intptr_0, uint uint_0);

	public delegate HandleResult OnConnect(IntPtr intptr_0);

	public delegate HandleResult OnPrepareListen(IntPtr intptr_0);

	public delegate HandleResult OnAccept(IntPtr intptr_0, IntPtr intptr_1);

	public delegate HandleResult OnHandShake(IntPtr intptr_0);

	private const string HPSOCKET_DLL_PATH = "HPSocket4C_U.dll";

	[DllImport("HPSocket4C_U.dll")]
	public static extern IntPtr Create_HP_TcpServer(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern IntPtr Create_HP_TcpClient(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern IntPtr Create_HP_TcpAgent(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern IntPtr Create_HP_TcpPullServer(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern IntPtr Create_HP_TcpPullClient(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern IntPtr Create_HP_TcpPullAgent(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern IntPtr Create_HP_TcpPackServer(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern IntPtr Create_HP_TcpPackAgent(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern IntPtr Create_HP_TcpPackClient(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern IntPtr Create_HP_UdpServer(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern IntPtr Create_HP_UdpClient(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void Destroy_HP_TcpServer(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void Destroy_HP_TcpClient(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void Destroy_HP_TcpAgent(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void Destroy_HP_TcpPullServer(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void Destroy_HP_TcpPullClient(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void Destroy_HP_TcpPullAgent(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void Destroy_HP_TcpPackServer(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void Destroy_HP_TcpPackAgent(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void Destroy_HP_TcpPackClient(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void Destroy_HP_UdpServer(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void Destroy_HP_UdpClient(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern IntPtr Create_HP_TcpServerListener();

	[DllImport("HPSocket4C_U.dll")]
	public static extern IntPtr Create_HP_TcpClientListener();

	[DllImport("HPSocket4C_U.dll")]
	public static extern IntPtr Create_HP_TcpAgentListener();

	[DllImport("HPSocket4C_U.dll")]
	public static extern IntPtr Create_HP_TcpPullServerListener();

	[DllImport("HPSocket4C_U.dll")]
	public static extern IntPtr Create_HP_TcpPullClientListener();

	[DllImport("HPSocket4C_U.dll")]
	public static extern IntPtr Create_HP_TcpPullAgentListener();

	[DllImport("HPSocket4C_U.dll")]
	public static extern IntPtr Create_HP_UdpServerListener();

	[DllImport("HPSocket4C_U.dll")]
	public static extern IntPtr Create_HP_UdpClientListener();

	[DllImport("HPSocket4C_U.dll")]
	public static extern void Destroy_HP_TcpServerListener(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void Destroy_HP_TcpClientListener(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void Destroy_HP_TcpAgentListener(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void Destroy_HP_TcpPullServerListener(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void Destroy_HP_TcpPullClientListener(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void Destroy_HP_TcpPullAgentListener(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void Destroy_HP_UdpServerListener(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void Destroy_HP_UdpClientListener(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_Set_FN_Server_OnPrepareListen(IntPtr intptr_0, OnPrepareListen onPrepareListen_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_Set_FN_Server_OnAccept(IntPtr intptr_0, OnAccept onAccept_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_Set_FN_Server_OnHandShake(IntPtr intptr_0, OnHandShake onHandShake_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_Set_FN_Server_OnSend(IntPtr intptr_0, OnSend onSend_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_Set_FN_Server_OnReceive(IntPtr intptr_0, OnReceive onReceive_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_Set_FN_Server_OnPullReceive(IntPtr intptr_0, OnPullReceive onPullReceive_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_Set_FN_Server_OnClose(IntPtr intptr_0, OnClose onClose_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_Set_FN_Server_OnShutdown(IntPtr intptr_0, OnShutdown onShutdown_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_Set_FN_Client_OnPrepareConnect(IntPtr intptr_0, OnPrepareConnect onPrepareConnect_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_Set_FN_Client_OnConnect(IntPtr intptr_0, OnConnect onConnect_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_Set_FN_Client_OnHandShake(IntPtr intptr_0, OnHandShake onHandShake_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_Set_FN_Client_OnSend(IntPtr intptr_0, OnSend onSend_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_Set_FN_Client_OnReceive(IntPtr intptr_0, OnReceive onReceive_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_Set_FN_Client_OnPullReceive(IntPtr intptr_0, OnPullReceive onPullReceive_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_Set_FN_Client_OnClose(IntPtr intptr_0, OnClose onClose_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_Set_FN_Agent_OnPrepareConnect(IntPtr intptr_0, OnPrepareConnect onPrepareConnect_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_Set_FN_Agent_OnConnect(IntPtr intptr_0, OnConnect onConnect_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_Set_FN_Agent_OnHandShake(IntPtr intptr_0, OnHandShake onHandShake_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_Set_FN_Agent_OnSend(IntPtr intptr_0, OnSend onSend_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_Set_FN_Agent_OnReceive(IntPtr intptr_0, OnReceive onReceive_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_Set_FN_Agent_OnPullReceive(IntPtr intptr_0, OnPullReceive onPullReceive_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_Set_FN_Agent_OnClose(IntPtr intptr_0, OnClose onClose_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_Set_FN_Agent_OnShutdown(IntPtr intptr_0, OnShutdown onShutdown_0);

	[DllImport("HPSocket4C_U.dll", CharSet = CharSet.Unicode)]
	public static extern bool HP_Server_Start(IntPtr intptr_0, string string_0, ushort ushort_0, ushort ushort_1);

	[DllImport("HPSocket4C_U.dll")]
	public static extern bool HP_Server_Stop(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern bool HP_Server_Destroying(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll", CharSet = CharSet.Ansi, SetLastError = true)]
	public static extern bool HP_Server_Send(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, int int_0);

	[DllImport("HPSocket4C_U.dll", SetLastError = true)]
	public static extern bool HP_Server_Send(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, int int_0);

	[DllImport("HPSocket4C_U.dll", CharSet = CharSet.Ansi, SetLastError = true)]
	public static extern bool HP_Server_SendPart(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, int int_0, int int_1);

	[DllImport("HPSocket4C_U.dll", SetLastError = true)]
	public static extern bool HP_Server_SendPart(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, int int_0, int int_1);

	[DllImport("HPSocket4C_U.dll", SetLastError = true)]
	public static extern bool HP_Server_SendPackets(IntPtr intptr_0, IntPtr intptr_1, WSABUF[] wsabuf_0, int int_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern bool HP_Server_Disconnect(IntPtr intptr_0, IntPtr intptr_1, bool bool_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern bool HP_Server_DisconnectLongConnections(IntPtr intptr_0, uint uint_0, bool bool_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern bool HP_Server_DisconnectSilenceConnections(IntPtr intptr_0, uint uint_0, bool bool_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_Server_SetSendPolicy(IntPtr intptr_0, SendPolicy sendPolicy_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern SendPolicy HP_Server_GetSendPolicy(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern bool HP_Server_SetConnectionExtra(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2);

	[DllImport("HPSocket4C_U.dll")]
	public static extern bool HP_Server_GetConnectionExtra(IntPtr intptr_0, IntPtr intptr_1, ref IntPtr intptr_2);

	[DllImport("HPSocket4C_U.dll")]
	public static extern bool HP_Server_HasStarted(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern ServiceState HP_Server_GetState(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern SocketError HP_Server_GetLastError(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern IntPtr HP_Server_GetLastErrorDesc(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern bool HP_Server_GetPendingDataLength(IntPtr intptr_0, IntPtr intptr_1, ref int int_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern uint HP_Server_GetConnectionCount(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern bool HP_Server_GetAllConnectionIDs(IntPtr intptr_0, IntPtr[] intptr_1, ref uint uint_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern bool HP_Server_GetConnectPeriod(IntPtr intptr_0, IntPtr intptr_1, ref uint uint_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern bool HP_Server_GetSilencePeriod(IntPtr intptr_0, IntPtr intptr_1, ref uint uint_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern bool HP_Server_GetListenAddress(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, ref int int_0, ref ushort ushort_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern bool HP_Server_GetLocalAddress(IntPtr intptr_0, IntPtr intptr_1, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, ref int int_0, ref ushort ushort_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern bool HP_Server_GetRemoteAddress(IntPtr intptr_0, IntPtr intptr_1, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, ref int int_0, ref ushort ushort_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_Server_SetFreeSocketObjLockTime(IntPtr intptr_0, uint uint_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_Server_SetFreeSocketObjPool(IntPtr intptr_0, uint uint_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_Server_SetFreeBufferObjPool(IntPtr intptr_0, uint uint_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_Server_SetFreeSocketObjHold(IntPtr intptr_0, uint uint_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_Server_SetFreeBufferObjHold(IntPtr intptr_0, uint uint_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_Server_SetWorkerThreadCount(IntPtr intptr_0, uint uint_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_Server_SetMarkSilence(IntPtr intptr_0, bool bool_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern uint HP_Server_GetFreeSocketObjLockTime(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern uint HP_Server_GetFreeSocketObjPool(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern uint HP_Server_GetFreeBufferObjPool(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern uint HP_Server_GetFreeSocketObjHold(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern uint HP_Server_GetFreeBufferObjHold(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern uint HP_Server_GetWorkerThreadCount(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern bool HP_Server_IsMarkSilence(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern bool HP_TcpServer_SendSmallFile(IntPtr intptr_0, IntPtr intptr_1, string string_0, ref WSABUF wsabuf_0, ref WSABUF wsabuf_1);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_TcpServer_SetAcceptSocketCount(IntPtr intptr_0, uint uint_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_TcpServer_SetSocketBufferSize(IntPtr intptr_0, uint uint_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_TcpServer_SetSocketListenQueue(IntPtr intptr_0, uint uint_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_TcpServer_SetKeepAliveTime(IntPtr intptr_0, uint uint_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_TcpServer_SetKeepAliveInterval(IntPtr intptr_0, uint uint_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern uint HP_TcpServer_GetAcceptSocketCount(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern uint HP_TcpServer_GetSocketBufferSize(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern uint HP_TcpServer_GetSocketListenQueue(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern uint HP_TcpServer_GetKeepAliveTime(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern uint HP_TcpServer_GetKeepAliveInterval(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_UdpServer_SetMaxDatagramSize(IntPtr intptr_0, uint uint_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern uint HP_UdpServer_GetMaxDatagramSize(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_UdpServer_SetPostReceiveCount(IntPtr intptr_0, uint uint_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern uint HP_UdpServer_GetPostReceiveCount(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_UdpServer_SetDetectAttempts(IntPtr intptr_0, uint uint_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_UdpServer_SetDetectInterval(IntPtr intptr_0, uint uint_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern uint HP_UdpServer_GetDetectAttempts(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern uint HP_UdpServer_GetDetectInterval(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll", CharSet = CharSet.Unicode)]
	public static extern bool HP_Client_Start(IntPtr intptr_0, string string_0, ushort ushort_0, bool bool_0);

	[DllImport("HPSocket4C_U.dll", CharSet = CharSet.Unicode)]
	public static extern bool HP_Client_StartWithBindAddress(IntPtr intptr_0, string string_0, ushort ushort_0, bool bool_0, string string_1);

	[DllImport("HPSocket4C_U.dll")]
	public static extern bool HP_Client_Stop(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll", CharSet = CharSet.Ansi, SetLastError = true)]
	public static extern bool HP_Client_Send(IntPtr intptr_0, byte[] byte_0, int int_0);

	[DllImport("HPSocket4C_U.dll", SetLastError = true)]
	public static extern bool HP_Client_Send(IntPtr intptr_0, IntPtr intptr_1, int int_0);

	[DllImport("HPSocket4C_U.dll", CharSet = CharSet.Ansi, SetLastError = true)]
	public static extern bool HP_Client_SendPart(IntPtr intptr_0, byte[] byte_0, int int_0, int int_1);

	[DllImport("HPSocket4C_U.dll", SetLastError = true)]
	public static extern bool HP_Client_SendPart(IntPtr intptr_0, IntPtr intptr_1, int int_0, int int_1);

	[DllImport("HPSocket4C_U.dll", SetLastError = true)]
	public static extern bool HP_Client_SendPackets(IntPtr intptr_0, WSABUF[] wsabuf_0, int int_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_Client_SetExtra(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("HPSocket4C_U.dll")]
	public static extern IntPtr HP_Client_GetExtra(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern bool HP_Client_HasStarted(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern ServiceState HP_Client_GetState(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern SocketError HP_Client_GetLastError(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern IntPtr HP_Client_GetLastErrorDesc(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern IntPtr HP_Client_GetConnectionID(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern bool HP_Client_GetLocalAddress(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, ref int int_0, ref ushort ushort_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern bool HP_Client_GetPendingDataLength(IntPtr intptr_0, ref int int_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_Client_SetFreeBufferPoolSize(IntPtr intptr_0, uint uint_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_Client_SetFreeBufferPoolHold(IntPtr intptr_0, uint uint_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern uint HP_Client_GetFreeBufferPoolSize(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern uint HP_Client_GetFreeBufferPoolHold(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern bool HP_TcpClient_SendSmallFile(IntPtr intptr_0, string string_0, ref WSABUF wsabuf_0, ref WSABUF wsabuf_1);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_TcpClient_SetSocketBufferSize(IntPtr intptr_0, uint uint_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_TcpClient_SetKeepAliveTime(IntPtr intptr_0, uint uint_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_TcpClient_SetKeepAliveInterval(IntPtr intptr_0, uint uint_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern uint HP_TcpClient_GetSocketBufferSize(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern uint HP_TcpClient_GetKeepAliveTime(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern uint HP_TcpClient_GetKeepAliveInterval(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_UdpClient_SetMaxDatagramSize(IntPtr intptr_0, uint uint_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern uint HP_UdpClient_GetMaxDatagramSize(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_UdpClient_SetDetectAttempts(IntPtr intptr_0, uint uint_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_UdpClient_SetDetectInterval(IntPtr intptr_0, uint uint_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern uint HP_UdpClient_GetDetectAttempts(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern uint HP_UdpClient_GetDetectInterval(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll", CharSet = CharSet.Unicode)]
	public static extern bool HP_Agent_Start(IntPtr intptr_0, string string_0, bool bool_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern bool HP_Agent_Stop(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern bool HP_Agent_Connect(IntPtr intptr_0, string string_0, ushort ushort_0, ref IntPtr intptr_1);

	[DllImport("HPSocket4C_U.dll", CharSet = CharSet.Ansi, SetLastError = true)]
	public static extern bool HP_Agent_Send(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, int int_0);

	[DllImport("HPSocket4C_U.dll", SetLastError = true)]
	public static extern bool HP_Agent_Send(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, int int_0);

	[DllImport("HPSocket4C_U.dll", SetLastError = true)]
	public static extern bool HP_Agent_SendPart(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, int int_0, int int_1);

	[DllImport("HPSocket4C_U.dll", SetLastError = true)]
	public static extern bool HP_Agent_SendPart(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, int int_0, int int_1);

	[DllImport("HPSocket4C_U.dll", SetLastError = true)]
	public static extern bool HP_Agent_SendPackets(IntPtr intptr_0, IntPtr intptr_1, WSABUF[] wsabuf_0, int int_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern bool HP_Agent_Disconnect(IntPtr intptr_0, IntPtr intptr_1, bool bool_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern bool HP_Agent_DisconnectLongConnections(IntPtr intptr_0, uint uint_0, bool bool_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern bool HP_Agent_DisconnectSilenceConnections(IntPtr intptr_0, uint uint_0, bool bool_0);

	[DllImport("HPSocket4C_U.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern bool HP_TcpAgent_SendSmallFile(IntPtr intptr_0, IntPtr intptr_1, string string_0, ref WSABUF wsabuf_0, ref WSABUF wsabuf_1);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_Agent_SetSendPolicy(IntPtr intptr_0, SendPolicy sendPolicy_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern SendPolicy HP_Agent_GetSendPolicy(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern bool HP_Agent_SetConnectionExtra(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2);

	[DllImport("HPSocket4C_U.dll")]
	public static extern bool HP_Agent_GetConnectionExtra(IntPtr intptr_0, IntPtr intptr_1, ref IntPtr intptr_2);

	[DllImport("HPSocket4C_U.dll")]
	public static extern bool HP_Agent_HasStarted(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern ServiceState HP_Agent_GetState(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern uint HP_Agent_GetConnectionCount(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern bool HP_Agent_GetAllConnectionIDs(IntPtr intptr_0, IntPtr[] intptr_1, ref uint uint_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern bool HP_Agent_GetConnectPeriod(IntPtr intptr_0, IntPtr intptr_1, ref uint uint_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern bool HP_Agent_GetSilencePeriod(IntPtr intptr_0, IntPtr intptr_1, ref uint uint_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern bool HP_Agent_GetLocalAddress(IntPtr intptr_0, IntPtr intptr_1, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, ref int int_0, ref ushort ushort_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern bool HP_Agent_GetRemoteAddress(IntPtr intptr_0, IntPtr intptr_1, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, ref int int_0, ref ushort ushort_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern SocketError HP_Agent_GetLastError(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern IntPtr HP_Agent_GetLastErrorDesc(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern bool HP_Agent_GetPendingDataLength(IntPtr intptr_0, IntPtr intptr_1, ref int int_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_Agent_SetFreeSocketObjLockTime(IntPtr intptr_0, uint uint_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_Agent_SetFreeSocketObjPool(IntPtr intptr_0, uint uint_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_Agent_SetFreeBufferObjPool(IntPtr intptr_0, uint uint_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_Agent_SetFreeSocketObjHold(IntPtr intptr_0, uint uint_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_Agent_SetFreeBufferObjHold(IntPtr intptr_0, uint uint_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_Agent_SetWorkerThreadCount(IntPtr intptr_0, uint uint_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_Agent_SetMarkSilence(IntPtr intptr_0, bool bool_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern uint HP_Agent_GetFreeSocketObjLockTime(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern uint HP_Agent_GetFreeSocketObjPool(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern uint HP_Agent_GetFreeBufferObjPool(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern uint HP_Agent_GetFreeSocketObjHold(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern uint HP_Agent_GetFreeBufferObjHold(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern uint HP_Agent_GetWorkerThreadCount(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern bool HP_Agent_IsMarkSilence(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_TcpAgent_SetReuseAddress(IntPtr intptr_0, bool bool_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern bool HP_TcpAgent_IsReuseAddress(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_TcpAgent_SetSocketBufferSize(IntPtr intptr_0, uint uint_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_TcpAgent_SetKeepAliveTime(IntPtr intptr_0, uint uint_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_TcpAgent_SetKeepAliveInterval(IntPtr intptr_0, uint uint_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern uint HP_TcpAgent_GetSocketBufferSize(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern uint HP_TcpAgent_GetKeepAliveTime(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern uint HP_TcpAgent_GetKeepAliveInterval(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern FetchResult HP_TcpPullServer_Fetch(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, int int_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern FetchResult HP_TcpPullServer_Peek(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, int int_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern FetchResult HP_TcpPullClient_Fetch(IntPtr intptr_0, IntPtr intptr_1, int int_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern FetchResult HP_TcpPullClient_Peek(IntPtr intptr_0, IntPtr intptr_1, int int_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern FetchResult HP_TcpPullAgent_Fetch(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, int int_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern FetchResult HP_TcpPullAgent_Peek(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, int int_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_TcpPackServer_SetMaxPackSize(IntPtr intptr_0, uint uint_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_TcpPackServer_SetPackHeaderFlag(IntPtr intptr_0, ushort ushort_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern uint HP_TcpPackServer_GetMaxPackSize(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern ushort HP_TcpPackServer_GetPackHeaderFlag(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_TcpPackAgent_SetMaxPackSize(IntPtr intptr_0, uint uint_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_TcpPackAgent_SetPackHeaderFlag(IntPtr intptr_0, ushort ushort_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern uint HP_TcpPackAgent_GetMaxPackSize(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern ushort HP_TcpPackAgent_GetPackHeaderFlag(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_TcpPackClient_SetMaxPackSize(IntPtr intptr_0, uint uint_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern void HP_TcpPackClient_SetPackHeaderFlag(IntPtr intptr_0, ushort ushort_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern uint HP_TcpPackClient_GetMaxPackSize(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern ushort HP_TcpPackClient_GetPackHeaderFlag(IntPtr intptr_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern IntPtr HP_GetSocketErrorDesc(SocketError socketError_0);

	public static int SYS_GetLastError()
	{
		return Marshal.GetLastWin32Error();
	}

	[DllImport("HPSocket4C_U.dll", SetLastError = true)]
	public static extern int SYS_WSAGetLastError();

	[DllImport("HPSocket4C_U.dll", SetLastError = true)]
	public static extern int SYS_SetSocketOption(IntPtr intptr_0, int int_0, int int_1, IntPtr intptr_1, int int_2);

	[DllImport("HPSocket4C_U.dll", SetLastError = true)]
	public static extern int SYS_GetSocketOption(IntPtr intptr_0, int int_0, int int_1, IntPtr intptr_1, ref int int_2);

	[DllImport("HPSocket4C_U.dll", SetLastError = true)]
	public static extern int SYS_IoctlSocket(IntPtr intptr_0, long long_0, IntPtr intptr_1);

	[DllImport("HPSocket4C_U.dll", SetLastError = true)]
	public static extern int SYS_WSAIoctl(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, uint uint_1, IntPtr intptr_2, uint uint_2, uint uint_3);

	[DllImport("HPSocket4C_U.dll")]
	public static extern bool SYS_GetSocketLocalAddress(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, ref int int_0, ref ushort ushort_0);

	[DllImport("HPSocket4C_U.dll")]
	public static extern bool HP_Server_GetRemoteAddress(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, ref int int_0, ref ushort ushort_0);
}
