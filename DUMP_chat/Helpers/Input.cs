using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Chat.presentation.Helpers
{
    public class Input
    {
        public bool IsValidEmail(string email)
        {
            var emailRegex = new Regex(@"^[^\s@]+@[^\s@]+\.[^\s@]+$");
            return emailRegex.IsMatch(email);
        }

    }
}
