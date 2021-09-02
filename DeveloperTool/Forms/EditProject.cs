using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace DeveloperTool
{
public partial class EditProjectForm : Form
{

public TextBox ProjectName = new TextBox() {Dock = DockStyle.Fill};
public TextBox Author = new TextBox() {Dock = DockStyle.Fill};
public TextBox Email = new TextBox() {Dock = DockStyle.Fill};
public Button Save = new Button() {Text = T._("Save"), Size = new Size(80, 40)};
public Button Cancel = new Button() {Text = T._("Cancel"), Size = new Size(80, 40)};

public EditProjectForm()
{
this.Text = T._("EditProject");
this.StartPosition = FormStartPosition.CenterScreen;
this.MinimizeBox = false;
this.MaximizeBox = false;
this.AcceptButton = Save;
this.CancelButton = Cancel;
TableLayoutPanel Table = new TableLayoutPanel();
Table.ColumnCount = 2;
Table.Location = new Point(10, 10);
Table.Size = new Size(420, 300);
Table.Controls.Add(new Label() {Text = "Name"});
Table.Controls.Add(ProjectName);
Table.Controls.Add(new Label() {Text = "Author"});
Table.Controls.Add(Author);
Table.Controls.Add(new Label() {Text = "E-Mail"});
Table.Controls.Add(Email);
Table.Controls.Add(Save, 2, 4);
Table.Controls.Add(Cancel, 2, 5);
this.Size = new Size(Table.Size.Width+50, Table.Size.Height+30);
this.Controls.Add(Table);
this.Paint += Form_Show;
Save.Click += Click_Save;
Cancel.Click += Click_Cancel;
}

}
}