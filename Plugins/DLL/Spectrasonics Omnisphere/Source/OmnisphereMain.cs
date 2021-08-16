using System.Threading;
using static MagicKeys.MagicKeys;
using static MKLib;

namespace MagicKeys
{

public partial class Omnisphere
{

public static void MainTab()
{
MouseClick("Left", Coords.X+545, Coords.Y+210, 1, 0, 0, 10);
VUILoader("OmnisphereMain");
}

public static void MainVoiceMenu()
{
MouseClick("Left", Coords.X+335, Coords.Y+270, 1, 0, 0, 10);
}

public static void MainOctaveMenu()
{
MouseClick("Left", Coords.X+410, Coords.Y+270, 1, 0, 0, 10);
}

public static void MainScaleMenu()
{
MouseClick("Left", Coords.X+370, Coords.Y+325, 1, 0, 0, 10);
}

public static void MainClockSpeedMenu()
{
MouseClick("Left", Coords.X+370, Coords.Y+375, 1, 0, 0, 10);
}

public static void MainSignalPathMenu()
{
MouseClick("Left", Coords.X+370, Coords.Y+430, 1, 0, 0, 10);
}

public static void MainLutchButton()
{
MouseClick("Left", Coords.X+345, Coords.Y+480, 1, 0, 0, 10);
Thread.Sleep(100);
Speak(CheckStateImg("Lutch", Coords.X+325, Coords.Y+460, Coords.X+380, Coords.Y+510));
}

public static void MainLutchMenu()
{
MouseClick("Left", Coords.X+395, Coords.Y+480, 1, 0, 0, 10);
}

public static void MainGainMenu()
{
MouseClick("Left", Coords.X+370, Coords.Y+535, 1, 0, 0, 10);
}

public static void MainPartLavelSlider()
{
HostAutomation(Coords.X+320, Coords.Y+590);
}

public static void MainMCheckBox()
{
MouseClick("Left", Coords.X+315, Coords.Y+620, 1, 0, 0, 10);
Thread.Sleep(100);
Speak(CheckStateImg("MainMCheck", Coords.X+290, Coords.Y+590, Coords.X+340, Coords.Y+650));
}

public static void MainSCheckBox()
{
MouseClick("Left", Coords.X+420, Coords.Y+620, 1, 0, 0, 10);
Thread.Sleep(100);
Speak(CheckStateImg("MainSCheck", Coords.X+390, Coords.Y+590, Coords.X+470, Coords.Y+650));
}

public static void MainCutOfSlider()
{
HostAutomation(Coords.X+530, Coords.Y+610);
}

public static void MainLPFCheckBox()
{
MouseClick("Left", Coords.X+705, Coords.Y+590, 1, 0, 0, 10);
Thread.Sleep(100);
Speak(CheckStateImg("MainLPF", Coords.X+715, Coords.Y+585, Coords.X+735, Coords.Y+610));
}

public static void MainHPFCheckBox()
{
MouseClick("Left", Coords.X+705, Coords.Y+610, 1, 0, 0, 10);
Thread.Sleep(100);
Speak(CheckStateImg("MainHPF", Coords.X+715, Coords.Y+595, Coords.X+735, Coords.Y+620));
}

public static void MainResonanseSlider()
{
HostAutomation(Coords.X+810, Coords.Y+610);
}

public static void MainBack()
{
VUILoader("Omnisphere");
}

}
}