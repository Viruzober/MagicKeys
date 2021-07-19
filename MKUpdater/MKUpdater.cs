using System;
using System.Windows.Forms;

namespace MKUpdater
{
public partial class MKUpdater
{
public static string NV;
public static string UpdCH;
static void Main (string[] Args)
{
if(Args[0] == null) return;
try
{
UpdCH = Args[1];
NV = GetHtmlCode("https://viruzober.ru/MagicKeys/"+UpdCH+"/ActiveVersion.txt");
if (Args[0] == NV) return;
UpdateForm UF = new UpdateForm();
string Change = GetHtmlCode("https://viruzober.github.io/MagicKeys/ChangeLog.txt");
UF.TB.Text = Change;
Application.Run(UF);
}
catch(Exception)
{
MessageBox.Show(T._("Something has gone wrong. Please check your internet connection."), T._("Error"));
return;
}
}

}
}