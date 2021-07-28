using System;
using System.Reflection;
using System.Windows.Forms;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static string InvokeFromString(string InvokeFunc, string FuncParam = null)
{
try
{
object Class = PClass;
MethodInfo Method;
object[] Param = null;
if ((Method = Class.GetType().GetMethod(InvokeFunc)) == null && BClass != null)
{
Class = BClass;
Method = Class.GetType().GetMethod(InvokeFunc);
}
if (Method == null)
{
Speak(T._("Method {0} is not implemented", InvokeFunc));
return null;
}
if (FuncParam != null)
{
Param = new object[] {FuncParam};
}
string Result = Method.Invoke(Class, Param) as string;
return Result;
}
catch(Exception ex)
{
MKDebugForm("ExceptionHook|"+ex.ToString());
return null;
}
}

}
}