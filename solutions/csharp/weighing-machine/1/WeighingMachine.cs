using System;
using System.Globalization;

class WeighingMachine
{
    double weight;

    public int Precision { get; }
    public double Weight
    {
        get => weight; set
        {
            if (value >= 0) { weight = value; }
            else { throw new ArgumentOutOfRangeException(); }
        }
    }
    public double TareAdjustment { get; set; } = 5.0;
    public string DisplayWeight => (Weight - TareAdjustment).ToString($"0.{new string('0', Precision)}", CultureInfo.InvariantCulture) + " kg";

    public WeighingMachine(int precision)
    {
        Precision = precision;
    }
}
