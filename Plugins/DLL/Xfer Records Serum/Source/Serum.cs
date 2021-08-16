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
if (API.GetWClass() == "#32770")
{
Speak(ControlGetTextPoint(Coords.X+100, Coords.Y-20));
}
}

public static void NextPreset()
{
MouseClick("Left", Coords.X+710, Coords.Y+10, 1, 0, 0, 10);
if (API.GetWClass() == "#32770")
{
Speak(ControlGetTextPoint(Coords.X+100, Coords.Y-20));
}
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
ITBC.Text = T._("Enter Activation code");
ITBC.InputBoxLabel.Text = T._("Enter activation code.");
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