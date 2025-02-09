using Alumnos.Entities;
using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace Alumnos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }
        
        public DbSet<Alumno> Alumnos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>()
                .HasKey(a => a.IdAlumno);

            
            modelBuilder.Entity<Alumno>().HasData(
                new Alumno { IdAlumno = 1, Nombre = "Juan Pérez", FechaNacimiento = new DateTime(2005, 5, 10), NombrePadre = "José Pérez", Grado = "5to", Seccion = "A", FechaIngreso = new DateTime(2023, 1, 15) },
                new Alumno { IdAlumno = 2, Nombre = "María García", FechaNacimiento = new DateTime(2006, 8, 20), NombrePadre = "Ana García", Grado = "4to", Seccion = "B", FechaIngreso = new DateTime(2022, 2, 22) },
                new Alumno { IdAlumno = 3, Nombre = "Luis Rodríguez", FechaNacimiento = new DateTime(2007, 3, 5), NombrePadre = "Carlos Rodríguez", Grado = "3ro", Seccion = "C", FechaIngreso = new DateTime(2021, 3, 1) },
                new Alumno { IdAlumno = 4, Nombre = "Ana Martínez", FechaNacimiento = new DateTime(2008, 11, 15), NombrePadre = "Sofía Martínez", Grado = "2do", Seccion = "A", FechaIngreso = new DateTime(2020, 4, 10) },
                new Alumno { IdAlumno = 5, Nombre = "Pedro Sánchez", FechaNacimiento = new DateTime(2009, 6, 25), NombrePadre = "Miguel Sánchez", Grado = "1ro", Seccion = "B", FechaIngreso = new DateTime(2019, 5, 20) },
                new Alumno { IdAlumno = 6, Nombre = "Sofía López", FechaNacimiento = new DateTime(2004, 9, 30), NombrePadre = "Elena López", Grado = "6to", Seccion = "C", FechaIngreso = new DateTime(2024, 6, 1) },
                new Alumno { IdAlumno = 7, Nombre = "Carlos Díaz", FechaNacimiento = new DateTime(2003, 4, 5), NombrePadre = "Laura Díaz", Grado = "7mo", Seccion = "A", FechaIngreso = new DateTime(2023, 7, 15) },
                new Alumno { IdAlumno = 8, Nombre = "Elena Fernández", FechaNacimiento = new DateTime(2002, 12, 10), NombrePadre = "Juan Fernández", Grado = "8vo", Seccion = "B", FechaIngreso = new DateTime(2022, 8, 22) },
                new Alumno { IdAlumno = 9, Nombre = "Miguel González", FechaNacimiento = new DateTime(2001, 7, 20), NombrePadre = "María González", Grado = "9no", Seccion = "C", FechaIngreso = new DateTime(2021, 9, 1) },
                new Alumno { IdAlumno = 10, Nombre = "Laura Ruiz", FechaNacimiento = new DateTime(2000, 2, 15), NombrePadre = "Pedro Ruiz", Grado = "10mo", Seccion = "A", FechaIngreso = new DateTime(2020, 10, 10) }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}