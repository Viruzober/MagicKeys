using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public partial class Omnisphere
{
public static void CopySerial()
{
int[] CS = ImgSearch("CopySerial", true);
MouseClick("Left", CS[1], CS[2], 1, 0, 0, 10);
Speak("copied "+GetText());
}

public static void PasteCode()
{
int[] PC = ImgSearch("PasteCode", true);
MouseClick("Left", PC[1], PC[2], 1, 0, 0, 10);
Speak("Pasted "+GetText());
}

public static void ActiveCode()
{
int[] AC = ImgSearch("ActiveCode", true);
MouseClick("Left", AC[1], AC[2], 1, 0, 0, 10);
}

}
}