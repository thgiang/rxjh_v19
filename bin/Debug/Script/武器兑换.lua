function SetPlayerwuqi(UserWorldId, ItmeId, site, number)
	local Player = GetPlayer(UserWorldId)
	local Itme = GetWorldItme(ItmeId)
	if Player.Player_Zx==0 then 
	SendSysMsg(UserWorldId,"û��2ת�ǲ��ܴ����������!��ת������!", 9, "ϵͳ��ʾ")
	return 
end
        	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����2����λ", 9, "ϵͳ��ʾ")
	return 
end 
	UpUseItme(UserWorldId,site,1)
	--SetPlayerVIP(UserWorldId,12)
	
	if Player.Player_Job==1 then 
 --��
	if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--����
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����2����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,100201250,weizs[0],1,0,0,0,0,0,0,0,2,0)

	else
	--Ů��
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����2����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,100201250,weizs[0],1,0,0,0,0,0,0,0,2,0)

	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����2����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,100202260,weizs[0],1,0,0,0,0,0,0,0,2,0)


	else
	--Ůа
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����2����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,100202260,weizs[0],1,0,0,0,0,0,0,0,2,0)

	end
	end
	elseif Player.Player_Job==2 then 
--��
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--����
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����2����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,200201250,weizs[0],1,0,0,0,0,0,0,0,2,0)

	else
	--Ů��
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����2����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,200201250,weizs[0],1,0,0,0,0,0,0,0,2,0)
	
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����2����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,200202260,weizs[0],1,0,0,0,0,0,0,0,2,0)
	else
	--Ůа
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����2����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,200202260,weizs[0],1,0,0,0,0,0,0,0,2,0)

	end
	end
	elseif Player.Player_Job==3 then 
--ǹ
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--����.
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����2����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,300201250,weizs[0],1,0,0,0,0,0,0,0,2,0)

	else
	--Ů��
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����2����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,300201250,weizs[0],1,0,0,0,0,0,0,0,2,0)
	
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����2����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,300202260,weizs[0],1,0,0,0,0,0,0,0,2,0)
	
	else
	--Ůа
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����2����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,300202260,weizs[0],1,0,0,0,0,0,0,0,2,0)
	
	
	end
	end
	elseif Player.Player_Job==4 then 
--��
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--����
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����2����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,400201250,weizs[0],1,0,0,0,0,0,0,0,2,0)
	
	else
	--Ů��
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����2����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,400201250,weizs[0],1,0,0,0,0,0,0,0,2,0)
	
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����2����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,400202260,weizs[0],1,0,0,0,0,0,0,0,2,0)

	else
	--Ůа
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����2����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,400202260,weizs[0],1,0,0,0,0,0,0,0,2,0)

	end
	end
	elseif Player.Player_Job==5 then 
--ҽ
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--����
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����2����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,500201250,weizs[0],1,0,0,0,0,0,0,0,2,0)

	else
	--Ů��
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����2����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,500201250,weizs[0],1,0,0,0,0,0,0,0,2,0)

	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����2����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,500202260,weizs[0],1,0,0,0,0,0,0,0,2,0)
	else
	--Ůа
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����2����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,500202260,weizs[0],1,0,0,0,0,0,0,0,2,0)

	end
	end
	elseif Player.Player_Job==6 then 
--CK
	if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--����
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����2����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700201250,weizs[0],1,0,0,0,0,0,0,0,2,0)
	
	else
	--Ů��
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����2����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700201250,weizs[0],1,0,0,0,0,0,0,0,2,0)
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����2����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700202260,weizs[0],1,0,0,0,0,0,0,0,2,0)

	else
	--Ůа
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����2����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,700202260,weizs[0],1,0,0,0,0,0,0,0,2,0)

	end
	end
	elseif Player.Player_Job==7 then 
--��ʦ
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--����
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����2����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,800201250,weizs[0],1,0,0,0,0,0,0,0,2,0)

	else
	--Ů��
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����2����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,800201250,weizs[0],1,0,0,0,0,0,0,0,2,0)
 
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--��а
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����2����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,800202260,weizs[0],1,0,0,0,0,0,0,0,2,0)

 	
	else
	--Ůа
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����2����λ", 9, "ϵͳ��ʾ")
	return 
end
AddItmeProp(UserWorldId,800202260,weizs[0],1,0,0,0,0,0,0,0,2,0)

 
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