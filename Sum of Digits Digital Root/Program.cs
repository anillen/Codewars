public class Number
{
    public static int DigitalRoot(long n)
    {
        int result = GetSumm(n.ToString());
    
        while(result>=10)
            result = GetSumm(result.ToString());
    
        return result;
    }
  
    public static int GetSumm(string str)
    {
        int result = 0;
    
        foreach(char symbol in str)
            result += int.Parse(symbol.ToString());
    
        return result;
    }
}