using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder idEdited = new(identifier);
        idEdited.Replace(' ', '_').Replace("😀", "");
        for (var i = 0; i < idEdited.Length; i++)
        {
            switch (idEdited[i])
            {
                case '-':
                    idEdited.Remove(i, 1);
                    idEdited[i] = char.ToUpper(idEdited[i]); i--; break;
                case char c when c >= '\u03b1' && c <= 'ω' || char.IsDigit(c):
                    idEdited.Remove(i, 1); i--; break;
                case char c when char.IsControl(c):
                    idEdited.Remove(i, 1);
                    idEdited.Insert(i, "CTRL"); break;
            }
        }
        return idEdited.ToString();
    }
}