using System;
using System.Threading;
using static MagicKeys.MagicKeys;
using static MKLib;
using System.Windows.Forms;

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
KeyUnReg();
OCRResult r =  GetOCRResult(Coords.W, Coords.H, Coords.X, Coords.Y, 1);
OmnisphereLibraryManager omnisphereLibraryManager = new OmnisphereLibraryManager(r);
omnisphereLibraryManager.ShowDialog();
KeyReg();
}

}

public class OmnisphereLibraryManager : Form
{

public OmnisphereLibraryManager(OCRResult r)
{
this.Size = new System.Drawing.Size(100, 100);
this.Location = new System.Drawing.Point(100, 100);
ComboBox t = new ComboBox();
t.Location = new System.Drawing.Point(10, 10);
t.Size = new System.Drawing.Size(100, 100);
t.DropDownStyle = ComboBoxStyle.DropDownList;
foreach(var item in r.lines)
{
t.Items.Add(item.text);
}
this.Controls.Add(t);
this.Load += wshow;
}


public void wshow(object sender, EventArgs e)
{
this.Activate();
}

}
}