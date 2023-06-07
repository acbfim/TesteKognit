using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kognito.domain;

namespace kognito.service.Contracts
{
    public interface IUserService
    {
        Task<User> AddAsync(User user);

    }
}