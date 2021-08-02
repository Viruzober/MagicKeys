using System;
using System.Windows.Forms;
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
using System.Collections.Generic;
using DeveloperTool;
using Windows.Devices.PointOfService;
namespace MagicKeys
{
public partial class DeveloperTool
{
public static List<String> LW = new List<string>();
public static List<int> LX = new List<int>();
public static List<int> LY = new List<int>();
public static async void OCRWordPosition()
{
KeyUnReg();
OptionKeyUnReg();
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
OCRResultForm ORF = new		OCRResultForm();
foreach(var Line in OCRR.Lines)
{
for(int I = 0; I <= Line.Words.Count-1; I++)
{
LW.Add(Line.Words[I].Text);
LX.Add(Convert.ToInt32(Line.Words[I].BoundingRect.X));
LY.Add(Convert.ToInt32(Line.Words[I].BoundingRect.Y));
}
}
foreach(var W in LW){
ORF.WList.Items.Add(W);
}
ORF.ShowDialog();
if(ORF.DialogResult == DialogResult.OK)
{
int SI = ORF.WList.SelectedIndex;
MagicKeys.MouseMove(P[1]+LX[SI], P[2]+LY[SI], 0);
}
LW.Clear();
LX.Clear();
LY.Clear();
OptionKeyReg();
KeyReg();
}
}
}