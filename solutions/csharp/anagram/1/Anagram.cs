using System;
using System.Linq;

public class Anagram
{
    string baseWord;
    public Anagram(string baseWord) { this.baseWord = baseWord; }

    public string[] FindAnagrams(string[] potentialMatches) => potentialMatches.Where(word => word.ToLower() != baseWord.ToLower() && string.Equals(string.Concat(word.ToLower().OrderBy(c => c)), string.Concat(baseWord.ToLower().OrderBy(c => c)), StringComparison.OrdinalIgnoreCase)).ToArray<string>();
}