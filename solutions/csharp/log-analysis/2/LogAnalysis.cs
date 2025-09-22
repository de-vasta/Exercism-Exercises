public static class LogAnalysis 
{
    public static string SubstringAfter(this string s, string startAfter) => s.Substring(s.IndexOf(startAfter) + startAfter.Length);
        public static string Message(this string s) => s.Substring(s.IndexOf(": ") + 2);

public static string SubstringBetween(this string s, string startAfter, string endBefore) => s.Substring(s.IndexOf(startAfter) + startAfter.Length, s.IndexOf(endBefore) - endBefore.Length - startAfter.Length + 1);
        public static string LogLevel(this string s) => s.Substring(s.IndexOf('[') + 1, s.IndexOf(']') - 1);
}