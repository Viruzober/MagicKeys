using static MagicKeys.MagicKeys;
using static MKLib;

namespace MagicKeys
{

public partial class Omnisphere
{

public static void OmnisphereLoader()
{
MouseClick("Left", Coords.X+20, Coords.Y+20, 1, 0, 0, 10);
while(
ImageSearch("Reg", true)[0] == 0 &&
ImageSearch("Logo", true)[0] == 0)
{
if (WinActive(API.GetWTitle(), API.GetWClass()) == false)
{
return;
}
}
if (ImageSearch("Reg", true)[0] == 1)
{
VUILoader("OmnisphereReg");
}
else
{
AudoSelect();
}
}

}
}