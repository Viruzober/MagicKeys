using System;
using System.Text;

namespace MagicKeys
{

public partial class DeveloperTool
{

public static void SpeakWindowInfo()
{
StringBuilder Title = new StringBuilder(512);
StringBuilder Class = new StringBuilder(512);
IntPtr H = MKLib.GetForegroundWindow();
MKLib.GetWindowText(H, Title, 512);
MKLib.GetClassName(H, Class, 512);
MKLib.Speak("Title: "+Title.ToString()+"\r\n Class: "+Class.ToString());
}

}
}