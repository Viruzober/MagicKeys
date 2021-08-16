using System;
using System.Diagnostics;
using static MagicKeys.MagicKeys;
using static MKLib;

namespace MagicKeys
{

public partial class Kontakt
{

public static void Load()
{
MouseClick("Left", Coords.X+355, Coords.Y+17, 1, 0, 0, 10);
MouseClick("Left", Coords.X+355, Coords.Y+87, 1, 0, 0, 10);
}

public static void BatchResave()
{
MouseClick("Left", Coords.X+355, Coords.Y+17, 1, 0, 0, 10);
MouseClick("Left", Coords.X+355, Coords.Y+247, 1, 0, 0, 10);
}

public static void AddLibrary()
{
try
{
if (OS() == "64")
{
Process.Start(@"Settings\Native Instruments Kontakt\Add Library Tool x64\Add Library.exe");
}
else
{
Process.Start(@"Settings\Native Instruments Kontakt\Add Library Tool x32\Add Library.exe");
}
}
catch(Exception)
{
Speak("Add library tool not found");
}
}

public static void AllLibDelete()
{
if (ImgSearch("KontaktLibLoaded")[0] == 1)
{
Speak("No loaded libraries");
return;
}
MouseClick("Left", Coords.X+355, Coords.Y+17, 1, 0, 0, 10);
MouseClick("Left", Coords.X+355, Coords.Y+235, 1, 0, 0, 10);
}

public static void GoToLibList()
{
VUILoader("LibList");
}

public static void BackToOptionMenu()
{
VUILoader("Kontakt");
}

}
}