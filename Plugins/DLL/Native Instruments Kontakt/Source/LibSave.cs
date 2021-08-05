using System;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public partial class Kontakt
{
public static void LibSave()
{
LibNormalize();
int X = P[1];
int Y = P[2];
int Count = 0;
while (ImgSearchArea("KontaktLibCount", X-10, Y+10, Width, Height, 20)[0] == 1)
{
int[] CI = ImgSearchArea("KontaktLibCount", X-10, Y+10, Width, Height, 20);
X = CI[1];
Y = CI[2];
Count += 1;
}
string Input = InputBox("Save Instrument", "Enter library number from 1 to "+Count.ToString()+".", 1, Count);
if (Input != null)
{
MouseClick("Left", P[1]+355, P[2]+17, 1, 0, 0, 10);
MouseMove(P[1]+355, P[2]+170, 0);
MouseMove(P[1]+320, P[2]+170, 1);
while (ImgSearch("KontaktLibSave")[0] == 0)
{
;
}

int[] LS = ImgSearch("KontaktLibSave");
MouseClick("Left", LS[5]+10, LS[2]+(17*(Convert.ToInt32(Input))), 1, 0, 0, 10);
}
}

}
}