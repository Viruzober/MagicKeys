using System;
using System.Reflection;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static MagicKeys MK = new MagicKeys();

public static string InvokeFromString(string InvokeFunc, string FuncParam = null)
{
KeyUnReg();
Type Class =Type.GetType(PluginsList[0]["PClass"]);
MethodInfo Method;
object[] Param;
if ((Method = Class.GetMethod(InvokeFunc)) == null && PluginsList[0]["BClass"] != "None")
{
Class = Type.GetType(PluginsList[0]["BClass"]);
Method = Class.GetMethod(InvokeFunc);
}
if (Method == null)
{
Speak("Метод "+InvokeFunc+" не реализован");
KeyReg();
return null;
}
if (FuncParam != null)
{
Param = new object[] {FuncParam};
}
else
{
Param = new object[] {};
}
string Result = Method.Invoke(MK, Param) as string;
KeyReg();
return Result;
}

}
}