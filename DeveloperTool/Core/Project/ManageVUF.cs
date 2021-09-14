using System.IO;
using System.Linq;
using static MKLib;

namespace DeveloperTool
{
public partial class DeveloperTool
{

public static void ManageVUF()
{
if (ProjectName == string.Empty)
{
Speak(T._("Project is not opened"));
return;
}
KeyUnReg();
VUFManagerForm VUFM = new VUFManagerForm();
VUFM.ShowDialog();
KeyReg();
}

}
}