using EFcore.Models;

namespace EFcore.Repositories
{
    public interface IUnitOfWork
    {
        BaseRepository<T> GetRepository<T>() where T : BaseEntity<int>;
        int SaveChanges();
        IDatabaseTransaction GetDatabaseTransaction();
    }
}