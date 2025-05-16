using System.Text;

public class Kata
{
    public static string BreakCamelCase(string str)
    {
        var result = new StringBuilder();
        foreach(var item in str)
        {
            if(char.IsUpper(item))
                result.Append(" ");
            result.Append(item);
        } 
        return result.ToString();
    }
}