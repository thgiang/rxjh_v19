namespace RxjhServer.Network
{
	public enum SocketError
	{
		Ok = 0,
		IllegalState = 1,
		InvalidParam = 2,
		SocketCreate = 3,
		SocketBind = 4,
		SocketPrepare = 5,
		SocketListen = 6,
		CPCreate = 7,
		WorkerThreadCreate = 8,
		DetectThreadCreate = 9,
		SocketAttachToCP = 10,
		ConnectServer = 11,
		Network = 12,
		DataProc = 13,
		DataSend = 14,
		SSLEnvNotReady = 101
	}
}
