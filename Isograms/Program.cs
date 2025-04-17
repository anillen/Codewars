using System;
using System.Linq;

public class Kata
{
    public static bool IsIsogram(string str) 
    {
        return str.ToLower().GroupBy(x=>x).FirstOrDefault(x=>x.Count() > 1) is null;
    }
}