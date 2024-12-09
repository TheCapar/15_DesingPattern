using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Mediator.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-04LJ0NG\\SQLEXPRESS; initial catalog=MediatorDesignPattern; integrated security=true;TrustServerCertificate=True;");
        }
        public DbSet<Product> Products { get; set; }
    }

}
