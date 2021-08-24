using System;
using System.Drawing;
using System.Text.Json;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Reflection.Metadata;

public static partial class MKLib
{

public static string ImgToText(int W, int H, int X, int Y, int Zoom, string Lang = "en")
{
if (Environment.OSVersion.Version.Major < 10)
{
return "Windows OCR is not available";
}
try
{
using var memoryStream = new MemoryStream();
Bitmap Screen = new Bitmap(W, H);
Graphics g = Graphics.FromImage(Screen);
g.CopyFromScreen(X, Y, 00, 0, Screen.Size);
Bitmap S = ResizeImage(Screen, Zoom);
S.Save(memoryStream, ImageFormat.Bmp);
byte[] b = memoryStream.GetBuffer();
string Result = Task.Run(() => OCR(b, Lang)).Result;
OCRResult JsonResult = JsonSerializer.Deserialize<OCRResult>(Result);
return JsonResult.Text;
}
catch(Exception)
{
return "Error OCR angine";
}
}

public static OCRResult GetOCRResult(int W, int H, int X, int Y, float Zoom, string Lang = "en")
{
if (Environment.OSVersion.Version.Major < 10)
{
Speak("Windows OCR is not available");
return null;
}
try
{
using var memoryStream = new MemoryStream();
Bitmap Screen = new Bitmap(W, H);
Graphics g = Graphics.FromImage(Screen);
g.CopyFromScreen(X, Y, 00, 0, Screen.Size);
Bitmap S = ResizeImage(Screen, Zoom);
S.Save(memoryStream, ImageFormat.Bmp);
byte[] b = memoryStream.GetBuffer();
string Result = Task.Run(() => OCR(b, Lang)).Result;
OCRResult JsonResult = JsonSerializer.Deserialize<OCRResult>(Result);
return JsonResult;
}
catch(Exception)
{
Speak("Error OCR angine");
return null;
}
}

public static string OCR(byte[] b, string Lang)
{
string Result = Recognize(b, (uint)b.Length, Lang);
return Result;
}

}