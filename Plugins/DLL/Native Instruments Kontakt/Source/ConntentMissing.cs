using System;
using static MagicKeys.MagicKeys;
namespace MagicKeys
{
public partial class Kontakt
{
public static void CmBFD()
{
MouseClick("Left", P[1]+220, P[2]+270, 1, 0, 0, 10);
}
public static void CmBFF()
{
MouseClick("Left", P[1]+220, P[2]+320, 1, 0, 0, 10);
}
public static void CmSFST()
{
MouseClick("Left", P[1]+50, P[2]+270, 1, 0, 0, 10);
}
public static void CmSD()
{
MouseClick("Left", P[1]+50, P[2]+290, 1, 0, 0, 10);
}
public static void CmAL()
{
MouseClick("Left", P[1]+330, P[2]+430, 1, 0, 0, 10);
}
public static void CmRAP()
{
MouseClick("Left", P[1]+190, P[2]+290, 1, 0, 0, 10);
CheckBox(P[1]+195, P[2]+295, "#2F2F2F", "Resolue_all_possible");
}
public static void CmCFD()
{
MouseClick("Left", P[1]+30, P[2]+355, 1, 0, 0, 10);
CheckBox(P[1]+30, P[2]+355, "#2F2F2F", "Check_for_duplicates_(takes_more_time)");
}
public static void CmAAFT()
{
MouseClick("Left", P[1]+30, P[2]+380, 1, 0, 0, 10);
CheckBox(P[1]+30, P[2]+380, "#2F2F2F", "Allow_alternative_file_types");
}
public static void CmKSM()
{
MouseClick("Left", P[1]+30, P[2]+400, 1, 0, 0, 10);
CheckBox(P[1]+30, P[2]+400, "#2F2F2F", "Keep_search_mode_end_selected_folders_for_the_corrent_session");
}
}
}