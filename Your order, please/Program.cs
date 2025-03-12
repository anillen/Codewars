using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
  public static string Order(string words)
  {
    List<string> result = new(words.Split(" "));
    
    result = result.OrderBy(r=>GetNumber(r)).ToList();
    
    return string.Join(" ", result);
  }
  
  public static int GetNumber(string str)
  {
    foreach(var s in str)
      if(char.IsDigit(s))
        return int.Parse(s.ToString());
    return 0;
  }
}