// <auto-generated />
using System;
using MagucVilla_API.Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MagucVilla_API.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    partial class AplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MagucVilla_API.Modelos.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Amenidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Detalle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaActualizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagenUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MetrosCuadrados")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ocupantes")
                        .HasColumnType("int");

                    b.Property<double>("Tarifa")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenidad = "",
                            Detalle = "Detalle de la villa ...",
                            FechaActualizacion = new DateTime(2023, 2, 3, 12, 20, 59, 134, DateTimeKind.Local).AddTicks(2811),
                            FechaCreacion = new DateTime(2023, 2, 3, 12, 20, 59, 134, DateTimeKind.Local).AddTicks(2776),
                            ImagenUrl = "",
                            MetrosCuadrados = 50,
                            Nombre = "Villa Real",
                            Ocupantes = 5,
                            Tarifa = 200.0
                        },
                        new
                        {
                            Id = 2,
                            Amenidad = "",
                            Detalle = "Detalle de la villa ...",
                            FechaActualizacion = new DateTime(2023, 2, 3, 12, 20, 59, 134, DateTimeKind.Local).AddTicks(2816),
                            FechaCreacion = new DateTime(2023, 2, 3, 12, 20, 59, 134, DateTimeKind.Local).AddTicks(2814),
                            ImagenUrl = "",
                            MetrosCuadrados = 50,
                            Nombre = "Villa Tropical",
                            Ocupantes = 2,
                            Tarifa = 500.0
                        },
                        new
                        {
                            Id = 3,
                            Amenidad = "",
                            Detalle = "Detalle de la villa ...",
                            FechaActualizacion = new DateTime(2023, 2, 3, 12, 20, 59, 134, DateTimeKind.Local).AddTicks(2820),
                            FechaCreacion = new DateTime(2023, 2, 3, 12, 20, 59, 134, DateTimeKind.Local).AddTicks(2819),
                            ImagenUrl = "",
                            MetrosCuadrados = 100,
                            Nombre = "Villa sencilla",
                            Ocupantes = 15,
                            Tarifa = 150.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
