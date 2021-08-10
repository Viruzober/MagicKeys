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
Invoker(BFObj.Func, BFObj.Params);
}
}
else
{
while(Thread.CurrentThread.Name == ThreadFunc)
{
Invoker(BFObj.Func, BFObj.Params);
}
}
}

}
}