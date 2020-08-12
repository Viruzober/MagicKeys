using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static void VUIObjectEnter()
{
if (API.GetPClass() == "MagicKeys")
{
List<string> VUFValues = Ini.IniReadValues(API.GetVUIPath()+API.GetVUI()+".vuf", API.GetFunc());
VUFInvoke(VUFValues);
return;
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