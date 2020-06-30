using System;
using Microsoft.Win32;

namespace MagicKeys
{
public partial class MagicKeys
{

public static string RegReader(RegistryKey HK, string Path, string GetKey)
{
string[] PR = Path.Split("/");
RegistryKey Key = HK;
for (int I = 0; I < PR.Length; I++)
{
Key = Key.OpenSubKey(PR[I]);
}
string Result = (Key.GetValue(GetKey)).ToString();
return Result;
}

}
}