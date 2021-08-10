using System;
using System.Reflection;

namespace MagicKeys
{

public partial class MagicKeys
{

public static string SystemInvoke(string InvokeFunc, string FuncParam = null)
{
try
{
Object Class = null;
object[] Param = null;
if (PluginClass.GetType().GetMethod(InvokeFunc) != null)
{
Class = PluginClass;
}
else if (SubClass.GetType().GetMethod(InvokeFunc) != null)
{
Class = SubClass;
}
else if (MKOBJ.GetType().GetMethod(InvokeFunc) != null)
{
Class = MKOBJ;
}
else
{
Speak(T._("Method {0} is not implemented", InvokeFunc));
return null;
}
if (FuncParam != null)
{
Param = new object[] {FuncParam};
}
MethodInfo Method = Class.GetType().GetMethod(InvokeFunc);
string Result = Method.Invoke(Class, Param) as string;
return Result;
}
catch(Exception ex)
{
MKDebugForm("ExceptionHook|"+ex.ToString());
return null;
}
}

}
}