using System;

class GapInPrimes 
{
    public static long[] Gap(int g, long m, long n) 
    {
        long before = 0;
        for(long i = m;i <= n;i++)
        {
            if(IsPrime(i))
            {
                if(before != 0)
                {
                    if((int)(i-before)==g)
                        return new [] { before,i };
                    else
                        before = i;
                }
                else
                    before = i;
            }
        }
        return null;
    }
  
    public static bool IsPrime(long number)
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