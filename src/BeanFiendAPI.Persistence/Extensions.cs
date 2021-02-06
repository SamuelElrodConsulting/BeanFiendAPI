using BeanFiendAPI.Persistence.SQLite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BeanFiendAPI.Persistence
{
    public static class Extensions
    {
        public static IServiceCollection AddBeanerSQLite(this IServiceCollection services, string x)
        {
            return
                services
                    .AddDbContext<BeanFiendSQLiteDbContext>(options =>
                    {
                        options.UseSqlite(x);
                    });
        }
    }
}