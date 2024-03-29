using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using static MKLib;

namespace MagicKeys
{

public partial class MagicKeys
{

public static bool CheckRunProc(string Proc)
{
var RunProc = from proc in Process.GetProcesses(".") orderby proc.Id select proc;
if (RunProc.Count(p => p.ProcessName.Contains(Proc)) > 1)
{
SoundPlay("Error", false);
MessageBox.Show(T._("MagicKeys is already running."), T._("Error"));
return true;
}
else
{
return false;
}
}

}
}