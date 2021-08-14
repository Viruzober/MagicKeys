using System.Windows.Forms;
using Microsoft.Collections.Extensions;

namespace MagicKeys
{

public partial class MagicKeys
{

public static OrderedDictionary<string, string> GetOptionKeys()
{
OrderedDictionary<string, string> OptionKeys = new OrderedDictionary<string, string>();
if (VUIObjects.Count != 0)
{
if (Settings.NavigationType == false)
{
OptionKeys.Add("Tab", "VUIObjectNavigator,Next");
OptionKeys.Add("Shift+Tab", "VUIObjectNavigator,Back");
}
else
{
OptionKeys.Add("Right", "VUIObjectNavigator,Next");
OptionKeys.Add("Left", "VUIObjectNavigator,Back");
}
OptionKeys.Add("F1", "Speak,Help");
OptionKeys.Add("Enter", "Invoker");
}
OptionKeys.Add("Ctrl+Shift+F3", "Speak,OptionHelp");
OptionKeys.Add("Ctrl+Shift+F5", "ReloadVUI");
return OptionKeys;
}

}
}