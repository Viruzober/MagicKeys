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
Slider("Env", 150, 70, "V", 1.38, 1.6);
}

public static void FilterModifierCutOff()
{
Slider("CutOff", 95, 130, "V", 1.38, 1.6);
}

public static void FilterModifierRes()
{
Slider("Res", 150, 130, "V", 1.38, 1.6);
}

public static void FilterModifierAfk()
{
Slider("Afk", 95, 205, "V", 1.38, 1.6);
}

public static void FilterModifierDec()
{
Slider("Dec", 150, 205, "V", 1.38, 1.6);
}

public static void FilterModifierSus()
{
Slider("Sus", 95, 265, "V", 1.38, 1.6);
}

public static void FilterModifierRel()
{
Slider("Rel", 150, 265, "V", 1.38, 1.6);
}

}
}