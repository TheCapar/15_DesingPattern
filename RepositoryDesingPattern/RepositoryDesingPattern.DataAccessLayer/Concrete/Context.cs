using Microsoft.EntityFrameworkCore;
using RepositoryDesingPattern.EntityLayer.Concrete;

namespace RepositoryDesingPattern.DataAccessLayer.Concrete
{
    //My db tables
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options):base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
