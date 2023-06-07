

using kognito.domain;

namespace kognito.service.Contracts
{
    public interface IWalletService
    {
        Task<List<Wallet>> GetAllByUserIdAsync(long userId);
        Task<Wallet> AddAsync(Wallet wallet);
    }
}