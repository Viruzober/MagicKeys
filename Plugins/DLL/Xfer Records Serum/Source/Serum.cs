using System.Threading;
using System.Windows.Forms;
using static MagicKeys.MagicKeys;
using static MKLib;

namespace MagicKeys
{

public partial class Serum
{

public static void PresetsMenu()
{
MouseClick("Left", Coords.X+660, Coords.Y+10, 1, 0, 0, 10);
}

public static void PreviousPreset()
{
MouseClick("Left", Coords.X+690, Coords.Y+10, 1, 0, 0, 10);
Thread.Sleep(100);
Speak(ImgToText(150, 30, Coords.X+450, Coords.Y, 4));
}

public static void NextPreset()
{
MouseClick("Left", Coords.X+710, Coords.Y+10, 1, 0, 0, 10);
Thread.Sleep(100);
Speak(ImgToText(150, 30, Coords.X+450, Coords.Y, 4));
}

public static void SpeakPreset()
{
Speak(ImgToText(150, 30, Coords.X+450, Coords.Y, 4));
}

public static void Menu()
{
MouseClick("Left", Coords.X+770, Coords.Y+10, 1, 0, 0, 10);
}

public static void SavePresetAs()
{
MouseClick("Left", Coords.X+440, Coords.Y+10, 1, 0, 0, 10);
}

public static void Register()
{
InputTextBox ITBC = new InputTextBox();
ITBC.Text = "Enter Activation code";
ITBC.InputBoxLabel.Text = "Enter activation code.";
ITBC.ShowDialog();
if (ITBC.DialogResult == DialogResult.OK)
{
MouseClick("Left", Coords.X+450, Coords.Y+40, 1, 0, 0, 10);
ControlSetTextPoint(Coords.X+450, Coords.Y+40, ITBC.GetString());
Thread.Sleep(50);
MouseClick("Left", Coords.X+710, Coords.Y+340, 1, 0, 0, 10);
Speak("please reload the plugin");
}
}

}
}