-----------傲世12.0【回收脚本】----------
function ExchangeItem(UserWorldId,str1)

---【武勋抽奖】
if str1== "@123" then
local Player = GetPlayer(UserWorldId)
if Player.Player_wuxun < 1000000 then
SendSysMsg(UserWorldId,"金块需要10万WX,你的武勋不足,有劳再杀点来换", 10, "系统提示")
return 
end
Player.Player_wuxun=Player.Player_wuxun-100000000
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"装备栏没有空位了，请检查清理,留出2个空位", 9, "系统提示")
return 
end                                         
AddItmeProp(UserWorldId,1008000516,weizs[0],1,0,0,0,0,0,0,0,0,0)
SendSysMsg(UserWorldId,"系统回收10w武勋;获得金块一个", 10, "系统提示")
end

if str1== "@兑换金块" then
local Player = GetPlayer(UserWorldId)
if Player.Player_wuxun < 100000 then
SendSysMsg(UserWorldId,"需要武勋10万以上,你的武勋不足,有劳再杀点来换", 10, "系统提示")
return 
end
Player.Player_wuxun=Player.Player_wuxun-100000
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"装备栏没有空位了，请检查清理,留出2个空位", 9, "系统提示")
return 
end
AddItmeProp(UserWorldId,900000035,weizs[0],1,0,0,0,0,0,0,0,0,0)
SendSysMsg(UserWorldId,"系统回收1000000武勋;获得金块，恭喜恭喜！", 10, "系统提示")
end

if str1== "@兑换宝石" then
local Player = GetPlayer(UserWorldId)
if Player.Player_wuxun < 500000 then
SendSysMsg(UserWorldId,"抽奖需要武勋50万以上,你的武勋不足,有劳再杀点来换", 10, "系统提示")
return 
end
Player.Player_wuxun=Player.Player_wuxun-500000
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"装备栏没有空位了，请检查清理,留出2个空位", 9, "系统提示")
return 
end
AddItmeProp(UserWorldId,900000401,weizs[0],500,0,0,0,0,0,0,0,0,0)
SendSysMsg(UserWorldId,"系统回收5000000武勋;获得宝石500个恭喜恭喜！！", 10, "系统提示")
end

---【兑换宝盒幸运】
if str1== "@兑换龙鳞" then
local weiz1=GetPakItemNum(UserWorldId,1008000213,1)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"兑换失败;先确认个人背包有1个龙鳞", 10, "系统提示")
return
end
local yb=GetRxpiont(UserWorldId)
if yb < 0 then
SendSysMsg(UserWorldId,"提炼需要手续费0元宝,你的元宝不足", 10, "系统提示")
return 
end
local weizs=GetPackages(UserWorldId,1)
if weizs.Count< 1 then 
SendSysMsg(UserWorldId,"装备栏没有空位了，请检查清理,留出1个空位", 9, "系统提示")
return 
end
AddItmeProp(UserWorldId,1008000212,weizs[0],1,2000000001,0,0,0,0,0,0,0,0)
DelItme(UserWorldId,weiz1,1)
SendSysMsg(UserWorldId,"恭喜您!逆天一个", 10, "系统提示")
SendSysMsg(UserWorldId,"逆天", 20, "系统提示")
end

---【星辰首饰进化】
--进化星辰项链
if str1== "@进化绯蓝项链" then
local weiz1=GetPakItemNum(UserWorldId,100026,1)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"请检查星辰项链在人物背包", 10, "系统提示")
return 
end
local weiz2=GetPakItemNum(UserWorldId,900000619,150)
if weiz2==-1 then 
SendSysMsg(UserWorldId,"请检查150张玉佩在人物背包", 10, "系统提示")
return 
end
local yb=GetRxpiont(UserWorldId)
if yb < 2499 then
SendSysMsg(UserWorldId,"提炼需要手续费3000元宝,你的元宝不足", 10, "系统提示")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"装备栏没有空位了，请检查清理,留出2个空位", 9, "系统提示")
return 
end
SetPlayerRxpiont(UserWorldId,3000,0)
DelItme(UserWorldId,weiz1,1) 
DelItme(UserWorldId,weiz2,150)                                          
AddItmeProp(UserWorldId,100028,weizs[0],1,0,20000060,60000060,10000024,80000002,0,0,0,0)
SendSysMsg(UserWorldId,"恭喜您进化星辰项链成功，获得【绯蓝项链】收费150个玉佩+3000元宝+初级星辰一个", 10, "系统提示")
end

--进化星辰耳环
if str1== "@进化绯蓝耳环" then
local weiz1=GetPakItemNum(UserWorldId,18,1)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"请检查星辰耳环在人物背包", 10, "系统提示")
return 
end
local weiz2=GetPakItemNum(UserWorldId,900000619,150)
if weiz2==-1 then 
SendSysMsg(UserWorldId,"请检查150张玉佩在人物背包", 10, "系统提示")
return 
end
local yb=GetRxpiont(UserWorldId)
if yb < 2499 then
SendSysMsg(UserWorldId,"提炼需要手续费3000元宝,你的元宝不足", 10, "系统提示")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"装备栏没有空位了，请检查清理,留出2个空位", 9, "系统提示")
return 
end
SetPlayerRxpiont(UserWorldId,3000,0)
DelItme(UserWorldId,weiz1,1)
DelItme(UserWorldId,weiz2,150)
AddItmeProp(UserWorldId,23,weizs[0],1,0,80000005,70000020,30000400,100000025,0,0,0,0)
SendSysMsg(UserWorldId,"恭喜您进化星辰耳环成功，获得【绯蓝耳环】收费150个+2500元宝+初级星辰一个", 10, "系统提示")
end

--进化星辰戒指
if str1== "@进化绯蓝戒指-(魔)" then
local weiz1=GetPakItemNum(UserWorldId,700911,1)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"请检查星辰戒指在人物背包", 10, "系统提示")
return 
end
local weiz2=GetPakItemNum(UserWorldId,900000619,150)
if weiz2==-1 then 
SendSysMsg(UserWorldId,"请检查150张玉佩在人物背包", 10, "系统提示")
return 
end

local yb=GetRxpiont(UserWorldId)
if yb < 2499 then
SendSysMsg(UserWorldId,"提炼需要手续费3000元宝,你的元宝不足", 10, "系统提示")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"装备栏没有空位了，请检查清理,留出2个空位", 9, "系统提示")
return 
end
SetPlayerRxpiont(UserWorldId,3000,0)
DelItme(UserWorldId,weiz1,1)
DelItme(UserWorldId,weiz2,150)                       
AddItmeProp(UserWorldId,700028,weizs[0],1,0,70000030,10000055,100000025,110000055,0,0,0,0)
SendSysMsg(UserWorldId,"恭喜您进化星辰戒指成功，获得【绯蓝戒指-(魔)】收费150个玉佩+3000元宝+初级星辰一个", 10, "系统提示")
end

---【星辰首饰进化】
--进化星辰项链
if str1== "@进化星辰项链" then
local weiz1=GetPakItemNum(UserWorldId,100026,1)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"请检查星辰项链在人物背包", 10, "系统提示")
return 
end
local weiz2=GetPakItemNum(UserWorldId,900000619,150)
if weiz2==-1 then 
SendSysMsg(UserWorldId,"请检查150张玉佩在人物背包", 10, "系统提示")
return 
end
local yb=GetRxpiont(UserWorldId)
if yb < 2499 then
SendSysMsg(UserWorldId,"提炼需要手续费3000元宝,你的元宝不足", 10, "系统提示")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"装备栏没有空位了，请检查清理,留出2个空位", 9, "系统提示")
return 
end
SetPlayerRxpiont(UserWorldId,3000,0)
DelItme(UserWorldId,weiz1,1)
DelItme(UserWorldId,weiz2,150)
AddItmeProp(UserWorldId,100028,weizs[0],1,0,20000040,10000040,30000150,80000002,0,0,0,0)
SendSysMsg(UserWorldId,"恭喜您进化星辰项链成功，获得【绯蓝项链】收费150个玉佩+3000元宝+初级星辰一个", 10, "系统提示")
end

--进化星辰耳环
if str1== "@进化星辰耳环" then
local weiz1=GetPakItemNum(UserWorldId,18,1)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"请检查星辰耳环在人物背包", 10, "系统提示")
return 
end
local weiz2=GetPakItemNum(UserWorldId,900000619,150)
if weiz2==-1 then 
SendSysMsg(UserWorldId,"请检查150张玉佩在人物背包", 10, "系统提示")
return 
end
local yb=GetRxpiont(UserWorldId)
if yb < 2499 then
SendSysMsg(UserWorldId,"提炼需要手续费3000元宝,你的元宝不足", 10, "系统提示")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"装备栏没有空位了，请检查清理,留出2个空位", 9, "系统提示")
return 
end
SetPlayerRxpiont(UserWorldId,3000,0)
DelItme(UserWorldId,weiz1,1)
DelItme(UserWorldId,weiz2,150)
AddItmeProp(UserWorldId,23,weizs[0],1,0,80000006,70000020,30000400,10000150,0,0,0,0)
SendSysMsg(UserWorldId,"恭喜您进化星辰耳环成功，获得【绯蓝耳环-(魔)】收费150个玉佩+3000元宝+初级星辰一个", 10, "系统提示")
end

--进化星辰戒指
if str1== "@进化星辰戒指" then
local weiz1=GetPakItemNum(UserWorldId,700911,1)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"请检查星辰戒指在人物背包", 10, "系统提示")
return 
end
local weiz2=GetPakItemNum(UserWorldId,900000619,150)
if weiz2==-1 then 
SendSysMsg(UserWorldId,"请检查150张玉佩在人物背包", 10, "系统提示")
return 
end

local yb=GetRxpiont(UserWorldId)
if yb < 2499 then
SendSysMsg(UserWorldId,"提炼需要手续费3000元宝,你的元宝不足", 10, "系统提示")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"装备栏没有空位了，请检查清理,留出2个空位", 9, "系统提示")
return 
end
SetPlayerRxpiont(UserWorldId,3000,0)
DelItme(UserWorldId,weiz1,1)
DelItme(UserWorldId,weiz2,150)
AddItmeProp(UserWorldId,700028,weizs[0],1,0,70000030,10000070,30000300,110000050,0,0,0,0)
SendSysMsg(UserWorldId,"恭喜您进化星辰戒指成功，获得【绯蓝戒指-(魔)】收费150个玉佩+3000元宝+初级星辰一个", 10, "系统提示")
end

--提炼傲天首饰
if str1== "@提炼傲天戒指" then
local weiz1=GetPakItemNum(UserWorldId,700021,1)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"请检查狱魔戒指是否在人物背包", 10, "系统提示")
return 
end
local weiz2=GetPakItemNum(UserWorldId,900000619,50)
if weiz2==-1 then 
SendSysMsg(UserWorldId,"请检查50枚玉佩是否在人物背包", 10, "系统提示")
return 
end

local yb=GetRxpiont(UserWorldId)
if yb < 0 then
SendSysMsg(UserWorldId,"提炼需要手续费0元宝,你的元宝不足", 10, "系统提示")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"装备栏没有空位了，请检查清理,留出2个空位", 9, "系统提示")
return 
end
SetPlayerRxpiont(UserWorldId,0,0)
DelItme(UserWorldId,weiz1,1)
DelItme(UserWorldId,weiz2,50)
AddItmeProp(UserWorldId,700022,weizs[0],1,0,70000013,10000030,30000100,0,0,0,0,0)
SendSysMsg(UserWorldId,"恭喜您提炼傲天戒指成功，消耗50张玉佩+狱魔戒指!!!", 10, "系统提示")
end

if str1== "@提炼傲天耳环" then
local weiz1=GetPakItemNum(UserWorldId,15,1)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"请检查狱魔耳环是否在人物背包", 10, "系统提示")
return 
end
local weiz2=GetPakItemNum(UserWorldId,900000619,50)
if weiz2==-1 then 
SendSysMsg(UserWorldId,"请检查50张玉佩是否在人物背包", 10, "系统提示")
return 
end

local yb=GetRxpiont(UserWorldId)
if yb < 0 then
SendSysMsg(UserWorldId,"提炼需要手续费0元宝,你的元宝不足", 10, "系统提示")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"装备栏没有空位了，请检查清理,留出2个空位", 9, "系统提示")
return 
end
SetPlayerRxpiont(UserWorldId,0,0)
DelItme(UserWorldId,weiz1,1)
DelItme(UserWorldId,weiz2,50)
AddItmeProp(UserWorldId,16,weizs[0],1,0,80000003,70000010,30000150,0,0,0,0,0)
SendSysMsg(UserWorldId,"恭喜您提炼傲天耳环成功，消耗50张玉佩+狱魔耳环", 10, "系统提示")
end

if str1== "@提炼傲天项链" then
local weiz1=GetPakItemNum(UserWorldId,100020,1)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"请检查狱魔项链在人物背包", 10, "系统提示")
return 
end
local weiz2=GetPakItemNum(UserWorldId,900000619,50)
if weiz2==-1 then 
SendSysMsg(UserWorldId,"请检查50张玉佩是否在人物背包", 10, "系统提示")
return 
end

local yb=GetRxpiont(UserWorldId)
if yb < 0 then
SendSysMsg(UserWorldId,"提炼需要手续费0元宝,你的元宝不足", 10, "系统提示")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"装备栏没有空位了，请检查清理,留出2个空位", 9, "系统提示")
return 
end
SetPlayerRxpiont(UserWorldId,0,0)
DelItme(UserWorldId,weiz1,1)
DelItme(UserWorldId,weiz2,50)
AddItmeProp(UserWorldId,100021,weizs[0],1,0,10000030,20000040,30000150,0,0,0,0,0)
SendSysMsg(UserWorldId,"恭喜您提炼傲天戒指成功，消耗50张玉佩+狱魔项链", 10, "系统提示")
end

--提炼星辰首饰
if str1== "@提炼星辰戒指" then
local weiz1=GetPakItemNum(UserWorldId,700022,1)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"请检查傲天戒指在人物背包", 10, "系统提示")
return 
end
local weiz2=GetPakItemNum(UserWorldId,900000619,100)
if weiz2==-1 then 
SendSysMsg(UserWorldId,"请检查100枚金块是否在人物背包", 10, "系统提示")
return 
end

local yb=GetRxpiont(UserWorldId)
if yb < 0 then
SendSysMsg(UserWorldId,"提炼需要手续费1000元宝,你的元宝不足", 10, "系统提示")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"装备栏没有空位了，请检查清理,留出2个空位", 9, "系统提示")
return 
end
SetPlayerRxpiont(UserWorldId,1000,0)
DelItme(UserWorldId,weiz1,1)
DelItme(UserWorldId,weiz2,100)
AddItmeProp(UserWorldId,700911,weizs[0],1,0,70000020,10000040,30000150,0,0,0,0,0)
SendSysMsg(UserWorldId,"恭喜您提炼星辰戒指成功，消耗100张玉佩+1000元宝+傲天戒指", 10, "系统提示")
end

if str1== "@提炼星辰耳环" then
local weiz1=GetPakItemNum(UserWorldId,16,1)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"请检查星辰戒指在人物背包", 10, "系统提示")
return 
end
local weiz2=GetPakItemNum(UserWorldId,900000619,100)
if weiz2==-1 then 
SendSysMsg(UserWorldId,"请检查100张玉佩是否在人物背包", 10, "系统提示")
return 
end

local yb=GetRxpiont(UserWorldId)
if yb < 0 then
SendSysMsg(UserWorldId,"提炼需要手续费1000元宝,你的元宝不足", 10, "系统提示")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"装备栏没有空位了，请检查清理,留出2个空位", 9, "系统提示")
return 
end
SetPlayerRxpiont(UserWorldId,1000,0)
DelItme(UserWorldId,weiz1,1)
DelItme(UserWorldId,weiz2,100)
AddItmeProp(UserWorldId,18,weizs[0],1,0,80000005,70000013,30000200,0,0,0,0,0)
SendSysMsg(UserWorldId,"恭喜您提炼星辰耳环成功，消耗100张玉佩+1000元宝+傲天耳环", 10, "系统提示")
end

if str1== "@提炼星辰项链" then
local weiz1=GetPakItemNum(UserWorldId,100021,1)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"请检查傲天项链在人物背包", 10, "系统提示")
return 
end
local weiz2=GetPakItemNum(UserWorldId,900000619,100)
if weiz2==-1 then 
SendSysMsg(UserWorldId,"请检查100张玉佩是否在人物背包", 10, "系统提示")
return 
end

local yb=GetRxpiont(UserWorldId)
if yb < 0 then
SendSysMsg(UserWorldId,"提炼需要手续费1000元宝,你的元宝不足", 10, "系统提示")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"装备栏没有空位了，请检查清理,留出2个空位", 9, "系统提示")
return 
end
SetPlayerRxpiont(UserWorldId,1000,0)
DelItme(UserWorldId,weiz1,1)
DelItme(UserWorldId,weiz2,100)
AddItmeProp(UserWorldId,100026,weizs[0],1,0,10000040,20000040,30000200,40000200,0,0,0,0)
SendSysMsg(UserWorldId,"恭喜您提炼星辰戒指成功，消耗100张玉佩+傲天项链", 10, "系统提示")
end

--提炼狱魔首饰
if str1== "@提炼狱魔戒指" then
local weiz1=GetPakItemNum(UserWorldId,700020,1)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"请检查血红戒指是否在人物背包", 10, "系统提示")
return 
end
local weiz2=GetPakItemNum(UserWorldId,900000619,30)
if weiz2==-1 then 
SendSysMsg(UserWorldId,"请检查30张玉佩是否在人物背包", 10, "系统提示")
return 
end

local yb=GetRxpiont(UserWorldId)
if yb < 0 then
SendSysMsg(UserWorldId,"提炼需要手续费0元宝,你的元宝不足", 10, "系统提示")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"装备栏没有空位了，请检查清理,留出2个空位", 9, "系统提示")
return 
end
SetPlayerRxpiont(UserWorldId,0,0)
DelItme(UserWorldId,weiz1,1)
DelItme(UserWorldId,weiz2,30)
AddItmeProp(UserWorldId,700021,weizs[0],1,0,70000011,10000035,0,0,0,0,0,0)
SendSysMsg(UserWorldId,"恭喜您提炼狱魔戒指成功，消耗30张玉佩+血红戒指", 10, "系统提示")
end

if str1== "@提炼狱魔耳环" then
local weiz1=GetPakItemNum(UserWorldId,14,1)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"请检查血红耳环是否在人物背包", 10, "系统提示")
return 
end
local weiz2=GetPakItemNum(UserWorldId,900000619,30)
if weiz2==-1 then 
SendSysMsg(UserWorldId,"请检查30张玉佩是否在人物背包", 10, "系统提示")
return 
end

local yb=GetRxpiont(UserWorldId)
if yb < 0 then
SendSysMsg(UserWorldId,"提炼需要手续费0元宝,你的元宝不足", 10, "系统提示")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"装备栏没有空位了，请检查清理,留出2个空位", 9, "系统提示")
return 
end
SetPlayerRxpiont(UserWorldId,0,0)
DelItme(UserWorldId,weiz1,1)
DelItme(UserWorldId,weiz2,30)
AddItmeProp(UserWorldId,15,weizs[0],1,0,80000003,70000008,30000120,0,0,0,0,0)
SendSysMsg(UserWorldId,"恭喜您提炼狱魔耳环成功，消耗30张玉佩+血红耳环", 10, "系统提示")
end

if str1== "@提炼狱魔项链" then
local weiz1=GetPakItemNum(UserWorldId,100018,1)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"请检查血红项链是否在人物背包", 10, "系统提示")
return 
end
local weiz2=GetPakItemNum(UserWorldId,900000619,30)
if weiz2==-1 then 
SendSysMsg(UserWorldId,"请检查30张玉佩是否在人物背包", 10, "系统提示")
return 
end

local yb=GetRxpiont(UserWorldId)
if yb < 0 then
SendSysMsg(UserWorldId,"提炼需要手续费0元宝,你的元宝不足", 10, "系统提示")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"装备栏没有空位了，请检查清理,留出2个空位", 9, "系统提示")
return 
end
SetPlayerRxpiont(UserWorldId,0,0)
DelItme(UserWorldId,weiz1,1)
DelItme(UserWorldId,weiz2,30)
AddItmeProp(UserWorldId,100020,weizs[0],1,0,20000035,60000035,0,0,0,0,0,0)
SendSysMsg(UserWorldId,"恭喜您提炼狱魔项链成功，消耗30张玉佩+血红项链", 10, "系统提示")
end


------------------------【宠物功能】------------------------------
if str1== "@分解雪狼" then
local weiz1=GetPakItemNum(UserWorldId,1000001011,1)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"请检查灵兽雪狼蛋是否在人物背包", 10, "系统提示")
return 
end
local weiz2=GetPakItemNum(UserWorldId,1008000167,1)
if weiz2==-1 then 
SendSysMsg(UserWorldId,"请检查分解丸是否在人物背包", 10, "系统提示")
return 
end

local yb=GetRxpiont(UserWorldId)
if yb < 0 then
SendSysMsg(UserWorldId,"召唤需要手续费0元宝,你的元宝不足", 10, "系统提示")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"装备栏没有空位了，请检查清理,留出2个空位", 9, "系统提示")
return 
end
SetPlayerRxpiont(UserWorldId,0,0)
DelItme(UserWorldId,weiz1,1)
DelItme(UserWorldId,weiz2,1)
AddItmeProp(UserWorldId,1008001108,weizs[0],1,0,0,0,0,0,0,0,0,0)
SendSysMsg(UserWorldId,"恭喜您分解雪狼成功，消耗雪狼*1 分解丸*1，获得灵兽雪狼蛋*1", 10, "系统提示")
end

if str1== "@分解金狼" then
local weiz1=GetPakItemNum(UserWorldId,1000001378,1)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"请检查灵兽金狼蛋是否在人物背包", 10, "系统提示")
return 
end
local weiz2=GetPakItemNum(UserWorldId,1008000167,1)
if weiz2==-1 then 
SendSysMsg(UserWorldId,"请检查分解丸是否在人物背包", 10, "系统提示")
return 
end

local yb=GetRxpiont(UserWorldId)
if yb < 0 then
SendSysMsg(UserWorldId,"召唤需要手续费0元宝,你的元宝不足", 10, "系统提示")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"装备栏没有空位了，请检查清理,留出2个空位", 9, "系统提示")
return 
end
SetPlayerRxpiont(UserWorldId,0,0)
DelItme(UserWorldId,weiz1,1)
DelItme(UserWorldId,weiz2,1)
AddItmeProp(UserWorldId,1008001375,weizs[0],1,0,0,0,0,0,0,0,0,0)
SendSysMsg(UserWorldId,"恭喜您分解金狼成功，消耗金狼*1 分解丸*1，获得灵兽金狼蛋*1", 10, "系统提示")
end

if str1== "@召唤金狼" then
local weiz1=GetPakItemNum(UserWorldId,1008001108,10)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"请检查灵兽雪狼蛋是否在人物背包", 10, "系统提示")
return 
end
local weiz2=GetPakItemNum(UserWorldId,1008000166,1)
if weiz2==-1 then 
SendSysMsg(UserWorldId,"请检查神兽丹是否在人物背包", 10, "系统提示")
return 
end

local yb=GetRxpiont(UserWorldId)
if yb < 0 then
SendSysMsg(UserWorldId,"召唤需要手续费0元宝,你的元宝不足", 10, "系统提示")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"装备栏没有空位了，请检查清理,留出2个空位", 9, "系统提示")
return 
end
SetPlayerRxpiont(UserWorldId,0,0)
DelItme(UserWorldId,weiz1,10)
DelItme(UserWorldId,weiz2,1)
AddItmeProp(UserWorldId,1000001378,weizs[0],1,0,80000003,20000100,110000100,0,0,0,0,0)
SendSysMsg(UserWorldId,"恭喜您召唤金狼成功，消耗灵兽雪狼蛋*10 神兽丹*1", 10, "系统提示")
end

if str1== "@召唤松狮犬" then
local weiz1=GetPakItemNum(UserWorldId,1008001375,3)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"请检查灵兽金狼蛋是否在人物背包", 10, "系统提示")
return 
end
local weiz2=GetPakItemNum(UserWorldId,1008000166,3)
if weiz2==-1 then 
SendSysMsg(UserWorldId,"请检查神兽丹是否在人物背包", 10, "系统提示")
return 
end

local yb=GetRxpiont(UserWorldId)
if yb < 0 then
SendSysMsg(UserWorldId,"召唤需要手续费15000元宝,你的元宝不足", 10, "系统提示")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"装备栏没有空位了，请检查清理,留出2个空位", 9, "系统提示")
return 
end
SetPlayerRxpiont(UserWorldId,15000,0)
DelItme(UserWorldId,weiz1,3)
DelItme(UserWorldId,weiz2,3)
AddItmeProp(UserWorldId,1000001380,weizs[0],1,0,80000004,10000100,20000100,110000100,0,0,0,0)
SendSysMsg(UserWorldId,"恭喜您召唤松狮犬成功，消耗灵兽金狼蛋*3 神兽丹*3", 10, "系统提示")
end

-----【其他功能】----------------------------------------------------------------------------

--提炼100万武勋
if str1== "@回收11100万武勋" then
local Player = GetPlayer(UserWorldId)
if Player.Player_wuxun < 1000000 then
SendSysMsg(UserWorldId,"提炼需要武勋100万以上,你的武勋不足", 10, "系统提示")
return 
end
Player.Player_wuxun=Player.Player_wuxun-1000000
SetPlayerRxpiont(UserWorldId,500,1)
SendSysMsg(UserWorldId,"恭喜您!获得500元宝 打开百宝阁查询", 10, "系统提示")
SendSysMsg(UserWorldId,"100万武勋已被系统回收;请小退后确认!", 10, "系统提示")
end

--回收测试
if str1== "@回收aaA" then
local weiz1=GetPakItmesx(UserWorldId,700022,0,70000013,10000040,40000005,0,0,0,0,0)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"不符合回收要求,请检查武器属性 ", 9, "系统提示")
return
end
local yb=GetRxpiont(UserWorldId)
if yb < 0 then
SendSysMsg(UserWorldId,"提炼需要手续费0元宝,你的元宝不足", 10, "系统提示")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"装备栏没有空位了，请检查清理,留出2个空位", 9, "系统提示")
return 
end
SetPlayerRxpiont(UserWorldId,0,0)
DelItme(UserWorldId,weiz1,1)
SetPlayerRxpiont(UserWorldId,100,1)
SendSysMsg(UserWorldId,"恭喜得到100元宝;满属性X10杖回收成功@_@...", 10, "系统提示")
end

if str1== "@回收aaB" then
local weiz1=GetPakItmesx(UserWorldId,700022,0,70000013,10000040,40000005,0,0,0,0,0)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"不符合回收要求,请检查武器属性 ", 9, "系统提示")
return
end
local weiz2=GetPakItmesx(UserWorldId,16,0,80000003,70000010,30000150,0,0,0,0,0)
if weiz2==-1 then 
SendSysMsg(UserWorldId,"不符合回收要求,请检查武器属性 ", 9, "系统提示")
return
end
local weiz3=GetPakItmesx(UserWorldId,14,0,80000003,70000005,30000080,0,0,0,0,0)
if weiz3==-1 then 
SendSysMsg(UserWorldId,"不符合回收要求,请检查武器属性 ", 9, "系统提示")
return
end
local yb=GetRxpiont(UserWorldId)
if yb < 0 then
SendSysMsg(UserWorldId,"提炼需要手续费0元宝,你的元宝不足", 10, "系统提示")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"装备栏没有空位了，请检查清理,留出2个空位", 9, "系统提示")
return 
end
SetPlayerRxpiont(UserWorldId,0,0)
DelItme(UserWorldId,weiz1,1)
DelItme(UserWorldId,weiz2,1)
DelItme(UserWorldId,weiz3,1)
SetPlayerRxpiont(UserWorldId,100,1)
SendSysMsg(UserWorldId,"恭喜得到100元宝;满属性X10杖回收成功@_@...", 10, "系统提示")
end

if str1== "@回收aaC" then
local weiz1=GetPakItemNum(UserWorldId,700022,1)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"请检查真金龙甲在人物背包", 10, "系统提示")
return 
end
SetPlayerRxpiont(UserWorldId,0,0)
DelItme(UserWorldId,weiz1,1)
SetPlayerRxpiont(UserWorldId,300,1)
SendSysMsg(UserWorldId,"回收真金龙甲成功，恭喜您获得300元宝!!", 10, "系统提示")
end

if str1== "@回收aaD" then
--同属性装备只能回收一件；检查数量的需要叠加；可以检查装备属性[多件]
local weiz1=GetPakItmesx(UserWorldId,100018,20000010,20000025,60000025,30000040,40000041,0,0,0,0)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"不符合回收要求,请检查武器属性 ", 9, "系统提示")
return
end
local weiz2=GetPakItmesx(UserWorldId,14,30000010,80000003,70000005,30000080,40000082,0,0,0,0)
if weiz2==-1 then 
SendSysMsg(UserWorldId,"不符合回收要求,请检查武器属性 ", 9, "系统提示")
return
end
local weiz3=GetPakItmesx(UserWorldId,14,30000010,80000003,70000005,30000080,40000083,0,0,0,0)
if weiz3==-1 then 
SendSysMsg(UserWorldId,"不符合回收要求,请检查武器属性 ", 9, "系统提示")
return
end
local weiz4=GetPakItmesx(UserWorldId,700020,10000010,70000015,10000030,60000050,50000054,0,0,0,0)
if weiz4==-1 then 
SendSysMsg(UserWorldId,"不符合回收要求,请检查武器属性 ", 9, "系统提示")
return
end
local weiz5=GetPakItmesx(UserWorldId,700020,10000010,70000015,10000030,60000050,50000055,0,0,0,0)
if weiz5==-1 then 
SendSysMsg(UserWorldId,"不符合回收要求,请检查武器属性 ", 9, "系统提示")
return
end
local yb=GetRxpiont(UserWorldId)
if yb < 0 then
SendSysMsg(UserWorldId,"提炼需要手续费0元宝,你的元宝不足", 10, "系统提示")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"装备栏没有空位了，请检查清理,留出2个空位", 9, "系统提示")
return 
end
SetPlayerRxpiont(UserWorldId,0,0)
DelItme(UserWorldId,weiz1,1)
DelItme(UserWorldId,weiz2,1)
DelItme(UserWorldId,weiz3,1)
DelItme(UserWorldId,weiz4,1)
DelItme(UserWorldId,weiz5,1)
SetPlayerRxpiont(UserWorldId,100,1)
SendSysMsg(UserWorldId,"恭喜得到100元宝;满属性X10杖回收成功@_@...", 10, "系统提示")
end
end