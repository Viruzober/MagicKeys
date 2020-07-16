using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
 
namespace MagicKeys
{
public partial class OmnisphereSearchForm : Form
{

public static string Result;
public Label SearchLabel = new Label();
public TextBox SearchText = new TextBox();
public Button OK = new Button();
public Button Cancel = new Button();
public Label LabelBank = new Label();
public Label LabelPatch = new Label();
public static ListView ListPatch = new ListView();
public ListView ListBank = new ListView();

public OmnisphereSearchForm()
{
InitForm();
InitTextBox();
InitLabel();
InitListView();
InitButton();
}

public void InitButton()
{
OK.Location = new Point(320, 10);
OK.Size = new Size(50, 30);
OK.TabIndex = 6;
OK.Text = "OK";
OK.Enabled = false;
OK.Click += ButtonOK_Click;
this.Controls.Add(OK);
Cancel.Location = new Point(390, 10);
Cancel.Size = new Size(50, 30);
Cancel.TabIndex = 7;
Cancel.Text = "Cancel";
Cancel.Click += ButtonCancel_Click;
this.Controls.Add(Cancel);
}

public void InitTextBox()
{
SearchText.Location = new Point(100, 10);
SearchText.Size = new Size(200, 25);
SearchText.TabIndex = 1;
SearchText.KeyDown += SearchText_KeyDown;
this.Controls.Add(SearchText);
}

public void InitLabel()
{
SearchLabel.Location = new Point(10, 10);
SearchLabel.Size = new Size(80, 25);
SearchLabel.Text = "Поиск";
SearchLabel.TabIndex = 0;
this.Controls.Add(SearchLabel);
LabelBank.Text = "Категории";
LabelBank.Location = new Point(10, 50);
LabelBank.Size = new Size(200, 25);
LabelBank.TabIndex = 2;
this.Controls.Add(LabelBank);
LabelPatch.Text = "Патчи";
LabelPatch.Location = new Point(280, 50);
LabelPatch.Size = new Size(200, 25);
LabelPatch.TabIndex = 4;
this.Controls.Add(LabelPatch);
}

public void InitListView()
{
ListBank.Location = new Point(10, 80);
ListBank.Size = new Size(250, 300);
ListBank.TabIndex = 3;
ListBank.SelectedIndexChanged += ListBank_SelectedIndexChanged;
ListBank.MultiSelect = false;
ListBank.View = View.Details;
ListBank.Columns.Add(new ColumnHeader());
ListBank.Columns[0].Text = "Banks";
this.Controls.Add(ListBank);
ListPatch.Location = new Point(280, 80);
ListPatch.Size = new Size(250, 300);
ListPatch.TabIndex = 5;
ListPatch.MultiSelect = false;
ListPatch.View = View.Details;
ListPatch.SelectedIndexChanged += ListPatch_SelectedIndexChanged;
ListPatch.Columns.Add(new ColumnHeader());
ListPatch.Columns[0].Text = "Patches";
this.Controls.Add(ListPatch);
}

public void InitForm()
{
this.Size = new Size(555, 430);
this.Name = "OmnisphereSearch";
this.StartPosition = FormStartPosition.CenterScreen;
this.MaximizeBox = false;
this.MinimizeBox = false;
this.Text = "Поиск";
this.TopMost = true;
this.Shown += Form_Shown;
this.CancelButton = Cancel;
}

}
}