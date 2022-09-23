using elections.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace elections.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatabaseController : ControllerBase
    {
        private readonly InstantRunoffContext instantRunoffContext;

        public DatabaseController(InstantRunoffContext instantRunoffContext)
        {
            this.instantRunoffContext = instantRunoffContext;
        }

        [HttpGet("[action]")]
        public async Task<int> RowCount()
        {
            var rowCount = await instantRunoffContext.Ballots.CountAsync();
            return rowCount;
        }
    }
}
