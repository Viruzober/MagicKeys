using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;
namespace MagicKeys
{
public partial class MagicKeys
{
public static KeyWNDProc KeyWndProcHandle = new KeyWNDProc();
public static KeysConverter kc = new KeysConverter();
public static void KeyReg()
{
if (VUIKeys.Count != 0)
{
int IDKey = 0;
foreach(var OBJKey in VUIKeys)
{
uint Mod = MKC.MOD_NOREPEAT;
string[] KeyItems = OBJKey.Key.Split("+");
for(int K = 0; K < KeyItems.Length; K++)
{
if (KeyItems[K] == "Ctrl" | KeyItems[K] == "Alt" | KeyItems[K] == "Shift" | KeyItems[K] == "Win")
{
Mod = Mod|(uint)Enum.Parse(typeof(MKC.ModKeys), KeyItems[K]);
}
}
try{
Keys key = (Keys)kc.ConvertFrom(KeyItems[^1]);
RegisterHotKey(KeyWndProcHandle.Handle, IDKey, Mod, (uint)key);
IDKey+=1;
}
catch(Exception)
{
MKDebugForm("KeyReg|"+API.GetCurrentVUI()+","+KeyItems[^1]);
return;
}
}
}
KeyNavigatorReg();
{
}
}
}
}