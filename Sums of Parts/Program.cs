using System;
using System.Linq;

class SumParts
{

    public static int[] PartsSums(int[] ls)
    {
      var result = new int[ls.Length+1];

      result[0] = ls.Sum();

      for(int i = 1;i <= ls.Length; i++)
        result[i] = result[i-1] - ls[i-1];

      return result;
    }
}