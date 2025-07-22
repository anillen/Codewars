public class Kata
{
  public static int SumMix(object[] x)
  {
    int result = 0;
    foreach(var item in x)
    {
      if(item is int number)
        result += number;
      if(item is string str)
        result += int.Parse(str);
    }
    return result;  
  }
}