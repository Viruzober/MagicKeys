using System;
using System.Threading;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class MagicKeys
{

public static void MenuItemClick(string Button, int X, int Y, string MIText)
{
MouseClick(Button, X, Y, 1, 0, 0, 10);
Thread.Sleep(200);
int Count = GetMICount();
for(int I = 0; I <= Count-1; I++)
{
if (GetMIText(I).Contains(MIText) == true)
{
int[] RC = GetMIRect(I);
MouseClick("Left", RC[0], RC[1], 1, 0, 0, 10);
return;
}
}
}

}
}