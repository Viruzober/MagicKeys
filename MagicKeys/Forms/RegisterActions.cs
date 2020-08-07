using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class RegisterForm : Form
{

public void Reg_Click(object sender, EventArgs e)
{
string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
Match isMatch = Regex.Match(UserMail.Text, pattern, RegexOptions.IgnoreCase);
if (UserName.Text != "")
{
if (isMatch.Success == true)
{
string ResultReg = MagicKeys.LicenseRegister(UserName.Text, UserMail.Text);
if (ResultReg == "Registered")
{
this.Close();
MagicKeys.RegUser = true;
MagicKeys.HM.Ni.Visible = false;
MagicKeys.HM = new Menu();
MessageBox.Show("Registration Successful. Restart MagicKeys to apply the changes.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
}
else
{
MagicKeys.SoundPlay("Error.wav", 0);
MessageBox.Show("Something has gone wrong. Please try again later or contact the developer.", "Error");
}
}
else
{
MagicKeys.Speak("Incorrect e-mail");
}
}
else
{
MagicKeys.Speak("Please enter your name");
}
}
public void Can_Click(object sender, EventArgs e)
{
this.Close();
}

public void RegisterForm_Shown(object sender, EventArgs e)
{
MagicKeys.HM.RegisterMenuItem.Visible = false;
}

public void RegisterForm_Closed(object sender, EventArgs e)
{
MagicKeys.HM.RegisterMenuItem.Visible = true;
}

}
}