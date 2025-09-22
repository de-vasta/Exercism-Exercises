class Lasagna
{
    public int ExpectedMinutesInOven() => 40;

    public int RemainingMinutesInOven(int minPassed) => ExpectedMinutesInOven() - minPassed;
    
    public int PreparationTimeInMinutes(int layers) => layers * 2;

    public int ElapsedTimeInMinutes(int layers, int passedTime) => PreparationTimeInMinutes(layers) + passedTime;
}