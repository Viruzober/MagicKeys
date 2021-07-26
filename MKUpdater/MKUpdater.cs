using System;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using Pluralize.NET.Core;
namespace MKUpdater
{
public partial class MKUpdater
{
public static string UpdateChannel;
public static string NewVersion;
static void Main (string[] Args)
{
if(Args[0] == null)
{
return;
}
if (Args[0] == "Move")
{
MessageBox.Show(Args[0], "");
Thread.Sleep(1000);
CopyDirectory(@".\", @"..\");
return;
}
try
{
UpdateChannel = new Pluralizer().Pluralize(Args[1]);
NewVersion = GetHtmlCode("https://viruzober.ru/MagicKeys/"+UpdateChannel+"/Version.txt").Trim();
if (Args[0] != NewVersion) return;
UpdateForm UF = new UpdateForm();
string ChangeLog = GetHtmlCode("https://viruzober.ru/MagicKeys/Changelog.txt");
UF.TB.Text = ChangeLog;
Application.Run(UF);
}
catch(Exception)
{
MessageBox.Show(T._("Something has gone wrong. Please check your internet connection."), T._("Error"));
return;
}
}

}
}