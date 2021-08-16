using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public record KeyInfo
{
public IntPtr WNDProcHandle;
public List<string> KeyList;
}
public static partial class MKLib
{

public static KeyInfo KeyRegInfo = new KeyInfo();

public static void SetKeyRegContext(KeyInfo keyInfo)
{
KeyRegInfo = keyInfo;
}

public static void KeyUnReg()
{
if (KeyRegInfo.KeyList == new KeyInfo().KeyList) return;
for(int I = 0; I < KeyRegInfo.KeyList.Count; I++)
{
UnregisterHotKey(KeyRegInfo.WNDProcHandle, I);
}
}

public static void KeyReg()
{
if (KeyRegInfo.KeyList == new KeyInfo().KeyList) return;
int IDKey = 0;
foreach(var OBJKey in KeyRegInfo.KeyList)
{
uint Mod = MKC.MOD_NOREPEAT;
string[] KeyItems = OBJKey.Split("+");
for(int K = 0; K < KeyItems.Length; K++)
{
if (KeyItems[K] == "Ctrl" | KeyItems[K] == "Alt" | KeyItems[K] == "Shift" | KeyItems[K] == "Win")
{
Mod = Mod|(uint)Enum.Parse(typeof(MKC.ModKeys), KeyItems[K]);
}
}
Keys key = (Keys)new KeysConverter().ConvertFrom(KeyItems[^1]);
RegisterHotKey(KeyRegInfo.WNDProcHandle, IDKey, Mod, (uint)key);
IDKey+=1;
}
}

public static string GetKeyName(int Key)
{
if (Key == 13)
{
return "Enter";
}
if (Key == 33)
{
return "PageUp";
}
if (Key == 34)
{
return "PageDown";
}
if (Key >= 48 && Key <= 57)
{
return ((char)Key).ToString();
}
return ((Keys)Key).ToString();
}

}