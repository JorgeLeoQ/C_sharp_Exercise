using System.Text;
using System.Text.RegularExpressions;

namespace Exercise9
{
    public class EmailExtract
    {
        public static string ExtractEmails(string input)
        {
            string pattern = (@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w{2,}([-.]\w{2,})*");

            MatchCollection matches = Regex.Matches(input, pattern, RegexOptions.IgnoreCase);

            StringBuilder emails = new StringBuilder();

            foreach (var match in matches)
            {
                emails.Append(match.ToString()).AppendLine();
            }

            return emails.ToString();
        }
    }
}
