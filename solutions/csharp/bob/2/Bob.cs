using System.Linq;

public static class Bob
    {
        public static string Response(string statement) => statement.TrimEnd() switch
        {
            string s when s.EndsWith('?') && s.All(c => !char.IsLower(c)) && s.Any(c => char.IsLetter(c)) => "Calm down, I know what I'm doing!",
            string s when s.EndsWith('?') => "Sure.",
            string s when s.All(c => !char.IsLower(c)) && s.Any(c => char.IsLetter(c)) => "Whoa, chill out!",
            "" => "Fine. Be that way!",
            _ => "Whatever."
        };
    }