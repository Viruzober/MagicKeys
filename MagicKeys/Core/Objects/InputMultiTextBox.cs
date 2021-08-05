using System.Windows.Forms;

namespace MagicKeys
{

public partial class MagicKeys
{

public static string InputMultiTextBox(string Title, string Text)
{
InputMultiTextBox ITB = new InputMultiTextBox();
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