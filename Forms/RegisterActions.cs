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
MessageBox.Show("Вы успешно зарегистрировались! Для  применения изменений перезагрузите MagicKeys.", "Внимание");
}
else
{
MessageBox.Show("Что-то пошло не так! Повторите попытку позже, или обратитесь к разработчику.", "Ошибка");
}
}
else
{
MagicKeys.Speak("Некоректный E-Mail");
}
}
else
{
MagicKeys.Speak("Пожалуйста, укажите ваше имя");
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