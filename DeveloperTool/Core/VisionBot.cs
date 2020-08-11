using System;
using System.Buffers.Text;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Threading;
using System.Diagnostics;
using System.Drawing;
using System.Text.Json;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MagicKeys
{
    public partial class DeveloperTool
{

public static async void VisionBot()
{
int[] MP = MagicKeys.GetMousePosition();
Bitmap Screen = new Bitmap(DP[0], DP[1]);
Graphics g = Graphics.FromImage(Screen);
g.CopyFromScreen(MP[0], MP[1], 00, 0, Screen.Size);
ImageConverter converter = new ImageConverter();
byte[] BT = (byte[])converter.ConvertTo(Screen, typeof(byte[]));
HttpClient HTTPC = new HttpClient();
MultipartFormDataContent form = new MultipartFormDataContent();
form.Add(new StringContent("target"), "all");
form.Add(new ByteArrayContent(BT, 0, BT.Length), "file", "OCR.bmp");
HttpResponseMessage response = await HTTPC.PostAsync("https://visionbot.ru/apiv2/in.php", form);
response.EnsureSuccessStatusCode();
HTTPC.Dispose();
string sd = response.Content.ReadAsStringAsync().Result;
Dictionary<string, string> J = JsonSerializer.Deserialize<Dictionary<string, string>>(sd);
Thread.Sleep(3000);
VisionBotResult(J["id"]);
}

public static async void VisionBotResult(string ID)
{
HttpClient HTTPC = new HttpClient();
var Values = new Dictionary<string, string>
{
{
"id", ID
}
};
var form = new FormUrlEncodedContent(Values);
HttpResponseMessage response = await HTTPC.PostAsync("https://visionbot.ru/apiv2/res.php", form);
response.EnsureSuccessStatusCode();
HTTPC.Dispose();
string sd = response.Content.ReadAsStringAsync().Result;
Dictionary<string, string> J = JsonSerializer.Deserialize<Dictionary<string, string>>(sd);
MagicKeys.Speak(J["text"]);
}

}
}