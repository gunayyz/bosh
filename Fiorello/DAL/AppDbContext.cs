using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace Fiorello.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options)
    }
}
