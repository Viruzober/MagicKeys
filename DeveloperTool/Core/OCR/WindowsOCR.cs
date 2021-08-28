using System.Threading;

namespace DeveloperTool
{

public partial class DeveloperTool
{

public static void WindowsOCR()
{
if (OCRSize[0] == 0)
{
MKLib.Speak(T._("No rectangle for OCR"));
return;
}
int[] MP = MKLib.GetMousePosition();
string Text = MKLib.ImgToText(OCRSize[0], OCRSize[1], MP[0], MP[1], OCRZoom);
MKLib.Speak(Text);
}

}
}