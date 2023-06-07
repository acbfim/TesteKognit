

using kognito.repository.Contracts;
using kognito.repository.Data;

namespace kognito.repository
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly DefaultContext _context;

        public BaseRepository(DefaultContext Context)
        {
            _context = Context;
        }


        public void Add<T>(T entity) where T : class
        {
            _context.AddAsync(entity);
        }

        public void AddRange<T>(IEnumerable<T> entities) where T : class
        {
            _context.AddRangeAsync(entities);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
    }
}