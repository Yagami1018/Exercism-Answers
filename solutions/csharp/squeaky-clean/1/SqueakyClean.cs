using System.Text;
using System.Text.RegularExpressions;
using Xunit.Internal;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder sb = new();
        char[] chars = Regex.Replace(identifier,@"[\u03B1-\u03C9]","").ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            if (Char.IsWhiteSpace(chars[i]))
            {
                sb.Append('_');
            }
            if (Char.IsControl(chars[i]))
            {
                sb.Append("CTRL");
            }
            if (chars[i] is '-')
            {
                sb.Append($"{chars[i + 1]}".ToUpper());
            }
            if (!Char.IsLetter(chars[i]))
            {
                continue;
            }
            if (i > 0 && chars[i - 1] is '-')
            {
                continue;
            }
            else
            {
                sb.Append(chars[i]);
            }
        }
        return sb.ToString();
    }
}
