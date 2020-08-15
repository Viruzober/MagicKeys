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
client.CancelDownload();
this.DialogResult = DialogResult.Cancel;
}

public void ProgressCheck(long? totalFileSize, long totalBytesDownloaded, double? progressPercentage)
{
PB.Value = Convert.ToInt32(progressPercentage);
InputBoxLabel.Text = totalBytesDownloaded.ToString();
}

}
}