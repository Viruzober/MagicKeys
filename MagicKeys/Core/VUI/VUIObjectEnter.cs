using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace MagicKeys
{
public partial class MagicKeys
{
public static void VUIObjectEnter()
{
KeyUnReg();
if (API.GetPluginClass() == "MagicKeys" | API.GetSubClass() == "MagicKeys")
{
List<string> Funcs = Ini.IniReadKeys(API.GetCurrentVUF(), API.GetFunc());
List<string> Params = Ini.IniReadValues(API.GetCurrentVUF(), API.GetFunc());
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