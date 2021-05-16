function addQSKONGFU(UserWorldId, ItmeId, site, number)
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
	if Player.Player_Money < 5000000 then
		return
        end
	if Player.Player_ExpErience < 50000 then
		return
        end
	SendSysMsg(UserWorldId,"您练成了升天二式的武功", 9, "系统提示")
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