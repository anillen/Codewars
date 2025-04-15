using System.Collections;
using System.Collections.Generic;

public class ListFilterer
{
    public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
    {
        List<int> result = new List<int>(listOfItems.Count);
      
        foreach(var item in listOfItems)
            if(item is int number)
                result.Add(number);
     
        return result;
    }
}