using Microsoft.EntityFrameworkCore;
using ProjeIT.Models;

namespace ProjeIT.Context
{
    public class ProjeITContext:DbContext
    {
        public ProjeITContext(DbContextOptions options):base(options)
        {

        }
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (@"Server=(localdb)\mssqllocaldb;Database=ProjeIT;Trusted_Connection=true");

        }*/
        public DbSet<Department> Department { get; set; }
        public DbSet<Personnel> Personnel { get; set; }
    }
}
