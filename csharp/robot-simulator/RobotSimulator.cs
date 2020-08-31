namespace Exercism.CSharp.Solutions.RobotSimulatorExercise
{
    public enum Commands
    {
        Advance = 'A',
        Left    = 'L',
        Right   = 'R'
    }

    public enum Direction
    {
        North,
        East,
        South,
        West
    }

    public class RobotSimulator
    {
        public RobotSimulator(Direction direction, int x, int y)
        {
            Direction = direction;
            X = x;
            Y = y;
        }

        public Direction Direction { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }

        public void Move(string instructions)
        {
            foreach (var cmd in instructions)
            {
                ExecuteCommand((Commands)cmd);
            }
        }

        private void ExecuteCommand(Commands cmd)
        {
            switch (cmd)
            {
                case Commands.Right:    TurnRight();    break;
                case Commands.Left:     TurnLeft();     break;
                case Commands.Advance:  Advance();      break;
            }
        }

        private void TurnRight()
        {
            switch (Direction)
            {
                case Direction.North:   Direction = Direction.East;     break;
                case Direction.East:    Direction = Direction.South;    break;
                case Direction.South:   Direction = Direction.West;     break;
                case Direction.West:    Direction = Direction.North;    break;
            }
        }

        private void TurnLeft()
        {
            switch (Direction)
            {
                case Direction.North:   Direction = Direction.West;     break;
                case Direction.East:    Direction = Direction.North;    break;
                case Direction.South:   Direction = Direction.East;     break;
                case Direction.West:    Direction = Direction.South;    break;
            }
        }

        private void Advance()
        {
            switch (Direction)
            {
                case Direction.North:   Y++; break;
                case Direction.East:    X++; break;
                case Direction.South:   Y--; break;
                case Direction.West:    X--; break;
            }
        }
    }
}