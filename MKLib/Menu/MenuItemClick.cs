using System.Threading;

public  static  partial class MKLib
{

public static bool MenuItemClick(string MIText)
{
Thread.Sleep(100);
int Count = GetMICount();
for(int I = 0; I <= Count-1; I++)
{
if (GetMIText(I).Contains(MIText, System.StringComparison.OrdinalIgnoreCase) == true)
{
int[] RC = GetMIRect(I);
MouseClick("Left", RC[0], RC[1], 1, 0, 0, 0);
return true;
}
}
return false;
}

public static bool MenuItemClick(int IDItem)
{
Thread.Sleep(100);
int[] RC = GetMIRect(IDItem);
if(RC[0] != 0)
{
MouseClick("Left", RC[0], RC[1], 1, 0, 0, 0);
return true;
}
return false;
}

}