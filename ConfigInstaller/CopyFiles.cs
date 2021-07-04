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
proc.StartInfo.RedirectStandardInput = true;
proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
string command = "xcopy /e /i /q /y /r /k \""+In+"\" \""+To+"\"\r\nexit";
proc.Start();
proc.StandardInput.WriteLine(command);
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