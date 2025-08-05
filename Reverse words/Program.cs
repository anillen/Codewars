using System;
using System.Linq;

public static class Kata
{
  public static string ReverseWords(string str)
  {
    return string.Join(" ", str.Split(" ").Select(s=>string.Join("",s.Reverse())));
  }
}