using Microsoft.EntityFrameworkCore;

namespace ASP.NET.Practice.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
    }
}
