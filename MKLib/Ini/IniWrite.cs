using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public static partial class Ini
{

public static void IniWrite(string IniFile, string Section, string Key, string Value)
{
if (File.Exists(IniFile) == false)
{
MKLib.CreateFile(IniFile);
}
List<string> AllFileStrings = File.ReadAllLines(IniFile).ToList();
if (AllFileStrings.Any() == false)
{
AllFileStrings.Add("["+Section+"]");
AllFileStrings.Add(Key+"="+Value);
File.WriteAllLines(IniFile, AllFileStrings);
return;
}
if (AllFileStrings.Contains("["+Section+"]") == false)
{
AllFileStrings.Add("["+Section+"]");
AllFileStrings.Add(Key+"="+Value);
File.WriteAllLines(IniFile, AllFileStrings);
return;
}
int SectionIndex = AllFileStrings.IndexOf(AllFileStrings.Where(t => t.Contains("["+Section+"]")).ToList()[0]);
List<string> RangeSectionKeys = AllFileStrings.GetRange(SectionIndex, AllFileStrings.Count - SectionIndex);
RangeSectionKeys.RemoveAt(0);
List<string> RangeKeys = RangeSectionKeys.TakeWhile(s => s.Trim().StartsWith("[") == false || s.Trim().EndsWith("]") == false).SkipWhile(t => string.IsNullOrEmpty(t) == true || CommentRGX.IsMatch(t) == true).ToList();
if (RangeKeys.Any() == false)
{
AllFileStrings.Insert(SectionIndex+1, Key+"="+Value);
File.WriteAllLines(IniFile, AllFileStrings);
return;
}
List<string> CheckKey = RangeKeys.Where(k => SplitRgx.Split(k.Trim())[0].Trim() == Key).ToList();
if (CheckKey.Any() == false)
{
AllFileStrings.Insert(SectionIndex + RangeSectionKeys.Count + 1, Key+"="+Value);
File.WriteAllLines(IniFile, AllFileStrings);
return;
}
int KeyIndex = RangeSectionKeys.IndexOf(RangeSectionKeys.Where(k => SplitRgx.Split(k.Trim())[0].Trim() == Key).ToList()[0]);
RangeSectionKeys[KeyIndex] = Key+"="+Value;
AllFileStrings.RemoveRange(SectionIndex+1, RangeSectionKeys.Count);
AllFileStrings.InsertRange(SectionIndex+1, RangeSectionKeys);
File.WriteAllLines(IniFile, AllFileStrings);
}

}