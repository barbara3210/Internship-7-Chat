using Chat.data.Entities;
using Chat.data.Entities.Models;
using Chat.domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace Chat.domain.Repositories
{
    public class UserRepository:BaseRepository
    {
        public UserRepository(ChatDbContext dbContext) : base(dbContext)
        {
        }

        public ResponseResultType Add(User user)
        {
            DbContext.Users.Add(user);

            return SaveChanges();
        }
        public ResponseResultType Update(User user, int id)
        {
            var userToUpdate = DbContext.Users.Find(id);
            if (userToUpdate is null)
            {
                return ResponseResultType.NotFound;
            }

            userToUpdate.FirstName = user.FirstName;
            userToUpdate.LastName = user.LastName;

            return SaveChanges();
        }
        public ResponseResultType Delete(int id)
        {
            var userToDelete = DbContext.Users.Find(id);
            if (userToDelete is null)
            {
                return ResponseResultType.NotFound;
            }

            DbContext.Users.Remove(userToDelete);

            return SaveChanges();
        }

        public User? GetById(int id) => DbContext.Users.FirstOrDefault(u => u.Id == id);
        public ICollection<User> GetAll() => DbContext.Users.ToList();

        
    }
}
