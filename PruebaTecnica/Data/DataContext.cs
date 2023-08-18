
using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Model;

namespace PruebaTecnica.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DataContext() { }


        public DbSet<Person> People { get; set; }
    }
}
