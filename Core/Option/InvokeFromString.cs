using System;
using System.Reflection;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static MagicKeys MK = new MagicKeys();

public static string InvokeFromString(string InvokeFunc, string FuncPtr = null)
{
Type cls = Type.GetType(PluginsList[0]["PClass"]);
if (cls.GetMethod(InvokeFunc) == null && PluginsList[0]["BClass"] != "None")
{
cls = Type.GetType(PluginsList[0]["BClass"]);
}
if (cls.GetMethod(InvokeFunc) == null)
{
Speak("Метод "+InvokeFunc+" не реализован");
return "";
}
MethodInfo method = cls.GetMethod(InvokeFunc);
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