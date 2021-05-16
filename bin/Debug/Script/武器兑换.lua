function SetPlayerwuqi(UserWorldId, ItmeId, site, number)
	local Player = GetPlayer(UserWorldId)
	local Itme = GetWorldItme(ItmeId)
	if Player.Player_Zx==0 then 
	SendSysMsg(UserWorldId,"没有2转是不能打开新手礼包的!二转再来吧!", 9, "系统提示")
	return 
end
        	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出2个空位", 9, "系统提示")
	return 
end 
	UpUseItme(UserWorldId,site,1)
	--SetPlayerVIP(UserWorldId,12)
	
	if Player.Player_Job==1 then 
 --刀
	if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--男正
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出2个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,100201250,weizs[0],1,0,0,0,0,0,0,0,2,0)

	else
	--女正
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出2个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,100201250,weizs[0],1,0,0,0,0,0,0,0,2,0)

	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--男邪
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出2个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,100202260,weizs[0],1,0,0,0,0,0,0,0,2,0)


	else
	--女邪
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出2个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,100202260,weizs[0],1,0,0,0,0,0,0,0,2,0)

	end
	end
	elseif Player.Player_Job==2 then 
--剑
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--男正
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出2个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,200201250,weizs[0],1,0,0,0,0,0,0,0,2,0)

	else
	--女正
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出2个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,200201250,weizs[0],1,0,0,0,0,0,0,0,2,0)
	
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--男邪
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出2个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,200202260,weizs[0],1,0,0,0,0,0,0,0,2,0)
	else
	--女邪
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出2个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,200202260,weizs[0],1,0,0,0,0,0,0,0,2,0)

	end
	end
	elseif Player.Player_Job==3 then 
--枪
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--男正.
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出2个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,300201250,weizs[0],1,0,0,0,0,0,0,0,2,0)

	else
	--女正
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出2个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,300201250,weizs[0],1,0,0,0,0,0,0,0,2,0)
	
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--男邪
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出2个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,300202260,weizs[0],1,0,0,0,0,0,0,0,2,0)
	
	else
	--女邪
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出2个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,300202260,weizs[0],1,0,0,0,0,0,0,0,2,0)
	
	
	end
	end
	elseif Player.Player_Job==4 then 
--弓
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--男正
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出2个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,400201250,weizs[0],1,0,0,0,0,0,0,0,2,0)
	
	else
	--女正
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出2个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,400201250,weizs[0],1,0,0,0,0,0,0,0,2,0)
	
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--男邪
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出2个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,400202260,weizs[0],1,0,0,0,0,0,0,0,2,0)

	else
	--女邪
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出2个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,400202260,weizs[0],1,0,0,0,0,0,0,0,2,0)

	end
	end
	elseif Player.Player_Job==5 then 
--医
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--男正
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出2个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,500201250,weizs[0],1,0,0,0,0,0,0,0,2,0)

	else
	--女正
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出2个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,500201250,weizs[0],1,0,0,0,0,0,0,0,2,0)

	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--男邪
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出2个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,500202260,weizs[0],1,0,0,0,0,0,0,0,2,0)
	else
	--女邪
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出2个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,500202260,weizs[0],1,0,0,0,0,0,0,0,2,0)

	end
	end
	elseif Player.Player_Job==6 then 
--CK
	if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--男正
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出2个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,700201250,weizs[0],1,0,0,0,0,0,0,0,2,0)
	
	else
	--女正
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出2个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,700201250,weizs[0],1,0,0,0,0,0,0,0,2,0)
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--男邪
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出2个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,700202260,weizs[0],1,0,0,0,0,0,0,0,2,0)

	else
	--女邪
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出2个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,700202260,weizs[0],1,0,0,0,0,0,0,0,2,0)

	end
	end
	elseif Player.Player_Job==7 then 
--琴师
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--男正
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出2个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,800201250,weizs[0],1,0,0,0,0,0,0,0,2,0)

	else
	--女正
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出2个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,800201250,weizs[0],1,0,0,0,0,0,0,0,2,0)
 
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--男邪
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出2个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,800202260,weizs[0],1,0,0,0,0,0,0,0,2,0)

 	
	else
	--女邪
	local weizs=GetPackages(UserWorldId,2)
if weizs.Count<2 then
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出2个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,800202260,weizs[0],1,0,0,0,0,0,0,0,2,0)

 
	end
	end
	--SendSysMsg(UserWorldId,"恭喜，获得12个月会员！", 9, "系统提示")
        --SendSysMsg(UserWorldId,"恭喜，获得10W攻击和防御！", 9, "系统提示")
	--SendNoticeMsg("◆◆◆VIP套装被打开",2)
	--SendNoticeMsg("◆◆◆获得VIP套装一套共14件!",2)
	--SendNoticeMsg("◆◆◆祝大家游戏快乐",2)
	--elseif Player.Player_Zx==0 then SendSysMsg(UserWorldId,"你没有升职不能打开", 9, "系统提示")
--return 
	end

end