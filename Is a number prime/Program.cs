using System;

public static class Kata
{
    public static bool IsPrime(int number)
    {
        if(number <= 1)
            return false;
      
        if(number == 2 || number == 3 || number == 5)
            return true;
      
        if(number % 2 == 0 || number % 3 == 0 || number % 5 == 0)
            return false;
      
        long bound = (long)Math.Floor(Math.Sqrt(number));
      
        for(long i = 6; i <= bound;i += 6)
        {
            if(number % (i+1)==0||number % (i+5)==0)
                return false;
        }
        return true;
    }
}