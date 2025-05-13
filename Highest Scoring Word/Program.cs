using System.Linq;
public class Kata
{
    public static string High(string s)
    {
        return s.Split(' ').MaxBy(a=>a.Select(c=>c - 'a' + 1).Sum());
    }
}