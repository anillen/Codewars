using System.Collections.Generic;
using System;

public class Deadfish
{
  public static int[] Parse(string data)
  {
    var result = new List<int>(data.Length);
    int value = 0;

    foreach(var item in data)
      switch(item)
      {
          case 'i':
          value++;
          break;
          case 'd':
          value--;
          break;
          case 's':
          value = (int)Math.Pow(value,2);
          break;
          case 'o':
          result.Add(value);
          break;
      }

    return result.ToArray();
  }
}