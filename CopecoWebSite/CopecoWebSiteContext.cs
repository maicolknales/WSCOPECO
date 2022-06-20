using CopecoWebSite.Models;
using Microsoft.EntityFrameworkCore;

namespace CopecoWebSite
{
    public class CopecoWebSiteContext : DbContext
    {
        public CopecoWebSiteContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=copecows;user=root;password=;convert zero datetime=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .HasOne(p => p.Rol);
            //.WithMany(b => b.usu);
        }


        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<CopecoWebSite.Models.Empleados>? Empleados { get; set; }

        public DbSet<CopecoWebSite.Models.Inventario>? Inventario { get; set; }

        public DbSet<CopecoWebSite.Models.Noticia>? Noticias { get; set; }

        public DbSet<CopecoWebSite.Models.SliderHome>? SliderHome { get; set; }

        public DbSet<CopecoWebSite.Models.Rol>? Roles { get; set; }
    }
}
