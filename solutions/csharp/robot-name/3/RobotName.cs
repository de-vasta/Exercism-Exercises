using System;
using System.Collections.Generic;

//*special thanks to @aage
public class Robot
{
    public static HashSet<string> ReservedNames { get; } = new();
    private string name;
    public string Name { get => name; private set => name = value; }
    private void SetRandName()
    {
        string result;      // if the result of randoms 🔀 operations does satisfy the condition below ⬇
        Random random = new();
        do
        {
            var twoLetters = string.Concat(RandomChar(), RandomChar());  // concatenate 2 random letters; Random name part 1 done!
            var threeDigits = string.Concat(RandomInt(), RandomInt(), RandomInt());   // concatenate 3 random digits; Random name part 2 done!
            result = twoLetters + threeDigits;
        } while (ReservedNames.Contains(result));  // check, if `ReservedNames` has anything and check the name on unique
        Name = result;
        ReservedNames.Add(Name);


        char RandomChar() => (char)random.Next('A', 'Z' + 1);
        int RandomInt() => random.Next(0, 10);
    }
    public Robot() => SetRandName();
    public void Reset()
    {
        ReservedNames.Remove(this.Name);
        SetRandName();
    }
}