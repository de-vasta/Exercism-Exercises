using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        string lettersGot = string.Empty;
        foreach (var item in word.ToLower())
        {
            if (char.IsLetter(item))
            {
                if (lettersGot.Contains(item)) { return false; }
                else { lettersGot += item; }
            }
        }
        return true;
    }
}
