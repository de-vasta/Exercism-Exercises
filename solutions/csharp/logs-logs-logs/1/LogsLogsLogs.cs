using System;

enum LogLevel { Unknown = 0, Trace = 1, Debug = 2, Info = 4, Warning = 5, Error = 6, Fatal = 42 }

static class LogLine
{
    public static LogLevel ParseLogLevel(string logLine) => logLine[(logLine.IndexOf('[') + 1)..logLine.IndexOf(']')] switch
    {
        "TRC" => LogLevel.Trace,
        "DBG" => LogLevel.Debug,
        "INF" => LogLevel.Info,
        "ERR" => LogLevel.Error,
        "FTL" => LogLevel.Fatal,
        "WRN" => LogLevel.Warning,
        _ => LogLevel.Unknown
    };

    public static string OutputForShortLog(LogLevel logLevel, string message) => $"{(byte)logLevel}:{message}";
}
