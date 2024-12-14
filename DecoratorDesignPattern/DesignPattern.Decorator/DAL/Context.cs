

using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Decorator.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-04LJ0NG\\SQLEXPRESS; initial catalog=DecoratorDesingPattern; integrated security=true;TrustServerCertificate=True;");
        }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Notifier> Notifiers { get; set; }
    }
}
