using System;
using System.Threading;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public partial class Serum
{

public static void PluginLoad()
{
while(
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
Speak("Перед использованием этого плагина выполните соответствующую инструкцию для него из папки settings");
return;
}
}

}
}