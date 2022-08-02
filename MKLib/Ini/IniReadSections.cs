using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Collections.Specialized.BitVector32;
using System.Windows.Forms;

public static partial class Ini
{

public static List<string> IniReadSections(string IniFile)
{
if (File.Exists(IniFile) == false) return new List<string>();
 List<string> FileStrings = File.ReadAllLines(IniFile).ToList();
List<string> Sections = FileStrings.Where(s => s.Trim().Contains("[") || s.Trim().Contains("]")).Select(t => t.Trim(new char[] {'[', ']'})).ToList();
return Sections;
}

}