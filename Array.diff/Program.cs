using System.Collections.Generic;
using System;

public class Kata
{
    public static int[] ArrayDiff(int[] a, int[] b)
    {
        List<int> result = new List<int>(a.Length);
    
        for(int i = 0; i< a.Length; i++)
            if(Array.IndexOf(b,a[i])==-1)
                result.Add(a[i]);
    
        return result.ToArray();  
    }
}