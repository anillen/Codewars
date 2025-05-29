using System;
using System.Linq;

public class Kata
{
    public static string ToWeirdCase(string s)
    {
        var array = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        var result = array.Select(word=>string.Join("",word.Select((symbol,index)=>index%2==0? char.ToUpper(symbol):char.ToLower(symbol))));
        return string.Join(" ",result);
    }
}