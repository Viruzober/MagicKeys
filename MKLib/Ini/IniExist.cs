using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


public static partial class Ini
{

public static bool IniSectionExists(string IniFile, string Section)
{
if (File.Exists(IniFile) == false) return false;
 List<string> FileStrings = File.ReadAllLines(IniFile).ToList();
List<string> Sections = FileStrings.Where(s => s.Trim().Contains("[") || s.Trim().Contains("]")).Select(t => t.Trim(new char[] {'[', ']'})).ToList();
if (Sections.Contains(Section) == true)
{
return true;
}
return false;
}

public static bool IniKeyExists(string IniFile, string Section, string Key)
{
if (File.Exists(IniFile) == false)
{
MKLib.CallDebugForm("File not found.\r\n"+"File: "+IniFile);
return false;
}
 List<string> FileStrings = File.ReadAllLines(IniFile).ToList();
if (FileStrings.Any() == false)
{
MKLib.CallDebugForm("File is empty.\r\n"+"File: "+IniFile);
return false;
}
int SectionIndex = FileStrings.IndexOf(FileStrings.Where(S => S.Trim().Contains("["+Section+"]")).ToList()[0]);
if (SectionIndex == -1)
{
MKLib.CallDebugForm("Section not found.\r\n"+"File: "+IniFile+"\r\nSection: "+Section);
return false;
}
FileStrings.RemoveRange(0, SectionIndex+1);
FileStrings = FileStrings.TakeWhile(s => s.Trim().StartsWith("[") == false || s.Trim().EndsWith("]") == false).SkipWhile(t => string.IsNullOrEmpty(t) == true || CommentRGX.IsMatch(t) == true).ToList();
List<string> Keys = FileStrings.Select(s => SplitRgx.Split(s.Trim())[0].Trim()).ToList();
if (Keys.Any() == false)
{
return false;
}
else if (Keys.Contains(Key) == false)
{
return false;
}
else
{
return true;
}
}

}