
namespace Chat.domain.Models
{
    public class ChatChannel
    {
        public int Id { get; set; }
        public string ChannelName { get; set; }
        public int CreatorUserId { get; set; }
    }
}
