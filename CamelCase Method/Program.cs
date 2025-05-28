using System.Linq;
using System;
namespace Kata
{
    public static class Problem
    {
        public static string CamelCase(this string str)  
        {  
            return string.Join("",str.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(s=>char.ToUpper(s[0])+s.Substring(1)));
        }
    }
}