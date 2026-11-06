using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VotËs.Data;

namespace VotËs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly VotoDigitalContext _context;
        public AuthController(VotoDigitalContext context)
        {
            _context = context;
        }
        
       

    }
}
