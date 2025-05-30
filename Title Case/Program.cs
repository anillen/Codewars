using System;
using System.Linq;

public class Kata
{
  public static string TitleCase(string title, string minorWords="")
  {
    var array = title.Split(" ",StringSplitOptions.RemoveEmptyEntries);
    if(minorWords is null)
      return string.Join(" ", array.Select(s=>char.ToUpper(s[0])+s.Substring(1).ToLower()));

    var minors = minorWords.Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(m=>m.ToLower()).ToArray();


    for(int i = 0; i< array.Length; i++)
    {
      if(i==0)
      {
        array[i] = char.ToUpper(array[i][0]) + array[i].Substring(1).ToLower();
        continue;
      }
      if(Array.IndexOf(minors,array[i].ToLower())==-1)
        array[i] = char.ToUpper(array[i][0]) + array[i].Substring(1).ToLower();
      else
        array[i] = array[i].ToLower();
    }
    return string.Join(" ",array);

  }
}