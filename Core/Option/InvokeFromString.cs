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
MethodInfo method;
if (Class.GetMethod(InvokeFunc) == null)
{
if (PluginsList[0]["BClass"] != "None")
{
Class = Type.GetType(PluginsList[0]["BClass"]);
}
else
{
Speak("Этот метод не реализован");
return "";
}
}
if (Class.GetMethod(InvokeFunc) == null)
{
Speak("Этот метод не реализован");
return "";
}
method = Class.GetMethod(InvokeFunc);
object[] FuncParam = new object[] {};
if (FuncPtr != null)
{
string Ptr = FuncPtr;
FuncParam = new object[] {Ptr};
}
string result = method.Invoke(MK, FuncParam) as string;
return result;
}

}
}