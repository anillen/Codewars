using System.Linq;
using System.Collections.Generic;

class WhichAreIn
{
    public static string[] inArray(string[] array1, string[] array2)
    {
      var result = new List<string>(array1.Length);

      foreach(var item in array1)
        if(array2.Any(x=>x.Contains(item)))
          result.Add(item);

      return result.OrderBy(x=>x).ToArray();
    }
}