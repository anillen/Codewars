using System;
using System.Linq;
using System.Collections.Generic;

public class RomanConvert
{
    public static string Solution(int n)
    {
        var numbers = new string [4,9]{
            {"I","II","III","IV","V","VI","VII","VIII","IX"},
            {"X","XX","XXX","XL","L","LX","LXX","LXXX","XC"},
            {"C","CC","CCC","CD","D","DC","DCC","DCCC","CM"},
            {"M","MM","MMM", "", "", "", "","",""}};
    
        var result = new List<string>();
    
        var str = string.Join("",n.ToString().Reverse());
    
        for(int i = 0; i < str.Length; i++)
        {
            var index = int.Parse(str[i].ToString());
            if(index != 0)
                result.Add(numbers[i,index-1]);
        }
    
        result.Reverse();
        return string.Join("",result.ToArray());
    }
}