------������װVIP

function Open1008000512(UserWorldId, ItmeId, site, number)
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
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����15����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)





 
	else
	--Ů��
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����15����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)




 
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����15����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)




 

	else
	--Ůа
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����15����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)




 
	end
	end
	elseif Player.Player_Job==2 then 
--��
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--����
	local weizs=GetPackages(UserWorldId,16)
if weizs.Count<16 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����15����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)




 
	else
	--Ů��
	local weizs=GetPackages(UserWorldId,16)
if weizs.Count<16 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����15����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)





 	
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,16)
if weizs.Count<16 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����15����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)






 
	else
	--Ůа
	local weizs=GetPackages(UserWorldId,16)
if weizs.Count<16 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����15����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)




 	
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
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)
  
	else
	--Ů��
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)

 	
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)

 	
	else
	--Ůа
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)

 	
	
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
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)

 
 	
	else
	--Ů��
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)


 	
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)

 	
	else
	--Ůа
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)

 	
	
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
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)

  
	else
	--Ů��
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)

 
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)


 	
	else
	--Ůа
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)

 
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
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)

 
 	
	else
	--Ů��
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)
 	
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)


 
	else
	--Ůа
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)



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
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)

  
	else
	--Ů��
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)


 
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)

 	
	else
	--Ůа
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)


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
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)

 
 
	else
	--Ů��
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)

 
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)

 	
	else
	--Ůа
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)


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
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)

 

 
	else
	--Ů��
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)



 
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)


 	
	else
	--Ůа
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)


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
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)
 


 
	else
	--Ů��
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)


 
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)


 	
	else
	--Ůа
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)


	end
	end
	elseif Player.Player_Job==11 then 
--÷
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--����
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)
 


 
	else
	--Ů��
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)


 
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)


 	
	else
	--Ůа
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)


	end
	end
	elseif Player.Player_Job==12 then 
--¬
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--����
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)
 


 
	else
	--Ů��
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)


 
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)


 	
	else
	--Ůа
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����10����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)


	end
	end
	SendSysMsg(UserWorldId,"��ϲ�����1���»�Ա��", 9, "ϵͳ��ʾ")
        --SendSysMsg(UserWorldId,"��ϲ�������-140PVP����2һ�װף�", 9, "ϵͳ��ʾ")
	--SendNoticeMsg("������VIP��װ����",2)
	--SendNoticeMsg("���������VIP��װһ�׹�6��!",2)
	--SendNoticeMsg("������ף�����Ϸ����",2)
	--elseif Player.Player_Zx==0 then SendSysMsg(UserWorldId,"��û����ְ���ܴ�", 9, "ϵͳ��ʾ")
--return 
	end

end