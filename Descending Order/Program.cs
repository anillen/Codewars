using System;
using System.Linq;

public static class Kata
{
    public static int DescendingOrder(int num)
    {
        char[] array = num.ToString().ToArray().OrderByDescending(x=>x).ToArray();
        return int.Parse(string.Join("",array));
    }
}