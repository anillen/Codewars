using System.Collections.Generic;
using System;

public class Xbonacci
{
  public double[] Tribonacci(double[] signature, int n)
  {    
    if(n==0)
    {
      return [];
    }

    if(n < 3)
    {
      Array.Resize(ref signature,n);
      return signature;
    }
    
    List<double> result = new List<double>(signature);
      
    for(int i = 2;i < n - 1;i++)
    {
      double sum = result[i-2] + result[i-1]+ result[i];
      result.Add(sum);
    }
    
    return result.ToArray();
  }
}