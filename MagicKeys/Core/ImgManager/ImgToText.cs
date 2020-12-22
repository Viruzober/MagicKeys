using System;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Threading;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using Windows;
using Windows.Graphics.Imaging;
using System.Threading.Tasks;
using Windows.Media.Ocr;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static string ImgToText(int W, int H, int X, int Y, int Zoom)
{
            try
{
var ocrText = Task.Run(async () => await OCR(W, H, X, Y, Zoom));
return ocrText;
}
catch(Exception)
{
return T._("Windows 10 OCR is unavailable");
}
}

public async static Task<string> OCR(int W, int H, int X, int Y, int Zoom)
{
using var memoryStream = new MemoryStream();
Bitmap Screen = new Bitmap(W, H);
Graphics g = Graphics.FromImage(Screen);
g.CopyFromScreen(X, Y, 00, 0, Screen.Size);
Bitmap S = new Bitmap(Screen, new Size(W*Zoom, H*Zoom));
var engine = Windows.Media.Ocr.OcrEngine.TryCreateFromLanguage(new Windows.Globalization.Language("en"));
S.Save(memoryStream, ImageFormat.Bmp);
using var RAS = memoryStream.AsRandomAccessStream();
var decoder = await Windows.Graphics.Imaging.BitmapDecoder.CreateAsync(RAS);
var softwareBitmap = await decoder.GetSoftwareBitmapAsync();
var ocrResult = await engine.RecognizeAsync(softwareBitmap);
return ocrResult.Text;
}

}
}