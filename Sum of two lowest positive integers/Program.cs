using System.Linq;

public static class Kata
{
	public static int sumTwoSmallestNumbers(int[] numbers)
	{
		var array = numbers.OrderBy(x=>x).ToArray();
    
    return array[0]+array[1];
	}
}