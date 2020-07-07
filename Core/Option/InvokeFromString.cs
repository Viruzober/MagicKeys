using System;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static string InvokeFromString(string InvokeFunc, string FuncPtr = null)
{
MagicKeys MK = new MagicKeys();
var method = Type.GetType(PluginsList[0]["PClass"]).GetMethod(InvokeFunc);
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