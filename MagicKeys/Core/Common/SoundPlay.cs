using System.IO;
using System.Media;
using static MKLib;

namespace MagicKeys
{
public partial class MagicKeys
{

public static void SoundPlay(string SoundFile, bool Wait)
{
if (Settings.SoundTheme == true)
{
string SoundPath = @$".\Sounds\{SoundFile}.ogg";
MKLib.PlaySound(SoundPath, Wait);
}
}

}
}