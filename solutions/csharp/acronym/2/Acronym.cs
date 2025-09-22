using System;
using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase) => new string(phrase.Split(new char[] { ' ', '-', '_' }, StringSplitOptions.RemoveEmptyEntries).Select(word => word[0]).ToArray()).ToUpper();
}