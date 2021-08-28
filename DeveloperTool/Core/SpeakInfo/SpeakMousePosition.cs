namespace DeveloperTool
{

public partial class DeveloperTool
{

public static void SpeakMousePosition()
{
int[] MP = MKLib.GetMousePosition();
string S = "X "+(MP[0]-Coords.X).ToString()+", Y"+(MP[1]-Coords.Y).ToString();
MKLib.Speak(S);
}

}
}