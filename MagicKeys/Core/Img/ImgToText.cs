using System;
using System.Drawing;
using System.Text.Json;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Reflection.Metadata;

namespace MagicKeys
{

public partial class MagicKeys
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
IntPtr Handle = Marshal.AllocHGlobal(b.Length);
Marshal.Copy(b, 0, Handle, b.Length);
string Result = Task.Run(() => OCR(Handle, (uint)b.Length, Lang)).Result;
OCRResult JsonResult = JsonSerializer.Deserialize<OCRResult>(Result);
return JsonResult.text;
}
catch(Exception)
{
return "Error OCR angine";
}
}

public static string OCR(IntPtr Handle, uint Size, string Lang)
{
return Marshal.PtrToStringUni(Recognize(Handle, Size, Marshal.StringToHGlobalUni(Lang)));
}

}
}