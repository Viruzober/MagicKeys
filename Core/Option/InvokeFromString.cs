using System;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static string InvokeFromString(string InvokeFunc)
{
MagicKeys MK = new MagicKeys();
var method = Type.GetType(PluginClass).GetMethod(InvokeFunc);
object[] FuncParam = new object[] {};
if (VUIFile != string.Empty)
{
if (VUIObjects[ActiveObjects[Section]].ContainsKey("Ptr") == true)
{
string Ptr = VUIObjects[ActiveObjects[Section]]["Ptr"];
FuncParam = new object[] {Ptr};
}
}
string result = method.Invoke(MK, FuncParam) as string;
return result;
}

public static string InvokeFromString(string InvokeClass, string InvokeFunc)
{
MagicKeys MK = new MagicKeys();
var method = Type.GetType(InvokeClass).GetMethod(InvokeFunc);
object[] FuncParam = new object[] {};
if (VUIFile != string.Empty)
{
if (VUIObjects[ActiveObjects[Section]].ContainsKey("Ptr") == true)
{
string Ptr = VUIObjects[ActiveObjects[Section]]["Ptr"];
FuncParam = new object[] {Ptr};
}
}
string result = method.Invoke(MK, FuncParam) as string;
return result;
}

}
}