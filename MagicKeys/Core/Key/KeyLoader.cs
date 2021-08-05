using Microsoft.Collections.Extensions;

using System.Collections.Generic;

namespace MagicKeys
{

public partial class MagicKeys
{

public static OrderedDictionary<string, string> VUIKeys = new OrderedDictionary<string, string>();
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
}

}
}