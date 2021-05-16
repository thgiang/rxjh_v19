--DestroyMonster为打死怪物后的触发器，本函数名不可以更改
--MonsterId  怪物ID
function DestroyMonster(UserWorldId, MonsterId)
	--local Msg=string.format("怪物ID %d",ran)
	--SendSysMsg(UserWorldId,Msg, 9, "系统提示")

	if MonsterId==10007 then
		Monster10007(UserWorldId)
	end
end

--[任务初出江湖得到的任务物品]
function Monster10007(UserWorldId)
	--查询得到任务ID为1任务阶段;
	--没有这个任务返回0,大于0表示当前任务进行到了哪个阶段
	local QuestItme=GetQuestItme(UserWorldId,900000001,10) ---这里是检测达到任务数量后不获取任务物品的提示任务数量已满
	if QuestItme then  --检测任务物品是否为10个
        SendSysMsg(UserWorldId,"任务物品已经完成请提交任务去吧", 9, "系统提示") --如果是就提示了直接不获取任务物品了
return
end
	local QuestLevel=GetQuestLevel(UserWorldId,1) --检测是否为这个任务ID1就是
if QuestLevel==2 then --检测第几阶段是否为第二阶段
		local ran=math.random(1,100)  --简单爆率
		if ran<=40 then
			--这里是一个简单的暴率设置
			AddQuestItme(UserWorldId,900000001,1) --掉落的人物物品ID

		end
	end
end 