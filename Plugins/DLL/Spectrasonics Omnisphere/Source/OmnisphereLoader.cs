using static MagicKeys.MagicKeys;

namespace MagicKeys
{

public partial class Omnisphere
{

public static void OmnisphereLoader()
{
MouseClick("Left", Coords.X+300, Coords.Y+10, 1, 0, 0, 10);
while(
ImgSearch("Reg", true)[0] == 0 &&
ImgSearch("Logo", true)[0] == 0)
{
if (WinActive(API.GetWTitle(), API.GetWClass()) == false)
{
return;
}
}
if (ImgSearch("Reg", true)[0] == 1)
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