using System.Linq;

public static class Kata
{
  // return masked string
  public static string Maskify(string cc)
  {
    if(cc.Length <= 4)
      return cc;
    
    return string.Join(string.Empty,cc.Select((c,i)=>i<cc.Length-4?'#':c));
  }
}
