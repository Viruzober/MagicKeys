using System;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class MagicKeys
{

public static KeyNavigator KeyNavigatorHandle = new KeyNavigator();

public static void KeyNavigatorReg(string KeyActive)
{
if (NavigationType == 0)
{
RegisterHotKey(KeyNavigatorHandle.Handle, 0, MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.Tab);
RegisterHotKey(KeyNavigatorHandle.Handle, 1, MKC.NOMOD|MKC.MOD_NOREPEAT, (int)Keys.Tab);
}
else
{
RegisterHotKey(KeyNavigatorHandle.Handle, 0, MKC.NOMOD|MKC.MOD_NOREPEAT, (int)Keys.Left);
RegisterHotKey(KeyNavigatorHandle.Handle, 1, MKC.NOMOD|MKC.MOD_NOREPEAT, (int)Keys.Right);
}
RegisterHotKey(KeyNavigatorHandle.Handle, 2, MKC.NOMOD|MKC.MOD_NOREPEAT, (int)Keys.F1);
if (KeyActive == "Enter")
{
RegisterHotKey(KeyNavigatorHandle.Handle, 3, MKC.NOMOD|MKC.MOD_NOREPEAT, (int)Keys.Enter);
}
else if (KeyActive == "Space")
{
RegisterHotKey(KeyNavigatorHandle.Handle, 3, MKC.NOMOD|MKC.MOD_NOREPEAT, (int)Keys.Space);
}
RegisterHotKey(KeyNavigatorHandle.Handle, 20, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F3);
}

public static void KeyNavigatorUnReg()
{
UnregisterHotKey(KeyNavigatorHandle.Handle, 0);
UnregisterHotKey(KeyNavigatorHandle.Handle, 1);
UnregisterHotKey(KeyNavigatorHandle.Handle, 2);
UnregisterHotKey(KeyNavigatorHandle.Handle, 3);
UnregisterHotKey(KeyNavigatorHandle.Handle, 20);
}

}
}