using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class HelpForm : Form
{
public string HelpFile;
public TextBox HelpText = new TextBox();

        public HelpForm()
{
InitTextBox();
InitForm();
}

public void InitTextBox()
{
HelpText.Location = new Point(10, 10);
HelpText.Size = new Size(300, 400);
HelpText.Multiline = true;
HelpText.ReadOnly = true;
HelpText.KeyDown += HelpForm_KeyDown;
this.Controls.Add(HelpText);
}

public void InitForm()
{
this.TopMost = true;
this.StartPosition = FormStartPosition.CenterScreen;
this.MaximizeBox = false;
this.MinimizeBox = false;
this.Size = new Size(335, 455);
this.Name = "HelpForm";
this.Text = "Help";
this.Shown += HelpForm_Shown;
}

}
}