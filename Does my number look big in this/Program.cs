using System;
using System.Linq;

public class Kata
{
    public static bool Narcissistic(int number)
    {
        string value = number.ToString();
        return value.Select(v=>Math.Pow(int.Parse(v.ToString()),value.Length)).Sum()==number;
    }
}