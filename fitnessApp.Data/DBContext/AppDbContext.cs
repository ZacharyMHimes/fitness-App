using fitnessApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
namespace fitnessApp.Data.DBContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
        public DbSet<User> Users { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<LogBook> Logbooks {get; set;}
    
    }
}