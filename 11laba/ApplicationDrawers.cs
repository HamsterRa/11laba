using Microsoft.EntityFrameworkCore;

namespace _11laba
{
   public class ApplicationDrawers:DbContext
    {
        public DbSet<Drawer> Drawers { get; set; }
        public ApplicationDrawers() 
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=databaseDrawers;Trusted_Connection=True;");
        }
    }
}
