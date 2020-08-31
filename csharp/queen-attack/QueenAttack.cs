using System;

namespace Exercism.CSharp.Solutions.QueenAttackExercise
{
    public static class QueenAttack
    {
        public static bool CanAttack(Queen white, Queen black) =>
            white.Row == black.Row ||
            white.Column == black.Column ||
            Math.Abs(white.Row - black.Row) == Math.Abs(white.Column - black.Column);

        public static Queen Create(int row, int column) =>
            new Queen(row, column);
    }
}