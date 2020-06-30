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

public static Bitmap MonoImg(Bitmap bmpImg, int P)
{
Bitmap result = new Bitmap(bmpImg.Width, bmpImg.Height);
Color color = new Color();
for (int j = 0; j < bmpImg.Height; j++)
{
for (int i = 0; i < bmpImg.Width; i++)
{
color = bmpImg.GetPixel(i, j);
int K = (color.R + color.G + color.B) / 3;
result.SetPixel(i, j, K <= P ? Color.Black : Color.White);
}
}
return result;
}

}
}