using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kognito.domain;
using kognito.repository.Contracts;
using kognito.service.Contracts;

namespace kognito.service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepo;

        public UserService(IUserRepository userRepo)
        {
            this.userRepo = userRepo;
        }
        public async Task<User> AddAsync(User user)
        {
            try
            {
                this.userRepo.Add(user);

                if(await this.userRepo.SaveChangesAsync())
                    return user;
                
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