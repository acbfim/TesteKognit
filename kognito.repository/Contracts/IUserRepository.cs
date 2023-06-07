using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kognito.domain;

namespace kognito.repository.Contracts
{
    public interface IUserRepository : IBaseRepository<User>
    {
    }
}