using System;

public class Accumul 
{
    public static String Accum(string s) 
    {
        string result = "";
        for(int i = 1; i <= s.Length; i++)
        {
            for(int k = 1; k <= i; k++)
            {
                if(k==1)
                    result+= Char.ToUpper(s[i-1]);
                else
                    result+= Char.ToLower(s[i-1]);
            }
            if(i != s.Length)
                result+="-";
        }
        return result;
    }
}