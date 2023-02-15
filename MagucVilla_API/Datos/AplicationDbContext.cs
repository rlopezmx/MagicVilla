using MagucVilla_API.Modelos;
using Microsoft.EntityFrameworkCore;

namespace MagucVilla_API.Datos
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Villa> Villas { get; set; }

        public DbSet<Productos> Productos { get; set; }

        //public DbSet<spProductos_Listado> spProductos_Listado { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Nombre = "Villa Real",
                    Detalle = "Detalle de la villa ...",
                    ImagenUrl = "",
                    Ocupantes = 5,
                    MetrosCuadrados = 50,
                    Tarifa =200,
                    Amenidad ="",
                    FechaCreacion =DateTime.Now,
                    FechaActualizacion=DateTime.Now 
                },
                new Villa()
                {
                    Id = 2,
                    Nombre = "Villa Tropical",
                    Detalle = "Detalle de la villa ...",
                    ImagenUrl = "",
                    Ocupantes = 2,
                    MetrosCuadrados = 50,
                    Tarifa = 500,
                    Amenidad = "",
                    FechaCreacion = DateTime.Now,
                    FechaActualizacion = DateTime.Now

                },
                new Villa()
                {
                    Id = 3,
                    Nombre = "Villa sencilla",
                    Detalle = "Detalle de la villa ...",
                    ImagenUrl = "",
                    Ocupantes = 15,
                    MetrosCuadrados = 100,
                    Tarifa = 150,
                    Amenidad = "",
                    FechaCreacion = DateTime.Now,
                    FechaActualizacion = DateTime.Now
                }
             );

            modelBuilder.Entity<Productos>();

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<spProductos_Listado>()
                        .ToSqlQuery("EXEC spProductos_Listado");
        }

        //protected override void OnModelCrearing(ModelBuilder modelBuider) => modelBuider.Entity<Producto>();
    }
}
