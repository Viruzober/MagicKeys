namespace DeveloperTool
{

public partial class DeveloperTool
{

public static void OCRClick(string BTN)
{
if (OCRSize[0] == 0)
{
MKLib.Speak(T._("No rectangle for OCR"));
return;
}
int[] MP = MKLib.GetMousePosition();
MKLib.MouseClick(BTN, MP[0]+(OCRSize[0]/2), MP[1]+(OCRSize[1]/2), 1, 0, 0, 10);
MKLib.MouseMove(MP[0], MP[1], 1);
}

}
}