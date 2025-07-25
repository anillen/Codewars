using System.Linq;

public class TwoToOne 
{ 
	public static string Longest (string s1, string s2) 
  {
    return string.Join("",s1.Union(s2).OrderBy(s=>s));
  }
}