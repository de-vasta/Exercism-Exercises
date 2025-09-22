using System;

class RemoteControlCar
    {
        public int MetersDriven { get; set; }
        public int BatteryLevel { get; set; } = 100;

        public static RemoteControlCar Buy() => new RemoteControlCar();

        public string DistanceDisplay() => $"Driven {MetersDriven} meters";

        public string BatteryDisplay() => BatteryLevel == 0 ? "Battery empty" : $"Battery at {BatteryLevel}%";

        public void Drive()
        {
            if (BatteryLevel > 0)
            {
                MetersDriven += 20;
                BatteryLevel--;
            }
        }
    }
