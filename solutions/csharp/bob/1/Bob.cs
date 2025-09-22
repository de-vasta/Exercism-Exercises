using System.Linq;

public static class Bob
    {
        public static string Response(string statement)
        {
            bool isAsk = statement.TrimEnd().EndsWith('?'),
            isYell = statement.All(c => !char.IsLower(c)) && statement.Any(c => char.IsLetter(c)),
            isQuiet = string.IsNullOrWhiteSpace(statement);

            if (isYell && isAsk) return "Calm down, I know what I'm doing!";
            else if (isAsk) return "Sure.";
            else if (isYell) return "Whoa, chill out!";
            else if (isQuiet) return "Fine. Be that way!";
            else return "Whatever.";
        }
    }