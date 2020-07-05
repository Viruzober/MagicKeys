using System;
using System.IO;
using System.Net;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static string UserInfo(string SerialKey)
{
try
{
WebRequest request = WebRequest.Create("http://viruzober.tk:80/UserInfo.php");
request.Method = "POST";
string data = "SerialKey="+SerialKey;
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
return r;
}
catch(Exception)
{
                return "Reg user";
}
}

}
}