    static class AssemblyLine
{
    public static double SuccessRate(int speed) => speed == 0 ? 0 : speed <= 4 ? 1 : speed <= 8 ? 0.9 : speed == 9 ? 0.8 : 0.77;   //! Don't do this! It's a bad practice!
    public static double ProductionRatePerHour(int speed) => 221 * speed * SuccessRate(speed);
    public static int WorkingItemsPerMinute(int speed) => (int)ProductionRatePerHour(speed) / 60;
}
