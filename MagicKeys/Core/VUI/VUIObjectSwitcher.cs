namespace MagicKeys
{

public partial class MagicKeys
{

public static void VUIObjectSwitcher(bool Update, string Switch, int Start, int End = 0)
{
int ObjectEnd = End;
if (End == 0)
{
ObjectEnd = Start;
}

for (int I = Start; I <= ObjectEnd; I++)
{
VUIObjects[I]["Active"] = Switch;
}
VUIObjectsUpdate(Update);
}

public static void VUIObjectSwitcher(bool Update, string Switch, string Start, string End = "")
{
string ObjectEnd = End;
if (End == "")
{
ObjectEnd = Start;
}

int StartIndex = VUIObjects.IndexOf(Start);
int EndIndex = VUIObjects.IndexOf(ObjectEnd);
for (int I = StartIndex; I <= EndIndex; I++)
{
VUIObjects[I]["Active"] = Switch;
}
VUIObjectsUpdate(Update);
}

}
}