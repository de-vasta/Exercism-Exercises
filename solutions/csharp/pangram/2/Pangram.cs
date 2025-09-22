using System;
using System.Linq;

public static class Pangram
{
    public static bool IsPangram(string input) => Enumerable.Range('a', 'z' - 'a' + 1).All(letter => input.Contains((char)letter, StringComparison.InvariantCultureIgnoreCase));
}
