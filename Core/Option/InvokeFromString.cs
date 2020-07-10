using System;
using System.Reflection;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static MagicKeys MK = new MagicKeys();

public static string InvokeFromString(string InvokeFunc, string FuncPtr = null)
{
Type Class = Type.GetType(PluginsList[0]["PClass"]);
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
object[] FuncParam = {};
if (FuncPtr != null)
{
FuncParam = new object[] {FuncPtr};
}
string Result = Method.Invoke(MK, FuncParam) as string;
return Result;
}

}
}