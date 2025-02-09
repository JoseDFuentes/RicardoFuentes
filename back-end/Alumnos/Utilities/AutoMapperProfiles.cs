using Alumnos.DTO;
using Alumnos.Entities;
using AutoMapper;
namespace Alumnos.Utilities
{
    public class AlumnoProfile : Profile
    {
        public AlumnoProfile()
        {
            CreateMap<Alumno, AlumnoDTO>();
            CreateMap<AlumnoDTO, Alumno>();
        }

    }
}