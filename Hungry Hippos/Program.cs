namespace CodeWars
{
    public class Game
    {
        private int[,] board;
        
        public Game(int[,] board)
        {
            this.board = board;
        }

        public int play()
        {
            int count = 0;
          
            for(int x = 0;x < board.GetLength(0);x++)
                for(int y = 0;y < board.GetLength(1);y++)
                    if(check(x,y))
                        count++;
          
            return count;
        }
      
        private bool check(int x, int y)
        {
            if(x < 0 || x >= board.GetLength(0))
                return false;
            if(y < 0 || y >= board.GetLength(1))
                return false;
          
            if(board[x,y] == 0)
                return false;
          
            board[x,y] = 0;
          
            check(x,y-1);
            check(x,y+1);
            check(x-1,y);
            check(x+1,y);
            return true;
        }

    }
}