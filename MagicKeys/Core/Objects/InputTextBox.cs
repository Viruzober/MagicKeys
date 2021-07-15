using System;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class MagicKeys
{

public static string InputTextBox(string Title, string Text)
{
InputTextBox ITB = new InputTextBox();
ITB.Text = Title;
ITB.InputBoxLabel.Text = Text;
ITB.ShowDialog();
if (ITB.DialogResult == DialogResult.OK)
{
return ITB.GetString();
}
else if (ITB.DialogResult == DialogResult.Cancel)
{
return null;
}
else
{
return null;
}
}

}
}