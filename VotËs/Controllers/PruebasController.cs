using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VotËs.Data;
using VotËs.Mappers;
using VotES.Models;

namespace VotËs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PruebasController : ControllerBase
    {
        private readonly VotoDigitalContext _context;
        
        public PruebasController(VotoDigitalContext context)
        {
            _context = context;

        }
        [HttpGet]
        /*public async Task<ActionResult<IEnumerator<VotanteEN>>> GetAll(){
            var VotantesLista = await _context.votante.ToListAsync();
            return Ok(VotantesLista);
        }*/
        public async Task<ActionResult<IEnumerator<EleccionesEN>>> GetAll()
        {
            var elecciones = await _context.elecciones
                 .Include(e =>   e.TipoEleccion)
                 .ToListAsync();

            var resultado = elecciones
                .Select(e => e.ToEleccionesDTO())
                .ToList();

            return Ok(resultado);
        }

    }
}
