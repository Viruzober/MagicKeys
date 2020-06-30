using System.Threading;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public static partial class Kontakt
{

public static void LibLoaded()
{
int[] LibLoaded = ImgSearch(@"Images\Kontakt\KontaktLibLoaded.bmp");
if(LibLoaded[0] == 1)
{
VUIObjectSwitcher(true, false, 4, 6);
return;
}
VUIObjectSwitcher(true, true, 4, 6);
}

}
}