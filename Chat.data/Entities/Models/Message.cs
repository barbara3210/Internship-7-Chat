using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.data.Entities.Models
{
    public class Message
    {
        public Message(int sender, int recipient, string message, DateTime date)
        {
            SenderUserId = sender;
            RecipientUserId = recipient;
            MessageContent = message;
            Time = date;

        }

        public int Id { get; set; }
        public int SenderUserId { get; set; }
        public int RecipientUserId { get; set; }
        public string MessageContent { get; set; }
        public DateTime Time { get; set; }
    }
}
