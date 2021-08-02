using System;
using System.Text;
namespace MagicKeys
{
public partial class DeveloperTool
{
public static void SpeakControlInfo()
{
StringBuilder Title = new StringBuilder(512);
StringBuilder Class = new StringBuilder(512);
int[] MP = MagicKeys.GetMousePosition();
IntPtr H = MagicKeys.GetWinPointHandle(MP[0], MP[1]);
MagicKeys.GetWindowText(H, Title, 512);
MagicKeys.GetClassName(H, Class, 512);
MagicKeys.Speak("Title: "+Title.ToString()+"\r\n Class: "+Class.ToString()+"\r\nText"+MagicKeys.ControlGetTextPoint(MP[0], MP[1]));
}
}
}