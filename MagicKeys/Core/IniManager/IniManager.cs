using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Reflection;

namespace MagicKeys
{
public static partial class Ini
{

public static List<string> IniReadSections(string GetFile)
{
List<string> temp = new List<string>();
string[] FileStr = File.ReadAllLines(GetFile);
string S = string.Empty;
for(int I = 0; I < FileStr.Length; I++)
{
S = FileStr[I].Trim();
if (S.StartsWith("[") && S.EndsWith("]"))
{
temp.Add(S.Substring(1, S.Length - 2));
}
}
return temp;
}

public static List<string> IniReadKeys(string File, string Section)
{
List<string> temp = new List<string>();
string sLine = string.Empty;
string SecName = string.Empty;
using (StreamReader sr = new StreamReader(File))
{
while (!sr.EndOfStream)
{
sLine = sr.ReadLine().Trim();
if (sLine.StartsWith("[") && sLine.EndsWith("]"))
{
SecName = sLine.Substring(1, sLine.Length - 2);
if (!sr.EndOfStream)
{
sLine = sr.ReadLine().Trim();
}
}
if (SecName.ToUpper() == Section.ToUpper())
{
if (sLine.Length > 0)
{
int pos = sLine.IndexOf("=");
if (pos > 0)
{
temp.Add(sLine.Remove(pos, sLine.Length - pos));
}
}
}
}
sr.Close();
}
return temp;
}

public static int IniCountSections( string File)
{
List<string> Count = IniReadSections(File);
return Count.Count;
}

}
}