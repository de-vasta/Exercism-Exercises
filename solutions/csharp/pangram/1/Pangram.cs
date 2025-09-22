using System;
using System.Linq;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        var latins = Enumerable.Range('a', 'z' - 'a' + 1);
        foreach (var latin in latins)
        {
            if (!input.Contains((char)latin, StringComparison.InvariantCultureIgnoreCase)) return false;
        }
        return true;
    }
}
