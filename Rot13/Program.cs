public class Kata
{
  public const string LETTERS = "abcdefghijklmnopqrstuvwxyz";
  
  public const int DISPLACEMENT = 13;
  
  public static string Rot13(string message)
  {
    string result = "";
    for(int i = 0;i < message.Length;i++)
    {
      bool isLower = char.IsLower(message[i]);
      
      int index = LETTERS.IndexOf(char.ToLower(message[i]));
      
      if(index < 0)
      {
        result += message[i];
        continue;
      }
      index += DISPLACEMENT;
      
      if(index >= LETTERS.Length)
        index = index - LETTERS.Length;
      
      if(isLower)
        result += LETTERS[index];
      else
        result += char.ToUpper(LETTERS[index]);
    }
    
    return result;
  }
}
