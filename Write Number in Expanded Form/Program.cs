using System;

public static class Kata 
{
    public static string ExpandedForm(long num) 
    {
        var result = "";
        var stringNumber = num.ToString();
        for(int i = 0;i<stringNumber.Length;i++)
        {
            if(stringNumber[i] == '0')
                continue;
        
            result+=stringNumber[i];
            result+=new string('0',(stringNumber.Length-1) - i);
            result+=" + ";
        }
        return result.TrimEnd(' ','+');
    }
}