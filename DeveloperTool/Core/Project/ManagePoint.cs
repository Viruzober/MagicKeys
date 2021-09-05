using System.IO;
using System.Linq;
using static MKLib;

namespace DeveloperTool
{
public partial class DeveloperTool
{

public static void ManagePoint()
{
if (ProjectName == string.Empty)
{
Speak(T._("Project is not opened"));
return;
}
KeyUnReg();
PointManager PM = new PointManager();
PM.ShowDialog();
KeyReg();
}

}
}