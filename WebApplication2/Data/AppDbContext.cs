﻿using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

       public DbSet<Producto> Productos { get; set; }  // Definimos el DbSet para la tabla productos
        public DbSet<Producto> Clientes { get; set; }

<<<<<<< HEAD


<<<<<<< HEAD
=======
       public DbSet<Proveedor> Provedores { get; set; }


>>>>>>> 9ecdc814041d2d2e3a22179c38645361e88f3561
=======
       public DbSet<Proveedor> Provedores { get; set; }


>>>>>>> 1fe8ccabcf910de1c112e52fcc0a1d6f60754de2
    }
}
