using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Alumnos.Entities;
using Microsoft.EntityFrameworkCore;
using Alumnos.DTO;

namespace Alumnos.Controller
{
    [ApiController]
    [Route("api/[controller]")]
  
    public class AlumnosController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        //private readonly IAuthorizationService authorizationService;

        public AlumnosController(ApplicationDbContext _context, IMapper _mapper)
        {
            this.mapper = _mapper;
            this.context = _context;
        }

      
        [HttpGet]
         public async Task<List<AlumnoDTO>> Get()
        {
             var alumnos = await context.Alumnos.ToListAsync();
            return mapper.Map<List<AlumnoDTO>>(alumnos);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<AlumnoDTO>> GetAlumno([FromRoute] int id)
        {
            var alumnos = await context.Alumnos.ToListAsync();
            
            var alumno = alumnos.FirstOrDefault(a => a.IdAlumno == id);

            if (alumno == null)
            {
                return NotFound();
            }

            return mapper.Map<AlumnoDTO>(alumno);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] AlumnoDTO alumnoDTO)
        {
            var existeAlumnoConId = await context.Alumnos.AnyAsync(a => a.IdAlumno == alumnoDTO.IdAlumno);

            if (existeAlumnoConId)
            {
                return BadRequest($"Ya existe un alumno con el Id {alumnoDTO.IdAlumno}");
            }

            var alumno = mapper.Map<Alumno>(alumnoDTO);

            context.Add(alumno);

            await context.SaveChangesAsync();

            var alumnoAuxDTO = mapper.Map<AlumnoDTO>(alumno);

            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] AlumnoDTO alumnoDTO)
        {
            var existeAlumnoConId = await context.Alumnos.AnyAsync(a => a.IdAlumno == alumnoDTO.IdAlumno);

            if (!existeAlumnoConId)
            {
                return NotFound();
            }

            var alumno = mapper.Map<Alumno>(alumnoDTO);

            context.Update(alumno);

            await context.SaveChangesAsync();

            
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existeAlumnoConId = await context.Alumnos.AnyAsync(a => a.IdAlumno == id);

            if (!existeAlumnoConId)
            {
                return NotFound();
            }

            

            context.Remove(new Alumno{IdAlumno = id});

            await context.SaveChangesAsync();

            
            return NoContent();
        }



    }

}