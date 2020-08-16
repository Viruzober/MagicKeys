using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.ComponentModel;
using System.Net.Http;
using System.IO;
using System.Threading;
using System.IO.Compression;
using System.Diagnostics;
using System.Linq;

namespace MKUpdater
{
public partial class UpdateForm : Form
{

public HttpClientDownloadWithProgress client;

public async void ButtonOK_Click(object sender, EventArgs e)
{
var RunProc = from proc in Process.GetProcesses(".") orderby proc.Id select proc;
if (RunProc.Count(p => p.ProcessName.Contains("MagicKeys")) > 0)
{
MessageBox.Show("Для обновления необходимо закрыть MagicKeys", "Внимание");
return;
}
ButtonOK.Enabled = false;
ButtonCancel.Enabled = true;
using (client = new HttpClientDownloadWithProgress("https://viruzober.tk/MagicKeys "+MKUpdater.NV+".zip", "MagicKeys "+MKUpdater.NV+".zip"))
{
client.ProgressChanged += ProgressCheck;
await client.StartDownload();
}
}

public void ButtonCancel_Click(object sender, EventArgs e)
{
ButtonOK.Enabled = true;
ButtonCancel.Enabled = false;
client.CancelDownload();
}

public void ProgressCheck(long? totalFileSize, long totalBytesDownloaded, double? progressPercentage)
{
PB.Value = Convert.ToInt32(progressPercentage);
if (totalFileSize == totalBytesDownloaded)
{
client.Dispose();
ButtonCancel.Enabled = false;
if (File.Exists("MagicKeys "+MKUpdater.NV+".zip") == true)
{
ZipFile.ExtractToDirectory("MagicKeys "+MKUpdater.NV+".zip", "./", true);
this.Close();
}
}
}

}
}