public class SplitString
{
  public static string[] Solution(string str)
  {    
    int length = str.Length % 2 == 0 ? str.Length/2 : str.Length/2 + 1;
    string[] result = new string[length];
    
    for(int i =0, j = 0;i < str.Length; i+=2, j++)
    {
      result[j] += str[i];
      
      result[j]+= i+1 < str.Length? str[i+1]:"_";
    }
    return result;
  }
}