using Chat.data.Entities;
using Chat.data.Entities.Models;
using Chat.domain.Enums;

namespace Chat.domain.Repositories
{
    public class ChannelRepository : BaseRepository
    {
        public ChannelRepository(ChatDbContext dbContext) : base(dbContext)
        {
        }

        public ResponseResultType Add(ChatChannel channel)
        {
            DbContext.Channels.Add(channel);

            return SaveChanges();
        }
    }
}
