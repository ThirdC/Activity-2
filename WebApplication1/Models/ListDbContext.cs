using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class ListDbContext : DbContext
    {
        public DbSet<List> Lists { get; set; }

        public ListDbContext(DbContextOptions<ListDbContext> option)
            : base(option)

        {

        }
    }
}
