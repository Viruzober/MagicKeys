using System;
using System.Windows.Forms;
using Microsoft.Collections.Extensions;
using System.Linq;
using System.Collections.Generic;

namespace MagicKeys
{

public record KeyInformation
{
public IntPtr HandleFromWNDProc;
public List<string> KeysList;
}

public partial class MagicKeys
{

public static KeyInformation KeyRegisterInfo = new KeyInformation();

public static void KeyReg()
{
if (KeyRegisterInfo.KeysList == new KeyInformation().KeysList) return;
int IDKey = 0;
foreach(var OBJKey in KeyRegisterInfo.KeysList)
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
try
{
Keys key = (Keys)new KeysConverter().ConvertFrom(KeyItems[^1]);
RegisterHotKey(KeyRegisterInfo.HandleFromWNDProc, IDKey, Mod, (uint)key);
IDKey+=1;
}
catch(Exception)
{
MKDebugForm("KeyReg|"+API.GetCurrentVUI()+"|"+KeyItems[^1]);
return;
}
}
}

}
}