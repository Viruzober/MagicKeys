using System;

namespace MagicKeys
{
public class VUIObjectContainer
{

public bool Visible = true;
public string Name = string.Empty;
public string Text = string.Empty;
public string Type = string.Empty;
public string Help = string.Empty;
public FunctionContainer AutoFunction = new FunctionContainer();
public FunctionContainer Function = new FunctionContainer();

}
}