using System;
using System.Linq;

namespace Exercism.CSharp.Solutions.RobotSimulatorExercise
{
    public enum Commands
    {
        Advance = 'A',
        TurnLeft = 'L',
        TurnRight = 'R'
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
                case Commands.TurnRight:    Turn(step: 1);          break;
                case Commands.TurnLeft:     Turn(step: -1);         break;
                case Commands.Advance:      Advance(Direction);     break;
            }
        }

        private void Turn(int step)
        {
            var all = Enum.GetValues(typeof(Direction)).Cast<Direction>().ToArray();
            int start = Array.IndexOf(all, Direction);
            int next = start + step;

            if (next < 0)
            {
                next = all.Length - 1;
            }

            if (next >= all.Length)
            {
                next = 0;
            }

            Direction = all[next];
        }

        private void Advance(Direction direction)
        {
            switch (direction)
            {
                case Direction.North:   Y++; break;
                case Direction.East:    X++; break;
                case Direction.South:   Y--; break;
                case Direction.West:    X--; break;
            }
        }
    }
}