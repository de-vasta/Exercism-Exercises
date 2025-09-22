using System;

public static class Darts
{
    public static int Score(double x, double y)
    {
        double radiusFunction = x * x + y * y;
        if (radiusFunction > 25)
        {
            if (radiusFunction > 100) { return 0; }
            else { return 1; }
        }
        else
        {
            if (radiusFunction > 1) { return 5; }
            else { return 10; }
        }
    }
}
