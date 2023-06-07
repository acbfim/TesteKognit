
namespace kognito.repository.Contracts
{
    public interface IBaseRepository<T> where T : class
    {
        public void Add<T>(T entity) where T : class;
        public void AddRange<T>(IEnumerable<T> entities) where T : class;
        public Task<bool> SaveChangesAsync();
    }
}