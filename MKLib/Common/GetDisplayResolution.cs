using System;
using System.Drawing;

public static partial class MKLib
{

public static Size GetDisplayResolution()
{
return System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
}

}