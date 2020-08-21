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
    public partial class DeveloperTool
{

public static async void OCR()
{
Bitmap Screen = new Bitmap(P[3]-P[1], P[4]-P[2]);
Graphics g = Graphics.FromImage(Screen);
g.CopyFromScreen(P[1], P[2], 00, 0, Screen.Size);
var engine = Windows.Media.Ocr.OcrEngine.TryCreateFromLanguage(new Windows.Globalization.Language("en"));
var memoryStream = new MemoryStream();
Screen.Save(memoryStream, ImageFormat.Bmp);
var WMS = WindowsRuntimeStreamExtensions.AsRandomAccessStream(memoryStream);
var decoder = await Windows.Graphics.Imaging.BitmapDecoder.CreateAsync(WMS);
var softwareBitmap = await decoder.GetSoftwareBitmapAsync();
var OCRR = await engine.RecognizeAsync(softwareBitmap);
Double Pos = OCRR.Lines[0].Words[0].BoundingRect.X;
        }

}
}