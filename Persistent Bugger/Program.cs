using System;
using System.Linq;

public class Persist 
{
    public static int Persistence(long n) 
    {    
        int count = 0;
      
        while(n>9)
        {
            n =  GetMult(n);
            count++;
        }
        return count;
    }
  
    private static long GetMult(long n)
    {
        long multiply = 1;
    
        foreach(var item in n.ToString())
            multiply *= int.Parse(item.ToString());
    
        return multiply;
    }
}