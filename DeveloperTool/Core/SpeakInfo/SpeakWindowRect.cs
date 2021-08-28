namespace DeveloperTool
{

public partial class DeveloperTool
{

public static void SpeakWindowRect()
{
int[] Rect = MKLib.GetWinRect(MKLib.GetForegroundWindow());
string R = T._("Width")+" "+(Rect[2]-Coords.X).ToString()+", "+T._("Height")+" "+(Rect[3]-Coords.Y).ToString();
MKLib.Speak(R);
}

}
}