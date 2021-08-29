using static MKLib;

namespace MagicKeys
{

public partial class MagicKeys
{

public static void MKDebugForm(string DebugInfo)
{
KeyUnReg();
LockPluginDetect = true;
DebugForm(DebugInfo);
}

}
}