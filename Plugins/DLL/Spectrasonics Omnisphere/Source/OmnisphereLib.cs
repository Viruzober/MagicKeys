using System;
using System.Collections.Generic;
using Microsoft.Collections.Extensions;
using System.Threading;
using static MagicKeys.MagicKeys;
using static MKLib;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;

namespace MagicKeys
{

public partial class Omnisphere
{

public static void GoToLibraryManager()
{
MouseClick("Left", Coords.X+120, Coords.Y+20, 1, 0, 0, 10);
VUILoader("LibraryManager");
}

public static void SelectLibrary()
{
MouseClick("Left", Coords.X+60, Coords.Y+60, 1, 0, 0, 10);
}

public static void LibraryManager()
{
int OldX = Coords.X;
while(true)
{
int[] ColumnSeparator = ImgSearchArea("LibraryManagerLine", OldX, Coords.Y+90, Coords.X+Coords.W, Coords.Y+Coords.H, 40);
if (ColumnSeparator[0] == 0) break;
OCRResult OCRLibraryManager =  GetOCRResult(ColumnSeparator[1] - OldX, 520, OldX, Coords.Y+90, 2);
OmnisphereLibraryManager Manager = new OmnisphereLibraryManager(OCRLibraryManager);
Manager.ShowDialog();
if (string.IsNullOrEmpty(Manager.GetSelectedValue())) break;
foreach(var ClickItem in OCRLibraryManager.Lines)
{
if (ClickItem.Text == Manager.GetSelectedValue())
{
Rect SelectedRect = ClickItem.Words[0].BoundingRect;
MouseClick("Left", OldX + (SelectedRect.X / 2), ColumnSeparator[2] + (SelectedRect.Y / 2), 1, 0, 0, 20);
}
}
OldX = ColumnSeparator[1] + (ColumnSeparator[3] / 2);
Thread.Sleep(500);
}
Speak("Done");
}

}

public class OmnisphereLibraryManager : Form
{

public ComboBox LinesComboBox = new ComboBox();

public OmnisphereLibraryManager(OCRResult OCRLibraryManager)
{
this.StartPosition = FormStartPosition.CenterScreen;
this.Text = "Omnisphere library manager";
TableLayoutPanel Table = new TableLayoutPanel();
Table.Location = new Point(0, 0);
Table.ColumnCount = 2;
Table.Controls.Add(new Label() {Text = OCRLibraryManager.Lines[0].Text.Trim()});
string[] ComboBoxValues = OCRLibraryManager.Lines.Select(t => t.Text).ToArray();
LinesComboBox.Items.AddRange(ComboBoxValues[1..]);
Table.Controls.Add(LinesComboBox);
this.Controls.Add(Table);
this.Load += Form_Load;
LinesComboBox.KeyDown += Form_KeyDown;
}

public void Form_Load(object sender, EventArgs e)
{
this.Activate();
}

public void Form_KeyDown(object Sender, KeyEventArgs e)
{
if (e.KeyCode == Keys.Enter)
{
if (LinesComboBox.SelectedIndex == -1)
{
Speak("Please select item");
return;
}
this.Close();
}
else if (e.KeyCode == Keys.Escape)
{
LinesComboBox.SelectedItem = null;
this.Close();
}
}

public string GetSelectedValue()
{
if (LinesComboBox.SelectedItem == null) return null;
return LinesComboBox.SelectedItem.ToString();
}

}
}