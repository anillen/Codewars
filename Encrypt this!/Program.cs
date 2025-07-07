namespace EncryptThis
{
    using System.Linq;

    public class Kata
    {
        public static string EncryptThis(string input)
        {
          if(string.IsNullOrEmpty(input))
            return input;

          var array = input.Split(' ').Select(EncryptWord);
          return string.Join(" ",array);
        }

        private static string EncryptWord(string word)
        {
          var result = "";
          var lengthDigit = ((int)word[0]).ToString().Length;

          result += ((int)word[0]).ToString() + word.Substring(1);
          if(word.Length <= lengthDigit-1)
            return result;

          return string.Join("", result.Select((x,i)=>{
            if(i==lengthDigit)
              return result[^1];
            if(i==result.Length-1)
              return result[lengthDigit];
            return x;
          }));
        }
    }
}