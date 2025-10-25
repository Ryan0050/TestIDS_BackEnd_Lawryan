using Microsoft.EntityFrameworkCore;
using TestIDS_Lawryan.Models;

namespace TestIDS_Lawryan.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<TrTransaction> TrTransaction { get; set; }
        public DbSet<MsStatus> MsStatus { get; set; }
    }
}