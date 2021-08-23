using Microsoft.EntityFrameworkCore;

namespace CRUD
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext() 
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=helloappdb;Trusted_Connection=True");
        }

        public DbSet<User> Users { get; set; }

    }
}
