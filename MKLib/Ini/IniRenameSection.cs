using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public static partial class Ini
{

public static void IniRenameSection(string IniFile, string OldNameSection, string NewNameSection)
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
int SectionIndex = FileStrings.IndexOf(FileStrings.Where(S => S.Trim().Contains("["+OldNameSection+"]")).ToList()[0]);
if (SectionIndex == -1)
{
MKLib.CallDebugForm("Section not found.\r\n"+"File: "+IniFile+"\r\nSection: "+OldNameSection);
return;
}
FileStrings[SectionIndex] = "["+NewNameSection+"]";
File.WriteAllLines(IniFile, FileStrings);
}

}