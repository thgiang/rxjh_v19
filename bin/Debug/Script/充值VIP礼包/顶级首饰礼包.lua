------������װVIP

function Open1008000515(UserWorldId, ItmeId, site, number)
	local Player = GetPlayer(UserWorldId)
	local Itme = GetWorldItme(ItmeId)
	if Player.Player_Zx==0 then 
	SendSysMsg(UserWorldId,"û��2ת�ǲ��ܴ����������!��ת������!", 9, "ϵͳ��ʾ")
	return 
end
 	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����2����λ", 9, "ϵͳ��ʾ")
	return 
end   
	UpUseItme(UserWorldId,site,1)
--[[	SetPlayerVIP(UserWorldId,0)
	SetPlayerShuxing(UserWorldId,0,0,0)
	Player.Player_WuXun=Player.Player_WuXun +0--]]
	if Player.Player_Job==1 then 
 --��
	if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--����
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����6����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700911,weizs[0],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,700911,weizs[1],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,100026,weizs[2],1,20000010,20000080,60000080,0,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[3],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[4],1,30000010,80000005,70000013,30000300,0,0,0,0,1)

 
	else
	--Ů��
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����6����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700911,weizs[0],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,700911,weizs[1],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,100026,weizs[2],1,20000010,20000080,60000080,0,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[3],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[4],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
 
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����6����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700911,weizs[0],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,700911,weizs[1],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,100026,weizs[2],1,20000010,20000080,60000080,0,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[3],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[4],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
 

	else
	--Ůа
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����6����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700911,weizs[0],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,700911,weizs[1],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,100026,weizs[2],1,20000010,20000080,60000080,0,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[3],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[4],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
 
	end
	end
	elseif Player.Player_Job==2 then 
--��
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--����
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����6����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700911,weizs[0],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,700911,weizs[1],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,100026,weizs[2],1,20000010,20000080,60000080,0,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[3],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[4],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
 
	else
	--Ů��
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����6����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700911,weizs[0],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,700911,weizs[1],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,100026,weizs[2],1,20000010,20000080,60000080,0,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[3],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[4],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
 	
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����6����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700911,weizs[0],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,700911,weizs[1],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,100026,weizs[2],1,20000010,20000080,60000080,0,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[3],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[4],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
 
	else
	--Ůа
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����6����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700911,weizs[0],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,700911,weizs[1],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,100026,weizs[2],1,20000010,20000080,60000080,0,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[3],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[4],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
 	
	end
	end
	elseif Player.Player_Job==3 then 
--ǹ
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--����.
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����6����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700911,weizs[0],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,700911,weizs[1],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,100026,weizs[2],1,20000010,20000080,60000080,0,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[3],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[4],1,30000010,80000005,70000013,30000300,0,0,0,0,1)


	else
	--Ů��
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����6����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700911,weizs[0],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,700911,weizs[1],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,100026,weizs[2],1,20000010,20000080,60000080,0,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[3],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[4],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
 	
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����6����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700911,weizs[0],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,700911,weizs[1],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,100026,weizs[2],1,20000010,20000080,60000080,0,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[3],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[4],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
 	
	else
	--Ůа
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����6����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700911,weizs[0],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,700911,weizs[1],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,100026,weizs[2],1,20000010,20000080,60000080,0,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[3],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[4],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
 	
	
	end
	end
	elseif Player.Player_Job==4 then 
--��
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--����
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����6����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700911,weizs[0],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,700911,weizs[1],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,100026,weizs[2],1,20000010,20000080,60000080,0,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[3],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[4],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
 	
	else
	--Ů��
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����6����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700911,weizs[0],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,700911,weizs[1],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,100026,weizs[2],1,20000010,20000080,60000080,0,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[3],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[4],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
 	
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����6����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700911,weizs[0],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,700911,weizs[1],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,100026,weizs[2],1,20000010,20000080,60000080,0,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[3],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[4],1,30000010,80000005,70000013,30000300,0,0,0,0,1)

 	
 	
	else
	--Ůа
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����6����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700911,weizs[0],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,700911,weizs[1],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,100026,weizs[2],1,20000010,20000080,60000080,0,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[3],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[4],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
 	
 	
	
	end
	end
	elseif Player.Player_Job==5 then 
--ҽ
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--����
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����6����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700911,weizs[0],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,700911,weizs[1],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,100026,weizs[2],1,20000010,20000080,60000080,0,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[3],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[4],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
 	
 
	else
	--Ů��
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����6����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700911,weizs[0],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,700911,weizs[1],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,100026,weizs[2],1,20000010,20000080,60000080,0,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[3],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[4],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
 	
 
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����6����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700911,weizs[0],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,700911,weizs[1],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,100026,weizs[2],1,20000010,20000080,60000080,0,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[3],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[4],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
 	
 	
	else
	--Ůа
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����6����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700911,weizs[0],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,700911,weizs[1],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,100026,weizs[2],1,20000010,20000080,60000080,0,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[3],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[4],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
 	
 
	end
	end
	elseif Player.Player_Job==6 then 
--CK
	if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--����
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����6����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700911,weizs[0],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,700911,weizs[1],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,100026,weizs[2],1,20000010,20000080,60000080,0,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[3],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[4],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
 	
 	
	else
	--Ů��
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����6����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700911,weizs[0],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,700911,weizs[1],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,100026,weizs[2],1,20000010,20000080,60000080,0,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[3],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[4],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
 	
 	
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����6����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700911,weizs[0],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,700911,weizs[1],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,100026,weizs[2],1,20000010,20000080,60000080,0,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[3],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[4],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
 	
 
	else
	--Ůа
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����6����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700911,weizs[0],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,700911,weizs[1],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,100026,weizs[2],1,20000010,20000080,60000080,0,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[3],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[4],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
 	
 
	end
	end
	elseif Player.Player_Job==7 then 
--��ʦ
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--����
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����6����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700911,weizs[0],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,700911,weizs[1],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,100026,weizs[2],1,20000010,20000080,60000080,0,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[3],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[4],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
 	

 
	else
	--Ů��
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����6����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700911,weizs[0],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,700911,weizs[1],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,100026,weizs[2],1,20000010,20000080,60000080,0,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[3],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[4],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
 	

 
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����6����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700911,weizs[0],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,700911,weizs[1],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,100026,weizs[2],1,20000010,20000080,60000080,0,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[3],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[4],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
 	

 	
	else
	--Ůа
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����6����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700911,weizs[0],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,700911,weizs[1],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,100026,weizs[2],1,20000010,20000080,60000080,0,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[3],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[4],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
 	
end
	end
	elseif Player.Player_Job==8 then 
--����
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--����
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����6����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700911,weizs[0],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,700911,weizs[1],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,100026,weizs[2],1,20000010,20000080,60000080,0,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[3],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[4],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
 	

 
	else
	--Ů��
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����6����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700911,weizs[0],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,700911,weizs[1],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,100026,weizs[2],1,20000010,20000080,60000080,0,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[3],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[4],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
 	

 
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����6����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700911,weizs[0],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,700911,weizs[1],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,100026,weizs[2],1,20000010,20000080,60000080,0,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[3],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[4],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
 	

 	
	else
	--Ůа
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����6����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700911,weizs[0],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,700911,weizs[1],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,100026,weizs[2],1,20000010,20000080,60000080,0,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[3],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[4],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
 	
end
	end
	elseif Player.Player_Job==9 then 
--̷����
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--����
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����6����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700911,weizs[0],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,700911,weizs[1],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,100026,weizs[2],1,20000010,20000080,60000080,0,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[3],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[4],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
 	

 
	else
	--Ů��
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����6����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700911,weizs[0],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,700911,weizs[1],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,100026,weizs[2],1,20000010,20000080,60000080,0,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[3],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[4],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
 	

 
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����6����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700911,weizs[0],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,700911,weizs[1],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,100026,weizs[2],1,20000010,20000080,60000080,0,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[3],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[4],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
 	

 	
	else
	--Ůа
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����6����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700911,weizs[0],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,700911,weizs[1],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,100026,weizs[2],1,20000010,20000080,60000080,0,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[3],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[4],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
 	

end
end
	elseif Player.Player_Job==10 then 
--ȭ����
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--����
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����6����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700911,weizs[0],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,700911,weizs[1],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,100026,weizs[2],1,20000010,20000080,60000080,0,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[3],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[4],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
 	

 
	else
	--Ů��
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����6����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700911,weizs[0],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,700911,weizs[1],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,100026,weizs[2],1,20000010,20000080,60000080,0,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[3],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[4],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
 	

 
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����6����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700911,weizs[0],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,700911,weizs[1],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,100026,weizs[2],1,20000010,20000080,60000080,0,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[3],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[4],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
 	

 	
	else
	--Ůа
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����6����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700911,weizs[0],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,700911,weizs[1],1,10000010,70000015,10000070,0,0,0,0,0,1)
AddItmeProp(UserWorldId,100026,weizs[2],1,20000010,20000080,60000080,0,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[3],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
AddItmeProp(UserWorldId,18,weizs[4],1,30000010,80000005,70000013,30000300,0,0,0,0,1)
 	

	end
	end
	SendSysMsg(UserWorldId,"��ϲ����ö������Σ�", 9, "ϵͳ��ʾ")
        --SendSysMsg(UserWorldId,"��ϲ����ö������Σ�", 9, "ϵͳ��ʾ")
	--SendNoticeMsg("������VIP��װ����",2)
	--SendNoticeMsg("���������VIP��װһ�׹�6��!",2)
	--SendNoticeMsg("������ף�����Ϸ����",2)
	--elseif Player.Player_Zx==0 then SendSysMsg(UserWorldId,"��û����ְ���ܴ�", 9, "ϵͳ��ʾ")
--return 
	end

end