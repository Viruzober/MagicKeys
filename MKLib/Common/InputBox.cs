using System.Windows.Forms;

public static partial class MKLib
{

public static string InputBox(string Title, string Text, int Start, int End)
{
InputBox IB = new InputBox();
IB.Value.Minimum = Start;
IB.Value.Maximum = End;
IB.Text = Title;
IB.InputBoxLabel.Text = Text;
IB.ShowDialog();
if (IB.DialogResult == DialogResult.OK)
{
return IB.GetString();
}
else if (IB.DialogResult == DialogResult.Cancel)
{
return null;
}
else
{
return null;
}
}

}