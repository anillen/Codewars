public class Kata
{
    const string LETTERS = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
    public static char FindMissingLetter(char[] array)
    {    
        if(array.Length <= 0)
            return ' ';
    
        int index = LETTERS.IndexOf(array[0]);      
    
        foreach(var letter in array)
        {
            if(LETTERS[index] != letter)
                return LETTERS[index];
            index++;
        }
  
        return ' ';
    }
}