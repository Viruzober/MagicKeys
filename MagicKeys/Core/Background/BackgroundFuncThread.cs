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
InvokeFromString(BFObj.Func, BFObj.Params);
Thread.Sleep(1000);
}
}
else
{
while(Thread.CurrentThread.Name == ThreadFunc)
{
InvokeFromString(BFObj.Func, BFObj.Params);
Thread.Sleep(1000);
}
}
}

}
}