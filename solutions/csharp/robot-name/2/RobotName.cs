using System;
using  System.Collections.Generic;

//*thanks to @aage (a mentor who helped me to find some ➖ of my code)
public class Robot
{
    public static HashSet<string> ReservedNames { get; } = new();

    private string name;
    public string Name { get => name; }
    private void SetRandName()
    {
        string result;      // if the result of randoms 🔀 operations does satisfy the condition below ⬇
        Random random = new();
        do
        {
            var twoLetters = new string(new char[] { RandomChar(), RandomChar() });  // concatenate 2 random letters; Random name part 1 done!
            var threeDigits = string.Concat(RandomInt(), RandomInt(), RandomInt());   // concatenate 3 random digits; Random name part 2 done!
            result = twoLetters + threeDigits;
        } while (ReservedNames.Count > 0 && ReservedNames.Contains(result));  // check, if `ReservedNames` has anything and check the name on unique
        name = result;
        ReservedNames.Add(name);


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