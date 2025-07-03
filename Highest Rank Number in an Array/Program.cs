using System.Linq;

public class Kata
{
  public static int HighestRank(int[] arr)
  {
    var item = arr.GroupBy(x=>x).OrderByDescending(x=>x.Key).MaxBy(x=>x.Count());
    return item.Key;
  }
}