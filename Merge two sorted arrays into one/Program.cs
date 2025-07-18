using System;
using System.Linq;

public class Kata
{
  public static int[] MergeArrays(int[] arr1, int[] arr2) => arr1.Union(arr2).OrderBy(x=>x).ToArray();
}