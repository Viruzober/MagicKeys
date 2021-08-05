using System.Windows.Forms;

namespace MagicKeys
{

public partial class MagicKeys
{

public static string GetKeyName(int Key)
{
if (Key == 33)
{
return "PageUp";
}

if (Key == 34)
{
return "PageDown";
}

if (Key >= 48 && Key <= 57)
{
return ((char)Key).ToString();
}
return ((Keys)Key).ToString();
}

}
}