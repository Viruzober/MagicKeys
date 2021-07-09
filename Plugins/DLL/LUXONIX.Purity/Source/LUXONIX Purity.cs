using System;
using System.Threading;
using System.Windows.Forms;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public partial class LUXONIXPurity
{

public static void PurityLoader()
{
if (ImgSearch("Register", true)[0] == 1)
{
VUILoader("Register");
return;
}
}

public static void Register()
{
InputTextBox ITBS = new InputTextBox();
ITBS.Text = T._("Enter serial");
ITBS.InputBoxLabel.Text = T._("Enter serial key.");
ITBS.ShowDialog();
InputTextBox ITBC = new InputTextBox();
ITBC.Text = T._("Enter Activation code");
ITBC.InputBoxLabel.Text = T._("Enter activation code.");
ITBC.ShowDialog();
if (ITBS.DialogResult == DialogResult.OK)
{
string[] Serial = ITBS.GetString().Split("-");
string[] Code = ITBC.GetString().Split("-");
int temp = 0;
for(int I = 0; I <= 4; I++)
{
MouseClick("Left", P[1]+383+temp, P[2]+303, 1, 0, 0, 10);
int[] MP = GetMousePosition();
ControlSetTextPoint(MP[0], MP[1], Serial[I]);
MouseClick("Left", P[1]+383+temp, P[2]+365, 1, 0, 0, 10);
int[] MPC = GetMousePosition();
ControlSetTextPoint(MPC[0], MPC[1], Code[I]);
temp += 70;
}
MouseClick("Left", P[1]+667, P[2]+416, 1, 0, 0, 10);
Thread.Sleep(1000);
if (ImgSearch("Register", true)[0] == 0)
{
VUILoader("Purity");
}
}
}

public static void BPMenu()
{
MouseClick("Right", P[1]+70, P[2]+30, 1, 0, 0, 10);
}

}
}