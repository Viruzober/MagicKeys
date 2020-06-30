using System;

namespace MagicKeys
{
public partial class MagicKeys
{

public static void VUIObjectSwitcher(bool Update, bool Switch, int Start, int End)
{
for (int I = Start; I <= End; I++)
{
VUIObjects[I] = Switch;
}
VUIUpdate(Update);
}

}
}