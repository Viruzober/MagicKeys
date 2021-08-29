using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Text.RegularExpressions;
public record KeyInfo
{
public IntPtr WNDProcHandle;
public List<string> KeyList;
}
public static partial class MKLib
{

private static KeyInfo KeyRegInfo = new KeyInfo();

public static void SetKeyRegContext(KeyInfo GetKeyInfo)
{
KeyRegInfo = GetKeyInfo;
}

public static void KeyUnReg()
{
for(int I = 0; I < KeyRegInfo.KeyList.Count; I++)
{
UnregisterHotKey(KeyRegInfo.WNDProcHandle, I);
}
}

public static void KeyUnReg(string KeyName)
{
if (KeyRegInfo.KeyList.IndexOf(KeyName) != -1)
{
UnregisterHotKey(KeyRegInfo.WNDProcHandle, KeyRegInfo.KeyList.IndexOf(KeyName));
}
}

public static void KeyReg()
{
int IDKey = 0;
Regex RGX = new Regex(@"\+(?!\+|$)");
foreach(var OBJKey in KeyRegInfo.KeyList)
{
uint Mod = MKC.MOD_NOREPEAT;
string[] KeyItems = RGX.Split(OBJKey);
for(int K = 0; K < KeyItems.Length; K++)
{
if (KeyItems[K] == "Ctrl" | KeyItems[K] == "Alt" | KeyItems[K] == "Shift" | KeyItems[K] == "Win")
{
Mod = Mod|(uint)Enum.Parse(typeof(MKC.ModKeys), KeyItems[K]);
}
}
Keys key = ConvertToKeys(KeyItems[^1]);
RegisterHotKey(KeyRegInfo.WNDProcHandle, IDKey, Mod, (uint)key);
IDKey+=1;
}
}

}