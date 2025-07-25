using System;
using System.Linq;

public static class Kata
{
  public static string Sentencify(string[] words)
  {
    string result = string.Join(" ", words.Select((s,i)=>{
      if(i>0)
        return s;
      else
        return $"{char.ToUpper(s[0])}{s.Substring(1)}";
    }));
    result+=".";
    return result;
  }
}