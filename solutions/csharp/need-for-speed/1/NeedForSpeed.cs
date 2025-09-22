class RemoteControlCar
{
    int battery = 100;

    public int Speed { get; }
    public int Distance { get; private set; }
    public int BatteryDrain { get; }
    public int Battery { get => battery; private set => battery = value; }

    public RemoteControlCar(int speed, int batteryDrain)
    {
        Speed = speed;
        BatteryDrain = batteryDrain;
    }
    public bool BatteryDrained() => Battery < BatteryDrain;

    public int DistanceDriven() => Distance;

    public void Drive()
    {
        if (!BatteryDrained())
        {
            Distance += Speed; Battery -= BatteryDrain;
        }
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}

class RaceTrack
{
    public int Distance { get; }
    public RaceTrack(int distance)
    {
        Distance = distance;
    }

    public bool CarCanFinish(RemoteControlCar car) => car.Battery / car.BatteryDrain * car.Speed >= this.Distance;
}