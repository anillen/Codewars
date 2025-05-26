using System.Collections.Generic;
using System;
using System.Linq;

public class SumDigPower {
    
    public static long[] SumDigPow(long a, long b) 
    {
        List<long> result = new List<long>();
        while(a < b)
        {
            if(IsCleanNumber(a))
                result.Add(a);
            a++;
        }
      
        return result.ToArray();
    }
    
    public static bool IsCleanNumber(long number)
    {
        var str = number.ToString();
        return str.Select((s,i)=>Math.Pow(int.Parse(s.ToString()),i+1)).Sum() == number;
    }
}