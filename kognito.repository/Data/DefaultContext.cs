
using kognito.domain;
using Microsoft.EntityFrameworkCore;

namespace kognito.repository.Data
{
    public class DefaultContext : DbContext
    {
        public DefaultContext(DbContextOptions<DefaultContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Wallet> UserWallet { get; set; }
    }
}