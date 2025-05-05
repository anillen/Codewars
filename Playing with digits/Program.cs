using System;

public class DigPow {
    public static long digPow(int n, int p) {
        long summ = 0;
    
        foreach(var symbol in n.ToString())
        {
            summ += (long)Math.Pow(int.Parse(symbol.ToString()),p);
            p++;
        }
        if(summ%n!=0)
            return -1;
    
        if(summ/n==0)
            return -1;
    
        return (long)summ/n;
    }
}