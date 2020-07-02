using System;
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
KeyUnReg();
Slider("Pan", 745, 70, "V", 1.38, 1.6);
KeyReg();
}

public static void AmpModifierSpread()
{
KeyUnReg();
Slider("Spread", 745, 130, "V", 1.38, 1.6);
KeyReg();
}

public static void AmpModifierSpike()
{
KeyUnReg();
Slider("Spike", 685, 130, "V", 1.38, 1.6);
KeyReg();
}

public static void AmpModifierDec()
{
KeyUnReg();
Slider("Dec", 745, 205, "V", 1.38, 1.6);
KeyReg();
}

public static void AmpModifierAfk()
{
KeyUnReg();
Slider("Afk", 685, 205, "V", 1.38, 1.6);
KeyReg();
}

public static void AmpModifierRel()
{
KeyUnReg();
Slider("Rel", 745, 265, "V", 1.38, 1.6);
KeyReg();
}

public static void AmpModifierSus()
{
KeyUnReg();
Slider("Sus", 685, 265, "V", 1.38, 1.6);
KeyReg();
}

}
}