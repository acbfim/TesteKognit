

using kognito.domain;
using kognito.repository.Contracts;
using kognito.repository.Data;
using Microsoft.EntityFrameworkCore;

namespace kognito.repository
{
    public class WalletRepository : BaseRepository<Wallet>, IWalletRepository
    {
        public WalletRepository(DefaultContext Context) : base(Context)
        {
        }

        public async Task<List<Wallet>> GetAllByUserIdAsync(long userId)
        {
            var query = _context.UserWallet.AsQueryable();

            query = query 
                .Include(x => x.User);

            query = query
                .Where(x => x.UserId == userId)
                .AsNoTracking();
            
            return await query.ToListAsync();
                
        }
    }
}