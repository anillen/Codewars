using System;

public class Kata
{
    public static string GetMiddle(string s)
    {
        int center = s.Length/2;
        if(s.Length % 2 == 0)
            return $"{s[center-1]}{s[center]}";
        else
            return $"{s[center]}";
    }
}