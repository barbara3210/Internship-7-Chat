using Chat.data.Entities;
using Chat.data.Entities.Models;
using Chat.domain.Enums;
using System.Text.RegularExpressions;
using System.Threading.Channels;

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

        public ResponseResultType Delete(int id)
        {
            var chatToDelete = DbContext.Channels.Find(id);
            if (chatToDelete is null)
            {
                return ResponseResultType.NotFound;
            }

            DbContext.Channels.Remove(chatToDelete);

            return SaveChanges();
        }
        public ResponseResultType Update(ChatChannel channel, int id)
        {
            var chatToUpdate = DbContext.Channels.Find(id);
            if (chatToUpdate is null)
            {
                return ResponseResultType.NotFound;
            }

            chatToUpdate.ChannelName = channel.ChannelName;

            return SaveChanges();
        }
        public ChatChannel? GetById(int id) => DbContext.Channels.FirstOrDefault(c => c.Id == id);

        public ICollection<ChatChannel> GetAll() => DbContext.Channels.ToList();


    }
}
