using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int GetUnique(IEnumerable<int> numbers)
    {
        return numbers.GroupBy(x=>x).Single(x=>x.Count()==1).Key;
    }
}