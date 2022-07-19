using System;
using static MagicKeys.MagicKeys;
using static MKLib;

namespace MagicKeys
{

public partial class Kontakt
{

public static void LibSave()
{
LibNormalize();
int X = Coords.X;
int Y = Coords.Y;
int Count = 0;
while (ImageSearchArea("KontaktLibCount", X-10, Y+10, GetDisplayResolution().Width, GetDisplayResolution().Height, 20)[0] == 1)
{
int[] CI = ImageSearchArea("KontaktLibCount", X-10, Y+10, GetDisplayResolution().Width, GetDisplayResolution().Height, 20);
X = CI[1];
Y = CI[2];
Count += 1;
}
string Input = InputBox("Save Instrument", "Enter library number from 1 to "+Count.ToString()+".", 1, Count);
if (Input != null)
{
MouseClick("Left", Coords.X+355, Coords.Y+17, 1, 0, 0, 10);
MouseMove(Coords.X+355, Coords.Y+170, 0);
MouseMove(Coords.X+320, Coords.Y+170, 1);
while (ImageSearch("KontaktLibSave")[0] == 0)
{
;
}

int[] LS = ImageSearch("KontaktLibSave");
MouseClick("Left", LS[5]+10, LS[2]+(17*(Convert.ToInt32(Input))), 1, 0, 0, 10);
}
}

}
}