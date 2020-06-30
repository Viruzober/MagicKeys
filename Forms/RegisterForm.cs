using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class RegisterForm : Form
{

public TextBox UserName = new TextBox();
public TextBox UserMail = new TextBox();
Button Reg = new Button();
Button Can = new Button();

public RegisterForm()
{
InitLabel();
InitTextBox();
InitButton();
InitForm();
}

public void InitLabel()
{
Label Name = new Label();
Name.TabIndex = 0;
Name.Location = new Point(10, 15);
Name.Size = new Size(130, 30);
Name.Text = "Имя и фамилия";
this.Controls.Add(Name);
Label Mail = new Label();
Mail.TabIndex = 2;
Mail.Location = new Point(10, 55);
Mail.Size = new Size(130, 30);
Mail.Text = "E-Mail";
this.Controls.Add(Mail);
}

public void InitTextBox()
{
UserName.TabIndex = 1;
UserName.Location = new Point(160, 10);
UserName.Size = new Size(150, 30);
this.Controls.Add(UserName);
UserMail.TabIndex = 3;
UserMail.Location = new Point(160, 50);
UserMail.Size = new Size(150, 30);
this.Controls.Add(UserMail);
}

public void InitButton()
{
Reg.DialogResult = DialogResult.OK;
Reg.Location = new Point(30, 100);
Reg.Size = new Size(150, 50);
Reg.Text = "Зарегистрироваться";
Reg.Click += Reg_Click;
this.Controls.Add(Reg);
Can.DialogResult = DialogResult.Cancel;
Can.Location = new Point(200, 100);
Can.Size = new Size(100, 50);
Can.Text = "Отмена";
Can.Click += Can_Click;
this.Controls.Add(Can);
}

public void InitForm()
{
this.TopMost = true;
this.StartPosition = FormStartPosition.CenterScreen;
this.Size = new Size(340, 200);
this.MaximizeBox = false;
this.MinimizeBox = false;
this.Text = "Регистрация";
this.Name = "RegisterForm";
this.Shown += RegisterForm_Shown;
this.Closed += RegisterForm_Closed;
}

}
}