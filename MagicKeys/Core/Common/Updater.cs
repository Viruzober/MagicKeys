using System;
using System.IO;
using System.Diagnostics;
using System.Linq;
namespace MagicKeys
{
public partial class MagicKeys
{
public static void Update(string Quiet = "false")
{
if (File.Exists(@".\MKUpdater.exe") == false)
{
return;
}
var RunProc = from proc in Process.GetProcesses(".") orderby proc.Id select proc;
if (RunProc.Count(p => p.ProcessName.Contains("MKUpdater")) > 0) return;
ProcessStartInfo startInfo = new ProcessStartInfo();
startInfo.FileName = "MKUpdater.exe";
startInfo.Arguments = GetVersion()+" "+UpdateChannel+" "+Quiet;
Process.Start(startInfo);
}
}
}