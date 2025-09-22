using System;

static class Badge
{
    public static string Print(int? id, string name, string? department) => String.Concat(id == null ? "" : $"[{id}] - ", $"{name} - {department?.ToUpper() ?? "OWNER"}");
    // {
    //     string idFormat = id == null ? "" : $"[{id}] - ";
    //     return idFormat + $"{name} - {department?.ToUpper() ?? "OWNER"}";
    // }
}