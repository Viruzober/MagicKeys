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
try
{
string[] FileStr = File.ReadAllLines(GetFile);
for (int S = 0; S < FileStr.Length; S++)
{
L = S;
if (FileStr[S].Trim() == "["+GetSection+"]")
{
for (int K = S; K < FileStr.Length; K++)
{
L = S;
string[] KeyValue = FileStr[K].Split("=", 2);
if (KeyValue[0].Trim() == GetKey)
{
return (KeyValue[1]).Trim();
}
}
}
}
throw new Exception();
}
catch(Exception)
{
MagicKeys.MKDebugForm("IniRead|"+L.ToString()+"|"+GetFile+"|"+GetSection+"|"+GetKey);
return null;
}
}	

}
}