using static MKLib;

namespace MagicKeys
{

public partial class MagicKeys
{

public static void MKDebugForm(string DebugInfo)
{
//MagicKeys.UnregisterHotKey(MagicKeys.HM.Handle, 1);
//MagicKeys.UnregisterHotKey(MagicKeys.HM.Handle, 2);
KeyUnReg();
LockPluginDetect = true;
using DebugForm DF = new DebugForm();
DF.DebugInfo = DebugInfo;
DF.ShowDialog();
}

}
}