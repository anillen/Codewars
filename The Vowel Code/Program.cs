using System.Linq;

public static class VowelCode
{
  const string LETTERS = "aeiou";

  public static string Encode(string msg)
  {
    string result = "";
    foreach(var item in msg)
    {
      int index = LETTERS.IndexOf(item);
      if(index > -1)
        result += index+1;
      else
        result += item;
    }
    return result;
  }

  public static string Decode(string msg)
  {
    return string.Join("",msg.Select(x=>char.IsDigit(x) ? LETTERS[int.Parse(x.ToString())-1] : x));
  }
}
