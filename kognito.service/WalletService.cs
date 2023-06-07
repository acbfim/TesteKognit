
using kognito.domain;
using kognito.repository.Contracts;
using kognito.service.Contracts;

namespace kognito.service
{
    public class WalletService : IWalletService
    {
        private readonly IWalletRepository repo;

        public WalletService(IWalletRepository repo)
        {
            this.repo = repo;
        }
        public Task<List<Wallet>> GetAllByUserIdAsync(long userId)
        {
            try
            {
                return this.repo.GetAllByUserIdAsync(userId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error GetAllByUserIdAsync: {ex.Message}");
                return null;
            }
        }

        public async Task<Wallet> AddAsync(Wallet wallet)
        {
            try
            {
                this.repo.Add(wallet);

                if(await this.repo.SaveChangesAsync())
                    return wallet;
                
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error AddAsync: {ex.Message}");
                return null;
            }
        }
    }
}