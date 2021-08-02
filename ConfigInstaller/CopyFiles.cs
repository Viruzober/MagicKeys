using System;
using System.Diagnostics;
namespace ConfigInstaller
{
public partial class ConfigInstaller
{
public static string CopyFiles(string In, string To)
{
Process proc = new Process();
try
{
proc.StartInfo.FileName = "cmd.exe";
proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
string command = "/C xcopy /e /i /q /y /r /k \""+In+"\" \""+To+"\"";
proc.StartInfo.Arguments = command;
proc.Start();
proc.WaitForExit();
return "Success";
}
catch(Exception)
{
return "Error";
}
}
}
}