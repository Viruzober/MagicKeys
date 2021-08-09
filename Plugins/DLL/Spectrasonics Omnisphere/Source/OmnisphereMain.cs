using System.Threading;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{

public partial class Omnisphere
{

public static void MainTab()
{
MouseClick("Left", P[1]+545, P[2]+210, 1, 0, 0, 10);
VUILoader("OmnisphereMain");
}

public static void MainVoiceMenu()
{
MouseClick("Left", P[1]+335, P[2]+270, 1, 0, 0, 10);
}

public static void MainOctaveMenu()
{
MouseClick("Left", P[1]+410, P[2]+270, 1, 0, 0, 10);
}

public static void MainScaleMenu()
{
MouseClick("Left", P[1]+370, P[2]+325, 1, 0, 0, 10);
}

public static void MainClockSpeedMenu()
{
MouseClick("Left", P[1]+370, P[2]+375, 1, 0, 0, 10);
}

public static void MainSignalPathMenu()
{
MouseClick("Left", P[1]+370, P[2]+430, 1, 0, 0, 10);
}

public static void MainLutchButton()
{
MouseClick("Left", P[1]+345, P[2]+480, 1, 0, 0, 10);
Thread.Sleep(100);
Speak(CheckStateImg("Lutch", P[1]+325, P[2]+460, P[1]+365, P[2]+500));
}

public static void MainLutchMenu()
{
MouseClick("Left", P[1]+395, P[2]+480, 1, 0, 0, 10);
}

public static void MainGainMenu()
{
MouseClick("Left", P[1]+370, P[2]+535, 1, 0, 0, 10);
}

public static void MainPartLavelSlider()
{
MouseClick("Right", P[1]+320, P[2]+590, 1, 0, 0, 10);
Thread.Sleep(100);
WaitWinClose("#32768");
Thread.Sleep(100);
WaitControlClose(P[1]+310, P[2]+570, "Edit");
}

public static void MainMCheckBox()
{
MouseClick("Left", P[1]+315, P[2]+620, 1, 0, 0, 10);
Thread.Sleep(100);
Speak(CheckStateImg("MainMCheck", P[1]+290, P[2]+590, P[1]+340, P[2]+650));
}

public static void MainSCheckBox()
{
MouseClick("Left", P[1]+420, P[2]+620, 1, 0, 0, 10);
Thread.Sleep(100);
Speak(CheckStateImg("MainSCheck", P[1]+390, P[2]+590, P[1]+470, P[2]+650));
}

public static void MainCutOfSlider()
{
Slider("CutOf", 490, 598, "H", 1.7, 1);
}

public static void MainLPFCheckBox()
{
MouseClick("Left", P[1]+705, P[2]+590, 1, 0, 0, 10);
Thread.Sleep(100);
Speak(CheckStateImg("MainLPF", P[1]+715, P[2]+585, P[1]+735, P[2]+610));
}

public static void MainHPFCheckBox()
{
MouseClick("Left", P[1]+705, P[2]+610, 1, 0, 0, 10);
Thread.Sleep(100);
Speak(CheckStateImg("MainHPF", P[1]+715, P[2]+595, P[1]+735, P[2]+620));
}

public static void MainBack()
{
VUILoader("Omnisphere");
}

}
}