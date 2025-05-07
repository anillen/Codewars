using System.Linq;
public class Kata
{
    public static int[] SortArray(int[] array)
    {
        var result = new int[array.Length];
        var odds = array.Where(a=>a%2!=0).OrderBy(a=>a).ToArray();
    
        for(int i = 0,j=0;i<array.Length;i++)
        {
            if(array[i]%2!=0)
            {
                result[i]=odds[j];
                j++;
            }
            else
                result[i]=array[i];
        }
        return result;
    }
}