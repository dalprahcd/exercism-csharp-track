using System;
using System.Linq;

public enum Commands
{ 
    TurnRight = 'R',
    TurnLeft = 'L',
    Advance = 'A'
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
        foreach (var cmd in instructions.ToCharArray())
        {
            ExecuteCommand((Commands)cmd);
        }
    }

    private void ExecuteCommand(Commands cmd)
    {
        switch (cmd)
        {
            case Commands.TurnRight:    Turn(step: 1);      break;
            case Commands.TurnLeft:     Turn(step: -1);     break;
            case Commands.Advance:      Advance(Direction); break;
        };
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

        Direction =  all[next];
    }

    private void Advance(Direction direction)
    {
        switch (direction)
        {
            case Direction.North:   Y += 1; break;
            case Direction.East:    X += 1; break;
            case Direction.South:   Y -= 1; break;
            case Direction.West:    X -= 1; break;
        };
    }
}