using System.Linq;
using System;

public class Kata
{
    public static int FindShort(string s)
    {
        return s.Split(" ", StringSplitOptions.RemoveEmptyEntries).MinBy(x=>x.Length).Length;
    }
}