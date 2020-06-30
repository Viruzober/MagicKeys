using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
namespace MagicKeys
{
    public partial class MagicKeys
{
public static bool CheckRunProc(string Proc)
{
var RunProc = from proc in Process.GetProcesses(".") orderby proc.Id select proc;
if (RunProc.Count(p => p.ProcessName.Contains(Proc)) > 1)
{
SoundPlay("Error.ogg", 0);
MessageBox.Show("Программа уже запущенна", "Внимание");
return true;
}
else return false;
}
}
}