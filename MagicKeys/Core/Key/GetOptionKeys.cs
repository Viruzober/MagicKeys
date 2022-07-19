using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MagicKeys
{

public partial class MagicKeys
{

public static List<VUIKeyFuncContainer> GetPluginOptionKeys()
{
List<VUIKeyFuncContainer> OptionKeyFunc = new List<VUIKeyFuncContainer>();
if (AllVUIObjects.Count != 0)
{
if (Settings.NavigationType == false)
{
OptionKeyFunc.Add(new VUIKeyFuncContainer() {Key = "Tab", Function = new FunctionContainer() {Name = "VUIObjectNavigator", Param = "Next"}});
OptionKeyFunc.Add(new VUIKeyFuncContainer() {Key = "Shift+Tab", Function= new FunctionContainer() {Name = "VUIObjectNavigator", Param = "Back"}});
}
else
{
OptionKeyFunc.Add(new VUIKeyFuncContainer() {Key = "Right", Function= new FunctionContainer() {Name = "VUIObjectNavigator", Param = "Next"}});
OptionKeyFunc.Add(new VUIKeyFuncContainer() {Key = "Left", Function= new FunctionContainer() {Name = "VUIObjectNavigator", Param = "Back"}});
}
OptionKeyFunc.Add(new VUIKeyFuncContainer() {Key = "F1"});
OptionKeyFunc.Add(new VUIKeyFuncContainer() {Key = "Enter"});
}   
OptionKeyFunc.Add(new VUIKeyFuncContainer() {Key = "Ctrl+Shift+F3"});
OptionKeyFunc.Add(new VUIKeyFuncContainer() {Key = "Ctrl+Shift+F5"});
return OptionKeyFunc;
}

}
}