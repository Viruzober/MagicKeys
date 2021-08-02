using System;
namespace MagicKeys
{
public partial class DeveloperTool
{
public static void SpeakWindowRect()
{
int[] Rect = MagicKeys.GetWinRect(MagicKeys.GetForegroundWindow());
string R = T._("Width")+" "+(Rect[2]-P[1]).ToString()+", "+T._("Height")+" "+(Rect[3]-P[2]).ToString();
MagicKeys.Speak(R);
}
}
}