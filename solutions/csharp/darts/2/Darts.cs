using System;

public static class Darts
{
    public static int Score(double x, double y)
    {
        double radiusFunction = x * x + y * y;
        if (radiusFunction > 25) { return radiusFunction > 100 ? 0 : 1; }
        else { return radiusFunction > 1 ? 5 : 10; }
    }
}