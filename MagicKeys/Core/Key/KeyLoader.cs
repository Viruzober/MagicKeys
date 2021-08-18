using System;
using System.Linq;
using Microsoft.Collections.Extensions;
using System.Collections.Generic;
using static MKLib;

namespace MagicKeys
{

public partial class MagicKeys
{

public static OrderedDictionary<string, string> VUIKeys = new OrderedDictionary<string, string>();
public static KeyWNDProc KeyWndProcHandle = new KeyWNDProc();
public static KeyInfo PluginKeyRegInfo = new KeyInfo();
public static void KeyLoader()
{
if (Ini.IniSectionExists(API.GetCurrentVUI(), "Keys") == true)
{
List<string> Keys = Ini.IniReadKeys(API.GetCurrentVUI(), "Keys");
List<string> Values = Ini.IniReadValues(API.GetCurrentVUI(), "Keys");
for(int I = 0; I <= Keys.Count-1; I++)
{
VUIKeys.Add(Keys[I], Values[I]);
}
}
var AllKeys = GetOptionKeys().Concat(VUIKeys).ToDictionary(x=>x.Key, x=>x.Value).Keys.ToList();
PluginKeyRegInfo.WNDProcHandle = KeyWndProcHandle.Handle;
PluginKeyRegInfo.KeyList = AllKeys;
SetKeyRegContext(PluginKeyRegInfo);
}

}
}