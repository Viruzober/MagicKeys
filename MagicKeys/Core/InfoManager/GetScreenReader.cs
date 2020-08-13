using System;
using System.Diagnostics;
using System.Linq;
using SpeechLib;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static string GetScreenReader()
{
var runningProcs = from proc in Process.GetProcesses(".") orderby proc.Id select proc;
if (runningProcs.Count(p => p.ProcessName.Contains("nvda")) > 0)
{
return "NVDA";
}
else if (runningProcs.Count(p => p.ProcessName.Contains("jhookldr")) > 0)
{
return "JAWS";
}
else
{
return "SAPI";
}
}

}
}