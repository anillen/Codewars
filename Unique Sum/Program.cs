using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
  public static int? UniqueSum(List<int> lst)
  {
    if(lst.Count <= 0)
      return null;
    return lst.GroupBy(x=>x).Select(x=>x.Key).Sum();
  }
}