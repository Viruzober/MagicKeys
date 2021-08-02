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
IntPtr H = MagicKeys.GetForegroundWindow();
MagicKeys.GetWindowText(H, Title, 512);
MagicKeys.GetClassName(H, Class, 512);
MagicKeys.Speak("Title: "+Title.ToString()+"\r\n Class: "+Class.ToString());
}
}
}