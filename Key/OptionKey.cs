using System;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class MagicKeys
{

public static void OptionReg()
{
RegisterHotKey(MagicKeys.HM.Handle, 0, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F1);
RegisterHotKey(MagicKeys.HM.Handle, 1, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F2);
RegisterHotKey(MagicKeys.HM.Handle, 2, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F3);
}

public static void OptionUnReg()
{
UnregisterHotKey(MagicKeys.HM.Handle, 0);
UnregisterHotKey(MagicKeys.HM.Handle, 1);
UnregisterHotKey(MagicKeys.HM.Handle, 2);
}

}
}