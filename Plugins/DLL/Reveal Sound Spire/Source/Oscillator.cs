using static MagicKeys.MagicKeys;
using static MKLib;

namespace MagicKeys
{

public partial class RevealSoundSpire
{

public void Oscillator1()
{
MouseClick("Left", Coords.X+145, Coords.Y+60, 1, 0, 0, 10);
Speak("Oscillator 1 selected");
}

public void Oscillator2()
{
MouseClick("Left", Coords.X+180, Coords.Y+60, 1, 0, 0, 10);
Speak("Oscillator 2 selected");
}

public void Oscillator3()
{
MouseClick("Left", Coords.X+215, Coords.Y+60, 1, 0, 0, 10);
Speak("Oscillator 3 selected");
}

public void Oscillator4()
{
MouseClick("Left", Coords.X+250, Coords.Y+60, 1, 0, 0, 10);
Speak("Oscillator 4 selected");
}

public static bool Copy = false;
public void CopyOscillator()
{
MouseClick("Left", Coords.X+290, Coords.Y+60, 1, 0, 0, 10);
Speak("Oscillator copied");
Copy = true;
}

public void PasteOscillator()
{
if (Copy == false)
{
Speak("Oscillator not copied");
return;
}
MouseClick("Left", Coords.X+335, Coords.Y+60, 1, 0, 0, 10);
Speak("Oscillator pasted");
}

}
}