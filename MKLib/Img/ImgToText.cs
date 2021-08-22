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
return "Windows 10 OCR is not evalable";
}
try
{
using var memoryStream = new MemoryStream();
Bitmap Screen = new Bitmap(W, H);
Graphics g = Graphics.FromImage(Screen);
g.CopyFromScreen(X, Y, 00, 0, Screen.Size);
Bitmap S = new Bitmap(Screen, new Size(W*Zoom, H*Zoom));
S.Save(memoryStream, ImageFormat.Png);
byte[] b = memoryStream.GetBuffer();
string Result = Task.Run(() => OCR(b, Lang)).Result;
OCRResult JsonResult = JsonSerializer.Deserialize<OCRResult>(Result);
return JsonResult.text;
}
catch(Exception)
{
return "Error OCR angine";
}
}

public static OCRResult GetOCRResult(int W, int H, int X, int Y, int Zoom, string Lang = "en")
{
if (Environment.OSVersion.Version.Major < 10)
{
Speak("Windows 10 OCR is not evalable");
return null;
}
try
{
using var memoryStream = new MemoryStream();
Bitmap Screen = new Bitmap(W, H);
Graphics g = Graphics.FromImage(Screen);
g.CopyFromScreen(X, Y, 00, 0, Screen.Size);
Bitmap S = new Bitmap(Screen, new Size(W*Zoom, H*Zoom));
S.Save(memoryStream, ImageFormat.Png);
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
IntPtr Handle = Marshal.AllocHGlobal(b.Length);
Marshal.Copy(b, 0, Handle, b.Length);
var Result = Marshal.PtrToStringUni(Recognize(Handle, (uint)b.Length, Lang));
Marshal.FreeHGlobal(Handle);
return Result;
}

}