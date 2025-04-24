using System;
using System.Linq;
public static class Kata
{
    const string ALPH = "abcdefghijklmnopqrstuvwxyz";
    public static string AlphabetPosition(string text)
    {
        return string.Join(' ',text.Select(t=>(ALPH.IndexOf(Char.ToLower(t))+1)).Where(t=>t>0));
    }
}