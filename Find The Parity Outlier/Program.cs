using System.Linq;

public class Kata
{
    public static int Find(int[] integers)
    {
        if(integers.Count(x=>x%2==0) > 1)
            return integers.Single(x=>x%2!=0);
        else
            return integers.Single(x=>x%2==0);
    }
}