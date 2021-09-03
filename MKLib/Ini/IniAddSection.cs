using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public static partial class Ini
{

public static void IniAddSection(string IniFile, string Section)
{
if (File.Exists(IniFile) == false)
{
MKLib.CallDebugForm("File not found.\r\n"+"File: "+IniFile);
return;
}
 List<string> FileStrings = File.ReadAllLines(IniFile).ToList();
List<string> CheckSection = FileStrings.Where(s => s.Contains("["+Section+"]")).ToList();
if (CheckSection.Any() == true)
{
MKLib.CallDebugForm("Section already exists\r\n"+"File: "+IniFile);
return;
}
FileStrings.Add("["+Section+"]");
File.WriteAllLines(IniFile, FileStrings);
}

}