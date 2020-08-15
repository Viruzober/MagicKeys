using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MagicKeys
{
public partial class MagicKeys
{

public static async Task<string> GetHtmlCode(string Url)
{
HttpClient HTTPC = new HttpClient();
HttpResponseMessage Hresponse = await HTTPC.GetAsync(Url);
Task<string> sd = Hresponse.Content.ReadAsStringAsync();
return sd.Result;
}

}
}