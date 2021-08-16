using System.Windows.Forms;

namespace MagicKeys
{

public partial class DeveloperTool
{

public static void KeyReg()
{
MKLib.RegisterHotKey(HM.Handle, 4, MKC.NOMOD, (int)Keys.Left);
MKLib.RegisterHotKey(HM.Handle, 5, MKC.NOMOD, (int)Keys.Right);
MKLib.RegisterHotKey(HM.Handle, 6, MKC.NOMOD, (int)Keys.Up);
MKLib.RegisterHotKey(HM.Handle, 7, MKC.NOMOD, (int)Keys.Down);
MKLib.RegisterHotKey(HM.Handle, 8, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.P);
MKLib.RegisterHotKey(HM.Handle, 9, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.R);
MKLib.RegisterHotKey(HM.Handle, 10, MKC.CTRL|MKC.MOD_NOREPEAT, (int)Keys.O);
MKLib.RegisterHotKey(HM.Handle, 11, MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.O);
MKLib.RegisterHotKey(HM.Handle, 12, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.Z);
MKLib.RegisterHotKey(HM.Handle, 13, MKC.MOD_NOREPEAT, (int)Keys.M);
MKLib.RegisterHotKey(HM.Handle, 14, MKC.MOD_NOREPEAT, (int)Keys.C);
MKLib.RegisterHotKey(HM.Handle, 15, MKC.MOD_NOREPEAT, (int)Keys.OemMinus);
MKLib.RegisterHotKey(HM.Handle, 16, MKC.MOD_NOREPEAT, (int)Keys.Oemplus);
MKLib.RegisterHotKey(HM.Handle, 17, MKC.CTRL|MKC.MOD_NOREPEAT, (int)Keys.S);
MKLib.RegisterHotKey(HM.Handle, 18, MKC.CTRL|MKC.MOD_NOREPEAT, (int)Keys.I);
MKLib.RegisterHotKey(HM.Handle, 19, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.G);
MKLib.RegisterHotKey(HM.Handle, 20, MKC.MOD_NOREPEAT, (int)Keys.R);
MKLib.RegisterHotKey(HM.Handle, 21, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.O);
MKLib.RegisterHotKey(HM.Handle, 22, MKC.CTRL|MKC.MOD_NOREPEAT, (int)Keys.OemMinus);
MKLib.RegisterHotKey(HM.Handle, 23, MKC.CTRL|MKC.MOD_NOREPEAT, (int)Keys.Oemplus);
MKLib.RegisterHotKey(HM.Handle, 24, MKC.CTRL|MKC.ALT|MKC.MOD_NOREPEAT, (int)Keys.A);
MKLib.RegisterHotKey(HM.Handle, 25, MKC.MOD_NOREPEAT, (int)Keys.W);
MKLib.RegisterHotKey(HM.Handle, 26, MKC.MOD_NOREPEAT|MKC.CTRL, (int)Keys.W);
}

public static void OptionKeyReg()
{
MKLib.RegisterHotKey(HM.Handle, 0, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F1);
MKLib.RegisterHotKey(HM.Handle, 1, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F2);
if (KeySwitch == 1)
{
return;
}

MKLib.RegisterHotKey(HM.Handle, 2, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F3);
MKLib.RegisterHotKey(HM.Handle, 3, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F4);
}

}
}