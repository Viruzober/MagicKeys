using System;
using System.Threading;

namespace MagicKeys
{
public partial class MagicKeys
{

public static void BackgroundFuncThread(object InvokeBackgroundFunc)
{
BackgroundFuncContainer TempBackgroundFunc = (BackgroundFuncContainer)InvokeBackgroundFunc;
while(Thread.CurrentThread.Name == ThreadFunc)
{
if (TempBackgroundFunc.CallMethod == BackgroundCallMethod.VUIObject)
{
if (TempBackgroundFunc.CallName != API.GetNameCurrentObject()) return;
}
if (API.GetPluginClass() == "lua")
{
LUAInvoke(TempBackgroundFunc.Func, TempBackgroundFunc.Param);
}
else
{
SystemInvoke(TempBackgroundFunc.Func, TempBackgroundFunc.Param);
}
if (TempBackgroundFunc.CallMethod == BackgroundCallMethod.VUIObject)
{
if (TempBackgroundFunc.CallName != API.GetNameCurrentObject()) return;
}
}
}

}
}