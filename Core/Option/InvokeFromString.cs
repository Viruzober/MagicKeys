using System;
using System.Reflection;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static MagicKeys MK = new MagicKeys();

public static string InvokeFromString(string InvokeFunc, string FuncParam = null)
{
Type Class =Type.GetType(PluginsList[0]["PClass"]);
if (Class.GetMethod(InvokeFunc) == null && PluginsList[0]["BClass"] != "None")
{
Class = Type.GetType(PluginsList[0]["BClass"]);
}
MethodInfo Method = Class.GetMethod(InvokeFunc);
if (Method == null)
{
Speak("Метод "+InvokeFunc+" не реализован");
return "";
}
object[] Param = {};
if (FuncParam != null)
{
Param = new object[] {FuncParam};
}
string Result = Method.Invoke(MK, Param) as string;
return Result;
}

}
}