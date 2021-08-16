using System;
using static MKLib;

namespace MagicKeys
{

public partial class MagicKeys
{

public static void Slider(string Name, int X, int Y, string Type, double OnePercent, double SlidePercent)
{
String Input = InputBox(Name, T._("Enter a value for ")+Name+T._(" from 1 to 100"), 1, 100);
if (Input == null)
{
return;
}
int[] TempCoords;
if (Type == "H")
{
MouseClickDrag("Left", Coords.X+X, Coords.Y+Y, 0, Coords.Y+Y, 1, 10);
int V = Coords.X+X+Convert.ToInt32((Convert.ToInt32(Input)*OnePercent)*SlidePercent);
MouseClickDrag("Left", Coords.X+X, Coords.Y+Y, V, Coords.Y+Y, 1, 10);
}
else if (Type == "V")
{
Coords = GetModuleCoords(API.GetModule());
TempCoords = WinMove(50, 0);
Coords = GetModuleCoords(API.GetModule());
MouseClickDrag("Left", Coords.X+X, Coords.Y+Y, Coords.X+X, GetDisplayResolution().Height-30, 0, 10);
Coords = GetModuleCoords(API.GetModule());
WinMove(50, 250);
Coords = GetModuleCoords(API.GetModule());
int V = Coords.Y+Y-Convert.ToInt32(Convert.ToInt32(Convert.ToInt32(Input)*OnePercent)*SlidePercent);
MouseClickDrag("Left", Coords.X+X, Coords.Y+Y, Coords.X+X, V, 0, 10);
Coords = GetModuleCoords(API.GetModule());
WinMove(TempCoords[0], TempCoords[1]);
Coords = GetModuleCoords(API.GetModule());
}
Speak("Done");
}

}
}