using System;
public class PerfectPower
{
    public static (int, int)? IsPerfectPower(int n)
    {
        int sqrt = Convert.ToInt32(Math.Sqrt(n));
        for(; sqrt >= 2; sqrt--)
        {
            int deg = Convert.ToInt32(Math.Log(n,sqrt));
        
            if(Math.Pow(sqrt,deg)==n)
                return new (sqrt,deg);
        }
        return null;
    }
}