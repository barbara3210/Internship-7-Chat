using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.data.Entities.Models
{
    public class Channel
    {
        public Channel(string name, int creator)
        {
            ChannelName = name;
            CreatorUserId = creator;

        }
        public int Id { get; set; }
        public string ChannelName { get; set; }
        public int CreatorUserId { get; set; }
    }
}
