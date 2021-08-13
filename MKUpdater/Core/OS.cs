using System;

namespace MKUpdater
{

public partial class MKUpdater
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
}