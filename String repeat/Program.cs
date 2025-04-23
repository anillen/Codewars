namespace Solution
{
    public static class Program
    {
        public static string RepeatStr(int n, string s)
        {
            string result = "";
            while(n > 0)
            {
                result+=s;
                n--;
            }
            return result;
        }
    }
}