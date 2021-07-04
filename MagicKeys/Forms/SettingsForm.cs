using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class SettingsForm : Form
{

public CheckBox NavigationType = new CheckBox();
public CheckBox SoundTheme = new CheckBox();
public Label TimeOut = new Label();
public NumericUpDown Time = new NumericUpDown();
public CheckBox SpeakType = new CheckBox();
public CheckBox Exit = new CheckBox();
public Button Help = new Button();
public Button Save = new Button();
public Button Cancel = new Button();

        public SettingsForm()
{
InitCheckBox();
InitLabel();
InitNumericUpDown();
InitButton();
InitForm();
}

public void InitCheckBox()
{
NavigationType.Location = new Point(10, 10);
NavigationType.Size = new Size(480, 30);
NavigationType.Text = T._("Use left/right arrow keys for navigation");
NavigationType.TabIndex = 0;
this.Controls.Add(NavigationType);
SoundTheme.Location = new Point(10, 40);
SoundTheme.Size = new Size(300, 30);
SoundTheme.Text = T._("Enable sounds");
SoundTheme.TabIndex = 1;
this.Controls.Add(SoundTheme);
SpeakType.Location = new Point(10, 120);
SpeakType.Size = new Size(400, 30);
SpeakType.Text = T._("Speak control types");
SpeakType.TabIndex = 2;
this.Controls.Add(SpeakType);
Exit.Location = new Point(10, 150);
Exit.Size = new Size(400, 30);
Exit.Text = T._("Ask before exiting");
Exit.TabIndex = 5;
this.Controls.Add(Exit);
}

public void InitLabel()
{
TimeOut.Location = new Point(10, 80);
TimeOut.Size = new Size(200, 30);
TimeOut.Text = T._("Window detection timeout (ms):");
TimeOut.TabIndex = 3;
this.Controls.Add(TimeOut);
}

public void InitNumericUpDown()
{
Time.Location = new Point(210, 75);
Time.Size = new Size(50, 30);
Time.Maximum = 100;
Time.Minimum = 20;
Time.TabIndex = 4;
this.Controls.Add(Time);
}

public void InitButton()
{
Help.Location = new Point(10, 310);
Help.Size = new Size(100, 40);
Help.Text = T._("Help");
Help.Click += Help_Click;
Help.TabIndex = 7;
this.Controls.Add(Help);
Save.Location = new Point(250, 310);
Save.Size = new Size(100, 40);
Save.Text = T._("Save");
Save.Click += Save_Click;
Save.TabIndex = 8;
this.Controls.Add(Save);
Cancel.Location = new Point(370, 310);
Cancel.Size = new Size(100, 40);
Cancel.Text = T._("Cancel");
Cancel.Click += Cancel_Click;
Cancel.TabIndex = 9;
this.Controls.Add(Cancel);
}

public void InitForm()
{
this.TopMost = true;
this.StartPosition = FormStartPosition.CenterScreen;
this.MaximizeBox = false;
this.MinimizeBox = false;
this.Size = new Size(500, 400);
this.Name = "SettingsForm";
this.Text = T._("Settings");
this.Shown += SettingsForm_Shown;
this.AcceptButton = Save;
this.CancelButton = Cancel;
}

}
}