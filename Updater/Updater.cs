using System;
using System.Windows.Forms;

namespace MKUpdater
{
public partial class MKUpdater
{
public static string NV;
static void Main (string[] Args)
{
try
{
NV = GetHtmlCode("https://viruzober.tk/ActiveVersion.txt");
if(Args[0] == null) return;
if (Args[0] == NV) return;
UpdateForm UF = new UpdateForm();
string Change = GetHtmlCode("https://viruzober.tk/Change.txt");
UF.TB.Text = Change;
Application.Run(UF);
}
catch(Exception)
{
MessageBox.Show("Что-то пошло не так. Проверьте интернет соеденение", "Внимание");
return;
}
}

}
}