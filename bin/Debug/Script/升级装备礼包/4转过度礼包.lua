------������װVIP

function Open1008000521(UserWorldId, ItmeId, site, number)
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
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,100201029,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,110301008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,801010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)


 
	else
	--Ů��
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,100201029,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,120301008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,801010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)

 	
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,100202030,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,110302008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,802010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)

 

	else
	--Ůа
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,100202030,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,120302008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,802010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)


 
	end
	end
	elseif Player.Player_Job==2 then 
--��
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--����
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,200201029,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,210301008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,801010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)

 
	else
	--Ů��
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,200201029,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,220301008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,801010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)

 	
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,200202030,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,210302008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,802010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)

 
	else
	--Ůа
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,200202030,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,220302008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,802010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)


 	
	end
	end
	elseif Player.Player_Job==3 then 
--ǹ
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--����.
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,300201029,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,310301008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,801010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)

 
	else
	--Ů��
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,300201029,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,320301008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,801010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)

 	
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,300202030,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,310302008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,802010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)

 	
	else
	--Ůа
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,300202030,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,320302008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,802010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)

 	
	
	end
	end
	elseif Player.Player_Job==4 then 
--��
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--����
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,400201029,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,410301008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,801010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)


 	
	else
	--Ů��
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,400201029,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,420301008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,801010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)

 	
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,400202030,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,410302008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,802010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)

 	
	else
	--Ůа
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,400202030,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,420302008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,802010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)

 	
	
	end
	end
	elseif Player.Player_Job==5 then 
--ҽ
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--����
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,500201029,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,510301008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,801010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)


 
	else
	--Ů��
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,500201029,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,520301008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,801010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)

 
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,500202030,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,510302008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,802010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)


 	
	else
	--Ůа
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,500202030,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,520302008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,802010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)

 
	end
	end
	elseif Player.Player_Job==6 then 
--CK
	if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--����
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700201029,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,710301008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,801010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)


 	
	else
	--Ů��
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700201029,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,720301008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,801010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)

 	
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700202030,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,710302008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,802010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)


 
	else
	--Ůа
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700202030,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,720302008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,802010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)

	end
	end
	elseif Player.Player_Job==7 then 
--��ʦ
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--����
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,800201029,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,810301008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,801010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)

 
	else
	--Ů��
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,800201029,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,820301008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,801010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)

 
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,800202030,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,810302008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,802010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)

 	
	else
	--Ůа
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,800202030,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,820302008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,802010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)



end
	end
	elseif Player.Player_Job==8 then 
--����
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--����
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,100204015,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,110304008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,801010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)


 
	else
	--Ů��
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,100204015,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,120304008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,801010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)


	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,100204015,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,110304008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,802010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)


 	
	else
	--Ůа
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,100204015,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,120304008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,802010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)


end
	end
	elseif Player.Player_Job==9 then 
--̷����
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--����
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,200204015,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,210304008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,801010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)



 
	else
	--Ů��
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,200204015,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,220304008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,801010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)



 
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,200204015,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,210304008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,802010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)



 	
	else
	--Ůа
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,200204015,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,220304008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,802010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)


end
end
	elseif Player.Player_Job==10 then 
--�񶷼�
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--����
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,900201029,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,910301008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,801010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)



 
	else
	--Ů��
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,900201029,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,920301008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,801010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)


 
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,900202030,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,910302008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,802010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)


 	
	else
	--Ůа
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,900202030,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,920302008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,802010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)


	end
	end
	elseif Player.Player_Job==11 then 
--÷����
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--����
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,400204015,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,410304008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,500109,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,500109,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,800110,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400108,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)



 
	else
	--Ů��
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,400204015,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,420304008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,500109,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,500109,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,800110,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400108,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)



 
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,400204015,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,410304008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502109,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502109,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,802110,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400108,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)



 	
	else
	--Ůа
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,400204015,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,420304008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502109,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502109,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,802110,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400108,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)


end
end
	elseif Player.Player_Job==12 then 
--¬����
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--����
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,300204015,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,310304008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,801010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)



 
	else
	--Ů��
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,300204015,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,320304008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,501009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,801010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)



 
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,300204015,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,310304008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,802010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)



 	
	else
	--Ůа
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,300204015,weizs[0],1,1010001910,70000030,70000030,70000030,70000030,0,0,0,0)
AddItmeProp(UserWorldId,320304008,weizs[1],1,1020001910,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[2],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,502009,weizs[3],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,802010,weizs[4],1,20000010,20000010,20000010,20000010,20000010,0,0,0,0)
AddItmeProp(UserWorldId,400008,weizs[5],1,20000010,20000010,20000010,0,0,0,0,0,0)
end
end
	--elseif Player.Player_Zx==0 then SendSysMsg(UserWorldId,"��û����ְ���ܴ�", 9, "ϵͳ��ʾ")
--return 
	end

end