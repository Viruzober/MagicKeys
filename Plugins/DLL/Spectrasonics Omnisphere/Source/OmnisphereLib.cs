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
OCRResult OCRLibraryManager =  GetOCRResult(720, 520, Coords.X, Coords.Y+100, 1);
OmnisphereLibraryManager manager = new OmnisphereLibraryManager(OCRLibraryManager);
manager.ShowDialog();
}

}

public class OmnisphereLibraryManager : Form
{

public OmnisphereLibraryManager(OCRResult OCRLibraryManager)
{
foreach(var item in OCRLibraryManager.lines)
{

}
this.Load += Form_Load;
}

public void Form_Load(object sender, EventArgs e)
{
this.Activate();
}

}
}