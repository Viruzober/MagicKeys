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
List<string> VUFValues = Ini.IniReadValues(API.GetVUIPath()+API.GetVUI().Substring(0, API.GetVUI().Length - 4)+".vuf", API.GetFunc());
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