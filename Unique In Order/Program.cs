using System.Collections.Generic;
using System.Linq;

public static class Kata
{
    public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable) 
    {
        if(!iterable.Any())
            return iterable;
    
        var result = new List<T>(iterable.Count());
        var beforeItem = iterable.First();
        result.Add(beforeItem);
    
        foreach(var item in iterable)
        {
            if(item.Equals(beforeItem))
                continue;
      
            result.Add(item);
            beforeItem = item;
        }
        return result;
    }
}