using System;
using System.Linq;
namespace MagicKeys
{

public partial class MagicKeys
{

public static void KeyUnReg()
{
if (KeyRegisterInfo.KeysList == new KeyInformation().KeysList) return;
for(int I = 0; I < KeyRegisterInfo.KeysList.Count; I++)
{
UnregisterHotKey(KeyRegisterInfo.HandleFromWNDProc, I);
}
}

}
}