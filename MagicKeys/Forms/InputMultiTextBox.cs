using System;
using System.Drawing;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class InputMultiTextBox : Form
{

public Label InputBoxLabel = new Label();
public TextBox Value = new TextBox();
public Button ButtonOK = new Button();
public Button ButtonCancel = new Button();

public InputMultiTextBox()
{
InitLabel();
InitTextBox();
InitButton();
InitForm();
}

public void InitLabel()
{
InputBoxLabel.AutoSize = false;
InputBoxLabel.Size = new Size(250, 25);
InputBoxLabel.Font = new Font(InputBoxLabel.Font, FontStyle.Regular);
InputBoxLabel.Location = new Point(20, 25);
this.Controls.Add(InputBoxLabel);
}

public void InitTextBox()
{
Value.Size = new Size(350, 150);
Value.Font = new Font(TextBox.DefaultFont, FontStyle.Regular);
Value.Location = new Point(20, 50);
Value.Multiline = true;
this.Controls.Add(Value);
}

public void InitButton()
{
ButtonOK.Size = new Size(80, 25);
ButtonOK.Location = new Point(205, 200);
ButtonOK.Text = "OK";
ButtonOK.Click += ButtonOK_Click;
this.Controls.Add(ButtonOK);
ButtonCancel.Size = new Size(80, 25);
ButtonCancel.Location = new Point(290, 200);
ButtonCancel.Text = "Cancel";
ButtonCancel.Click += ButtonCancel_Click;
this.Controls.Add(ButtonCancel);
}

public void InitForm()
{
this.TopMost = true;
this.StartPosition = FormStartPosition.CenterScreen;
this.MaximizeBox = false;
this.MinimizeBox = false;
this.Size = new Size(400, 275);
this.Name = "InputTextBox";
this.AcceptButton = ButtonOK;
this.CancelButton = ButtonCancel;
}

}
}