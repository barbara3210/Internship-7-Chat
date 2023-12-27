using Chat.data.Entities;
using Chat.domain.Enums;

namespace Chat.domain.Repositories
{
    public class BaseRepository
    {
        protected readonly ChatDbContext DbContext;

        public BaseRepository(ChatDbContext dbContext)
        {
            DbContext = dbContext;
        }
        protected ResponseResultType SaveChanges()
        {
            var hasChanges = DbContext.SaveChanges() > 0;
            if (hasChanges)
                return ResponseResultType.Success;

            return ResponseResultType.NoChanges;
        }
    }
}
