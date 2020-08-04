using System;
using System.Reflection;
using System.IO;
using System.Windows.Forms;

namespace MagicKeys
{
public static partial class Ini
{

public static string IniRead(string GetFile, string GetSection, string GetKey)
{
int L = 0;
int End = 0;
string Error = string.Empty;
try
{
string[] FileStr = File.ReadAllLines(GetFile);
for (int S = 0; S <= FileStr.Length-1; S++)
{
if (FileStr[S].Trim() == "["+GetSection+"]")
{
L = S;
break;
}
else if (FileStr[S].Trim() != "["+GetSection+"]" && S == FileStr.Length-1)
{
L = S+1;
Error = "Section not found";
throw new Exception();
}
}

for (int R = L+1; R < FileStr.Length; R++)
{
if (FileStr[R].Contains("[") || R == FileStr.Length-1)
{
End = R;
break;
}
}

for (int Start = L+1; Start <= End; Start++)
{
string[] KeyValue = FileStr[Start].Split("=", 2);
if (KeyValue[0].Trim() == GetKey)
{
if (KeyValue.Length == 2)
{
return KeyValue[1].Trim();
}
else
{
L = Start+1;
Error = "Value is not correct";
throw new Exception();
}
}
else if (KeyValue[0].Trim() != GetKey && Start == End)
{
L = Start+1;
Error = "Key not found";
throw new Exception();
}
}
Error = "Error reading file";
throw new Exception();
}
catch(Exception)
{
MagicKeys.MKDebugForm("IniRead|"+L.ToString()+"|"+GetFile+"|"+GetSection+"|"+GetKey+"|"+Error);
return null;
}
}	

}
}