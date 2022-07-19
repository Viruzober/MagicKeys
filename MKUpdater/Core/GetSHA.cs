using System;
using System.IO;
using System.Security.Cryptography;

namespace MKUpdater
{

public partial class MKUpdater
{

public static string GetSHA(string file)
{
using (FileStream stream = File.OpenRead(file))
{
var sha =  SHA256.Create();
byte[] checksum = sha.ComputeHash(stream);
return BitConverter.ToString(checksum).Replace("-", String.Empty);
}
}

}
}