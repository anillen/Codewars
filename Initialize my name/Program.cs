using System;

public class Kata
{
    public static string InitializeNames(string name)
    {
        string[] split = name.Split(' ',StringSplitOptions.RemoveEmptyEntries);
    
        if(split.Length<=2)
            return name;
    
        for(int i = 1; i<split.Length-1;i++)
            split[i] = $"{split[i][0]}.";

        return string.Join(' ',split);
    }
}