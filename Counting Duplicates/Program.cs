using System;
using System.Linq;

public class Kata
{
    public static int DuplicateCount(string str)
    {
        return str.ToLower().GroupBy(s=>s).Where(x=>x.Count()>1).Count();
    }
}