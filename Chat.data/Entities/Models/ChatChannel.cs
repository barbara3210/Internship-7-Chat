using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.data.Entities.Models
{
    public class ChatChannel
    {
        public ChatChannel(string name, int creator)
        {
            ChannelName = name;
            Creator = creator;

        }
        public int Id { get; set; }
        public string ChannelName { get; set; }
        public int Creator { get; set; }
    }
}
