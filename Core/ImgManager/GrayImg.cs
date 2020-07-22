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

public static Bitmap GrayImg(Bitmap Img)
{
Bitmap output = new Bitmap(Img.Width, Img.Height);
for (int j = 0; j < Img.Height; j++)
{
for (int i = 0; i < Img.Width; i++)
{
UInt32 pixel = (UInt32)(Img.GetPixel(i, j).ToArgb());
float R = (float)((pixel & 0x00FF0000) >> 16);
float G = (float)((pixel & 0x0000FF00) >> 8);
float B = (float)(pixel & 0x000000FF);
R = G = B = (R + G + B) / 3.0f;
UInt32 newPixel = 0xFF000000 | ((UInt32)R << 16) | ((UInt32)G << 8) | ((UInt32)B);
output.SetPixel(i, j, Color.FromArgb((int)newPixel));
}
}
return output;
}

}
}