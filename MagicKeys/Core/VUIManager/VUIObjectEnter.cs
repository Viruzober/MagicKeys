using System;
using System.Collections.Generic;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static void VUIObjectEnter()
{
if (API.GetPClass() == "MagicKeys")
{
List<string> VUFValues = Ini.IniReadValues(API.GetVUIPath()+API.GetVUIExt().Substring(0, API.GetVUIExt().Length - 4)+".vuf", API.GetFunc());
VUFInvoke(VUFValues);
}
if (API.GetParam() == null)
{
InvokeFromString(API.GetFunc());
return;
}
InvokeFromString(API.GetFunc(), API.GetParam());
}

}
}