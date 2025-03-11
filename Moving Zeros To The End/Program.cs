using System.Collections.Generic;

public class Kata
{
  public static int[] MoveZeroes(int[] arr)
  {
    List<int> result = new List<int>(arr.Length);
    int zeros = 0;
    
    foreach(int value in arr)
    {
      if(value==0)
        zeros++;
      else
        result.Add(value);
    }
    while(zeros > 0)
    {
      result.Add(0);
      zeros--;
    }
    return result.ToArray();
  }
}