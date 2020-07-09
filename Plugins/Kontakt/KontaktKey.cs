using System.Windows.Forms;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public static partial class Kontakt
{

public static KontaktKey KontaktKeyHandle = new KontaktKey();

public static void KeyReg()
{
KeyNavigatorReg("Enter");
if (PluginsList[0]["VUIName"] == "LibList")
{
RegisterHotKey(KontaktKeyHandle.Handle, 4, MKC.NOMOD|MKC.MOD_NOREPEAT, (int)Keys.Down);
RegisterHotKey(KontaktKeyHandle.Handle, 5, MKC.NOMOD|MKC.MOD_NOREPEAT, (int)Keys.Up);
RegisterHotKey(KontaktKeyHandle.Handle, 6, MKC.NOMOD|MKC.MOD_NOREPEAT, (int)Keys.I);
RegisterHotKey(KontaktKeyHandle.Handle, 7, MKC.NOMOD|MKC.MOD_NOREPEAT, (int)Keys.S);
RegisterHotKey(KontaktKeyHandle.Handle, 8, MKC.NOMOD|MKC.MOD_NOREPEAT, (int)Keys.D);
}
if (PluginsList[0]["VUIName"] == "Kontakt")
{
RegisterHotKey(KontaktKeyHandle.Handle, 9, MKC.CTRL|MKC.MOD_NOREPEAT, (int)Keys.D);
}
}

public static void KeyUnReg()
{
KeyNavigatorUnReg();
if (PluginsList[0]["VUIName"] != "LibList")
{
UnregisterHotKey(KontaktKeyHandle.Handle, 4);
UnregisterHotKey(KontaktKeyHandle.Handle, 5);
UnregisterHotKey(KontaktKeyHandle.Handle, 6);
UnregisterHotKey(KontaktKeyHandle.Handle, 7);
UnregisterHotKey(KontaktKeyHandle.Handle, 8);
}
if (PluginsList[0]["VUIName"] != "Kontakt")
{
UnregisterHotKey(KontaktKeyHandle.Handle, 9);
}
}

}
}