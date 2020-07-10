using System;
using System.Reflection;
using System.IO;

namespace MagicKeys
{
public static partial class Ini
{

public static void IniWrite(string GetFile, string GetSection, string GetKey, string GetValue)
{
string[] FileStr = File.ReadAllLines(GetFile);
string FullStr = "";
for(int I = 0; I < FileStr.Length; I++)
{
if (FileStr[I] == "["+GetSection+"]")
{
for(int K = I; K < FileStr.Length; K++)
{
if(FileStr[K].Contains(GetKey))
{
string KeyStr = FileStr[K].Substring(0, FileStr[K].IndexOf("=")+1);
FileStr[K] = KeyStr+GetValue;
for(int R = 0; R < FileStr.Length; R++)
{
FullStr+=FileStr[R]+"\r\n";
}
File.WriteAllText(GetFile, FullStr);
}
}
}
}
}	

}
}