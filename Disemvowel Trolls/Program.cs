using System;
using System.Linq;

public static class Kata
{
    public static string Disemvowel(string str)
    {
        string letters = "aeiou";
        string upperLetters = letters.ToUpper();
      
        return string.Join("",str.Where(c => !letters.Contains(c) && !upperLetters.Contains(c)));
    }
}