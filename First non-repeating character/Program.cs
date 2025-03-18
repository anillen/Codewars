using System.Collections.Generic;
using System;
using System.Linq;

public class Kata
{
    public static string FirstNonRepeatingLetter(string s)
    {
        if(string.IsNullOrEmpty(s))
            return "";
    
        Dictionary<char,int> letters = new (s.Length);
    
        foreach(char symbol in s)
        {
            char lower = Char.ToLower(symbol);
            if(letters.TryGetValue(lower, out _))
                letters[lower]+=1;
            else
                letters.Add(lower,1);
        }
    
        var exclusivePair = letters.MinBy(l=>l.Value);
    
        if(exclusivePair.Value > 1 )
            return "";
    
        char upperExclusive = Char.ToUpper(exclusivePair.Key);
        char lowerExclusive = exclusivePair.Key;

        return s.First(c=>c == lowerExclusive || c == upperExclusive).ToString();
    }
}