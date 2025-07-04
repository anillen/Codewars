using System;
using System.Linq;

namespace Kata
{
  public static class Kata
  {
    public static int[] UpArray(int[] num)
		{
      if(num.Length == 0 || num.Any(x=>x > 9) || num.Any(x=>x < 0))
        return null;

      return AddNumber(num, num.Length-1);
		}
    private static int[] AddNumber(int[] num, int index)
    {
      if(index < 0)
      {
        int[] temp = new int[num.Length+1];
        Array.Copy(num,0,temp,1, num.Length);
        temp[0] = 1;
        return temp;
      }

      num[index] += 1;
      if(num[index]==10)
      {
        num[index]=0;
        return AddNumber(num,index-1);
      }
      return num;
    }
  }
}