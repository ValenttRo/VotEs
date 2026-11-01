using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VotËs.Data;
using VotES.Models;

namespace VotËs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VotanteController : ControllerBase
    {
        private readonly VotoDigitalContext _context;
        
        public VotanteController(VotoDigitalContext context)
        {
            _context = context;

        }
        [HttpGet]
        public async Task<ActionResult<IEnumerator<VotanteEN>>> GetAll(){
            var VotantesLista = await _context.votante.ToListAsync();
            return Ok(VotantesLista);
        }    

    }
}
