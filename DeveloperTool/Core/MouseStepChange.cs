using System;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class DeveloperTool
{

public static void MouseStepChange()
{
InputBox IB = new InputBox();
IB.Value.Minimum = 1;
IB.Value.Maximum = 100;
IB.Text = "Mouse step";
IB.InputBoxLabel.Text = "Enter mouse step";
IB.Show();
if (IB.DialogResult == DialogResult.OK)
{
MouseStep = Convert.ToInt32(IB.GetString());
}
MagicKeys.Speak(MouseStep.ToString());
}

}
}