using System;
using System.Collections.Generic;
namespace MagicKeys
{
public partial class MagicKeys
{
public static void ParamsLoader()
{
if (Ini.IniSectionExists(API.GetCurrentVUI(), "Params") == true)
{
List<string> Keys = Ini.IniReadKeys(API.GetCurrentVUI(), "Params");
List<string> Values = Ini.IniReadValues(API.GetCurrentVUI(), "Params");
for(int I = 0; I <= Keys.Count-1; I++)
{
CurrentPlugin[Keys[I]] = Values[I];
}
}
}
}
}