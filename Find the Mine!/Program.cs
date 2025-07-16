using System;

public class Kata
{
  public static Tuple<int, int> MineLocation(int[,] field)
  {
    for(int i = 0; i <= field.GetUpperBound(0); i++)
    {
      for(int j = 0;j <= field.GetUpperBound(1);j++)
      {
        if(field[i,j]==1)
          return new Tuple<int,int>(i,j);
      }
    }
    return new Tuple<int,int>(0,0); 
  }
}