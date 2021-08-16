using System.Threading;

namespace MagicKeys
{

public partial class DeveloperTool
{

public static void WindowsOCR()
{
if (DP[0] == 0)
{
MKLib.Speak(T._("No rectangle for OCR"));
return;
}
int[] MP = MKLib.GetMousePosition();
string Text = MKLib.ImgToText(DP[0], DP[1], MP[0], MP[1], OCRZoom);
Thread.Sleep(500);
OCRR = Text;
MKLib.Speak(Text);
}

}
}