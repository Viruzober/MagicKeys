using System;
using System.Reflection;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static string InvokeFromString(string InvokeFunc, string FuncParam = null, string GetClass = null)
{
KeyUnReg();
Type Class = PClass;
MethodInfo Method;
object[] Param;
if ((Method = Class.GetMethod(InvokeFunc)) == null && BClass != null)
{
Class = BClass;
Method = Class.GetMethod(InvokeFunc);
}
if (Method == null)
{
Speak("Метод "+InvokeFunc+" не реализован");
KeyReg();
return null;
}
if (FuncParam != null)
{
Param = new object[] {FuncParam};
}
else
{
Param = new object[] {};
}
string Result = Method.Invoke(OClass, Param) as string;
KeyReg();
return Result;
}

}
}