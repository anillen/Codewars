using System;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        string letters = "aeiou";
      
        int vowelCount = 0;

        foreach(var letter in str)
            if(letters.Contains(letter))
                vowelCount++;

        return vowelCount;
    }
}