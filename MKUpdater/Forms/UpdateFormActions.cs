using Pluralize.NET.Core;
using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace MKUpdater
{

public partial class UpdateForm : Form
{

public HttpClientDownloadWithProgress client;
public string UpdateFileName = string.Empty;
public async void ButtonOK_Click(object sender, EventArgs e)
{
string Proc = MKUpdater.CheckProc();
if (Proc != string.Empty)
{
MessageBox.Show(T._("Please close these programs before updating.")+"\r\n"+Proc, T._("Warning"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
return;
}
ButtonOK.Enabled = false;
ButtonCancel.Enabled = true;
UpdateFileName = "MagicKeys_"+new Pluralizer().Singularize(MKUpdater.UpdateChannel)+"_"+MKUpdater.NewVersion+"_x"+MKUpdater.OS()+".zip";
Directory.CreateDirectory("./Temp/");
try
{
using (client = new HttpClientDownloadWithProgress("https://viruzober.ru/MagicKeys/"+MKUpdater.UpdateChannel+"/"+UpdateFileName, @".\Temp\"+UpdateFileName))
{
client.ProgressChanged += ProgressCheck;
await client.StartDownload();
}
}
catch(Exception)
{
MessageBox.Show(T._("Error Downloading update. Please try again later."), T._("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
if (File.Exists(@".\Temp\"+UpdateFileName) == false)
{
MessageBox.Show(T._("Update file is corrupted."), T._("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
Directory.Delete(@".\Temp\", true);
this.Close();
return;
}
if(MKUpdater.GetSHA(@".\Temp\"+UpdateFileName).ToLower() != MKUpdater.GetHttpContent("https://viruzober.ru/MagicKeys/"+MKUpdater.UpdateChannel+"/"+UpdateFileName+".sum"))
{
MessageBox.Show(T._("Update file is corrupted."), T._("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
Directory.Delete(@".\Temp\", true);
this.Close();
return;
}
ZipFile.ExtractToDirectory(@".\Temp\"+UpdateFileName, @".\Temp\", true);
File.Delete(@".\Temp\"+UpdateFileName);
this.Close();
Process.Start(@".\Temp\MKUpdater.exe", "Move");
}
}

}
}