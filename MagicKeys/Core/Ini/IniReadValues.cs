using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace MagicKeys
{
public static partial class Ini
{
public static List<string> IniReadValues(string File, string Section)
{
List<string> Temp = new List<string>();
List<string> Keys = IniReadKeys(@File, Section);
for(int I = 0; I <= Keys.Count-1; I++)
{
Temp.Add(IniRead(@File, Section, Keys[I]));
}
return Temp;
}
}
}