using Microsoft.EntityFrameworkCore;

namespace Crudv4.Models
{
    public class BancoDeDados : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=DESKTOP-CM8F2OC\SQLEXPRESS;Database=Crudv4;Integrated Security=True");
        }
    }
}
