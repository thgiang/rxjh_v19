function SetPlayerzhuangbei(UserWorldId, ItmeId, site, number)
	local Player = GetPlayer(UserWorldId)
	local Itme = GetWorldItme(ItmeId)
	if Player.Player_Zx==0 then 
	SendSysMsg(UserWorldId,"û��2ת�ǲ��ܴ����������!��ת������!", 9, "ϵͳ��ʾ")
	return 
end
        	local weizs=GetPackages(UserWorldId,5)
if weizs.Count<5 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����5����λ", 9, "ϵͳ��ʾ")
	return 
end 
	UpUseItme(UserWorldId,site,1)
	--SetPlayerVIP(UserWorldId,12)
	
	if Player.Player_Job==1 then 
 --��
	if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--����
	local weizs=GetPackages(UserWorldId,5)
if weizs.Count<5 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����5����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,110301015,weizs[0],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,502016,weizs[1],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,802017,weizs[2],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,400015,weizs[3],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,502016,weizs[4],1,0,0,0,0,0,0,0,2,0)
 
	else
	--Ů��
	local weizs=GetPackages(UserWorldId,5)
if weizs.Count<5 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����5����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,120301015,weizs[0],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,502016,weizs[1],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,802017,weizs[2],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,400015,weizs[3],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,502016,weizs[4],1,0,0,0,0,0,0,0,2,0)
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,5)
if weizs.Count<5 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����5����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,110302015,weizs[0],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,502016,weizs[1],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,802017,weizs[2],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,400015,weizs[3],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,502016,weizs[4],1,0,0,0,0,0,0,0,2,0)
	else
	--Ůа
	local weizs=GetPackages(UserWorldId,5)
if weizs.Count<5 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����5����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,100202260,weizs[0],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,502016,weizs[1],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,802017,weizs[2],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,400015,weizs[3],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,502016,weizs[4],1,0,0,0,0,0,0,0,2,0)
	end
	end
	elseif Player.Player_Job==2 then 
--��
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--����
	local weizs=GetPackages(UserWorldId,5)
if weizs.Count<5 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����5����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,210301015,weizs[0],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,502016,weizs[1],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,802017,weizs[2],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,400015,weizs[3],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,502016,weizs[4],1,0,0,0,0,0,0,0,2,0)
	else
	--Ů��
	local weizs=GetPackages(UserWorldId,5)
if weizs.Count<5 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����5����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,220301015,weizs[0],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,502016,weizs[1],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,802017,weizs[2],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,400015,weizs[3],1,0,0,0,0,0,0,0,2,0)	
AddItmeProp(UserWorldId,502016,weizs[4],1,0,0,0,0,0,0,0,2,0)
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,5)
if weizs.Count<5 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����5����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,210302015,weizs[0],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,502016,weizs[1],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,802017,weizs[2],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,400015,weizs[3],1,0,0,0,0,0,0,0,2,0)	
AddItmeProp(UserWorldId,502016,weizs[4],1,0,0,0,0,0,0,0,2,0)
	else
	--Ůа
	local weizs=GetPackages(UserWorldId,5)
if weizs.Count<5 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����5����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,120302015,weizs[0],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,502016,weizs[1],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,802017,weizs[2],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,400015,weizs[3],1,0,0,0,0,0,0,0,2,0)	
AddItmeProp(UserWorldId,502016,weizs[4],1,0,0,0,0,0,0,0,2,0)
	end
	end
	elseif Player.Player_Job==3 then 
--ǹ
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--����.
	local weizs=GetPackages(UserWorldId,5)
if weizs.Count<5 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����5����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,310301015,weizs[0],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,502016,weizs[1],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,802017,weizs[2],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,400015,weizs[3],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,502016,weizs[4],1,0,0,0,0,0,0,0,2,0)
	else
	--Ů��
	local weizs=GetPackages(UserWorldId,5)
if weizs.Count<5 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����5����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,320301015,weizs[0],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,502016,weizs[1],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,802017,weizs[2],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,400015,weizs[3],1,0,0,0,0,0,0,0,2,0)	
AddItmeProp(UserWorldId,502016,weizs[4],1,0,0,0,0,0,0,0,2,0)
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,5)
if weizs.Count<5 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����5����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,310302015,weizs[0],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,502016,weizs[1],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,802017,weizs[2],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,400015,weizs[3],1,0,0,0,0,0,0,0,2,0)	
AddItmeProp(UserWorldId,502016,weizs[4],1,0,0,0,0,0,0,0,2,0)
	else
	--Ůа
	local weizs=GetPackages(UserWorldId,5)
if weizs.Count<5 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����5����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,320302015,weizs[0],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,502016,weizs[1],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,802017,weizs[2],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,400015,weizs[3],1,0,0,0,0,0,0,0,2,0)	
AddItmeProp(UserWorldId,502016,weizs[4],1,0,0,0,0,0,0,0,2,0)
	
	end
	end
	elseif Player.Player_Job==4 then 
--��
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--����
	local weizs=GetPackages(UserWorldId,5)
if weizs.Count<5 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����5����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,410301015,weizs[0],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,502016,weizs[1],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,802017,weizs[2],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,400015,weizs[3],1,0,0,0,0,0,0,0,2,0)	
AddItmeProp(UserWorldId,502016,weizs[4],1,0,0,0,0,0,0,0,2,0)
	else
	--Ů��
	local weizs=GetPackages(UserWorldId,5)
if weizs.Count<5 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����5����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,420301015,weizs[0],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,502016,weizs[1],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,802017,weizs[2],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,400015,weizs[3],1,0,0,0,0,0,0,0,2,0)	
AddItmeProp(UserWorldId,502016,weizs[4],1,0,0,0,0,0,0,0,2,0)
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,5)
if weizs.Count<5 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����5����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,410302015,weizs[0],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,502016,weizs[1],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,802017,weizs[2],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,400015,weizs[3],1,0,0,0,0,0,0,0,2,0)	
AddItmeProp(UserWorldId,502016,weizs[4],1,0,0,0,0,0,0,0,2,0)
	else
	--Ůа
	local weizs=GetPackages(UserWorldId,5)
if weizs.Count<5 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����5����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,420302015,weizs[0],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,502016,weizs[1],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,802017,weizs[2],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,400015,weizs[3],1,0,0,0,0,0,0,0,2,0)	
AddItmeProp(UserWorldId,502016,weizs[4],1,0,0,0,0,0,0,0,2,0)
	end
	end
	elseif Player.Player_Job==5 then 
--ҽ
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--����
	local weizs=GetPackages(UserWorldId,5)
if weizs.Count<5 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����5����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,510301015,weizs[0],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,502016,weizs[1],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,802017,weizs[2],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,400015,weizs[3],1,0,0,0,0,0,0,0,2,0) 
AddItmeProp(UserWorldId,502016,weizs[4],1,0,0,0,0,0,0,0,2,0)
	else
	--Ů��
	local weizs=GetPackages(UserWorldId,5)
if weizs.Count<5 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����5����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,520301015,weizs[0],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,502016,weizs[1],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,802017,weizs[2],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,400015,weizs[3],1,0,0,0,0,0,0,0,2,0) 
AddItmeProp(UserWorldId,502016,weizs[4],1,0,0,0,0,0,0,0,2,0)
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,5)
if weizs.Count<5 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����5����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,510302015,weizs[0],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,502016,weizs[1],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,802017,weizs[2],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,400015,weizs[3],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,502016,weizs[4],1,0,0,0,0,0,0,0,2,0)
	else
	--Ůа
	local weizs=GetPackages(UserWorldId,5)
if weizs.Count<5 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����5����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,520302015,weizs[0],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,502016,weizs[1],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,802017,weizs[2],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,400015,weizs[3],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,502016,weizs[4],1,0,0,0,0,0,0,0,2,0)
	end
	end
	elseif Player.Player_Job==6 then 
--CK
	if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--����
	local weizs=GetPackages(UserWorldId,5)
if weizs.Count<5 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����5����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,710301015,weizs[0],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,502016,weizs[1],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,802017,weizs[2],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,400015,weizs[3],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,502016,weizs[4],1,0,0,0,0,0,0,0,2,0)
	else
	--Ů��
	local weizs=GetPackages(UserWorldId,5)
if weizs.Count<5 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����5����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,720301015,weizs[0],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,502016,weizs[1],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,802017,weizs[2],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,400015,weizs[3],1,0,0,0,0,0,0,0,2,0)	
AddItmeProp(UserWorldId,502016,weizs[4],1,0,0,0,0,0,0,0,2,0)
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,5)
if weizs.Count<5 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����5����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,710302015,weizs[0],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,502016,weizs[1],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,802017,weizs[2],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,400015,weizs[3],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,502016,weizs[4],1,0,0,0,0,0,0,0,2,0)
	else
	--Ůа
	local weizs=GetPackages(UserWorldId,5)
if weizs.Count<5 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����5����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,720302015,weizs[0],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,502016,weizs[1],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,802017,weizs[2],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,400015,weizs[3],1,0,0,0,0,0,0,0,2,0)
	end
	end
	elseif Player.Player_Job==7 then 
--��ʦ
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--����
	local weizs=GetPackages(UserWorldId,5)
if weizs.Count<5 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����5����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,810301015,weizs[0],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,502016,weizs[1],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,802017,weizs[2],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,400015,weizs[3],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,502016,weizs[4],1,0,0,0,0,0,0,0,2,0)
	else
	--Ů��
	local weizs=GetPackages(UserWorldId,5)
if weizs.Count<5 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����5����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,820301015,weizs[0],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,502016,weizs[1],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,802017,weizs[2],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,400015,weizs[3],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,502016,weizs[4],1,0,0,0,0,0,0,0,2,0)
 
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,5)
if weizs.Count<5 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����5����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,810302014,weizs[0],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,502016,weizs[1],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,802017,weizs[2],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,400015,weizs[3],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,502016,weizs[4],1,0,0,0,0,0,0,0,2,0)

 	
	else
	--Ůа
	local weizs=GetPackages(UserWorldId,5)
if weizs.Count<5 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����5����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,820302015,weizs[0],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,502016,weizs[1],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,802017,weizs[2],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,400015,weizs[3],1,0,0,0,0,0,0,0,2,0)
AddItmeProp(UserWorldId,502016,weizs[4],1,0,0,0,0,0,0,0,2,0)
 
	end
	end
	--SendSysMsg(UserWorldId,"��ϲ�����12���»�Ա��", 9, "ϵͳ��ʾ")
        --SendSysMsg(UserWorldId,"��ϲ�����10W�����ͷ�����", 9, "ϵͳ��ʾ")
	--SendNoticeMsg("������VIP��װ����",2)
	--SendNoticeMsg("���������VIP��װһ�׹�14��!",2)
	--SendNoticeMsg("������ף�����Ϸ����",2)
	--elseif Player.Player_Zx==0 then SendSysMsg(UserWorldId,"��û����ְ���ܴ�", 9, "ϵͳ��ʾ")
--return 
	end

end