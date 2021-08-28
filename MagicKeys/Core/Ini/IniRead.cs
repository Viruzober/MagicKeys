using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace MagicKeys
{

public static partial class Ini
{

public static string IniRead(string IniFile, string Section, string Key)
{
if (File.Exists(IniFile) == false) return null;
 List<string> FileStrings = File.ReadAllLines(IniFile).ToList();
int IndexStartSection = FileStrings.IndexOf(FileStrings.Where(S => S.Contains(Section)).ToList()[0]);
FileStrings.RemoveRange(0, IndexStartSection+1);
FileStrings = FileStrings.TakeWhile(s => s.Trim().StartsWith("[") == false || s.Trim().EndsWith("]") == false || s.Trim().StartsWith("#") == false).ToList();
string KeyValue = FileStrings.Where(s => s.Trim().StartsWith(Key)).ToList()[0].Trim();
string Value = KeyValue.Remove(0, Key.Length).Trim().Split("=", 2)[1].Trim();
return Value;
}

}
}