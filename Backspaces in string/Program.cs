
public class Kata
{
  public static string CleanString(string s)
  {
    string result = "";
    for(int i = 0; i < s.Length;i++)
    {
      if(s[i] == '#')
      {
        if(result.Length > 0)
          result = result.Substring(0,result.Length-1);
      }
      else
        result+=s[i];
    }

    return result;
  }
}