using System;
using System.Windows.Forms;

namespace MKUpdater
{
public partial class MKUpdater
{
public static string NV = GetHtmlCode("https://viruzober.tk/ActiveVersion.txt");
static void Main (string[] Args)
{
if(Args[0] == null) return;
if (Args[0] == NV) return;
UpdateForm UF = new UpdateForm();
string Change = GetHtmlCode("https://viruzober.tk/Change.txt");
UF.TB.Text = Change;
Application.Run(UF);
}

}
}