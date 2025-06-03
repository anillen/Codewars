using System;

namespace Solution
{
  class Solution
  {
    public static int[,] MultiplicationTable(int size)
    {
      var result = new int[size,size];

      for(int i = 0;i < size; i++)
        for(int j = 0; j < size; j++)
          result[i,j] = (i+1)*(j+1);

      return result;
    }
  }
}