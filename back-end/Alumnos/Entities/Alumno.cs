using System.Diagnostics;
namespace Alumnos.Entities
{
    public class Alumno
    {

        public int IdAlumno { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        
        public string NombrePadre{ get; set; }

        public string Grado { get; set; }
        public string Seccion { get; set; }
        
        public DateTime FechaIngreso { get; set; }

        public List<Alumno> Alumnos { get; set; }

    }

}
