using System;
using System.Collections.Generic;
using System.Linq;

public class Kata {
    public static int[] DeleteNth(int[] arr, int x) {
        var result = new List<int>(arr.Length);
    
        foreach(var item in arr)
            if(result.Count(x=>x==item) < x)
                result.Add(item);
    
        return result.ToArray();
    }
}