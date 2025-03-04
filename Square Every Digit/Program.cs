using System;

public class Kata
{
  public static int SquareDigits(int n)
  {
    if(n < 10)
      return n*n;
    
    string result = "";
    foreach(var sNum in n.ToString())
    {
      int num = int.Parse(sNum.ToString());
      result+=num*num;
    }
    
    return int.Parse(result);
  }
}