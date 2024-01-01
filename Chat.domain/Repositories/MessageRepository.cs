using Chat.data.Entities;
using Chat.domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.domain.Repositories
{
    public class MessageRepository : BaseRepository
    {
        public MessageRepository(ChatDbContext dbContext) : base(dbContext)
        {
        }
        

    }
}
