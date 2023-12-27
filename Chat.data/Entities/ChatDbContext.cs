using Chat.data.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Chat.data.Entities.Models;
using Chat.data.Seeds;
using System.Threading.Channels;

namespace Chat.data.Entities
{
    internal class ChatDbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<System.Threading.Channels.Channel> Channels { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<ChannelMember> ChannelMembers { get; set; }


        public ChatDbContext(DbContextOptions<ChatDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ChatDb;Trusted_Connection=True;");
        }
    }
}
