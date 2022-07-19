using System;
using System.Linq;
using System.Collections.Generic;
using static MKLib;

namespace MagicKeys
{

public partial class MagicKeys
{

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
VUIKeyFuncContainer TempKeyFunc = new VUIKeyFuncContainer();
TempKeyFunc.Key = Keys[I];
TempKeyFunc.Function = FunctionParser(Values[I]);
VUIKeysFunctions.Add(TempKeyFunc);
}
}
var AllKeys = VUIKeysFunctions.Concat(GetPluginOptionKeys()).ToList();
PluginKeyRegInfo.WNDProcHandle = KeyWndProcHandle.Handle;
PluginKeyRegInfo.KeyList = AllKeys.Select(k => k.Key).ToList();
SetKeyRegContext(PluginKeyRegInfo);
}

}
}