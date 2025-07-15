using System.Linq;

public class Kata
{
  public static string Borrow(string s)
  {
    string result = "";
    foreach(var item in s)
    {
      if(char.IsPunctuation(item))
        continue;
      if(item==' ')
        continue;
      if(char.IsUpper(item))
        result+=char.ToLower(item);
      else
        result+=item;
    }
    return result;
  }
}