--[一转任务]
function MissIon18(UserWorldId,QuestId, CzId, RwJdId)
	local Player = GetPlayer(UserWorldId)
	if CzId==1 then
	 	SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
	elseif CzId==2 then
		if Player.Player_Job_leve>=1 then 
			return 
		elseif Player.Player_Level < 10  then 
			SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
return 
		end
                local Hfgwq = Hfgwuqi(UserWorldId)
	        if Hfgwq then
			return 
		end
  
		SetPlayerTransfer(UserWorldId,0,1)
                Hfgzhuanzhi(UserWorldId)

		SetQigong(UserWorldId,5)
                UpHpMpSp(UserWorldId)
		UpGongFu(UserWorldId)
		Player.Player_Money=Player.Player_Money+20000000
		UpMoney(UserWorldId)
		AddQuest(UserWorldId,QuestId,1)
		SendMissionMsg(UserWorldId,QuestId, 21, 1)
	elseif CzId==3 then
	 	SendMissionMsg(UserWorldId,QuestId, 31, RwJdId)
	elseif CzId==5 then
	 	SendMissionMsg(UserWorldId,QuestId, 51, RwJdId)
	end	 
end
--[二转正任务]
function MissIon11(UserWorldId,QuestId, CzId, RwJdId)
	local Player = GetPlayer(UserWorldId)
	if CzId==1 then
 		SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
	elseif CzId==2 then
		if Player.Player_Job_leve>=2 then 
			return 
		elseif Player.Player_Level < 35 then 
			SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
return 
		elseif Player.Player_Job_leve < 1 then 

return 
		end
                local Hfgwq = Hfgwuqi(UserWorldId)
	        if Hfgwq then
			return 
		end

		SetPlayerTransfer(UserWorldId,1,2)
                Hfgzhuanzhi(UserWorldId)
               
		SetQigong(UserWorldId,6)
		UpGongFu(UserWorldId)
		UpYzbItme(UserWorldId)
		Player.Player_Money=Player.Player_Money+100000000
		UpMoney(UserWorldId)
		AddQuest(UserWorldId,QuestId,1)
		SendMissionMsg(UserWorldId,QuestId, 21, 1)
	elseif CzId==3 then
	 	SendMissionMsg(UserWorldId,QuestId, 31, RwJdId)
	elseif CzId==5 then
	 	SendMissionMsg(UserWorldId,QuestId, 51, RwJdId)
	end	
end
--[二转邪任务]
function MissIon12(UserWorldId,QuestId, CzId, RwJdId)
	local Player = GetPlayer(UserWorldId)
	if CzId==1 then
		if Player.Player_Level < 35 then 
			SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
			return 
		else
	 		SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
		end
	elseif CzId==2 then
		if Player.Player_Job_leve>=2 then 
			return 
		elseif Player.Player_Level < 35 then 
			SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
			return 
		elseif Player.Player_Job_leve < 1 then 
                        return 
		end
                local Hfgwq = Hfgwuqi(UserWorldId)
	        if Hfgwq then
			return 
		end
               
		SetPlayerTransfer(UserWorldId,2,2)
                Hfgzhuanzhi(UserWorldId)
                
		SetQigong(UserWorldId,6)
		UpGongFu(UserWorldId)
		UpYzbItme(UserWorldId)
		Player.Player_Money=Player.Player_Money+100000000
		UpMoney(UserWorldId)
		AddQuest(UserWorldId,QuestId,1)
		SendMissionMsg(UserWorldId,QuestId, 21, 1)
	elseif CzId==3 then
	 	SendMissionMsg(UserWorldId,QuestId, 31, RwJdId)
	elseif CzId==5 then
	 	SendMissionMsg(UserWorldId,QuestId, 51, RwJdId)
	end	
end

--[三转正任务]
function MissIon45(UserWorldId,QuestId, CzId, RwJdId)
	local Player = GetPlayer(UserWorldId)
	if CzId==1 then
		if Player.Player_Level < 60 then 
			SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
			return 
		else
	 		SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
		end
	elseif CzId==2 then
		if Player.Player_Job_leve>=3 then 
			return 
		elseif Player.Player_Level < 60 then 
			SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
			return 
		elseif Player.Player_Job_leve < 2 then 
                        return
		end
                local Hfgwq = Hfgwuqi(UserWorldId)
	        if Hfgwq then
			return 
		end
               
		SetPlayerTransfer(UserWorldId,Player.Player_Zx,3)
                Hfgzhuanzhi(UserWorldId)
               
		SetQigong(UserWorldId,7)
		UpGongFu(UserWorldId)
		Player.Player_Money=Player.Player_Money+200000000
		UpMoney(UserWorldId)
		AddQuest(UserWorldId,QuestId,1)
		SendMissionMsg(UserWorldId,QuestId, 21, 1)
	elseif CzId==3 then
	 	SendMissionMsg(UserWorldId,QuestId, 31, RwJdId)
	elseif CzId==5 then
	 	SendMissionMsg(UserWorldId,QuestId, 51, RwJdId)
	end	
end
--[三转邪任务]
function MissIon46(UserWorldId,QuestId, CzId, RwJdId)
	local Player = GetPlayer(UserWorldId)
	if CzId==1 then
		if Player.Player_Level < 60 then 
			SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
			return 
		else
	 		SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
		end
	elseif CzId==2 then
		if Player.Player_Job_leve>=3 then 
			return 
		elseif Player.Player_Level < 60 then 
			SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
			return 
		elseif Player.Player_Job_leve < 2 then 
                        return
		end
                local Hfgwq = Hfgwuqi(UserWorldId)
	        if Hfgwq then
			return 
		end

		SetPlayerTransfer(UserWorldId,Player.Player_Zx,3)
                Hfgzhuanzhi(UserWorldId)
                
		SetQigong(UserWorldId,7)
		UpGongFu(UserWorldId)
		Player.Player_Money=Player.Player_Money+200000000
		UpMoney(UserWorldId)
		AddQuest(UserWorldId,QuestId,1)
		SendMissionMsg(UserWorldId,QuestId, 21, 1)
	elseif CzId==3 then
	 	SendMissionMsg(UserWorldId,QuestId, 31, RwJdId)
	elseif CzId==5 then
	 	SendMissionMsg(UserWorldId,QuestId, 51, RwJdId)
	end	
end
--[四转正任务]
function MissIon73(UserWorldId,QuestId, CzId, RwJdId)
	local Player = GetPlayer(UserWorldId)
	if CzId==1 then
		if Player.Player_Level < 80 then 
			SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
			return 
		else
	 		SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
		end
	elseif CzId==2 then
		if Player.Player_Job_leve>=4 then 
			return 
		elseif Player.Player_Job_leve < 3 then 
                        return

		end
                local Hfgwq = Hfgwuqi(UserWorldId)
	        if Hfgwq then
			return 
		end
              
		SetPlayerTransfer(UserWorldId,Player.Player_Zx,4)
                Hfgzhuanzhi(UserWorldId)
               
		SetQigong(UserWorldId,8)
		SetQigong(UserWorldId,9)
		UpGongFu(UserWorldId)
		Player.Player_Money=Player.Player_Money+300000000
		UpMoney(UserWorldId)
		AddQuest(UserWorldId,QuestId,1)
		SendMissionMsg(UserWorldId,QuestId, 21, 1)
	elseif CzId==3 then
	 	SendMissionMsg(UserWorldId,QuestId, 31, RwJdId)
	elseif CzId==5 then
	 	SendMissionMsg(UserWorldId,QuestId, 51, RwJdId)
	end	
end
--[四转邪任务]
function MissIon74(UserWorldId,QuestId, CzId, RwJdId)
	local Player = GetPlayer(UserWorldId)
	if CzId==1 then
		if Player.Player_Level < 80 then 
			SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
			return 
		else
	 		SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
		end
	elseif CzId==2 then
		if Player.Player_Job_leve>=4 then 
			return 
		elseif Player.Player_Job_leve < 3 then 
                        return
		end
                local Hfgwq = Hfgwuqi(UserWorldId)
	        if Hfgwq then
			return 
		end
               
		SetPlayerTransfer(UserWorldId,Player.Player_Zx,4)
                Hfgzhuanzhi(UserWorldId)
   
		SetQigong(UserWorldId,8)
		SetQigong(UserWorldId,9)
		UpGongFu(UserWorldId)
		Player.Player_Money=Player.Player_Money+300000000
		UpMoney(UserWorldId)
		AddQuest(UserWorldId,QuestId,1)
		SendMissionMsg(UserWorldId,QuestId, 21, 1)
	elseif CzId==3 then
	 	SendMissionMsg(UserWorldId,QuestId, 31, RwJdId)
	elseif CzId==5 then
	 	SendMissionMsg(UserWorldId,QuestId, 51, RwJdId)
	end	
end
--[五转任务]
function MissIon178(UserWorldId,QuestId, CzId, RwJdId)
	local Player = GetPlayer(UserWorldId)
	if CzId==1 then
		if Player.Player_Level < 100 then 
			SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
			return 
		else
	 		SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
		end
	elseif CzId==2 then
		if Player.Player_Job_leve>=5 then 
			return 
		elseif Player.Player_Level < 100 then 
			SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
			return 
		elseif Player.Player_Job_leve < 4 then 
                        return
		end
                local Hfgwq = Hfgwuqi(UserWorldId)
	        if Hfgwq then
			return 
		end

		SetPlayerTransfer(UserWorldId,Player.Player_Zx,5)
                Hfgzhuanzhi(UserWorldId)
               
		SetQigong(UserWorldId,10)
		AddSkill(UserWorldId,0,25)
		AddSkill(UserWorldId,0,26)
		AddSkill(UserWorldId,0,27)
		UpGongFu(UserWorldId)
		Player.Player_Money=Player.Player_Money+400000000
		UpMoney(UserWorldId)
		AddQuest(UserWorldId,QuestId,1)
		SendMissionMsg(UserWorldId,QuestId, 21, 1)
	elseif CzId==3 then
	 	SendMissionMsg(UserWorldId,QuestId, 31, RwJdId)
	elseif CzId==5 then
	 	SendMissionMsg(UserWorldId,QuestId, 51, RwJdId)
	end	
end
--[六转任务]
function MissIon300(UserWorldId,QuestId, CzId, RwJdId)
	local Player = GetPlayer(UserWorldId)
	if CzId==1 then
		if Player.Player_Level<115  then 
			SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
			return 
		else
	 		SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
		end
	elseif CzId==2 then
		if Player.Player_Job_leve>=6 then 
			return 
		elseif Player.Player_Level<115 or Player.Player_Job_leve<5 then 
			SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
			return 
		elseif Player.Player_Job_leve < 5 then 
                        return
		end

		local weiz=GetPackage(UserWorldId)
		if weiz==-1 then 
			SendSysMsg(UserWorldId,"装备栏没有空位了，请清理", 9, "系统提示")
			SendMissionMsg(UserWorldId,QuestId, 31, RwJdId)
			return 
		end
                local Hfgwq = Hfgwuqi(UserWorldId)
	        if Hfgwq then
			return 
		end

		AddSkillBook6(UserWorldId,weiz);

		SetPlayerTransfer(UserWorldId,Player.Player_Zx,6)

		Player.Player_Money=Player.Player_Money+400000000
                Hfgzhuanzhi(UserWorldId)
       
		UpGongFu(UserWorldId)
		UpMoney(UserWorldId)
		UpExp(UserWorldId)
		UpYzbItme(UserWorldId)

		AddQuest(UserWorldId,QuestId,1)
		SendMissionMsg(UserWorldId,QuestId, 21, 1)
	elseif CzId==3 then
	 	SendMissionMsg(UserWorldId,QuestId, 31, RwJdId)
	elseif CzId==5 then
	 	SendMissionMsg(UserWorldId,QuestId, 51, RwJdId)
	end	
end
--[七转任务]
function MissIon301(UserWorldId,QuestId, CzId, RwJdId)
	local Player = GetPlayer(UserWorldId)
	if CzId==1 then
		if Player.Player_Level<120  then
			SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
			return 
		else
	 		SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
		end
	elseif CzId==2 then
		if Player.Player_Job_leve>=7 then 
			return 
		elseif Player.Player_Level<120 or Player.Player_Job_leve<6 then 
			SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
			return 
		elseif Player.Player_Job_leve < 6 then 
                        return
		end
		local weiz=GetPackage(UserWorldId)
		if weiz==-1 then 
			SendSysMsg(UserWorldId,"装备栏没有空位了，请清理", 9, "系统提示")
			SendMissionMsg(UserWorldId,QuestId, 31, RwJdId)
			return 
		end
                local Hfgwq = Hfgwuqi(UserWorldId)
	        if Hfgwq then
			return 
		end
                
		AddSkillBook7(UserWorldId,weiz);

		SetPlayerTransfer(UserWorldId,Player.Player_Zx,7)

		--Player.Player_Money=Player.Player_Money+400000000
                Hfgzhuanzhi(UserWorldId)
         
		UpGongFu(UserWorldId)
		UpMoney(UserWorldId)
		UpExp(UserWorldId)
		UpYzbItme(UserWorldId)

		AddQuest(UserWorldId,QuestId,1)
		SendMissionMsg(UserWorldId,QuestId, 21, 1)
	elseif CzId==3 then
	 	SendMissionMsg(UserWorldId,QuestId, 31, RwJdId)
	elseif CzId==5 then
	 	SendMissionMsg(UserWorldId,QuestId, 51, RwJdId)
	end	
end
--[八转转任务]
function MissIon409(UserWorldId,QuestId, CzId, RwJdId)
	local Player = GetPlayer(UserWorldId)
	if CzId==1 then
		if Player.Player_Level<130 then 
			SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
			return 
		else
	 		SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)
		end
	elseif CzId==2 then
		if Player.Player_Job_leve>=8 then 
			return 
		elseif Player.Player_Level<130  or Player.Player_Job_leve<7 then 
			SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)
			return 
		elseif Player.Player_Job_leve < 7 then 
                        return
		end
		local weiz=GetPackage(UserWorldId)
		if weiz==-1 then 
			SendSysMsg(UserWorldId,"装备栏没有空位了，请清理", 9, "系统提示")
			SendMissionMsg(UserWorldId,QuestId, 31, RwJdId)
			return 
		end
                local Hfgwq = Hfgwuqi(UserWorldId)
	        if Hfgwq then
			return 
		end

		AddSkillBook8(UserWorldId,weiz);

		SetPlayerTransfer(UserWorldId,Player.Player_Zx,8)
                Hfgzhuanzhi(UserWorldId)
        
		--Player.Player_Money=Player.Player_Money+400000000
		UpGongFu(UserWorldId)
		UpMoney(UserWorldId)
		UpExp(UserWorldId)
		UpYzbItme(UserWorldId)

		AddQuest(UserWorldId,QuestId,1)
		SendMissionMsg(UserWorldId,QuestId, 21, 1)
	elseif CzId==3 then
	 	SendMissionMsg(UserWorldId,QuestId, 31, RwJdId)
	elseif CzId==5 then
	 	SendMissionMsg(UserWorldId,QuestId, 51, RwJdId)
	end	
end