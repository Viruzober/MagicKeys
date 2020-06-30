using System;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static string InvokeFromString(string InvokeFunc)
{
MagicKeys MK = new MagicKeys();
var method = Type.GetType(PluginClass).GetMethod(InvokeFunc);
if (Ini.IniKeyExists(IniFile, ActiveObjects[Section].ToString(), "Ptr"))
{
string Ptr = Ini.IniReadStr(IniFile, ActiveObjects[Section].ToString(), "Ptr");
object[] FuncParam = new object[] {Ptr};
string result = method.Invoke(MK, FuncParam) as string;
return result;
}
else
{
object[] FuncParam = new object[] {};
string result = method.Invoke(MK, FuncParam) as string;
return result;
}
}

}
}