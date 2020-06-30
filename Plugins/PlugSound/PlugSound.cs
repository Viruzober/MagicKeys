using System.Windows.Forms;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public static partial class PlugSound
{

public static void Menu()
{
MouseClick("Left", P[1]+250, P[2]+30, 1, 0, 0, 10);
}

public static void FreeMenu()
{
MouseClick("Left", P[1]+150, P[2]+30, 1, 0, 0, 10);
}

}
}