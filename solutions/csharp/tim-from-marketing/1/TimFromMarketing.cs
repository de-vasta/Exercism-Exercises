using System;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string idFormat = id == null ? "" : $"[{id}] - ";
        return idFormat + $"{name} - {department?.ToUpper() ?? "OWNER"}";
    }
}