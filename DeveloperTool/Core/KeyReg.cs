using System;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class DeveloperTool
{

public static void KeyReg()
{
MagicKeys.RegisterHotKey(HM.Handle, 4, MKC.NOMOD, (int)Keys.Left);
MagicKeys.RegisterHotKey(HM.Handle, 5, MKC.NOMOD, (int)Keys.Right);
MagicKeys.RegisterHotKey(HM.Handle, 6, MKC.NOMOD, (int)Keys.Up);
MagicKeys.RegisterHotKey(HM.Handle, 7, MKC.NOMOD, (int)Keys.Down);
MagicKeys.RegisterHotKey(HM.Handle, 8, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.P);
MagicKeys.RegisterHotKey(HM.Handle, 9, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.R);
MagicKeys.RegisterHotKey(HM.Handle, 10, MKC.CTRL|MKC.MOD_NOREPEAT, (int)Keys.O);
MagicKeys.RegisterHotKey(HM.Handle, 11, MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.O);
MagicKeys.RegisterHotKey(HM.Handle, 12, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.Z);
}

public static void OptionKeyReg()
{
MagicKeys.RegisterHotKey(HM.Handle, 0, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F1);
MagicKeys.RegisterHotKey(HM.Handle, 1, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F2);
MagicKeys.RegisterHotKey(HM.Handle, 2, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F3);
}

}
}