public static class LogAnalysis 
{
    public static string SubstringAfter(this string s, string startAfter) => s[(s.IndexOf(startAfter) + startAfter.Length)..];
    public static string Message(this string s) => s[(s.IndexOf(": ") + 2)..];

    public static string SubstringBetween(this string s, string startAfter, string endBefore) => s[(s.IndexOf(startAfter) + startAfter.Length)..s.IndexOf(endBefore)];

    public static string LogLevel(this string s) => s[(s.IndexOf('[') + 1)..s.IndexOf(']')];
}