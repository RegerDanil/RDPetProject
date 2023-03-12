using Microsoft.EntityFrameworkCore;

namespace SportStoreRD.Models
{
    public class AppIdentityDbContext : DbContext
    {
        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options)
           : base(options) { }
    }
}
