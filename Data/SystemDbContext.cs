

using Microsoft.EntityFrameworkCore;
using SystemManager.Entities;

//using Microsoft.EntityFrameworkCore.SqlServer;

namespace SystemManager.Data
{
    public class SystemDbContext : DbContext
    {
        
        public DbSet<User> Users { get; set; }
        public DbSet<Machine> Machines { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder options) 
                =>  options.UseSqlServer("Server=localhost;Database=SystemManager;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True;\n");
    }
}