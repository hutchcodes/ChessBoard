namespace ChessBoard
{
    public class Board
    {
        public Board()
        {
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    Color color;
                    if ((x+y) % 2 == 0)
                    {
                        color = Color.Black;
                    }
                    else
                    { 
                        color = Color.White; 
                    }
                    Squares[x,y] = new Square(color);
                }
            }
        }

        public Square[,] Squares = new Square[8,8];

    }
}