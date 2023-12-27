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
    public class UserRepository:BaseRepository
    {
        public UserRepository(ChatDbContext dbContext) : base(dbContext)
        {
        }

        public User GetUserByEmail(string email)
        {
            return dbContext.Users.FirstOrDefault(u => u.Email == email);
        }
    }
}
