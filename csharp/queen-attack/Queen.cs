using System;

namespace Exercism.CSharp.Solutions.QueenAttackExercise
{
    public class Queen
    {
        public Queen(int row, int column)
        {
            if (row < 0 || row > 7)
            {
                throw new ArgumentOutOfRangeException(nameof(row));
            }

            if (column < 0 || column > 7)
            {
                throw new ArgumentOutOfRangeException(nameof(column));
            }

            Row = row;
            Column = column;
        }

        public int Row { get; }
        public int Column { get; }
    }
}