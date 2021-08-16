namespace MagicKeys
{

public partial class DeveloperTool
{

public static void OCRClick(string BTN)
{
if (DP[0] == 0)
{
MKLib.Speak(T._("No rectangle for OCR"));
return;
}
int[] MP = MKLib.GetMousePosition();
MKLib.MouseClick(BTN, MP[0]+(DP[0]/2), MP[1]+(DP[1]/2), 1, 0, 0, 10);
MKLib.MouseMove(MP[0], MP[1], 1);
}

}
}