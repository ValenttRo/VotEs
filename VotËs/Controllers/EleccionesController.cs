using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;
using VotËs.Data;
using VotES.Models;

namespace VotËs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EleccionesController : ControllerBase
    {
        private readonly VotoDigitalContext _context;
        public EleccionesController(VotoDigitalContext context)
        {
            _context = context;
        }
        [HttpGet("Disponibles")]
        public async Task<IActionResult> Disponibles()
        {


            var EleccionesDisponibles = await _context.elecciones
                .Where(P=> P.EstadoDeEleccion == EleccionesEN.Estado.Open).ToListAsync ();
            
            return Ok(EleccionesDisponibles);
        }
    }
}
