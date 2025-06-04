using System.Linq;
using System.Collections.Generic;
using System;

public class StockList {

    public static string stockSummary(String[] lstOfArt, String[] lstOf1stLetter) {

      var library = new Dictionary<char,int>();

      foreach(var item in lstOf1stLetter)
        library.Add(item[0], 0);

      foreach(var item in lstOfArt)
      {
        int value = int.Parse(item.Split(' ')[1]);

        if(library.ContainsKey(item[0]))
          library[item[0]] += value;
      }
      if(!library.Any(p=>p.Value>0))
        return string.Empty;

      return string.Join(" - ", library.Select((pair)=>$"({pair.Key.ToString()} : {pair.Value})"));
    }
}