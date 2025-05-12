using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static string[] TowerBuilder(int nFloors)
    {
        int symbolCount = (nFloors * 2) - 1;
        int spaces = 0;
    
        List<string> result = new List<string>(nFloors);
    
        for(int i = nFloors;i > 0;i--)
        {
            string floor = "";
      
            for(int j = 0; j < spaces; j++)
                floor+=" ";
      
            for(int j = 0; j < symbolCount - (spaces * 2);j++)
                floor += "*";
      
            for(int j = 0; j < spaces; j++)
                floor+=" ";
      
            spaces+=1;
      
            result.Add(floor);
        }
        result.Reverse();
        return result.ToArray();
    }
}