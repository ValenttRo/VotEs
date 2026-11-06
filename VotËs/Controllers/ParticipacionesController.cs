using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VotËs.Data;
using VotËs.Models;

namespace VotËs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipacionesController : ControllerBase
    {
        private readonly VotoDigitalContext _context;
        public ParticipacionesController(VotoDigitalContext context)
        {
            _context = context;
        }
        [HttpGet("{IdVotante}/{IdEleccion}")]
        public async Task<IActionResult> MisParticiapaciones(int IdVotante, int IdEleccion)
        {
            
            var Participacion = await _context.participacion_votante.FindAsync(IdVotante, IdEleccion);
            var pp = await _context.participacion_votante.ToListAsync();
            if (Participacion == null) 
                return NotFound();
            return Ok(Participacion);
        }
    }
}
