using System;
using System.Collections.Generic;

namespace MagicKeys
{
public partial class MagicKeys
{

public static string Invoker(string Func, string Param = null)
{
KeyUnReg();
string Resulte;
if (API.GetActiveClass() == "lua")
{
Resulte = LUAInvoke(Func, Param);
KeyReg();
return Resulte;
}
if (API.GetActiveClass() == "MagicKeys")
{
List<string> VUFFuncs = Ini.IniReadKeys(API.GetCurrentScript(), Func);
List<string> VUFParams = Ini.IniReadValues(API.GetCurrentScript(), Func);
Resulte = VUFInvoke(VUFFuncs, VUFParams);
KeyReg();
return Resulte;
}
 Resulte = SystemInvoke(Func, Param);
KeyReg();
return Resulte;
}

}
}