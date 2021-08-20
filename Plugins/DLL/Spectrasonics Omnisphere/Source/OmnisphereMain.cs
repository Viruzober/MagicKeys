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

public static void MainVelocityLinear()
{
MouseClick("Left", Coords.X+1030, Coords.Y+270, 1, 0, 0, 10);
Thread.Sleep(100);
Speak(CheckStateImg("VelocityLinear", Coords.X+1025, Coords.Y+265, Coords.X+1055, Coords.Y+290));
}

public static void MainVelocityExponentialPositive()
{
MouseClick("Left", Coords.X+1060, Coords.Y+270, 1, 0, 0, 10);
Thread.Sleep(100);
Speak(CheckStateImg("VelocityExponentialPositive", Coords.X+1055, Coords.Y+265, Coords.X+1080, Coords.Y+290));
}

public static void MainVelocityExponentialNegative()
{
MouseClick("Left", Coords.X+1030, Coords.Y+290, 1, 0, 0, 10);
Thread.Sleep(100);
Speak(CheckStateImg("VelocityExponentialNegative", Coords.X+1025, Coords.Y+285, Coords.X+1050, Coords.Y+300));
}

public static void MainVelocityFlat()
{
MouseClick("Left", Coords.X+1060, Coords.Y+290, 1, 0, 0, 10);
Thread.Sleep(100);
Speak(CheckStateImg("VelocityFlat", Coords.X+1055, Coords.Y+285, Coords.X+1080, Coords.Y+300));
}

public static void MainSoloLegato()
{
MouseClick("Left", Coords.X+1000, Coords.Y+380, 1, 0, 0, 10);
Thread.Sleep(200);
Speak(CheckStateImg("SoloLegato", Coords.X+995, Coords.Y+375, Coords.X+1020, Coords.Y+400));
}

public static void MainSolo()
{
MouseClick("Left", Coords.X+1040, Coords.Y+365, 1, 0, 0, 10);
Thread.Sleep(200);
Speak(CheckStateImg("Solo", Coords.X+1035, Coords.Y+360, Coords.X+1060, Coords.Y+380));
}

public static void MainGlideLegato()
{
MouseClick("Left", Coords.X+1000, Coords.Y+425, 1, 0, 0, 10);
Thread.Sleep(200);
Speak(CheckStateImg("GlideLegato", Coords.X+995, Coords.Y+420, Coords.X+1020, Coords.Y+445));
}

public static void MainGlide()
{
MouseClick("Left", Coords.X+1040, Coords.Y+425, 1, 0, 0, 10);
Thread.Sleep(200);
string CheckState = CheckStateImg("Glide", Coords.X+1035, Coords.Y+420, Coords.X+1060, Coords.Y+445);
Speak(CheckState);
if(CheckState == "Checked")
{
VUIObjectSwitcher(false, "true", "24", "27");
return;
}
VUIObjectSwitcher(false, "false", "24", "27");
}

public static void MainGlideA()
{
MouseClick("Left", Coords.X+1030, Coords.Y+465, 1, 0, 0, 10);
Thread.Sleep(200);
Speak(CheckStateImg("GlideA", Coords.X+1000, Coords.Y+450, Coords.X+1090, Coords.Y+490));
}

public static void MainGlideB()
{
MouseClick("Left", Coords.X+1040, Coords.Y+465, 1, 0, 0, 10);
Thread.Sleep(200);
Speak(CheckStateImg("GlideB", Coords.X+1000, Coords.Y+450, Coords.X+1090, Coords.Y+490));
}

public static void MainGlideC()
{
MouseClick("Left", Coords.X+1055, Coords.Y+465, 1, 0, 0, 10);
Thread.Sleep(200);
Speak(CheckStateImg("GlideC", Coords.X+1000, Coords.Y+450, Coords.X+1090, Coords.Y+490));
}

public static void MainGlideD()
{
MouseClick("Left", Coords.X+1075, Coords.Y+465, 1, 0, 0, 10);
Thread.Sleep(200);
Speak(CheckStateImg("GlideD", Coords.X+1000, Coords.Y+450, Coords.X+1090, Coords.Y+490));
}

public static void MainGlideTimeSlider()
{
HostAutomation(Coords.X+1105, Coords.Y+435);
}

public static void MainPitchBandUp()
{
MouseClick("Left", Coords.X+1020, Coords.Y+510, 1, 0, 0, 10);
}

public static void MainPitchBandDown()
{
MouseClick("Left", Coords.X+1090, Coords.Y+510, 1, 0, 0, 10);
}

public static void MainSustainSlider()
{
HostAutomation(Coords.X+990, Coords.Y+600);
}

public static void MainSustainCheckBox()
{
MouseClick("Left", Coords.X+1030, Coords.Y+590, 1, 0, 0, 10);
Thread.Sleep(200);
Speak(CheckStateImg("MainSustainCheckBox", Coords.X+1025, Coords.Y+585, Coords.X+1050, Coords.Y+610));
}

public static void MainSustainBtn1()
{
MouseClick("Left", Coords.X+995, Coords.Y+585, 1, 0, 0, 10);
Thread.Sleep(200);
Speak(CheckStateImg("MainSustain1", Coords.X+990, Coords.Y+570, Coords.X+1010, Coords.Y+610));
}

public static void MainSustainBtn2()
{
MouseClick("Left", Coords.X+995, Coords.Y+595, 1, 0, 0, 10);
Thread.Sleep(200);
Speak(CheckStateImg("MainSustain2", Coords.X+990, Coords.Y+570, Coords.X+1010, Coords.Y+610));
}

public static void MainExpressionCheckBox()
{
MouseClick("Left", Coords.X+1090, Coords.Y+595, 1, 0, 0, 10);
Thread.Sleep(200);
Speak(CheckStateImg("ExpressionCheckBox", Coords.X+1085, Coords.Y+570, Coords.X+1110, Coords.Y+610));
}

public static void MainBack()
{
VUILoader("Omnisphere");
}

}
}