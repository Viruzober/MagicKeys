using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MagicKeys
{

public static partial class Ini
{

public static bool IniFileExists(string ExistsFile)
{
return File.Exists(ExistsFile);
}

public static bool IniSectionExists(string File, string Section)
{
List<string> temp = new List<string>();
temp = IniReadSections(File);
bool x = temp.Contains(Section, StringComparer.OrdinalIgnoreCase);
temp.Clear();
return x;
}

public static bool IniKeyExists(string File, string Section, string Key)
{
List<string> temp = new List<string>();
temp = IniReadKeys(File, Section);
bool x = temp.Contains(Key, StringComparer.OrdinalIgnoreCase);
temp.Clear();
return x;
}

}
}