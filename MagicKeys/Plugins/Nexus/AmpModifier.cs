using System;
using System.Threading;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public partial class Nexus
{

public static void AmpModifierOnOff()
{
MouseClick("Left", P[1]+685, P[2]+80, 1, 0, 0, 10);
CheckBox(P[1]+685, P[2]+60, "#3AA1FF", "Amp modifier");
}

public static void AmpModifierPan()
{
Slider("Pan", 745, 70, "V", 1.38, 1.6);
}

public static void AmpModifierSpread()
{
Slider("Spread", 745, 130, "V", 1.38, 1.6);
}

public static void AmpModifierSpike()
{
Slider("Spike", 685, 130, "V", 1.38, 1.6);
}

public static void AmpModifierDec()
{
Slider("Dec", 745, 205, "V", 1.38, 1.6);
}

public static void AmpModifierAfk()
{
Slider("Afk", 685, 205, "V", 1.38, 1.6);
}

public static void AmpModifierRel()
{
Slider("Rel", 745, 265, "V", 1.38, 1.6);
}

public static void AmpModifierSus()
{
Slider("Sus", 685, 265, "V", 1.38, 1.6);
}

}
}