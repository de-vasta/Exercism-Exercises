using System.Collections.Generic;

public class Authenticator
{
    public Identity Admin { get; }

    public IDictionary<string, Identity> GetDevelopers() => developers;

    public Authenticator(Identity admin)
    {
        Admin = admin;
    }

    private IDictionary<string, Identity> developers = new Dictionary<string, Identity>
    {
        ["Bertrand"] = new()
        {
            Email = "bert@ex.ism",
            EyeColor = "blue"
        },

        ["Anders"] = new()
        {
            Email = "anders@ex.ism",
            EyeColor = "brown"
        }
    };

    private record EyeColor
    {
        const string Blue = "blue";
        const string Green = "green";
        const string Brown = "brown";
        const string Hazel = "hazel";
        const string Brey = "grey";
    }
}

public struct Identity
{
    public string Email { get; set; }

    public string EyeColor { get; set; }
}