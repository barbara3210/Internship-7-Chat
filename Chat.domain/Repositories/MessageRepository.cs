using Chat.data.Entities;
using Chat.domain.Enums;
using Chat.data.Entities.Models;
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

        public ResponseResultType Add(Message message)
        {
            DbContext.Messages.Add(message);

            return SaveChanges();
        }
      
        public ResponseResultType Delete(int id)
        {
            var messToDelete = DbContext.Messages.Find(id);
            if (messToDelete is null)
            {
                return ResponseResultType.NotFound;
            }

            DbContext.Messages.Remove(messToDelete);

            return SaveChanges();
        }


        public Message? GetById(int id) => DbContext.Messages.FirstOrDefault(l => l.Id == id);


    }
}
