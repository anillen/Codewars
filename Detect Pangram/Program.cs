using System;
using System.Linq;

public static class Kata
{
    const string LETTERS = "abcdefghijklmnopqrstuvwxyz";
  
    public static bool IsPangram(string str)
    {
        return LETTERS.All(l=>str.Any(s => s==l || s== char.ToUpper(l)));
    }
}