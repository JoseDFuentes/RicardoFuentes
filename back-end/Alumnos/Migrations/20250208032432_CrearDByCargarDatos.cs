using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Alumnos.Migrations
{
    /// <inheritdoc />
    public partial class CrearDByCargarDatos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alumnos",
                columns: table => new
                {
                    IdAlumno = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    NombrePadre = table.Column<string>(type: "TEXT", nullable: false),
                    Grado = table.Column<string>(type: "TEXT", nullable: false),
                    Seccion = table.Column<string>(type: "TEXT", nullable: false),
                    FechaIngreso = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AlumnoIdAlumno = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alumnos", x => x.IdAlumno);
                    table.ForeignKey(
                        name: "FK_Alumnos_Alumnos_AlumnoIdAlumno",
                        column: x => x.AlumnoIdAlumno,
                        principalTable: "Alumnos",
                        principalColumn: "IdAlumno");
                });

            migrationBuilder.InsertData(
                table: "Alumnos",
                columns: new[] { "IdAlumno", "AlumnoIdAlumno", "FechaIngreso", "FechaNacimiento", "Grado", "Nombre", "NombrePadre", "Seccion" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "5to", "Juan Pérez", "José Pérez", "A" },
                    { 2, null, new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "4to", "María García", "Ana García", "B" },
                    { 3, null, new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2007, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "3ro", "Luis Rodríguez", "Carlos Rodríguez", "C" },
                    { 4, null, new DateTime(2020, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "2do", "Ana Martínez", "Sofía Martínez", "A" },
                    { 5, null, new DateTime(2019, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "1ro", "Pedro Sánchez", "Miguel Sánchez", "B" },
                    { 6, null, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2004, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "6to", "Sofía López", "Elena López", "C" },
                    { 7, null, new DateTime(2023, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2003, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "7mo", "Carlos Díaz", "Laura Díaz", "A" },
                    { 8, null, new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2002, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "8vo", "Elena Fernández", "Juan Fernández", "B" },
                    { 9, null, new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2001, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "9no", "Miguel González", "María González", "C" },
                    { 10, null, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "10mo", "Laura Ruiz", "Pedro Ruiz", "A" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alumnos_AlumnoIdAlumno",
                table: "Alumnos",
                column: "AlumnoIdAlumno");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alumnos");
        }
    }
}
