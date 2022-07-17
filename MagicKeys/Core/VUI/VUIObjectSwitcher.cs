namespace MagicKeys
{

public partial class MagicKeys
{

public static void VUIObjectSwitcher(bool Update, bool Switch, int Start, int End = 0)
{
int ObjectEnd = End;
if (End == 0)
{
ObjectEnd = Start;
}

for (int I = Start; I <= ObjectEnd; I++)
{
AllVUIObjects[I].Visible = Switch;
}
VUIObjectsUpdate(Update);
}

}
}