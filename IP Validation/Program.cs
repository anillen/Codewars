using System.Text.RegularExpressions;

namespace Solution
{
    class Kata
    {
        public static bool IsValidIp(string ipAddres)
        {
          var pattern = @"^((25[0-5]|(2[0-4]|1\d|[1-9]|)\d)\.?\b){4}$";

          return Regex.IsMatch(ipAddres,pattern);
        }
    }
}