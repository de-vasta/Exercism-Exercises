using System;

public enum Direction { North, East, South, West }

public class RobotSimulator
{
    public RobotSimulator(Direction direction, int x, int y) { (this.Direction, X, Y) = (direction, x, y); }

    public Direction Direction { get; private set; }

    public int X { get; private set; }

    public int Y { get; private set; }

    public void Move(string instructions)
    {
        foreach (var item in instructions)
        {
            switch (this.Direction)
            {
                case Direction.North:
                    switch (item)
                    {
                        case 'L': this.Direction = Direction.West; break;
                        case 'R': this.Direction = Direction.East; break;
                        default: Y++; break;
                    }
                    break;

                case Direction.South:
                    switch (item)
                    {
                        case 'L': this.Direction = Direction.East; break;
                        case 'R': this.Direction = Direction.West; break;
                        default: Y--; break;
                    }
                    break;

                case Direction.West:
                    switch (item)
                    {
                        case 'L': this.Direction = Direction.South; break;
                        case 'R': this.Direction = Direction.North; break;
                        default: X--; break;
                    }
                    break;

                case Direction.East:
                    switch (item)
                    {
                        case 'L': this.Direction = Direction.North; break;
                        case 'R': this.Direction = Direction.South; break;
                        default: X++; break;
                    }
                    break;
            }
        }
    }
}