------VIP����ʵ��װ80��װ

function Open1008000522(UserWorldId, ItmeId, site, number)
	local Player = GetPlayer(UserWorldId)
	local Itme = GetWorldItme(ItmeId)	
     	local weizs=GetPackages(UserWorldId,20)
if weizs.Count<10 then 
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����6����λ", 9, "ϵͳ��ʾ")
	return 
end        
	UpUseItme(UserWorldId,site,1)
--[[	SetPlayerVIP(UserWorldId,1)
	SetPlayerShuxing(UserWorldId,100000,100000,0)
	Player.Player_WuXun=Player.Player_WuXun +1200000--]]
	if Player.Player_Job==1 and Player.Player_Sex==1 then 
 --������
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)


--����Ů 
 elseif Player.Player_Job==1 and Player.Player_Sex==2 then 

AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)


 --а����
elseif Player.Player_Job==1 and Player.Player_Sex==1 then 

AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)
 
 --а��Ů
elseif Player.Player_Job==1 and Player.Player_Sex==2 then 
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)

 --������
elseif Player.Player_Job==2 and Player.Player_Sex==1 then 
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)

 --����Ů
elseif Player.Player_Job==2 and Player.Player_Sex==2 then 
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)


--а���� 	
elseif Player.Player_Job==2 and Player.Player_Sex==1 then 
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)

elseif Player.Player_Job==2 and Player.Player_Sex==2 then 
--а��Ů
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)

--��ǹ�� 	
elseif Player.Player_Job==3 and Player.Player_Sex==1 then 
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)


--��ǹŮ 
elseif Player.Player_Job==3 and Player.Player_Sex==2 then 
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)


--аǹ�� 	
elseif Player.Player_Job==3 and Player.Player_Sex==1 then 
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)

--аǹŮ 	
elseif Player.Player_Job==3 and Player.Player_Sex==2 then 
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)

--������ 	
	
elseif Player.Player_Job==4 and Player.Player_Sex==1 then 
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)


--����Ů
elseif Player.Player_Job==4 and Player.Player_Sex==2 then 
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)


--а���� 	
elseif Player.Player_Job==4 and Player.Player_Sex==1 then 
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)

--а��Ů 	
elseif Player.Player_Job==4 and Player.Player_Sex==2 then 
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)

 --��ҽ��		
elseif Player.Player_Job==5 and Player.Player_Sex==1 then 
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)


 --��ҽŮ
elseif Player.Player_Job==5 and Player.Player_Sex==2 then
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)


 --аҽ��
elseif Player.Player_Job==5 and Player.Player_Sex==1 then
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)


 --аҽŮ	
elseif Player.Player_Job==5 and Player.Player_Sex==2 then
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)

--CK��		
elseif Player.Player_Job==6 and Player.Player_Sex==1 then 
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)


 --CKŮ
elseif Player.Player_Job==6 and Player.Player_Sex==2 then
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)


--��ʦ��		
elseif Player.Player_Job==7 and Player.Player_Sex==1 then 
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)


 --��ʦŮ
elseif Player.Player_Job==7 and Player.Player_Sex==2 then
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)


--������		
elseif Player.Player_Job==8 and Player.Player_Sex==1 then 
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)


 --����Ů
elseif Player.Player_Job==8 and Player.Player_Sex==2 then
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)


--̷������		
elseif Player.Player_Job==9 and Player.Player_Sex==1 then 
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)


 --̷����Ů
elseif Player.Player_Job==9 and Player.Player_Sex==2 then
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)


--�񶷼���		
elseif Player.Player_Job==10 and Player.Player_Sex==1 then 
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)


--�񶷼�Ů
elseif Player.Player_Job==10 and Player.Player_Sex==2 then
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)

	elseif Player.Player_Job==11 and Player.Player_Sex==1 then 
--��
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)

	elseif Player.Player_Job==11 and Player.Player_Sex==2 then 

AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)

	elseif Player.Player_Job==12 and Player.Player_Sex==1 then 
--¬
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)

	elseif Player.Player_Job==12 and Player.Player_Sex==2 then 

AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)


	end
	end
