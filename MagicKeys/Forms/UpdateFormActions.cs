using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.ComponentModel;
using System.Net.Http;
using System.IO;
using System.Threading;

namespace MagicKeys
{
public partial class UpdateForm : Form
{

public string Link = string.Empty;
public HttpClientDownloadWithProgress client;

public async void ButtonOK_Click(object sender, EventArgs e)
{
using (client = new HttpClientDownloadWithProgress(Link, "123.zip"))
{
client.ProgressChanged += ProgressCheck;
await client.StartDownload();
}
}

public void ButtonCancel_Click(object sender, EventArgs e)
{
client.Dispose();
this.DialogResult = DialogResult.Cancel;
}

public void ProgressCheck(long? totalFileSize, long totalBytesDownloaded, double? progressPercentage)
{
PB.Value = Convert.ToInt32(progressPercentage);
this.Text = totalBytesDownloaded.ToString();
}

public async void StartDownload()
{
byte[] data;
HttpClient HTTPC = new HttpClient();
HttpResponseMessage Hresponse = await HTTPC.GetAsync("https://viruzober.tk/123.zip");
string sd = Hresponse.Content.ReadAsStringAsync().Result;
MessageBox.Show(sd.ToString(), "");
var client = new HttpClient();
HttpResponseMessage response = await client.GetAsync(Link);
HttpContent content = response.Content;
data = await content.ReadAsByteArrayAsync();
FileStream file = File.Create("upd.zip");
file.Write(data, 0, data.Length);
}

}
}