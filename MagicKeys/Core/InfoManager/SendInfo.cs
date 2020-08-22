using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;
namespace MagicKeys
{
public partial class MagicKeys
{

public static async void SendInfo()
{
HttpClient HTTPC = new HttpClient();
var Values = new Dictionary<string, string>();
Values.Add("PCID", PCID());
Values.Add("OSVersion", Environment.OSVersion.ToString()+" "+OS()+" bit");
Values.Add("ScreenResolution", Width.ToString()+"x"+Height.ToString());
Values.Add("ScreenOrientation", SystemInformation.ScreenOrientation.ToString());
Values.Add("ScreenDPI", GetDPI());
Values.Add("ScreenReader", GetScreenReader());
var form = new FormUrlEncodedContent(Values);
HttpResponseMessage response = await HTTPC.PostAsync("https://viruzober.tk/MagicKeys/Info.php", form);
response.EnsureSuccessStatusCode();
string sd = response.Content.ReadAsStringAsync().Result;
HTTPC.Dispose();
}

}
}