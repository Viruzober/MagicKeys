using System.Threading;
using static MagicKeys.MagicKeys;
using static MKLib;

namespace MagicKeys
{

public partial class Omnisphere
{

public static void LayersTab()
{
MouseClick("Left", Coords.X+545, Coords.Y+210, 1, 0, 0, 10);
MouseClick("Left", Coords.X+745, Coords.Y+265, 1, 0, 0, 10);
VUILoader("OmnisphereLayers");
}

public static void TypeLayerA()
{
MouseClick("Left", Coords.X+570, Coords.Y+330, 1, 0, 0, 10);
}

public static void TypeLayerB()
{
MouseClick("Left", Coords.X+570, Coords.Y+370, 1, 0, 0, 10);
}

public static void TypeLayerC()
{
MouseClick("Left", Coords.X+570, Coords.Y+410, 1, 0, 0, 10);
}

public static void TypeLayerD()
{
MouseClick("Left", Coords.X+570, Coords.Y+450, 1, 0, 0, 10);
}

}
}