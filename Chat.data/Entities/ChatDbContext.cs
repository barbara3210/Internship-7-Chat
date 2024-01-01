using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
using Chat.data.Entities.Models;
using Chat.data.Seeds;
using System.Text.RegularExpressions;

namespace Chat.data.Entities
{
    public class ChatDbContext:DbContext
    {

        public DbSet<User> Users => Set<User>();
        public DbSet<ChatChannel> Channels => Set<ChatChannel>();
        public DbSet<Message> Messages => Set<Message>();
        public DbSet<ChannelMember> ChannelMembers => Set<ChannelMember>();


        public ChatDbContext(DbContextOptions<ChatDbContext> options) : base(options)
        {
        }

        public ChatDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChannelMember>()
                .HasKey(cm => new { cm.ChannelId, cm.UserId });

            modelBuilder.Entity<ChatChannel>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<ChatChannel>()
                .Property(c => c.ChannelName)
                .IsRequired();

           

            DbSeed.Seed(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
    }

    public class ChatDbContextFactory : IDesignTimeDbContextFactory<ChatDbContext>
    {
        public ChatDbContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddXmlFile("App.config")
                .Build();

            config.Providers
                .First()
                .TryGet("connectionStrings:add:ChatApp:connectionString", out var connectionString);

            var options = new DbContextOptionsBuilder<ChatDbContext>()
                .UseNpgsql(connectionString)
                .Options;

            return new ChatDbContext(options);
        }
    }
}
