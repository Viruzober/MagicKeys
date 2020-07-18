using System.Windows.Forms;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public static partial class Omnisphere
{

public static OmnisphereKey OmnisphereKeyHandle = new OmnisphereKey();

public static void KeyReg()
{
KeyNavigatorReg("Space");
RegisterHotKey(OmnisphereKeyHandle.Handle, 4, MKC.NOMOD|MKC.MOD_NOREPEAT, (int)Keys.Home);
RegisterHotKey(OmnisphereKeyHandle.Handle, 5, MKC.NOMOD|MKC.MOD_NOREPEAT, (int)Keys.End);
RegisterHotKey(OmnisphereKeyHandle.Handle, 6, MKC.NOMOD|MKC.MOD_NOREPEAT, (int)Keys.Prior);
RegisterHotKey(OmnisphereKeyHandle.Handle, 7, MKC.NOMOD|MKC.MOD_NOREPEAT, (int)Keys.Next);
RegisterHotKey(OmnisphereKeyHandle.Handle, 8, MKC.CTRL|MKC.MOD_NOREPEAT, (int)Keys.Home);
RegisterHotKey(OmnisphereKeyHandle.Handle, 9, MKC.CTRL|MKC.MOD_NOREPEAT, (int)Keys.End);
RegisterHotKey(OmnisphereKeyHandle.Handle, 10, MKC.CTRL|MKC.MOD_NOREPEAT, (int)Keys.Prior);
RegisterHotKey(OmnisphereKeyHandle.Handle, 11, MKC.CTRL|MKC.MOD_NOREPEAT, (int)Keys.Next);
RegisterHotKey(OmnisphereKeyHandle.Handle, 12, MKC.NOMOD|MKC.MOD_NOREPEAT, (int)Keys.B);
RegisterHotKey(OmnisphereKeyHandle.Handle, 13, MKC.NOMOD|MKC.MOD_NOREPEAT, (int)Keys.P);
}

public static void KeyUnReg()
{
KeyNavigatorUnReg();
UnregisterHotKey(OmnisphereKeyHandle.Handle, 4);
UnregisterHotKey(OmnisphereKeyHandle.Handle, 5);
UnregisterHotKey(OmnisphereKeyHandle.Handle, 6);
UnregisterHotKey(OmnisphereKeyHandle.Handle, 7);
UnregisterHotKey(OmnisphereKeyHandle.Handle, 8);
UnregisterHotKey(OmnisphereKeyHandle.Handle, 9);
UnregisterHotKey(OmnisphereKeyHandle.Handle, 10);
UnregisterHotKey(OmnisphereKeyHandle.Handle, 11);
UnregisterHotKey(OmnisphereKeyHandle.Handle, 12);
UnregisterHotKey(OmnisphereKeyHandle.Handle, 13);
}

}
}