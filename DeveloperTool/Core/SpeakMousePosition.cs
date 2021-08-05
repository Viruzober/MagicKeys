namespace MagicKeys
{

public partial class DeveloperTool
{

public static void SpeakMousePosition()
{
int[] MP = MagicKeys.GetMousePosition();
string S = "X "+(MP[0]-P[1]).ToString()+", Y"+(MP[1]-P[2]).ToString();
MagicKeys.Speak(S);
}

}
}