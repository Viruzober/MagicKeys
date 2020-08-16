using System;
using System.Drawing;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class InputTextBox : Form
{

public Label InputBoxLabel = new Label();
public TextBox Value = new TextBox();
public Button ButtonOK = new Button();
public Button ButtonCancel = new Button();

public InputTextBox()
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
Value.Size = new Size(250, 25);
Value.Font = new Font(TextBox.DefaultFont, FontStyle.Regular);
Value.Location = new Point(20, 50);
this.Controls.Add(Value);
}

public void InitButton()
{
ButtonOK.Size = new Size(80, 25);
ButtonOK.Location = new Point(105, 75);
ButtonOK.Text = "OK";
ButtonOK.Click += ButtonOK_Click;
this.Controls.Add(ButtonOK);
ButtonCancel.Size = new Size(80, 25);
ButtonCancel.Location = new Point(190, 75);
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
this.Size = new Size(300, 150);
this.Name = "InputTextBox";
this.AcceptButton = ButtonOK;
this.CancelButton = ButtonCancel;
this.Shown += InputTextBox_Shown;
}

}
}