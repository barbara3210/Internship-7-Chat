using Chat.data.Entities.Models;
using System.Text.RegularExpressions;
using Chat.domain.Models;
using User = Chat.domain.Models.User;
using ChatChannel = Chat.domain.Models.ChatChannel;

namespace Chat.presentation.Helpers
{
    public class Input
    {
        public bool IsValidEmail(string email)
        {
            var emailRegex = new Regex(@"^[^\s@]+@[^\s@]+\.[^\s@]+$");
            return emailRegex.IsMatch(email);
        }
        public static void Error(string message)
        {
            Console.WriteLine(message);
            Thread.Sleep(1000);
            Console.Clear();
        }

        public static void Write(User user)
        => Console.WriteLine($"{user.Id}: {user.FirstName} {user.LastName}");

        public static void Write(ICollection<User> users)
        {
            foreach (var user in users)
                Write(user);
        }
        public static void Write(ChatChannel chat)
        {
            Console.WriteLine($"{chat.Id}: {chat.ChannelName}");
        }
        public static void Write(ICollection<ChatChannel> chats)
        {
            foreach (var chat in chats)
                Write(chat);
        }
        

    }
}
