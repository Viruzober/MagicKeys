using static MKLib;
using System;
using System.Collections.Generic;

namespace MagicKeys
{
public partial class MagicKeys
{

public static string Invoker(string Func, string Param = null)
{
KeyUnReg();
string Result;
if (API.GetActiveClass() == "lua")
{
Result = LUAInvoke(Func, Param);
KeyReg();
return Result;
}
if (API.GetActiveClass() == "MagicKeys")
{
List<string> VUFFuncs = Ini.IniReadKeys(API.GetCurrentScript(), Func);
List<string> VUFParams = Ini.IniReadValues(API.GetCurrentScript(), Func);
Result = VUFInvoke(VUFFuncs, VUFParams);
KeyReg();
return Result;
}
 Result = SystemInvoke(Func, Param);
KeyReg();
return Result;
}

}
}