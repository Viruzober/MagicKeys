using System;
using System.Diagnostics;

namespace ConfigInstaller
{
public partial class ConfigInstaller
{

public static string RegImport(string PluginName)
{
Process proc = new Process();
try
{
proc.StartInfo.FileName = "reg.exe";
proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
proc.StartInfo.CreateNoWindow = true;
proc.StartInfo.UseShellExecute = false;
string command = "import ./Settings/"+PluginName+"/Install.reg";
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