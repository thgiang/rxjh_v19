------顶级防装VIP

function Open1008000512(UserWorldId, ItmeId, site, number)
	local Player = GetPlayer(UserWorldId)
	local Itme = GetWorldItme(ItmeId)
	if Player.Player_Zx==0 then 
	SendSysMsg(UserWorldId,"没有2转是不能打开新手礼包的!二转再来吧!", 9, "系统提示")
	return 
end
 	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出2个空位", 9, "系统提示")
	return 
end   
	UpUseItme(UserWorldId,site,1)
--[[	SetPlayerVIP(UserWorldId,0)
	SetPlayerShuxing(UserWorldId,0,0,0)
	Player.Player_WuXun=Player.Player_WuXun +0--]]
	if Player.Player_Job==1 then 
 --刀
	if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--男正
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出15个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)





 
	else
	--女正
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出15个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)




 
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--男邪
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出15个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)




 

	else
	--女邪
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出15个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)




 
	end
	end
	elseif Player.Player_Job==2 then 
--剑
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--男正
	local weizs=GetPackages(UserWorldId,16)
if weizs.Count<16 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出15个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)




 
	else
	--女正
	local weizs=GetPackages(UserWorldId,16)
if weizs.Count<16 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出15个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)





 	
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--男邪
	local weizs=GetPackages(UserWorldId,16)
if weizs.Count<16 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出15个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)






 
	else
	--女邪
	local weizs=GetPackages(UserWorldId,16)
if weizs.Count<16 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出15个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)




 	
	end
	end
	elseif Player.Player_Job==3 then 
--枪
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--男正.
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出10个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)
  
	else
	--女正
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出10个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)

 	
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--男邪
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出10个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)

 	
	else
	--女邪
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出10个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)

 	
	
	end
	end
	elseif Player.Player_Job==4 then 
--弓
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--男正
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出10个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)

 
 	
	else
	--女正
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出10个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)


 	
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--男邪
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出10个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)

 	
	else
	--女邪
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出10个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)

 	
	
	end
	end
	elseif Player.Player_Job==5 then 
--医
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--男正
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出10个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)

  
	else
	--女正
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出10个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)

 
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--男邪
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出10个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)


 	
	else
	--女邪
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出10个空位", 9, "系统提示")
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
	--男正
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出10个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)

 
 	
	else
	--女正
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出10个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)
 	
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--男邪
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出10个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)


 
	else
	--女邪
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出10个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)



	end
	end
	elseif Player.Player_Job==7 then 
--琴师
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--男正
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出10个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)

  
	else
	--女正
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出10个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)


 
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--男邪
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出10个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)

 	
	else
	--女邪
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出10个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)


end
	end
	elseif Player.Player_Job==8 then 
--韩飞
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--男正
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出10个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)

 
 
	else
	--女正
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出10个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)

 
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--男邪
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出10个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)

 	
	else
	--女邪
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出10个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)


end
	end
	elseif Player.Player_Job==9 then 
--谭花灵
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--男正
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出10个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)

 

 
	else
	--女正
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出10个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)



 
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--男邪
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出10个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)


 	
	else
	--女邪
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出10个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)


end
end
	elseif Player.Player_Job==10 then 
--格斗家
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--男正
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出10个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)
 


 
	else
	--女正
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出10个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)


 
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--男邪
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出10个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)


 	
	else
	--女邪
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出10个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)


	end
	end
	elseif Player.Player_Job==11 then 
--梅
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--男正
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出10个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)
 


 
	else
	--女正
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出10个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)


 
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--男邪
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出10个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)


 	
	else
	--女邪
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出10个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)


	end
	end
	elseif Player.Player_Job==12 then 
--卢
		if Player.Player_Zx==1 then 
	
	if Player.Player_Sex==1 then
	--男正
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出10个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)
 


 
	else
	--女正
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出10个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)


 
	end
	elseif Player.Player_Zx==2 then 
	if Player.Player_Sex==1 then
	--男邪
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出10个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)


 	
	else
	--女邪
	local weizs=GetPackages(UserWorldId,15)
if weizs.Count<15 then
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出10个空位", 9, "系统提示")
	return 
end
AddItmeProp(UserWorldId,1008000690,weizs[0],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[1],1,0,0,0,0,0,0,0,1,0)
AddItmeProp(UserWorldId,1008000690,weizs[2],1,0,0,0,0,0,0,0,1,0)


	end
	end
	SendSysMsg(UserWorldId,"恭喜，获得1个月会员！", 9, "系统提示")
        --SendSysMsg(UserWorldId,"恭喜，获得真-140PVP进化2一套白！", 9, "系统提示")
	--SendNoticeMsg("◆◆◆VIP套装被打开",2)
	--SendNoticeMsg("◆◆◆获得VIP套装一套共6件!",2)
	--SendNoticeMsg("◆◆◆祝大家游戏快乐",2)
	--elseif Player.Player_Zx==0 then SendSysMsg(UserWorldId,"你没有升职不能打开", 9, "系统提示")
--return 
	end

end