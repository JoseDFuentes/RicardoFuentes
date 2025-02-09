﻿// <auto-generated />
using System;
using Alumnos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Alumnos.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.1");

            modelBuilder.Entity("Alumnos.Entities.Alumno", b =>
                {
                    b.Property<int>("IdAlumno")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AlumnoIdAlumno")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Grado")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NombrePadre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Seccion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IdAlumno");

                    b.HasIndex("AlumnoIdAlumno");

                    b.ToTable("Alumnos");

                    b.HasData(
                        new
                        {
                            IdAlumno = 1,
                            FechaIngreso = new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaNacimiento = new DateTime(2005, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Grado = "5to",
                            Nombre = "Juan Pérez",
                            NombrePadre = "José Pérez",
                            Seccion = "A"
                        },
                        new
                        {
                            IdAlumno = 2,
                            FechaIngreso = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaNacimiento = new DateTime(2006, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Grado = "4to",
                            Nombre = "María García",
                            NombrePadre = "Ana García",
                            Seccion = "B"
                        },
                        new
                        {
                            IdAlumno = 3,
                            FechaIngreso = new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaNacimiento = new DateTime(2007, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Grado = "3ro",
                            Nombre = "Luis Rodríguez",
                            NombrePadre = "Carlos Rodríguez",
                            Seccion = "C"
                        },
                        new
                        {
                            IdAlumno = 4,
                            FechaIngreso = new DateTime(2020, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaNacimiento = new DateTime(2008, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Grado = "2do",
                            Nombre = "Ana Martínez",
                            NombrePadre = "Sofía Martínez",
                            Seccion = "A"
                        },
                        new
                        {
                            IdAlumno = 5,
                            FechaIngreso = new DateTime(2019, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaNacimiento = new DateTime(2009, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Grado = "1ro",
                            Nombre = "Pedro Sánchez",
                            NombrePadre = "Miguel Sánchez",
                            Seccion = "B"
                        },
                        new
                        {
                            IdAlumno = 6,
                            FechaIngreso = new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaNacimiento = new DateTime(2004, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Grado = "6to",
                            Nombre = "Sofía López",
                            NombrePadre = "Elena López",
                            Seccion = "C"
                        },
                        new
                        {
                            IdAlumno = 7,
                            FechaIngreso = new DateTime(2023, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaNacimiento = new DateTime(2003, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Grado = "7mo",
                            Nombre = "Carlos Díaz",
                            NombrePadre = "Laura Díaz",
                            Seccion = "A"
                        },
                        new
                        {
                            IdAlumno = 8,
                            FechaIngreso = new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaNacimiento = new DateTime(2002, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Grado = "8vo",
                            Nombre = "Elena Fernández",
                            NombrePadre = "Juan Fernández",
                            Seccion = "B"
                        },
                        new
                        {
                            IdAlumno = 9,
                            FechaIngreso = new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaNacimiento = new DateTime(2001, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Grado = "9no",
                            Nombre = "Miguel González",
                            NombrePadre = "María González",
                            Seccion = "C"
                        },
                        new
                        {
                            IdAlumno = 10,
                            FechaIngreso = new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaNacimiento = new DateTime(2000, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Grado = "10mo",
                            Nombre = "Laura Ruiz",
                            NombrePadre = "Pedro Ruiz",
                            Seccion = "A"
                        });
                });

            modelBuilder.Entity("Alumnos.Entities.Alumno", b =>
                {
                    b.HasOne("Alumnos.Entities.Alumno", null)
                        .WithMany("Alumnos")
                        .HasForeignKey("AlumnoIdAlumno");
                });

            modelBuilder.Entity("Alumnos.Entities.Alumno", b =>
                {
                    b.Navigation("Alumnos");
                });
#pragma warning restore 612, 618
        }
    }
}
