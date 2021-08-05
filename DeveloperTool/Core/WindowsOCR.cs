using System.Threading;

namespace MagicKeys
{
public partial class DeveloperTool
{
public static void WindowsOCR()
{
if (DP[0] == 0)
{
MagicKeys.Speak(T._("No rectangle for OCR"));
return;
}
int[] MP = MagicKeys.GetMousePosition();
string Text = MagicKeys.ImgToText(DP[0], DP[1], MP[0], MP[1], OCRZoom);
Thread.Sleep(500);
OCRR = Text;
MagicKeys.Speak(Text);
}

}
}