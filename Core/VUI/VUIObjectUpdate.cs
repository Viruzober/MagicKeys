using System;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static void VUIUpdate(bool StartObject)
{
ActiveObjects.Clear();
foreach(var O in VUIObjects)
{
if (O.Value == true)
{
ActiveObjects.Add(O.Key);
}
}
Count = ActiveObjects.Count-1;
if (StartObject == true) Section = 0;
}

}
}