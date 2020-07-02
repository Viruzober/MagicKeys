using System;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public partial class Nexus
{

public static void OutputVol()
{
KeyUnReg();
Slider("Vol", 720, 415, "V", 1.38, 1.6);
KeyReg();
}

}
}