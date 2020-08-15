using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.ComponentModel;
using System.Net.Http;
using System.IO;
using System.Threading;
using System.IO.Compression;

namespace Updater
{
public partial class UpdateForm : Form
{

public HttpClientDownloadWithProgress client;

public async void ButtonOK_Click(object sender, EventArgs e)
{
ButtonOK.Enabled = false;
ButtonCancel.Enabled = true;
using (client = new HttpClientDownloadWithProgress("https://viruzober.tk/MagicKeys "+Updater.NV+".zip", "MagicKeys "+Updater.NV+".zip"))
{
client.ProgressChanged += ProgressCheck;
await client.StartDownload();
}
ZipFile.ExtractToDirectory("MagicKeys "+Updater.NV+".zip", "./", true);
this.Close();
}

public void ButtonCancel_Click(object sender, EventArgs e)
{
ButtonOK.Enabled = true;
ButtonCancel.Enabled = false;
client.CancelDownload();
this.DialogResult = DialogResult.Cancel;
}

public void ProgressCheck(long? totalFileSize, long totalBytesDownloaded, double? progressPercentage)
{
PB.Value = Convert.ToInt32(progressPercentage);
if (PB.Value == 100)
{
ButtonCancel.Enabled = false;
}
}

}
}