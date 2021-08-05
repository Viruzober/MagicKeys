using System.Threading;
using System.Windows.Forms;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public partial class Serum
{
public static void PresetsMenu()
{
MouseClick("Left", P[1]+660, P[2]+10, 1, 0, 0, 10);
}

public static void PreviousPreset()
{
MouseClick("Left", P[1]+690, P[2]+10, 1, 0, 0, 10);
if (API.GetWClass() == "#32770")
{
Speak(ControlGetTextPoint(P[1]+100, P[2]-20));
}
}

public static void NextPreset()
{
MouseClick("Left", P[1]+710, P[2]+10, 1, 0, 0, 10);
if (API.GetWClass() == "#32770")
{
Speak(ControlGetTextPoint(P[1]+100, P[2]-20));
}
}

public static void Menu()
{
MouseClick("Left", P[1]+770, P[2]+10, 1, 0, 0, 10);
}

public static void SavePresetAs()
{
MouseClick("Left", P[1]+440, P[2]+10, 1, 0, 0, 10);
}

public static void Register()
{
InputTextBox ITBC = new InputTextBox();
ITBC.Text = T._("Enter Activation code");
ITBC.InputBoxLabel.Text = T._("Enter activation code.");
ITBC.ShowDialog();
if (ITBC.DialogResult == DialogResult.OK)
{
MouseClick("Left", P[1]+450, P[2]+40, 1, 0, 0, 10);
ControlSetTextPoint(P[1]+450, P[2]+40, ITBC.GetString());
Thread.Sleep(50);
MouseClick("Left", P[1]+710, P[2]+340, 1, 0, 0, 10);
Speak("please reload the plugin");
}
}

}
}