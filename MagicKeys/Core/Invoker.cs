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
if (API.GetPluginClass() == "lua")
{
Result = LUAInvoke(Func, Param);
KeyReg();
return Result;
}
 Result = SystemInvoke(Func, Param);
KeyReg();
return Result;
}

}
}