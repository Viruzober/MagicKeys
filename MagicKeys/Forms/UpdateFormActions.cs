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
public WebClient Web;
public string Link = string.Empty;
public void ButtonOK_Click(object sender, EventArgs e)
{
startDownload();
}

public void ButtonCancel_Click(object sender, EventArgs e)
{
Web.CancelAsync();
this.DialogResult = DialogResult.Cancel;
}

public void InputBox_Shown(Object sender, EventArgs e)
{
this.Activate();
}

public void startDownload()
{
Web = new WebClient();
Web.DownloadProgressChanged += Web_DownloadProgressChanged;
Web.DownloadFileCompleted += Web_DownloadFileCompleted;
Web.DownloadFileAsync(new System.Uri(Link), "upd.rar");
}
 
public void Web_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
{
if (e.Cancelled == true)
{
MessageBox.Show("Загрузка файла отменена!");
return;
}
else
{
MessageBox.Show("Загрузка файла завершена!");
}
}
 
public void Web_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
{
PB.Value = e.ProgressPercentage;
}

}
}