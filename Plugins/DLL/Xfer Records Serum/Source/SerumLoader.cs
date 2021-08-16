using System.Threading;
using static MagicKeys.MagicKeys;
using static MKLib;

namespace MagicKeys
{

public partial class Serum
{

public static void SerumLoader()
{
Thread.Sleep(100);
if (ImgSearchArea("Reg", Coords.X, Coords.Y, Coords.X+Coords.W, Coords.Y+Coords.H, 0)[0] == 1)
{
VUILoader("Register");
return;
}
if (ImgSearchArea("Logo", Coords.X, Coords.Y, Coords.X+Coords.W, Coords.Y+Coords.H, 0)[0] == 1)
{
return;
}

KeyUnReg();
Speak("Before using this plugin follow the instructions found in the corresponding Settings folder");
}

}
}