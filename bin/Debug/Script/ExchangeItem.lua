-----------����12.0�����սű���----------
function ExchangeItem(UserWorldId,str1)

---����ѫ�齱��
if str1== "@123" then
local Player = GetPlayer(UserWorldId)
if Player.Player_wuxun < 1000000 then
SendSysMsg(UserWorldId,"�����Ҫ10��WX,�����ѫ����,������ɱ������", 10, "ϵͳ��ʾ")
return 
end
Player.Player_wuxun=Player.Player_wuxun-100000000
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ���������,����2����λ", 9, "ϵͳ��ʾ")
return 
end                                         
AddItmeProp(UserWorldId,1008000516,weizs[0],1,0,0,0,0,0,0,0,0,0)
SendSysMsg(UserWorldId,"ϵͳ����10w��ѫ;��ý��һ��", 10, "ϵͳ��ʾ")
end

if str1== "@�һ����" then
local Player = GetPlayer(UserWorldId)
if Player.Player_wuxun < 100000 then
SendSysMsg(UserWorldId,"��Ҫ��ѫ10������,�����ѫ����,������ɱ������", 10, "ϵͳ��ʾ")
return 
end
Player.Player_wuxun=Player.Player_wuxun-100000
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ���������,����2����λ", 9, "ϵͳ��ʾ")
return 
end
AddItmeProp(UserWorldId,900000035,weizs[0],1,0,0,0,0,0,0,0,0,0)
SendSysMsg(UserWorldId,"ϵͳ����1000000��ѫ;��ý�飬��ϲ��ϲ��", 10, "ϵͳ��ʾ")
end

if str1== "@�һ���ʯ" then
local Player = GetPlayer(UserWorldId)
if Player.Player_wuxun < 500000 then
SendSysMsg(UserWorldId,"�齱��Ҫ��ѫ50������,�����ѫ����,������ɱ������", 10, "ϵͳ��ʾ")
return 
end
Player.Player_wuxun=Player.Player_wuxun-500000
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ���������,����2����λ", 9, "ϵͳ��ʾ")
return 
end
AddItmeProp(UserWorldId,900000401,weizs[0],500,0,0,0,0,0,0,0,0,0)
SendSysMsg(UserWorldId,"ϵͳ����5000000��ѫ;��ñ�ʯ500����ϲ��ϲ����", 10, "ϵͳ��ʾ")
end

---���һ��������ˡ�
if str1== "@�һ�����" then
local weiz1=GetPakItemNum(UserWorldId,1008000213,1)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"�һ�ʧ��;��ȷ�ϸ��˱�����1������", 10, "ϵͳ��ʾ")
return
end
local yb=GetRxpiont(UserWorldId)
if yb < 0 then
SendSysMsg(UserWorldId,"������Ҫ������0Ԫ��,���Ԫ������", 10, "ϵͳ��ʾ")
return 
end
local weizs=GetPackages(UserWorldId,1)
if weizs.Count< 1 then 
SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ���������,����1����λ", 9, "ϵͳ��ʾ")
return 
end
AddItmeProp(UserWorldId,1008000212,weizs[0],1,2000000001,0,0,0,0,0,0,0,0)
DelItme(UserWorldId,weiz1,1)
SendSysMsg(UserWorldId,"��ϲ��!����һ��", 10, "ϵͳ��ʾ")
SendSysMsg(UserWorldId,"����", 20, "ϵͳ��ʾ")
end

---���ǳ����ν�����
--�����ǳ�����
if str1== "@�����������" then
local weiz1=GetPakItemNum(UserWorldId,100026,1)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"�����ǳ����������ﱳ��", 10, "ϵͳ��ʾ")
return 
end
local weiz2=GetPakItemNum(UserWorldId,900000619,150)
if weiz2==-1 then 
SendSysMsg(UserWorldId,"����150�����������ﱳ��", 10, "ϵͳ��ʾ")
return 
end
local yb=GetRxpiont(UserWorldId)
if yb < 2499 then
SendSysMsg(UserWorldId,"������Ҫ������3000Ԫ��,���Ԫ������", 10, "ϵͳ��ʾ")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ���������,����2����λ", 9, "ϵͳ��ʾ")
return 
end
SetPlayerRxpiont(UserWorldId,3000,0)
DelItme(UserWorldId,weiz1,1) 
DelItme(UserWorldId,weiz2,150)                                          
AddItmeProp(UserWorldId,100028,weizs[0],1,0,20000060,60000060,10000024,80000002,0,0,0,0)
SendSysMsg(UserWorldId,"��ϲ�������ǳ������ɹ�����á�����������շ�150������+3000Ԫ��+�����ǳ�һ��", 10, "ϵͳ��ʾ")
end

--�����ǳ�����
if str1== "@�����������" then
local weiz1=GetPakItemNum(UserWorldId,18,1)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"�����ǳ����������ﱳ��", 10, "ϵͳ��ʾ")
return 
end
local weiz2=GetPakItemNum(UserWorldId,900000619,150)
if weiz2==-1 then 
SendSysMsg(UserWorldId,"����150�����������ﱳ��", 10, "ϵͳ��ʾ")
return 
end
local yb=GetRxpiont(UserWorldId)
if yb < 2499 then
SendSysMsg(UserWorldId,"������Ҫ������3000Ԫ��,���Ԫ������", 10, "ϵͳ��ʾ")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ���������,����2����λ", 9, "ϵͳ��ʾ")
return 
end
SetPlayerRxpiont(UserWorldId,3000,0)
DelItme(UserWorldId,weiz1,1)
DelItme(UserWorldId,weiz2,150)
AddItmeProp(UserWorldId,23,weizs[0],1,0,80000005,70000020,30000400,100000025,0,0,0,0)
SendSysMsg(UserWorldId,"��ϲ�������ǳ������ɹ�����á�����������շ�150��+2500Ԫ��+�����ǳ�һ��", 10, "ϵͳ��ʾ")
end

--�����ǳ���ָ
if str1== "@���������ָ-(ħ)" then
local weiz1=GetPakItemNum(UserWorldId,700911,1)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"�����ǳ���ָ�����ﱳ��", 10, "ϵͳ��ʾ")
return 
end
local weiz2=GetPakItemNum(UserWorldId,900000619,150)
if weiz2==-1 then 
SendSysMsg(UserWorldId,"����150�����������ﱳ��", 10, "ϵͳ��ʾ")
return 
end

local yb=GetRxpiont(UserWorldId)
if yb < 2499 then
SendSysMsg(UserWorldId,"������Ҫ������3000Ԫ��,���Ԫ������", 10, "ϵͳ��ʾ")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ���������,����2����λ", 9, "ϵͳ��ʾ")
return 
end
SetPlayerRxpiont(UserWorldId,3000,0)
DelItme(UserWorldId,weiz1,1)
DelItme(UserWorldId,weiz2,150)                       
AddItmeProp(UserWorldId,700028,weizs[0],1,0,70000030,10000055,100000025,110000055,0,0,0,0)
SendSysMsg(UserWorldId,"��ϲ�������ǳ���ָ�ɹ�����á������ָ-(ħ)���շ�150������+3000Ԫ��+�����ǳ�һ��", 10, "ϵͳ��ʾ")
end

---���ǳ����ν�����
--�����ǳ�����
if str1== "@�����ǳ�����" then
local weiz1=GetPakItemNum(UserWorldId,100026,1)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"�����ǳ����������ﱳ��", 10, "ϵͳ��ʾ")
return 
end
local weiz2=GetPakItemNum(UserWorldId,900000619,150)
if weiz2==-1 then 
SendSysMsg(UserWorldId,"����150�����������ﱳ��", 10, "ϵͳ��ʾ")
return 
end
local yb=GetRxpiont(UserWorldId)
if yb < 2499 then
SendSysMsg(UserWorldId,"������Ҫ������3000Ԫ��,���Ԫ������", 10, "ϵͳ��ʾ")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ���������,����2����λ", 9, "ϵͳ��ʾ")
return 
end
SetPlayerRxpiont(UserWorldId,3000,0)
DelItme(UserWorldId,weiz1,1)
DelItme(UserWorldId,weiz2,150)
AddItmeProp(UserWorldId,100028,weizs[0],1,0,20000040,10000040,30000150,80000002,0,0,0,0)
SendSysMsg(UserWorldId,"��ϲ�������ǳ������ɹ�����á�����������շ�150������+3000Ԫ��+�����ǳ�һ��", 10, "ϵͳ��ʾ")
end

--�����ǳ�����
if str1== "@�����ǳ�����" then
local weiz1=GetPakItemNum(UserWorldId,18,1)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"�����ǳ����������ﱳ��", 10, "ϵͳ��ʾ")
return 
end
local weiz2=GetPakItemNum(UserWorldId,900000619,150)
if weiz2==-1 then 
SendSysMsg(UserWorldId,"����150�����������ﱳ��", 10, "ϵͳ��ʾ")
return 
end
local yb=GetRxpiont(UserWorldId)
if yb < 2499 then
SendSysMsg(UserWorldId,"������Ҫ������3000Ԫ��,���Ԫ������", 10, "ϵͳ��ʾ")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ���������,����2����λ", 9, "ϵͳ��ʾ")
return 
end
SetPlayerRxpiont(UserWorldId,3000,0)
DelItme(UserWorldId,weiz1,1)
DelItme(UserWorldId,weiz2,150)
AddItmeProp(UserWorldId,23,weizs[0],1,0,80000006,70000020,30000400,10000150,0,0,0,0)
SendSysMsg(UserWorldId,"��ϲ�������ǳ������ɹ�����á��������-(ħ)���շ�150������+3000Ԫ��+�����ǳ�һ��", 10, "ϵͳ��ʾ")
end

--�����ǳ���ָ
if str1== "@�����ǳ���ָ" then
local weiz1=GetPakItemNum(UserWorldId,700911,1)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"�����ǳ���ָ�����ﱳ��", 10, "ϵͳ��ʾ")
return 
end
local weiz2=GetPakItemNum(UserWorldId,900000619,150)
if weiz2==-1 then 
SendSysMsg(UserWorldId,"����150�����������ﱳ��", 10, "ϵͳ��ʾ")
return 
end

local yb=GetRxpiont(UserWorldId)
if yb < 2499 then
SendSysMsg(UserWorldId,"������Ҫ������3000Ԫ��,���Ԫ������", 10, "ϵͳ��ʾ")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ���������,����2����λ", 9, "ϵͳ��ʾ")
return 
end
SetPlayerRxpiont(UserWorldId,3000,0)
DelItme(UserWorldId,weiz1,1)
DelItme(UserWorldId,weiz2,150)
AddItmeProp(UserWorldId,700028,weizs[0],1,0,70000030,10000070,30000300,110000050,0,0,0,0)
SendSysMsg(UserWorldId,"��ϲ�������ǳ���ָ�ɹ�����á������ָ-(ħ)���շ�150������+3000Ԫ��+�����ǳ�һ��", 10, "ϵͳ��ʾ")
end

--������������
if str1== "@���������ָ" then
local weiz1=GetPakItemNum(UserWorldId,700021,1)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"������ħ��ָ�Ƿ������ﱳ��", 10, "ϵͳ��ʾ")
return 
end
local weiz2=GetPakItemNum(UserWorldId,900000619,50)
if weiz2==-1 then 
SendSysMsg(UserWorldId,"����50ö�����Ƿ������ﱳ��", 10, "ϵͳ��ʾ")
return 
end

local yb=GetRxpiont(UserWorldId)
if yb < 0 then
SendSysMsg(UserWorldId,"������Ҫ������0Ԫ��,���Ԫ������", 10, "ϵͳ��ʾ")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ���������,����2����λ", 9, "ϵͳ��ʾ")
return 
end
SetPlayerRxpiont(UserWorldId,0,0)
DelItme(UserWorldId,weiz1,1)
DelItme(UserWorldId,weiz2,50)
AddItmeProp(UserWorldId,700022,weizs[0],1,0,70000013,10000030,30000100,0,0,0,0,0)
SendSysMsg(UserWorldId,"��ϲ�����������ָ�ɹ�������50������+��ħ��ָ!!!", 10, "ϵͳ��ʾ")
end

if str1== "@�����������" then
local weiz1=GetPakItemNum(UserWorldId,15,1)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"������ħ�����Ƿ������ﱳ��", 10, "ϵͳ��ʾ")
return 
end
local weiz2=GetPakItemNum(UserWorldId,900000619,50)
if weiz2==-1 then 
SendSysMsg(UserWorldId,"����50�������Ƿ������ﱳ��", 10, "ϵͳ��ʾ")
return 
end

local yb=GetRxpiont(UserWorldId)
if yb < 0 then
SendSysMsg(UserWorldId,"������Ҫ������0Ԫ��,���Ԫ������", 10, "ϵͳ��ʾ")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ���������,����2����λ", 9, "ϵͳ��ʾ")
return 
end
SetPlayerRxpiont(UserWorldId,0,0)
DelItme(UserWorldId,weiz1,1)
DelItme(UserWorldId,weiz2,50)
AddItmeProp(UserWorldId,16,weizs[0],1,0,80000003,70000010,30000150,0,0,0,0,0)
SendSysMsg(UserWorldId,"��ϲ��������������ɹ�������50������+��ħ����", 10, "ϵͳ��ʾ")
end

if str1== "@������������" then
local weiz1=GetPakItemNum(UserWorldId,100020,1)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"������ħ���������ﱳ��", 10, "ϵͳ��ʾ")
return 
end
local weiz2=GetPakItemNum(UserWorldId,900000619,50)
if weiz2==-1 then 
SendSysMsg(UserWorldId,"����50�������Ƿ������ﱳ��", 10, "ϵͳ��ʾ")
return 
end

local yb=GetRxpiont(UserWorldId)
if yb < 0 then
SendSysMsg(UserWorldId,"������Ҫ������0Ԫ��,���Ԫ������", 10, "ϵͳ��ʾ")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ���������,����2����λ", 9, "ϵͳ��ʾ")
return 
end
SetPlayerRxpiont(UserWorldId,0,0)
DelItme(UserWorldId,weiz1,1)
DelItme(UserWorldId,weiz2,50)
AddItmeProp(UserWorldId,100021,weizs[0],1,0,10000030,20000040,30000150,0,0,0,0,0)
SendSysMsg(UserWorldId,"��ϲ�����������ָ�ɹ�������50������+��ħ����", 10, "ϵͳ��ʾ")
end

--�����ǳ�����
if str1== "@�����ǳ���ָ" then
local weiz1=GetPakItemNum(UserWorldId,700022,1)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"��������ָ�����ﱳ��", 10, "ϵͳ��ʾ")
return 
end
local weiz2=GetPakItemNum(UserWorldId,900000619,100)
if weiz2==-1 then 
SendSysMsg(UserWorldId,"����100ö����Ƿ������ﱳ��", 10, "ϵͳ��ʾ")
return 
end

local yb=GetRxpiont(UserWorldId)
if yb < 0 then
SendSysMsg(UserWorldId,"������Ҫ������1000Ԫ��,���Ԫ������", 10, "ϵͳ��ʾ")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ���������,����2����λ", 9, "ϵͳ��ʾ")
return 
end
SetPlayerRxpiont(UserWorldId,1000,0)
DelItme(UserWorldId,weiz1,1)
DelItme(UserWorldId,weiz2,100)
AddItmeProp(UserWorldId,700911,weizs[0],1,0,70000020,10000040,30000150,0,0,0,0,0)
SendSysMsg(UserWorldId,"��ϲ�������ǳ���ָ�ɹ�������100������+1000Ԫ��+�����ָ", 10, "ϵͳ��ʾ")
end

if str1== "@�����ǳ�����" then
local weiz1=GetPakItemNum(UserWorldId,16,1)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"�����ǳ���ָ�����ﱳ��", 10, "ϵͳ��ʾ")
return 
end
local weiz2=GetPakItemNum(UserWorldId,900000619,100)
if weiz2==-1 then 
SendSysMsg(UserWorldId,"����100�������Ƿ������ﱳ��", 10, "ϵͳ��ʾ")
return 
end

local yb=GetRxpiont(UserWorldId)
if yb < 0 then
SendSysMsg(UserWorldId,"������Ҫ������1000Ԫ��,���Ԫ������", 10, "ϵͳ��ʾ")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ���������,����2����λ", 9, "ϵͳ��ʾ")
return 
end
SetPlayerRxpiont(UserWorldId,1000,0)
DelItme(UserWorldId,weiz1,1)
DelItme(UserWorldId,weiz2,100)
AddItmeProp(UserWorldId,18,weizs[0],1,0,80000005,70000013,30000200,0,0,0,0,0)
SendSysMsg(UserWorldId,"��ϲ�������ǳ������ɹ�������100������+1000Ԫ��+�������", 10, "ϵͳ��ʾ")
end

if str1== "@�����ǳ�����" then
local weiz1=GetPakItemNum(UserWorldId,100021,1)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"����������������ﱳ��", 10, "ϵͳ��ʾ")
return 
end
local weiz2=GetPakItemNum(UserWorldId,900000619,100)
if weiz2==-1 then 
SendSysMsg(UserWorldId,"����100�������Ƿ������ﱳ��", 10, "ϵͳ��ʾ")
return 
end

local yb=GetRxpiont(UserWorldId)
if yb < 0 then
SendSysMsg(UserWorldId,"������Ҫ������1000Ԫ��,���Ԫ������", 10, "ϵͳ��ʾ")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ���������,����2����λ", 9, "ϵͳ��ʾ")
return 
end
SetPlayerRxpiont(UserWorldId,1000,0)
DelItme(UserWorldId,weiz1,1)
DelItme(UserWorldId,weiz2,100)
AddItmeProp(UserWorldId,100026,weizs[0],1,0,10000040,20000040,30000200,40000200,0,0,0,0)
SendSysMsg(UserWorldId,"��ϲ�������ǳ���ָ�ɹ�������100������+��������", 10, "ϵͳ��ʾ")
end

--������ħ����
if str1== "@������ħ��ָ" then
local weiz1=GetPakItemNum(UserWorldId,700020,1)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"����Ѫ���ָ�Ƿ������ﱳ��", 10, "ϵͳ��ʾ")
return 
end
local weiz2=GetPakItemNum(UserWorldId,900000619,30)
if weiz2==-1 then 
SendSysMsg(UserWorldId,"����30�������Ƿ������ﱳ��", 10, "ϵͳ��ʾ")
return 
end

local yb=GetRxpiont(UserWorldId)
if yb < 0 then
SendSysMsg(UserWorldId,"������Ҫ������0Ԫ��,���Ԫ������", 10, "ϵͳ��ʾ")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ���������,����2����λ", 9, "ϵͳ��ʾ")
return 
end
SetPlayerRxpiont(UserWorldId,0,0)
DelItme(UserWorldId,weiz1,1)
DelItme(UserWorldId,weiz2,30)
AddItmeProp(UserWorldId,700021,weizs[0],1,0,70000011,10000035,0,0,0,0,0,0)
SendSysMsg(UserWorldId,"��ϲ��������ħ��ָ�ɹ�������30������+Ѫ���ָ", 10, "ϵͳ��ʾ")
end

if str1== "@������ħ����" then
local weiz1=GetPakItemNum(UserWorldId,14,1)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"����Ѫ������Ƿ������ﱳ��", 10, "ϵͳ��ʾ")
return 
end
local weiz2=GetPakItemNum(UserWorldId,900000619,30)
if weiz2==-1 then 
SendSysMsg(UserWorldId,"����30�������Ƿ������ﱳ��", 10, "ϵͳ��ʾ")
return 
end

local yb=GetRxpiont(UserWorldId)
if yb < 0 then
SendSysMsg(UserWorldId,"������Ҫ������0Ԫ��,���Ԫ������", 10, "ϵͳ��ʾ")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ���������,����2����λ", 9, "ϵͳ��ʾ")
return 
end
SetPlayerRxpiont(UserWorldId,0,0)
DelItme(UserWorldId,weiz1,1)
DelItme(UserWorldId,weiz2,30)
AddItmeProp(UserWorldId,15,weizs[0],1,0,80000003,70000008,30000120,0,0,0,0,0)
SendSysMsg(UserWorldId,"��ϲ��������ħ�����ɹ�������30������+Ѫ�����", 10, "ϵͳ��ʾ")
end

if str1== "@������ħ����" then
local weiz1=GetPakItemNum(UserWorldId,100018,1)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"����Ѫ�������Ƿ������ﱳ��", 10, "ϵͳ��ʾ")
return 
end
local weiz2=GetPakItemNum(UserWorldId,900000619,30)
if weiz2==-1 then 
SendSysMsg(UserWorldId,"����30�������Ƿ������ﱳ��", 10, "ϵͳ��ʾ")
return 
end

local yb=GetRxpiont(UserWorldId)
if yb < 0 then
SendSysMsg(UserWorldId,"������Ҫ������0Ԫ��,���Ԫ������", 10, "ϵͳ��ʾ")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ���������,����2����λ", 9, "ϵͳ��ʾ")
return 
end
SetPlayerRxpiont(UserWorldId,0,0)
DelItme(UserWorldId,weiz1,1)
DelItme(UserWorldId,weiz2,30)
AddItmeProp(UserWorldId,100020,weizs[0],1,0,20000035,60000035,0,0,0,0,0,0)
SendSysMsg(UserWorldId,"��ϲ��������ħ�����ɹ�������30������+Ѫ������", 10, "ϵͳ��ʾ")
end


------------------------�����﹦�ܡ�------------------------------
if str1== "@�ֽ�ѩ��" then
local weiz1=GetPakItemNum(UserWorldId,1000001011,1)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"��������ѩ�ǵ��Ƿ������ﱳ��", 10, "ϵͳ��ʾ")
return 
end
local weiz2=GetPakItemNum(UserWorldId,1008000167,1)
if weiz2==-1 then 
SendSysMsg(UserWorldId,"����ֽ����Ƿ������ﱳ��", 10, "ϵͳ��ʾ")
return 
end

local yb=GetRxpiont(UserWorldId)
if yb < 0 then
SendSysMsg(UserWorldId,"�ٻ���Ҫ������0Ԫ��,���Ԫ������", 10, "ϵͳ��ʾ")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ���������,����2����λ", 9, "ϵͳ��ʾ")
return 
end
SetPlayerRxpiont(UserWorldId,0,0)
DelItme(UserWorldId,weiz1,1)
DelItme(UserWorldId,weiz2,1)
AddItmeProp(UserWorldId,1008001108,weizs[0],1,0,0,0,0,0,0,0,0,0)
SendSysMsg(UserWorldId,"��ϲ���ֽ�ѩ�ǳɹ�������ѩ��*1 �ֽ���*1���������ѩ�ǵ�*1", 10, "ϵͳ��ʾ")
end

if str1== "@�ֽ����" then
local weiz1=GetPakItemNum(UserWorldId,1000001378,1)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"�������޽��ǵ��Ƿ������ﱳ��", 10, "ϵͳ��ʾ")
return 
end
local weiz2=GetPakItemNum(UserWorldId,1008000167,1)
if weiz2==-1 then 
SendSysMsg(UserWorldId,"����ֽ����Ƿ������ﱳ��", 10, "ϵͳ��ʾ")
return 
end

local yb=GetRxpiont(UserWorldId)
if yb < 0 then
SendSysMsg(UserWorldId,"�ٻ���Ҫ������0Ԫ��,���Ԫ������", 10, "ϵͳ��ʾ")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ���������,����2����λ", 9, "ϵͳ��ʾ")
return 
end
SetPlayerRxpiont(UserWorldId,0,0)
DelItme(UserWorldId,weiz1,1)
DelItme(UserWorldId,weiz2,1)
AddItmeProp(UserWorldId,1008001375,weizs[0],1,0,0,0,0,0,0,0,0,0)
SendSysMsg(UserWorldId,"��ϲ���ֽ���ǳɹ������Ľ���*1 �ֽ���*1��������޽��ǵ�*1", 10, "ϵͳ��ʾ")
end

if str1== "@�ٻ�����" then
local weiz1=GetPakItemNum(UserWorldId,1008001108,10)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"��������ѩ�ǵ��Ƿ������ﱳ��", 10, "ϵͳ��ʾ")
return 
end
local weiz2=GetPakItemNum(UserWorldId,1008000166,1)
if weiz2==-1 then 
SendSysMsg(UserWorldId,"�������޵��Ƿ������ﱳ��", 10, "ϵͳ��ʾ")
return 
end

local yb=GetRxpiont(UserWorldId)
if yb < 0 then
SendSysMsg(UserWorldId,"�ٻ���Ҫ������0Ԫ��,���Ԫ������", 10, "ϵͳ��ʾ")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ���������,����2����λ", 9, "ϵͳ��ʾ")
return 
end
SetPlayerRxpiont(UserWorldId,0,0)
DelItme(UserWorldId,weiz1,10)
DelItme(UserWorldId,weiz2,1)
AddItmeProp(UserWorldId,1000001378,weizs[0],1,0,80000003,20000100,110000100,0,0,0,0,0)
SendSysMsg(UserWorldId,"��ϲ���ٻ����ǳɹ�����������ѩ�ǵ�*10 ���޵�*1", 10, "ϵͳ��ʾ")
end

if str1== "@�ٻ���ʨȮ" then
local weiz1=GetPakItemNum(UserWorldId,1008001375,3)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"�������޽��ǵ��Ƿ������ﱳ��", 10, "ϵͳ��ʾ")
return 
end
local weiz2=GetPakItemNum(UserWorldId,1008000166,3)
if weiz2==-1 then 
SendSysMsg(UserWorldId,"�������޵��Ƿ������ﱳ��", 10, "ϵͳ��ʾ")
return 
end

local yb=GetRxpiont(UserWorldId)
if yb < 0 then
SendSysMsg(UserWorldId,"�ٻ���Ҫ������15000Ԫ��,���Ԫ������", 10, "ϵͳ��ʾ")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ���������,����2����λ", 9, "ϵͳ��ʾ")
return 
end
SetPlayerRxpiont(UserWorldId,15000,0)
DelItme(UserWorldId,weiz1,3)
DelItme(UserWorldId,weiz2,3)
AddItmeProp(UserWorldId,1000001380,weizs[0],1,0,80000004,10000100,20000100,110000100,0,0,0,0)
SendSysMsg(UserWorldId,"��ϲ���ٻ���ʨȮ�ɹ����������޽��ǵ�*3 ���޵�*3", 10, "ϵͳ��ʾ")
end

-----���������ܡ�----------------------------------------------------------------------------

--����100����ѫ
if str1== "@����11100����ѫ" then
local Player = GetPlayer(UserWorldId)
if Player.Player_wuxun < 1000000 then
SendSysMsg(UserWorldId,"������Ҫ��ѫ100������,�����ѫ����", 10, "ϵͳ��ʾ")
return 
end
Player.Player_wuxun=Player.Player_wuxun-1000000
SetPlayerRxpiont(UserWorldId,500,1)
SendSysMsg(UserWorldId,"��ϲ��!���500Ԫ�� �򿪰ٱ����ѯ", 10, "ϵͳ��ʾ")
SendSysMsg(UserWorldId,"100����ѫ�ѱ�ϵͳ����;��С�˺�ȷ��!", 10, "ϵͳ��ʾ")
end

--���ղ���
if str1== "@����aaA" then
local weiz1=GetPakItmesx(UserWorldId,700022,0,70000013,10000040,40000005,0,0,0,0,0)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"�����ϻ���Ҫ��,������������ ", 9, "ϵͳ��ʾ")
return
end
local yb=GetRxpiont(UserWorldId)
if yb < 0 then
SendSysMsg(UserWorldId,"������Ҫ������0Ԫ��,���Ԫ������", 10, "ϵͳ��ʾ")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ���������,����2����λ", 9, "ϵͳ��ʾ")
return 
end
SetPlayerRxpiont(UserWorldId,0,0)
DelItme(UserWorldId,weiz1,1)
SetPlayerRxpiont(UserWorldId,100,1)
SendSysMsg(UserWorldId,"��ϲ�õ�100Ԫ��;������X10�Ȼ��ճɹ�@_@...", 10, "ϵͳ��ʾ")
end

if str1== "@����aaB" then
local weiz1=GetPakItmesx(UserWorldId,700022,0,70000013,10000040,40000005,0,0,0,0,0)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"�����ϻ���Ҫ��,������������ ", 9, "ϵͳ��ʾ")
return
end
local weiz2=GetPakItmesx(UserWorldId,16,0,80000003,70000010,30000150,0,0,0,0,0)
if weiz2==-1 then 
SendSysMsg(UserWorldId,"�����ϻ���Ҫ��,������������ ", 9, "ϵͳ��ʾ")
return
end
local weiz3=GetPakItmesx(UserWorldId,14,0,80000003,70000005,30000080,0,0,0,0,0)
if weiz3==-1 then 
SendSysMsg(UserWorldId,"�����ϻ���Ҫ��,������������ ", 9, "ϵͳ��ʾ")
return
end
local yb=GetRxpiont(UserWorldId)
if yb < 0 then
SendSysMsg(UserWorldId,"������Ҫ������0Ԫ��,���Ԫ������", 10, "ϵͳ��ʾ")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ���������,����2����λ", 9, "ϵͳ��ʾ")
return 
end
SetPlayerRxpiont(UserWorldId,0,0)
DelItme(UserWorldId,weiz1,1)
DelItme(UserWorldId,weiz2,1)
DelItme(UserWorldId,weiz3,1)
SetPlayerRxpiont(UserWorldId,100,1)
SendSysMsg(UserWorldId,"��ϲ�õ�100Ԫ��;������X10�Ȼ��ճɹ�@_@...", 10, "ϵͳ��ʾ")
end

if str1== "@����aaC" then
local weiz1=GetPakItemNum(UserWorldId,700022,1)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"����������������ﱳ��", 10, "ϵͳ��ʾ")
return 
end
SetPlayerRxpiont(UserWorldId,0,0)
DelItme(UserWorldId,weiz1,1)
SetPlayerRxpiont(UserWorldId,300,1)
SendSysMsg(UserWorldId,"����������׳ɹ�����ϲ�����300Ԫ��!!", 10, "ϵͳ��ʾ")
end

if str1== "@����aaD" then
--ͬ����װ��ֻ�ܻ���һ���������������Ҫ���ӣ����Լ��װ������[���]
local weiz1=GetPakItmesx(UserWorldId,100018,20000010,20000025,60000025,30000040,40000041,0,0,0,0)
if weiz1==-1 then 
SendSysMsg(UserWorldId,"�����ϻ���Ҫ��,������������ ", 9, "ϵͳ��ʾ")
return
end
local weiz2=GetPakItmesx(UserWorldId,14,30000010,80000003,70000005,30000080,40000082,0,0,0,0)
if weiz2==-1 then 
SendSysMsg(UserWorldId,"�����ϻ���Ҫ��,������������ ", 9, "ϵͳ��ʾ")
return
end
local weiz3=GetPakItmesx(UserWorldId,14,30000010,80000003,70000005,30000080,40000083,0,0,0,0)
if weiz3==-1 then 
SendSysMsg(UserWorldId,"�����ϻ���Ҫ��,������������ ", 9, "ϵͳ��ʾ")
return
end
local weiz4=GetPakItmesx(UserWorldId,700020,10000010,70000015,10000030,60000050,50000054,0,0,0,0)
if weiz4==-1 then 
SendSysMsg(UserWorldId,"�����ϻ���Ҫ��,������������ ", 9, "ϵͳ��ʾ")
return
end
local weiz5=GetPakItmesx(UserWorldId,700020,10000010,70000015,10000030,60000050,50000055,0,0,0,0)
if weiz5==-1 then 
SendSysMsg(UserWorldId,"�����ϻ���Ҫ��,������������ ", 9, "ϵͳ��ʾ")
return
end
local yb=GetRxpiont(UserWorldId)
if yb < 0 then
SendSysMsg(UserWorldId,"������Ҫ������0Ԫ��,���Ԫ������", 10, "ϵͳ��ʾ")
return 
end
local weizs=GetPackages(UserWorldId,2)
if weizs.Count< 2 then 
SendSysMsg(UserWorldId,"װ����û�п�λ�ˣ���������,����2����λ", 9, "ϵͳ��ʾ")
return 
end
SetPlayerRxpiont(UserWorldId,0,0)
DelItme(UserWorldId,weiz1,1)
DelItme(UserWorldId,weiz2,1)
DelItme(UserWorldId,weiz3,1)
DelItme(UserWorldId,weiz4,1)
DelItme(UserWorldId,weiz5,1)
SetPlayerRxpiont(UserWorldId,100,1)
SendSysMsg(UserWorldId,"��ϲ�õ�100Ԫ��;������X10�Ȼ��ճɹ�@_@...", 10, "ϵͳ��ʾ")
end
end