using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

public static partial class Ini
{

public static List<string> IniReadValues(string IniFile, string Section)
{
if (File.Exists(IniFile) == false) return null;
 List<string> FileStrings = File.ReadAllLines(IniFile).ToList();
int IndexStartSection = FileStrings.IndexOf(FileStrings.Where(S => S.Trim().Contains("["+Section+"]")).ToList()[0]);
FileStrings.RemoveRange(0, IndexStartSection+1);
FileStrings = FileStrings.TakeWhile(s => s.Trim().StartsWith("[") == false || s.Trim().EndsWith("]") == false).SkipWhile(t => string.IsNullOrEmpty(t) == true || CommentRGX.IsMatch(t) == true).ToList();
List<string> Keys = FileStrings.Select(s => SplitRgx.Split(s.Trim())[1].Trim()).ToList();
return Keys;
}

}