using System.Windows.Forms;

namespace MagicKeys
{
public partial class MagicKeys
{
public static KeyNavigator KeyNavigatorHandle = new KeyNavigator();
public static void KeyNavigatorReg()
{
if (VUIObjects.Count != 0)
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
RegisterHotKey(KeyNavigatorHandle.Handle, 3, MKC.NOMOD|MKC.MOD_NOREPEAT, (int)Keys.Enter);
}
RegisterHotKey(KeyNavigatorHandle.Handle, 4, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F3);
RegisterHotKey(KeyNavigatorHandle.Handle, 5, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F5);
}

public static void KeyNavigatorUnReg()
{
for(int I = 0; I <= 5; I++)
{
UnregisterHotKey(KeyNavigatorHandle.Handle, I);
}
}

}
}