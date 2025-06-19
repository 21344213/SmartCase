using Microsoft.EntityFrameworkCore;
using SmartDomain;

namespace ISmartInfrasture
{
    public class BaseDataDbContext : DbContext

    {
        public BaseDataDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Apperoal> apperoals { get; set; }
    }
}
