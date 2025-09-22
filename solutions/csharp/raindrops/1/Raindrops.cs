using System;

public static class Raindrops
{
    public static string Convert(int number)
    {
        bool hasFactor3 = number % 3 == 0;
        bool hasFactor5 = number % 5 == 0;
        bool hasFactor7 = number % 7 == 0;

        if (hasFactor3 || hasFactor5 || hasFactor7)
        {
            string result = string.Empty;
            if (hasFactor3) { result += "Pling"; }
            if (hasFactor5) { result += "Plang"; }
            if (hasFactor7) { result += "Plong"; }
            return result;
        }
        else { return number.ToString(); }
    }
}