using static MKLib;
using System;
using System.Collections.Generic;

namespace MagicKeys
{
public partial class MagicKeys
{

public static void Invoker(string Func, string Param)
{
KeyUnReg();
if (API.GetPluginClass() == "lua")
{
LUAInvoke(Func, Param);
KeyReg();
return;
}
 SystemInvoke(Func, Param);
KeyReg();
}

}
}