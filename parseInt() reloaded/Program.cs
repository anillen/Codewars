using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Parser
{
    public static Dictionary<string,int> WordNumbers = new Dictionary<string, int>
    {
        {"zero", 0}, {"one", 1}, {"two", 2}, {"three", 3}, {"four", 4},
        {"five", 5}, {"six", 6}, {"seven", 7}, {"eight", 8},
        {"nine", 9}, {"ten", 10}, {"eleven", 11}, {"twelve", 12},
        {"thirteen", 13}, {"fourteen", 14}, {"fifteen", 15},
        {"sixteen", 16}, {"seventeen", 17}, {"eighteen", 18},
        {"nineteen", 19}, {"twenty", 20}, {"thirty", 30},
        {"forty", 40}, {"fifty", 50}, {"sixty", 60},
        {"seventy", 70}, {"eighty", 80}, {"ninety", 90},
        {"hundred", 100}, {"thousand", 1000}, {"million", 1000000}
    };

    public static int ParseInt(string s)
    {
        string[] words = s.Split(new [] {' ','-'}, StringSplitOptions.RemoveEmptyEntries);
      
        int result = 0;
        int current = 0;
      
        foreach(var word in words)
        { 
            if(word == "and")
                continue;
      
            int number = WordNumbers[word];
        
            if(number == 100)
            {
                current*=number;
            }
            else if(number == 1000||number== 1000000)
            {
                current*=number;
                result+=current;
                current = 0;
            }else
            {
                current+=number;
            }
        }
      
        return result+current;
    }
}