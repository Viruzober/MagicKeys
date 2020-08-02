using System;
using System.IO;
using System.Windows.Forms;
using System.Reflection;

namespace MagicKeys
{
public partial class MagicKeys
{

public static void MKDebugForm(string DebugInfo)
{
MagicKeys.UnregisterHotKey(MagicKeys.HM.Handle, 1);
MagicKeys.UnregisterHotKey(MagicKeys.HM.Handle, 2);
KeyUnReg();
KeySwitch = 1;
DebugForm DF = new DebugForm();
DF.DebugInfo = DebugInfo;
DF.ShowDialog();
MagicKeys.RegisterHotKey(MagicKeys.HM.Handle, 2, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F3);
MagicKeys.RegisterHotKey(MagicKeys.HM.Handle, 1, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F2);
}

}
}