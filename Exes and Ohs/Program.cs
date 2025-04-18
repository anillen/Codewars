using System.Linq;
using System;
public static class Kata 
{
    public static bool XO (string input)
    {
        string lower = input.ToLower();
        return lower.Count(x=>x=='x') == lower.Count(x=>x=='o');
    } 
}