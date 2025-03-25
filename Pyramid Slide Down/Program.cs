using System;

public class PyramidSlideDown
{
    public static int LongestSlideDown(int[][] pyramid)
    {        
        for(int i = pyramid.Length-1; i > 0; i--)
        {
            for(int j = 0; j < pyramid[i-1].Length;j++)
            {
                pyramid[i-1][j] += Math.Max(pyramid[i][j],pyramid[i][j+1]);
            }
        }
      
        return pyramid[0][0];
    }
}