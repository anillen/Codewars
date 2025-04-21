using System.Linq;

public static class Kata
{
    public static int SquareSum(int[] numbers)
    { 
        return (int)numbers.Select(n=>n*n).Sum();
    }
}