using System;
using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        var a = phrase.Split(new char[] { ' ', '-', '_' }, StringSplitOptions.RemoveEmptyEntries);
        var b = a.Select(word => word[0]).ToArray();
        var c = new string(b).ToUpper();
        return c;
    }
}