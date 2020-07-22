using System;
using System.Reflection;
using System.IO;

namespace MagicKeys
{
public static partial class Ini
{

public static string IniRead(string GetFile, string GetSection, string GetKey)
{
StreamReader SR = new StreamReader(GetFile);
string FileStr = SR.ReadToEnd();
string SearchSection = FileStr.Substring(FileStr.IndexOf("["+GetSection+"]"));
string SearchKey = SearchSection.Substring(SearchSection.IndexOf(GetKey+"=")-1);
string KeyValue = SearchKey.Substring(0, SearchKey.IndexOf("\r\n"));
string Value = KeyValue.Substring(KeyValue.IndexOf("=")+1);
SR.Close();
return Value;
}	

}
}