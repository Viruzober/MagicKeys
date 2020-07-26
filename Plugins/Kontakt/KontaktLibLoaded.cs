using System.Threading;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public static partial class Kontakt
{

public static void LibLoaded()
{
if(ImgSearch(@"Images\Kontakt\KontaktLibLoaded.bmp", true)[0] == 1)
{
VUIObjectSwitcher(true, "false", 4, 6);
}
}

}
}