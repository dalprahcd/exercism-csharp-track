namespace Exercism.CSharp.Solutions.SpiralMatrixExercise
{
    public static class SpiralMatrix
    {
        private enum Direction
        {
            Left = 0,
            Bottom,
            Right,
            Top
        }

        public static int[,] GetMatrix(int size)
        {
            var output = new int [size, size];
            int x = 0, y = 0;
            var direction = Direction.Left;

            for (int i = 0; i < size * size; i++)
            {
                output[x, y] = i + 1;
                switch (direction)
                {
                    case Direction.Left:
                        if (y + 1 == size || output[x, y + 1] != 0)
                        {
                            x++;
                            direction = Direction.Bottom;
                            break;
                        }
                        y++;
                        break;

                    case Direction.Bottom:
                        if (x + 1 == size || output[x + 1, y] != 0)
                        {
                            y--;
                            direction = Direction.Right;
                            break;
                        }
                        x++;
                        break;

                    case Direction.Right:
                        if (y - 1 < 0 || output[x, y - 1] != 0)
                        {
                            x--;
                            direction = Direction.Top;
                            break;
                        }
                        y--;
                        break;

                    case Direction.Top:
                        if (x -1 < 0 || output[x - 1, y] != 0)
                        {
                            y++;
                            direction = Direction.Left;
                            break;
                        }
                        x--;
                        break;
                }
            }

            return output;
        }
    }
}