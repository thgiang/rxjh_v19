--DestroyMonsterΪ���������Ĵ��������������������Ը���
--MonsterId  ����ID
function DestroyMonster(UserWorldId, MonsterId)
	--local Msg=string.format("����ID %d",ran)
	--SendSysMsg(UserWorldId,Msg, 9, "ϵͳ��ʾ")

	if MonsterId==10007 then
		Monster10007(UserWorldId)
	end
end

--[������������õ���������Ʒ]
function Monster10007(UserWorldId)
	--��ѯ�õ�����IDΪ1����׶�;
	--û��������񷵻�0,����0��ʾ��ǰ������е����ĸ��׶�
	local QuestItme=GetQuestItme(UserWorldId,900000001,10) ---�����Ǽ��ﵽ���������󲻻�ȡ������Ʒ����ʾ������������
	if QuestItme then  --���������Ʒ�Ƿ�Ϊ10��
        SendSysMsg(UserWorldId,"������Ʒ�Ѿ�������ύ����ȥ��", 9, "ϵͳ��ʾ") --����Ǿ���ʾ��ֱ�Ӳ���ȡ������Ʒ��
return
end
	local QuestLevel=GetQuestLevel(UserWorldId,1) --����Ƿ�Ϊ�������ID1����
if QuestLevel==2 then --���ڼ��׶��Ƿ�Ϊ�ڶ��׶�
		local ran=math.random(1,100)  --�򵥱���
		if ran<=40 then
			--������һ���򵥵ı�������
			AddQuestItme(UserWorldId,900000001,1) --�����������ƷID

		end
	end
end 