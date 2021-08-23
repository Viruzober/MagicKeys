using System.Drawing;
using System.Drawing.Drawing2D;
public static partial class MKLib
{

public  static Bitmap ResizeImage(Bitmap Image, float Scale)
{
Bitmap Result = new Bitmap((int)(Image.Width * Scale), (int)(Image.Height * Scale));
var GR = Graphics.FromImage(Result);
GR.InterpolationMode = InterpolationMode.HighQualityBilinear;
GR.DrawImage(Image, 0, 0, Result.Width, Result.Height); 
            return Result;
        }

}