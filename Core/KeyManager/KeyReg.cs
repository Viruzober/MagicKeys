using System;
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
int IDKey = 0;
foreach(var OBJKey in VUIKeys)
{
//uint Mod = MKC.MOD_NOREPEAT;
uint Mod = 0;
string[] KeyItems = OBJKey.Key.Split("+");
for(int K = 0; K <= KeyItems.Length-1; K++)
{
if (KeyItems[K] == "Alt") Mod = Mod|MKC.ALT;
if (KeyItems[K] == "Ctrl") Mod = Mod|MKC.CTRL;
if (KeyItems[K] == "Shift") Mod = Mod|MKC.SHIFT;
if (KeyItems[K] == "Win") Mod = Mod|MKC.WIN;
}
            uint key = (uint)(Keys)kc.ConvertFrom(KeyItems[KeyItems.Length-1]);
RegisterHotKey(KeyWndProcHandle.Handle, IDKey, Mod, key);
IDKey+=1;
}
}

}
}