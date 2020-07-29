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
if (Ini.IniSectionExists(API.GetVUIPath()+API.GetVUIExt(), "Keys") == true)
{
List<string> KeyList = Ini.IniReadKeys(API.GetVUIPath()+API.GetVUIExt(), "Keys");
for(int I = 0; I <= KeyList.Count-1; I++)
{
VUIKeys.Add(KeyList[I], Ini.IniRead(API.GetVUIPath()+API.GetVUIExt(), "Keys", KeyList[I]));
}
}
else
{
VUIKeys.Add("None", "None");
}
}

}
}