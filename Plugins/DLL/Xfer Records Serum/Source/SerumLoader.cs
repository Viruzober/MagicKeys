using System.Threading;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public partial class Serum
{
public static void SerumLoader()
{
Thread.Sleep(100);
if (ImgSearchArea("Reg", P[1], P[2], P[1]+P[3], P[2]+P[4], 0)[0] == 1)
{
VUILoader("Register");
return;
}
if (ImgSearchArea("Logo", P[1], P[2], P[1]+P[3], P[2]+P[4], 0)[0] == 1)
{
return;
}

KeyUnReg();
Speak("Before using this plugin follow the instructions found in the corresponding Settings folder");
}

}
}