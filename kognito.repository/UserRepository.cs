using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kognito.domain;
using kognito.repository.Contracts;
using kognito.repository.Data;

namespace kognito.repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(DefaultContext Context) : base(Context)
        {
        }
    }
}