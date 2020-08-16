using System;
using System.Drawing;
using System.Windows.Forms;

namespace MKUpdater
{
public partial class UpdateForm : Form
{

public Label UPDL = new Label();
public ProgressBar PB = new ProgressBar();
public RichTextBox TB = new RichTextBox();
public Button ButtonOK = new Button();
public Button ButtonCancel = new Button();

public UpdateForm()
{
InitLabel();
InitTextBox();
InitProgressBar();
InitButton();
InitForm();
}

public void InitLabel()
{
UPDL.AutoSize = false;
UPDL.Size = new Size(250, 25);
UPDL.Font = new Font(UPDL.Font, FontStyle.Regular);
UPDL.Location = new Point(20, 25);
UPDL.Text = "Change log";
this.Controls.Add(UPDL);
}

public void InitTextBox()
{
TB.Size = new Size(450, 175);
TB.Location = new Point(20, 50);
TB.ReadOnly = true;
TB.Multiline = true;
this.Controls.Add(TB);
}

public void InitProgressBar()
{
PB.Size = new Size(250, 25);
PB.Location = new Point(20, 230);
PB.Minimum = 0;
PB.Maximum = 100;
this.Controls.Add(PB);
}

public void InitButton()
{
ButtonOK.Size = new Size(80, 25);
ButtonOK.Location = new Point(305, 225);
ButtonOK.Text = "Update";
ButtonOK.Click += ButtonOK_Click;
this.Controls.Add(ButtonOK);
ButtonCancel.Size = new Size(80, 25);
ButtonCancel.Location = new Point(390, 225);
ButtonCancel.Text = "Cancel";
ButtonCancel.Enabled = false;
ButtonCancel.Click += ButtonCancel_Click;
this.Controls.Add(ButtonCancel);
}

public void InitForm()
{
this.TopMost = true;
this.StartPosition = FormStartPosition.CenterScreen;
this.MaximizeBox = false;
this.MinimizeBox = false;
this.Size = new Size(500, 300);
this.Name = "Updater";
this.Text = "Update MagicKeys";
}

}
}