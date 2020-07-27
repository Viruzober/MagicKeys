using System.IO;
using System.Net;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static string LicenseRegister(string Name, string Mail)
{
WebRequest request = WebRequest.Create("http://viruzober.tk:80/Register.php");
request.Method = "POST";
string data = "Name="+Name+"&Mail="+Mail+"&Version="+Version+"&SerialKey="+PCID();
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

}
}