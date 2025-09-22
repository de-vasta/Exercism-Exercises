using System;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        ArgumentNullException.ThrowIfNull(text);
        string rotated = String.Empty;
        foreach (var item in text)
        {
            rotated += item switch
            {
                > 'a' and < 'z' => (char)((item + shiftKey) % ('a' + 'z')),
                > 'A' and < 'Z' => (char)((item + shiftKey) % ('A' + 'Z')),
                _ => item
            };
        }
        return rotated;
    }
}