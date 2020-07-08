using System;
using System.Reflection;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static string InvokeFromString(string InvokeFunc, string FuncPtr = null)
{
MagicKeys MK = new MagicKeys();
var Class = Type.GetType(PluginsList[0]["PClass"]);
MethodInfo method;
if (Class.GetMethod(InvokeFunc) == null)
{
Class = Type.GetType(PluginsList[0]["BClass"]);
method = Class.GetMethod(InvokeFunc);
}
else
{
method = Class.GetMethod(InvokeFunc);
}
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