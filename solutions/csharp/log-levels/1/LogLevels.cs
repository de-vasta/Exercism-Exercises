using System;

static class LogLine
{
    public static string Message(string logLine) => 
        logLine.Substring(logLine.IndexOf(' ')).Trim();

    public static string LogLevel(string logLine)
    {
        int from = logLine.IndexOf('[') + 1, to = logLine.IndexOf(']');
        return logLine[from..to].ToLower();
    }

     public static string Reformat(string logLine) => 
         $"{Message(logLine)} ({LogLevel(logLine)})";
}
