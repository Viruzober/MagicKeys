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
string Error = string.Empty;
try
{
string[] FileStr = File.ReadAllLines(GetFile);
for(int S = 0; S < FileStr.Length; S++)
{
L = S;
if (FileStr[S].Trim() == "["+GetSection+"]")
{

int Start = S;
int End = 0;
for (int ES = S+1; ES < FileStr.Length; ES++)
{
if (FileStr[ES].Contains("[") == true | ES == FileStr.Length-1)
{
End = ES;
}
}

for (int K = Start; K <= End; K++)
{
string[] KeyValue = FileStr[K].Split("=", 2);
L = K;
if (KeyValue[0].Trim() == GetKey)
{
return KeyValue[1].Trim();
}
else if (KeyValue[0].Trim() != GetKey && K == End)
{
Error = "Key not found";
throw new Exception();
}
}

}
else if (FileStr[S] != "["+GetSection+"]" && S == FileStr.Length)
{
Error = "Section not found";
throw new Exception();
{
}
}
if (S == FileStr.Length-1)
{
Error = "Section not found";
throw new Exception();
}
}
}
catch(Exception)
{
MagicKeys.MKDebugForm("IniRead|"+L.ToString()+"|"+GetFile+"|"+GetSection+"|"+GetKey+"|"+Error);
return null;
}
}	

}
}