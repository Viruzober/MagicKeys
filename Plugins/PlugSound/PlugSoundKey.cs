using System.Windows.Forms;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public static partial class PlugSound
{

public static void KeyReg()
{
KeyNavigatorReg("Space");
}

public static void KeyUnReg()
{
KeyNavigatorUnReg();
}

}
}