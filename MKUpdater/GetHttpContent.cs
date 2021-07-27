using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.IO;
namespace MKUpdater
{
public partial class MKUpdater
{

public static string GetHttpContent(string URL)
{
using (HttpClient client = new HttpClient())
{
using (HttpResponseMessage response = client.GetAsync(URL).Result)
{
using (HttpContent content = response.Content)
{
if (response.EnsureSuccessStatusCode().StatusCode != HttpStatusCode.OK) new HttpRequestException();
string result = content.ReadAsStringAsync().Result.ToString();
return result.Trim();
}
}
}
}

}
}