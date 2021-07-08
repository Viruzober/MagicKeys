using System;
using System.Threading;

namespace MagicKeys
{
public partial class DeveloperTool
{

public static void MouseMover(string To)
{
OCRR = string.Empty;
Thread.Sleep(20);
KeyUnReg();
int[] MP = MagicKeys.GetMousePosition();
if (To == "Left")
{
if (MP[0]-MouseStep <= P[1])
{
MagicKeys.SoundPlay("End", 0);
MagicKeys.MouseMove(P[1], MP[1], 0);
KeyReg();
return;
}
MagicKeys.MouseMove(MP[0]-MouseStep, MP[1], 0);
}

if (To == "Right")
{
if (MP[0]+MouseStep >= P[3])
{
MagicKeys.SoundPlay("End", 0);
MagicKeys.MouseMove(P[3], MP[1], 0);
KeyReg();
return;
}
MagicKeys.MouseMove(MP[0]+MouseStep, MP[1], 0);
}

if (To == "Up")
{
if (MP[1]-MouseStep <= P[2])
{
MagicKeys.SoundPlay("End", 0);
MagicKeys.MouseMove(MP[0], P[2], 0);
KeyReg();
return;
}
MagicKeys.MouseMove(MP[0], MP[1]-MouseStep, 0);
}

if (To == "Down")
{
if (MP[1]+MouseStep >= P[4])
{
MagicKeys.SoundPlay("End", 0);
MagicKeys.MouseMove(MP[0], P[4], 0);
KeyReg();
return;
}
MagicKeys.MouseMove(MP[0], MP[1]+MouseStep, 0);
}
if(AutoOCR == 1)
{
VisionBot();
}
KeyReg();
}

}
}