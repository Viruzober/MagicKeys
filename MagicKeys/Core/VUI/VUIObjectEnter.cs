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
LUAInvoke(API.GetFunc(), API.GetParam());
KeyReg();
return;
}
if (API.GetActiveClass() == "MagicKeys")
{
List<string> Funcs = Ini.IniReadKeys(API.GetCurrentScript(), API.GetFunc());
List<string> Params = Ini.IniReadValues(API.GetCurrentScript(), API.GetFunc());
VUFInvoke(Funcs, Params);
KeyReg();
return;
}
if (API.GetParam() == null)
{
InvokeFromString(API.GetFunc());
KeyReg();
return;
}
InvokeFromString(API.GetFunc(), API.GetParam());
KeyReg();
}

}
}