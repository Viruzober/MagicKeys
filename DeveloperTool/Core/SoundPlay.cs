using System.IO;
using System.Media;
using static MKLib;

namespace MagicKeys
{
public partial class DeveloperTool
{

public static void SoundPlay(string SoundFile, int Wait)
{
string SoundPath = @$".\Sounds\{SoundFile}.ogg";
MKLib.PlaySound(SoundPath, Wait);
}

}
}