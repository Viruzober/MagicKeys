using System;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public partial class Nexus
{

public static void FilterModifierOnOff()
{
MouseClick("Left", P[1]+95, P[2]+80, 1, 0, 0, 10);
CheckBox(P[1]+90, P[2]+60, "#3AA1FF", "FilterModifier");
}

public static void FilterModifierEnv()
{
KeyUnReg();
Slider("Env", 150, 70, "V", 1.38, 1.6);
KeyReg();
}

public static void FilterModifierCutOff()
{
KeyUnReg();
Slider("CutOff", 95, 130, "V", 1.38, 1.6);
KeyReg();
}

public static void FilterModifierRes()
{
KeyUnReg();
Slider("Res", 150, 130, "V", 1.38, 1.6);
KeyReg();
}

public static void FilterModifierAfk()
{
KeyUnReg();
Slider("Afk", 95, 205, "V", 1.38, 1.6);
KeyReg();
}

public static void FilterModifierDec()
{
KeyUnReg();
Slider("Dec", 150, 205, "V", 1.38, 1.6);
KeyReg();
}

public static void FilterModifierSus()
{
KeyUnReg();
Slider("Sus", 95, 265, "V", 1.38, 1.6);
KeyReg();
}

public static void FilterModifierRel()
{
KeyUnReg();
Slider("Rel", 150, 265, "V", 1.38, 1.6);
KeyReg();
}

}
}