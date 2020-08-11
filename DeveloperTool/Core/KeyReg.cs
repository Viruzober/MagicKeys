using System;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class DeveloperTool
{

public static void KeyReg()
{
MagicKeys.RegisterHotKey(HM.Handle, 4, MKC.NOMOD|MKC.MOD_NOREPEAT, (int)Keys.Left);
MagicKeys.RegisterHotKey(HM.Handle, 5, MKC.NOMOD|MKC.MOD_NOREPEAT, (int)Keys.Right);
MagicKeys.RegisterHotKey(HM.Handle, 6, MKC.NOMOD|MKC.MOD_NOREPEAT, (int)Keys.Up);
MagicKeys.RegisterHotKey(HM.Handle, 7, MKC.NOMOD|MKC.MOD_NOREPEAT, (int)Keys.Down);
MagicKeys.RegisterHotKey(HM.Handle, 8, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.P);
}

}
}