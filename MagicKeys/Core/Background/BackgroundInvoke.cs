using System;
using System.Threading;

namespace MagicKeys
{
public partial class MagicKeys
{
public static Thread BackgroundThread = new Thread(new ParameterizedThreadStart(BackgroundFuncThread));
public static void BackgroundInvoke(BackgroundFuncObject ParamsObject)
{
BackgroundThread = new Thread(new ParameterizedThreadStart(BackgroundFuncThread));
ThreadFunc = ParamsObject.Func+","+Guid.NewGuid().ToString();
BackgroundThread.Name = ThreadFunc;
BackgroundThread.Start(ParamsObject);
}

}
}