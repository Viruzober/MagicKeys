using System.IO;
using System.Linq;
using static MKLib;

namespace DeveloperTool
{
public partial class DeveloperTool
{

public static void ManageVUI
()
{
if (ProjectName == string.Empty)
{
Speak(T._("Project is not opened"));
return;
}
KeyUnReg();
VUIManager VUIM = new VUIManager();
VUIM.ShowDialog();
KeyReg();
}

}
}