using System;
using System.Reflection;
using System.Linq;
using static MKLib;

namespace MagicKeys
{

public partial class MagicKeys
{

public static void SystemInvoke(string Func, string Param)
{
try
{
var CheckMethod = PluginClass.GetType().GetMethods().Select(m => m.Name).Where(n => n == Func).ToList();
if (CheckMethod.Any() == false)
{
Speak(T._("Method {0} is not implemented", Func));
return;
}
MethodInfo Method = PluginClass.GetType().GetMethod(Func);
object[] ParamsObjects = null;
if (string.IsNullOrEmpty(Param) == true)
{
Method.Invoke(PluginClass, ParamsObjects);
return;
}
ParamsObjects = new object[] {Param};
Method.Invoke(PluginClass, ParamsObjects);
return;
}
catch(Exception ex)
{
MKDebugForm(ex.ToString());
return;
}
}

}
}