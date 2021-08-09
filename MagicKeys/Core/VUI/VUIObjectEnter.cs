using System.Collections.Generic;

namespace MagicKeys
{

public partial class MagicKeys
{

public static void VUIObjectEnter()
{
KeyUnReg();
if (API.GetActiveClass() == "lua")
{
LUAInvoke(API.GetFunc("Func"), API.GetParam("Func"));
KeyReg();
return;
}
if (API.GetActiveClass() == "MagicKeys")
{
List<string> Funcs = Ini.IniReadKeys(API.GetCurrentScript(), API.GetFunc("Func"));
List<string> Params = Ini.IniReadValues(API.GetCurrentScript(), API.GetFunc("Func"));
VUFInvoke(Funcs, Params);
KeyReg();
return;
}
if (API.GetParam("Func") == null)
{
InvokeFromString(API.GetFunc("Func"));
KeyReg();
return;
}
InvokeFromString(API.GetFunc("Func"), API.GetParam("Func"));
KeyReg();
}

}
}