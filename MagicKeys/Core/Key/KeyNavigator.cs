using System.Windows.Forms;

namespace MagicKeys
{

public partial class MagicKeys
{

public static void KeyNavigatorReg()
{
if (VUIObjects.Count != 0)
{
if (NavigationType == 0)
{
RegisterHotKey(KeyWndProcHandle.Handle, 0, MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.Tab);
RegisterHotKey(KeyWndProcHandle.Handle, 1, MKC.NOMOD|MKC.MOD_NOREPEAT, (int)Keys.Tab);
}
else
{
RegisterHotKey(KeyWndProcHandle.Handle, 0, MKC.NOMOD|MKC.MOD_NOREPEAT, (int)Keys.Left);
RegisterHotKey(KeyWndProcHandle.Handle, 1, MKC.NOMOD|MKC.MOD_NOREPEAT, (int)Keys.Right);
}
RegisterHotKey(KeyWndProcHandle.Handle, 2, MKC.NOMOD|MKC.MOD_NOREPEAT, (int)Keys.F1);
RegisterHotKey(KeyWndProcHandle.Handle, 3, MKC.NOMOD|MKC.MOD_NOREPEAT, (int)Keys.Enter);
}
RegisterHotKey(KeyWndProcHandle.Handle, 4, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F3);
RegisterHotKey(KeyWndProcHandle.Handle, 5, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F5);
}

}
}