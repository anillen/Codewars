using System;

public static class Kata 
{
    public static int summation(int num)
    {
      int result = 0;
      for(int i = 1; i <= num; i++)
        result+=i;
      return result;
    }
}