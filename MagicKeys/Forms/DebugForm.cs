using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class DebugForm : Form
{
public string DebugInfo;
public TextBox DebugText = new TextBox();
public Button Exit = new Button();

        public DebugForm()
{
InitTextBox();
InitButton();
InitForm();
}

public void InitTextBox()
{
DebugText.Location = new Point(10, 10);
DebugText.Size = new Size(400, 150);
DebugText.Multiline = true;
DebugText.ReadOnly = true;
this.Controls.Add(DebugText);
}

public void InitButton()
{
Exit.Size = new Size(400, 25);
Exit.Location = new Point(10, 180);
Exit.Text = T._("Exit");
Exit.Click += Exit_Click;
this.Controls.Add(Exit);
}

public void InitForm()
{
this.TopMost = true;
this.StartPosition = FormStartPosition.CenterScreen;
this.MaximizeBox = false;
this.MinimizeBox = false;
this.Size = new Size(435, 250);
this.Name = "DebugForm";
this.Text = T._("Error");
this.AcceptButton = Exit;
this.CancelButton = Exit;
this.Shown += DebugForm_Shown;
}

}
}