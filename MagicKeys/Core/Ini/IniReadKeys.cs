using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using static System.Collections.Specialized.BitVector32;
using System.Windows.Forms;

namespace MagicKeys
{

public static partial class Ini
{

public static List<string> IniReadKeys(string IniFile, string Section)
{
Regex RGX = new Regex(@"=(?!=)");
if (File.Exists(IniFile) == false) return null;
 List<string> FileStrings = File.ReadAllLines(IniFile).ToList();
int IndexStartSection = FileStrings.IndexOf(FileStrings.Where(S => S.Trim().Contains("["+Section+"]")).ToList()[0]);
FileStrings.RemoveRange(0, IndexStartSection+1);
FileStrings = FileStrings.TakeWhile(s => s.Trim().StartsWith("[") == false || s.Trim().EndsWith("]") == false).SkipWhile(t => string.IsNullOrEmpty(t) == true).ToList();
List<string> Keys = FileStrings.Select(s => RGX.Split(s.Trim())[0].Trim()).ToList();
return Keys;
}

}
}