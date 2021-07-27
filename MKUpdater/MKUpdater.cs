using System;
using System.Threading;
using System.Net.Http;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Pluralize.NET.Core;
namespace MKUpdater
{
public partial class MKUpdater
{
public static string UpdateChannel;
public static string NewVersion;
static void Main (string[] Args)
{
Directory.SetCurrentDirectory(Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName));
if(Args[0] == null)
{
return;
}
if (Args[0] == "Move")
{
Thread.Sleep(1000);
CopyDirectory(@".\", @"..\");
Process.Start(@"..\MKUpdater.exe", "Clean");
return;
}
if (Args[0] == "Clean")
{
Thread.Sleep(1000);
Directory.Delete(@".\Temp\", true);
Process.Start(@".\MagicKeys.exe");
return;
}
try
{
UpdateChannel = new Pluralizer().Pluralize(Args[1]);
NewVersion = GetHttpContent("https://viruzober.ru/MagicKeys/"+UpdateChannel+"/Version.txt");
if (Args[0] == NewVersion)
{
if (Args[2] == "true")
{
MessageBox.Show(T._("No updates available."), T._("Information"), MessageBoxButtons.OK, MessageBoxIcon.Information);
}
return;
}
UpdateForm UF = new UpdateForm();
string ChangeLog = GetHttpContent("https://viruzober.ru/MagicKeys/Changelog.txt");
UF.TB.Text = ChangeLog;
Application.Run(UF);
}
catch(HttpRequestException)
{
MessageBox.Show(T._("the update server returned an error. Please try again later."), T._("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
return;
}
catch(Exception)
{
MessageBox.Show(T._("Something has gone wrong. Please check your internet connection."), T._("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
return;
}
}

}
}