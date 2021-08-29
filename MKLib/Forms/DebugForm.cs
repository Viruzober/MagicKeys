using System.Drawing;
using System.Windows.Forms;

public partial class DebugForm : Form
{

public TextBox DebugText = new TextBox();
public Button Exit = new Button();
public DebugForm(string DebugInfo)
{
InitTextBox(DebugInfo);
InitButton();
InitForm();
}

public void InitTextBox(string DebugInfo)
{
DebugText.Location = new Point(10, 10);
DebugText.Size = new Size(400, 150);
DebugText.Multiline = true;
DebugText.ReadOnly = true;
DebugText.Text = DebugInfo;
this.Controls.Add(DebugText);
}

public void InitButton()
{
Exit.Size = new Size(400, 25);
Exit.Location = new Point(10, 180);
Exit.Text = "Exit";
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
this.Text = "Error";
this.AcceptButton = Exit;
this.CancelButton = Exit;
this.Shown += DebugForm_Shown;
}

}