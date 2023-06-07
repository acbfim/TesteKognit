using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kognito.domain;
using kognito.repository.Data;

namespace kognito.repository.Contracts
{
    public interface IWalletRepository : IBaseRepository<Wallet>
    {
        Task<List<Wallet>> GetAllByUserIdAsync(long userId);
    }
}