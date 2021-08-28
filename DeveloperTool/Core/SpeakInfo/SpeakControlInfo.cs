using System;
using System.Text;

namespace DeveloperTool
{

public partial class DeveloperTool
{

public static void SpeakControlInfo()
{
StringBuilder Title = new StringBuilder(512);
StringBuilder Class = new StringBuilder(512);
int[] MP = MKLib.GetMousePosition();
IntPtr H = MKLib.GetWinPointHandle(MP[0], MP[1]);
MKLib.GetWindowText(H, Title, 512);
MKLib.GetClassName(H, Class, 512);
MKLib.Speak("Title: "+Title.ToString()+"\r\n Class: "+Class.ToString()+"\r\nText"+MKLib.ControlGetTextPoint(MP[0], MP[1]));
}

}
}