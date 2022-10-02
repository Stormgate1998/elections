using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using shared;
using elections.Controllers;
using Microsoft.AspNetCore.Mvc.Infrastructure;
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


        [HttpPost("{electionid}/isclosed")]
        public async Task IsClosed(int electionid, bool isClosed)
        {
            var qTask =  context.Elections.FirstOrDefaultAsync(e => e.Id == electionid);
            var row = await qTask;
            /*return*/
            row.Ballotingclosed = isClosed;
            await context.SaveChangesAsync();
        }
        /*
         * [HttpGet("{electionid}/vote/{voterid:int}")]
         * public string MakeVOteWithID(int electionId, int voterid){
         * 
         * return $"You want to make a vote for voterid {voterid}";
         * }
         * 
         * 
         */



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
        public async Task<bool> Ballotexists(int id)
        {
            var row = await  context.Elections.FirstOrDefaultAsync(e => e.Id == id);
            return row != null;
        }

        // PUT api/<ElectionController>/5
        [HttpPut("{id}")]
       /* public async Task<IActionResult> PutBallot(int id, Ballot ballot)
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
                if (!(await Ballotexists(id)))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
        }*/

        // DELETE api/<ElectionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpGet("{electionid}/offices")]
        public async Task<IActionResult> GetOfficesAndLocalities(int electionid){
            var offices = await context.Offices.
                Include(o => o.City).
                Include(o => o.County).
                Include(o => o.State).Select(o => new {
                    o.OfficeName,
                    Locality = 
                    o.City.CityName ??
                    o.County.CountyName ??
                    o.State.StateName
                })
                .ToListAsync();
            return Ok(offices);
        }
    }
}
