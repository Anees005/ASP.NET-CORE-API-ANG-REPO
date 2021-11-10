using Demo_Angular_Core.Data;
using Demo_Angular_Core.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_Angular_Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly FootballDbContext _footballDbContext;

        public PlayerController(FootballDbContext footballDbContext)
        {
            _footballDbContext = footballDbContext;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Player>>> GetPlayers()
        {
            return await _footballDbContext.Players.ToListAsync();
        }

    }
}
