using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Chat.data.Entities;

namespace Chat.domain.Factories;

public static class DbContextFactory
{
    public static ChatDbContext GetChatAppDbContext()
    {
        var options = new DbContextOptionsBuilder()
            .UseNpgsql(ConfigurationManager.ConnectionStrings["ChatApp"].ConnectionString)
            .Options;

        return new ChatDbContext(options);
    }
}