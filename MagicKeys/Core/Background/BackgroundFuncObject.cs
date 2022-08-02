using System;

namespace MagicKeys
{
public enum BackgroundCallMethod : int
{
VUIKey = 0,
VUIObject = 1
}

public class BackgroundFuncContainer
{

public string Func = String.Empty;
public string Param = String.Empty;
public string CallName = String.Empty;
public BackgroundCallMethod CallMethod;
}
}