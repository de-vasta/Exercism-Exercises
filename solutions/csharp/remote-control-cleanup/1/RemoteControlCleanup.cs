public enum SpeedUnits
{
    MetersPerSecond,
    CentimetersPerSecond
}

public class RemoteControlCar
{
    private Speed _currentSpeed;

    public string? CurrentSponsor { get; private set; }
    public Speed CurrentSpeed { get => _currentSpeed; private set => _currentSpeed = value; }
    public CarTelemetry Telemetry { get; }

    public RemoteControlCar() => Telemetry = new(this);

    public string GetSpeed() => CurrentSpeed.ToString();

    private void SetSponsor(string sponsorName) => CurrentSponsor = sponsorName;

    public class CarTelemetry
    {
        private RemoteControlCar remoteControlCar;

        public CarTelemetry(RemoteControlCar remoteControlCar)
        {
            this.remoteControlCar = remoteControlCar;
        }

        public void Calibrate() { }
        public bool SelfTest() => true;

        public void ShowSponsor(string sponsorName) => remoteControlCar.SetSponsor(sponsorName);

        public void SetSpeed(decimal amount, string unitsString)
        {
            SpeedUnits speedUnits = SpeedUnits.MetersPerSecond;
            if (unitsString == "cps") speedUnits = SpeedUnits.CentimetersPerSecond;
            remoteControlCar.CurrentSpeed = new Speed(amount, speedUnits);
        }
    }
}
public struct Speed
{
    public decimal Amount { get; }
    public SpeedUnits SpeedUnits { get; }

    public Speed(decimal amount, SpeedUnits speedUnits) => (Amount, SpeedUnits) = (amount, speedUnits);

    public override string ToString()
    {
        string unitsString = "meters per second";
        if (SpeedUnits == SpeedUnits.CentimetersPerSecond) unitsString = "centimeters per second";
        return Amount + " " + unitsString;
    }
}
