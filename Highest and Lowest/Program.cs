using System;
using System.Linq;
public static class Kata
{
    public static string HighAndLow(string numbers)
    {
        int[] array = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(x=>int.Parse(x.ToString())).ToArray();
    
        return $"{array.Max()} {array.Min()}";
    }
}