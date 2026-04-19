using System.Text;
using System.Text.RegularExpressions;
using Xunit.Internal;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder sb = new();
        var isAfterDash = false;
        foreach (char c in identifier)
        {
            sb.Append(c switch
            {
                _ when IsGreekLowerCase(c) => default,
                _ when isAfterDash => char.ToUpperInvariant(c),
                _ when char.IsWhiteSpace(c) => '_',
                _ when char.IsControl(c) => "CTRL",
                _ when char.IsLetter(c) => c,
                _ => default,
            });
            isAfterDash = c.Equals('-');
        }
        return sb.ToString();
    }
    private static bool IsGreekLowerCase(char c) => c is >= 'α' and <= 'ω';
}
