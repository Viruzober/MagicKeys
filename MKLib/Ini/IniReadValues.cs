using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

public static partial class Ini
{

public static List<string> IniReadValues(string IniFile, string Section)
{
if (File.Exists(IniFile) == false)
{
MKLib.CallDebugForm("File not found.\r\n"+"File: "+IniFile);
return  new List<string>();
}
 List<string> FileStrings = File.ReadAllLines(IniFile).ToList();
if (FileStrings.Any() == false)
{
MKLib.CallDebugForm("File is empty.\r\n"+"File: "+IniFile);
return  new List<string>();
}
int SectionIndex = FileStrings.IndexOf(FileStrings.Where(S => S.Trim().Contains("["+Section+"]")).ToList()[0]);
if (SectionIndex == -1)
{
MKLib.CallDebugForm("Section not found.\r\n"+"File: "+IniFile+"\r\nSection: "+Section);
return  new List<string>();
}
FileStrings.RemoveRange(0, SectionIndex+1);
FileStrings = FileStrings.TakeWhile(s => s.Trim().StartsWith("[") == false || s.Trim().EndsWith("]") == false).SkipWhile(t => string.IsNullOrEmpty(t) == true || CommentRGX.IsMatch(t) == true).ToList();
List<string> Values = FileStrings.Select(s => SplitRgx.Split(s.Trim())[1].Trim()).ToList();
if (Values.Any() == false)
{
MKLib.CallDebugForm("Values not found.\r\n"+"File: "+IniFile+"\r\nSection: "+Section);
return  new List<string>();
}
return Values;
}

}