using System;

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
TempCoords = WinMove(50, 0);
MouseClickDrag("Left", Coords.X+X, Coords.Y+Y, Coords.X+X, GetDisplayResolution().Height-30, 0, 10);
WinMove(50, 250);
int V = Coords.Y+Y-Convert.ToInt32(Convert.ToInt32(Convert.ToInt32(Input)*OnePercent)*SlidePercent);
MouseClickDrag("Left", Coords.X+X, Coords.Y+Y, Coords.X+X, V, 0, 10);
WinMove(TempCoords[0], TempCoords[1]);
}
Speak("Done");
}

}
}