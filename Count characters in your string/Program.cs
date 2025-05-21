using System.Collections.Generic;
using System;
using System.Linq;

public class Kata
{
    public static Dictionary<char, int> Count(string str)
    {
        var result = new Dictionary<char,int>();
        var groups = str.GroupBy(x=>x);
        foreach(var group in groups)
            result.Add(group.Key, group.Count());
        return result;
    }
}