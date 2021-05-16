--OpenItmeTrigGer为打开物品的触发器，本函数名不可以更改
--ItmeId  物品ID
--site	  物品在包裹中的位置
--number  物品数量
function OpenItmeTrigGer(UserWorldId, ItmeId, site, number)
	SendMissionMsg(UserWorldId,ItmeId, 11, site)
	if ItmeId==1000000388 then
	 	addKONGFU(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000389 then
	 	addKONGFU(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000390 then
	 	addKONGFU(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000391 then
	 	addKONGFU(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000392 then
	 	addKONGFU(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000393 then
	 	addKONGFU(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000394 then
	 	addKONGFU(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000395 then
	 	addKONGFU(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000396 then
	 	addKONGFU(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000397 then
	 	addKONGFU(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000398 then
	 	addKONGFU(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000399 then
	 	addKONGFU(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000001049 then
	 	addKONGFU(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1008001316 then
	 	addKONGFU(UserWorldId, ItmeId, site, number)
--会员一个月红包
	elseif ItmeId==1000000050 then
	 	SetPlayerVIPP(UserWorldId, ItmeId, site, number)

--冲级礼包
	elseif ItmeId==1008000513 then
	 	Open1008000513(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1008000514 then
	 	Open1008000514(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1008000515 then
	 	Open1008000515(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1008000516 then
	 	Open1008000516(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1008000512 then
	 	Open1008000512(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1008000520 then
	 	Open1008000520(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1008000521 then
	 	Open1008000521(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1008000522 then
	 	Open1008000522(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1008000507 then
	 	Open1008000507(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1008000529 then
	 	Open1008000529(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1008000530 then
	 	Open1008000530(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1008000532 then
	 	Open1008000532(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1008000507 then
	 	Open1008000507(UserWorldId, ItmeId, site, number)
	elseif ItmeId==999000059 then
	 	Open999000059(UserWorldId, ItmeId, site, number)
	elseif ItmeId==999000060 then
	 	Open999000060(UserWorldId, ItmeId, site, number)
	elseif ItmeId==999000061 then
	 	Open999000061(UserWorldId, ItmeId, site, number)
	elseif ItmeId==999000058 then
	 	Open999000058(UserWorldId, ItmeId, site, number)
	elseif ItmeId==999000062 then
	 	Open999000062(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1008000517 then
	 	Open1008000517(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1008000510 then
	 	Open1008000510(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1008000511 then
	 	Open1008000511(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1008000518 then
	 	Open1008000518(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1008000519 then
	 	Open1008000519(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1008000523 then
	 	Open1008000523(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1008000528 then
	 	Open1008000528(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1008000525 then
	 	Open1008000525(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1008000526 then
	 	Open1008000526(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1008000527 then
	 	Open1008000527(UserWorldId, ItmeId, site, number)
--新加的琴师
	elseif ItmeId==1000000495 then
	 	addQSKONGFU(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000498 then
	 	addQSKONGFU(UserWorldId, ItmeId, site, number)

	elseif ItmeId==1000000494 then
	 	addQ1KONGFU(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000497 then
	 	addQ1KONGFU(UserWorldId, ItmeId, site, number)

	elseif ItmeId==1000000496 then
	 	addQ3KONGFU(UserWorldId, ItmeId, site, number)
	elseif ItmeId==1000000499 then
	 	addQ3KONGFU(UserWorldId, ItmeId, site, number)
--谭花灵升天三武功
	elseif ItmeId==1000001013 then
	 	tanhuasan(UserWorldId, ItmeId, site, number)
--谭花灵升天四武功
	elseif ItmeId==1000001047 then
	 	tanhuasi(UserWorldId, ItmeId, site, number)
--谭花灵升天五武功
	elseif ItmeId==1000001206 then
	 	tanhuawu(UserWorldId, ItmeId, site, number)

--韩飞官升天四武功
	elseif ItmeId==1000001046 then
	 	hfgsi(UserWorldId, ItmeId, site, number)



--刀升天四武功
	elseif ItmeId==1000001032 then
	 	zhengsi(UserWorldId, ItmeId, site, number)
--剑正升天四武功
	elseif ItmeId==1000001033 then
	 	zhengsi(UserWorldId, ItmeId, site, number)
--枪正升天四武功
	elseif ItmeId==1000001034 then
	 	zhengsi(UserWorldId, ItmeId, site, number)
--弓正升天四武功
	elseif ItmeId==1000001035 then
	 	zhengsi(UserWorldId, ItmeId, site, number)
--医正升天四武功
	elseif ItmeId==1000001036 then
	 	zhengsi(UserWorldId, ItmeId, site, number)
--刺正升天四武功
	elseif ItmeId==1000001037 then
	 	zhengsi(UserWorldId, ItmeId, site, number)
--乐正升天四武功
	elseif ItmeId==1000001038 then
	 	zhengsi(UserWorldId, ItmeId, site, number)

--刀邪升天四武功
	elseif ItmeId==1000001039 then
	 	zhengsi(UserWorldId, ItmeId, site, number)
--剑邪升天四武功
	elseif ItmeId==1000001040 then
	 	zhengsi(UserWorldId, ItmeId, site, number)
--枪邪升天四武功
	elseif ItmeId==1000001041 then
	 	zhengsi(UserWorldId, ItmeId, site, number)
--弓邪升天四武功
	elseif ItmeId==1000001042 then
	 	zhengsi(UserWorldId, ItmeId, site, number)
--医邪升天四武功
	elseif ItmeId==1000001043 then
	 	zhengsi(UserWorldId, ItmeId, site, number)
--刺邪升天四武功
	elseif ItmeId==1000001044 then
	 	zhengsi(UserWorldId, ItmeId, site, number)
--乐邪升天四武功
	elseif ItmeId==1000001045 then
	 	zhengsi(UserWorldId, ItmeId, site, number)
--刀正升天五武功
	elseif ItmeId==1000001191 then
	 	zhengwu(UserWorldId, ItmeId, site, number)
--刀邪升天五武功
	elseif ItmeId==1000001192 then
	 	zhengwu(UserWorldId, ItmeId, site, number)

--剑正升天五武功
	elseif ItmeId==1000001193 then
	 	zhengwu(UserWorldId, ItmeId, site, number)
--剑邪升天五武功
	elseif ItmeId==1000001194 then
	 	zhengwu(UserWorldId, ItmeId, site, number)

--枪正升天五武功
	elseif ItmeId==1000001195 then
	 	zhengwu(UserWorldId, ItmeId, site, number)
--枪邪升天五武功
	elseif ItmeId==1000001196 then
	 	zhengwu(UserWorldId, ItmeId, site, number)

--弓正升天五武功
	elseif ItmeId==1000001197 then
	 	zhengwu(UserWorldId, ItmeId, site, number)
--弓邪升天五武功
	elseif ItmeId==1000001198 then
	 	zhengwu(UserWorldId, ItmeId, site, number)

--医生正升天五武功
	elseif ItmeId==1000001199 then
	 	zhengwu(UserWorldId, ItmeId, site, number)
--医生邪升天五武功
	elseif ItmeId==1000001200 then
	 	zhengwu(UserWorldId, ItmeId, site, number)


--格斗家正升天五武功
	elseif ItmeId==1000001207 then
	 	zhengwu(UserWorldId, ItmeId, site, number)
--格斗家升天五武功
	elseif ItmeId==1000001208 then
	 	zhengwu(UserWorldId, ItmeId, site, number)


--刺客正升天五武功
	elseif ItmeId==1000001201 then
	 	zhengwu(UserWorldId, ItmeId, site, number)
--刺客邪升天五武功
	elseif ItmeId==1000001202 then
	 	zhengwu(UserWorldId, ItmeId, site, number)


--乐师正升天五武功
	elseif ItmeId==1000001203 then
	 	zhengwu(UserWorldId, ItmeId, site, number)
--乐师邪升天五武功
	elseif ItmeId==1000001204 then
	 	zhengwu(UserWorldId, ItmeId, site, number)

--韩飞官升天五武功
	elseif ItmeId==1000001205 then
	 	 hfgwu(UserWorldId, ItmeId, site, number)
--韩飞官升天五武功1
	elseif ItmeId==1000001223 then
	 	 hfgwu1(UserWorldId, ItmeId, site, number)


	end
end

function hfgsi(UserWorldId, ItmeId, site, number)
	local Player = GetPlayer(UserWorldId)
	local Itme = GetWorldItme(ItmeId)
	if Itme.FLD_LEVEL > Player.Player_Level then
		return
        end
	if Itme.FLD_ZX ~= 0 then
		if Itme.FLD_ZX ~= Player.Player_Zx then
			return
        	end
        end
	if Itme.FLD_RESIDE1 ~= 0 then
		if Itme.FLD_RESIDE1 ~= Player.Player_Job then
			return
        	end
        end
	if Itme.FLD_JOB_LEVEL ~= 0 then
		if Itme.FLD_JOB_LEVEL > Player.Player_Job_leve then
			return
        	end
        end
	if Player.Player_Money < 500000000 then
		return
        end
	if Player.Player_ExpErience < 5000000 then
		return
        end
	AddStKongfu(UserWorldId,3,13)
	UpUseItme(UserWorldId,site,1)

	SendKongfuMsg(UserWorldId)

	Player.Player_ExpErience =Player.Player_ExpErience-5000000
	Player.Player_Money=Player.Player_Money-500000000

	UpGongFu(UserWorldId)
	UpExp(UserWorldId)
	UpMoney(UserWorldId)
end

function hfgwu(UserWorldId, ItmeId, site, number)
	local Player = GetPlayer(UserWorldId)
	local Itme = GetWorldItme(ItmeId)
	if Itme.FLD_LEVEL > Player.Player_Level then
		return
        end
	if Itme.FLD_ZX ~= 0 then
		if Itme.FLD_ZX ~= Player.Player_Zx then
			return
        	end
        end
	if Itme.FLD_RESIDE1 ~= 0 then
		if Itme.FLD_RESIDE1 ~= Player.Player_Job then
			return
        	end
        end
	if Itme.FLD_JOB_LEVEL ~= 0 then
		if Itme.FLD_JOB_LEVEL > Player.Player_Job_leve then
			return
        	end
        end
	if Player.Player_Money < 500000000 then
		return
        end
	if Player.Player_ExpErience < 5000000 then
		return
        end
	AddStKongfu(UserWorldId,3,17)
	UpUseItme(UserWorldId,site,1)

	SendKongfuMsg(UserWorldId)

	Player.Player_ExpErience =Player.Player_ExpErience-5000000
	Player.Player_Money=Player.Player_Money-500000000

	UpGongFu(UserWorldId)
	UpExp(UserWorldId)
	UpMoney(UserWorldId)
end

function hfgwu1(UserWorldId, ItmeId, site, number)
	local Player = GetPlayer(UserWorldId)
	local Itme = GetWorldItme(ItmeId)
	if Itme.FLD_LEVEL > Player.Player_Level then
		return
        end
	if Itme.FLD_ZX ~= 0 then
		if Itme.FLD_ZX ~= Player.Player_Zx then
			return
        	end
        end
	if Itme.FLD_RESIDE1 ~= 0 then
		if Itme.FLD_RESIDE1 ~= Player.Player_Job then
			return
        	end
        end
	if Itme.FLD_JOB_LEVEL ~= 0 then
		if Itme.FLD_JOB_LEVEL > Player.Player_Job_leve then
			return
        	end
        end
	if Player.Player_Money < 500000000 then
		return
        end
	if Player.Player_ExpErience < 5000000 then
		return
        end
	AddStKongfu(UserWorldId,3,19)
	AddStKongfu(UserWorldId,3,20)
	UpUseItme(UserWorldId,site,1)

	SendKongfuMsg(UserWorldId)

	Player.Player_ExpErience =Player.Player_ExpErience-5000000
	Player.Player_Money=Player.Player_Money-500000000

	UpGongFu(UserWorldId)
	UpExp(UserWorldId)
	UpMoney(UserWorldId)
end

function zhengsi(UserWorldId, ItmeId, site, number)
	local Player = GetPlayer(UserWorldId)
	local Itme = GetWorldItme(ItmeId)
	if Itme.FLD_LEVEL > Player.Player_Level then
		return
        end
	if Itme.FLD_ZX ~= 0 then
		if Itme.FLD_ZX ~= Player.Player_Zx then
			return
        	end
        end
	if Itme.FLD_RESIDE1 ~= 0 then
		if Itme.FLD_RESIDE1 ~= Player.Player_Job then
			return
        	end
        end
	if Itme.FLD_JOB_LEVEL ~= 0 then
		if Itme.FLD_JOB_LEVEL > Player.Player_Job_leve then
			return
        	end
        end
	if Player.Player_Money < 500000000 then
		return
        end
	if Player.Player_ExpErience < 5000000 then
		return
        end
	AddStKongfu(UserWorldId,3,10)
	AddStKongfu(UserWorldId,3,11)
	UpUseItme(UserWorldId,site,1)

	SendKongfuMsg(UserWorldId)

	Player.Player_ExpErience =Player.Player_ExpErience-5000000
	Player.Player_Money=Player.Player_Money-500000000

	UpGongFu(UserWorldId)
	UpExp(UserWorldId)
	UpMoney(UserWorldId)
end


function addFqjnKONGFU(UserWorldId, ItmeId, site, number)
	local Player = GetPlayer(UserWorldId)
	local JnId=0
	if Player.Player_Job==1 then
		JnId=100301
	elseif Player.Player_Job==2 then
		JnId=200301
	elseif Player.Player_Job==3 then
		JnId=300301
	elseif Player.Player_Job==4 then
		JnId=400301
	elseif Player.Player_Job==5 then
		JnId=500301
	elseif Player.Player_Job==6 then
		JnId=800301
	end

end


function tanhuasan(UserWorldId, ItmeId, site, number)
	local Player = GetPlayer(UserWorldId)
	local Itme = GetWorldItme(ItmeId)
	if Itme.FLD_LEVEL > Player.Player_Level then
		return
        end
	if Itme.FLD_ZX ~= 0 then
		if Itme.FLD_ZX ~= Player.Player_Zx then
			return
        	end
        end
	if Itme.FLD_RESIDE1 ~= 0 then
		if Itme.FLD_RESIDE1 ~= Player.Player_Job then
			return
        	end
        end
	if Itme.FLD_JOB_LEVEL ~= 0 then
		if Itme.FLD_JOB_LEVEL > Player.Player_Job_leve then
			return
        	end
        end
	if Player.Player_Money < 500000000 then
		return
        end
	if Player.Player_ExpErience < 5000000 then
		return
        end
	AddStKongfu(UserWorldId,3,16)
	AddStKongfu(UserWorldId,3,17)
	UpUseItme(UserWorldId,site,1)

	SendKongfuMsg(UserWorldId)

	Player.Player_ExpErience =Player.Player_ExpErience-5000000
	Player.Player_Money=Player.Player_Money-500000000

	UpGongFu(UserWorldId)
	UpExp(UserWorldId)
	UpMoney(UserWorldId)
end

function tanhuasi(UserWorldId, ItmeId, site, number)
	local Player = GetPlayer(UserWorldId)
	local Itme = GetWorldItme(ItmeId)
	if Itme.FLD_LEVEL > Player.Player_Level then
		return
        end
	if Itme.FLD_ZX ~= 0 then
		if Itme.FLD_ZX ~= Player.Player_Zx then
			return
        	end
        end
	if Itme.FLD_RESIDE1 ~= 0 then
		if Itme.FLD_RESIDE1 ~= Player.Player_Job then
			return
        	end
        end
	if Itme.FLD_JOB_LEVEL ~= 0 then
		if Itme.FLD_JOB_LEVEL > Player.Player_Job_leve then
			return
        	end
        end
	if Player.Player_Money < 500000000 then
		return
        end
	if Player.Player_ExpErience < 5000000 then
		return
        end
	AddStKongfu(UserWorldId,3,18)
	AddStKongfu(UserWorldId,3,19)
	UpUseItme(UserWorldId,site,1)

	SendKongfuMsg(UserWorldId)

	Player.Player_ExpErience =Player.Player_ExpErience-5000000
	Player.Player_Money=Player.Player_Money-500000000

	UpGongFu(UserWorldId)
	UpExp(UserWorldId)
	UpMoney(UserWorldId)
end


function tanhuawu(UserWorldId, ItmeId, site, number)
	local Player = GetPlayer(UserWorldId)
	local Itme = GetWorldItme(ItmeId)
	if Itme.FLD_LEVEL > Player.Player_Level then
		return
        end
	if Itme.FLD_ZX ~= 0 then
		if Itme.FLD_ZX ~= Player.Player_Zx then
			return
        	end
        end
	if Itme.FLD_RESIDE1 ~= 0 then
		if Itme.FLD_RESIDE1 ~= Player.Player_Job then
			return
        	end
        end
	if Itme.FLD_JOB_LEVEL ~= 0 then
		if Itme.FLD_JOB_LEVEL > Player.Player_Job_leve then
			return
        	end
        end
	if Player.Player_Money < 500000000 then
		return
        end
	if Player.Player_ExpErience < 5000000 then
		return
        end
	AddStKongfu(UserWorldId,3,20)
	AddStKongfu(UserWorldId,3,21)
	UpUseItme(UserWorldId,site,1)

	SendKongfuMsg(UserWorldId)

	Player.Player_ExpErience =Player.Player_ExpErience-5000000
	Player.Player_Money=Player.Player_Money-500000000

	UpGongFu(UserWorldId)
	UpExp(UserWorldId)
	UpMoney(UserWorldId)
end


function zhengwu(UserWorldId, ItmeId, site, number)
	local Player = GetPlayer(UserWorldId)
	local Itme = GetWorldItme(ItmeId)
	if Itme.FLD_LEVEL > Player.Player_Level then
		return
        end
	if Itme.FLD_ZX ~= 0 then
		if Itme.FLD_ZX ~= Player.Player_Zx then
			return
        	end
        end
	if Itme.FLD_RESIDE1 ~= 0 then
		if Itme.FLD_RESIDE1 ~= Player.Player_Job then
			return
        	end
        end
	if Itme.FLD_JOB_LEVEL ~= 0 then
		if Itme.FLD_JOB_LEVEL > Player.Player_Job_leve then
			return
        	end
        end
	if Player.Player_Money < 500000000 then
		return
        end
	if Player.Player_ExpErience < 5000000 then
		return
        end
	AddStKongfu(UserWorldId,3,13)
	AddStKongfu(UserWorldId,3,14)
	UpUseItme(UserWorldId,site,1)

	SendKongfuMsg(UserWorldId)

	Player.Player_ExpErience =Player.Player_ExpErience-5000000
	Player.Player_Money=Player.Player_Money-500000000

	UpGongFu(UserWorldId)
	UpExp(UserWorldId)
	UpMoney(UserWorldId)
end

function addKONGFU(UserWorldId, ItmeId, site, number)
	local Player = GetPlayer(UserWorldId)
	local Itme = GetWorldItme(ItmeId)
	if Itme.FLD_LEVEL > Player.Player_Level then
		return
        end
	if Itme.FLD_ZX ~= 0 then
		if Itme.FLD_ZX ~= Player.Player_Zx then
			return
        	end
        end
	if Itme.FLD_RESIDE1 ~= 0 then
		if Itme.FLD_RESIDE1 ~= Player.Player_Job then
			return
        	end
        end
	if Itme.FLD_JOB_LEVEL ~= 0 then
		if Itme.FLD_JOB_LEVEL > Player.Player_Job_leve then
			return
        	end
        end
	if Player.Player_Money < 500000000 then
		return
        end
	if Player.Player_ExpErience < 5000000 then
		return
        end
	AddStKongfu(UserWorldId,3,4)
	AddStKongfu(UserWorldId,3,5)
	UpUseItme(UserWorldId,site,1)

	SendKongfuMsg(UserWorldId)

	Player.Player_ExpErience =Player.Player_ExpErience-5000000
	Player.Player_Money=Player.Player_Money-500000000

	UpGongFu(UserWorldId)
	UpExp(UserWorldId)
	UpMoney(UserWorldId)
end
function SetPlayerVIPP(UserWorldId, ItmeId, site, number)
	local Player = GetPlayer(UserWorldId)
	local Itme = GetWorldItme(ItmeId)
	UpUseItme(UserWorldId,site,1)
	SetPlayerVIP(UserWorldId,1)
	SendSysMsg(UserWorldId,"恭喜你获得了一个月会员", 9, "系统提示")
end

function Open999000058(UserWorldId, ItmeId, site, number)
	local Player = GetPlayer(UserWorldId)
	local Itme = GetWorldItme(ItmeId)
	UpUseItme(UserWorldId,site,1)
        SetPlayerRxpiont(UserWorldId,300,1)
	SendSysMsg(UserWorldId,"恭喜你获得300元宝", 9, "系统提示")
end
function Open999000059(UserWorldId, ItmeId, site, number)
	local Player = GetPlayer(UserWorldId)
	local Itme = GetWorldItme(ItmeId)
	UpUseItme(UserWorldId,site,1)
        SetPlayerRxpiont(UserWorldId,500,1)
	SendSysMsg(UserWorldId,"恭喜你获得500元宝", 9, "系统提示")
end
function Open999000060(UserWorldId, ItmeId, site, number)
	local Player = GetPlayer(UserWorldId)
	local Itme = GetWorldItme(ItmeId)
	UpUseItme(UserWorldId,site,1)
        SetPlayerRxpiont(UserWorldId,10,1)
	SendSysMsg(UserWorldId,"恭喜你获得10元宝", 9, "系统提示")
end
function Open999000061(UserWorldId, ItmeId, site, number)
	local Player = GetPlayer(UserWorldId)
	local Itme = GetWorldItme(ItmeId)
	UpUseItme(UserWorldId,site,1)
        SetPlayerRxpiont(UserWorldId,50,1)
	SendSysMsg(UserWorldId,"恭喜你获得50元宝", 9, "系统提示")
end
function Open999000062(UserWorldId, ItmeId, site, number)
	local Player = GetPlayer(UserWorldId)
	local Itme = GetWorldItme(ItmeId)
	UpUseItme(UserWorldId,site,1)
        SetPlayerRxpiont(UserWorldId,100,1)
	SendSysMsg(UserWorldId,"恭喜你获得100元宝", 9, "系统提示")
end
function yuanbaowubai(UserWorldId, ItmeId, site, number)
	local Player = GetPlayer(UserWorldId)
	local Itme = GetWorldItme(ItmeId)
	UpUseItme(UserWorldId,site,1)
        SetPlayerRxpiont(UserWorldId,500,1)
	SendSysMsg(UserWorldId,"恭喜你获得500元宝", 9, "系统提示")
end
function SetPlayerVSX1(UserWorldId, ItmeId, site, number)
	local Player = GetPlayer(UserWorldId)
	local Itme = GetWorldItme(ItmeId)
	UpUseItme(UserWorldId,site,1)
        SetPlayerShuxing(UserWorldId,100000)
	SendSysMsg(UserWorldId,"恭喜你获得10W攻击", 9, "系统提示")
end
