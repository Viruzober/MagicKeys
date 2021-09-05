using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public static partial class Ini
{
private static Regex SplitRgx = new Regex(@"=(?!=)");
private static Regex CommentRGX = new Regex(@"^[;#]");

public static string IniRead(string IniFile, string Section, string Key)
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
FileStrings = FileStrings.TakeWhile(s => s.Trim().StartsWith("[") == false | s.Trim().EndsWith("]") == false | s.Trim().StartsWith("#") == false).SkipWhile(t => string.IsNullOrEmpty(t) == true || CommentRGX.IsMatch(t) == true).ToList();
string KeyValue = FileStrings.Where(s => s.Trim().StartsWith(Key)).ToList()[0].Trim();
if (string.IsNullOrEmpty(KeyValue) == true)
{
MKLib.CallDebugForm("Key not found.\r\n"+"File: "+IniFile+"\r\nSection: "+Section+"\r\nKey: "+Key);
return null;
}
string Value = SplitRgx.Split(KeyValue)[1].Trim();
if (string.IsNullOrEmpty(Value) == true)
{
MKLib.CallDebugForm("Value not found.\r\n"+"File: "+IniFile+"\r\nSection: "+Section+"\r\nKey: "+Key);
return null;
}
return Value;
}

}