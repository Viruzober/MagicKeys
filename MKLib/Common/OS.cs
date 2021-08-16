using System;


public static partial class MKLib
{

public static string OS()
{
bool Bit = Environment.Is64BitOperatingSystem;
if (Bit == true)
{
return "64";
}
return "86";
}

}