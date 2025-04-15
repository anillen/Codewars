using System;
using System.Linq;

public static class Kata
{
    public static string Solution(string str) 
    {
        return string.Join("",str.ToArray().Reverse());
    }
}