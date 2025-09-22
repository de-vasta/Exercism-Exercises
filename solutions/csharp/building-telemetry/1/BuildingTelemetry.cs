using System.Collections.Generic;

public class RemoteControlCar
{
    public int BatteryPercentage { get; private set; } = 100;
    public int DistanceDrivenInMeters { get; private set; } = 0;
    private List<string> sponsors = new();
    private int latestSerialNum = 0;

    public void Drive()
    {
        if (BatteryPercentage > 0)
        {
            BatteryPercentage -= 10;
            DistanceDrivenInMeters += 2;
        }
    }

    public void SetSponsors(params string[] sponsors) => this.sponsors.AddRange(sponsors);

    public string DisplaySponsor(int sponsorNum) => this.sponsors[sponsorNum];

    public bool GetTelemetryData(ref int serialNum, out int batteryPercentage, out int distanceDrivenInMeters)
    {
        if (latestSerialNum > serialNum)
        {
            serialNum = latestSerialNum;
            batteryPercentage = -1;
            distanceDrivenInMeters = -1;
            return false;
        }
        else
        {
            latestSerialNum = serialNum;
            batteryPercentage = this.BatteryPercentage;
            distanceDrivenInMeters = this.DistanceDrivenInMeters;
            return true;
        }
    }
    public static RemoteControlCar Buy() => new RemoteControlCar();
}
public class TelemetryClient
{
    private RemoteControlCar car;

    public TelemetryClient(RemoteControlCar car)
    {
        this.car = car;
    }

    public string GetBatteryUsagePerMeter(int serialNum) => car.BatteryPercentage == 100 ? "no data" : $"usage-per-meter=5";
}