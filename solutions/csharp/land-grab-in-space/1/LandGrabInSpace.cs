using System;
using System.Collections.Generic;
using System.Linq;

public struct Coord : IEquatable<Coord>, IComparable<Coord>, IComparable
{
    public Coord(ushort x, ushort y)
    {
        X = x;
        Y = y;
    }

    public ushort X { get; }
    public ushort Y { get; }

    public bool Equals(Coord other) => X == other.X && Y == other.Y;

    public override bool Equals(object? obj) => (obj is Coord other) && Equals(other);

    public override int GetHashCode() => HashCode.Combine(X, Y);

    public static bool operator ==(Coord left, Coord right) => left.Equals(right);
    public static bool operator !=(Coord left, Coord right) => !left.Equals(right);

    public static bool operator <(Coord left, Coord right) => left.CompareTo(right) == -1;
    public static bool operator >(Coord left, Coord right) => left.CompareTo(right) == 1;

    public int CompareTo(Coord other) => (X + Y).CompareTo(other.X + other.Y);

    public int CompareTo(object? obj)
    {
        if (ReferenceEquals(null, obj)) return 1;
        return obj is Coord other
            ? CompareTo(other)
            : throw new ArgumentException($"Object must be of type {nameof(Coord)}");
    }
}

public struct Plot : IEquatable<Plot>
{
    public Coord[] CoordOf4 { get; }

    public Plot(Coord coord1, Coord coord2, Coord coord3, Coord coord4)
    {
        CoordOf4 = new[] { coord1, coord2, coord3, coord4 };
    }

    public bool Equals(Plot other) => CoordOf4.SequenceEqual(other.CoordOf4);

    public override bool Equals(object? obj) => (obj is Plot other) && Equals(other);

    public override int GetHashCode() => CoordOf4.GetHashCode();

    public static bool operator ==(Plot left, Plot right) => left.Equals(right);
    public static bool operator !=(Plot left, Plot right) => !left.Equals(right);
}

public class ClaimsHandler
{
    public List<Plot> PlotList { get; } = new();

    public void StakeClaim(Plot plot) => PlotList.Add(plot);

    public bool IsClaimStaked(Plot plot) => PlotList.Contains(plot);

    public bool IsLastClaim(Plot plot) => PlotList[^1] == plot;

    public Plot GetClaimWithLongestSide() => PlotList.MaxBy(x => x.CoordOf4.Max());
}