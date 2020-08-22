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
using System.Text;

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
using (client = new HttpClientDownloadWithProgress("https://viruzober.tk/MagicKeys/MagicKeys_"+MKUpdater.NV+".zip", "MagicKeys_"+MKUpdater.NV+".zip"))
{
client.ProgressChanged += ProgressCheck;
await client.StartDownload();
}
}

public void ButtonCancel_Click(object sender, EventArgs e)
{
ButtonCancel.Enabled = false;
client.CancelDownload();
this.Close();
}

public void ProgressCheck(long? totalFileSize, long totalBytesDownloaded, double? progressPercentage)
{
PB.Value = Convert.ToInt32(progressPercentage);
if (totalFileSize == totalBytesDownloaded)
{
client.Dispose();
ButtonCancel.Enabled = false;
if (File.Exists("MagicKeys_"+MKUpdater.NV+".zip") == true)
{
string DSHA = MKUpdater.GetHtmlCode("https://viruzober.tk/MagicKeys/SHA256.txt");
string GSHA = MKUpdater.GetSHA("MagicKeys_"+MKUpdater.NV+".zip");
if (DSHA != GSHA)
{
MessageBox.Show("Update file is not correct", "Error");
File.Delete("MagicKeys_"+MKUpdater.NV+".zip");
this.Close();
return;
}
ZipFile.ExtractToDirectory("MagicKeys_"+MKUpdater.NV+".zip", "./", true);
File.Delete("MagicKeys_"+MKUpdater.NV+".zip");
this.Close();
}
}
}

}
}