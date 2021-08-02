using System;
namespace MagicKeys
{
public partial class DeveloperTool
{
public static void OCRClick(string BTN)
{
if (DP[0] == 0)
{
MagicKeys.Speak(T._("No rectangle for OCR"));
return;
}
int[] MP = MagicKeys.GetMousePosition();
MagicKeys.MouseClick(BTN, MP[0]+(DP[0]/2), MP[1]+(DP[1]/2), 1, 0, 0, 10);
MagicKeys.MouseMove(MP[0], MP[1], 1);
}
}
}