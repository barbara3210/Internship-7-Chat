using Chat.data.Entities.Models;

namespace Chat.domain.Models
{
    public class Message
    {
        public int Id { get; set; }
        public int ChannelId { get; set; }
        public int SenderUserId { get; set; }
        public int RecipientUserId { get; set; }
        public string MessageContent { get; set; }
        public DateTime Time { get; set; }

    }
}
