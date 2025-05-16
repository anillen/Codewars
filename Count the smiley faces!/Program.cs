using System.Linq;
using System.Text.RegularExpressions;

public static class Kata
{  
    public static int CountSmileys(string[] smileys) 
    {    
        return smileys.Count(s=>Regex.IsMatch(s,@"([;:][-~]?[\)D])"));
    }
}