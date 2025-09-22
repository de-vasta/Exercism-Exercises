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
                >= 'a' and <= 'z' => item + shiftKey <= 'z' ? (char)(item + shiftKey) : (char)('a' - 1 + (item + shiftKey) % ('z')),
                >= 'A' and <= 'Z' => item + shiftKey <= 'Z' ? (char)(item + shiftKey) : (char)('A' - 1 + (item + shiftKey) % ('Z')),
                _ => item
            };
        }
        return rotated;
    }
}