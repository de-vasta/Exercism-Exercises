using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word)=> word.ToLower().Where(c=>char.IsLetter(c)).Distinct().Count() == word.Where(c => char.IsLetter(c)).Count();
}
