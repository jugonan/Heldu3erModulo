using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Heldu.Models;

namespace Heldu.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Heldu.Models.Categoria> Categoria { get; set; }
        public DbSet<Heldu.Models.GustoUsuario> GustoUsuario { get; set; }
        public DbSet<Heldu.Models.Mercado> Mercado { get; set; }
        public DbSet<Heldu.Models.Producto> Producto { get; set; }
        public DbSet<Heldu.Models.ProductoCategoria> ProductoCategoria { get; set; }
        public DbSet<Heldu.Models.ProductoVendedor> ProductoVendedor { get; set; }
        public DbSet<Heldu.Models.Ubicacion> Ubicacion { get; set; }
        public DbSet<Heldu.Models.Usuario> Usuario { get; set; }
        public DbSet<Heldu.Models.Vendedor> Vendedor { get; set; }
    }
}
