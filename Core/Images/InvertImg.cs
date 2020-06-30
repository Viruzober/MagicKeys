using System;
using System.Drawing.Imaging;
using System.Threading;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using Windows;
using System.Threading.Tasks;
using Windows.Media.Ocr;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static Bitmap InvertImg(Bitmap bitmap)
{
int x;
int y;
for (x = 0; x <= bitmap.Width - 1; x++)
{
for (y = 0; y <= bitmap.Height - 1; y += 1)
{
Color oldColor = bitmap.GetPixel(x, y);
Color newColor;
newColor = Color.FromArgb(oldColor.A, 255 - oldColor.R, 255 - oldColor.G, 255 - oldColor.B);
bitmap.SetPixel(x, y, newColor);
}
}
            return bitmap;
        }

}
}