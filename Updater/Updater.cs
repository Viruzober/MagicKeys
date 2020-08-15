using MagicKeys;
using System;
using System.Windows.Forms;

namespace Updater
{
public partial class Updater
{
public static string NV = GetHtmlCode("https://viruzober.tk/ActiveVersion.txt").Result;
static void Main (string[] Args)
{	
//Version Ald = new Version(Args[0]);
//Version NewV = new Version(NV);
//if (Ald <= NewV) return;
UpdateForm UF = new UpdateForm();
string Change = GetHtmlCode("https://viruzober.tk/Change.txt").Result;
UF.TB.Text = Change;
Application.Run(UF);
}

}
}