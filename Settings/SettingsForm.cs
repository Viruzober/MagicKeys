using System.Drawing;
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
public Label LUpdateChannel = new Label();
public ComboBox UpdateChannel = new ComboBox();
public CheckBox CheckUpdate = new CheckBox();
public Button Help = new Button();
public Button Save = new Button();
public Button Cancel = new Button();
public SettingsForm()
{
InitControls();
InitButton();
InitForm();
}

public void InitControls()
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
TimeOut.Location = new Point(10, 80);
TimeOut.Size = new Size(200, 30);
TimeOut.Text = T._("Window detection timeout (ms):");
TimeOut.TabIndex = 2;
this.Controls.Add(TimeOut);
Time.Location = new Point(210, 75);
Time.Size = new Size(50, 30);
Time.Maximum = 100;
Time.Minimum = 20;
Time.TabIndex = 3;
this.Controls.Add(Time);
SpeakType.Location = new Point(10, 120);
SpeakType.Size = new Size(400, 30);
SpeakType.Text = T._("Speak control types");
SpeakType.TabIndex = 4;
this.Controls.Add(SpeakType);
Exit.Location = new Point(10, 150);
Exit.Size = new Size(400, 30);
Exit.Text = T._("Ask before exiting");
Exit.TabIndex = 5;
this.Controls.Add(Exit);
LUpdateChannel.Location = new Point(10, 190);
LUpdateChannel.Size = new Size(100, 30);
LUpdateChannel.Text = T._("Update channel");
LUpdateChannel.TabIndex = 6;
this.Controls.Add(LUpdateChannel);
UpdateChannel.Location = new Point(110, 180);
UpdateChannel.Size = new Size(100, 30);
UpdateChannel.Items.AddRange(new string[2] {"Release", "Nightly"});
UpdateChannel.DropDownStyle = ComboBoxStyle.DropDownList;
UpdateChannel.TabIndex = 7;
this.Controls.Add(UpdateChannel);
CheckUpdate.Location = new Point(10, 210);
CheckUpdate.Size = new Size(400, 30);
CheckUpdate.TabIndex = 8;
CheckUpdate.Text = T._("check for updates when magicKeys starts");
this.Controls.Add(CheckUpdate);
}

public void InitButton()
{
Help.Location = new Point(10, 310);
Help.Size = new Size(100, 40);
Help.Text = T._("Help");
Help.Click += Help_Click;
Help.TabIndex = 9;
this.Controls.Add(Help);
Save.Location = new Point(250, 310);
Save.Size = new Size(100, 40);
Save.Text = T._("Save");
Save.Click += Save_Click;
Save.TabIndex = 10;
this.Controls.Add(Save);
Cancel.Location = new Point(370, 310);
Cancel.Size = new Size(100, 40);
Cancel.Text = T._("Cancel");
Cancel.Click += Cancel_Click;
Cancel.TabIndex = 11;
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