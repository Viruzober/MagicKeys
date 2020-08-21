using System;

namespace MagicKeys
{
public partial class DeveloperTool
{

public static void SpeakWindowRect()
{
int[] Rect = MagicKeys.GetWinRect(MagicKeys.GetForegroundWindow());
string R = "Width "+(Rect[2]-P[1]).ToString()+", Height "+(Rect[3]-P[2]).ToString();
MagicKeys.Speak(R);
}

}
}