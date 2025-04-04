using System.Linq;

namespace Solution
{
    class Kata
    {
        public static int find_it(int[] seq) 
        {
            return seq.GroupBy(x=>x).Where(x=>(x.Count() % 2 != 0)).First().Key;
        }
    }
}