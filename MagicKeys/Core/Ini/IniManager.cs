using System;
using System.Collections.Generic;
using System.IO;

namespace MagicKeys
{

public static partial class Ini
{

public static List<string> IniReadSections(string GetFile)
{
List<string> temp = new List<string>();
if (IniFileExists(GetFile) == false)
{
MagicKeys.MKDebugForm("FileNotFound|"+GetFile);
return null;
}
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

public static List<string> IniReadKeys(string GetFile, string GetSection)
{
List<string> temp = new List<string>();
int L = 0;
int End = 0;
string Error = string.Empty;
try
{
if (IniFileExists(GetFile) == false)
{
MagicKeys.MKDebugForm("FileNotFound|"+GetFile);
return null;
}
string[] FileStr = File.ReadAllLines(GetFile);
for (int S = 0; S <= FileStr.Length-1; S++)
{
if (FileStr[S].StartsWith(":") == true || FileStr[S].StartsWith("#") == true || string.IsNullOrWhiteSpace(FileStr[S]))
{
continue;
}

if (FileStr[S].Trim() == "["+GetSection+"]")
{
L = S;
break;
}
else if (FileStr[S].Trim() != "["+GetSection+"]" && S == FileStr.Length-1)
{
L = S+1;
Error = T._("Section not found");
throw new Exception();
}
}
for (int R = L+1; R <= FileStr.Length-1; R++)
{
if (FileStr[R].StartsWith(":") == true || FileStr[R].StartsWith("#") == true || string.IsNullOrWhiteSpace(FileStr[R]))
{
continue;
}

if (FileStr[R].Contains("[") || R == FileStr.Length-1)
{
End = R;
break;
}
}
for (int Start = L+1; Start <= End; Start++)
{
if (FileStr[Start].StartsWith(":") == true || FileStr[Start].StartsWith("#") == true || string.IsNullOrWhiteSpace(FileStr[Start]))
{
continue;
}

if (FileStr[Start].Contains("[") == true)
{
continue;
}

string[] KeyValue = FileStr[Start].Split("=", 2);
temp.Add(KeyValue[0].Trim());
}
return temp;
}
catch(Exception)
{
MagicKeys.MKDebugForm("IniReadKeys|"+L.ToString()+"|"+GetFile+"|"+GetSection+"|"+Error);
return null;
}
}

public static int IniCountSections( string File)
{
List<string> Count = IniReadSections(File);
return Count.Count;
}

}
}