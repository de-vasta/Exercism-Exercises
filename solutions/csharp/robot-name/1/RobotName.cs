using System;
using  System.Collections.Generic;

public class Robot
{
    public static HashSet<string> ReservedNames { get; } = new();

    private string name = "Err001";
    public string Name { get => name; }
    private void SetRandName()
    {
        string result;      // if the result of randoms 🔀 operations does satisfy the condition below ⬇
        Random randLetter = new(), randDigit = new();
        do
        {
            var twoLetters = new string(new char[] { (char)randLetter.Next('A', 'Z' + 1), (char)randLetter.Next('A', 'Z' + 1) });  // concatenate 2 random letters; Random name part 1 done!
            var threeDigits = string.Concat(randDigit.Next(0, 10), randDigit.Next(0, 10), randDigit.Next(0, 10));   // concatenate 3 random digits; Random name part 2 done!
            result = twoLetters + threeDigits;
        } while (ReservedNames.Count > 0 && ReservedNames.Contains(result));  // check, if `ReservedNames` has anything and check the name on unique
        name = result;
        ReservedNames.Add(name);
    }

    public Robot() => SetRandName();

    public void Reset()
    {
        ReservedNames.Remove(this.Name);
        SetRandName();
    }
}