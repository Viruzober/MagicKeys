using System;
using System.Threading;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public partial class Serum
{

public static void SerumLoader()
{
        while (
ImgSearch("SerumLogo", true)[0] == 0 &
ImgSearch("SerumReg", true)[0] == 0)
{
if (WinActive(API.GetWTitle(), API.GetWClass()) == false)
{
return;
}
}
if (ImgSearch("SerumLogo", true)[0] == 1)
{
VUIObjectSwitcher(true, "false", 6, 6);
}
else if (ImgSearch("SerumReg", true)[0] == 1)
{
VUIObjectSwitcher(true, "false", 1, 5);
}
else
{
Speak("Before using this plugin follow the instructions found in the corresponding Settings folder");
return;
}
}

}
}