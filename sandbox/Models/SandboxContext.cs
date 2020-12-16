using Microsoft.EntityFrameworkCore;
using sandbox.Models;

namespace BikePath.Models
{
    public class SandboxContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public SandboxContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("workstation id=sandbox-db.mssql.somee.com;packet size=4096;user id=ivan1tarasov_SQLLogin_1;pwd=h5dxkd38aj;data source=sandbox-db.mssql.somee.com;persist security info=False;initial catalog=sandbox-db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
        }
    }
}