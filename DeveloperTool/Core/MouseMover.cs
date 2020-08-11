using System;

namespace MagicKeys
{
public partial class DeveloperTool
{

public static void MouseMover(string To)
{
int[] MP = MagicKeys.GetMousePosition();
if (To == "Left")
{
if (MP[0]-MouseStep <= P[1])
{
MagicKeys.SoundPlay("End", 0);
return;
}
MagicKeys.MouseMove(MP[0]-MouseStep, MP[1], 0);
}

if (To == "Right")
{
if (MP[0]+MouseStep >= P[3])
{
MagicKeys.SoundPlay("End", 0);
return;
}
MagicKeys.MouseMove(MP[0]+MouseStep, MP[1], 0);
}

if (To == "Up")
{
if (MP[1]-MouseStep <= P[2])
{
MagicKeys.SoundPlay("End", 0);
return;
}
MagicKeys.MouseMove(MP[0], MP[1]-MouseStep, 0);
}

if (To == "Down")
{
if (MP[1]+MouseStep >= P[4])
{
MagicKeys.SoundPlay("End", 0);
return;
}
MagicKeys.MouseMove(MP[0], MP[1]+MouseStep, 0);
}

}

}
}