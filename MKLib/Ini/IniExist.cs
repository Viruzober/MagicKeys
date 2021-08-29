using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


public static partial class Ini
{

public static bool IniSectionExists(string IniFile, string Section)
{
List<string> temp = IniReadSections(IniFile);
bool Exists = temp.Contains(Section, StringComparer.OrdinalIgnoreCase);
return Exists;
}

public static bool IniKeyExists(string IniFile, string Section, string Key)
{
List<string> temp = IniReadKeys(IniFile, Section);
bool Exists = temp.Contains(Key, StringComparer.OrdinalIgnoreCase);
return Exists;
}

}