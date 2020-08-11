using System;
using System.Buffers.Text;
using System.IO;
using System.Net;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Threading;
using System.Diagnostics;
using System.Drawing;
using System.Text.Json;
using System.Collections.Generic;

namespace MagicKeys
{
    public partial class DeveloperTool
{

public static void VisionBot()
{
WebRequest request = WebRequest.Create("https://visionbot.ru/apiv2/in.php");
request.Method = "POST";
int[] MP = MagicKeys.GetMousePosition();
Bitmap Screen = new Bitmap(DP[0], DP[1]);
Graphics g = Graphics.FromImage(Screen);
g.CopyFromScreen(MP[0], MP[1], 00, 0, Screen.Size);
ImageConverter converter = new ImageConverter();
byte[] BT = (byte[])converter.ConvertTo(Screen, typeof(byte[]));
string Img = Convert.ToBase64String(BT);
string data = "body="+Img+"&target=all";
byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(data);
request.ContentType = "application/x-www-form-urlencoded";
request.ContentLength = byteArray.Length;
Stream dataStream = request.GetRequestStream();
dataStream.Write(byteArray, 0, byteArray.Length);
WebResponse response = request.GetResponse();
Stream stream = response.GetResponseStream();
StreamReader reader = new StreamReader(stream);
string r = reader.ReadToEnd();
response.Close();
Dictionary<string, string> J = JsonSerializer.Deserialize<Dictionary<string, string>>(r);
Thread.Sleep(10000);
VisionBotResult(J["id"]);
}

public static void VisionBotResult(string ID)
{
WebRequest request = WebRequest.Create("https://visionbot.ru/apiv2/res.php");
request.Method = "POST";
string data = "id="+ID;
byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(data);
request.ContentType = "application/x-www-form-urlencoded";
request.ContentLength = byteArray.Length;
Stream dataStream = request.GetRequestStream();
dataStream.Write(byteArray, 0, byteArray.Length);
WebResponse response = request.GetResponse();
Stream stream = response.GetResponseStream();
StreamReader reader = new StreamReader(stream);
string r = reader.ReadToEnd();
response.Close();
Dictionary<string, string> J = JsonSerializer.Deserialize<Dictionary<string, string>>(r);
MagicKeys.Speak(J["text"]+" "+J["status"]);
}

}
}