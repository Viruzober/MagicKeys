using System;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static void VUILoader(string File)
{
SoundPlay("ChangeVUI.ogg", 0);
IniFile = File;
Count = Ini.IniCountSections(File);
VUIObjects.Clear();
for (int I = 1; I <= Count; I++)
{
VUIObjects.Add(I, true);
}
VUIUpdate(true);
}

}
}