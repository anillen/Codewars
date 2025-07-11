using System;
using System.Linq;

public class Kata
{
  public static string PigIt(string str)
  {
    return string.Join(" ",str.Split(' ').Select(ProcessString));
  }
  
  private static string ProcessString(string str)
  {
    if(string.IsNullOrEmpty(str))
      return str;
    if(!char.IsLetter(str[0]) && str.Length == 1)
      return str;
    
    return $"{str.Substring(1)}{str[0]}ay";
  }
}