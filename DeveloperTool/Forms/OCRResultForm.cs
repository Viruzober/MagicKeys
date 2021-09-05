using System.Drawing;
using System.Windows.Forms;

namespace DeveloperTool
{

public partial class OCRResultForm : Form
{

public ListView WList = new ListView();
public OCRResultForm()
{
InitListBox();
InitForm();
}

public void InitListBox()
{
WList.Location = new Point(10, 10);
WList.Size = new Size(400, 150);
WList.View = View.Details;
WList.MultiSelect = false;
WList.Columns.Add(new ColumnHeader());
WList.Columns[0].Text = "Words";
this.Controls.Add(WList);
WList.KeyDown += Form_KeyDown;
}

public void InitForm()
{
this.TopMost = true;
this.StartPosition = FormStartPosition.CenterScreen;
this.MaximizeBox = false;
this.MinimizeBox = false;
this.Size = new Size(435, 250);
this.Text = T._("OCR Word List");
this.Load += OCRResultForm_Shown;
}

}
}