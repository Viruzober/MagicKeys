using System;
using System.Drawing;

namespace MagicKeys
{
public partial class MagicKeys
{

public static Size GetDisplayResolution()
{
return System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
}

}
}