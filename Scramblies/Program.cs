using System;
using System.Linq;
using System.Collections.Generic;

public class Scramblies 
{    
    public static bool Scramble(string str1, string str2) 
    {
      var container = str1.ToList();
      
      foreach(var item in str2)
      {
        if(container.IndexOf(item)<0)
          return false;
        
        container.Remove(item);
      }
      return true;
    }

}