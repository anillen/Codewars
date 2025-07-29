using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static IEnumerable<string> OpenOrSenior(int[][] data)
    {
      var result = new List<string>(data.Length);
      
      foreach(var item in data)
        if(item[0]>=55 && item[1]>7)
          result.Add("Senior");
        else
          result.Add("Open");
      
      return result;
    }
}