----ת�����---
function zhuanshengjiang(UserWorldId, ItmeId, site, number)
	local Player = GetPlayer(UserWorldId)
	local Itme = GetWorldItme(ItmeId)
	local weizs=GetPackages(UserWorldId,5)
if weizs.Count<5 then
	SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ�������,����3����λ", 9, "ϵͳ��ʾ")
	return 
end
UpUseItme(UserWorldId,site,1)
AddItmeProp(UserWorldId,800000062,weizs[0],1,1100035,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,800000062,weizs[1],1,1100035,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,800000062,weizs[2],1,1100035,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,800000062,weizs[3],1,1100035,0,0,0,0,0,0,0,0)
end

