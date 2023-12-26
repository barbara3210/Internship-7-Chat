using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.domain.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        public int ChannelId { get; set; }
        public int SenderUserId { get; set; }
        public int RecipientUserId { get; set; }
        public string MessageContent { get; set; }
        public DateTime Time { get; set; }

    }
}
