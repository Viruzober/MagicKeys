using System;

namespace MagicKeys
{
public partial class MagicKeys
{

public static void Slider(string Name, int X, int Y, string Type, double OnePercent, double SlidePercent)
{
int Input = Convert.ToInt32(InputBox(Name, T._("Enter a value for ")+Name+T._(" from 1 to 100"), 1, 100));
if (Input == null)
{
return;
}
if (Type == "H")
{
MouseClickDrag("Left", P[1]+X, P[2]+Y, 0, P[2]+Y, 1, 10);
int V = P[1]+X+Convert.ToInt32((Input*OnePercent)*SlidePercent);
MouseClickDrag("Left", P[1]+X, P[2]+Y, V, P[2]+Y, 1, 10);
}
else if (Type == "V")
{
WindowMover(50, 0, true);
MouseClickDrag("Left", P[1]+X, P[2]+Y, P[1]+X, Height-30, 0, 10);
WindowMover(50, 250, false);
int V = P[2]+Y-Convert.ToInt32(Convert.ToInt32(Input*OnePercent)*SlidePercent);
MouseClickDrag("Left", P[1]+X, P[2]+Y, P[1]+X, V, 0, 10);
WindowMover(DP[1], DP[2], false);
}
Speak("OK");
}

}
}