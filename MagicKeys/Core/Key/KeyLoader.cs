using System;
using System.IO;
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
if (Ini.IniSectionExists(API.GetCurrentVUI(), "Keys") == true)
{
List<string> KeyList = Ini.IniReadKeys(API.GetCurrentVUI(), "Keys");
for(int I = 0; I <= KeyList.Count-1; I++)
{
VUIKeys.Add(KeyList[I], Ini.IniRead(API.GetCurrentVUI(), "Keys", KeyList[I]));
}
}
}
}
}