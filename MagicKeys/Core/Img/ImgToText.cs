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

public static string ImgToText(int W, int H, int X, int Y, int Zoom)
{
using var memoryStream = new MemoryStream();
Bitmap Screen = new Bitmap(W, H);
Graphics g = Graphics.FromImage(Screen);
g.CopyFromScreen(X, Y, 00, 0, Screen.Size);
Bitmap S = new Bitmap(Screen, new Size(W*Zoom, H*Zoom));
S.Save(memoryStream, ImageFormat.Bmp);
byte[] b = memoryStream.ToArray();
IntPtr Handle = Marshal.AllocHGlobal(b.Length);
Marshal.Copy(b, 0, Handle, b.Length);
string Resulte = Task.Run(() => OCR(Handle, (uint)b.Length, "en")).Result;
OCRResulte JsonResulte = JsonSerializer.Deserialize<OCRResulte>(Resulte);
return JsonResulte.text;
}

public static string OCR(IntPtr Handle, uint Size, string Lang)
{
return Marshal.PtrToStringUni(Recognize(Handle, Size, Marshal.StringToHGlobalUni(Lang)));
}

}
}