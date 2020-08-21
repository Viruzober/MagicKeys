using System;
using System.Reflection;
using System.Windows.Forms;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static string InvokeFromString(string InvokeFunc, string FuncParam = null)
{
Type Class = PClass;
object OBC = Activator.CreateInstance(PClass);
MethodInfo Method;
object[] Param = null;
if ((Method = Class.GetMethod(InvokeFunc)) == null && BClass != null)
{
Class = BClass;
OBC = Activator.CreateInstance(BClass);
Method = Class.GetMethod(InvokeFunc);
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
string Result = Method.Invoke(OBC, Param) as string;
return Result;
}

}
}