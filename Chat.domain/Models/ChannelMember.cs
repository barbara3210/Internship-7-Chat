using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.domain.Models
{
    public class ChannelMember
    {
        public int ChannelId { get; set; }
        public int UserId { get; set; }
    }
}
