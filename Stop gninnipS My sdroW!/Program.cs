using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
    public static string SpinWords(string sentence)
    {
        string[] words = sentence.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    
        for(int i = 0; i < words.Length; i++)
            if(words[i].Length >= 5)
                words[i] = string.Join("",words[i].Reverse());
    
        return string.Join(" ", words);
    }
}