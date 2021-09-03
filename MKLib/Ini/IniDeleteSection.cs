using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public static partial class Ini
{

public static void IniDeleteSection(string IniFile, string Section)
{
if (File.Exists(IniFile) == false)
{
MKLib.CallDebugForm("File not found.\r\n"+"File: "+IniFile);
return;
}
 List<string> FileStrings = File.ReadAllLines(IniFile).ToList();
if (FileStrings.Any() == false)
{
MKLib.CallDebugForm("File is empty.\r\n"+"File: "+IniFile);
return;
}
int SectionIndex = FileStrings.IndexOf(FileStrings.Where(S => S.Trim().Contains("["+Section+"]")).ToList()[0]);
if (SectionIndex == -1)
{
MKLib.CallDebugForm("Section not found.\r\n"+"File: "+IniFile+"\r\nSection: "+Section);
return;
}
List<string> RangeSectionKeys = FileStrings.GetRange(SectionIndex, FileStrings.Count - SectionIndex);
RangeSectionKeys.RemoveAt(0);
List<string> RangeKeys = RangeSectionKeys.TakeWhile(s => s.Trim().StartsWith("[") == false | s.Trim().EndsWith("]") == false).ToList();
FileStrings.RemoveRange(SectionIndex, RangeKeys.Count + 1);
File.WriteAllLines(IniFile, FileStrings);
}

}