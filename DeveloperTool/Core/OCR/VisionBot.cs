using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using static MKLib;
namespace DeveloperTool
{

public partial class DeveloperTool
{

public static async void VisionBot()
{
try{
if (OCRSize[0] == 0)
{
MKLib.Speak(T._("No rectangle for OCR"));
return;
}
int[] MP = MKLib.GetMousePosition();
Bitmap Screen = new Bitmap(OCRSize[0], OCRSize[1]);
Graphics g = Graphics.FromImage(Screen);
g.CopyFromScreen(MP[0], MP[1], 00, 0, Screen.Size);
Bitmap S = ResizeImage(Screen, OCRZoom);
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
catch(Exception)
{
MKLib.Speak("Error");
}
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
SoundPlay("PluginDetect");
continue;
}
HTTPC.Dispose();
MKLib.Speak(J["text"]);
break;
}
}

}
}