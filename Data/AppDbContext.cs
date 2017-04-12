
using DOTNET_APPS.Models;
using Microsoft.EntityFrameworkCore;

namespace DOTNET_APPS.Data
{
    public class AppDbContext : DbContext
    {
        public  AppDbContext (DbContextOptions<AppDbContext> options )
        :base(options)
        {}

        public DbSet<Person> People { get; set; }

    }
}