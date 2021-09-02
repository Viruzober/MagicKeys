using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Text.RegularExpressions;
public record KeyInfo
{
public IntPtr WNDProcHandle;
public List<string> KeyList = new List<string>();
}
public static partial class MKLib
{

private static KeyInfo MKLibKeyRegInfo;

public static void SetKeyRegContext(KeyInfo GetKeyInfo)
{
MKLibKeyRegInfo = GetKeyInfo;
}

public static void DisableKey(string Key)
{
MKLibKeyRegInfo.KeyList[MKLibKeyRegInfo.KeyList.IndexOf(Key)] = null;
}

public static void KeyUnReg()
{
for(int I = 0; I < MKLibKeyRegInfo.KeyList.Count; I++)
{
if (MKLibKeyRegInfo.KeyList[I] == null) continue;
UnregisterHotKey(MKLibKeyRegInfo.WNDProcHandle, I);
}
}

public static void KeyUnReg(string KeyName)
{
if (MKLibKeyRegInfo.KeyList.IndexOf(KeyName) != -1)
{
UnregisterHotKey(MKLibKeyRegInfo.WNDProcHandle, MKLibKeyRegInfo.KeyList.IndexOf(KeyName));
}
}

public static void KeyReg()
{
int IDKey = 0;
Regex RGX = new Regex(@"\+(?!\+|$)");
foreach(var OBJKey in MKLibKeyRegInfo.KeyList)
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
RegisterHotKey(MKLibKeyRegInfo.WNDProcHandle, IDKey, Mod, (uint)key);
IDKey+=1;
}
}

}