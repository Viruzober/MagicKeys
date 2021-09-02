using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using static System.Collections.Specialized.BitVector32;
using System.Windows.Forms;
using CoreAudio;

public static partial class Ini
{

public static List<string> IniReadKeys(string IniFile, string Section)
{
if (File.Exists(IniFile) == false)
{
MKLib.CallDebugForm("File not found.\r\n"+"File: "+IniFile);
return null;
}
 List<string> FileStrings = File.ReadAllLines(IniFile).ToList();
if (FileStrings.Any() == false)
{
MKLib.CallDebugForm("File is empty.\r\n"+"File: "+IniFile);
return null;
}
int SectionIndex = FileStrings.IndexOf(FileStrings.Where(S => S.Trim().Contains("["+Section+"]")).ToList()[0]);
if (SectionIndex == -1)
{
MKLib.CallDebugForm("Section not found.\r\n"+"File: "+IniFile+"\r\nSection: "+Section);
return null;
}
FileStrings.RemoveRange(0, SectionIndex+1);
FileStrings = FileStrings.TakeWhile(s => s.Trim().StartsWith("[") == false || s.Trim().EndsWith("]") == false).SkipWhile(t => string.IsNullOrEmpty(t) == true || CommentRGX.IsMatch(t) == true).ToList();
List<string> Keys = FileStrings.Select(s => SplitRgx.Split(s.Trim())[0].Trim()).ToList();
if (Keys.Any() == false)
{
MKLib.CallDebugForm("Keys not found.\r\n"+"File: "+IniFile+"\r\nSection: "+Section);
return null;
}
return Keys;
}

}