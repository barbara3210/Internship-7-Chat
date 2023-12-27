using Chat.domain.Repositories;


namespace Chat.domain.Factories;

public class RepositoryFactory
{
    public static TRepository Create<TRepository>()
        where TRepository : BaseRepository
    {
        var dbContext = DbContextFactory.GetChatAppDbContext();
        var repositoryInstance = Activator.CreateInstance(typeof(TRepository), dbContext) as TRepository;

        return repositoryInstance!;
    }
}
