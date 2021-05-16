------VIP经济实惠装80套装

function Open1008000522(UserWorldId, ItmeId, site, number)
	local Player = GetPlayer(UserWorldId)
	local Itme = GetWorldItme(ItmeId)	
     	local weizs=GetPackages(UserWorldId,20)
if weizs.Count<10 then 
	SendSysMsg(UserWorldId,"装备栏没有空位了，请清理,留出6个空位", 9, "系统提示")
	return 
end        
	UpUseItme(UserWorldId,site,1)
--[[	SetPlayerVIP(UserWorldId,1)
	SetPlayerShuxing(UserWorldId,100000,100000,0)
	Player.Player_WuXun=Player.Player_WuXun +1200000--]]
	if Player.Player_Job==1 and Player.Player_Sex==1 then 
 --正刀男
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)


--正刀女 
 elseif Player.Player_Job==1 and Player.Player_Sex==2 then 

AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)


 --邪刀男
elseif Player.Player_Job==1 and Player.Player_Sex==1 then 

AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)
 
 --邪刀女
elseif Player.Player_Job==1 and Player.Player_Sex==2 then 
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)

 --正剑男
elseif Player.Player_Job==2 and Player.Player_Sex==1 then 
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)

 --正剑女
elseif Player.Player_Job==2 and Player.Player_Sex==2 then 
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)


--邪剑男 	
elseif Player.Player_Job==2 and Player.Player_Sex==1 then 
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)

elseif Player.Player_Job==2 and Player.Player_Sex==2 then 
--邪剑女
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)

--正枪男 	
elseif Player.Player_Job==3 and Player.Player_Sex==1 then 
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)


--正枪女 
elseif Player.Player_Job==3 and Player.Player_Sex==2 then 
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)


--邪枪男 	
elseif Player.Player_Job==3 and Player.Player_Sex==1 then 
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)

--邪枪女 	
elseif Player.Player_Job==3 and Player.Player_Sex==2 then 
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)

--正弓男 	
	
elseif Player.Player_Job==4 and Player.Player_Sex==1 then 
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)


--正弓女
elseif Player.Player_Job==4 and Player.Player_Sex==2 then 
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)


--邪弓男 	
elseif Player.Player_Job==4 and Player.Player_Sex==1 then 
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)

--邪弓女 	
elseif Player.Player_Job==4 and Player.Player_Sex==2 then 
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)

 --正医男		
elseif Player.Player_Job==5 and Player.Player_Sex==1 then 
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)


 --正医女
elseif Player.Player_Job==5 and Player.Player_Sex==2 then
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)


 --邪医男
elseif Player.Player_Job==5 and Player.Player_Sex==1 then
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)


 --邪医女	
elseif Player.Player_Job==5 and Player.Player_Sex==2 then
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)

--CK男		
elseif Player.Player_Job==6 and Player.Player_Sex==1 then 
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)


 --CK女
elseif Player.Player_Job==6 and Player.Player_Sex==2 then
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)


--琴师男		
elseif Player.Player_Job==7 and Player.Player_Sex==1 then 
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)


 --琴师女
elseif Player.Player_Job==7 and Player.Player_Sex==2 then
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)


--韩飞男		
elseif Player.Player_Job==8 and Player.Player_Sex==1 then 
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)


 --韩飞女
elseif Player.Player_Job==8 and Player.Player_Sex==2 then
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)


--谭花灵男		
elseif Player.Player_Job==9 and Player.Player_Sex==1 then 
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)


 --谭花灵女
elseif Player.Player_Job==9 and Player.Player_Sex==2 then
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)


--格斗家男		
elseif Player.Player_Job==10 and Player.Player_Sex==1 then 
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)


--格斗家女
elseif Player.Player_Job==10 and Player.Player_Sex==2 then
AddItmeProp(UserWorldId,1008000055,weizs[1],9999,0,0,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1000000901,weizs[2],9999,0,2000000008,0,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000044,weizs[3],9999,0,2019999999,1020000200,0,0,0,0,0,0)
AddItmeProp(UserWorldId,1008000045,weizs[4],9999,0,2019999999,1020000200,0,0,0,0,0,0)

	elseif Player.Player_Job==11 and Player.Player_Sex==1 then 
--柳
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
--卢
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
