using CoreAudio;
using System;
using System.Threading;

namespace MagicKeys
{
public partial class MagicKeys
{

public static void BackgroundFuncThread(object Params)
{
BackgroundFuncObject BFObj = (BackgroundFuncObject)Params;
if (BFObj.AutoFunc == true)
{
while(Thread.CurrentThread.Name == ThreadFunc)
{
if (BFObj.ObjectName != API.GetNameCurrentObject()) return;
if (API.GetActiveClass() == "lua")
{
LUAInvoke(BFObj.Func, BFObj.Params);
}
else
{
SystemInvoke(BFObj.Func, BFObj.Params);
}
if (BFObj.ObjectName != API.GetNameCurrentObject()) return;
}
}
else
{
while(Thread.CurrentThread.Name == ThreadFunc)
{
if (API.GetActiveClass() == "lua")
{
LUAInvoke(BFObj.Func, BFObj.Params);
}
else
{
SystemInvoke(BFObj.Func, BFObj.Params);
}
}
}
}

}
}