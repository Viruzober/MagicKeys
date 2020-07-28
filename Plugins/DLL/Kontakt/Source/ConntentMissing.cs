using System;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public static partial class Kontakt
{

public static void CmBFD()
{
MouseClick("Left", P[1]+220, P[2]+250, 1, 0, 0, 1);
}

public static void CmBFF()
{
MouseClick("Left", P[1]+220, P[2]+300, 1, 0, 0, 1);
}

public static void CmSFST()
{
MouseClick("Left", P[1]+50, P[2]+250, 1, 0, 0, 1);
}

public static void CmSD()
{
MouseClick("Left", P[1]+50, P[2]+270, 1, 0, 0, 1);
}

public static void CmAL()
{
MouseClick("Left", P[1]+330, P[2]+410, 1, 0, 0, 1);
}

public static void CmRAP()
{
MouseClick("Left", P[1]+190, P[2]+270, 1, 0, 0, 1);
CheckBox(P[1]+190, P[2]+270, "#2F2F2F", "Resolue_all_possible");
}

public static void CmCFD()
{
MouseClick("Left", P[1]+25, P[2]+330, 1, 0, 0, 1);
CheckBox(P[1]+25, P[2]+330, "#2F2F2F", "Check_for_duplicates_(takes_more_time)");
}

public static void CmAAFT()
{
MouseClick("Left", P[1]+25, P[2]+353, 1, 0, 0, 1);
CheckBox(P[1]+25, P[2]+353, "#2F2F2F", "Allow_alternative_file_types");
}

public static void CmKSM()
{
MouseClick("Left", P[1]+25, P[2]+375, 1, 0, 0, 1);
CheckBox(P[1]+25, P[2]+375, "#2F2F2F", "Keep_search_mode_end_selected_folders_for_the_corrent_session");
}

}
}