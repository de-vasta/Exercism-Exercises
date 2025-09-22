using System;

public enum Direction { North, East, South, West }

public class RobotSimulator
{
    public RobotSimulator(Direction direction, int x, int y) => (this.Direction, X, Y) = (direction, x, y);
    public Direction Direction { get; private set; }
    public int X { get; private set; }
    public int Y { get; private set; }
    public void Move(string instructions)
    {
        foreach (var item in instructions)
        {
            switch (item)
            {
                case 'L': TurnLeft(); break;
                case 'R': TurnRight(); break;
                default: GoAhead(); break;
            }
        }


        void TurnRight() => this.Direction = this.Direction switch
        {
            Direction.North => Direction.East,
            Direction.South => Direction.West,
            Direction.West => Direction.North,
            Direction.East => Direction.South,
            _ => throw new ArgumentOutOfRangeException()
        };
        void TurnLeft() => this.Direction = this.Direction switch
        {
            Direction.North => Direction.West,
            Direction.South => Direction.East,
            Direction.West => Direction.South,
            Direction.East => Direction.North,
            _ => throw new ArgumentOutOfRangeException()
        };
        void GoAhead()
        {
            switch (this.Direction)
            {
                case Direction.North: Y++; break;
                case Direction.South: Y--; break;
                case Direction.West: X--; break;
                case Direction.East: X++; break;
                default: throw new ArgumentOutOfRangeException();
            }
        }
    }
}