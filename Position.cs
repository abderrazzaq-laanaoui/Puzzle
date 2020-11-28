using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle
{
    class Position
    {
        public int Col { get; set; }
        public int Row { get; set; }

        public Position(int row, int col)
        {
            Row = row;
            Col = col;
        }

        public static Position operator +(Position p1, Position p2)
            => new Position(p1.Row + p2.Row, p1.Col + p2.Col);


    }
}
