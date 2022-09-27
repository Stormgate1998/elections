using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using shared;
using elections.Controllers;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace elections.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElectionController : ControllerBase
    {
        // GET: api/<ElectionController>
        private readonly InstantRunoffContext context;

        public ElectionController(InstantRunoffContext context)
        {
            this.context = context;
        }
        
        
        [HttpGet("{electionid}/isopen")]
            public async Task<string> IsOpen(int electionid)
        {
            var row = context.Elections.Where(e => e.Id == electionid);
            return row.Ballotingclosed;
            await context.SaveChangesAsync();
        }
        
        
        
        
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ElectionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ElectionController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
        public bool Ballotexists(int id)
        {

        }

        // PUT api/<ElectionController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBallot(int id, Ballot ballot)
        {
            if (id != ballot.Id)
            {
                return BadRequest();
            }

            context.Entry(ballot).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BallotExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
        }

        // DELETE api/<ElectionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
