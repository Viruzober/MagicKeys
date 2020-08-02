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

        public DebugForm()
{
InitTextBox();
InitForm();
}

public void InitTextBox()
{
DebugText.Location = new Point(10, 10);
DebugText.Size = new Size(300, 400);
DebugText.Multiline = true;
DebugText.ReadOnly = true;
DebugText.KeyDown += DebugText_KeyDown;
this.Controls.Add(DebugText);
}

public void InitForm()
{
this.TopMost = true;
this.StartPosition = FormStartPosition.CenterScreen;
this.MaximizeBox = false;
this.MinimizeBox = false;
this.Size = new Size(335, 455);
this.Name = "DebugForm";
this.Text = "Error";
this.Shown += DebugForm_Shown;
}

}
}