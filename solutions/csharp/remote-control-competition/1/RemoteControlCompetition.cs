using System;
using System.Collections.Generic;

public interface IRemoteControlCar
{
    public int DistanceTravelled { get; }

    public void Drive();
}

public class ProductionRemoteControlCar : IRemoteControlCar, IComparable<ProductionRemoteControlCar>
{
    public int DistanceTravelled { get; private set; }
    public int NumberOfVictories { get; set; }

    public void Drive() => DistanceTravelled += 10;

    public int CompareTo(ProductionRemoteControlCar other) => other == null ? 1 : this.NumberOfVictories.CompareTo(other.NumberOfVictories);

    public static bool operator <(ProductionRemoteControlCar left, ProductionRemoteControlCar right) => left.CompareTo(right) < 0;
    public static bool operator <=(ProductionRemoteControlCar left, ProductionRemoteControlCar right) => left.CompareTo(right) <= 0;
    public static bool operator >(ProductionRemoteControlCar left, ProductionRemoteControlCar right) => left.CompareTo(right) > 0;
    public static bool operator >=(ProductionRemoteControlCar left, ProductionRemoteControlCar right) => left.CompareTo(right) >= 0;
}

public class ExperimentalRemoteControlCar : IRemoteControlCar
{
    public int DistanceTravelled { get; private set; }

    public void Drive() => DistanceTravelled += 20;
}

public static class TestTrack
{
    public static void Race(IRemoteControlCar car) => car.Drive();

    public static List<ProductionRemoteControlCar> GetRankedCars(ProductionRemoteControlCar prc1, ProductionRemoteControlCar prc2)
    {
        var rankedCars = new List<ProductionRemoteControlCar>() { prc1, prc2 };
        rankedCars.Sort();
        return rankedCars;
    }
}
