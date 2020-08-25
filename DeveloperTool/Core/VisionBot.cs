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
if (DP[0] == 0)
{
MagicKeys.Speak(T._("No rectangle for OCR"));
return;
}
int[] MP = MagicKeys.GetMousePosition();
Bitmap Screen = new Bitmap(DP[0], DP[1]);
Graphics g = Graphics.FromImage(Screen);
g.CopyFromScreen(MP[0]-(DP[0]/2), MP[1]-(DP[1]/2), 00, 0, Screen.Size);
Bitmap S = new Bitmap(Screen, new Size(DP[0]*OCRZoom, DP[1]*OCRZoom));
ImageConverter converter = new ImageConverter();
byte[] BT = (byte[])converter.ConvertTo(S, typeof(byte[]));
HttpClient HTTPC = new HttpClient();
var form = new MultipartFormDataContent();
form.Add(new ByteArrayContent(BT, 0, BT.Length), "file", "OCR.bmp");
form.Add(new StringContent("text"), "target");
HttpResponseMessage response = await HTTPC.PostAsync("https://visionbot.ru/apiv2/in.php", form);
response.EnsureSuccessStatusCode();
HTTPC.Dispose();
string sd = response.Content.ReadAsStringAsync().Result;
Dictionary<string, string> J = JsonSerializer.Deserialize<Dictionary<string, string>>(sd);
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
while(true)
{
HttpResponseMessage response = await HTTPC.PostAsync("https://visionbot.ru/apiv2/res.php", form);
response.EnsureSuccessStatusCode();
string sd = response.Content.ReadAsStringAsync().Result;
Dictionary<string, string> J = JsonSerializer.Deserialize<Dictionary<string, string>>(sd);
if (J["status"] == "notready")
{
Thread.Sleep(1000);
MagicKeys.SoundPlay("PluginDetect", 0);
continue;
}
HTTPC.Dispose();
OCRR = J["text"];
MagicKeys.Speak(J["text"]);
break;
}
}

}
}