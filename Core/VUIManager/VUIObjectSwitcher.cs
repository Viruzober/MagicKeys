using System;

namespace MagicKeys
{
public partial class MagicKeys
{

public static void VUIObjectSwitcher(bool Update, string Switch, int Start, int End)
{
for (int I = Start; I <= End; I++)
{
VUIObjects[I]["Active"] = Switch;
}
VUIObjectsUpdate(Update);
}

}
}