----转生礼包---
function zhuanshengjiang(UserWorldId, ItmeId, site, number)
	local Player = GetPlayer(UserWorldId)
	local Itme = GetWorldItme(ItmeId)
	local weizs=GetPackages(UserWorldId,5)
if weizs.Count<5 then
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出3个空位", 9, "系统提示")
	return 
end
UpUseItme(UserWorldId,site,1)
AddItmeProp(UserWorldId,800000062,weizs[0],1,1100035,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,800000062,weizs[1],1,1100035,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,800000062,weizs[2],1,1100035,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,800000062,weizs[3],1,1100035,0,0,0,0,0,0,0,0)
end

