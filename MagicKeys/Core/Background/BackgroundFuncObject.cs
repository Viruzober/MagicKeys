using System;

namespace MagicKeys
{
public class BackgroundFuncObject
{

public string Func;
public string Params;
public string ObjectName = null;
public bool AutoFunc = false;
public BackgroundFuncObject(string GetFunc, string GetParams, string GetObjectName = null, bool GetAutoFunc = false)
{
Func = GetFunc;
Params = GetParams;
ObjectName = GetObjectName;
AutoFunc = GetAutoFunc;
}

}
}