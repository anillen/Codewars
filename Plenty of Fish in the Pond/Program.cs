namespace CodeWars
{
    using System.Linq;
    using System;
  
    public class Game
    {      
        public int fish(string shoal)
        {
            int[] steps = new int[6]
            {
                4,8,12,16,20,24
            };
          
            int total = 0;
            int size = 1;
          
            foreach(var item in shoal.OrderBy(s=>s))
            {
                int score = int.Parse(item.ToString());
            
                if(score <= size)
                    total += score;
                else break;
            
                if(size > steps.Length && total > steps[^1])
                {
                    size++;
                    total = 0;
                }
                if(size <= steps.Length && total >= steps[size-1])
                {
                    size++;
                    total = 0;
                }
            }
            return size;
        }
    }
}