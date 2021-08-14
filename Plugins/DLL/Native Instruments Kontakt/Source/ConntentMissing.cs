using static MagicKeys.MagicKeys;

namespace MagicKeys
{

public partial class Kontakt
{

public static void CmBFD()
{
MouseClick("Left", Coords.X+220, Coords.Y+270, 1, 0, 0, 10);
}

public static void CmBFF()
{
MouseClick("Left", Coords.X+220, Coords.Y+320, 1, 0, 0, 10);
}

public static void CmSFST()
{
MouseClick("Left", Coords.X+50, Coords.Y+270, 1, 0, 0, 10);
}

public static void CmSD()
{
MouseClick("Left", Coords.X+50, Coords.Y+290, 1, 0, 0, 10);
}

public static void CmAL()
{
MouseClick("Left", Coords.X+330, Coords.Y+430, 1, 0, 0, 10);
}

public static void CmRAP()
{
MouseClick("Left", Coords.X+190, Coords.Y+290, 1, 0, 0, 10);
CheckBox(Coords.X+195, Coords.Y+295, "#2F2F2F", "Resolue_all_possible");
}

public static void CmCFD()
{
MouseClick("Left", Coords.X+30, Coords.Y+355, 1, 0, 0, 10);
CheckBox(Coords.X+30, Coords.Y+355, "#2F2F2F", "Check_for_duplicates_(takes_more_time)");
}

public static void CmAAFT()
{
MouseClick("Left", Coords.X+30, Coords.Y+380, 1, 0, 0, 10);
CheckBox(Coords.X+30, Coords.Y+380, "#2F2F2F", "Allow_alternative_file_types");
}

public static void CmKSM()
{
MouseClick("Left", Coords.X+30, Coords.Y+400, 1, 0, 0, 10);
CheckBox(Coords.X+30, Coords.Y+400, "#2F2F2F", "Keep_search_mode_end_selected_folders_for_the_corrent_session");
}

}
}