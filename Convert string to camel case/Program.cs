using System;
using System.Linq;

public class Kata
{
    public static string ToCamelCase(string str)
    {
        return string.Concat(str.Split('-','_').Select((s,i)=> i > 0 ? char.ToUpper(s[0]) + s.Substring(1):s));
    }
}