using System;
using System.Threading;
using System.Windows.Forms;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public static partial class Kontakt
{

public static int[] GetPos()
{
int[] Img = ImgSearch(@"Images\Kontakt\NIK_Logo.BMP");
if (Img[0] == 1)
{
IntPtr Handle = GetWinPointHandle(Img[5], Img[6]);
int[] Rect = GetWinRect(Handle);
int[] ControlCoord;
ControlCoord = new int[5] {Img[0], Rect[0], Rect[1], Rect[2], Rect[3]};
return ControlCoord;
}
else
{
return Img;
}
}

}
}