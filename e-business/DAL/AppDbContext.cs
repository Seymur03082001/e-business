using Microsoft.EntityFrameworkCore;

namespace e_business.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options) { }
    }
}
