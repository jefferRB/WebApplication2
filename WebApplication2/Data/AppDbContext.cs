using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

       public DbSet<Producto> Productos { get; set; }  // Definimos el DbSet para la tabla productos
       



<<<<<<< HEAD
=======
       public DbSet<Proveedor> Provedores { get; set; }


>>>>>>> 9ecdc814041d2d2e3a22179c38645361e88f3561
    }
}
