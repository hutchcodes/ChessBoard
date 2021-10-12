using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    public class Square
    {
        public Square(Color color) 
        {
            this.Color = color;
        }
        public Square(Piece piece)
        {
            this.Piece = piece;
        }
        public Piece? Piece { get; set; }
        public Color Color { get; private set; }
    }
}
