using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.data.Entities.Models
{
    public class ChannelMember
    {

        public ChannelMember(int channel, int user)
        {
            ChannelId = channel;
            UserId = user;
            
        }
        public int ChannelId { get; set; }
        public int UserId { get; set; }
    }
}
