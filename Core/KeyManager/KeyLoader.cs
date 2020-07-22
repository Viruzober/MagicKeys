using System;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Collections.Generic;

namespace MagicKeys
{
public partial class MagicKeys
{
public static Dictionary<string, string> VUIKeys = new Dictionary<string, string>();
public static void KeyLoader()
{
if (Ini.IniSectionExists(@"VUI\"+API.GetVUI(), "Keys") == true)
{
List<string> KeyList = Ini.IniReadKeys(@"VUI\"+API.GetVUI(), "Keys");
for(int I = 0; I <= KeyList.Count-1; I++)
{
VUIKeys.Add(KeyList[I], Ini.IniRead(@"VUI\"+API.GetVUI(), "Keys", KeyList[I]));
}
}
}

}
}