using System;
using System.Drawing.Imaging;
using System.Threading;
using System.Diagnostics;
using System.Drawing;
using System.IO;

namespace MagicKeys
{
public partial class MagicKeys
{

public static Bitmap BrightnessImg(Bitmap Img, int Value)
{
Bitmap Result = new Bitmap(Img, Img.Width, Img.Height);
            for (int j = 0; j < Img.Height; j++)
            {
                for (int i = 0; i < Img.Width; i++)
                {
                    Color C = Img.GetPixel(i, j);
Byte R = ToByte(C.R+Value);
Byte G = ToByte(C.G+Value);
Byte B = ToByte(C.B+Value);
Color NewColor = Color.FromArgb(R, G, B);
Result.SetPixel(i, j, NewColor);
                }
            }
return Result;
}

public static byte ToByte(int Val)
{
if (Val > 255) Val = 255;
else if (Val < 0) Val = 0;
return (byte)Val;
}

}
}