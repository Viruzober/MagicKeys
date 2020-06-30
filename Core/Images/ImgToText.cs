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
var GetOCR = Task.Run(async () => await OCR(W, H, X, Y, Zoom));
return GetOCR.Result;
}
catch(Exception)
{
return "Компонент Windows 10 OCR недоступен";
}
}

public async static Task<string> OCR(int W, int H, int X, int Y, int Zoom)
{
Bitmap Screen = new Bitmap(W, H);
Graphics g = Graphics.FromImage(Screen);
g.CopyFromScreen(X, Y, 00, 0, Screen.Size);
Bitmap S = new Bitmap(Screen, new Size(W*Zoom, H*Zoom));
S.MakeTransparent();
//S.Save(@".\Images\"+Guid.NewGuid().ToString()+".png");
var engine = Windows.Media.Ocr.OcrEngine.TryCreateFromLanguage(new Windows.Globalization.Language("en"));
var memoryStream = new MemoryStream();
S.Save(memoryStream, ImageFormat.Bmp);
var WMS = WindowsRuntimeStreamExtensions.AsRandomAccessStream(memoryStream);
var decoder = await Windows.Graphics.Imaging.BitmapDecoder.CreateAsync(WMS);
var softwareBitmap = await decoder.GetSoftwareBitmapAsync();
var ocrResult = await engine.RecognizeAsync(softwareBitmap);
return ocrResult.Text;
        }

}
}