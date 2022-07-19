using System.Threading;
using System.Windows.Forms;
using static MagicKeys.MagicKeys;
using static MKLib;

namespace MagicKeys
{

public partial class LUXONIXPurity
{

public static void PurityLoader()
{
if (ImageSearch("Register", true)[0] == 1)
{
VUILoader("Register");
return;
}
}

public static void Register()
{
InputTextBox ITBS = new InputTextBox();
ITBS.Text = "Enter serial";
ITBS.InputBoxLabel.Text = "Enter serial key.";
ITBS.ShowDialog();
InputTextBox ITBC = new InputTextBox();
ITBC.Text = "Enter Activation code";
ITBC.InputBoxLabel.Text = "Enter activation code.";
ITBC.ShowDialog();
if (ITBS.DialogResult == DialogResult.OK)
{
string[] Serial = ITBS.GetString().Split("-");
string[] Code = ITBC.GetString().Split("-");
int temp = 0;
for(int I = 0; I <= 4; I++)
{
MouseClick("Left", Coords.X+383+temp, Coords.Y+303, 1, 0, 0, 10);
int[] MP = GetMousePosition();
ControlSetTextPoint(MP[0], MP[1], Serial[I]);
MouseClick("Left", Coords.X+383+temp, Coords.Y+365, 1, 0, 0, 10);
int[] MPC = GetMousePosition();
ControlSetTextPoint(MPC[0], MPC[1], Code[I]);
temp += 70;
}
MouseClick("Left", Coords.X+667, Coords.Y+416, 1, 0, 0, 10);
Thread.Sleep(1000);
if (ImageSearch("Register", true)[0] == 0)
{
VUILoader("Purity");
}
}
}

public static void BPMenu()
{
MouseClick("Right", Coords.X+70, Coords.Y+30, 1, 0, 0, 10);
}

}
}