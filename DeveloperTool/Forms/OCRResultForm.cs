using System.Drawing;
using System.Windows.Forms;

namespace DeveloperTool
{
public partial class OCRResultForm : Form
{
public ListBox WList = new ListBox();
public OCRResultForm()
{
InitListBox();
InitForm();
}

public void InitListBox()
{
WList.Location = new Point(10, 10);
WList.Size = new Size(400, 150);
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
this.Name = "DebugForm";
this.Text = T._("OCR Word List");
this.Shown += OCRResultForm_Shown;
}

}
}