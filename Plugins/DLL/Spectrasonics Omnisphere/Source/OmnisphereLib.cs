using System;
using System.Collections.Generic;
using Microsoft.Collections.Extensions;
using System.Threading;
using static MagicKeys.MagicKeys;
using static MKLib;
using System.Windows.Forms;
using System.Drawing;
namespace MagicKeys
{

public partial class Omnisphere
{

public static void GoToLibraryManager()
{
MouseClick("Left", Coords.X+120, Coords.Y+20, 1, 0, 0, 10);
VUILoader("LibraryManager");
}

public static void LibraryManager()
{
int OldX = Coords.X;
List<OCRResult> TableLines = new List<OCRResult>();
while(true)
{
int[] ColumnSeparator = ImgSearchArea("LibraryManagerLine", OldX, Coords.Y+100, Coords.X+Coords.W, Coords.Y+Coords.H, 50);
if (ColumnSeparator[0] == 0) break;
OCRResult OCRLibraryManager =  GetOCRResult(ColumnSeparator[1] - OldX, 520, OldX, Coords.Y+100, 1);
OldX = ColumnSeparator[1]+5;
TableLines.Add(OCRLibraryManager);
}
OmnisphereLibraryManager Manager = new OmnisphereLibraryManager(TableLines);
Manager.ShowDialog();
}

}

public class OmnisphereLibraryManager : Form
{

public OrderedDictionary<string, ComboBox> LinesComboBoxes = new OrderedDictionary<string, ComboBox>();

public OmnisphereLibraryManager(List<OCRResult> OCRLibraryManager)
{
this.StartPosition = FormStartPosition.CenterScreen;
this.Text = "Omnisphere library manager";
this.Size = new Size(400, 300);
TableLayoutPanel Table = new TableLayoutPanel();
Table.Size = this.Size;
Table.Location = new Point(0, 0);
Table.ColumnCount = 2;
foreach(var OcrItem in OCRLibraryManager)
{
Table.Controls.Add(new Label() {Text = "курац"});
}
this.Controls.Add(Table);
this.Load += Form_Load;
}

public void Form_Load(object sender, EventArgs e)
{
Application.DoEvents();
this.Activate();
}

}
}