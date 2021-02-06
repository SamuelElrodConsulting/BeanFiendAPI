using BeanFiendAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace BeanFiendAPI.Persistence.SQLite
{
    public class BeanFiendSQLiteDbContext : DbContext
    {
        public BeanFiendSQLiteDbContext(DbContextOptions options)
            : base(options)
        { }

        public DbSet<Beaner> Beaners { get; set; }
        public DbSet<Coffee> Coffees { get; set; }
    }
}