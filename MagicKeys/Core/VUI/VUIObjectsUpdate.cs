using System;
using Microsoft.Collections.Extensions;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static void VUIObjectsUpdate(bool StartObject)
{
ActiveObjects.Clear();
foreach(var O in VUIObjects)
{
if (O.Value["Active"] == "true")
{
ActiveObjects.Add(O.Key);
}
}
Count = ActiveObjects.Count-1;
if (StartObject == true) Section = 0;
}

}
}